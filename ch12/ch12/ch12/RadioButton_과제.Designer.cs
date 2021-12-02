namespace ch12
{
    partial class RadioButton_과제
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
            this.label1 = new System.Windows.Forms.Label();
            this.txBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radBtn1 = new System.Windows.Forms.RadioButton();
            this.radBtn2 = new System.Windows.Forms.RadioButton();
            this.radBtn3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "성별입력";
            // 
            // txBox
            // 
            this.txBox.Location = new System.Drawing.Point(166, 66);
            this.txBox.Name = "txBox";
            this.txBox.Size = new System.Drawing.Size(100, 21);
            this.txBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // radBtn1
            // 
            this.radBtn1.AutoSize = true;
            this.radBtn1.Location = new System.Drawing.Point(49, 233);
            this.radBtn1.Name = "radBtn1";
            this.radBtn1.Size = new System.Drawing.Size(47, 16);
            this.radBtn1.TabIndex = 3;
            this.radBtn1.TabStop = true;
            this.radBtn1.Text = "여자";
            this.radBtn1.UseVisualStyleBackColor = true;
            // 
            // radBtn2
            // 
            this.radBtn2.AutoSize = true;
            this.radBtn2.Location = new System.Drawing.Point(156, 233);
            this.radBtn2.Name = "radBtn2";
            this.radBtn2.Size = new System.Drawing.Size(47, 16);
            this.radBtn2.TabIndex = 4;
            this.radBtn2.TabStop = true;
            this.radBtn2.Text = "남자";
            this.radBtn2.UseVisualStyleBackColor = true;
            // 
            // radBtn3
            // 
            this.radBtn3.AutoSize = true;
            this.radBtn3.Location = new System.Drawing.Point(276, 233);
            this.radBtn3.Name = "radBtn3";
            this.radBtn3.Size = new System.Drawing.Size(47, 16);
            this.radBtn3.TabIndex = 5;
            this.radBtn3.TabStop = true;
            this.radBtn3.Text = "중성";
            this.radBtn3.UseVisualStyleBackColor = true;
            // 
            // RadioButton_과제
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.radBtn3);
            this.Controls.Add(this.radBtn2);
            this.Controls.Add(this.radBtn1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txBox);
            this.Controls.Add(this.label1);
            this.Name = "RadioButton_과제";
            this.Text = "R_B_과제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radBtn1;
        private System.Windows.Forms.RadioButton radBtn2;
        private System.Windows.Forms.RadioButton radBtn3;
    }
}