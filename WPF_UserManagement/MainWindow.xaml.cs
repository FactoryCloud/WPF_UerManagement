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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Packt.CS7;

namespace WPF_UserManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Page2 RightSide;
        public MainWindow()
        {
            InitializeComponent();
            RightSide = new Page2();
            frame2.Content = RightSide;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var db = new GestCloudDB();
            var a = (Page1)frame.Content;
            MessageBox.Show(a.Username.Text);
            foreach(User user in db.Users)
            {
                a.Username.Text = user.Username;
            }
        }
    }
}
