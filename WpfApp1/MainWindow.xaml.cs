using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Net.Http;
using System.Net.Http.Headers;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        //private void BindFestivalList()
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("http://localhost:9572/");
        //    //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
        //    client.DefaultRequestHeaders.Accept.Add(
        //       new MediaTypeWithQualityHeaderValue("application/json"));
            
        //    HttpResponseMessage response = client.GetAsync("api/festivals").Result;
        //    if (response.IsSuccessStatusCode)
        //    {
                
        //        var festivals = response.Content.ReadAsAsync<IEnumerable<FestivalViewModel>>().Result;
        //        sqlFestival.ItemsSource = festivals;

        //    }
        //    else
        //    {
        //        MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
        //    }
        //}

        //private void Window_Loaded(object sender, RoutedEventArgs e)

        //{

        //    BindFestivalList();

        //}

        
    }
}
