namespace zadanieRekrutacyjne
{
    partial class UPDATE_OK
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
            this.updVis = new System.Windows.Forms.CheckBox();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.updParentId = new System.Windows.Forms.TextBox();
            this.updOrderId = new System.Windows.Forms.TextBox();
            this.updDescription = new System.Windows.Forms.TextBox();
            this.updName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.currentIdLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updVis
            // 
            this.updVis.AutoSize = true;
            this.updVis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updVis.Location = new System.Drawing.Point(231, 93);
            this.updVis.Name = "updVis";
            this.updVis.Size = new System.Drawing.Size(101, 17);
            this.updVis.TabIndex = 24;
            this.updVis.Text = "Visibility             ";
            this.updVis.UseVisualStyleBackColor = true;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(346, 241);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 23;
            this.cmdUpdate.Text = "UPDATE";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // updParentId
            // 
            this.updParentId.Location = new System.Drawing.Point(317, 67);
            this.updParentId.Name = "updParentId";
            this.updParentId.Size = new System.Drawing.Size(100, 20);
            this.updParentId.TabIndex = 22;
            // 
            // updOrderId
            // 
            this.updOrderId.Location = new System.Drawing.Point(317, 116);
            this.updOrderId.Name = "updOrderId";
            this.updOrderId.Size = new System.Drawing.Size(100, 20);
            this.updOrderId.TabIndex = 21;
            // 
            // updDescription
            // 
            this.updDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updDescription.Location = new System.Drawing.Point(317, 142);
            this.updDescription.Multiline = true;
            this.updDescription.Name = "updDescription";
            this.updDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.updDescription.Size = new System.Drawing.Size(250, 86);
            this.updDescription.TabIndex = 20;
            // 
            // updName
            // 
            this.updName.Location = new System.Drawing.Point(317, 41);
            this.updName.Name = "updName";
            this.updName.Size = new System.Drawing.Size(100, 20);
            this.updName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "New Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "New Ordering id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "New Parent id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "New Name:";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contentTextBox.Location = new System.Drawing.Point(12, 12);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTextBox.Size = new System.Drawing.Size(211, 317);
            this.contentTextBox.TabIndex = 25;
            // 
            // currentIdLabel
            // 
            this.currentIdLabel.AutoSize = true;
            this.currentIdLabel.Location = new System.Drawing.Point(256, 12);
            this.currentIdLabel.Name = "currentIdLabel";
            this.currentIdLabel.Size = new System.Drawing.Size(16, 13);
            this.currentIdLabel.TabIndex = 26;
            this.currentIdLabel.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Id:";
            // 
            // UPDATE_OK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentIdLabel);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.updVis);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.updParentId);
            this.Controls.Add(this.updOrderId);
            this.Controls.Add(this.updDescription);
            this.Controls.Add(this.updName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(600, 380);
            this.Name = "UPDATE_OK";
            this.Text = "UPDATE_OK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox contentTextBox;
        public System.Windows.Forms.CheckBox updVis;
        public System.Windows.Forms.TextBox updParentId;
        public System.Windows.Forms.TextBox updOrderId;
        public System.Windows.Forms.TextBox updName;
        public System.Windows.Forms.Label currentIdLabel;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox updDescription;
    }
}