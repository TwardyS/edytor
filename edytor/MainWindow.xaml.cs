using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace edytor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lewotekst_Click(object sender, RoutedEventArgs e)
        {
            edytowanie.TextAlignment = TextAlignment.Left;
        }

        private void srodektekst_Click(object sender, RoutedEventArgs e)
        {
            edytowanie.TextAlignment = TextAlignment.Center;
        }

        private void prawotekst_Click(object sender, RoutedEventArgs e)
        {
            edytowanie.TextAlignment = TextAlignment.Right;
        }

        private void justujtekst_Click(object sender, RoutedEventArgs e)
        {
            edytowanie.TextAlignment = TextAlignment.Justify;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            edytowanie.Foreground = Brushes.Blue;
        }

        private void czerwony_Checked(object sender, RoutedEventArgs e)
        {
            edytowanie.Foreground = Brushes.Red;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            edytowanie.Foreground = Brushes.Green;
        }

        private void rozmiar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            edytowanie.FontSize = rozmiar.Value;
        }
        private void kursywa_Checked(object sender, RoutedEventArgs e)
        {
            edytowanie.FontStyle = FontStyles.Italic;
        }

        private void kursywa_Unchecked(object sender, RoutedEventArgs e)
        {
            edytowanie.FontStyle = FontStyles.Normal;
        }

        private void pogrubienie_Checked(object sender, RoutedEventArgs e)
        {
            edytowanie.FontWeight = FontWeights.Bold;
        }

        private void pogrubienie_Unchecked(object sender, RoutedEventArgs e)
        {
            edytowanie.FontWeight = FontWeights.Normal;
        }

        private void podkreslenie_Checked(object sender, RoutedEventArgs e)
        {
            edytowanie.TextDecorations = TextDecorations.Underline;
        }

        private void podkreslenie_Unchecked(object sender, RoutedEventArgs e)
        {
            edytowanie.TextDecorations = null;
        }
    }
}