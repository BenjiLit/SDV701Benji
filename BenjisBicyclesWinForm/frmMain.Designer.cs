namespace BenjisBicyclesWinForm
{
    partial class frmMain
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
            this.lblBenjisBicycles = new System.Windows.Forms.Label();
            this.lstBicycleBrands = new System.Windows.Forms.ListBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalBrands = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnViewBrand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBenjisBicycles
            // 
            this.lblBenjisBicycles.AutoSize = true;
            this.lblBenjisBicycles.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenjisBicycles.Location = new System.Drawing.Point(70, 23);
            this.lblBenjisBicycles.Name = "lblBenjisBicycles";
            this.lblBenjisBicycles.Size = new System.Drawing.Size(170, 27);
            this.lblBenjisBicycles.TabIndex = 0;
            this.lblBenjisBicycles.Text = "Benji\'s Bicycles";
            // 
            // lstBicycleBrands
            // 
            this.lstBicycleBrands.FormattingEnabled = true;
            this.lstBicycleBrands.Location = new System.Drawing.Point(18, 105);
            this.lstBicycleBrands.Name = "lstBicycleBrands";
            this.lstBicycleBrands.Size = new System.Drawing.Size(144, 173);
            this.lstBicycleBrands.TabIndex = 1;
            this.lstBicycleBrands.DoubleClick += new System.EventHandler(this.lstBicycleBrands_DoubleClick);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(182, 243);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 35);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Our Brands...";
            // 
            // lblTotalBrands
            // 
            this.lblTotalBrands.AutoSize = true;
            this.lblTotalBrands.Location = new System.Drawing.Point(15, 295);
            this.lblTotalBrands.Name = "lblTotalBrands";
            this.lblTotalBrands.Size = new System.Drawing.Size(133, 13);
            this.lblTotalBrands.TabIndex = 7;
            this.lblTotalBrands.Text = "Total Brands We Stock : 5";
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(182, 192);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(100, 35);
            this.btnOrders.TabIndex = 8;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnViewBrand
            // 
            this.btnViewBrand.Location = new System.Drawing.Point(182, 140);
            this.btnViewBrand.Name = "btnViewBrand";
            this.btnViewBrand.Size = new System.Drawing.Size(100, 35);
            this.btnViewBrand.TabIndex = 9;
            this.btnViewBrand.Text = "View Brand";
            this.btnViewBrand.UseVisualStyleBackColor = true;
            this.btnViewBrand.Click += new System.EventHandler(this.btnViewBrand_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 337);
            this.Controls.Add(this.btnViewBrand);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.lblTotalBrands);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lstBicycleBrands);
            this.Controls.Add(this.lblBenjisBicycles);
            this.Name = "frmMain";
            this.Text = "Benji\'s Bicycles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBenjisBicycles;
        private System.Windows.Forms.ListBox lstBicycleBrands;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalBrands;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnViewBrand;
    }
}

