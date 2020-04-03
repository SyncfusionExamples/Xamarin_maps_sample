using Syncfusion.SfMaps.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MarkerOnGPSLocation
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.AddMarkerInCurrentLocation();
        }

        private async void AddMarkerInCurrentLocation()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location != null)
                {
                    CustomMarker marker = new CustomMarker();
                    marker.Latitude = location.Latitude.ToString();
                    marker.Longitude = location.Longitude.ToString();
                    this.layer.Markers = new ObservableCollection<MapMarker> { marker };
                }
            }
            catch (Exception ex)
            {
                // Handle not supported on device exception
                await Application.Current.MainPage.DisplayAlert("Alert", ex.Message, "Ok");
            }
        }
    }

    public class CustomMarker : MapMarker
    {
        public ImageSource Image { get; set; }
        public CustomMarker()
        {
            Image = ImageSource.FromResource("MarkerOnGPSLocation.pin.png");
        }
    }
}
