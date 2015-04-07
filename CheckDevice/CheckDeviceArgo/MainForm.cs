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
        decimal NumBuffSize { get; }
        int PortBaudRate { get; }
        string Port1Appoindet { get; }
        string Port2Appointed { get; }
        void ArrowPicture( Constans.ArrowsPicture arrowsPicture);
        void PrgsBarTestInit(int prgsBarMax, int prgsBarStep, bool prgsBarVisible);
        void PrgsBarTestProgress();
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
        public void Initialize()
        {
            cbxPort1.Items.AddRange(SerialPort.GetPortNames());
            if (cbxPort1.Items.Count != 0) cbxPort1.Text = cbxPort1.Items[0].ToString();
            cbxPort2.Items.AddRange(SerialPort.GetPortNames());
            if (cbxPort2.Items.Count > 1) cbxPort2.Text = cbxPort2.Items[1].ToString();
        }

 
        #region Проброс событий
        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (StartTest != null) StartTest(this, EventArgs.Empty);
        }
        #endregion

        #region Реализация IMainForm

        public decimal NumBuffSize { get { return numBuffSize.Value; } }
        public int PortBaudRate { get { return Convert.ToInt32(cbxBaudRate.Text); } }
        public string Port1Appoindet {get { return cbxPort1.Text; }}
        public string Port2Appointed {get { return cbxPort2.Text; }}
        public void ArrowPicture(Constans.ArrowsPicture arrowsPicture)
        {
            // ensure UI is updated from cocrrect thread
            this.Invoke((Action)(() =>
            {
                switch ((int)arrowsPicture)
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
            }));
        }

        #region Инициализация градусника теста
        private readonly int defaultprgsBarStep = 1;
        private readonly int defaulprgsBarMax = 1;
        public void PrgsBarTestInit(bool prgsBarVisible)
        {
            PrgsBarTestInit(defaulprgsBarMax, defaultprgsBarStep, prgsBarVisible);
        }
        public void PrgsBarTestInit(int prgsBarMax, bool prgsBarVisible)
        {
            PrgsBarTestInit(prgsBarMax, defaultprgsBarStep, prgsBarVisible);
        }
        public void PrgsBarTestInit(int prgsBarMax, int prgsBarStep, bool prgsBarVisible)
        {
            // ensure UI is updated from cocrrect thread
            this.Invoke((Action)(() =>
            {
                prgsBarTest.Minimum = 1;
                prgsBarTest.Value = 1;
                prgsBarTest.Step = prgsBarStep;
                prgsBarTest.Maximum = prgsBarMax;
                prgsBarTest.Visible = prgsBarVisible;
                this.Activate();
            }));
        }
        #endregion

        public void PrgsBarTestProgress()
        {
            // ensure UI is updated from cocrrect thread
            this.Invoke((Action)(() =>
            {
                prgsBarTest.PerformStep();
            }));
        }

        public event EventHandler StartTest;

        #endregion


    }
}
