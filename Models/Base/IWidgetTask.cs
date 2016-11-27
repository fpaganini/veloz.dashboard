using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veloz.Models
{
    public interface IWidgetTask : IWidgetContent
    {
        List<TaskItem> Items { get; set; }
    }
}