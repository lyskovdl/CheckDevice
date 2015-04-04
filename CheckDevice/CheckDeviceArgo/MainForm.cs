using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckDeviceArgo
{
    public interface IMainForm
    {
        void ArrowPicture(int direction);
        decimal NumBuffSize { get; }
        int PortBaudRate { get; }
        string Port1Appoindet { get; }
        string Port2Appointed { get; }
        event EventHandler StartTest;
        event EventHandler<MsgEventArgs> MessageEvent;
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            this.Shown += (s, o) =>
            {
                Initialize();
            };
        }


        #region Проброс событий
        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (StartTest != null) StartTest(this, EventArgs.Empty);
        }
        #endregion

        #region Реализация IMainForm

        public void ArrowPicture(int direction)
        {

        }
        public decimal NumBuffSize { get { return numBuffSize.Value; } }
        public int PortBaudRate { get { return Convert.ToInt32(cbxBaudRate.Text); } }
        public string Port1Appoindet {get { return cbxPort1.Text; }}
        public string Port2Appointed {get { return cbxPort2.Text; }}
        public event EventHandler StartTest;
        public event EventHandler<MsgEventArgs> MessageEvent;

        #endregion



        public void Initialize()
        {
            cbxPort1.Items.AddRange(SerialPort.GetPortNames());
            if (cbxPort1.Items.Count != 0)
                cbxPort1.Text = cbxPort1.Items[0].ToString();
            else
            {
                if (MessageEvent != null) MessageEvent(this, new MsgEventArgs("Отсутствуют порты"));

            }
            cbxPort2.Items.AddRange(SerialPort.GetPortNames());
            if (cbxPort2.Items.Count > 1) cbxPort2.Text = cbxPort2.Items[1].ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pBLeftArrow_Click(object sender, EventArgs e)
        {

        }

        private void pBLeftArrow_Click_1(object sender, EventArgs e)
        {

        }


    }
}
