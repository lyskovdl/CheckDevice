using CheckDeviceArgo.BL;
using System;


namespace CheckDeviceArgo
{
    public class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IDataTransfer _dataTransfer;
        private readonly IMessageServis _message;

        public MainPresenter(IMainForm view, IDataTransfer dataTransfer, IMessageServis message)
        {
            _view = view; _dataTransfer = dataTransfer; _message= message;

            _view.MessageEvent += _view_MessageEvent;
            _view.StartTest += _view_StartTest;

        }

        void _view_StartTest(object sender, EventArgs e)
        {
            if (_view.Port1Appoindet == null | _view.Port2Appointed == null
                | (_view.Port1Appoindet == _view.Port2Appointed))
            {
                _message.ShowExclamation("Не выполнены условия для запуска теста. Например: не выбран один из портов.");
            }
            else Start();
        }

        void _view_MessageEvent(object sender, MsgEventArgs e)
        {
            _message.ShowExclamation("Нет активных портов COM!");
        }

        private void Start()
        {
            _message.ShowMessage("Начинаем тест");
        }


    }

}
