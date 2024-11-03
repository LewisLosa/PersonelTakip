using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;

namespace PersonelTakip
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void NavigateToPage(Page page)
        {
            MainContentFrame.Content = page;
        }
    }
}
