﻿using System;

namespace AWG.Measures.core.Dto
{
  public class WeeklyMeasureDetail
  {
    public string StationId { get; set; }
    public int Year { get; set; }
    public int Week { get; set; }
    public DateTime Date { get; set; }
    public DateTime DateLast { get; set; }
    public double? Precipitations { get; set; }
    public double? SolarRadiations { get; set; }
    public double? AvgSolarRadiations { get; set; }
    public double? MinWindSpeed { get; set; }
    public double? AvgWindSpeed { get; set; }
    public double? MaxWindSpeed { get; set; }
    public double? MinTemperature { get; set; }
    public double? AvgTemperature { get; set; }
    public double? MaxTemperature { get; set; }
    public double? MinRelativeHumidity { get; set; }
    public double? AvgRelativeHumidity { get; set; }
    public double? MaxRelativeHumidity { get; set; }
    public double? WindDirection { get; set; }

  }
}