namespace zadanieRekrutacyjne
{
    partial class Login
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
            this.logValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passValue = new System.Windows.Forms.TextBox();
            this.Log = new System.Windows.Forms.Button();
            this.URI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logValue
            // 
            this.logValue.Location = new System.Drawing.Point(86, 85);
            this.logValue.Name = "logValue";
            this.logValue.Size = new System.Drawing.Size(100, 20);
            this.logValue.TabIndex = 0;
            this.logValue.Text = "rest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // passValue
            // 
            this.passValue.Location = new System.Drawing.Point(86, 111);
            this.passValue.Name = "passValue";
            this.passValue.Size = new System.Drawing.Size(100, 20);
            this.passValue.TabIndex = 2;
            this.passValue.Text = "gBict?3J";
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(66, 141);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(75, 23);
            this.Log.TabIndex = 4;
            this.Log.Text = "Log-in";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // URI
            // 
            this.URI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URI.Location = new System.Drawing.Point(86, 24);
            this.URI.Name = "URI";
            this.URI.Size = new System.Drawing.Size(278, 20);
            this.URI.TabIndex = 5;
            this.URI.Text = "http://dotnet.demos.i-sklep.pl/rest_api/shop_api/v1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Api URL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resource name:";
            // 
            // resName
            // 
            this.resName.Location = new System.Drawing.Point(116, 55);
            this.resName.Name = "resName";
            this.resName.Size = new System.Drawing.Size(100, 20);
            this.resName.TabIndex = 8;
            this.resName.Text = "categories";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(394, 171);
            this.Controls.Add(this.resName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.URI);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(410, 210);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Log;
        public System.Windows.Forms.TextBox logValue;
        public System.Windows.Forms.TextBox passValue;
        public System.Windows.Forms.TextBox URI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox resName;
    }
}