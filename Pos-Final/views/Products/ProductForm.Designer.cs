using System;

namespace Pos_Final.views.Products
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roundControlHeaderProduct = new RoundTextBoxProject.RoundControl();
            this.roundControlProduct = new RoundTextBoxProject.RoundControl();
            this.panelInputCategory = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCategoryName = new System.Windows.Forms.ComboBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundControl7 = new RoundTextBoxProject.RoundControl();
            this.roundControl8 = new RoundTextBoxProject.RoundControl();
            this.roundControl9 = new RoundTextBoxProject.RoundControl();
            this.roundControl3 = new RoundTextBoxProject.RoundControl();
            this.rcInputProduct = new RoundTextBoxProject.RoundControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundControl1 = new RoundTextBoxProject.RoundControl();
            this.txtSearchPt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roundControl2 = new RoundTextBoxProject.RoundControl();
            this.panelInputCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundControlHeaderProduct
            // 
            this.roundControlHeaderProduct.BackColor = System.Drawing.Color.LightGray;
            this.roundControlHeaderProduct.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControlHeaderProduct.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControlHeaderProduct.BorderWidth = 1F;
            this.roundControlHeaderProduct.Location = new System.Drawing.Point(11, -1);
            this.roundControlHeaderProduct.Margin = new System.Windows.Forms.Padding(2);
            this.roundControlHeaderProduct.Name = "roundControlHeaderProduct";
            this.roundControlHeaderProduct.Radius = 40;
            this.roundControlHeaderProduct.Size = new System.Drawing.Size(1788, 88);
            this.roundControlHeaderProduct.TabIndex = 15;
            this.roundControlHeaderProduct.Load += new System.EventHandler(this.roundControlHeaderProduct_Load);
            // 
            // roundControlProduct
            // 
            this.roundControlProduct.BackColor = System.Drawing.Color.Transparent;
            this.roundControlProduct.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.roundControlProduct.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControlProduct.BorderWidth = 1F;
            this.roundControlProduct.Location = new System.Drawing.Point(11, 81);
            this.roundControlProduct.Margin = new System.Windows.Forms.Padding(2);
            this.roundControlProduct.Name = "roundControlProduct";
            this.roundControlProduct.Radius = 30;
            this.roundControlProduct.Size = new System.Drawing.Size(1788, 928);
            this.roundControlProduct.TabIndex = 14;
            this.roundControlProduct.Load += new System.EventHandler(this.roundControlProduct_Load);
            // 
            // panelInputCategory
            // 
            this.panelInputCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.panelInputCategory.Controls.Add(this.label8);
            this.panelInputCategory.Controls.Add(this.cboCategoryName);
            this.panelInputCategory.Controls.Add(this.btnProductDelete);
            this.panelInputCategory.Controls.Add(this.btnBrowse);
            this.panelInputCategory.Controls.Add(this.picImage);
            this.panelInputCategory.Controls.Add(this.txtSellPrice);
            this.panelInputCategory.Controls.Add(this.label3);
            this.panelInputCategory.Controls.Add(this.txtBarcode);
            this.panelInputCategory.Controls.Add(this.btnProductUpdate);
            this.panelInputCategory.Controls.Add(this.btnSaveProduct);
            this.panelInputCategory.Controls.Add(this.txtName);
            this.panelInputCategory.Controls.Add(this.label6);
            this.panelInputCategory.Controls.Add(this.label2);
            this.panelInputCategory.Controls.Add(this.label1);
            this.panelInputCategory.Controls.Add(this.roundControl7);
            this.panelInputCategory.Controls.Add(this.roundControl8);
            this.panelInputCategory.Controls.Add(this.roundControl9);
            this.panelInputCategory.Controls.Add(this.roundControl3);
            this.panelInputCategory.Controls.Add(this.rcInputProduct);
            this.panelInputCategory.Location = new System.Drawing.Point(34, 97);
            this.panelInputCategory.Name = "panelInputCategory";
            this.panelInputCategory.Size = new System.Drawing.Size(658, 882);
            this.panelInputCategory.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 783);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 28);
            this.label8.TabIndex = 56;
            this.label8.Text = "CategoryName :";
            // 
            // cboCategoryName
            // 
            this.cboCategoryName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoryName.Location = new System.Drawing.Point(206, 783);
            this.cboCategoryName.Name = "cboCategoryName";
            this.cboCategoryName.Size = new System.Drawing.Size(230, 36);
            this.cboCategoryName.TabIndex = 57;
            this.cboCategoryName.SelectedIndexChanged += new System.EventHandler(this.cbCategoryId_SelectedIndexChanged_1);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.Red;
            this.btnProductDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnProductDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnProductDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnProductDelete.Image")));
            this.btnProductDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductDelete.Location = new System.Drawing.Point(472, 314);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnProductDelete.Size = new System.Drawing.Size(139, 35);
            this.btnProductDelete.TabIndex = 54;
            this.btnProductDelete.Text = "Delete ";
            this.btnProductDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(472, 580);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnBrowse.Size = new System.Drawing.Size(135, 35);
            this.btnBrowse.TabIndex = 52;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picImage.Location = new System.Drawing.Point(173, 414);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(263, 331);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 51;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSellPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellPrice.Location = new System.Drawing.Point(173, 322);
            this.txtSellPrice.Multiline = true;
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(263, 37);
            this.txtSellPrice.TabIndex = 48;
            this.txtSellPrice.TextChanged += new System.EventHandler(this.txtSellPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "Sell Price :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(173, 249);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(263, 37);
            this.txtBarcode.TabIndex = 46;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarCode_TextChanged);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnProductUpdate.Image")));
            this.btnProductUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductUpdate.Location = new System.Drawing.Point(473, 446);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnProductUpdate.Size = new System.Drawing.Size(139, 34);
            this.btnProductUpdate.TabIndex = 45;
            this.btnProductUpdate.Text = "Update ";
            this.btnProductUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductUpdate.UseVisualStyleBackColor = false;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveProduct.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveProduct.Image")));
            this.btnSaveProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProduct.Location = new System.Drawing.Point(475, 204);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Padding = new System.Windows.Forms.Padding(16, 0, 5, 0);
            this.btnSaveProduct.Size = new System.Drawing.Size(135, 35);
            this.btnSaveProduct.TabIndex = 43;
            this.btnSaveProduct.Text = "Save ";
            this.btnSaveProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(173, 168);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 37);
            this.txtName.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Input Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barcode : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // roundControl7
            // 
            this.roundControl7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl7.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.roundControl7.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl7.BorderWidth = 1F;
            this.roundControl7.Location = new System.Drawing.Point(444, 181);
            this.roundControl7.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl7.Name = "roundControl7";
            this.roundControl7.Radius = 40;
            this.roundControl7.Size = new System.Drawing.Size(197, 80);
            this.roundControl7.TabIndex = 82;
            this.roundControl7.Load += new System.EventHandler(this.roundControl7_Load);
            // 
            // roundControl8
            // 
            this.roundControl8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl8.BackgroundColor = System.Drawing.Color.Red;
            this.roundControl8.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl8.BorderWidth = 1F;
            this.roundControl8.Location = new System.Drawing.Point(443, 291);
            this.roundControl8.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl8.Name = "roundControl8";
            this.roundControl8.Radius = 40;
            this.roundControl8.Size = new System.Drawing.Size(197, 80);
            this.roundControl8.TabIndex = 83;
            // 
            // roundControl9
            // 
            this.roundControl9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.roundControl9.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl9.BorderWidth = 1F;
            this.roundControl9.Location = new System.Drawing.Point(444, 423);
            this.roundControl9.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl9.Name = "roundControl9";
            this.roundControl9.Radius = 40;
            this.roundControl9.Size = new System.Drawing.Size(197, 80);
            this.roundControl9.TabIndex = 84;
            // 
            // roundControl3
            // 
            this.roundControl3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl3.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.roundControl3.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl3.BorderWidth = 1F;
            this.roundControl3.Location = new System.Drawing.Point(441, 557);
            this.roundControl3.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl3.Name = "roundControl3";
            this.roundControl3.Radius = 40;
            this.roundControl3.Size = new System.Drawing.Size(197, 80);
            this.roundControl3.TabIndex = 85;
            // 
            // rcInputProduct
            // 
            this.rcInputProduct.BackColor = System.Drawing.Color.Gainsboro;
            this.rcInputProduct.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rcInputProduct.BorderColor = System.Drawing.Color.Teal;
            this.rcInputProduct.BorderWidth = 2F;
            this.rcInputProduct.ForeColor = System.Drawing.Color.Black;
            this.rcInputProduct.Location = new System.Drawing.Point(12, 16);
            this.rcInputProduct.Margin = new System.Windows.Forms.Padding(2);
            this.rcInputProduct.Name = "rcInputProduct";
            this.rcInputProduct.Radius = 30;
            this.rcInputProduct.Size = new System.Drawing.Size(644, 864);
            this.rcInputProduct.TabIndex = 5;
            this.rcInputProduct.Load += new System.EventHandler(this.rcInputProduct_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgProduct);
            this.panel1.Controls.Add(this.roundControl1);
            this.panel1.Location = new System.Drawing.Point(698, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 884);
            this.panel1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Product List ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgProduct
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProduct.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgProduct.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProduct.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgProduct.Location = new System.Drawing.Point(22, 80);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgProduct.RowHeadersWidth = 4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgProduct.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgProduct.RowTemplate.Height = 24;
            this.dgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProduct.Size = new System.Drawing.Size(1027, 773);
            this.dgProduct.TabIndex = 1;
            this.dgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductList_CellContentClick);
            this.dgProduct.DoubleClick += new System.EventHandler(this.dgProduct_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Barcode ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sell Price ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Qty InStock ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Category Id ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStockToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 36);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addStockToolStripMenuItem
            // 
            this.addStockToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            this.addStockToolStripMenuItem.Size = new System.Drawing.Size(166, 32);
            this.addStockToolStripMenuItem.Text = "AddStock";
            this.addStockToolStripMenuItem.Click += new System.EventHandler(this.addStockToolStripMenuItem_Click);
            // 
            // roundControl1
            // 
            this.roundControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.roundControl1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl1.BorderColor = System.Drawing.Color.Teal;
            this.roundControl1.BorderWidth = 2F;
            this.roundControl1.Location = new System.Drawing.Point(1, 16);
            this.roundControl1.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl1.Name = "roundControl1";
            this.roundControl1.Radius = 30;
            this.roundControl1.Size = new System.Drawing.Size(1070, 866);
            this.roundControl1.TabIndex = 0;
            // 
            // txtSearchPt
            // 
            this.txtSearchPt.BackColor = System.Drawing.Color.Teal;
            this.txtSearchPt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchPt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPt.ForeColor = System.Drawing.Color.Black;
            this.txtSearchPt.Location = new System.Drawing.Point(1505, 31);
            this.txtSearchPt.Multiline = true;
            this.txtSearchPt.Name = "txtSearchPt";
            this.txtSearchPt.Size = new System.Drawing.Size(235, 27);
            this.txtSearchPt.TabIndex = 48;
            this.txtSearchPt.TextChanged += new System.EventHandler(this.txtSearchPt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1399, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 28);
            this.label9.TabIndex = 49;
            this.label9.Text = "Search :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 41);
            this.label7.TabIndex = 13;
            this.label7.Text = "Product List ";
            // 
            // roundControl2
            // 
            this.roundControl2.BackColor = System.Drawing.Color.Teal;
            this.roundControl2.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControl2.BorderColor = System.Drawing.Color.Red;
            this.roundControl2.BorderWidth = 2F;
            this.roundControl2.Location = new System.Drawing.Point(1483, 12);
            this.roundControl2.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl2.Name = "roundControl2";
            this.roundControl2.Radius = 30;
            this.roundControl2.Size = new System.Drawing.Size(277, 63);
            this.roundControl2.TabIndex = 65;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1942, 1222);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearchPt);
            this.Controls.Add(this.roundControl2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInputCategory);
            this.Controls.Add(this.roundControlHeaderProduct);
            this.Controls.Add(this.roundControlProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load_1);
            this.panelInputCategory.ResumeLayout(false);
            this.panelInputCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cbCategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private RoundTextBoxProject.RoundControl roundControlHeaderProduct;
        private RoundTextBoxProject.RoundControl roundControlProduct;
        private System.Windows.Forms.Panel panelInputCategory;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RoundTextBoxProject.RoundControl rcInputProduct;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgProduct;
        private RoundTextBoxProject.RoundControl roundControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.ComboBox cboCategoryName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchPt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private RoundTextBoxProject.RoundControl roundControl2;
        private RoundTextBoxProject.RoundControl roundControl7;
        private RoundTextBoxProject.RoundControl roundControl8;
        private RoundTextBoxProject.RoundControl roundControl9;
        private RoundTextBoxProject.RoundControl roundControl3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
    }
}