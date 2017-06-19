namespace BenjisBicyclesWinForm
{
    partial class frmOrders
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
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.lblOrdersPlaced = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.lblTotalOrdersValue = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(12, 48);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(155, 173);
            this.lstOrders.TabIndex = 0;
            this.lstOrders.DoubleClick += new System.EventHandler(this.lstOrders_DoubleClick);
            // 
            // lblOrdersPlaced
            // 
            this.lblOrdersPlaced.AutoSize = true;
            this.lblOrdersPlaced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersPlaced.Location = new System.Drawing.Point(37, 19);
            this.lblOrdersPlaced.Name = "lblOrdersPlaced";
            this.lblOrdersPlaced.Size = new System.Drawing.Size(95, 16);
            this.lblOrdersPlaced.TabIndex = 1;
            this.lblOrdersPlaced.Text = "Orders Placed";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(183, 198);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(183, 73);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrder.TabIndex = 3;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // lblTotalOrdersValue
            // 
            this.lblTotalOrdersValue.AutoSize = true;
            this.lblTotalOrdersValue.Location = new System.Drawing.Point(12, 238);
            this.lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            this.lblTotalOrdersValue.Size = new System.Drawing.Size(104, 13);
            this.lblTotalOrdersValue.TabIndex = 4;
            this.lblTotalOrdersValue.Text = "Total Orders Value $";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(112, 238);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(16, 13);
            this.lblTotalValue.TabIndex = 5;
            this.lblTotalValue.Text = "...";
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 276);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotalOrdersValue);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblOrdersPlaced);
            this.Controls.Add(this.lstOrders);
            this.Name = "frmOrders";
            this.Text = "Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Label lblOrdersPlaced;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label lblTotalOrdersValue;
        private System.Windows.Forms.Label lblTotalValue;
    }
}