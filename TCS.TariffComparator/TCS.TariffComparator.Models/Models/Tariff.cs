﻿
namespace TCS.TariffComparator.Models.Models;

    public record Tariff
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public decimal BaseCost { get; set; }
        public decimal AdditionalKwhCost { get; set; }
        public int IncludedKwh { get; set; }
    }

