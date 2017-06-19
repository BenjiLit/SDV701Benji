namespace BenjisBicyclesWinForm
{
    partial class frmElectricBike
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
            this.txtElectricRange = new System.Windows.Forms.TextBox();
            this.lblElectricRange = new System.Windows.Forms.Label();
            this.txtMotorPosition = new System.Windows.Forms.TextBox();
            this.lblMotorPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtElectricRange
            // 
            this.txtElectricRange.Location = new System.Drawing.Point(107, 302);
            this.txtElectricRange.Name = "txtElectricRange";
            this.txtElectricRange.Size = new System.Drawing.Size(100, 20);
            this.txtElectricRange.TabIndex = 13;
            // 
            // lblElectricRange
            // 
            this.lblElectricRange.AutoSize = true;
            this.lblElectricRange.Location = new System.Drawing.Point(12, 305);
            this.lblElectricRange.Name = "lblElectricRange";
            this.lblElectricRange.Size = new System.Drawing.Size(95, 13);
            this.lblElectricRange.TabIndex = 12;
            this.lblElectricRange.Text = "Electric Range Km";
            // 
            // txtMotorPosition
            // 
            this.txtMotorPosition.Location = new System.Drawing.Point(107, 348);
            this.txtMotorPosition.Name = "txtMotorPosition";
            this.txtMotorPosition.Size = new System.Drawing.Size(100, 20);
            this.txtMotorPosition.TabIndex = 15;
            // 
            // lblMotorPosition
            // 
            this.lblMotorPosition.AutoSize = true;
            this.lblMotorPosition.Location = new System.Drawing.Point(12, 351);
            this.lblMotorPosition.Name = "lblMotorPosition";
            this.lblMotorPosition.Size = new System.Drawing.Size(74, 13);
            this.lblMotorPosition.TabIndex = 14;
            this.lblMotorPosition.Text = "Motor Position";
            // 
            // frmElectricBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(328, 405);
            this.Controls.Add(this.txtMotorPosition);
            this.Controls.Add(this.lblMotorPosition);
            this.Controls.Add(this.txtElectricRange);
            this.Controls.Add(this.lblElectricRange);
            this.Name = "frmElectricBike";
            this.Text = "Electric Bike";
            this.Controls.SetChildIndex(this.lblElectricRange, 0);
            this.Controls.SetChildIndex(this.txtElectricRange, 0);
            this.Controls.SetChildIndex(this.lblMotorPosition, 0);
            this.Controls.SetChildIndex(this.txtMotorPosition, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElectricRange;
        private System.Windows.Forms.Label lblElectricRange;
        private System.Windows.Forms.TextBox txtMotorPosition;
        private System.Windows.Forms.Label lblMotorPosition;
    }
}
