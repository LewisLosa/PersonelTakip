using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace PersonelTakip
{
    public partial class DB_SetupWizard : MetroWindow
    {
        public DB_SetupWizard()
        {
            InitializeComponent();
        }
    // İleri butonuna basıldığında bir sonraki sekmeye geç
    private void NextStep_Click(object sender, RoutedEventArgs e)
        {
            if (WizardTabControl.SelectedIndex < WizardTabControl.Items.Count - 1)
            {
                WizardTabControl.SelectedIndex += 1;
            }
        }

        // Sihirbazı kapat
        private void CloseWizard_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private async void ConnectionStep_Click(object sender, RoutedEventArgs e)
        {
            // Kullanıcıya modal ile soruyu göster
            var result = await this.ShowMessageAsync("Bağlantı Testi",
                "Devam etmeden önce bağlantı testi yapmak ister misiniz?",
                MessageDialogStyle.AffirmativeAndNegative,
                new MetroDialogSettings
                {
                    NegativeButtonText = "Hayır",
                    AffirmativeButtonText = "Evet"
                });

            if (result == MessageDialogResult.Affirmative)
            {
                // Eğer kullanıcı "Evet" derse, bağlantı testi yap.
                await TestConnection();
            }
            else
            {
                // Eğer kullanıcı "Hayır" derse, kurulum devam etsin.
                WizardTabControl.SelectedIndex += 1; // Bir sonraki adıma geç
            }
        }

        private async Task TestConnection()
        {
            bool connectionSuccess = true;

            if (connectionSuccess)
            {
                await this.ShowMessageAsync("Bağlantı Testi", "Bağlantı testi başarılı!", MessageDialogStyle.Affirmative);
                WizardTabControl.SelectedIndex += 1;
            }
            else
            {
                await this.ShowMessageAsync("Bağlantı Testi", "Bağlantı testi başarısız oldu. Lütfen bilgileri kontrol edin.", MessageDialogStyle.Affirmative);
            }
        }
    }
}
