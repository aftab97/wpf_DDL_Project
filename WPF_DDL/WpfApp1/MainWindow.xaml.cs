using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            GetWebPage("http://dev-xpo.datadrivenlogistics.com/smartpass/webservices/smartpass/datarequest.ashx?Username=Ryan&Password=C5D9519&xmlData=%3Cdatarequest%20appFunction=%22getUser%22%20deviceID=%22353555089110189%22%20username=%2224486015%22%20password=%2224486015%22%3E%3C/datarequest%3E");
            
        }
        string GetWebPage(string address)
        {
            string responseText;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(address);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader responseStream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8")))
                {
                    responseText = responseStream.ReadToEnd();
                    
                }
            }

            return responseText;
        }

       
    }
}
