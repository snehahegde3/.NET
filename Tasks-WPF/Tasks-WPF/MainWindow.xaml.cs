using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tasks_WPF
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

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"Thread nr. {Thread.CurrentThread.ManagedThreadId}");
            MessageBox.Show("hi");
            HttpClient client = new HttpClient();
            string html = client.GetStringAsync("https://google.com").Result;
            MyButton.Content = "Done";
            

        }
    }
}
