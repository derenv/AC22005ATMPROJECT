namespace WindowsFormsApp1
{
    partial class FAtm
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
            this.submit = new System.Windows.Forms.Button();
            this.lblAtm = new System.Windows.Forms.Label();
            this.Pin = new System.Windows.Forms.TextBox();
            this.Account = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(116, 137);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(168, 29);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // lblAtm
            // 
            this.lblAtm.AutoSize = true;
            this.lblAtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtm.Location = new System.Drawing.Point(12, 9);
            this.lblAtm.Name = "lblAtm";
            this.lblAtm.Size = new System.Drawing.Size(39, 18);
            this.lblAtm.TabIndex = 1;
            this.lblAtm.Text = "ATM";
            // 
            // Pin
            // 
            this.Pin.Location = new System.Drawing.Point(116, 111);
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(168, 20);
            this.Pin.TabIndex = 2;
            // 
            // Account
            // 
            this.Account.Location = new System.Drawing.Point(116, 75);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(168, 20);
            this.Account.TabIndex = 3;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(15, 78);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(95, 13);
            this.lblAccount.TabIndex = 4;
            this.lblAccount.Text = "Enter Account No.";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(40, 114);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(70, 13);
            this.lblPin.TabIndex = 5;
            this.lblPin.Text = "Enter Pin No.";
            // 
            // FAtm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 261);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.lblAtm);
            this.Controls.Add(this.submit);
            this.Name = "FAtm";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Atm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label lblAtm;
        private System.Windows.Forms.TextBox Pin;
        private System.Windows.Forms.TextBox Account;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblPin;
    }
}