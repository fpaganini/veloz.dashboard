namespace Veloz.Models
{
    public interface IWidgetWeather : IWidgetContent
    {
        string LocationName { get; set; }
        string APIKEY { get; set; }
        string LocationLatitude { get; set; }
        string LocationLongitude { get; set; }
    }
}