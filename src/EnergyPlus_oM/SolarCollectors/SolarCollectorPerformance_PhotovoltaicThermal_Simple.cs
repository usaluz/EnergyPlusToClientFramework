using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description("Thermal performance parameters for a hybrid photovoltaic-thermal (PVT) solar coll" +
                 "ector.")]
    [JsonObject("SolarCollectorPerformance:PhotovoltaicThermal:Simple")]
    public class SolarCollectorPerformance_PhotovoltaicThermal_Simple : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("fraction_of_surface_area_with_active_thermal_collector")]
        public System.Nullable<float> FractionOfSurfaceAreaWithActiveThermalCollector { get; set; } = null;
        

        [JsonProperty("thermal_conversion_efficiency_input_mode_type")]
        public SolarCollectorPerformance_PhotovoltaicThermal_Simple_ThermalConversionEfficiencyInputModeType ThermalConversionEfficiencyInputModeType { get; set; } = (SolarCollectorPerformance_PhotovoltaicThermal_Simple_ThermalConversionEfficiencyInputModeType)Enum.Parse(typeof(SolarCollectorPerformance_PhotovoltaicThermal_Simple_ThermalConversionEfficiencyInputModeType), "Fixed");
        

        [Description("Efficiency = (thermal power generated [W])/(incident solar[W])")]
        [JsonProperty("value_for_thermal_conversion_efficiency_if_fixed")]
        public System.Nullable<float> ValueForThermalConversionEfficiencyIfFixed { get; set; } = null;
        

        [JsonProperty("thermal_conversion_efficiency_schedule_name")]
        public string ThermalConversionEfficiencyScheduleName { get; set; } = "";
        

        [JsonProperty("front_surface_emittance")]
        public System.Nullable<float> FrontSurfaceEmittance { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
    }
}