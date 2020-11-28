using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace AsynchronousProgramming
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

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            //DownloadHtml("http://msdn.microsoft.com");
            //DownloadHtmlAsync("http://msdn.microsoft.com");

            //var html = GetHtml("http://msdn.microsoft.com");
            //MessageBox.Show(html.Substring(0,10));

            //var html = await GetHtmlAsync("http://msdn.microsoft.com"); //await yazabilmek için button click async olmalı
            //MessageBox.Show(html.Substring(0, 10));

            var getHtmlTask = GetHtmlAsync("http://msdn.microsoft.com");
            MessageBox.Show("Waiting for the task to complete");
            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0, 10));
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        public async Task<String> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            string path = @"C:\Users\turhany-PC\Desktop\AsynchronousProgramming\AsynchronousProgramming\AsynchronousProgramming\result.html";
            using (var streamWriter = new StreamWriter(path))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            string path = @"C:\Users\turhany-PC\Desktop\AsynchronousProgramming\AsynchronousProgramming\AsynchronousProgramming\result.html";
            using (var streamWriter = new StreamWriter(path))
            {
                streamWriter.Write(html);
            }
        }
    }
}
