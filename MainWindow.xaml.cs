using Kontrol.Components;
using Kontrol.Security;
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

namespace Kontrol_Server_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = SecurityManager.Instance;
        }

        private void unauthorizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (lbAccepted.SelectedItem != null)
            {
                SecurityManager.Instance.DenyMAC(lbAccepted.SelectedItem.ToString());
            }
        }

        private void authorizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (lbUnaccepted.SelectedItem != null)
            {
                SecurityManager.Instance.AllowMAC(lbUnaccepted.SelectedItem.ToString());
            }
        }
    }
}