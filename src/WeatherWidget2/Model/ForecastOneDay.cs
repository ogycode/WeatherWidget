﻿using System.Collections.Generic;

namespace WeatherWidget2.Model
{
    public class ForecastOneDay
    {
        public int Day { get; set; }
        public List<string> Labels { get; set; }
        public List<string> Condi { get; set; }
        public List<int> Values { get; set; }
        public List<string> Icons { get; set; }
        public List<double> Press { get; set; }
        public List<double> Humi { get; set; }
        public List<Wind> Wind { get; set; }

        public ForecastOneDay()
        {
            Labels = new List<string>();
            Values = new List<int>();
            Icons = new List<string>();
            Press = new List<double>();
            Humi = new List<double>();
            Wind = new List<Wind>();
            Condi = new List<string>();
            Day = -1;
        }

        public string GetDayIcon()
        {
            return Icons[Icons.Count / 2];
        }
        public string GetCurrentIcon()
        {
            return Icons[0];
        }
        public string GetDayCondition()
        {
            return Condi[Condi.Count / 2];
        }
        public string GetCurrentCondition()
        {
            return Condi[0];
        }
        public double GetDayPressure()
        {
            return Press[Press.Count / 2];
        }
        public double GetCurrentPressure()
        {
            return Press[0];
        }
        public double GetDayHumidity()
        {
            return Humi[Humi.Count / 2];
        }
        public double GetCurrentHumidity()
        {
            return Humi[0];
        }
        public int GetDayValue()
        {
            return Values[Values.Count / 2];
        }
        public int GetCurrentValue()
        {
            return Values[0];
        }
        public int GetDayWindSpeed()
        {
            return (int)Wind[Wind.Count / 2].Speed;
        }
        public int GetCurrentWindSpeed()
        {
            return (int)Wind[0].Speed;
        }
        public int GetDayWindDeg()
        {
            return (int)Wind[Wind.Count / 2].Direction;
        }
        public int GetCurrentWindDeg()
        {
            return (int)Wind[0].Direction;
        }

        public static string GetSideCode(int degre)
        {
            switch (degre)
            {
                case int i when i > 348 &&  i < 11:
                    return "N";
                case int i when i > 11 && i < 34:
                    return "NNE";
                case int i when i > 34 && i < 55:
                    return "NE";
                case int i when i > 55 && i < 79:
                    return "ENE";
                case int i when i > 79 && i < 101:
                    return "E";
                case int i when i > 101 && i < 124:
                    return "ESE";
                case int i when i > 124 && i < 146:
                    return "SE";
                case int i when i > 146 && i < 169:
                    return "SSE";
                case int i when i > 169 && i < 191:
                    return "S";
                case int i when i > 191 && i < 204:
                    return "SSW";
                case int i when i > 204 && i < 234:
                    return "SW";
                case int i when i > 234 && i < 259:
                    return "WDW";
                case int i when i > 259 && i < 281:
                    return "W";
                case int i when i > 281 && i < 304:
                    return "WNW";
                case int i when i > 304 && i < 326:
                    return "NW";
                case int i when i > 326 && i < 348:
                    return "NNW";
                default:
                    break;
            }
            return "";
        }

        public override bool Equals(object obj)
        {
            return Day == ((ForecastOneDay)obj).Day;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode() + Day;
        }
        public override string ToString()
        {
            return $"Day: {Day}";
        }
    }
}
