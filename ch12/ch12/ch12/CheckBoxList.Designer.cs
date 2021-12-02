namespace ch12
{
    partial class CheckBoxList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkGwamok = new System.Windows.Forms.CheckedListBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkGwamok
            // 
            this.chkGwamok.FormattingEnabled = true;
            this.chkGwamok.Items.AddRange(new object[] {
            "C언어",
            "Visual C++",
            "C#",
            "Java",
            "JSP",
            "ASP",
            "PHP"});
            this.chkGwamok.Location = new System.Drawing.Point(96, 57);
            this.chkGwamok.Name = "chkGwamok";
            this.chkGwamok.Size = new System.Drawing.Size(191, 132);
            this.chkGwamok.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(103, 225);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(157, 12);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "좋아하는 과목을 선택하시오";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(86, 283);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "선택";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(192, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CheckBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.chkGwamok);
            this.Name = "CheckBoxList";
            this.Text = "체크박스리스트연습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkGwamok;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnExit;
    }
}