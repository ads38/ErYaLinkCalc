namespace ErYaLinkCalc
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.clipTimeTxt = new System.Windows.Forms.TextBox();
            this.calcEncBtn = new System.Windows.Forms.Button();
            this.durationTxt = new System.Windows.Forms.TextBox();
            this.saltTxt = new System.Windows.Forms.TextBox();
            this.playingTimeTxt = new System.Windows.Forms.TextBox();
            this.objectIdTxt = new System.Windows.Forms.TextBox();
            this.jobIdTxt = new System.Windows.Forms.TextBox();
            this.userIdTxt = new System.Windows.Forms.TextBox();
            this.clazzIdTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copyENCBtn = new System.Windows.Forms.Button();
            this.encTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.copyOutLinkBtn = new System.Windows.Forms.Button();
            this.outLinkTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkParseBtn = new System.Windows.Forms.Button();
            this.inLinkTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.clipTimeTxt);
            this.groupBox1.Controls.Add(this.calcEncBtn);
            this.groupBox1.Controls.Add(this.durationTxt);
            this.groupBox1.Controls.Add(this.saltTxt);
            this.groupBox1.Controls.Add(this.playingTimeTxt);
            this.groupBox1.Controls.Add(this.objectIdTxt);
            this.groupBox1.Controls.Add(this.jobIdTxt);
            this.groupBox1.Controls.Add(this.userIdTxt);
            this.groupBox1.Controls.Add(this.clazzIdTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数表";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(21, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 12);
            this.label14.TabIndex = 23;
            this.label14.Text = "SALT的值强烈建议不要修改！";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F);
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(349, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(311, 12);
            this.label13.TabIndex = 22;
            this.label13.Text = "根据以上参数计算enc参数的值，点击后会在以下显示出来";
            // 
            // clipTimeTxt
            // 
            this.clipTimeTxt.Font = new System.Drawing.Font("宋体", 10.5F);
            this.clipTimeTxt.Location = new System.Drawing.Point(96, 303);
            this.clipTimeTxt.Name = "clipTimeTxt";
            this.clipTimeTxt.Size = new System.Drawing.Size(671, 23);
            this.clipTimeTxt.TabIndex = 15;
            // 
            // calcEncBtn
            // 
            this.calcEncBtn.Location = new System.Drawing.Point(666, 345);
            this.calcEncBtn.Name = "calcEncBtn";
            this.calcEncBtn.Size = new System.Drawing.Size(101, 29);
            this.calcEncBtn.TabIndex = 2;
            this.calcEncBtn.Text = "计算enc参数值";
            this.calcEncBtn.UseVisualStyleBackColor = true;
            this.calcEncBtn.Click += new System.EventHandler(this.calcEncBtn_Click);
            // 
            // durationTxt
            // 
            this.durationTxt.Font = new System.Drawing.Font("宋体", 10.5F);
            this.durationTxt.Location = new System.Drawing.Point(145, 268);
            this.durationTxt.Name = "durationTxt";
            this.durationTxt.Size = new System.Drawing.Size(622, 23);
            this.durationTxt.TabIndex = 14;
            // 
            // saltTxt
            // 
            this.saltTxt.Font = new System.Drawing.Font("宋体", 10.5F);
            this.saltTxt.Location = new System.Drawing.Point(68, 206);
            this.saltTxt.Name = "saltTxt";
            this.saltTxt.Size = new System.Drawing.Size(699, 23);
            this.saltTxt.TabIndex = 13;
            this.saltTxt.Text = "d_yHJ!$pdA~5";
            // 
            // playingTimeTxt
            // 
            this.playingTimeTxt.Font = new System.Drawing.Font("宋体", 10.5F);
            this.playingTimeTxt.Location = new System.Drawing.Point(166, 171);
            this.playingTimeTxt.Name = "playingTimeTxt";
            this.playingTimeTxt.Size = new System.Drawing.Size(601, 23);
            this.playingTimeTxt.TabIndex = 12;
            // 
            // objectIdTxt
            // 
            this.objectIdTxt.Font = new System.Drawing.Font("宋体", 10.5F);
            this.objectIdTxt.Location = new System.Drawing.Point(89, 136);
            this.objectIdTxt.Name = "objectIdTxt";
            this.objectIdTxt.Size = new System.Drawing.Size(678, 23);
            this.objectIdTxt.TabIndex = 11;
            // 
            // jobIdTxt
            // 
            this.jobIdTxt.Font = new System.Drawing.Font("宋体", 10.5F);
            this.jobIdTxt.Location = new System.Drawing.Point(89, 101);
            this.jobIdTxt.Name = "jobIdTxt";
            this.jobIdTxt.Size = new System.Drawing.Size(678, 23);
            this.jobIdTxt.TabIndex = 10;
            // 
            // userIdTxt
            // 
            this.userIdTxt.Font = new System.Drawing.Font("宋体", 10.5F);
            this.userIdTxt.Location = new System.Drawing.Point(89, 66);
            this.userIdTxt.Name = "userIdTxt";
            this.userIdTxt.Size = new System.Drawing.Size(678, 23);
            this.userIdTxt.TabIndex = 9;
            // 
            // clazzIdTxt
            // 
            this.clazzIdTxt.Font = new System.Drawing.Font("宋体", 10.5F);
            this.clazzIdTxt.Location = new System.Drawing.Point(89, 31);
            this.clazzIdTxt.Name = "clazzIdTxt";
            this.clazzIdTxt.Size = new System.Drawing.Size(678, 23);
            this.clazzIdTxt.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(20, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "clipTime:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(20, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "duration * 1000:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(20, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "SALT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(20, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "playingTime * 1000:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(20, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "objectId:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "jobId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "userId:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "clazzId:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.copyENCBtn);
            this.groupBox2.Controls.Add(this.encTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "enc 参数（MD5哈希值）";
            // 
            // copyENCBtn
            // 
            this.copyENCBtn.Location = new System.Drawing.Point(666, 32);
            this.copyENCBtn.Name = "copyENCBtn";
            this.copyENCBtn.Size = new System.Drawing.Size(101, 29);
            this.copyENCBtn.TabIndex = 3;
            this.copyENCBtn.Text = "复制enc参数";
            this.copyENCBtn.UseVisualStyleBackColor = true;
            this.copyENCBtn.Click += new System.EventHandler(this.copyENCBtn_Click);
            // 
            // encTxt
            // 
            this.encTxt.Font = new System.Drawing.Font("宋体", 10.5F);
            this.encTxt.Location = new System.Drawing.Point(61, 35);
            this.encTxt.Name = "encTxt";
            this.encTxt.Size = new System.Drawing.Size(598, 23);
            this.encTxt.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(20, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "enc:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clearBtn);
            this.groupBox3.Controls.Add(this.copyOutLinkBtn);
            this.groupBox3.Controls.Add(this.outLinkTxt);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.linkParseBtn);
            this.groupBox3.Controls.Add(this.inLinkTxt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 325);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "链接解析";
            // 
            // copyOutLinkBtn
            // 
            this.copyOutLinkBtn.Location = new System.Drawing.Point(598, 290);
            this.copyOutLinkBtn.Name = "copyOutLinkBtn";
            this.copyOutLinkBtn.Size = new System.Drawing.Size(169, 29);
            this.copyOutLinkBtn.TabIndex = 21;
            this.copyOutLinkBtn.Text = "复制推荐的输出链接";
            this.copyOutLinkBtn.UseVisualStyleBackColor = true;
            this.copyOutLinkBtn.Click += new System.EventHandler(this.copyOutLinkBtn_Click);
            // 
            // outLinkTxt
            // 
            this.outLinkTxt.Font = new System.Drawing.Font("宋体", 10.5F);
            this.outLinkTxt.Location = new System.Drawing.Point(89, 190);
            this.outLinkTxt.Multiline = true;
            this.outLinkTxt.Name = "outLinkTxt";
            this.outLinkTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outLinkTxt.Size = new System.Drawing.Size(678, 94);
            this.outLinkTxt.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(20, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 14);
            this.label12.TabIndex = 19;
            this.label12.Text = "输出链接:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F);
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(87, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(473, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "输入了尔雅链接再点击这个按钮，将链接中的参数解析到“参数表”中的各个文本框里，\r\n并输出链接到以下文本框";
            // 
            // linkParseBtn
            // 
            this.linkParseBtn.Location = new System.Drawing.Point(598, 155);
            this.linkParseBtn.Name = "linkParseBtn";
            this.linkParseBtn.Size = new System.Drawing.Size(169, 29);
            this.linkParseBtn.TabIndex = 17;
            this.linkParseBtn.Text = "解析链接参数到以上文本框";
            this.linkParseBtn.UseVisualStyleBackColor = true;
            this.linkParseBtn.Click += new System.EventHandler(this.linkParseBtn_Click);
            // 
            // inLinkTxt
            // 
            this.inLinkTxt.Font = new System.Drawing.Font("宋体", 10.5F);
            this.inLinkTxt.Location = new System.Drawing.Point(89, 20);
            this.inLinkTxt.Multiline = true;
            this.inLinkTxt.Name = "inLinkTxt";
            this.inLinkTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inLinkTxt.Size = new System.Drawing.Size(678, 129);
            this.inLinkTxt.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(20, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 17;
            this.label10.Text = "输入链接:";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(89, 290);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(169, 29);
            this.clearBtn.TabIndex = 22;
            this.clearBtn.Text = "清空所有";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 836);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "尔雅链接计算器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clipTimeTxt;
        private System.Windows.Forms.TextBox durationTxt;
        private System.Windows.Forms.TextBox saltTxt;
        private System.Windows.Forms.TextBox playingTimeTxt;
        private System.Windows.Forms.TextBox objectIdTxt;
        private System.Windows.Forms.TextBox jobIdTxt;
        private System.Windows.Forms.TextBox userIdTxt;
        private System.Windows.Forms.TextBox clazzIdTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox encTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button calcEncBtn;
        private System.Windows.Forms.Button copyENCBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button linkParseBtn;
        private System.Windows.Forms.TextBox inLinkTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox outLinkTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button copyOutLinkBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button clearBtn;
    }
}

