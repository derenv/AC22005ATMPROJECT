namespace WindowsFormsApp1
{
    partial class FBank
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
            this.atmCreate = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // atmCreate
            // 
            this.atmCreate.Location = new System.Drawing.Point(12, 12);
            this.atmCreate.Name = "atmCreate";
            this.atmCreate.Size = new System.Drawing.Size(144, 53);
            this.atmCreate.TabIndex = 2;
            this.atmCreate.Text = "New ATM";
            this.atmCreate.UseVisualStyleBackColor = true;
            this.atmCreate.Click += new System.EventHandler(this.atmCreate_Click_1);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(12, 83);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(144, 65);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // FBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 164);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.atmCreate);
            this.Name = "FBank";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.FBank_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button atmCreate;
        private System.Windows.Forms.Button Quit;
    }
}