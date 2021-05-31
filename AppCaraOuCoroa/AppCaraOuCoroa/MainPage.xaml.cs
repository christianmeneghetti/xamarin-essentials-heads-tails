using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace AppCaraOuCoroa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btJogar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageJogo());

            try
            {
                // Or use specified time
                var duration = TimeSpan.FromSeconds(1);
                Vibration.Vibrate(duration);
            }
            catch (FeatureNotSupportedException ex)
            {
                // Feature not supported on device
                DisplayAlert("Error", ex.Message, "OK");
            }
            catch (Exception ex)
            {
                // Other error has occurred.
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
