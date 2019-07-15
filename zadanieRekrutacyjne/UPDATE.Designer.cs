namespace zadanieRekrutacyjne
{
    partial class UPDATE
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
            this.searchCatName = new System.Windows.Forms.TextBox();
            this.toUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // searchCatName
            // 
            this.searchCatName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCatName.Location = new System.Drawing.Point(38, 12);
            this.searchCatName.Name = "searchCatName";
            this.searchCatName.Size = new System.Drawing.Size(299, 20);
            this.searchCatName.TabIndex = 2;
            this.searchCatName.Text = "Which id you want to change?";
            // 
            // toUpdate
            // 
            this.toUpdate.Location = new System.Drawing.Point(120, 50);
            this.toUpdate.Name = "toUpdate";
            this.toUpdate.Size = new System.Drawing.Size(75, 23);
            this.toUpdate.TabIndex = 3;
            this.toUpdate.Text = "OK";
            this.toUpdate.UseVisualStyleBackColor = true;
            this.toUpdate.Click += new System.EventHandler(this.toUpdate_Click);
            // 
            // UPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 81);
            this.Controls.Add(this.toUpdate);
            this.Controls.Add(this.searchCatName);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(360, 120);
            this.Name = "UPDATE";
            this.Text = "UPDATE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchCatName;
        private System.Windows.Forms.Button toUpdate;
    }
}