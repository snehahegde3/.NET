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

        private async void MyButton_Click(object sender, RoutedEventArgs e)
        {
            // runs in a different thread
            Task.Run(() =>
            {
                Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
                HttpClient client = new HttpClient();
                var html = client.GetStringAsync("https://github.com/yourkin/fileupload-fastapi/raw/a85a697cab2f887780b3278059a0dd52847d80f3/tests/data/test-5mb.bin").Result;

                // this goes to the thread that responsible for the Button
                MyButton.Dispatcher.Invoke(() =>
                {
                    //so the main, thread: thread 1 that handles the UI, handles this
                    Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    MyButton.Content = "Done";

                });

            });

            

        }

        private async void MyButton_Click2(object sender, RoutedEventArgs e)
        {
            await Task.Run(async () =>
            {
                Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
                HttpClient client = new HttpClient();
                var html = client.GetStringAsync("https://github.com/yourkin/fileupload-fastapi/raw/a85a697cab2f887780b3278059a0dd52847d80f3/tests/data/test-5mb.bin").Result;

                
            });
            Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
            MyButton.Content = "Done Downloading";
        }
    }
}
