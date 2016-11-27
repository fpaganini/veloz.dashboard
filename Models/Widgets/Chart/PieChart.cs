using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veloz.Models.Widgets.Chart
{
    public class PieChart: IWidgetChart
    {

        public PieChart()
    {
        this.Closable = true;
        this.Colapsable = true;
        this.Title = "";
        this.SubTitle = "";
        this.ValuesTitle = "";
        this.ItemsTitle = "";

    }

        public bool FixedHeight { get; set; }
        public string ItemsTitle { get; set; }
    public string ValuesTitle { get; set; }

    public WidgetWidth Size { get; set; }

    public WidgetContent Style { get { return WidgetContent.Pie; } }

    public string Title { get; set; }

    public string SubTitle { get; set; }

    public List<ChartItem> Items { get; set; }

    public List<WidgetTools> Tools { get; set; }

    public bool Closable { get; set; }
    public bool Colapsable { get; set; }

    public void AddItem(string name, double valor)
    {
        if (Items == null)
            Items = new List<ChartItem>();
        var item = new ChartItem();
        item.DefaultColor = Colors.blue + Items.Count();
        item.Value = valor;
        item.Name = name;
        Items.Add(item);

        double valorMaximo = 0;
        foreach (var it in Items)
        {
            valorMaximo += it.Value;
        }


        for (int i = 0; i < Items.Count; i++)
        {
            Items[i].PercentValue = Items[i].Value / valorMaximo * 100.0;
            if (Items[i].PercentValue > 100)
                Items[i].PercentValue = 100;
            if (Items[i].PercentValue < 0)
                Items[i].PercentValue = 0;

            Items[i].PercentValue = (int)Items[i].PercentValue;

        }




    }

}
}