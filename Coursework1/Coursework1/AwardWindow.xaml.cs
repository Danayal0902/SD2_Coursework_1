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

namespace Coursework1
{
    /// <summary>
    /// Interaction logic for AwardWindow.xaml
    /// Author: Danayal Iftikhar
    /// This class is used to provide a GUI for the input from the Main window and display award details based on those values
    /// Last Modified: 22/10/2015
    /// </summary>
    public partial class AwardWindow : Window
    {
        public AwardWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Owner.Show(); //Open the Main window
            Close(); //Close the current window
        }
    }
}
