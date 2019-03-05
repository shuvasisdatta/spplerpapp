using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace spplerpapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
            
        public void OnBackButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
            else
            {
                System.Environment.Exit(0); // Exit from App
            }
        }
        
        void webviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            webView.IsVisible       = false;
            labelLoading.IsVisible  = true;
            indicator.IsRunning     = true;
            indicator.IsVisible     = true;
        }

        void webviewNavigated(object sender, WebNavigatedEventArgs e)
        {
            labelLoading.IsVisible  = false;
            indicator.IsRunning     = false;
            indicator.IsVisible     = false;
            webView.IsVisible = true;
        }
    }
}
