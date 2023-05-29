using System.Net.Http;
using System.Windows;
using System.Windows.Documents;

namespace Studies.AsyncProgramming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string ApiUrl = "https://dummyjson.com/products";

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnGetDataAsync_Click(object sender, RoutedEventArgs e)
        {
            txtData.Document = new FlowDocument();

            HttpClient httpClient = new HttpClient();

            try
            {
                //Send the GET request and retrieve the response.
                HttpResponseMessage response = await httpClient.GetAsync(ApiUrl);

                //Ensure the request was successful.
                response.EnsureSuccessStatusCode();

                //Read the response content as a string.
                string responseBody = await response.Content.ReadAsStringAsync();
                txtData.AppendText(responseBody + "\n");
            }
            catch (HttpRequestException ex)
            {
                //Handle any errors that occurred during the request.
                txtData.AppendText("HttpRequestException : " + ex.Message + "\n");
            }
            finally
            {
                //Dispose of the HttpClient instance when done.
                httpClient.Dispose();
            }
        }

        private void btnGetDataSync_Click(object sender, RoutedEventArgs e)
        {
            txtData.Document = new FlowDocument();

            HttpClient httpClient = new HttpClient();

            try
            {
                //Send the GET request and retrieve the response.
                HttpResponseMessage response = httpClient.GetAsync(ApiUrl).Result;

                //Ensure the request was successful.
                response.EnsureSuccessStatusCode();

                //Read the response content as a string.
                string responseBody = response.Content.ReadAsStringAsync().Result;
                txtData.AppendText(responseBody + "\n");
            }
            catch (HttpRequestException ex)
            {
                //Handle any errors that occurred during the request.
                txtData.AppendText("HttpRequestException : " + ex.Message + "\n");
            }
            finally
            {
                //Dispose of the HttpClient instance when done.
                httpClient.Dispose();
            }
        }
    }
}
