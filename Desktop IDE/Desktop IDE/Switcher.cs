using System.Windows.Controls;

namespace Desktop_IDE
{
    public static class Switcher
    {
        public static MainWindow menuSwitcher;

        public static void Switch(UserControl newPage)
        {
            menuSwitcher.Navigate(newPage);
        }

        public static void Switch(UserControl newPage, object state)
        {
            menuSwitcher.Navigate(newPage, state);
        }
    }
}
