namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Constant")]
        Constant = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ConstantOnDemand")]
        ConstantOnDemand = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Cycling")]
        Cycling = 3,
    }
}