using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veloz.Models
{
 
    public interface IWidgetContent
    {

        bool FixedHeight { get; set; }
        WidgetWidth Size { get; set; }
        String Title { get; set; }
        WidgetContent Style { get; }
        string SubTitle { get; set; }
        bool Closable { get; set; }
        bool Colapsable { get; set; }
        List<WidgetTools> Tools { get; set; }


    }

    public class ChartItem
    {
        public string Name { get; set; }
        public double PercentValue { get; set; }
        public double Value { get; set; }
        public Colors DefaultColor { get; set; }
    }
    public class ActivitieItem
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public string ReadMoreURL { get; set; }
        public string ReadMoreFunction { get; set; }
    }
    public class TaskItem
    {
        public string TaskName { get; set; }
        public bool Completed { get; set; }
    }
    public class WidgetTools
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string Function { get; set; }
    }
    public class SplineSeries
    {
        
        public SplineSeries()
        {
            Values = new List<SplineValues>();
            SerieName = "";
        }
        public string SerieName { get; set; }
        public System.Drawing.Color Color { get; set; }
        public List<SplineValues> Values { get; set; }

        public void AddValue(DateTime date, double value)
        {
            var item = new SplineValues(date, value);
            Values.Add(item);
        }

    } 
    public class SplineValues
    {
        public SplineValues()
        {
        }


        public SplineValues(DateTime date, double value)
        {
            this.date = date;
            this.Value = value;
        }


        public DateTime date { get; set; }
        public double Value { get; set; }
    }
}
