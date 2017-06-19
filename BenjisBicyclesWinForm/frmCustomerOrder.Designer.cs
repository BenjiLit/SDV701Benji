namespace BenjisBicyclesWinForm
{
    partial class frmCustomerOrder
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.lblItemOrdered = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtOrderersName = new System.Windows.Forms.TextBox();
            this.txtOrderesPhone = new System.Windows.Forms.TextBox();
            this.txtItemOrdered = new System.Windows.Forms.TextBox();
            this.txtOrderedQuantity = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lblOdDt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(137, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.Location = new System.Drawing.Point(22, 56);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(78, 13);
            this.lblContactPhone.TabIndex = 2;
            this.lblContactPhone.Text = "Contact Phone";
            // 
            // lblItemOrdered
            // 
            this.lblItemOrdered.AutoSize = true;
            this.lblItemOrdered.Location = new System.Drawing.Point(22, 93);
            this.lblItemOrdered.Name = "lblItemOrdered";
            this.lblItemOrdered.Size = new System.Drawing.Size(68, 13);
            this.lblItemOrdered.TabIndex = 3;
            this.lblItemOrdered.Text = "Item Ordered";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(22, 134);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(40, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quatity";
            // 
            // txtOrderersName
            // 
            this.txtOrderersName.Enabled = false;
            this.txtOrderersName.Location = new System.Drawing.Point(112, 22);
            this.txtOrderersName.Name = "txtOrderersName";
            this.txtOrderersName.Size = new System.Drawing.Size(100, 20);
            this.txtOrderersName.TabIndex = 5;
            // 
            // txtOrderesPhone
            // 
            this.txtOrderesPhone.Enabled = false;
            this.txtOrderesPhone.Location = new System.Drawing.Point(112, 56);
            this.txtOrderesPhone.Name = "txtOrderesPhone";
            this.txtOrderesPhone.Size = new System.Drawing.Size(100, 20);
            this.txtOrderesPhone.TabIndex = 6;
            // 
            // txtItemOrdered
            // 
            this.txtItemOrdered.Enabled = false;
            this.txtItemOrdered.Location = new System.Drawing.Point(112, 93);
            this.txtItemOrdered.Name = "txtItemOrdered";
            this.txtItemOrdered.Size = new System.Drawing.Size(100, 20);
            this.txtItemOrdered.TabIndex = 7;
            // 
            // txtOrderedQuantity
            // 
            this.txtOrderedQuantity.Enabled = false;
            this.txtOrderedQuantity.Location = new System.Drawing.Point(112, 134);
            this.txtOrderedQuantity.Name = "txtOrderedQuantity";
            this.txtOrderedQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtOrderedQuantity.TabIndex = 8;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(112, 199);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPrice.TabIndex = 10;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(22, 202);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price $";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Location = new System.Drawing.Point(112, 166);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(100, 20);
            this.txtOrderDate.TabIndex = 12;
            // 
            // lblOdDt
            // 
            this.lblOdDt.AutoSize = true;
            this.lblOdDt.Location = new System.Drawing.Point(22, 169);
            this.lblOdDt.Name = "lblOdDt";
            this.lblOdDt.Size = new System.Drawing.Size(59, 13);
            this.lblOdDt.TabIndex = 11;
            this.lblOdDt.Text = "Order Date";
            // 
            // frmCustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 295);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lblOdDt);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtOrderedQuantity);
            this.Controls.Add(this.txtItemOrdered);
            this.Controls.Add(this.txtOrderesPhone);
            this.Controls.Add(this.txtOrderersName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItemOrdered);
            this.Controls.Add(this.lblContactPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Name = "frmCustomerOrder";
            this.Text = "Customer Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContactPhone;
        private System.Windows.Forms.Label lblItemOrdered;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtOrderersName;
        private System.Windows.Forms.TextBox txtOrderesPhone;
        private System.Windows.Forms.TextBox txtItemOrdered;
        private System.Windows.Forms.TextBox txtOrderedQuantity;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lblOdDt;
    }
}