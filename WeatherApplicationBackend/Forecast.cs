namespace WeatherApplicationBackend;

using Newtonsoft.Json;

public class Location
{
    public string Name { get; set; }
    public string Region { get; set; }
    public string Country { get; set; }
    // Other location properties as needed
}

public class Condition
{
    public string Text { get; set; }
    public string Icon { get; set; }
    public int Code { get; set; }
}

public class Current
{
    [JsonProperty("temp_c")]
    public double TemperatureCelsius { get; set; }

    [JsonProperty("wind_kph")]
    public double WindSpeedKph { get; set; }

    [JsonProperty("wind_dir")]
    public string WindDirection { get; set; }

    [JsonProperty("precip_mm")]
    public double PrecipitationMm { get; set; }

    [JsonProperty("humidity")]
    public int HumidityPercent { get; set; }

    [JsonProperty("vis_km")]
    public double VisibilityKm { get; set; }

    // Other current weather properties as needed
    public Condition Condition { get; set; }
}

public class Forecast
{
    public Location Location { get; set; }
    public Current Current { get; set; }
}
