namespace Dieu_khien__giam_sat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblParityBit = new System.Windows.Forms.Label();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblDataBit = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.cbxParityBit = new System.Windows.Forms.ComboBox();
            this.cbxStopBit = new System.Windows.Forms.ComboBox();
            this.cbxBaud = new System.Windows.Forms.ComboBox();
            this.cbxDataBit = new System.Windows.Forms.ComboBox();
            this.cbxCom = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxDieuKhien = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblChieu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rabThietbi2 = new System.Windows.Forms.RadioButton();
            this.rabThietbi1 = new System.Windows.Forms.RadioButton();
            this.groupBoxGiamSat = new System.Windows.Forms.GroupBox();
            this.groupBoxTocDo2 = new System.Windows.Forms.GroupBox();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.groupBoxTocDo1 = new System.Windows.Forms.GroupBox();
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.lblChieuR = new System.Windows.Forms.Label();
            this.txtCHIEU = new System.Windows.Forms.TextBox();
            this.groupBoxThongSo = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxDieuKhien.SuspendLayout();
            this.groupBoxGiamSat.SuspendLayout();
            this.groupBoxTocDo2.SuspendLayout();
            this.groupBoxTocDo1.SuspendLayout();
            this.groupBoxThongSo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblParityBit);
            this.groupBox1.Controls.Add(this.lblStopBit);
            this.groupBox1.Controls.Add(this.lblBaudRate);
            this.groupBox1.Controls.Add(this.lblDataBit);
            this.groupBox1.Controls.Add(this.lblCom);
            this.groupBox1.Controls.Add(this.cbxParityBit);
            this.groupBox1.Controls.Add(this.cbxStopBit);
            this.groupBox1.Controls.Add(this.cbxBaud);
            this.groupBox1.Controls.Add(this.cbxDataBit);
            this.groupBox1.Controls.Add(this.cbxCom);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều khiển cổng COM";
            // 
            // lblParityBit
            // 
            this.lblParityBit.AutoSize = true;
            this.lblParityBit.Location = new System.Drawing.Point(12, 170);
            this.lblParityBit.Name = "lblParityBit";
            this.lblParityBit.Size = new System.Drawing.Size(59, 16);
            this.lblParityBit.TabIndex = 1;
            this.lblParityBit.Text = "Parity Bit";
            // 
            // lblStopBit
            // 
            this.lblStopBit.AutoSize = true;
            this.lblStopBit.Location = new System.Drawing.Point(12, 140);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(53, 16);
            this.lblStopBit.TabIndex = 1;
            this.lblStopBit.Text = "Stop BIt";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(12, 80);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(68, 16);
            this.lblBaudRate.TabIndex = 1;
            this.lblBaudRate.Text = "BaudRate";
            // 
            // lblDataBit
            // 
            this.lblDataBit.AutoSize = true;
            this.lblDataBit.Location = new System.Drawing.Point(12, 110);
            this.lblDataBit.Name = "lblDataBit";
            this.lblDataBit.Size = new System.Drawing.Size(54, 16);
            this.lblDataBit.TabIndex = 1;
            this.lblDataBit.Text = "Data Bit";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(12, 50);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(72, 16);
            this.lblCom.TabIndex = 1;
            this.lblCom.Text = "Cổng COM";
            // 
            // cbxParityBit
            // 
            this.cbxParityBit.FormattingEnabled = true;
            this.cbxParityBit.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbxParityBit.Location = new System.Drawing.Point(120, 167);
            this.cbxParityBit.Name = "cbxParityBit";
            this.cbxParityBit.Size = new System.Drawing.Size(200, 24);
            this.cbxParityBit.TabIndex = 0;
            this.cbxParityBit.Text = "None";
            // 
            // cbxStopBit
            // 
            this.cbxStopBit.FormattingEnabled = true;
            this.cbxStopBit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbxStopBit.Location = new System.Drawing.Point(120, 137);
            this.cbxStopBit.Name = "cbxStopBit";
            this.cbxStopBit.Size = new System.Drawing.Size(200, 24);
            this.cbxStopBit.TabIndex = 0;
            this.cbxStopBit.Text = "One";
            // 
            // cbxBaud
            // 
            this.cbxBaud.FormattingEnabled = true;
            this.cbxBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbxBaud.Location = new System.Drawing.Point(120, 77);
            this.cbxBaud.Name = "cbxBaud";
            this.cbxBaud.Size = new System.Drawing.Size(200, 24);
            this.cbxBaud.TabIndex = 0;
            this.cbxBaud.Text = "9600";
            // 
            // cbxDataBit
            // 
            this.cbxDataBit.FormattingEnabled = true;
            this.cbxDataBit.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbxDataBit.Location = new System.Drawing.Point(120, 107);
            this.cbxDataBit.Name = "cbxDataBit";
            this.cbxDataBit.Size = new System.Drawing.Size(200, 24);
            this.cbxDataBit.TabIndex = 0;
            this.cbxDataBit.Text = "8";
            // 
            // cbxCom
            // 
            this.cbxCom.FormattingEnabled = true;
            this.cbxCom.Location = new System.Drawing.Point(120, 47);
            this.cbxCom.Name = "cbxCom";
            this.cbxCom.Size = new System.Drawing.Size(200, 24);
            this.cbxCom.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kết Nối";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 97);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(204, 27);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Chưa kết nối";
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.Location = new System.Drawing.Point(15, 56);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(305, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBoxDieuKhien
            // 
            this.groupBoxDieuKhien.Controls.Add(this.btnStop);
            this.groupBoxDieuKhien.Controls.Add(this.btnOk);
            this.groupBoxDieuKhien.Controls.Add(this.label3);
            this.groupBoxDieuKhien.Controls.Add(this.comboBox1);
            this.groupBoxDieuKhien.Controls.Add(this.textBox1);
            this.groupBoxDieuKhien.Controls.Add(this.lblChieu);
            this.groupBoxDieuKhien.Controls.Add(this.label1);
            this.groupBoxDieuKhien.Controls.Add(this.rabThietbi2);
            this.groupBoxDieuKhien.Controls.Add(this.rabThietbi1);
            this.groupBoxDieuKhien.Location = new System.Drawing.Point(12, 322);
            this.groupBoxDieuKhien.Name = "groupBoxDieuKhien";
            this.groupBoxDieuKhien.Size = new System.Drawing.Size(338, 242);
            this.groupBoxDieuKhien.TabIndex = 5;
            this.groupBoxDieuKhien.TabStop = false;
            this.groupBoxDieuKhien.Text = "Điều khiển thiết bị";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(181, 190);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 46);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(47, 190);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 46);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "RPM";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Quay theo chiều kim đồng hồ",
            "Quay ngược chiều kim đồng hồ"});
            this.comboBox1.Location = new System.Drawing.Point(102, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblChieu
            // 
            this.lblChieu.AutoSize = true;
            this.lblChieu.Location = new System.Drawing.Point(11, 143);
            this.lblChieu.Name = "lblChieu";
            this.lblChieu.Size = new System.Drawing.Size(76, 16);
            this.lblChieu.TabIndex = 2;
            this.lblChieu.Text = "Chiều Quay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tốc độ đặt";
            // 
            // rabThietbi2
            // 
            this.rabThietbi2.AutoSize = true;
            this.rabThietbi2.Location = new System.Drawing.Point(207, 44);
            this.rabThietbi2.Name = "rabThietbi2";
            this.rabThietbi2.Size = new System.Drawing.Size(82, 20);
            this.rabThietbi2.TabIndex = 0;
            this.rabThietbi2.TabStop = true;
            this.rabThietbi2.Text = "Thiết bị 2";
            this.rabThietbi2.UseVisualStyleBackColor = true;
            this.rabThietbi2.CheckedChanged += new System.EventHandler(this.rabThietbi2_CheckedChanged);
            // 
            // rabThietbi1
            // 
            this.rabThietbi1.AutoSize = true;
            this.rabThietbi1.Location = new System.Drawing.Point(47, 44);
            this.rabThietbi1.Name = "rabThietbi1";
            this.rabThietbi1.Size = new System.Drawing.Size(82, 20);
            this.rabThietbi1.TabIndex = 0;
            this.rabThietbi1.TabStop = true;
            this.rabThietbi1.Text = "Thiết bị 1";
            this.rabThietbi1.UseVisualStyleBackColor = true;
            this.rabThietbi1.CheckedChanged += new System.EventHandler(this.rabThietbi1_CheckedChanged_1);
            // 
            // groupBoxGiamSat
            // 
            this.groupBoxGiamSat.Controls.Add(this.groupBoxTocDo2);
            this.groupBoxGiamSat.Controls.Add(this.groupBoxTocDo1);
            this.groupBoxGiamSat.Controls.Add(this.groupBoxThongSo);
            this.groupBoxGiamSat.Location = new System.Drawing.Point(364, 12);
            this.groupBoxGiamSat.Name = "groupBoxGiamSat";
            this.groupBoxGiamSat.Size = new System.Drawing.Size(569, 552);
            this.groupBoxGiamSat.TabIndex = 6;
            this.groupBoxGiamSat.TabStop = false;
            this.groupBoxGiamSat.Text = "Giám sát các thông số của thiết bị";
            // 
            // groupBoxTocDo2
            // 
            this.groupBoxTocDo2.Controls.Add(this.circularProgressBar1);
            this.groupBoxTocDo2.Location = new System.Drawing.Point(297, 26);
            this.groupBoxTocDo2.Name = "groupBoxTocDo2";
            this.groupBoxTocDo2.Size = new System.Drawing.Size(266, 278);
            this.groupBoxTocDo2.TabIndex = 1;
            this.groupBoxTocDo2.TabStop = false;
            this.groupBoxTocDo2.Text = "Tốc độ động cơ 2";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(6, 23);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.SystemColors.Highlight;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 10;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.LawnGreen;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.circularProgressBar1.Size = new System.Drawing.Size(250, 231);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.Text = "00000";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.Value = 68;
            // 
            // groupBoxTocDo1
            // 
            this.groupBoxTocDo1.Controls.Add(this.circularProgressBar3);
            this.groupBoxTocDo1.Location = new System.Drawing.Point(22, 26);
            this.groupBoxTocDo1.Name = "groupBoxTocDo1";
            this.groupBoxTocDo1.Size = new System.Drawing.Size(269, 278);
            this.groupBoxTocDo1.TabIndex = 1;
            this.groupBoxTocDo1.TabStop = false;
            this.groupBoxTocDo1.Text = "Tốc độ động cơ 1";
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar3.AnimationSpeed = 500;
            this.circularProgressBar3.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.circularProgressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar3.InnerMargin = 2;
            this.circularProgressBar3.InnerWidth = -1;
            this.circularProgressBar3.Location = new System.Drawing.Point(6, 23);
            this.circularProgressBar3.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterColor = System.Drawing.SystemColors.Highlight;
            this.circularProgressBar3.OuterMargin = -25;
            this.circularProgressBar3.OuterWidth = 10;
            this.circularProgressBar3.ProgressColor = System.Drawing.Color.LawnGreen;
            this.circularProgressBar3.ProgressWidth = 25;
            this.circularProgressBar3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.circularProgressBar3.Size = new System.Drawing.Size(250, 231);
            this.circularProgressBar3.StartAngle = 270;
            this.circularProgressBar3.SubscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar3.SubscriptText = "";
            this.circularProgressBar3.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar3.SuperscriptMargin = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.circularProgressBar3.SuperscriptText = "";
            this.circularProgressBar3.TabIndex = 0;
            this.circularProgressBar3.Text = "00000";
            this.circularProgressBar3.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar3.Value = 68;
            // 
            // lblChieuR
            // 
            this.lblChieuR.AutoSize = true;
            this.lblChieuR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChieuR.Location = new System.Drawing.Point(66, 105);
            this.lblChieuR.Name = "lblChieuR";
            this.lblChieuR.Size = new System.Drawing.Size(139, 29);
            this.lblChieuR.TabIndex = 0;
            this.lblChieuR.Text = "Chiều quay:";
            // 
            // txtCHIEU
            // 
            this.txtCHIEU.Location = new System.Drawing.Point(265, 108);
            this.txtCHIEU.Name = "txtCHIEU";
            this.txtCHIEU.ReadOnly = true;
            this.txtCHIEU.Size = new System.Drawing.Size(241, 22);
            this.txtCHIEU.TabIndex = 1;
            // 
            // groupBoxThongSo
            // 
            this.groupBoxThongSo.Controls.Add(this.txtCHIEU);
            this.groupBoxThongSo.Controls.Add(this.lblChieuR);
            this.groupBoxThongSo.Location = new System.Drawing.Point(22, 310);
            this.groupBoxThongSo.Name = "groupBoxThongSo";
            this.groupBoxThongSo.Size = new System.Drawing.Size(541, 223);
            this.groupBoxThongSo.TabIndex = 2;
            this.groupBoxThongSo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 581);
            this.Controls.Add(this.groupBoxGiamSat);
            this.Controls.Add(this.groupBoxDieuKhien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giám sát và điều khiển";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxDieuKhien.ResumeLayout(false);
            this.groupBoxDieuKhien.PerformLayout();
            this.groupBoxGiamSat.ResumeLayout(false);
            this.groupBoxTocDo2.ResumeLayout(false);
            this.groupBoxTocDo1.ResumeLayout(false);
            this.groupBoxThongSo.ResumeLayout(false);
            this.groupBoxThongSo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.ComboBox cbxCom;
        private System.Windows.Forms.Label lblStopBit;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblDataBit;
        private System.Windows.Forms.ComboBox cbxStopBit;
        private System.Windows.Forms.ComboBox cbxBaud;
        private System.Windows.Forms.ComboBox cbxDataBit;
        private System.Windows.Forms.Label lblParityBit;
        private System.Windows.Forms.ComboBox cbxParityBit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblStatus;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBoxDieuKhien;
        private System.Windows.Forms.RadioButton rabThietbi2;
        private System.Windows.Forms.RadioButton rabThietbi1;
        private System.Windows.Forms.Label lblChieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBoxGiamSat;
        private System.Windows.Forms.GroupBox groupBoxTocDo1;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private System.Windows.Forms.GroupBox groupBoxTocDo2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.GroupBox groupBoxThongSo;
        private System.Windows.Forms.TextBox txtCHIEU;
        private System.Windows.Forms.Label lblChieuR;
    }
}

