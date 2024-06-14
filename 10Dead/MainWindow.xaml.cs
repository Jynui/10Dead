using System.Windows;

namespace _10Dead
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Vxod_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the new window you want to open
            var newWindow = new AnotherWindow();
            // Show the new window
            newWindow.Show();
            // Optionally, close the current window
            this.Close();
        }
    }
}
