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
    /// Interaction logic for Questions.xaml
    /// </summary>
    public partial class Questions : UserControl,Switchable
    {
        //MainWindow main = new MainWindow();
        

        public Questions()
        {
            InitializeComponent();
            //main.ResizeMode = System.Windows.ResizeMode.CanResize;
            
        }

        private void clickClose(object sender, RoutedEventArgs e)
        {
            
            Switcher.Switch(new MainMenu());
        }
        private void clickSend(object sender, RoutedEventArgs e)
        {
            MEGAhotspot.hotspot("MEGA", "x8743k0J", true);
        }
        
        #region Switchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
        #endregion

        
    }
}
