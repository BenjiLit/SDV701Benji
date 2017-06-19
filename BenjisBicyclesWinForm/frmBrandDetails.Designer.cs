namespace BenjisBicyclesWinForm
{
    partial class frmBrandDetails
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
            this.btnAddBike = new System.Windows.Forms.Button();
            this.btnDeleteBike = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstBicycles = new System.Windows.Forms.ListBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblBrandContact = new System.Windows.Forms.Label();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtBrandContact = new System.Windows.Forms.TextBox();
            this.txtWarranyPeriod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSortBy = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbAddBike = new System.Windows.Forms.GroupBox();
            this.rbPushBike = new System.Windows.Forms.RadioButton();
            this.rbElectricBike = new System.Windows.Forms.RadioButton();
            this.lblHeading = new System.Windows.Forms.Label();
            this.gbSortBy.SuspendLayout();
            this.gbAddBike.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBike
            // 
            this.btnAddBike.Location = new System.Drawing.Point(95, 25);
            this.btnAddBike.Name = "btnAddBike";
            this.btnAddBike.Size = new System.Drawing.Size(74, 33);
            this.btnAddBike.TabIndex = 0;
            this.btnAddBike.Text = "Add bike";
            this.btnAddBike.UseVisualStyleBackColor = true;          
            // 
            // btnDeleteBike
            // 
            this.btnDeleteBike.Location = new System.Drawing.Point(221, 298);
            this.btnDeleteBike.Name = "btnDeleteBike";
            this.btnDeleteBike.Size = new System.Drawing.Size(78, 33);
            this.btnDeleteBike.TabIndex = 1;
            this.btnDeleteBike.Text = "Delete Bike";
            this.btnDeleteBike.UseVisualStyleBackColor = true;
            this.btnDeleteBike.Click += new System.EventHandler(this.btnDeleteBike_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(221, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstBicycles
            // 
            this.lstBicycles.FormattingEnabled = true;
            this.lstBicycles.Location = new System.Drawing.Point(20, 204);
            this.lstBicycles.Name = "lstBicycles";
            this.lstBicycles.Size = new System.Drawing.Size(279, 82);
            this.lstBicycles.TabIndex = 3;
            this.lstBicycles.DoubleClick += new System.EventHandler(this.lstBicycles_DoubleClick);
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(17, 25);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(66, 13);
            this.lblBrandName.TabIndex = 4;
            this.lblBrandName.Text = "Brand Name";
            // 
            // lblBrandContact
            // 
            this.lblBrandContact.AutoSize = true;
            this.lblBrandContact.Location = new System.Drawing.Point(17, 61);
            this.lblBrandContact.Name = "lblBrandContact";
            this.lblBrandContact.Size = new System.Drawing.Size(91, 13);
            this.lblBrandContact.TabIndex = 5;
            this.lblBrandContact.Text = "Brand Contact Ph";
            // 
            // lblWarranty
            // 
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Location = new System.Drawing.Point(17, 99);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(86, 13);
            this.lblWarranty.TabIndex = 6;
            this.lblWarranty.Text = "Warranty Period ";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Enabled = false;
            this.txtBrandName.Location = new System.Drawing.Point(167, 25);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(100, 20);
            this.txtBrandName.TabIndex = 7;
            // 
            // txtBrandContact
            // 
            this.txtBrandContact.Enabled = false;
            this.txtBrandContact.Location = new System.Drawing.Point(167, 61);
            this.txtBrandContact.Name = "txtBrandContact";
            this.txtBrandContact.Size = new System.Drawing.Size(100, 20);
            this.txtBrandContact.TabIndex = 8;
            // 
            // txtWarranyPeriod
            // 
            this.txtWarranyPeriod.Enabled = false;
            this.txtWarranyPeriod.Location = new System.Drawing.Point(167, 96);
            this.txtWarranyPeriod.Name = "txtWarranyPeriod";
            this.txtWarranyPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtWarranyPeriod.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bikes We Have";
            // 
            // gbSortBy
            // 
            this.gbSortBy.Controls.Add(this.radioButton2);
            this.gbSortBy.Controls.Add(this.radioButton1);
            this.gbSortBy.Location = new System.Drawing.Point(167, 136);
            this.gbSortBy.Name = "gbSortBy";
            this.gbSortBy.Size = new System.Drawing.Size(132, 52);
            this.gbSortBy.TabIndex = 11;
            this.gbSortBy.TabStop = false;
            this.gbSortBy.Text = "Sort By";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(66, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Price";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Name";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // gbAddBike
            // 
            this.gbAddBike.Controls.Add(this.rbPushBike);
            this.gbAddBike.Controls.Add(this.rbElectricBike);
            this.gbAddBike.Controls.Add(this.btnAddBike);
            this.gbAddBike.Location = new System.Drawing.Point(20, 300);
            this.gbAddBike.Name = "gbAddBike";
            this.gbAddBike.Size = new System.Drawing.Size(177, 76);
            this.gbAddBike.TabIndex = 12;
            this.gbAddBike.TabStop = false;
            this.gbAddBike.Text = "Add Bike Type";
            // 
            // rbPushBike
            // 
            this.rbPushBike.AutoSize = true;
            this.rbPushBike.Location = new System.Drawing.Point(7, 53);
            this.rbPushBike.Name = "rbPushBike";
            this.rbPushBike.Size = new System.Drawing.Size(49, 17);
            this.rbPushBike.TabIndex = 1;
            this.rbPushBike.TabStop = true;
            this.rbPushBike.Text = "Push";
            this.rbPushBike.UseVisualStyleBackColor = true;
            // 
            // rbElectricBike
            // 
            this.rbElectricBike.AutoSize = true;
            this.rbElectricBike.Checked = true;
            this.rbElectricBike.Location = new System.Drawing.Point(7, 20);
            this.rbElectricBike.Name = "rbElectricBike";
            this.rbElectricBike.Size = new System.Drawing.Size(60, 17);
            this.rbElectricBike.TabIndex = 0;
            this.rbElectricBike.TabStop = true;
            this.rbElectricBike.Text = "Electric";
            this.rbElectricBike.UseVisualStyleBackColor = true;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(21, 188);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(112, 13);
            this.lblHeading.TabIndex = 13;
            this.lblHeading.Text = "Model Name    Price $";
            // 
            // frmBrandDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 388);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.gbAddBike);
            this.Controls.Add(this.gbSortBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWarranyPeriod);
            this.Controls.Add(this.txtBrandContact);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.lblWarranty);
            this.Controls.Add(this.lblBrandContact);
            this.Controls.Add(this.lblBrandName);
            this.Controls.Add(this.lstBicycles);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteBike);
            this.Name = "frmBrandDetails";
            this.Text = "Brand Details";
            this.gbSortBy.ResumeLayout(false);
            this.gbSortBy.PerformLayout();
            this.gbAddBike.ResumeLayout(false);
            this.gbAddBike.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBike;
        private System.Windows.Forms.Button btnDeleteBike;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstBicycles;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblBrandContact;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.TextBox txtBrandContact;
        private System.Windows.Forms.TextBox txtWarranyPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSortBy;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gbAddBike;
        private System.Windows.Forms.RadioButton rbPushBike;
        private System.Windows.Forms.RadioButton rbElectricBike;
        private System.Windows.Forms.Label lblHeading;
    }
}