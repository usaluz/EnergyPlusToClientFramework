using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("The Single Zone Minimum Humidity Setpoint Manager allows the control of a single " +
                 "zone minimum humidity level. This setpoint manager can be used in conjunction wi" +
                 "th object ZoneControl:Humidistat to detect humidity levels.")]
    public class SetpointManager_SingleZone_Humidity_Minimum : BHoMObject, IEnergyPlusClass
    {
        

        [Description("Node(s) at which humidity ratio setpoint will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
        

        [Description("Name of the zone air node for the humidity control zone")]
        [JsonProperty("control_zone_air_node_name")]
        public string ControlZoneAirNodeName { get; set; } = "";
    }
}