using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Dieu_khien__giam_sat
{
    public partial class Form1 : Form
    {
        string dataOut;
        string dataIn;
        string NumberControl;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxBaud.Enabled = true;
            cbxCom.Enabled = true;
            cbxDataBit.Enabled = true;
            cbxParityBit.Enabled = true;
            cbxStopBit.Enabled = true;

            textBox1.Enabled = false;

            comboBox1.Enabled = false;

            circularProgressBar3.Value = 0;
            circularProgressBar1.Value = 0;

            comboBox1.SelectedIndex = 0;

            groupBoxGiamSat.Enabled = false;
            groupBoxDieuKhien.Enabled = false;

            string[] Ports = SerialPort.GetPortNames();
            int[] ComNumberList = new int[Ports.Length];
            for (int i = 0; i < Ports.Length; i++)
            {
                ComNumberList[i] = int.Parse(Ports[i].Substring(3));
            }
            Array.Sort(ComNumberList);
            foreach (int ComNumber in ComNumberList)
            {
                cbxCom.Items.Add("COM" + ComNumber.ToString());
            }
            bool found = false;
            foreach (string str in cbxCom.Items)
            {
                if (str == Properties.Settings.Default.PortName)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                cbxCom.Text = Properties.Settings.Default.PortName;
            }
            else
            {

            }
        }
        private void SaveSetting()
        {
            Properties.Settings.Default.PortName = cbxCom.Text;
            Properties.Settings.Default.Save();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                button1.Text = "Kết nối";
                lblStatus.Text = "Chưa kết nối";
                progressBar1.Value = 0;
                cbxBaud.Enabled = true;
                cbxCom.Enabled = true;
                cbxDataBit.Enabled = true;
                cbxParityBit.Enabled = true;
                cbxStopBit.Enabled = true;
            }
            else
            {
                try
                    {
                        cbxBaud.Enabled = false;
                        cbxCom.Enabled = false;
                        cbxDataBit.Enabled = false;
                        cbxParityBit.Enabled = false;
                        cbxStopBit.Enabled = false;
                        serialPort1.PortName = cbxCom.Text;
                        serialPort1.BaudRate = Convert.ToInt32(cbxBaud.Text);
                        serialPort1.DataBits = Convert.ToInt32(cbxDataBit.Text);
                        serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits),cbxStopBit.Text);
                        serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbxParityBit.Text);
                        serialPort1.Open(); 
                        progressBar1.Value = 100;
                        button1.Text = "Ngắt kết nối";
                        lblStatus.Text = "Đã kết nối";
                        groupBoxDieuKhien.Enabled = true;
                }
                 catch (Exception err)
                    {
                        MessageBox.Show(err.Message,"Không thể kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
        private void rabThietbi1_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBoxGiamSat.Enabled = true;
            groupBoxTocDo1.Enabled = true;
            groupBoxTocDo2.Enabled = false;
            NumberControl = "0";
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void rabThietbi2_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxGiamSat.Enabled = true;
            groupBoxTocDo1.Enabled = false;
            groupBoxTocDo2.Enabled = true;
            NumberControl = "1";
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn thực sự muốn thoát?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
            else
            {
                e.Cancel = true;
            }
            SaveSetting();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
          
            if (serialPort1.IsOpen)
            {
                dataOut = NumberControl +","+ comboBox1.SelectedIndex + "," + textBox1.Text + "," + "#";
                serialPort1.WriteLine(dataOut);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                textBox1.Text = ""; 
            }
            dataOut = NumberControl + "," + comboBox1.SelectedIndex + "," + "0" + "," + "#";
            serialPort1.WriteLine(dataOut);
        }
        public string KiemTra (string input)
        {
            for(int i = 0; i<input.Length; i++)
            {
                if (input.Contains("#"))
                {
                    input = input.Substring(0, input.IndexOf("#"));
                }
            }
            return input;
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = "";
            dataIn = serialPort1.ReadExisting();
            dataIn = KiemTra(dataIn);
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {

            string[] SplitDataIn = dataIn.Split(',');
            try
            {
                if ((SplitDataIn[0]) == "0")
                {
                    circularProgressBar3.Maximum = Convert.ToInt32(SplitDataIn[5]);
                    circularProgressBar3.Text = SplitDataIn[2];
                    circularProgressBar3.Value = Convert.ToInt32(SplitDataIn[2]);
                    if (rabThietbi1.Checked)
                    {
                        //txtDong.Text = SplitDataIn[3];
                        //txtAp.Text = SplitDataIn[4];
                        if ((SplitDataIn[1]) == "1")
                        {
                            txtCHIEU.Text = "Quay theo chiều kim đồng hồ";
                        }
                        else
                        {
                            txtCHIEU.Text = "Quay theo chiều kim đồng hồ";
                        }
                    }

                }
                else
                {
                    circularProgressBar1.Maximum = Convert.ToInt32(SplitDataIn[5]);
                    circularProgressBar1.Text = SplitDataIn[2];
                    circularProgressBar1.Value = Convert.ToInt32(SplitDataIn[2]);
                    if (rabThietbi2.Checked)
                    {
                        //txtDong.Text = SplitDataIn[3];
                        //txtAp.Text = SplitDataIn[4];
                        if ((SplitDataIn[1]) == "1")
                        {
                            txtCHIEU.Text = "Quay theo chiều kim đồng hồ";
                        }
                        else
                        {
                            txtCHIEU.Text = "Quay theo chiều kim đồng hồ";
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Có lỗi xảy ra", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (circularProgressBar3.Value >= 0 && circularProgressBar3.Value <= 0.5 * circularProgressBar3.Maximum)
            {
                circularProgressBar3.ProgressColor = Color.LawnGreen;
            }
            if (circularProgressBar3.Value > 0.5 * circularProgressBar3.Maximum && circularProgressBar3.Value <= 0.75 * circularProgressBar3.Maximum)
            {
                circularProgressBar3.ProgressColor = Color.Yellow;
            }
            if (circularProgressBar3.Value > 0.75 * circularProgressBar3.Maximum && circularProgressBar3.Value <= circularProgressBar3.Maximum)
            {
                circularProgressBar3.ProgressColor = Color.Red;
            }

            if (circularProgressBar1.Value >= 0 && circularProgressBar3.Value <= 50)
            {
                circularProgressBar1.ProgressColor = Color.LawnGreen;
            }
            if (circularProgressBar1.Value > 50 && circularProgressBar3.Value <= 85)
            {
                circularProgressBar1.ProgressColor = Color.Yellow;
            }
            if (circularProgressBar1.Value > 85 && circularProgressBar3.Value <= 100)
            {
                circularProgressBar1.ProgressColor = Color.Red;
            }
        }

    }
}
