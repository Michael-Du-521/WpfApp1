using System.Windows;

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (null!=sender)
            {
                MessageBox.Show(e.ToString());
            }
            else
            {
                MessageBox.Show($"{sender?.ToString()} could be null in any sense", "Warning");
            }
            
        }
    }
}
