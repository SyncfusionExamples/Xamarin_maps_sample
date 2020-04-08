using Syncfusion.SfMaps.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MapMarkerTemplateSelector
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class CustomMarker : MapMarker
    {
        /// <summary>
        /// Gets or sets marker image for high population.
        /// </summary>
        public ImageSource HighPopulationMarker { get; set; }

        /// <summary>
        /// Gets or sets marker image for low population.
        /// </summary>
        public ImageSource LowPopulationMarker { get; set; }

        /// <summary>
        /// Gets or sets population (in million)
        /// </summary>
        public int Population { get; set; }
        public CustomMarker()
        {
            if (Device.RuntimePlatform == Device.UWP)
            {
                HighPopulationMarker = ImageSource.FromResource("MapMarkerTemplateSelector.Icons.place.png", typeof(CustomMarker).GetTypeInfo().Assembly);
                LowPopulationMarker = ImageSource.FromResource("MapMarkerTemplateSelector.Icons.pin.png", typeof(CustomMarker).GetTypeInfo().Assembly);
            }
            else
            {
                HighPopulationMarker = ImageSource.FromResource("MapMarkerTemplateSelector.Icons.place.png");
                LowPopulationMarker = ImageSource.FromResource("MapMarkerTemplateSelector.Icons.pin.png");
            }
        }
    }
}
