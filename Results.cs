namespace CTApucarana

public class Results
{

public int temp {get; set;}

public string description {get; set;}

public string city {get; set;}

public int humidity {get; set;}

public double rain {get; set;}

public string sunrise {get; set;}

public string sunset {get; set;}
[JsonPropertyName("wind_speedy")]
public string windSpeedy {get; set;}
[JsonPropertyName("wind_direction")]

public int windDirection {get; set;}
[JsonPropertyName("moon_phase")]

public string moonPhase {get; set;}
[JsonPropertyName("img_id")]

public string imgId {get; set;}
[JsonPropertyName("condition_code")]

public string conditionCode {get; set;}

public string currently {get; set;}

} 