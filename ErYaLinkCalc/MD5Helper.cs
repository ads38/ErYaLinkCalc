using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ErYaLinkCalc
{
    /// <summary>
    /// 用户自定义的MD5 加密相关的类，该类不能被继承
    /// </summary>
    class MD5Helper
    {
        /// <summary>
        /// string:要加密的目标字符串
        /// </summary>
        private string _targetString;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="str">初始化目标字符串</param>
        public MD5Helper(string str)
        {
            this._targetString = str;
        }

        /// <summary>
        /// MD5　32位加密
        /// </summary>
        /// <returns>string</returns>
        public string StringToMD5()
        {
            string cl = this._targetString;
            string result = "";
            MD5 md5 = MD5.Create();//实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                //using x2 to avoid lack some digits
                result = result + s[i].ToString("x2");

            }
            return result;
    
           }

    }
}
