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
using System.Threading;

namespace CheckDeviceArgo
{
        public interface IMainForm
    {
        void ArrowPicture( Constans.ArrowsPicture arrowsPicture);
        decimal NumBuffSize { get; }
        int PortBaudRate { get; }
        string Port1Appoindet { get; }
        string Port2Appointed { get; }
        event EventHandler StartTest;
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

        public void ArrowPicture(Constans.ArrowsPicture arrowsPicture)
        {
            switch ((int) arrowsPicture)
            {
                case 1:
                    pBLeftArrow.Visible = true;
                    break;
                case 2:
                    pBLeftArrow.Visible = false;
                    pBRightArrow.Visible = true;
                    break;
                case 0:
                    pBLeftArrow.Visible = false;
                    pBRightArrow.Visible = false;
                    break;
                default:
                    break;
            };
            pBRightArrow.Refresh();
            pBLeftArrow.Refresh();
        }

        public decimal NumBuffSize { get { return numBuffSize.Value; } }
        public int PortBaudRate { get { return Convert.ToInt32(cbxBaudRate.Text); } }
        public string Port1Appoindet {get { return cbxPort1.Text; }}
        public string Port2Appointed {get { return cbxPort2.Text; }}
        public event EventHandler StartTest;

        #endregion



        public void Initialize()
        {
            cbxPort1.Items.AddRange(SerialPort.GetPortNames());
            if (cbxPort1.Items.Count != 0) cbxPort1.Text = cbxPort1.Items[0].ToString();
            cbxPort2.Items.AddRange(SerialPort.GetPortNames());
            if (cbxPort2.Items.Count > 1) cbxPort2.Text = cbxPort2.Items[1].ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1; int j = 100;
            prgsBarTest.Minimum = i;
            prgsBarTest.Value = i;
            prgsBarTest.Step = i;
            prgsBarTest.Maximum = j;
            prgsBarTest.Visible = true;
            while (i < j)
            {
                Thread.Sleep(50);
                prgsBarTest.PerformStep();
                i++;
            } 

        }
        

    }
}
