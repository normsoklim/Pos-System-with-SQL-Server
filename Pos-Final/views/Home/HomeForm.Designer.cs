namespace Pos_Final.views.Home
{
    partial class HomeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaleReport = new CustomControls.RJControls.RJButton();
            this.lblAllSale = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.roundControl6 = new RoundTextBoxProject.RoundControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReport = new CustomControls.RJControls.RJButton();
            this.lblAllPt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.roundControl5 = new RoundTextBoxProject.RoundControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStockReport = new CustomControls.RJControls.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAllStock = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.roundControl4 = new RoundTextBoxProject.RoundControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAllUser = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.roundControl3 = new RoundTextBoxProject.RoundControl();
            this.roundControl2 = new RoundTextBoxProject.RoundControl();
            this.roundControl1 = new RoundTextBoxProject.RoundControl();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.Mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Mainpanel
            // 
            this.Mainpanel.BackColor = System.Drawing.Color.LightGray;
            this.Mainpanel.Controls.Add(this.label11);
            this.Mainpanel.Controls.Add(this.label10);
            this.Mainpanel.Controls.Add(this.dateTimePickerTo);
            this.Mainpanel.Controls.Add(this.dateTimePickerFrom);
            this.Mainpanel.Controls.Add(this.btnLoad);
            this.Mainpanel.Controls.Add(this.chart1);
            this.Mainpanel.Controls.Add(this.panel4);
            this.Mainpanel.Controls.Add(this.panel3);
            this.Mainpanel.Controls.Add(this.panel2);
            this.Mainpanel.Controls.Add(this.panel1);
            this.Mainpanel.Controls.Add(this.roundControl2);
            this.Mainpanel.Controls.Add(this.roundControl1);
            this.Mainpanel.Location = new System.Drawing.Point(-12, 7);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(1810, 1049);
            this.Mainpanel.TabIndex = 4;
            this.Mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Mainpanel_Paint);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(61, 207);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(158, 54);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Show Chart ";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(61, 310);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Sales";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Profit ";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Top";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Stock";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Customer ";
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(1630, 711);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.btnSaleReport);
            this.panel4.Controls.Add(this.lblAllSale);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.roundControl6);
            this.panel4.Location = new System.Drawing.Point(1408, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 241);
            this.panel4.TabIndex = 13;
            // 
            // btnSaleReport
            // 
            this.btnSaleReport.BackColor = System.Drawing.Color.Teal;
            this.btnSaleReport.BackgroundColor = System.Drawing.Color.Teal;
            this.btnSaleReport.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaleReport.BorderRadius = 10;
            this.btnSaleReport.BorderSize = 1;
            this.btnSaleReport.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnSaleReport.FlatAppearance.BorderSize = 0;
            this.btnSaleReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Thistle;
            this.btnSaleReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.btnSaleReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnSaleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleReport.ForeColor = System.Drawing.Color.Black;
            this.btnSaleReport.Location = new System.Drawing.Point(166, 38);
            this.btnSaleReport.Name = "btnSaleReport";
            this.btnSaleReport.Size = new System.Drawing.Size(86, 31);
            this.btnSaleReport.TabIndex = 16;
            this.btnSaleReport.Text = "Report ";
            this.btnSaleReport.TextColor = System.Drawing.Color.Black;
            this.btnSaleReport.UseVisualStyleBackColor = false;
            this.btnSaleReport.Click += new System.EventHandler(this.btnSaleReport_Click);
            // 
            // lblAllSale
            // 
            this.lblAllSale.AutoSize = true;
            this.lblAllSale.BackColor = System.Drawing.Color.Teal;
            this.lblAllSale.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllSale.Location = new System.Drawing.Point(73, 99);
            this.lblAllSale.Name = "lblAllSale";
            this.lblAllSale.Size = new System.Drawing.Size(40, 38);
            this.lblAllSale.TabIndex = 13;
            this.lblAllSale.Text = "0 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Sale $ ";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Teal;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(29, 27);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(72, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // roundControl6
            // 
            this.roundControl6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl6.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControl6.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl6.BorderWidth = 2F;
            this.roundControl6.Location = new System.Drawing.Point(2, 11);
            this.roundControl6.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl6.Name = "roundControl6";
            this.roundControl6.Radius = 20;
            this.roundControl6.Size = new System.Drawing.Size(268, 221);
            this.roundControl6.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnReport);
            this.panel3.Controls.Add(this.lblAllPt);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.roundControl5);
            this.panel3.Location = new System.Drawing.Point(1097, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 241);
            this.panel3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(107, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Products";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Teal;
            this.btnReport.BackgroundColor = System.Drawing.Color.Teal;
            this.btnReport.BorderColor = System.Drawing.Color.Teal;
            this.btnReport.BorderRadius = 10;
            this.btnReport.BorderSize = 0;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Thistle;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Location = new System.Drawing.Point(165, 38);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(86, 31);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "Report ";
            this.btnReport.TextColor = System.Drawing.Color.Black;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblAllPt
            // 
            this.lblAllPt.AutoSize = true;
            this.lblAllPt.BackColor = System.Drawing.Color.Teal;
            this.lblAllPt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllPt.Location = new System.Drawing.Point(69, 100);
            this.lblAllPt.Name = "lblAllPt";
            this.lblAllPt.Size = new System.Drawing.Size(32, 38);
            this.lblAllPt.TabIndex = 14;
            this.lblAllPt.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total  Products";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Teal;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(36, 38);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // roundControl5
            // 
            this.roundControl5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl5.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControl5.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl5.BorderWidth = 2F;
            this.roundControl5.Location = new System.Drawing.Point(2, 11);
            this.roundControl5.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl5.Name = "roundControl5";
            this.roundControl5.Radius = 20;
            this.roundControl5.Size = new System.Drawing.Size(268, 221);
            this.roundControl5.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnStockReport);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblAllStock);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.roundControl4);
            this.panel2.Location = new System.Drawing.Point(780, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 241);
            this.panel2.TabIndex = 11;
            // 
            // btnStockReport
            // 
            this.btnStockReport.BackColor = System.Drawing.Color.Teal;
            this.btnStockReport.BackgroundColor = System.Drawing.Color.Teal;
            this.btnStockReport.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnStockReport.BorderRadius = 10;
            this.btnStockReport.BorderSize = 0;
            this.btnStockReport.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnStockReport.FlatAppearance.BorderSize = 0;
            this.btnStockReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.btnStockReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.btnStockReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnStockReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockReport.ForeColor = System.Drawing.Color.Black;
            this.btnStockReport.Location = new System.Drawing.Point(163, 35);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(86, 31);
            this.btnStockReport.TabIndex = 19;
            this.btnStockReport.Text = "Report ";
            this.btnStockReport.TextColor = System.Drawing.Color.Black;
            this.btnStockReport.UseVisualStyleBackColor = false;
            this.btnStockReport.Click += new System.EventHandler(this.btnStockReport_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Stocks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Stocks";
            // 
            // lblAllStock
            // 
            this.lblAllStock.AutoSize = true;
            this.lblAllStock.BackColor = System.Drawing.Color.Teal;
            this.lblAllStock.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllStock.Location = new System.Drawing.Point(53, 105);
            this.lblAllStock.Name = "lblAllStock";
            this.lblAllStock.Size = new System.Drawing.Size(32, 38);
            this.lblAllStock.TabIndex = 12;
            this.lblAllStock.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Teal;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(35, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // roundControl4
            // 
            this.roundControl4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl4.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControl4.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl4.BorderWidth = 2F;
            this.roundControl4.Location = new System.Drawing.Point(2, 11);
            this.roundControl4.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl4.Name = "roundControl4";
            this.roundControl4.Radius = 20;
            this.roundControl4.Size = new System.Drawing.Size(268, 221);
            this.roundControl4.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblAllUser);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.roundControl3);
            this.panel1.Location = new System.Drawing.Point(461, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 241);
            this.panel1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Users ";
            // 
            // lblAllUser
            // 
            this.lblAllUser.AutoSize = true;
            this.lblAllUser.BackColor = System.Drawing.Color.Teal;
            this.lblAllUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllUser.Location = new System.Drawing.Point(48, 105);
            this.lblAllUser.Name = "lblAllUser";
            this.lblAllUser.Size = new System.Drawing.Size(32, 38);
            this.lblAllUser.TabIndex = 11;
            this.lblAllUser.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Teal;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(39, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // roundControl3
            // 
            this.roundControl3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl3.BackgroundColor = System.Drawing.Color.Teal;
            this.roundControl3.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl3.BorderWidth = 2F;
            this.roundControl3.Location = new System.Drawing.Point(2, 11);
            this.roundControl3.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl3.Name = "roundControl3";
            this.roundControl3.Radius = 20;
            this.roundControl3.Size = new System.Drawing.Size(268, 221);
            this.roundControl3.TabIndex = 9;
            // 
            // roundControl2
            // 
            this.roundControl2.BackColor = System.Drawing.Color.Transparent;
            this.roundControl2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundControl2.BorderWidth = 1F;
            this.roundControl2.Location = new System.Drawing.Point(29, 288);
            this.roundControl2.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl2.Name = "roundControl2";
            this.roundControl2.Radius = 30;
            this.roundControl2.Size = new System.Drawing.Size(1690, 759);
            this.roundControl2.TabIndex = 1;
            // 
            // roundControl1
            // 
            this.roundControl1.BackColor = System.Drawing.Color.Transparent;
            this.roundControl1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.roundControl1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundControl1.BorderWidth = 1F;
            this.roundControl1.Location = new System.Drawing.Point(13, 16);
            this.roundControl1.Margin = new System.Windows.Forms.Padding(2);
            this.roundControl1.Name = "roundControl1";
            this.roundControl1.Radius = 20;
            this.roundControl1.Size = new System.Drawing.Size(1706, 268);
            this.roundControl1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 28);
            this.label11.TabIndex = 25;
            this.label11.Text = "Ending Date  From​:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 28);
            this.label10.TabIndex = 24;
            this.label10.Text = "Starting​ Date  From​:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(61, 162);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(255, 22);
            this.dateTimePickerTo.TabIndex = 23;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(61, 76);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(255, 22);
            this.dateTimePickerFrom.TabIndex = 22;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 1049);
            this.Controls.Add(this.Mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.Mainpanel.ResumeLayout(false);
            this.Mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel4;
        private CustomControls.RJControls.RJButton btnSaleReport;
        private System.Windows.Forms.Label lblAllSale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private RoundTextBoxProject.RoundControl roundControl6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJControls.RJButton btnReport;
        private System.Windows.Forms.Label lblAllPt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private RoundTextBoxProject.RoundControl roundControl5;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton btnStockReport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAllStock;
        private System.Windows.Forms.PictureBox pictureBox4;
        private RoundTextBoxProject.RoundControl roundControl4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAllUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private RoundTextBoxProject.RoundControl roundControl3;
        private RoundTextBoxProject.RoundControl roundControl2;
        private RoundTextBoxProject.RoundControl roundControl1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
    }
}