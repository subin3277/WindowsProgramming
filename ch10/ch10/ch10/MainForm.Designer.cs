namespace ch10
{
    partial class MainForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(26, 36);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 12);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "이름";
            this.lbName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(26, 77);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(29, 12);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "결과";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 21);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "이름을 입력하세요..";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(83, 72);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(141, 21);
            this.txtResult.TabIndex = 3;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(47, 108);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 4;
            this.btnOutput.Text = "출력하기";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.BtnOutput_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(149, 108);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbName);
            this.Name = "MainForm";
            this.Text = "ControlTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnReset;
    }
}

