using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErYaLinkCalc
{
    class ParamHelper
    {
        /// <summary>
        /// string:参数 clazzId
        /// </summary>
        public  string clazzId { get; set; }
        /// <summary>
        /// string:参数 userId
        /// </summary>
        public string userId { get; set; }
        public string jobId { get; set; }
        public string objectId { get; set; }

        public string playingTime { get; set; }
        public string SALT { get ; set; }
        public string  duration { get; set; }
        public string clipTime { get; set; }

        public string outLink { get; set; }

        private MD5Helper m;
        /// <summary>
        /// 在字符串首尾添加方括号
        /// </summary>
        /// <param name="str">目标字符串</param>
        /// <returns>string</returns>
        private string AddSqBrackets(string str)
        {
            return str.Insert(0, "[").Insert(str.Length+1,"]");
        }

        public ParamHelper()
        {
            SALT = "d_yHJ!$pdA~5";
        }
        /// <summary>
        /// 返回最终加方括号的整个字符串
        /// </summary>
        /// <returns>string</returns>
        public string FinalString()
        {
            //判断是否为空
            if( 
                clazzId.Trim()=="" ||
                userId.Trim()=="" ||
                jobId.Trim()=="" || 
                objectId.Trim()== "" || 
                playingTime.Trim()=="" ||
                SALT.Trim()=="" ||
                duration.Trim()=="" || 
                clipTime.Trim()==""
                )
                  return "";
            else
            {
                string res = AddSqBrackets(clazzId) +
                                  AddSqBrackets(userId) +
                                  AddSqBrackets(jobId) +
                                  AddSqBrackets(objectId) +
                                  AddSqBrackets(playingTime) +
                                  AddSqBrackets(SALT) +
                                  AddSqBrackets(duration) +
                                  AddSqBrackets(clipTime);
                return res;
            }
        }
        
        public string[] ParseLink(string link)
        {
            /*
             https://mooc1-3.chaoxing.com/multimedia/log/a/8640592/7e796434c647e23faa9f66527a94baa5?
             clazzId=7796558
             &playingTime=0                                      
             &duration=1051                                      
             &clipTime=0_1051                                   
             &objectId=54d9590053706e35b9f1fbf3     
             &otherInfo=nodeId_143078569-cpi_8640592    
             &jobid=1423530229724                            
             &userid=24804958                                   
             &isdrag=0                                                   
             &view=pc                                                   
             &enc=4760c22e38e7d823ec254d319e1362e2&rt=0.9    
             &dtype=Video                                                            
             &_t=1554911508252                                                   
             */
             //用？分割开，首先
            string[] arr = link.Split(new char[] {'?'});
            //分割后以&连接 的参数字符串
            string afterQmark = arr[1];
            //
            string[] paramz = afterQmark.Split(new char[] { '&'});
            //解析重要的参数出来 8个
            //clazzid userid jobid objectid playingtime duration cliptime otherinfo
            //0 7 6 4 1 2 3 5
            string[] importantPara = { paramz[0], paramz[1], paramz[2], paramz[3], paramz[4], paramz[5], paramz[6], paramz[7] };
            //以上的形式为 clazzId=*******,userid=*******....
            //比如clazzId=7796558，需要再用=分割，取右边的元素
            string[] paramVals = new string[8]; ;
            for (int i=0;i<importantPara.Length ;i++)
            {
                paramVals[i] = importantPara[i].Split(new char[] { '=' })[1];
            }

            //设置推荐链接
            //计算enc值
            //参数表：
         
            string encyStr = "";
            encyStr += AddSqBrackets(paramVals[0]);
            encyStr += AddSqBrackets(paramVals[7]);
            encyStr += AddSqBrackets(paramVals[6]);
            encyStr += AddSqBrackets(paramVals[4]);
            encyStr += AddSqBrackets(paramVals[2] + "000");
            encyStr += AddSqBrackets(SALT);
            encyStr += AddSqBrackets(paramVals[2] + "000");
            encyStr += AddSqBrackets(paramVals[3]);
             //开始加密
             m = new MD5Helper(encyStr);
            //加密后的enc值
            string enc = m.StringToMD5();
            //拼接字符串
            //需要的参数表：
            /*
             * clazzid 
             * userid  
             * jobid   
             * objectid  
             * playingtime 
             * duration 
             * cliptime  
             * otherInfo
             * enc
             * rt
             */
            //arr[0] =  https://mooc1-3.chaoxing.com/multimedia/log/a/8640592/7e796434c647e23faa9f66527a94baa5
            string otlink = arr[0] + "?" + "clazzId=" + paramVals[0] + "&"
                                    + "playingTime=" + paramVals[2] + "&"
                                    + "duration=" + paramVals[2] +  "&"
                                    + "clipTime=" + paramVals[3] + "&"
                                    + "objectId=" + paramVals[4]  + "&"  
                                    + "otherInfo=" + paramVals[5]  + "&"      
                                    + "jobid=" + paramVals[6] + "&" 
                                    + "userid=" + paramVals[7] + "&"
                                    + "isdrag=3" + "&"
                                    + "view=pc" + "&" 
                                    + "enc=" + enc + "&"
                                    + "rt=0.9&dtype=video" ;
            outLink = otlink;
            return paramVals;
        }

    }
}
