using System.Windows.Forms;

namespace CheckDeviceArgo
{

    public interface IMessageServis
    {
        void ShowMessage(string message);
        void ShowExclamation(string message);
        void ShowError(string message);
    }


    public  class MessageServis : IMessageServis
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение111111", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
        public void ShowExclamation(string message)
        {
            MessageBox.Show(message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
        }
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
    }
}
