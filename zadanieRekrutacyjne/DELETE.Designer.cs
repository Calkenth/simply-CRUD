namespace zadanieRekrutacyjne
{
    partial class DELETE
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
            this.toDelete = new System.Windows.Forms.Button();
            this.searchCatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toDelete
            // 
            this.toDelete.Location = new System.Drawing.Point(80, 45);
            this.toDelete.Name = "toDelete";
            this.toDelete.Size = new System.Drawing.Size(75, 23);
            this.toDelete.TabIndex = 6;
            this.toDelete.Text = "DELETE";
            this.toDelete.UseVisualStyleBackColor = true;
            this.toDelete.Click += new System.EventHandler(this.toDelete_Click);
            // 
            // searchCatName
            // 
            this.searchCatName.Location = new System.Drawing.Point(56, 12);
            this.searchCatName.Name = "searchCatName";
            this.searchCatName.Size = new System.Drawing.Size(189, 20);
            this.searchCatName.TabIndex = 5;
            this.searchCatName.Text = "Which id?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search:";
            // 
            // DELETE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 80);
            this.Controls.Add(this.toDelete);
            this.Controls.Add(this.searchCatName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DELETE";
            this.Text = "DELETE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toDelete;
        private System.Windows.Forms.TextBox searchCatName;
        private System.Windows.Forms.Label label1;
    }
}