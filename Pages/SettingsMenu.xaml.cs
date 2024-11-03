using System.Windows;
using MahApps.Metro;
using System.Windows.Controls;
using ControlzEx.Theming;

namespace PersonelTakip
{
    public partial class SettingsMenu : Page
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void SaveSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            // Tema ve renk şeması seçimini al
            var selectedTheme = (ComboBoxItem)ThemeComboBox.SelectedItem;
            var selectedColorScheme = (ComboBoxItem)ColorSchemeComboBox.SelectedItem;

            // Tema değişimi
            if (selectedTheme != null)
            {
                string theme = selectedTheme.Content?.ToString() ?? "Light"; // Varsayılan tema "Light"
                string accent = selectedColorScheme?.Content?.ToString() ?? "Blue"; // Varsayılan renk "Blue"
                ApplyTheme(theme, accent);
            }
        }

        private void ApplyTheme(string theme, string accent)
        {
            // Tema ve renk şemasını uygula
            switch (theme)
            {
                case "Light":
                    ThemeManager.Current.ChangeThemeBaseColor(Application.Current, "Light");
                    break;
                case "Dark":
                    ThemeManager.Current.ChangeThemeBaseColor(Application.Current, "Dark");
                    break;
                default:
                    ThemeManager.Current.ChangeThemeBaseColor(Application.Current, "Light"); // Varsayılan tema
                    break;
            }

            // Renk şemasını uygula
            if (accent != null)
            {
                ThemeManager.Current.ChangeThemeColorScheme(Application.Current, accent);
            }
        }
    }
}
