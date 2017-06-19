namespace BenjisBicyclesWinForm
{
    partial class frmBicycle
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblModelName = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblStockQ = new System.Windows.Forms.Label();
            this.txtLastEdited = new System.Windows.Forms.TextBox();
            this.lblLastEdited = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(236, 21);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 63);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(12, 24);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(67, 13);
            this.lblModelName.TabIndex = 2;
            this.lblModelName.Text = "Model Name";
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(108, 21);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(100, 20);
            this.txtModelName.TabIndex = 3;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(108, 163);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(108, 67);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price $";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(108, 116);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Weight Kg";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(108, 209);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 13;
            // 
            // lblStockQ
            // 
            this.lblStockQ.AutoSize = true;
            this.lblStockQ.Location = new System.Drawing.Point(12, 212);
            this.lblStockQ.Name = "lblStockQ";
            this.lblStockQ.Size = new System.Drawing.Size(77, 13);
            this.lblStockQ.TabIndex = 12;
            this.lblStockQ.Text = "Stock Quantity";
            // 
            // txtLastEdited
            // 
            this.txtLastEdited.Location = new System.Drawing.Point(108, 256);
            this.txtLastEdited.Name = "txtLastEdited";
            this.txtLastEdited.Size = new System.Drawing.Size(100, 20);
            this.txtLastEdited.TabIndex = 11;
            // 
            // lblLastEdited
            // 
            this.lblLastEdited.AutoSize = true;
            this.lblLastEdited.Location = new System.Drawing.Point(12, 259);
            this.lblLastEdited.Name = "lblLastEdited";
            this.lblLastEdited.Size = new System.Drawing.Size(60, 13);
            this.lblLastEdited.TabIndex = 10;
            this.lblLastEdited.Text = "Last Edited";
            // 
            // frmBicycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 340);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblStockQ);
            this.Controls.Add(this.txtLastEdited);
            this.Controls.Add(this.lblLastEdited);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.lblModelName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "frmBicycle";
            this.Text = "Bicycle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblStockQ;
        private System.Windows.Forms.TextBox txtLastEdited;
        private System.Windows.Forms.Label lblLastEdited;
    }
}