using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    [Description("List of variable refrigerant flow (VRF) terminal units served by a given VRF cond" +
                 "ensing unit. See ZoneHVAC:TerminalUnit:VariableRefrigerantFlow and AirConditione" +
                 "r:VariableRefrigerantFlow.")]
    public class ZoneTerminalUnitList : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_terminal_unit_list_name")]
        public string ZoneTerminalUnitListName { get; set; } = "";
        

        [JsonProperty("terminal_units")]
        public string TerminalUnits { get; set; } = "";
    }
}