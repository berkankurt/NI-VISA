namespace kaynak
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.USB_Kaynaklar = new System.Windows.Forms.ListBox();
            this.sec = new System.Windows.Forms.TextBox();
            this.ResourceStringLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // USB_Kaynaklar
            // 
            this.USB_Kaynaklar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.USB_Kaynaklar.Location = new System.Drawing.Point(12, 12);
            this.USB_Kaynaklar.Name = "USB_Kaynaklar";
            this.USB_Kaynaklar.Size = new System.Drawing.Size(282, 108);
            this.USB_Kaynaklar.TabIndex = 1;
            // 
            // sec
            // 
            this.sec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sec.Location = new System.Drawing.Point(12, 141);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(282, 20);
            this.sec.TabIndex = 5;
            this.sec.Text = "GPIB0::2::INSTR";
            this.sec.TextChanged += new System.EventHandler(this.visaResourceNameTextBox_TextChanged);
            // 
            // ResourceStringLabel
            // 
            this.ResourceStringLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResourceStringLabel.Location = new System.Drawing.Point(15, 125);
            this.ResourceStringLabel.Name = "ResourceStringLabel";
            this.ResourceStringLabel.Size = new System.Drawing.Size(279, 13);
            this.ResourceStringLabel.TabIndex = 7;
            this.ResourceStringLabel.Text = "Resource String:";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(12, 167);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(77, 25);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(95, 167);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(77, 25);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Cancel";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 431);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.ResourceStringLabel);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.USB_Kaynaklar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox USB_Kaynaklar;
        private System.Windows.Forms.TextBox sec;
        private System.Windows.Forms.Label ResourceStringLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button closeButton;
    }
}

