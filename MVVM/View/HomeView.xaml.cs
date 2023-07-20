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
using illumina.Core;
using Microsoft.VisualBasic.FileIO;

namespace illumina.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();

           
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Settings1.Default.QuickLogin == false)
            {
                MessageBox.Show("Old logins not found, please re-login!");
                try
                {
                    Settings1.Default.QuickLogin = true;
                    Handling.QuickSave();
                }
                catch
                {
                    Handling.Error101();
                }
            }
            else
            {
                MessageBox.Show("Old logins found! :)");
            }

            
        }
    }
}
