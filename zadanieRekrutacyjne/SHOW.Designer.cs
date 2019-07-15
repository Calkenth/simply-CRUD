namespace zadanieRekrutacyjne
{
    partial class SHOW
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.searchCat = new System.Windows.Forms.TextBox();
            this.showOne = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            this.contentTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(19, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Id:";
            // 
            // searchCat
            // 
            this.searchCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCat.Location = new System.Drawing.Point(53, 13);
            this.searchCat.Name = "searchCat";
            this.searchCat.Size = new System.Drawing.Size(299, 20);
            this.searchCat.TabIndex = 1;
            this.searchCat.Text = "Which id?";
            // 
            // showOne
            // 
            this.showOne.Location = new System.Drawing.Point(71, 39);
            this.showOne.Name = "showOne";
            this.showOne.Size = new System.Drawing.Size(75, 23);
            this.showOne.TabIndex = 2;
            this.showOne.Text = "SHOW";
            this.showOne.UseVisualStyleBackColor = true;
            this.showOne.Click += new System.EventHandler(this.showOne_Click);
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(152, 39);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(75, 23);
            this.showAll.TabIndex = 3;
            this.showAll.Text = "SHOW ALL";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // contentTxtBox
            // 
            this.contentTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentTxtBox.Location = new System.Drawing.Point(15, 68);
            this.contentTxtBox.Multiline = true;
            this.contentTxtBox.Name = "contentTxtBox";
            this.contentTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTxtBox.Size = new System.Drawing.Size(337, 191);
            this.contentTxtBox.TabIndex = 5;
            // 
            // SHOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 271);
            this.Controls.Add(this.contentTxtBox);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.showOne);
            this.Controls.Add(this.searchCat);
            this.Controls.Add(this.nameLabel);
            this.MinimumSize = new System.Drawing.Size(380, 310);
            this.Name = "SHOW";
            this.Text = "SHOW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox searchCat;
        private System.Windows.Forms.Button showOne;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.TextBox contentTxtBox;
    }
}