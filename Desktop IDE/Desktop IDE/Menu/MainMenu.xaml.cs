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

namespace Desktop_IDE
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl,Switchable
    {
        //MainWindow main1 = new MainWindow();
        public MainMenu()
        {
            InitializeComponent();
            //main1.ResizeMode = System.Windows.ResizeMode.NoResize;
            //main1.Height = 350; main1.Width = 526;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Questions());
        }

        #region Switchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
        #endregion

        
    }
}
