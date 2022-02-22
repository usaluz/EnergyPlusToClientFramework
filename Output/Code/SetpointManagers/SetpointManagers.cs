namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
    using BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts;
    using BH.oM.Adapters.EnergyPlus.AirDistribution;
    using BH.oM.Adapters.EnergyPlus.AirflowNetwork;
    using BH.oM.Adapters.EnergyPlus.Coils;
    using BH.oM.Adapters.EnergyPlus.ComplianceObjects;
    using BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers;
    using BH.oM.Adapters.EnergyPlus.Controllers;
    using BH.oM.Adapters.EnergyPlus.Daylighting;
    using BH.oM.Adapters.EnergyPlus.DemandLimitingControls;
    using BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer;
    using BH.oM.Adapters.EnergyPlus.Economics;
    using BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications;
    using BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS;
    using BH.oM.Adapters.EnergyPlus.EvaporativeCoolers;
    using BH.oM.Adapters.EnergyPlus.ExteriorEquipment;
    using BH.oM.Adapters.EnergyPlus.ExternalInterface;
    using BH.oM.Adapters.EnergyPlus.Fans;
    using BH.oM.Adapters.EnergyPlus.FluidProperties;
    using BH.oM.Adapters.EnergyPlus.GeneralDataEntry;
    using BH.oM.Adapters.EnergyPlus.HeatRecovery;
    using BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers;
    using BH.oM.Adapters.EnergyPlus.HVACDesignObjects;
    using BH.oM.Adapters.EnergyPlus.HVACTemplates;
    using BH.oM.Adapters.EnergyPlus.HybridModel;
    using BH.oM.Adapters.EnergyPlus.InternalGains;
    using BH.oM.Adapters.EnergyPlus.LocationandClimate;
    using BH.oM.Adapters.EnergyPlus.NodeBranchManagement;
    using BH.oM.Adapters.EnergyPlus.NonZoneEquipment;
    using BH.oM.Adapters.EnergyPlus.OperationalFaults;
    using BH.oM.Adapters.EnergyPlus.OutputReporting;
    using BH.oM.Adapters.EnergyPlus.Parametrics;
    using BH.oM.Adapters.EnergyPlus.PerformanceCurves;
    using BH.oM.Adapters.EnergyPlus.PerformanceTables;
    using BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserFlowControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserLoops;
    using BH.oM.Adapters.EnergyPlus.Pumps;
    using BH.oM.Adapters.EnergyPlus.PythonPluginSystem;
    using BH.oM.Adapters.EnergyPlus.Refrigeration;
    using BH.oM.Adapters.EnergyPlus.RoomAirModels;
    using BH.oM.Adapters.EnergyPlus.Schedules;
    using BH.oM.Adapters.EnergyPlus.SimulationParameters;
    using BH.oM.Adapters.EnergyPlus.SolarCollectors;
    using BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements;
    using BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers;
    using BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces;
    using BH.oM.Adapters.EnergyPlus.UnitaryEquipment;
    using BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels;
    using BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment;
    using BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage;
    using BH.oM.Adapters.EnergyPlus.WaterSystems;
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("The simplest Setpoint Manager simply uses a schedule to determine one or more set" +
        "points. Values of the nodes are not used as input.")]
    [JsonObject("SetpointManager:Scheduled")]
    public class SetpointManager_Scheduled : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_Scheduled_ControlVariable ControlVariable { get; set; } = (SetpointManager_Scheduled_ControlVariable)Enum.Parse(typeof(SetpointManager_Scheduled_ControlVariable), "HumidityRatio");
        

[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description("Node(s) at which control variable will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    public enum SetpointManager_Scheduled_ControlVariable
    {
        
        [JsonProperty("HumidityRatio")]
        HumidityRatio = 0,
        
        [JsonProperty("MassFlowRate")]
        MassFlowRate = 1,
        
        [JsonProperty("MaximumHumidityRatio")]
        MaximumHumidityRatio = 2,
        
        [JsonProperty("MaximumMassFlowRate")]
        MaximumMassFlowRate = 3,
        
        [JsonProperty("MaximumTemperature")]
        MaximumTemperature = 4,
        
        [JsonProperty("MinimumHumidityRatio")]
        MinimumHumidityRatio = 5,
        
        [JsonProperty("MinimumMassFlowRate")]
        MinimumMassFlowRate = 6,
        
        [JsonProperty("MinimumTemperature")]
        MinimumTemperature = 7,
        
        [JsonProperty("Temperature")]
        Temperature = 8,
    }
    
    [Description("This setpoint manager places a high and low schedule value on one or more nodes.")]
    [JsonObject("SetpointManager:Scheduled:DualSetpoint")]
    public class SetpointManager_Scheduled_DualSetpoint : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_Scheduled_DualSetpoint_ControlVariable ControlVariable { get; set; } = (SetpointManager_Scheduled_DualSetpoint_ControlVariable)Enum.Parse(typeof(SetpointManager_Scheduled_DualSetpoint_ControlVariable), "Temperature");
        

[JsonProperty("high_setpoint_schedule_name")]
public string HighSetpointScheduleName { get; set; } = "";
        

[JsonProperty("low_setpoint_schedule_name")]
public string LowSetpointScheduleName { get; set; } = "";
        

[Description("Node(s) at which temperature will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    public enum SetpointManager_Scheduled_DualSetpoint_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Temperature")]
        Temperature = 1,
    }
    
    [Description("This Setpoint Manager is used to place a setpoint temperature on system node acco" +
        "rding to the outdoor air temperature using a reset rule. The outdoor air tempera" +
        "ture is obtained from the weather information during the simulation.")]
    [JsonObject("SetpointManager:OutdoorAirReset")]
    public class SetpointManager_OutdoorAirReset : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_OutdoorAirReset_ControlVariable ControlVariable { get; set; } = (SetpointManager_OutdoorAirReset_ControlVariable)Enum.Parse(typeof(SetpointManager_OutdoorAirReset_ControlVariable), "Temperature");
        

[JsonProperty("setpoint_at_outdoor_low_temperature")]
public System.Nullable<float> SetpointAtOutdoorLowTemperature { get; set; } = null;
        

[JsonProperty("outdoor_low_temperature")]
public System.Nullable<float> OutdoorLowTemperature { get; set; } = null;
        

[JsonProperty("setpoint_at_outdoor_high_temperature")]
public System.Nullable<float> SetpointAtOutdoorHighTemperature { get; set; } = null;
        

[JsonProperty("outdoor_high_temperature")]
public System.Nullable<float> OutdoorHighTemperature { get; set; } = null;
        

[Description("Node(s) at which temperature will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
        

[Description("Optional input. Schedule allows scheduling of the outdoor air reset rule - a sche" +
    "dule value of 1 means use the first rule; a value of 2 means use the second rule" +
    ".")]
[JsonProperty("schedule_name")]
public string ScheduleName { get; set; } = "";
        

[Description("2nd outdoor air temperature reset rule")]
[JsonProperty("setpoint_at_outdoor_low_temperature_2")]
public System.Nullable<float> SetpointAtOutdoorLowTemperature2 { get; set; } = null;
        

[Description("2nd outdoor air temperature reset rule")]
[JsonProperty("outdoor_low_temperature_2")]
public System.Nullable<float> OutdoorLowTemperature2 { get; set; } = null;
        

[Description("2nd outdoor air temperature reset rule")]
[JsonProperty("setpoint_at_outdoor_high_temperature_2")]
public System.Nullable<float> SetpointAtOutdoorHighTemperature2 { get; set; } = null;
        

[Description("2nd outdoor air temperature reset rule")]
[JsonProperty("outdoor_high_temperature_2")]
public System.Nullable<float> OutdoorHighTemperature2 { get; set; } = null;
    }
    
    public enum SetpointManager_OutdoorAirReset_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MaximumTemperature")]
        MaximumTemperature = 1,
        
        [JsonProperty("MinimumTemperature")]
        MinimumTemperature = 2,
        
        [JsonProperty("Temperature")]
        Temperature = 3,
    }
    
    [Description(@"This setpoint manager detects the control zone load, zone inlet node flow rate, and zone node temperature and calculates a setpoint temperature for the supply air that will satisfy the zone load (heating or cooling) for the control zone. This setpoint manager is not limited to reheat applications.")]
    [JsonObject("SetpointManager:SingleZone:Reheat")]
    public class SetpointManager_SingleZone_Reheat : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_SingleZone_Reheat_ControlVariable ControlVariable { get; set; } = (SetpointManager_SingleZone_Reheat_ControlVariable)Enum.Parse(typeof(SetpointManager_SingleZone_Reheat_ControlVariable), "Temperature");
        

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
    
    public enum SetpointManager_SingleZone_Reheat_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Temperature")]
        Temperature = 1,
    }
    
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
    
    public enum SetpointManager_SingleZone_Heating_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Temperature")]
        Temperature = 1,
    }
    
    [Description(@"This setpoint manager detects the control zone load to meet the current cooling setpoint, zone inlet node flow rate, and zone node temperature, and calculates a setpoint temperature for the supply air that will satisfy the zone cooling load for the control zone.")]
    [JsonObject("SetpointManager:SingleZone:Cooling")]
    public class SetpointManager_SingleZone_Cooling : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_SingleZone_Cooling_ControlVariable ControlVariable { get; set; } = (SetpointManager_SingleZone_Cooling_ControlVariable)Enum.Parse(typeof(SetpointManager_SingleZone_Cooling_ControlVariable), "Temperature");
        

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
    
    public enum SetpointManager_SingleZone_Cooling_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Temperature")]
        Temperature = 1,
    }
    
    [Description("The Single Zone Minimum Humidity Setpoint Manager allows the control of a single " +
        "zone minimum humidity level. This setpoint manager can be used in conjunction wi" +
        "th object ZoneControl:Humidistat to detect humidity levels.")]
    [JsonObject("SetpointManager:SingleZone:Humidity:Minimum")]
    public class SetpointManager_SingleZone_Humidity_Minimum : BHoMObject, IEnergyPlusClass
    {
        

[Description("Node(s) at which humidity ratio setpoint will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
        

[Description("Name of the zone air node for the humidity control zone")]
[JsonProperty("control_zone_air_node_name")]
public string ControlZoneAirNodeName { get; set; } = "";
    }
    
    [Description("The Single Zone Maximum Humidity Setpoint Manager allows the control of a single " +
        "zone maximum humidity level. This setpoint manager can be used in conjunction wi" +
        "th object ZoneControl:Humidistat to detect humidity levels.")]
    [JsonObject("SetpointManager:SingleZone:Humidity:Maximum")]
    public class SetpointManager_SingleZone_Humidity_Maximum : BHoMObject, IEnergyPlusClass
    {
        

[Description("Node(s) at which humidity ratio setpoint will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
        

[Description("Name of the zone air node for the humidity control zone")]
[JsonProperty("control_zone_air_node_name")]
public string ControlZoneAirNodeName { get; set; } = "";
    }
    
    [Description("The Mixed Air Setpoint Manager is meant to be used in conjunction with a Controll" +
        "er:OutdoorAir object. This setpoint manager is used to establish a temperature s" +
        "etpoint at the mixed air node.")]
    [JsonObject("SetpointManager:MixedAir")]
    public class SetpointManager_MixedAir : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_MixedAir_ControlVariable ControlVariable { get; set; } = (SetpointManager_MixedAir_ControlVariable)Enum.Parse(typeof(SetpointManager_MixedAir_ControlVariable), "Temperature");
        

[JsonProperty("reference_setpoint_node_name")]
public string ReferenceSetpointNodeName { get; set; } = "";
        

[JsonProperty("fan_inlet_node_name")]
public string FanInletNodeName { get; set; } = "";
        

[JsonProperty("fan_outlet_node_name")]
public string FanOutletNodeName { get; set; } = "";
        

[Description("Node(s) at which the temperature will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
        

[Description("Optional field used to limit economizer operation to prevent freezing of DX cooli" +
    "ng coil.")]
[JsonProperty("cooling_coil_inlet_node_name")]
public string CoolingCoilInletNodeName { get; set; } = "";
        

[Description("Optional field used to limit economizer operation to prevent freezing of DX cooli" +
    "ng coil.")]
[JsonProperty("cooling_coil_outlet_node_name")]
public string CoolingCoilOutletNodeName { get; set; } = "";
        

[Description("Optional field used to limit economizer operation to prevent freezing of DX cooli" +
    "ng coil.")]
[JsonProperty("minimum_temperature_at_cooling_coil_outlet_node")]
public System.Nullable<float> MinimumTemperatureAtCoolingCoilOutletNode { get; set; } = (System.Nullable<float>)Single.Parse("7.2", CultureInfo.InvariantCulture);
    }
    
    public enum SetpointManager_MixedAir_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Temperature")]
        Temperature = 1,
    }
    
    [Description("This setpoint manager determines the required conditions at the outdoor air strea" +
        "m node which will produce the reference setpoint condition at the mixed air node" +
        " when mixed with the return air stream")]
    [JsonObject("SetpointManager:OutdoorAirPretreat")]
    public class SetpointManager_OutdoorAirPretreat : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
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
    
    public enum SetpointManager_OutdoorAirPretreat_ControlVariable
    {
        
        [JsonProperty("HumidityRatio")]
        HumidityRatio = 0,
        
        [JsonProperty("MaximumHumidityRatio")]
        MaximumHumidityRatio = 1,
        
        [JsonProperty("MinimumHumidityRatio")]
        MinimumHumidityRatio = 2,
        
        [JsonProperty("Temperature")]
        Temperature = 3,
    }
    
    [Description("This SetpointManager resets the cooling supply air temperature of a central force" +
        "d air HVAC system according to the cooling demand of the warmest zone.")]
    [JsonObject("SetpointManager:Warmest")]
    public class SetpointManager_Warmest : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_Warmest_ControlVariable ControlVariable { get; set; } = (SetpointManager_Warmest_ControlVariable)Enum.Parse(typeof(SetpointManager_Warmest_ControlVariable), "Temperature");
        

[Description("Enter the name of an AirLoopHVAC object")]
[JsonProperty("hvac_air_loop_name")]
public string HvacAirLoopName { get; set; } = "";
        

[JsonProperty("minimum_setpoint_temperature")]
public System.Nullable<float> MinimumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_setpoint_temperature")]
public System.Nullable<float> MaximumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[JsonProperty("strategy")]
public SetpointManager_Warmest_Strategy Strategy { get; set; } = (SetpointManager_Warmest_Strategy)Enum.Parse(typeof(SetpointManager_Warmest_Strategy), "MaximumTemperature");
        

[Description("Node(s) at which the temperature will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    public enum SetpointManager_Warmest_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Temperature")]
        Temperature = 1,
    }
    
    public enum SetpointManager_Warmest_Strategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MaximumTemperature")]
        MaximumTemperature = 1,
    }
    
    [Description("This SetpointManager is used in dual duct systems to reset the setpoint temperatu" +
        "re of the air in the heating supply duct. Usually it is used in conjunction with" +
        " a SetpointManager:Warmest resetting the temperature of the air in the cooling s" +
        "upply duct.")]
    [JsonObject("SetpointManager:Coldest")]
    public class SetpointManager_Coldest : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_Coldest_ControlVariable ControlVariable { get; set; } = (SetpointManager_Coldest_ControlVariable)Enum.Parse(typeof(SetpointManager_Coldest_ControlVariable), "Temperature");
        

[Description("Enter the name of an AirLoopHVAC object.")]
[JsonProperty("hvac_air_loop_name")]
public string HvacAirLoopName { get; set; } = "";
        

[JsonProperty("minimum_setpoint_temperature")]
public System.Nullable<float> MinimumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_setpoint_temperature")]
public System.Nullable<float> MaximumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[JsonProperty("strategy")]
public SetpointManager_Coldest_Strategy Strategy { get; set; } = (SetpointManager_Coldest_Strategy)Enum.Parse(typeof(SetpointManager_Coldest_Strategy), "MinimumTemperature");
        

[Description("Node(s) at which the temperature will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    public enum SetpointManager_Coldest_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Temperature")]
        Temperature = 1,
    }
    
    public enum SetpointManager_Coldest_Strategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MinimumTemperature")]
        MinimumTemperature = 1,
    }
    
    [Description("This setpoint manager determines the required mass flow rate through a return air" +
        " bypass duct to meet the specified temperature setpoint")]
    [JsonObject("SetpointManager:ReturnAirBypassFlow")]
    public class SetpointManager_ReturnAirBypassFlow : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_ReturnAirBypassFlow_ControlVariable ControlVariable { get; set; } = (SetpointManager_ReturnAirBypassFlow_ControlVariable)Enum.Parse(typeof(SetpointManager_ReturnAirBypassFlow_ControlVariable), "Flow");
        

[Description("Enter the name of an AirLoopHVAC object.")]
[JsonProperty("hvac_air_loop_name")]
public string HvacAirLoopName { get; set; } = "";
        

[JsonProperty("temperature_setpoint_schedule_name")]
public string TemperatureSetpointScheduleName { get; set; } = "";
    }
    
    public enum SetpointManager_ReturnAirBypassFlow_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Flow")]
        Flow = 1,
    }
    
    [Description("This setpoint manager sets both the supply air temperature and the supply air flo" +
        "w rate.")]
    [JsonObject("SetpointManager:WarmestTemperatureFlow")]
    public class SetpointManager_WarmestTemperatureFlow : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_WarmestTemperatureFlow_ControlVariable ControlVariable { get; set; } = (SetpointManager_WarmestTemperatureFlow_ControlVariable)Enum.Parse(typeof(SetpointManager_WarmestTemperatureFlow_ControlVariable), "Temperature");
        

[Description("Enter the name of an AirLoopHVAC object.")]
[JsonProperty("hvac_air_loop_name")]
public string HvacAirLoopName { get; set; } = "";
        

[JsonProperty("minimum_setpoint_temperature")]
public System.Nullable<float> MinimumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_setpoint_temperature")]
public System.Nullable<float> MaximumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[Description(@"For TemperatureFirst the manager tries to find the highest setpoint temperature that will satisfy all the zone cooling loads at minimum supply air flow rate. If this setpoint temperature is less than the minimum, the setpoint temperature is set to the minimum, and the supply air flow rate is increased to meet the loads. For FlowFirst the manager tries to find the lowest supply air flow rate that will satisfy all the zone cooling loads at the maximum setpoint temperature. If this flow is greater than the maximum, the flow is set to the maximum and the setpoint temperature is reduced to satisfy the cooling loads.")]
[JsonProperty("strategy")]
public SetpointManager_WarmestTemperatureFlow_Strategy Strategy { get; set; } = (SetpointManager_WarmestTemperatureFlow_Strategy)Enum.Parse(typeof(SetpointManager_WarmestTemperatureFlow_Strategy), "TemperatureFirst");
        

[Description("Node(s) at which the temperature will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
        

[Description("Fraction of the maximum supply air flow rate. Used to define the minimum supply f" +
    "low for the TemperatureFirst strategy.")]
[JsonProperty("minimum_turndown_ratio")]
public System.Nullable<float> MinimumTurndownRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
    }
    
    public enum SetpointManager_WarmestTemperatureFlow_ControlVariable
    {
        
        [JsonProperty("Temperature")]
        Temperature = 0,
    }
    
    public enum SetpointManager_WarmestTemperatureFlow_Strategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FlowFirst")]
        FlowFirst = 1,
        
        [JsonProperty("TemperatureFirst")]
        TemperatureFirst = 2,
    }
    
    [Description("This setpoint manager sets the average supply air temperature based on the heatin" +
        "g load requirements of all controlled zones in an air loop served by a central a" +
        "ir-conditioner.")]
    [JsonObject("SetpointManager:MultiZone:Heating:Average")]
    public class SetpointManager_MultiZone_Heating_Average : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of an AirLoopHVAC object")]
[JsonProperty("hvac_air_loop_name")]
public string HvacAirLoopName { get; set; } = "";
        

[JsonProperty("minimum_setpoint_temperature")]
public System.Nullable<float> MinimumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_setpoint_temperature")]
public System.Nullable<float> MaximumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description("Node(s) at which the temperature will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    [Description("This setpoint manager sets the average supply air temperature based on the coolin" +
        "g load requirements of all controlled zones in an air loop served by a central a" +
        "ir-conditioner.")]
    [JsonObject("SetpointManager:MultiZone:Cooling:Average")]
    public class SetpointManager_MultiZone_Cooling_Average : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of an AirLoopHVAC object")]
[JsonProperty("hvac_air_loop_name")]
public string HvacAirLoopName { get; set; } = "";
        

[JsonProperty("minimum_setpoint_temperature")]
public System.Nullable<float> MinimumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_setpoint_temperature")]
public System.Nullable<float> MaximumSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("18", CultureInfo.InvariantCulture);
        

[Description("Node(s) at which the temperature will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    [Description("This setpoint manager sets the average supply air minimum humidity ratio based on" +
        " moisture load requirements of all controlled zones in an air loop served by a c" +
        "entral air-conditioner.")]
    [JsonObject("SetpointManager:MultiZone:MinimumHumidity:Average")]
    public class SetpointManager_MultiZone_MinimumHumidity_Average : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of an AirLoopHVAC object")]
[JsonProperty("hvac_air_loop_name")]
public string HvacAirLoopName { get; set; } = "";
        

[JsonProperty("minimum_setpoint_humidity_ratio")]
public System.Nullable<float> MinimumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.005", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_setpoint_humidity_ratio")]
public System.Nullable<float> MaximumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.012", CultureInfo.InvariantCulture);
        

[Description("Node(s) at which the humidity ratio will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    [Description("This setpoint manager sets the average supply air maximum humidity ratio based on" +
        " moisture load requirements of all controlled zones in an air loop served by a c" +
        "entral air-conditioner.")]
    [JsonObject("SetpointManager:MultiZone:MaximumHumidity:Average")]
    public class SetpointManager_MultiZone_MaximumHumidity_Average : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of an AirLoopHVAC object")]
[JsonProperty("hvac_air_loop_name")]
public string HvacAirLoopName { get; set; } = "";
        

[JsonProperty("minimum_setpoint_humidity_ratio")]
public System.Nullable<float> MinimumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_setpoint_humidity_ratio")]
public System.Nullable<float> MaximumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.015", CultureInfo.InvariantCulture);
        

[Description("Node(s) at which the humidity ratio will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    [Description(@"This setpoint manager sets the minimum supply air humidity ratio based on humidification requirements of a controlled zone with critical humidity ratio setpoint (i.e., a zone with the highest humidity ratio setpoint) in an air loop served by a central air-conditioner.")]
    [JsonObject("SetpointManager:MultiZone:Humidity:Minimum")]
    public class SetpointManager_MultiZone_Humidity_Minimum : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of an AirLoopHVAC object")]
[JsonProperty("hvac_air_loop_name")]
public string HvacAirLoopName { get; set; } = "";
        

[JsonProperty("minimum_setpoint_humidity_ratio")]
public System.Nullable<float> MinimumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.005", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_setpoint_humidity_ratio")]
public System.Nullable<float> MaximumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.012", CultureInfo.InvariantCulture);
        

[Description("Node(s) at which the humidity ratio will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    [Description(@"This setpoint manager sets the maximum supply air humidity ratio based on dehumidification requirements of a controlled zone with critical humidity ratio setpoint (i.e., a zone with the lowest humidity ratio setpoint) in an air loop served by a central air-conditioner.")]
    [JsonObject("SetpointManager:MultiZone:Humidity:Maximum")]
    public class SetpointManager_MultiZone_Humidity_Maximum : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of an AirLoopHVAC object")]
[JsonProperty("hvac_air_loop_name")]
public string HvacAirLoopName { get; set; } = "";
        

[JsonProperty("minimum_setpoint_humidity_ratio")]
public System.Nullable<float> MinimumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_setpoint_humidity_ratio")]
public System.Nullable<float> MaximumSetpointHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.015", CultureInfo.InvariantCulture);
        

[Description("Node(s) at which the humidity ratio will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    [Description("This setpoint manager is used to place a temperature setpoint on a system node th" +
        "at is derived from the current outdoor air environmental conditions. The outdoor" +
        " air conditions are obtained from the weather information during the simulation." +
        "")]
    [JsonObject("SetpointManager:FollowOutdoorAirTemperature")]
    public class SetpointManager_FollowOutdoorAirTemperature : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_FollowOutdoorAirTemperature_ControlVariable ControlVariable { get; set; } = (SetpointManager_FollowOutdoorAirTemperature_ControlVariable)Enum.Parse(typeof(SetpointManager_FollowOutdoorAirTemperature_ControlVariable), "Temperature");
        

[JsonProperty("reference_temperature_type")]
public SetpointManager_FollowOutdoorAirTemperature_ReferenceTemperatureType ReferenceTemperatureType { get; set; } = (SetpointManager_FollowOutdoorAirTemperature_ReferenceTemperatureType)Enum.Parse(typeof(SetpointManager_FollowOutdoorAirTemperature_ReferenceTemperatureType), "OutdoorAirWetBulb");
        

[JsonProperty("offset_temperature_difference")]
public System.Nullable<float> OffsetTemperatureDifference { get; set; } = null;
        

[JsonProperty("maximum_setpoint_temperature")]
public System.Nullable<float> MaximumSetpointTemperature { get; set; } = null;
        

[JsonProperty("minimum_setpoint_temperature")]
public System.Nullable<float> MinimumSetpointTemperature { get; set; } = null;
        

[Description("Node(s) at which control variable will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    public enum SetpointManager_FollowOutdoorAirTemperature_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MaximumTemperature")]
        MaximumTemperature = 1,
        
        [JsonProperty("MinimumTemperature")]
        MinimumTemperature = 2,
        
        [JsonProperty("Temperature")]
        Temperature = 3,
    }
    
    public enum SetpointManager_FollowOutdoorAirTemperature_ReferenceTemperatureType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("OutdoorAirDryBulb")]
        OutdoorAirDryBulb = 1,
        
        [JsonProperty("OutdoorAirWetBulb")]
        OutdoorAirWetBulb = 2,
    }
    
    [Description(@"This setpoint manager is used to place a temperature setpoint on a system node that is derived from the current temperatures at a separate system node. The current value of the temperature at a reference node is obtained and used to generate setpoint on a second system node. If the reference node is also designated to be an outdoor air (intake) node, then this setpoint manager can be used to follow outdoor air conditions that are adjusted for altitude.")]
    [JsonObject("SetpointManager:FollowSystemNodeTemperature")]
    public class SetpointManager_FollowSystemNodeTemperature : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_FollowSystemNodeTemperature_ControlVariable ControlVariable { get; set; } = (SetpointManager_FollowSystemNodeTemperature_ControlVariable)Enum.Parse(typeof(SetpointManager_FollowSystemNodeTemperature_ControlVariable), "Temperature");
        

[JsonProperty("reference_node_name")]
public string ReferenceNodeName { get; set; } = "";
        

[JsonProperty("reference_temperature_type")]
public SetpointManager_FollowSystemNodeTemperature_ReferenceTemperatureType ReferenceTemperatureType { get; set; } = (SetpointManager_FollowSystemNodeTemperature_ReferenceTemperatureType)Enum.Parse(typeof(SetpointManager_FollowSystemNodeTemperature_ReferenceTemperatureType), "NodeDryBulb");
        

[JsonProperty("offset_temperature_difference")]
public System.Nullable<float> OffsetTemperatureDifference { get; set; } = null;
        

[JsonProperty("maximum_limit_setpoint_temperature")]
public System.Nullable<float> MaximumLimitSetpointTemperature { get; set; } = null;
        

[JsonProperty("minimum_limit_setpoint_temperature")]
public System.Nullable<float> MinimumLimitSetpointTemperature { get; set; } = null;
        

[Description("Node(s) at which control variable will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    public enum SetpointManager_FollowSystemNodeTemperature_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MaximumTemperature")]
        MaximumTemperature = 1,
        
        [JsonProperty("MinimumTemperature")]
        MinimumTemperature = 2,
        
        [JsonProperty("Temperature")]
        Temperature = 3,
    }
    
    public enum SetpointManager_FollowSystemNodeTemperature_ReferenceTemperatureType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NodeDryBulb")]
        NodeDryBulb = 1,
        
        [JsonProperty("NodeWetBulb")]
        NodeWetBulb = 2,
    }
    
    [Description(@"This setpoint manager is used to place a temperature setpoint on a system node that is derived from a current ground temperature. The ground temperatures are specified in different Site:GroundTemperature:* objects and used during the simulation. This setpoint manager is primarily intended for condenser or plant loops using some type of ground heat exchanger.")]
    [JsonObject("SetpointManager:FollowGroundTemperature")]
    public class SetpointManager_FollowGroundTemperature : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_FollowGroundTemperature_ControlVariable ControlVariable { get; set; } = (SetpointManager_FollowGroundTemperature_ControlVariable)Enum.Parse(typeof(SetpointManager_FollowGroundTemperature_ControlVariable), "Temperature");
        

[JsonProperty("reference_ground_temperature_object_type")]
public SetpointManager_FollowGroundTemperature_ReferenceGroundTemperatureObjectType ReferenceGroundTemperatureObjectType { get; set; } = (SetpointManager_FollowGroundTemperature_ReferenceGroundTemperatureObjectType)Enum.Parse(typeof(SetpointManager_FollowGroundTemperature_ReferenceGroundTemperatureObjectType), "SiteGroundTemperatureBuildingSurface");
        

[JsonProperty("offset_temperature_difference")]
public System.Nullable<float> OffsetTemperatureDifference { get; set; } = null;
        

[JsonProperty("maximum_setpoint_temperature")]
public System.Nullable<float> MaximumSetpointTemperature { get; set; } = null;
        

[JsonProperty("minimum_setpoint_temperature")]
public System.Nullable<float> MinimumSetpointTemperature { get; set; } = null;
        

[Description("Node(s) at which control variable will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    public enum SetpointManager_FollowGroundTemperature_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MaximumTemperature")]
        MaximumTemperature = 1,
        
        [JsonProperty("MinimumTemperature")]
        MinimumTemperature = 2,
        
        [JsonProperty("Temperature")]
        Temperature = 3,
    }
    
    public enum SetpointManager_FollowGroundTemperature_ReferenceGroundTemperatureObjectType
    {
        
        [JsonProperty("Site:GroundTemperature:BuildingSurface")]
        SiteGroundTemperatureBuildingSurface = 0,
        
        [JsonProperty("Site:GroundTemperature:Deep")]
        SiteGroundTemperatureDeep = 1,
        
        [JsonProperty("Site:GroundTemperature:FCfactorMethod")]
        SiteGroundTemperatureFCfactorMethod = 2,
        
        [JsonProperty("Site:GroundTemperature:Shallow")]
        SiteGroundTemperatureShallow = 3,
    }
    
    [Description("This setpoint manager uses one curve to determine the optimum condenser entering " +
        "water temperature for a given timestep and two other curves to place boundary co" +
        "nditions on the setpoint value.")]
    [JsonObject("SetpointManager:CondenserEnteringReset")]
    public class SetpointManager_CondenserEnteringReset : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_CondenserEnteringReset_ControlVariable ControlVariable { get; set; } = (SetpointManager_CondenserEnteringReset_ControlVariable)Enum.Parse(typeof(SetpointManager_CondenserEnteringReset_ControlVariable), "Temperature");
        

[Description("This scheduled setpoint value is only used in a given timestep if the \"Optimized\"" +
    " Condenser Entering Temperature does not fall within the prescribed boundary con" +
    "ditions.")]
[JsonProperty("default_condenser_entering_water_temperature_schedule_name")]
public string DefaultCondenserEnteringWaterTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("minimum_design_wetbulb_temperature_curve_name")]
public string MinimumDesignWetbulbTemperatureCurveName { get; set; } = "";
        

[JsonProperty("minimum_outside_air_wetbulb_temperature_curve_name")]
public string MinimumOutsideAirWetbulbTemperatureCurveName { get; set; } = "";
        

[JsonProperty("optimized_cond_entering_water_temperature_curve_name")]
public string OptimizedCondEnteringWaterTemperatureCurveName { get; set; } = "";
        

[JsonProperty("minimum_lift")]
public System.Nullable<float> MinimumLift { get; set; } = (System.Nullable<float>)Single.Parse("11.1", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_condenser_entering_water_temperature")]
public System.Nullable<float> MaximumCondenserEnteringWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("32", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_tower_design_inlet_air_wet_bulb_temperature")]
public System.Nullable<float> CoolingTowerDesignInletAirWetBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25.56", CultureInfo.InvariantCulture);
        

[Description("Node(s) at which control variable will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    public enum SetpointManager_CondenserEnteringReset_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Temperature")]
        Temperature = 1,
    }
    
    [Description("This setpoint manager determine the ideal optimum condenser entering water temper" +
        "ature setpoint for a given timestep.")]
    [JsonObject("SetpointManager:CondenserEnteringReset:Ideal")]
    public class SetpointManager_CondenserEnteringReset_Ideal : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("control_variable")]
public SetpointManager_CondenserEnteringReset_Ideal_ControlVariable ControlVariable { get; set; } = (SetpointManager_CondenserEnteringReset_Ideal_ControlVariable)Enum.Parse(typeof(SetpointManager_CondenserEnteringReset_Ideal_ControlVariable), "Temperature");
        

[JsonProperty("minimum_lift")]
public System.Nullable<float> MinimumLift { get; set; } = (System.Nullable<float>)Single.Parse("11.1", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_condenser_entering_water_temperature")]
public System.Nullable<float> MaximumCondenserEnteringWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("32", CultureInfo.InvariantCulture);
        

[Description("Node(s) at which control variable will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    public enum SetpointManager_CondenserEnteringReset_Ideal_ControlVariable
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Temperature")]
        Temperature = 1,
    }
    
    [Description(@"This object can be used with CoilSystem:Cooling:DX to model on/off cycling control of single stage air systems. Setpoints are modulated to run coil full on or full off depending on zone conditions. Intended for use with ZoneControl:Thermostat:StagedDualSetpoint")]
    [JsonObject("SetpointManager:SingleZone:OneStageCooling")]
    public class SetpointManager_SingleZone_OneStageCooling : BHoMObject, IEnergyPlusClass
    {
        

[Description("This is the setpoint value applied when cooling device is to cycle ON")]
[JsonProperty("cooling_stage_on_supply_air_setpoint_temperature")]
public System.Nullable<float> CoolingStageOnSupplyAirSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-99", CultureInfo.InvariantCulture);
        

[Description("This is the setpoint value applied when cooling device is to cycle OFF")]
[JsonProperty("cooling_stage_off_supply_air_setpoint_temperature")]
public System.Nullable<float> CoolingStageOffSupplyAirSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("99", CultureInfo.InvariantCulture);
        

[JsonProperty("control_zone_name")]
public string ControlZoneName { get; set; } = "";
        

[Description("Node(s) at which the temperature will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    [Description(@"This object can be used with CoilSystem:Heating:DX, Coil:Heating:Fuel, Coil:Heating:Electric to model on/off cycling control of single stage air systems. Setpoints are modulated to run coil full on or full off depending on zone conditions. Intended for use with ZoneControl:Thermostat:StagedDualSetpoint.")]
    [JsonObject("SetpointManager:SingleZone:OneStageHeating")]
    public class SetpointManager_SingleZone_OneStageHeating : BHoMObject, IEnergyPlusClass
    {
        

[Description("This is the setpoint value applied when heating device is to cycle ON")]
[JsonProperty("heating_stage_on_supply_air_setpoint_temperature")]
public System.Nullable<float> HeatingStageOnSupplyAirSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("99", CultureInfo.InvariantCulture);
        

[Description("This is the setpoint value applied when heating device is to cycle OFF")]
[JsonProperty("heating_stage_off_supply_air_setpoint_temperature")]
public System.Nullable<float> HeatingStageOffSupplyAirSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-99", CultureInfo.InvariantCulture);
        

[JsonProperty("control_zone_name")]
public string ControlZoneName { get; set; } = "";
        

[Description("Node(s) at which the temperature will be set")]
[JsonProperty("setpoint_node_or_nodelist_name")]
public string SetpointNodeOrNodelistName { get; set; } = "";
    }
    
    [Description(@"This setpoint manager is used to place a temperature setpoint on a plant supply outlet node based on a target return water setpoint. The setpoint manager attempts to achieve the desired return water temperature by adjusting the supply temperature setpoint based on the plant conditions at each system time step.")]
    [JsonObject("SetpointManager:ReturnTemperature:ChilledWater")]
    public class SetpointManager_ReturnTemperature_ChilledWater : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"This is the name of the supply outlet node for the plant being controlled by this setpoint manager. Typically this is where the setpoint will be actuated for supply equipment to control to, but not necessarily. This setpoint manager will mine that information from the internal plant data structures.")]
[JsonProperty("plant_loop_supply_outlet_node")]
public string PlantLoopSupplyOutletNode { get; set; } = "";
        

[Description("This is the name of the supply inlet node for the plant being controlled with thi" +
    "s setpoint manager. The temperature on this node is controlled by actuating the " +
    "supply setpoint.")]
[JsonProperty("plant_loop_supply_inlet_node")]
public string PlantLoopSupplyInletNode { get; set; } = "";
        

[Description("This is the minimum chilled water supply temperature setpoint. This is also used " +
    "as the default setpoint during no-load or negative-load conditions and during in" +
    "itialization.")]
[JsonProperty("minimum_supply_temperature_setpoint")]
public System.Nullable<float> MinimumSupplyTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[Description("This is the maximum reset temperature for the chilled water supply.")]
[JsonProperty("maximum_supply_temperature_setpoint")]
public System.Nullable<float> MaximumSupplyTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("This defines whether the chilled water return temperature target is constant, sch" +
    "eduled, or specified on the supply inlet node by a separate setpoint manager.")]
[JsonProperty("return_temperature_setpoint_input_type")]
public SetpointManager_ReturnTemperature_ChilledWater_ReturnTemperatureSetpointInputType ReturnTemperatureSetpointInputType { get; set; } = (SetpointManager_ReturnTemperature_ChilledWater_ReturnTemperatureSetpointInputType)Enum.Parse(typeof(SetpointManager_ReturnTemperature_ChilledWater_ReturnTemperatureSetpointInputType), "Constant");
        

[Description("This is the desired return temperature target, which is met by adjusting the supp" +
    "ly temperature setpoint. This constant value is only used if the Design Chilled " +
    "Water Return Temperature Input Type is Constant")]
[JsonProperty("return_temperature_setpoint_constant_value")]
public System.Nullable<float> ReturnTemperatureSetpointConstantValue { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[Description(@"This is the desired return temperature target, which is met by adjusting the supply temperature setpoint. This is a schedule name to allow the return temperature target value to be scheduled. This field is only used if the Design Chilled Water Return Temperature Input Type is Scheduled")]
[JsonProperty("return_temperature_setpoint_schedule_name")]
public string ReturnTemperatureSetpointScheduleName { get; set; } = "";
    }
    
    public enum SetpointManager_ReturnTemperature_ChilledWater_ReturnTemperatureSetpointInputType
    {
        
        [JsonProperty("Constant")]
        Constant = 0,
        
        [JsonProperty("ReturnTemperatureSetpoint")]
        ReturnTemperatureSetpoint = 1,
        
        [JsonProperty("Scheduled")]
        Scheduled = 2,
    }
    
    [Description(@"This setpoint manager is used to place a temperature setpoint on a plant supply outlet node based on a target return water setpoint. The setpoint manager attempts to achieve the desired return water temperature by adjusting the supply temperature setpoint based on the plant conditions at each system time step.")]
    [JsonObject("SetpointManager:ReturnTemperature:HotWater")]
    public class SetpointManager_ReturnTemperature_HotWater : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"This is the name of the supply outlet node for the plant being controlled by this setpoint manager. Typically this is where the setpoint will be actuated for supply equipment to control to, but not necessarily. This setpoint manager will mine that information from the internal plant data structures.")]
[JsonProperty("plant_loop_supply_outlet_node")]
public string PlantLoopSupplyOutletNode { get; set; } = "";
        

[Description("This is the name of the supply inlet node for the plant being controlled with thi" +
    "s setpoint manager. The temperature on this node is controlled by actuating the " +
    "supply setpoint.")]
[JsonProperty("plant_loop_supply_inlet_node")]
public string PlantLoopSupplyInletNode { get; set; } = "";
        

[Description("This is the minimum reset temperature for the hot water supply.")]
[JsonProperty("minimum_supply_temperature_setpoint")]
public System.Nullable<float> MinimumSupplyTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("77", CultureInfo.InvariantCulture);
        

[Description("This is the maximum hot water supply temperature setpoint. This is also used as t" +
    "he default setpoint during no-load or negative-load conditions and during initia" +
    "lization.")]
[JsonProperty("maximum_supply_temperature_setpoint")]
public System.Nullable<float> MaximumSupplyTemperatureSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("82", CultureInfo.InvariantCulture);
        

[Description("This defines whether the hot water return temperature target is constant, schedul" +
    "ed, or specified on the supply inlet node by a separate setpoint manager.")]
[JsonProperty("return_temperature_setpoint_input_type")]
public SetpointManager_ReturnTemperature_HotWater_ReturnTemperatureSetpointInputType ReturnTemperatureSetpointInputType { get; set; } = (SetpointManager_ReturnTemperature_HotWater_ReturnTemperatureSetpointInputType)Enum.Parse(typeof(SetpointManager_ReturnTemperature_HotWater_ReturnTemperatureSetpointInputType), "Constant");
        

[Description("This is the desired return temperature target, which is met by adjusting the supp" +
    "ly temperature setpoint. This constant value is only used if the Design Hot Wate" +
    "r Return Temperature Input Type is Constant")]
[JsonProperty("return_temperature_setpoint_constant_value")]
public System.Nullable<float> ReturnTemperatureSetpointConstantValue { get; set; } = (System.Nullable<float>)Single.Parse("71", CultureInfo.InvariantCulture);
        

[Description(@"This is the desired return temperature target, which is met by adjusting the supply temperature setpoint. This is a schedule name to allow the return temperature target value to be scheduled. This field is only used if the Design Hot Water Return Temperature Input Type is Scheduled")]
[JsonProperty("return_temperature_setpoint_schedule_name")]
public string ReturnTemperatureSetpointScheduleName { get; set; } = "";
    }
    
    public enum SetpointManager_ReturnTemperature_HotWater_ReturnTemperatureSetpointInputType
    {
        
        [JsonProperty("Constant")]
        Constant = 0,
        
        [JsonProperty("ReturnTemperatureSetpoint")]
        ReturnTemperatureSetpoint = 1,
        
        [JsonProperty("Scheduled")]
        Scheduled = 2,
    }
}
