using MahApps.Metro.Controls;
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

namespace PersonelTakip
{
    /// <summary>
    /// Interaction logic for ManagePersonnel.xaml
    /// </summary>
    public partial class ManagePersonnel : Page
    {
        public ManagePersonnel()
        {
            InitializeComponent();
            this.SizeChanged += Page_SizeChanged;
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double pageWidth = e.NewSize.Width;

            if (pageWidth < 600)
            {
                // Küçük ekran boyutu için örneğin butonları daraltabiliriz
                AddButton.Width = 70;
                EditButton.Width = 70;
                DeleteButton.Width = 70;
            }
            else
            {
                // Daha geniş ekranlarda normal genişlikleri kullanabiliriz
                AddButton.Width = 100;
                EditButton.Width = 100;
                DeleteButton.Width = 100;
            }
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Yeni personel ekleme işlemleri
            MessageBox.Show("Yeni personel ekleniyor.");
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // Seçili personeli düzenleme işlemleri
            MessageBox.Show("Seçili personel düzenleniyor.");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Seçili personeli silme işlemleri
            MessageBox.Show("Seçili personel siliniyor.");
        }
    }
}
