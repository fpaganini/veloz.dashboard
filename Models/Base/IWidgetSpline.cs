using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veloz.Models
{
    public interface IWidgetSpline : IWidgetContent
    {
        int AxisXTicksValue { get; set; }
        Ticks AxisXTicksType { get; set; }
        int AxisYTicks { get; set; }
        List<SplineSeries> Series { get; set; }
    }
}