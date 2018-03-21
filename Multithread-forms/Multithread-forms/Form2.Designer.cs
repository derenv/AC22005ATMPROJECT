namespace Multithread_forms
{
    partial class testform
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
            this.lftlbl = new System.Windows.Forms.Label();
            this.rgtlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lftlbl
            // 
            this.lftlbl.AutoSize = true;
            this.lftlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lftlbl.Location = new System.Drawing.Point(25, 31);
            this.lftlbl.Name = "lftlbl";
            this.lftlbl.Size = new System.Drawing.Size(78, 73);
            this.lftlbl.TabIndex = 0;
            this.lftlbl.Text = "C";
            // 
            // rgtlbl
            // 
            this.rgtlbl.AutoSize = true;
            this.rgtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgtlbl.Location = new System.Drawing.Point(426, 31);
            this.rgtlbl.Name = "rgtlbl";
            this.rgtlbl.Size = new System.Drawing.Size(78, 73);
            this.rgtlbl.TabIndex = 1;
            this.rgtlbl.Text = "D";
            // 
            // testform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 404);
            this.Controls.Add(this.rgtlbl);
            this.Controls.Add(this.lftlbl);
            this.Name = "testform";
            this.Text = "test form 2";
            this.Load += new System.EventHandler(this.testform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lftlbl;
        private System.Windows.Forms.Label rgtlbl;
    }
}