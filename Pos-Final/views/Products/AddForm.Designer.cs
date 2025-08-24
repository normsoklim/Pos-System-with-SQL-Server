namespace Pos_Final.views.Products
{
    partial class AddForm
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
            this.panelInputCategory = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRiel = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSppName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveStock = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundControl7 = new RoundTextBoxProject.RoundControl();
            this.rcInputProduct = new RoundTextBoxProject.RoundControl();
            this.panelInputCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInputCategory
            // 
            this.panelInputCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.panelInputCategory.Controls.Add(this.txtPrice);
            this.panelInputCategory.Controls.Add(this.txtQty);
            this.panelInputCategory.Controls.Add(this.label3);
            this.panelInputCategory.Controls.Add(this.lblName);
            this.panelInputCategory.Controls.Add(this.lblId);
            this.panelInputCategory.Controls.Add(this.label10);
            this.panelInputCategory.Controls.Add(this.label7);
            this.panelInputCategory.Controls.Add(this.lblRiel);
            this.panelInputCategory.Controls.Add(this.lblAmount);
            this.panelInputCategory.Controls.Add(this.label8);
            this.panelInputCategory.Controls.Add(this.cboSppName);
            this.panelInputCategory.Controls.Add(this.label1);
            this.panelInputCategory.Controls.Add(this.btnSaveStock);
            this.panelInputCategory.Controls.Add(this.label6);
            this.panelInputCategory.Controls.Add(this.label2);
            this.panelInputCategory.Controls.Add(this.roundControl7);
            this.panelInputCategory.Controls.Add(this.rcInputProduct);
            this.panelInputCategory.Location = new System.Drawing.Point(-8, 1);
            this.panelInputCategory.Name = "panelInputCategory";
            this.panelInputCategory.Size = new System.Drawing.Size(669, 731);
            this.panelInputCategory.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(235, 333);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(210, 34);
            this.txtPrice.TabIndex = 91;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(235, 251);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(210, 34);
            this.txtQty.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 89;
            this.label3.Text = "Product Name :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(250, 171);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 28);
            this.lblName.TabIndex = 88;
            this.lblName.Text = "________________";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(250, 100);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(140, 28);
            this.lblId.TabIndex = 87;
            this.lblId.Text = "________________";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(91, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 28);
            this.label10.TabIndex = 86;
            this.label10.Text = "Product Id :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 60;
            // 
            // lblRiel
            // 
            this.lblRiel.AutoSize = true;
            this.lblRiel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRiel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiel.Location = new System.Drawing.Point(411, 498);
            this.lblRiel.Name = "lblRiel";
            this.lblRiel.Size = new System.Drawing.Size(0, 31);
            this.lblRiel.TabIndex = 58;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(411, 435);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 31);
            this.lblAmount.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 28);
            this.label8.TabIndex = 56;
            this.label8.Text = "SupplierName :";
            // 
            // cboSppName
            // 
            this.cboSppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSppName.FormattingEnabled = true;
            this.cboSppName.Location = new System.Drawing.Point(231, 434);
            this.cboSppName.Name = "cboSppName";
            this.cboSppName.Size = new System.Drawing.Size(214, 36);
            this.cboSppName.TabIndex = 55;
            this.cboSppName.SelectedIndexChanged += new System.EventHandler(this.cboSppName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "Price :";
            // 
            // btnSaveStock
            // 
            this.btnSaveStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveStock.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveStock.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveStock.FlatAppearance.BorderSize = 0;
            this.btnSaveStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveStock.Location = new System.Drawing.Point(245, 558);
            this.btnSaveStock.Name = "btnSaveStock";
            this.btnSaveStock.Padding = new System.Windows.Forms.Padding(16, 0, 5, 0);
            this.btnSaveStock.Size = new System.Drawing.Size(172, 43);
            this.btnSaveStock.TabIndex = 43;
            this.btnSaveStock.Text = "Confirm";
            this.btnSaveStock.UseVisualStyleBackColor = false;
            this.btnSaveStock.Click += new System.EventHandler(this.btnSaveStock_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Input AddStock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qty : ";
            // 
            // roundControl7
            // 
            this.roundControl7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl7.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.roundControl7.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl7.BorderWidth = 1F;
            this.roundControl7.Location = new System.Drawing.Point(214, 533);
            this.roundControl7.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl7.Name = "roundControl7";
            this.roundControl7.Radius = 40;
            this.roundControl7.Size = new System.Drawing.Size(239, 89);
            this.roundControl7.TabIndex = 82;
            // 
            // rcInputProduct
            // 
            this.rcInputProduct.BackColor = System.Drawing.Color.Gainsboro;
            this.rcInputProduct.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rcInputProduct.BorderColor = System.Drawing.Color.Teal;
            this.rcInputProduct.BorderWidth = 2F;
            this.rcInputProduct.ForeColor = System.Drawing.Color.Black;
            this.rcInputProduct.Location = new System.Drawing.Point(29, 10);
            this.rcInputProduct.Margin = new System.Windows.Forms.Padding(2);
            this.rcInputProduct.Name = "rcInputProduct";
            this.rcInputProduct.Radius = 30;
            this.rcInputProduct.Size = new System.Drawing.Size(623, 677);
            this.rcInputProduct.TabIndex = 5;
            this.rcInputProduct.Load += new System.EventHandler(this.rcInputProduct_Load);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(655, 715);
            this.Controls.Add(this.panelInputCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.panelInputCategory.ResumeLayout(false);
            this.panelInputCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInputCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRiel;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSppName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private RoundTextBoxProject.RoundControl roundControl7;
        private RoundTextBoxProject.RoundControl rcInputProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblId;
    }
}