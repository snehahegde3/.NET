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
        // whenever there is a change in the HtmlProperty, the OnHtmlChanged will be called 
        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
            "html",
            typeof(string),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(OnHtmlChanged)
            );
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
                var html = client.GetStringAsync("https://google.com").Result;
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
            string myHtml = "Bla";
            await Task.Run(async () =>
            {
                Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
                HttpClient client = new HttpClient();
                var html = client.GetStringAsync("https://google.com").Result;
                myHtml = html;

                
            });
            Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
            MyButton.Content = "Done";
            MyWebBrowser.SetValue(HtmlProperty, myHtml);

        }

        public static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if (webBrowser != null)
            {
                webBrowser.NavigateToString(e.NewValue as string);
            }
        }

        
    }
}
