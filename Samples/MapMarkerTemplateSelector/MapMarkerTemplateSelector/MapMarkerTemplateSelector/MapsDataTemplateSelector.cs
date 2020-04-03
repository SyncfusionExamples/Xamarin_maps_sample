using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MapMarkerTemplateSelector
{
    class MapsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate HighPopulationTemplate { get; set; }

        public DataTemplate LowPopulationTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((CustomMarker)item).Population >= 250000000 ? HighPopulationTemplate : LowPopulationTemplate; 
        }
    }
}
