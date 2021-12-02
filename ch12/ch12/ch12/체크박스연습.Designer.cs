namespace ch12
{
    partial class 체크박스연습
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.chkStr1 = new System.Windows.Forms.CheckBox();
            this.chkStr2 = new System.Windows.Forms.CheckBox();
            this.chkStr3 = new System.Windows.Forms.CheckBox();
            this.lbSample = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.lbSample);
            this.grpBox.Controls.Add(this.chkStr3);
            this.grpBox.Controls.Add(this.chkStr2);
            this.grpBox.Controls.Add(this.chkStr1);
            this.grpBox.Location = new System.Drawing.Point(36, 52);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(322, 174);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "좋아하는 음식 선택";
            // 
            // chkStr1
            // 
            this.chkStr1.AutoSize = true;
            this.chkStr1.Location = new System.Drawing.Point(41, 32);
            this.chkStr1.Name = "chkStr1";
            this.chkStr1.Size = new System.Drawing.Size(48, 16);
            this.chkStr1.TabIndex = 0;
            this.chkStr1.Text = "라면";
            this.chkStr1.UseVisualStyleBackColor = true;
            this.chkStr1.CheckedChanged += new System.EventHandler(this.ChkStr1_CheckedChanged);
            // 
            // chkStr2
            // 
            this.chkStr2.AutoSize = true;
            this.chkStr2.Location = new System.Drawing.Point(41, 77);
            this.chkStr2.Name = "chkStr2";
            this.chkStr2.Size = new System.Drawing.Size(48, 16);
            this.chkStr2.TabIndex = 1;
            this.chkStr2.Text = "쫄면";
            this.chkStr2.UseVisualStyleBackColor = true;
            this.chkStr2.CheckedChanged += new System.EventHandler(this.ChkStr2_CheckedChanged);
            // 
            // chkStr3
            // 
            this.chkStr3.AutoSize = true;
            this.chkStr3.Location = new System.Drawing.Point(41, 127);
            this.chkStr3.Name = "chkStr3";
            this.chkStr3.Size = new System.Drawing.Size(60, 16);
            this.chkStr3.TabIndex = 2;
            this.chkStr3.Text = "짜장면";
            this.chkStr3.UseVisualStyleBackColor = true;
            this.chkStr3.CheckedChanged += new System.EventHandler(this.ChkStr3_CheckedChanged);
            // 
            // lbSample
            // 
            this.lbSample.AutoSize = true;
            this.lbSample.Location = new System.Drawing.Point(181, 77);
            this.lbSample.Name = "lbSample";
            this.lbSample.Size = new System.Drawing.Size(13, 12);
            this.lbSample.TabIndex = 3;
            this.lbSample.Text = "\"\"";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(155, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // 체크박스연습
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBox);
            this.Name = "체크박스연습";
            this.Text = "체크박스연습";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label lbSample;
        private System.Windows.Forms.CheckBox chkStr3;
        private System.Windows.Forms.CheckBox chkStr2;
        private System.Windows.Forms.CheckBox chkStr1;
        private System.Windows.Forms.Button btnExit;
    }
}

