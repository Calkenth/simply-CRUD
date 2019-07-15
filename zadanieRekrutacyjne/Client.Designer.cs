namespace zadanieRekrutacyjne
{
    partial class Client
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
            this.cmdNEW = new System.Windows.Forms.Button();
            this.cmdSHOW = new System.Windows.Forms.Button();
            this.cmdUPDATE = new System.Windows.Forms.Button();
            this.cmdDELETE = new System.Windows.Forms.Button();
            this.newLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdNEW
            // 
            this.cmdNEW.Location = new System.Drawing.Point(22, 12);
            this.cmdNEW.Name = "cmdNEW";
            this.cmdNEW.Size = new System.Drawing.Size(75, 23);
            this.cmdNEW.TabIndex = 0;
            this.cmdNEW.Text = "NEW";
            this.cmdNEW.UseVisualStyleBackColor = true;
            this.cmdNEW.Click += new System.EventHandler(this.cmdNEW_Click);
            // 
            // cmdSHOW
            // 
            this.cmdSHOW.Location = new System.Drawing.Point(103, 12);
            this.cmdSHOW.Name = "cmdSHOW";
            this.cmdSHOW.Size = new System.Drawing.Size(75, 23);
            this.cmdSHOW.TabIndex = 1;
            this.cmdSHOW.Text = "SHOW";
            this.cmdSHOW.UseVisualStyleBackColor = true;
            this.cmdSHOW.Click += new System.EventHandler(this.cmdSHOW_Click);
            // 
            // cmdUPDATE
            // 
            this.cmdUPDATE.Location = new System.Drawing.Point(184, 12);
            this.cmdUPDATE.Name = "cmdUPDATE";
            this.cmdUPDATE.Size = new System.Drawing.Size(75, 23);
            this.cmdUPDATE.TabIndex = 2;
            this.cmdUPDATE.Text = "UPDATE";
            this.cmdUPDATE.UseVisualStyleBackColor = true;
            this.cmdUPDATE.Click += new System.EventHandler(this.cmdUPDATE_Click);
            // 
            // cmdDELETE
            // 
            this.cmdDELETE.Location = new System.Drawing.Point(265, 12);
            this.cmdDELETE.Name = "cmdDELETE";
            this.cmdDELETE.Size = new System.Drawing.Size(75, 23);
            this.cmdDELETE.TabIndex = 3;
            this.cmdDELETE.Text = "DELETE";
            this.cmdDELETE.UseVisualStyleBackColor = true;
            this.cmdDELETE.Click += new System.EventHandler(this.cmdDELETE_Click);
            // 
            // newLog
            // 
            this.newLog.Location = new System.Drawing.Point(135, 41);
            this.newLog.Name = "newLog";
            this.newLog.Size = new System.Drawing.Size(75, 23);
            this.newLog.TabIndex = 4;
            this.newLog.Text = "LOG-IN";
            this.newLog.UseVisualStyleBackColor = true;
            this.newLog.Click += new System.EventHandler(this.newLog_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 66);
            this.Controls.Add(this.newLog);
            this.Controls.Add(this.cmdDELETE);
            this.Controls.Add(this.cmdUPDATE);
            this.Controls.Add(this.cmdSHOW);
            this.Controls.Add(this.cmdNEW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdNEW;
        private System.Windows.Forms.Button cmdSHOW;
        private System.Windows.Forms.Button cmdUPDATE;
        private System.Windows.Forms.Button cmdDELETE;
        private System.Windows.Forms.Button newLog;
    }
}

