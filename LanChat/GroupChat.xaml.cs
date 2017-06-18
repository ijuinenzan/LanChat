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
    /// Interaction logic for GroupChat.xaml
    /// </summary>
    public partial class GroupChat : Window
    {
        public GroupChat()
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

            var user1 = new User
            {
                UserName = "Userrrrrrrrr1"
            };
            var user2 = new User
            {
                UserName = "Userrrrrrrrrrrrr2"
            };

            UserList.Items.Add(user1);
            UserList.Items.Add(user2);
            UserList.Items.Refresh();
        }

        private void SendMessage(object sender, RoutedEventArgs e)
        {

        }

        private void ChatPrivate(object sender, RoutedEventArgs e)
        {
            var privateChat = new PrivateChat (  );
            privateChat.Show (  );
        }
    }
}
