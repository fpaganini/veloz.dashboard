using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veloz.Models.Widgets
{
    public class Weather : IWidgetWeather
    {

        public Weather()
        {
            this.Closable = true;
            this.Colapsable = true;
            this.Title = "";
            this.SubTitle = "";
       }

        public string APIKEY { get; set; }
        public string LocationLatitude { get; set; }
        public string LocationLongitude { get; set; }
        public bool FixedHeight { get; set; }

        public WidgetWidth Size { get; set; }

        public WidgetContent Style { get { return WidgetContent.Weather; } }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string LocationName { get; set; }

        public List<WidgetTools> Tools { get; set; }

        public bool Closable { get; set; }
        public bool Colapsable { get; set; }

      
    }
}