using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ErYaLinkCalc
{
    public partial class MainFrm : Form
    {
        //成员变量
        //ini
        ParamHelper pmh = new ParamHelper();
        MD5Helper md5;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void calcEncBtn_Click(object sender, EventArgs e)
        {
            string classId = clazzIdTxt.Text;
            string userId = userIdTxt.Text;
            string jobId = jobIdTxt.Text;
            string objectId = objectIdTxt.Text;
            string playingTime = playingTimeTxt.Text;
            string salt = saltTxt.Text;
            string duration = durationTxt.Text;
            string cliptime = clipTimeTxt.Text;
            
            pmh.clazzId = classId;
            pmh.userId = userId;
            pmh.jobId = jobId;
            pmh.objectId = objectId;
            pmh.playingTime = playingTime;
            pmh.SALT = salt;
            pmh.duration = duration;
            pmh.clipTime = cliptime;
            string s = pmh.FinalString();
            //Md5初始化
            md5 = new MD5Helper(s);
            //计算出md5
            string s2 = md5.StringToMD5();
            //赋值给encTxt
            encTxt.Text = s2;
            MessageBox.Show(s);
        }

        private void copyENCBtn_Click(object sender, EventArgs e)
        {
            //copy enc param
            encTxt.SelectAll();
            encTxt.Copy();
        }

        /// <summary>
        /// 链接中的参数解析按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkParseBtn_Click(object sender, EventArgs e)
        {
            pmh.ParseLink(inLinkTxt.Text);
            outLinkTxt.Text = pmh.outLink;

        }

        //复制输出链接
        private void copyOutLinkBtn_Click(object sender, EventArgs e)
        {
            outLinkTxt.SelectAll();
            outLinkTxt.Copy();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inLinkTxt.Clear();
            outLinkTxt.Clear();
            inLinkTxt.Focus();
        }
    }
}
