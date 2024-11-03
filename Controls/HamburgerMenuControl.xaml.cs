using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;

namespace PersonelTakip
{
    public partial class HamburgerMenuControl : UserControl
    {
        public HamburgerMenuControl()
        {
            InitializeComponent();
        }

        private void HamburgerMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem is HamburgerMenuGlyphItem item)
            {
                var mainWindow = Window.GetWindow(this) as MainWindow;
                if (mainWindow != null)
                {
                    // Menüler arasından seçim yaparak sayfayı güncelle
                    switch (item.Label)
                    {
                        case "Ana Menü":
                            mainWindow.NavigateToPage(new MainMenu());
                            break;
                        case "Personel Yönetimi":
                            mainWindow.NavigateToPage(new ManagePersonnel());
                            break;
                        case "Giriş / Çıkış Takibi":
                            mainWindow.NavigateToPage(new EntryManagement());
                            break;
                        case "Mesai / İzin Yönetimi":
                            mainWindow.NavigateToPage(new OvertimeManagement());
                            break;
                        case "Seçenekler":
                            mainWindow.NavigateToPage(new SettingsMenu());
                            break;
                        default:
                            MessageBox.Show("Bu menü henüz tanımlanmadı.", "Uyarı", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }
                }
            }
        }
    }
}
