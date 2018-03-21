namespace Multithread_forms
{
    partial class mainform
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
            this.actbtn = new System.Windows.Forms.Button();
            this.lftlbl = new System.Windows.Forms.Label();
            this.rgtlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // actbtn
            // 
            this.actbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actbtn.Location = new System.Drawing.Point(144, 271);
            this.actbtn.Name = "actbtn";
            this.actbtn.Size = new System.Drawing.Size(184, 87);
            this.actbtn.TabIndex = 0;
            this.actbtn.Text = "ACTIVATE THREAD";
            this.actbtn.UseVisualStyleBackColor = true;
            this.actbtn.Click += new System.EventHandler(this.actbtn_Click);
            // 
            // lftlbl
            // 
            this.lftlbl.AutoSize = true;
            this.lftlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lftlbl.Location = new System.Drawing.Point(12, 38);
            this.lftlbl.Name = "lftlbl";
            this.lftlbl.Size = new System.Drawing.Size(75, 73);
            this.lftlbl.TabIndex = 1;
            this.lftlbl.Text = "A";
            // 
            // rgtlbl
            // 
            this.rgtlbl.AutoSize = true;
            this.rgtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgtlbl.Location = new System.Drawing.Point(388, 38);
            this.rgtlbl.Name = "rgtlbl";
            this.rgtlbl.Size = new System.Drawing.Size(75, 73);
            this.rgtlbl.TabIndex = 2;
            this.rgtlbl.Text = "B";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 415);
            this.Controls.Add(this.rgtlbl);
            this.Controls.Add(this.lftlbl);
            this.Controls.Add(this.actbtn);
            this.Name = "mainform";
            this.Text = "Test(icles)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button actbtn;
        private System.Windows.Forms.Label lftlbl;
        private System.Windows.Forms.Label rgtlbl;
    }
}

