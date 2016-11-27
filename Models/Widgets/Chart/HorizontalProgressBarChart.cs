using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veloz.Models.Widgets.Chart
{
    public class HorizontalProgressBarChart : IWidgetChart
    {

        public HorizontalProgressBarChart()
        {
            this.Closable = true;
            this.Colapsable = true;
        }

        public string ItemsTitle { get; set; }
        public string ValuesTitle { get; set; }
        public bool FixedHeight { get; set; }
        public WidgetWidth Size { get; set; }

        public WidgetContent Style { get { return WidgetContent.HorizontalProgressBars; } }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public List<ChartItem> Items { get; set; }

        public List<WidgetTools> Tools { get; set; }

        public bool Closable { get; set; }
        public bool Colapsable { get; set; }

        public void AddItem(string name, double valor, double valorMaximo)
        {
            if (Items == null)
                Items = new List<ChartItem>();
            var item = new ChartItem();

            item.DefaultColor = Colors.green;
            item.Value = valor;
            item.Name = name;
            item.PercentValue = valor / valorMaximo * 100.0;
            if (item.PercentValue > 100)
                item.PercentValue = 100;
            if (item.PercentValue < 0)
                item.PercentValue = 0;
            Items.Add(item);
        }

    }
}