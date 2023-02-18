namespace FinalProject___Salary_Budgeting_System
{
    partial class PaySlipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaySlipForm));
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnlPayslip = new System.Windows.Forms.Panel();
            this.lblCname = new System.Windows.Forms.Label();
            this.lblGpay = new System.Windows.Forms.Label();
            this.lblNpay = new System.Windows.Forms.Label();
            this.lblTotDeductions = new System.Windows.Forms.Label();
            this.lblNighthrs = new System.Windows.Forms.Label();
            this.lblNightOT = new System.Windows.Forms.Label();
            this.lblSSSP = new System.Windows.Forms.Label();
            this.lblHDMFP = new System.Windows.Forms.Label();
            this.lblPHICP = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblOT = new System.Windows.Forms.Label();
            this.lblTotHrs = new System.Windows.Forms.Label();
            this.lblHrate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlPayslip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(255, 651);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 39);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(86, 651);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 39);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pnlPayslip
            // 
            this.pnlPayslip.BackColor = System.Drawing.Color.White;
            this.pnlPayslip.Controls.Add(this.lblCname);
            this.pnlPayslip.Controls.Add(this.lblGpay);
            this.pnlPayslip.Controls.Add(this.lblNpay);
            this.pnlPayslip.Controls.Add(this.lblTotDeductions);
            this.pnlPayslip.Controls.Add(this.lblNighthrs);
            this.pnlPayslip.Controls.Add(this.lblNightOT);
            this.pnlPayslip.Controls.Add(this.lblSSSP);
            this.pnlPayslip.Controls.Add(this.lblHDMFP);
            this.pnlPayslip.Controls.Add(this.lblPHICP);
            this.pnlPayslip.Controls.Add(this.label23);
            this.pnlPayslip.Controls.Add(this.lblPosition);
            this.pnlPayslip.Controls.Add(this.lblOT);
            this.pnlPayslip.Controls.Add(this.lblTotHrs);
            this.pnlPayslip.Controls.Add(this.lblHrate);
            this.pnlPayslip.Controls.Add(this.lblDate);
            this.pnlPayslip.Controls.Add(this.lblDept);
            this.pnlPayslip.Controls.Add(this.lblName);
            this.pnlPayslip.Controls.Add(this.label21);
            this.pnlPayslip.Controls.Add(this.label20);
            this.pnlPayslip.Controls.Add(this.label19);
            this.pnlPayslip.Controls.Add(this.label18);
            this.pnlPayslip.Controls.Add(this.label17);
            this.pnlPayslip.Controls.Add(this.label16);
            this.pnlPayslip.Controls.Add(this.label15);
            this.pnlPayslip.Controls.Add(this.label14);
            this.pnlPayslip.Controls.Add(this.label13);
            this.pnlPayslip.Controls.Add(this.label12);
            this.pnlPayslip.Controls.Add(this.label11);
            this.pnlPayslip.Controls.Add(this.label10);
            this.pnlPayslip.Controls.Add(this.label9);
            this.pnlPayslip.Controls.Add(this.label8);
            this.pnlPayslip.Controls.Add(this.label7);
            this.pnlPayslip.Controls.Add(this.label6);
            this.pnlPayslip.Controls.Add(this.label5);
            this.pnlPayslip.Controls.Add(this.label4);
            this.pnlPayslip.Controls.Add(this.label3);
            this.pnlPayslip.Controls.Add(this.label2);
            this.pnlPayslip.Controls.Add(this.label1);
            this.pnlPayslip.Controls.Add(this.pictureBox2);
            this.pnlPayslip.Location = new System.Drawing.Point(24, 43);
            this.pnlPayslip.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPayslip.Name = "pnlPayslip";
            this.pnlPayslip.Size = new System.Drawing.Size(407, 598);
            this.pnlPayslip.TabIndex = 15;
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblCname.Location = new System.Drawing.Point(206, 555);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(14, 16);
            this.lblCname.TabIndex = 39;
            this.lblCname.Text = "0";
            // 
            // lblGpay
            // 
            this.lblGpay.AutoSize = true;
            this.lblGpay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblGpay.Location = new System.Drawing.Point(273, 471);
            this.lblGpay.Name = "lblGpay";
            this.lblGpay.Size = new System.Drawing.Size(16, 17);
            this.lblGpay.TabIndex = 38;
            this.lblGpay.Text = "0";
            // 
            // lblNpay
            // 
            this.lblNpay.AutoSize = true;
            this.lblNpay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNpay.Location = new System.Drawing.Point(273, 495);
            this.lblNpay.Name = "lblNpay";
            this.lblNpay.Size = new System.Drawing.Size(16, 17);
            this.lblNpay.TabIndex = 37;
            this.lblNpay.Text = "0";
            // 
            // lblTotDeductions
            // 
            this.lblTotDeductions.AutoSize = true;
            this.lblTotDeductions.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTotDeductions.Location = new System.Drawing.Point(273, 447);
            this.lblTotDeductions.Name = "lblTotDeductions";
            this.lblTotDeductions.Size = new System.Drawing.Size(16, 17);
            this.lblTotDeductions.TabIndex = 35;
            this.lblTotDeductions.Text = "0";
            // 
            // lblNighthrs
            // 
            this.lblNighthrs.AutoSize = true;
            this.lblNighthrs.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblNighthrs.Location = new System.Drawing.Point(273, 317);
            this.lblNighthrs.Name = "lblNighthrs";
            this.lblNighthrs.Size = new System.Drawing.Size(14, 16);
            this.lblNighthrs.TabIndex = 34;
            this.lblNighthrs.Text = "0";
            // 
            // lblNightOT
            // 
            this.lblNightOT.AutoSize = true;
            this.lblNightOT.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblNightOT.Location = new System.Drawing.Point(273, 336);
            this.lblNightOT.Name = "lblNightOT";
            this.lblNightOT.Size = new System.Drawing.Size(14, 16);
            this.lblNightOT.TabIndex = 33;
            this.lblNightOT.Text = "0";
            // 
            // lblSSSP
            // 
            this.lblSSSP.AutoSize = true;
            this.lblSSSP.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblSSSP.Location = new System.Drawing.Point(273, 374);
            this.lblSSSP.Name = "lblSSSP";
            this.lblSSSP.Size = new System.Drawing.Size(14, 16);
            this.lblSSSP.TabIndex = 32;
            this.lblSSSP.Text = "0";
            // 
            // lblHDMFP
            // 
            this.lblHDMFP.AutoSize = true;
            this.lblHDMFP.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblHDMFP.Location = new System.Drawing.Point(273, 392);
            this.lblHDMFP.Name = "lblHDMFP";
            this.lblHDMFP.Size = new System.Drawing.Size(14, 16);
            this.lblHDMFP.TabIndex = 31;
            this.lblHDMFP.Text = "0";
            // 
            // lblPHICP
            // 
            this.lblPHICP.AutoSize = true;
            this.lblPHICP.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblPHICP.Location = new System.Drawing.Point(273, 410);
            this.lblPHICP.Name = "lblPHICP";
            this.lblPHICP.Size = new System.Drawing.Size(14, 16);
            this.lblPHICP.TabIndex = 30;
            this.lblPHICP.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label23.Location = new System.Drawing.Point(273, 428);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 16);
            this.label23.TabIndex = 29;
            this.label23.Text = "0";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblPosition.Location = new System.Drawing.Point(186, 193);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(12, 16);
            this.lblPosition.TabIndex = 28;
            this.lblPosition.Text = "-";
            // 
            // lblOT
            // 
            this.lblOT.AutoSize = true;
            this.lblOT.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblOT.Location = new System.Drawing.Point(273, 285);
            this.lblOT.Name = "lblOT";
            this.lblOT.Size = new System.Drawing.Size(14, 16);
            this.lblOT.TabIndex = 27;
            this.lblOT.Text = "0";
            // 
            // lblTotHrs
            // 
            this.lblTotHrs.AutoSize = true;
            this.lblTotHrs.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblTotHrs.Location = new System.Drawing.Point(273, 269);
            this.lblTotHrs.Name = "lblTotHrs";
            this.lblTotHrs.Size = new System.Drawing.Size(14, 16);
            this.lblTotHrs.TabIndex = 26;
            this.lblTotHrs.Text = "0";
            // 
            // lblHrate
            // 
            this.lblHrate.AutoSize = true;
            this.lblHrate.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblHrate.Location = new System.Drawing.Point(273, 252);
            this.lblHrate.Name = "lblHrate";
            this.lblHrate.Size = new System.Drawing.Size(14, 16);
            this.lblHrate.TabIndex = 25;
            this.lblHrate.Text = "0";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDate.Location = new System.Drawing.Point(186, 210);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(12, 16);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "-";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblDept.Location = new System.Drawing.Point(186, 176);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(12, 16);
            this.lblDept.TabIndex = 23;
            this.lblDept.Text = "-";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblName.Location = new System.Drawing.Point(186, 158);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(12, 16);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label21.Location = new System.Drawing.Point(133, 555);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 16);
            this.label21.TabIndex = 21;
            this.label21.Text = "Conforme:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 6.5F);
            this.label20.Location = new System.Drawing.Point(34, 547);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 24);
            this.label20.TabIndex = 20;
            this.label20.Text = "Prepared: HR\r\nChecked: HR\r\n";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(45, 495);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 17);
            this.label19.TabIndex = 19;
            this.label19.Text = "NET PAY:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(64, 447);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 17);
            this.label18.TabIndex = 18;
            this.label18.Text = "Total:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(45, 471);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "GROSS PAY:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label16.Location = new System.Drawing.Point(73, 428);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "TAX:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label15.Location = new System.Drawing.Point(73, 392);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "HDMF Premium:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label14.Location = new System.Drawing.Point(73, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "PHIC Premium:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label13.Location = new System.Drawing.Point(72, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "SSS Premium:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label12.Location = new System.Drawing.Point(71, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Night overtime:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label11.Location = new System.Drawing.Point(71, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Night shift hours:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 7.5F);
            this.label10.Location = new System.Drawing.Point(65, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "NIGHT SHIFT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label9.Location = new System.Drawing.Point(70, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Overtime:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label8.Location = new System.Drawing.Point(70, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total work of hours:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label7.Location = new System.Drawing.Point(71, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Basic hourly rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(45, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Deductions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(45, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Earnings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(44, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label3.Location = new System.Drawing.Point(44, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label2.Location = new System.Drawing.Point(44, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label1.Location = new System.Drawing.Point(45, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FinalProject___Salary_Budgeting_System.Properties.Resources.PLMun_Payslip_png;
            this.pictureBox2.Location = new System.Drawing.Point(-133, -19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(659, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PaySlipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(456, 705);
            this.Controls.Add(this.pnlPayslip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaySlipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payslip";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaySlipForm_MouseDown);
            this.pnlPayslip.ResumeLayout(false);
            this.pnlPayslip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel pnlPayslip;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblCname;
        public System.Windows.Forms.Label lblGpay;
        public System.Windows.Forms.Label lblNpay;
        public System.Windows.Forms.Label lblTotDeductions;
        public System.Windows.Forms.Label lblNighthrs;
        public System.Windows.Forms.Label lblNightOT;
        public System.Windows.Forms.Label lblSSSP;
        public System.Windows.Forms.Label lblHDMFP;
        public System.Windows.Forms.Label lblPHICP;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.Label lblPosition;
        public System.Windows.Forms.Label lblOT;
        public System.Windows.Forms.Label lblTotHrs;
        public System.Windows.Forms.Label lblHrate;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblDept;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}