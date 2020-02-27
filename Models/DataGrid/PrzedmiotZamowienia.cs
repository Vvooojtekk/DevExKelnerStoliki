using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace KelnerStoliki.Models.DataGrid {
    public class PrzedmiotZamowienia {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int ID { get; set; }

        [Range(1, 100)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Ilosc { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]

        [Display(Name = "Danie")]
        public int DanieID { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Danie { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public float Cena { get; set; }

    }
}
