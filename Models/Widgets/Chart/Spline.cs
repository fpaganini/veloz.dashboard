using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veloz.Models.Widgets.Chart
{
    public class Spline : IWidgetSpline
    {

        public Spline()
        {
            this.Closable = true;
            this.Colapsable = true;
            this.Title = "";
            this.SubTitle = "";
            this.ValuesTitle = "";
            this.ItemsTitle = "";
            Series = new List<SplineSeries>();
            this.AxisXTicksValue = 1;
            this.AxisXTicksType = Ticks.Day;
            this.AxisYTicks = 8;
        }

        public bool FixedHeight { get; set; }
        public string ItemsTitle { get; set; }
        public string ValuesTitle { get; set; }

        public WidgetWidth Size { get; set; }

        public WidgetContent Style { get { return WidgetContent.Spline; } }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public int AxisXTicksValue { get; set; }
        public Ticks AxisXTicksType { get; set; }
        public int AxisYTicks { get; set; }
        public List<SplineSeries> Series { get; set; }

        public List<WidgetTools> Tools { get; set; }

        public bool Closable { get; set; }
        public bool Colapsable { get; set; }


        public void AddSerie(string SerieName, System.Drawing.Color Color)
        {
            var serie = new SplineSeries();
            serie.Color = Color;
            serie.SerieName = SerieName;
            Series.Add(serie);
        }

        public void AddSerie(string SerieName, System.Drawing.Color Color, params SplineValues[] values)
        {
            var serie = new SplineSeries();
            serie.Color = Color;
            serie.SerieName = SerieName;
            serie.Values = new List<SplineValues>(values.ToArray());
            Series.Add(serie);
        }

    }
}