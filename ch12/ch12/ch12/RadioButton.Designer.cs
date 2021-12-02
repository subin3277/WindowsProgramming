namespace ch12
{
    partial class FrmRadio
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
            this.grpRadio = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.radB1 = new System.Windows.Forms.RadioButton();
            this.radB2 = new System.Windows.Forms.RadioButton();
            this.radB3 = new System.Windows.Forms.RadioButton();
            this.lbSample = new System.Windows.Forms.Label();
            this.grpRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRadio
            // 
            this.grpRadio.Controls.Add(this.lbSample);
            this.grpRadio.Controls.Add(this.radB3);
            this.grpRadio.Controls.Add(this.radB2);
            this.grpRadio.Controls.Add(this.radB1);
            this.grpRadio.Location = new System.Drawing.Point(55, 54);
            this.grpRadio.Name = "grpRadio";
            this.grpRadio.Size = new System.Drawing.Size(256, 167);
            this.grpRadio.TabIndex = 0;
            this.grpRadio.TabStop = false;
            this.grpRadio.Text = "성별체크";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(146, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "확인";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // radB1
            // 
            this.radB1.AutoSize = true;
            this.radB1.Location = new System.Drawing.Point(24, 39);
            this.radB1.Name = "radB1";
            this.radB1.Size = new System.Drawing.Size(47, 16);
            this.radB1.TabIndex = 0;
            this.radB1.TabStop = true;
            this.radB1.Text = "여자";
            this.radB1.UseVisualStyleBackColor = true;
            // 
            // radB2
            // 
            this.radB2.AutoSize = true;
            this.radB2.Location = new System.Drawing.Point(24, 80);
            this.radB2.Name = "radB2";
            this.radB2.Size = new System.Drawing.Size(47, 16);
            this.radB2.TabIndex = 1;
            this.radB2.TabStop = true;
            this.radB2.Text = "남자";
            this.radB2.UseVisualStyleBackColor = true;
            // 
            // radB3
            // 
            this.radB3.AutoSize = true;
            this.radB3.Location = new System.Drawing.Point(24, 122);
            this.radB3.Name = "radB3";
            this.radB3.Size = new System.Drawing.Size(47, 16);
            this.radB3.TabIndex = 2;
            this.radB3.TabStop = true;
            this.radB3.Text = "중성";
            this.radB3.UseVisualStyleBackColor = true;
            // 
            // lbSample
            // 
            this.lbSample.AutoSize = true;
            this.lbSample.Location = new System.Drawing.Point(164, 39);
            this.lbSample.Name = "lbSample";
            this.lbSample.Size = new System.Drawing.Size(13, 12);
            this.lbSample.TabIndex = 3;
            this.lbSample.Text = "\"\"";
            // 
            // FrmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpRadio);
            this.Name = "FrmRadio";
            this.Text = "성별체크";
            this.grpRadio.ResumeLayout(false);
            this.grpRadio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRadio;
        private System.Windows.Forms.Label lbSample;
        private System.Windows.Forms.RadioButton radB3;
        private System.Windows.Forms.RadioButton radB2;
        private System.Windows.Forms.RadioButton radB1;
        private System.Windows.Forms.Button btnExit;
    }
}