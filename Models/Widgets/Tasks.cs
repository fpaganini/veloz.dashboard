using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veloz.Models.Widgets
{
    public class Tasks : IWidgetTask
    {

        public Tasks()
        {
            this.Closable = true;
            this.Colapsable = true;
            this.Title = "";
            this.SubTitle = "";

        }

        public bool FixedHeight { get; set; }

        public WidgetWidth Size { get; set; }

        public WidgetContent Style { get { return WidgetContent.Tasks; } }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public List<TaskItem> Items { get; set; }

        public List<WidgetTools> Tools { get; set; }

        public bool Closable { get; set; }
        public bool Colapsable { get; set; }

        public void AddItem(string name, bool completed)
        {
            if (Items == null)
                Items = new List<TaskItem>();
            var item = new TaskItem();
            item.TaskName = name;
            item.Completed = completed;
            Items.Add(item);
           
        }

        public void AddItem(string name)
        {
            if (Items == null)
                Items = new List<TaskItem>();
            var item = new TaskItem();
            item.TaskName = name;
            item.Completed = false;
            Items.Add(item);

        }
    }
}