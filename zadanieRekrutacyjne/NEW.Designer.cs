namespace zadanieRekrutacyjne
{
    partial class NEW
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newName = new System.Windows.Forms.TextBox();
            this.newDescription = new System.Windows.Forms.TextBox();
            this.newOrderId = new System.Windows.Forms.TextBox();
            this.newParentId = new System.Windows.Forms.TextBox();
            this.newCat = new System.Windows.Forms.Button();
            this.newVis = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parent id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ordering:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description:";
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(110, 13);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(100, 20);
            this.newName.TabIndex = 6;
            // 
            // newDescription
            // 
            this.newDescription.Location = new System.Drawing.Point(110, 123);
            this.newDescription.Multiline = true;
            this.newDescription.Name = "newDescription";
            this.newDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.newDescription.Size = new System.Drawing.Size(256, 86);
            this.newDescription.TabIndex = 8;
            // 
            // newOrderId
            // 
            this.newOrderId.Location = new System.Drawing.Point(110, 97);
            this.newOrderId.Name = "newOrderId";
            this.newOrderId.Size = new System.Drawing.Size(100, 20);
            this.newOrderId.TabIndex = 9;
            this.newOrderId.Text = "1";
            // 
            // newParentId
            // 
            this.newParentId.Location = new System.Drawing.Point(110, 41);
            this.newParentId.Name = "newParentId";
            this.newParentId.Size = new System.Drawing.Size(100, 20);
            this.newParentId.TabIndex = 10;
            this.newParentId.Text = "1";
            // 
            // newCat
            // 
            this.newCat.Location = new System.Drawing.Point(139, 222);
            this.newCat.Name = "newCat";
            this.newCat.Size = new System.Drawing.Size(75, 23);
            this.newCat.TabIndex = 11;
            this.newCat.Text = "CREATE";
            this.newCat.UseVisualStyleBackColor = true;
            this.newCat.Click += new System.EventHandler(this.newCat_Click);
            // 
            // newVis
            // 
            this.newVis.AutoSize = true;
            this.newVis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newVis.Location = new System.Drawing.Point(24, 70);
            this.newVis.Name = "newVis";
            this.newVis.Size = new System.Drawing.Size(101, 17);
            this.newVis.TabIndex = 12;
            this.newVis.Text = "Visibility             ";
            this.newVis.UseVisualStyleBackColor = true;
            // 
            // NEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 255);
            this.Controls.Add(this.newVis);
            this.Controls.Add(this.newCat);
            this.Controls.Add(this.newParentId);
            this.Controls.Add(this.newOrderId);
            this.Controls.Add(this.newDescription);
            this.Controls.Add(this.newName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NEW";
            this.Text = "NEW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.TextBox newDescription;
        private System.Windows.Forms.TextBox newOrderId;
        private System.Windows.Forms.TextBox newParentId;
        private System.Windows.Forms.Button newCat;
        private System.Windows.Forms.CheckBox newVis;
    }
}