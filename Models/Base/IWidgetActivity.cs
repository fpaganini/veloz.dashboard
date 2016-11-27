using System.Collections.Generic;

namespace Veloz.Models
{
    public interface IWidgetActivity : IWidgetContent
    {
        List<ActivitieItem> Items { get; set; }
    }
}