using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloThere.Models
{
    public class Model
    {
        [JsonProperty("$id")]
        public long Id { get; set; }

        [JsonProperty("currentDateTime")]
        public string CurrentDateTime { get; set; }

        [JsonProperty("utcOffset")]
        public string UtcOffset { get; set; }

        [JsonProperty("isDayLightSavingsTime")]
        public bool IsDayLightSavingsTime { get; set; }

        [JsonProperty("dayOfTheWeek")]
        public string DayOfTheWeek { get; set; }

        [JsonProperty("timeZoneName")]
        public string TimeZoneName { get; set; }

        [JsonProperty("currentFileTime")]
        public double CurrentFileTime { get; set; }

        [JsonProperty("ordinalDate")]
        public string OrdinalDate { get; set; }

        [JsonProperty("serviceResponse")]
        public object ServiceResponse { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, \n" +
                $"UtcOffset:{UtcOffset}, \n" +
                $"IsDayLightSavingsTime:{IsDayLightSavingsTime}, \n" +
                $"DayOfTheWeek:{DayOfTheWeek}, \n" +
                $"TimeZoneName:{TimeZoneName}, \n" +
                $"CurrentFileTime:{CurrentFileTime}, \n" +
                $"OrdinalDate:{OrdinalDate}, \n" +
                $"ServiceResponse:{ServiceResponse}";
        }
    }
}
