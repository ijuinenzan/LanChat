using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LanChat
{
    /// <summary>
    /// Interaction logic for PrivateChat.xaml
    /// </summary>
    public partial class PrivateChat : Window
    {
        public PrivateChat()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var message = new MessageItem
            {
                Content = "Hello",
                UserName = "User2",
                Time = DateTime.Now,
                Type = MessageType.Other
            };

            var message2 = new MessageItem
            {
                Content = "Hello",
                UserName = "User1",
                Time = DateTime.Now,
                Type = MessageType.Me
            };

            MessageList.Items.Add(message);
            MessageList.Items.Add(message2);
            MessageList.Items.Refresh();
        }

        private void SendMessage(object sender, RoutedEventArgs e)
        {

        }
    }
}
