using System.Collections.Generic;

namespace Veloz.Models
{
    public interface IWidgetChart : IWidgetContent
    {
        List<ChartItem> Items { get; set; }
        string ItemsTitle { get; set; }
        string ValuesTitle { get; set; }
    }
}