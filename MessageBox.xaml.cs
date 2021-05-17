using System.Windows;
using System.Windows.Input;

namespace LabPyatnashki
{
    public partial class MessageBox : Window
    {
        MessageBoxResult Result = MessageBoxResult.None;
        public MessageBox()
        {
            InitializeComponent();
        }
        private void YesButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Result = MessageBoxResult.Yes;
            Close();
        }
        private void NoButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Result = MessageBoxResult.No;
            Close();
        }
        public static MessageBoxResult Show(string time, int turnNumber)
        {
            MessageBox dialog = new MessageBox();
            dialog.MessageContainer.Text = $"YOU WIN!\nYOUR TIME: {time}\nNUMBER OF TURNS: {turnNumber}\n PLAY AGAIN?";
            dialog.ShowDialog();
            return dialog.Result;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(Result == MessageBoxResult.None)
                e.Cancel = true;
        }
    }
}
