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
        public ImageSource ImageName { get; set; }
        public ImageSource ImageName1 { get; set; }
        public int Population { get; set; }
        public CustomMarker()
        {
            if (Device.RuntimePlatform == Device.UWP)
            {
                ImageName = ImageSource.FromResource("MapMarkerTemplateSelector.Icons.place.png", typeof(CustomMarker).GetTypeInfo().Assembly);
                ImageName1 = ImageSource.FromResource("MapMarkerTemplateSelector.Icons.pin.png", typeof(CustomMarker).GetTypeInfo().Assembly);
            }
            else
            {
                ImageName = ImageSource.FromResource("MapMarkerTemplateSelector.Icons.place.png");
                ImageName1 = ImageSource.FromResource("MapMarkerTemplateSelector.Icons.pin.png");
            }
        }
    }
}
