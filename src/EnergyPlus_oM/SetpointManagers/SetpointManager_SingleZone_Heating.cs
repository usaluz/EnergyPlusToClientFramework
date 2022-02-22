using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description(@"This setpoint manager detects the control zone load to meet the current heating setpoint, zone inlet node flow rate, and zone node temperature, and calculates a setpoint temperature for the supply air that will satisfy the zone heating load for the control zone.")]
    [JsonObject("SetpointManager:SingleZone:Heating")]
    public class SetpointManager_SingleZone_Heating : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("control_variable")]
        public SetpointManager_SingleZone_Heating_ControlVariable ControlVariable { get; set; } = (SetpointManager_SingleZone_Heating_ControlVariable)Enum.Parse(typeof(SetpointManager_SingleZone_Heating_ControlVariable), "Temperature");
        

        [JsonProperty("minimum_supply_air_temperature")]
        public System.Nullable<float> MinimumSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-99", CultureInfo.InvariantCulture);
        

        [JsonProperty("maximum_supply_air_temperature")]
        public System.Nullable<float> MaximumSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("99", CultureInfo.InvariantCulture);
        

        [JsonProperty("control_zone_name")]
        public string ControlZoneName { get; set; } = "";
        

        [JsonProperty("zone_node_name")]
        public string ZoneNodeName { get; set; } = "";
        

        [JsonProperty("zone_inlet_node_name")]
        public string ZoneInletNodeName { get; set; } = "";
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}