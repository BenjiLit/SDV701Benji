namespace BenjisBicyclesWinForm
{
    partial class frmPushBike
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
            this.lblGearAmount = new System.Windows.Forms.Label();
            this.txtGearAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGearAmount
            // 
            this.lblGearAmount.AutoSize = true;
            this.lblGearAmount.Location = new System.Drawing.Point(12, 305);
            this.lblGearAmount.Name = "lblGearAmount";
            this.lblGearAmount.Size = new System.Drawing.Size(86, 13);
            this.lblGearAmount.TabIndex = 10;
            this.lblGearAmount.Text = "Amount of Gears";
            // 
            // txtGearAmount
            // 
            this.txtGearAmount.Location = new System.Drawing.Point(108, 298);
            this.txtGearAmount.Name = "txtGearAmount";
            this.txtGearAmount.Size = new System.Drawing.Size(100, 20);
            this.txtGearAmount.TabIndex = 11;
            // 
            // frmPushBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(328, 346);
            this.Controls.Add(this.txtGearAmount);
            this.Controls.Add(this.lblGearAmount);
            this.Name = "frmPushBike";
            this.Text = "Push Bike";
            this.Controls.SetChildIndex(this.lblGearAmount, 0);
            this.Controls.SetChildIndex(this.txtGearAmount, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGearAmount;
        private System.Windows.Forms.TextBox txtGearAmount;
    }
}
