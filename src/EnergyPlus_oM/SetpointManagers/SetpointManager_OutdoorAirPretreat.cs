using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager determines the required conditions at the outdoor air strea" +
                 "m node which will produce the reference setpoint condition at the mixed air node" +
                 " when mixed with the return air stream")]
    public class SetpointManager_OutdoorAirPretreat : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("control_variable")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_OutdoorAirPretreat_ControlVariable ControlVariable { get; set; } = (SetpointManager_OutdoorAirPretreat_ControlVariable)Enum.Parse(typeof(SetpointManager_OutdoorAirPretreat_ControlVariable), "HumidityRatio");
        

        [Description("Applicable only if Control variable is Temperature")]
        [JsonProperty("minimum_setpoint_temperature")]
        public System.Nullable<float> MinimumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-99", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Control variable is Temperature")]
        [JsonProperty("maximum_setpoint_temperature")]
        public System.Nullable<float> MaximumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("99", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Control variable is MaximumHumidityRatio, MinimumHumidityRatio" +
                     ", or HumidityRatio - then minimum is 0.00001")]
        [JsonProperty("minimum_setpoint_humidity_ratio")]
        public System.Nullable<float> MinimumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("1E-05", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Control variable is MaximumHumidityRatio, MinimumHumidityRatio" +
                     ", or HumidityRatio - then minimum is 0.00001")]
        [JsonProperty("maximum_setpoint_humidity_ratio")]
        public System.Nullable<float> MaximumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The current setpoint at this node is the desired condition for the Mixed Air Node" +
                     " This node must have a valid setpoint which has been set by another setpoint man" +
                     "ager")]
        [JsonProperty("reference_setpoint_node_name")]
        public string ReferenceSetpointNodeName { get; set; } = "";
        

        [Description("Name of Mixed Air Node")]
        [JsonProperty("mixed_air_stream_node_name")]
        public string MixedAirStreamNodeName { get; set; } = "";
        

        [Description("Name of Outdoor Air Stream Node")]
        [JsonProperty("outdoor_air_stream_node_name")]
        public string OutdoorAirStreamNodeName { get; set; } = "";
        

        [Description("Name of Return Air Stream Node")]
        [JsonProperty("return_air_stream_node_name")]
        public string ReturnAirStreamNodeName { get; set; } = "";
        

        [Description("Node(s) at which the temperature or humidity ratio will be set")]
        [JsonProperty("setpoint_node_or_nodelist_name")]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}