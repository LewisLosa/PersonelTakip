using System.Windows;
using System.Windows.Controls;

namespace PersonelTakip
{
    public partial class OvertimeManagement : Page
    {
        public OvertimeManagement()
        {
            InitializeComponent();
        }

        private void AddMesaiButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mesai ekleme işlemi başlatıldı.");
        }

        private void AddIzinButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("İzin ekleme işlemi başlatıldı.");
        }

        private void DeleteRecordButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Kayıt silme işlemi başlatıldı.");
        }
    }
}
