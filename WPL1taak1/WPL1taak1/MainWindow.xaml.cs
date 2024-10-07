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

namespace WPL1taak1
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

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush(Colors.Black);
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFBDB8B8"));
        }

        private void klikOpRood(object sender, MouseButtonEventArgs e)
        {
            kleurCodeTextBox.Text = "#FF0000";
            infoTextBox.Text = "Rood is de kleur van warmte";
        }

        private void klikOpGeel(object sender, MouseButtonEventArgs e)
        {
            kleurCodeTextBox.Text = "#FFFF00";
            infoTextBox.Text = "Geel is de kleur van levenslust";
        }

        private void klikOpGroen(object sender, MouseButtonEventArgs e)
        {
            kleurCodeTextBox.Text = "#008000";
            infoTextBox.Text = "Groen is de kleur van genezing";
        }

        private void klikOpBlauw(object sender, MouseButtonEventArgs e)
        {
            kleurCodeTextBox.Text = "#0000FF";
            infoTextBox.Text = "Blauw is de kleur van intelligentie";
        }
    }
}