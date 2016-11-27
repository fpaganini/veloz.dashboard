using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veloz.Models.Widgets
{
    public class Activitie : IWidgetActivity
    {

        public Activitie()
        {
            this.Closable = true;
            this.Colapsable = true;
            this.Title = "";
            this.SubTitle = "";

        }

        public bool FixedHeight { get; set; }

        public WidgetWidth Size { get; set; }

        public WidgetContent Style { get { return WidgetContent.Activities; } }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public List<ActivitieItem> Items { get; set; }

        public List<WidgetTools> Tools { get; set; }

        public bool Closable { get; set; }
        public bool Colapsable { get; set; }

        public void AddItem(DateTime date , string username,string title,string text)
        {
            if (Items == null)
                Items = new List<ActivitieItem>();
            var item = new ActivitieItem();
            item.Date = date;
            item.UserName = username;
            item.Title = title;
            item.Text = text;
            Items.Add(item);

         



        }

    }
}