namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
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
    using BH.oM.Adapters.EnergyPlus.SetpointManagers;
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
    
    
    [Description(@"Zone thermostat control. Referenced schedules must be defined elsewhere in the idf. Thermostat control type is dual setpoint with deadband. It is not necessary to create a thermostat object for every zone, only for each unique set of setpoint schedules. For example, an office building may have two thermostat objects, one for ""Office"" and one for ""Storage"".")]
    [JsonObject("HVACTemplate:Thermostat")]
    public class HVACTemplate_Thermostat : BHoMObject, IEnergyPlusClass
    {
        

[Description("Leave blank if constant setpoint specified below, must enter schedule or constant" +
    " setpoint")]
[JsonProperty("heating_setpoint_schedule_name")]
public string HeatingSetpointScheduleName { get; set; } = "";
        

[Description("Ignored if schedule specified above, must enter schedule or constant setpoint")]
[JsonProperty("constant_heating_setpoint")]
public System.Nullable<float> ConstantHeatingSetpoint { get; set; } = null;
        

[Description("Leave blank if constant setpoint specified below, must enter schedule or constant" +
    " setpoint")]
[JsonProperty("cooling_setpoint_schedule_name")]
public string CoolingSetpointScheduleName { get; set; } = "";
        

[Description("Ignored if schedule specified above, must enter schedule or constant setpoint")]
[JsonProperty("constant_cooling_setpoint")]
public System.Nullable<float> ConstantCoolingSetpoint { get; set; } = null;
    }
    
    [Description("Zone with ideal air system that meets heating or cooling loads")]
    [JsonObject("HVACTemplate:Zone:IdealLoadsAirSystem")]
    public class HVACTemplate_Zone_IdealLoadsAirSystem : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("If blank, always on")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("maximum_heating_supply_air_temperature")]
public System.Nullable<float> MaximumHeatingSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_cooling_supply_air_temperature")]
public System.Nullable<float> MinimumCoolingSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_heating_supply_air_humidity_ratio")]
public System.Nullable<float> MaximumHeatingSupplyAirHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.0156", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_cooling_supply_air_humidity_ratio")]
public System.Nullable<float> MinimumCoolingSupplyAirHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.0077", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_limit")]
public HVACTemplate_Zone_IdealLoadsAirSystem_HeatingLimit HeatingLimit { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_HeatingLimit)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_HeatingLimit), "NoLimit");
        

[Description("This field is ignored if Heating Limit = NoLimit If this field is blank, there is" +
    " no limit.")]
[JsonProperty("maximum_heating_air_flow_rate")]
public string MaximumHeatingAirFlowRate { get; set; } = "";
        

[Description("This field is ignored if Heating Limit = NoLimit If this field is blank, there is" +
    " no limit.")]
[JsonProperty("maximum_sensible_heating_capacity")]
public string MaximumSensibleHeatingCapacity { get; set; } = "";
        

[JsonProperty("cooling_limit")]
public HVACTemplate_Zone_IdealLoadsAirSystem_CoolingLimit CoolingLimit { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_CoolingLimit)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_CoolingLimit), "NoLimit");
        

[Description("This field is ignored if Cooling Limit = NoLimit This field is required if Outdoo" +
    "r Air Economizer Type is anything other than NoEconomizer.")]
[JsonProperty("maximum_cooling_air_flow_rate")]
public string MaximumCoolingAirFlowRate { get; set; } = "";
        

[Description("This field is ignored if Cooling Limit = NoLimit")]
[JsonProperty("maximum_total_cooling_capacity")]
public string MaximumTotalCoolingCapacity { get; set; } = "";
        

[Description("If blank, heating is always available.")]
[JsonProperty("heating_availability_schedule_name")]
public string HeatingAvailabilityScheduleName { get; set; } = "";
        

[Description("If blank, cooling is always available.")]
[JsonProperty("cooling_availability_schedule_name")]
public string CoolingAvailabilityScheduleName { get; set; } = "";
        

[Description(@"ConstantSensibleHeatRatio means that the ideal loads system will be controlled to meet the sensible cooling load, and the latent cooling rate will be computed using a constant sensible heat ratio (SHR) Humidistat means that there is a ZoneControl:Humidistat for this zone and the ideal loads system will attempt to satisfy the humidistat. None means that there is no dehumidification. ConstantSupplyHumidityRatio means that during cooling the supply air will always be at the Minimum Cooling Supply Humidity Ratio.")]
[JsonProperty("dehumidification_control_type")]
public HVACTemplate_Zone_IdealLoadsAirSystem_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_DehumidificationControlType), "ConstantSensibleHeatRatio");
        

[Description("This field is applicable only when Dehumidification Control Type is ConstantSensi" +
    "bleHeatRatio")]
[JsonProperty("cooling_sensible_heat_ratio")]
public System.Nullable<float> CoolingSensibleHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("Zone relative humidity setpoint in percent (0 to 100)")]
[JsonProperty("dehumidification_setpoint")]
public System.Nullable<float> DehumidificationSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[Description(@"None means that there is no humidification. Humidistat means that there is a ZoneControl:Humidistat for this zone and the ideal loads system will attempt to satisfy the humidistat. ConstantSupplyHumidityRatio means that during heating the supply air will always be at the Maximum Heating Supply Humidity Ratio.")]
[JsonProperty("humidification_control_type")]
public HVACTemplate_Zone_IdealLoadsAirSystem_HumidificationControlType HumidificationControlType { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_HumidificationControlType)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_HumidificationControlType), "None");
        

[Description("Zone relative humidity setpoint in percent (0 to 100)")]
[JsonProperty("humidification_setpoint")]
public System.Nullable<float> HumidificationSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description(@"None means there is no outdoor air and all related fields will be ignored Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirMethod), "None");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the minimum outdoor air flow rate will be computed using these specifications. The outdoor air flow rate will also be affected by the next two fields. If this field is blank, there will be no outdoor air and the remaining fields will be ignored.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description(@"This field controls how the minimum outdoor air flow rate is calculated. None means that design occupancy will be used to compute the minimum outdoor air flow rate OccupancySchedule means that current occupancy level will be used. CO2Setpoint means that the design occupancy will be used to compute the minimum outdoor air flow rate and the outdoor air flow rate may be increased if necessary to maintain the indoor air carbon dioxide setpoint defined in a ZoneControl:ContaminantController object.")]
[JsonProperty("demand_controlled_ventilation_type")]
public HVACTemplate_Zone_IdealLoadsAirSystem_DemandControlledVentilationType DemandControlledVentilationType { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_DemandControlledVentilationType)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_DemandControlledVentilationType), "None");
        

[Description("DifferentialDryBulb and DifferentialEnthalpy will increase the outdoor air flow r" +
    "ate when there is a cooling load and the outdoor air temperature or enthalpy is " +
    "below the zone exhaust air temperature or enthalpy.")]
[JsonProperty("outdoor_air_economizer_type")]
public HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirEconomizerType OutdoorAirEconomizerType { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirEconomizerType)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirEconomizerType), "NoEconomizer");
        

[JsonProperty("heat_recovery_type")]
public HVACTemplate_Zone_IdealLoadsAirSystem_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_Zone_IdealLoadsAirSystem_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_Zone_IdealLoadsAirSystem_HeatRecoveryType), "None");
        

[JsonProperty("sensible_heat_recovery_effectiveness")]
public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Heat Recovery Type is Enthalpy.")]
[JsonProperty("latent_heat_recovery_effectiveness")]
public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
    }
    
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_HeatingLimit
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LimitCapacity")]
        LimitCapacity = 1,
        
        [JsonProperty("LimitFlowRate")]
        LimitFlowRate = 2,
        
        [JsonProperty("LimitFlowRateAndCapacity")]
        LimitFlowRateAndCapacity = 3,
        
        [JsonProperty("NoLimit")]
        NoLimit = 4,
    }
    
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_CoolingLimit
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LimitCapacity")]
        LimitCapacity = 1,
        
        [JsonProperty("LimitFlowRate")]
        LimitFlowRate = 2,
        
        [JsonProperty("LimitFlowRateAndCapacity")]
        LimitFlowRateAndCapacity = 3,
        
        [JsonProperty("NoLimit")]
        NoLimit = 4,
    }
    
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantSensibleHeatRatio")]
        ConstantSensibleHeatRatio = 1,
        
        [JsonProperty("ConstantSupplyHumidityRatio")]
        ConstantSupplyHumidityRatio = 2,
        
        [JsonProperty("Humidistat")]
        Humidistat = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_HumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantSupplyHumidityRatio")]
        ConstantSupplyHumidityRatio = 1,
        
        [JsonProperty("Humidistat")]
        Humidistat = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("None")]
        None = 6,
        
        [JsonProperty("Sum")]
        Sum = 7,
    }
    
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_DemandControlledVentilationType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CO2Setpoint")]
        CO2Setpoint = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("OccupancySchedule")]
        OccupancySchedule = 3,
    }
    
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_OutdoorAirEconomizerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [JsonProperty("DifferentialEnthalpy")]
        DifferentialEnthalpy = 2,
        
        [JsonProperty("NoEconomizer")]
        NoEconomizer = 3,
    }
    
    public enum HVACTemplate_Zone_IdealLoadsAirSystem_HeatRecoveryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Sensible")]
        Sensible = 3,
    }
    
    [Description("Zone baseboard heating system.")]
    [JsonObject("HVACTemplate:Zone:BaseboardHeat")]
    public class HVACTemplate_Zone_BaseboardHeat : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[JsonProperty("baseboard_heating_type")]
public HVACTemplate_Zone_BaseboardHeat_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_BaseboardHeat_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_BaseboardHeat_BaseboardHeatingType), "HotWater");
        

[Description("If blank, always on")]
[JsonProperty("baseboard_heating_availability_schedule_name")]
public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_capacity")]
public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
    "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
    "f no DOAS serves this zone.")]
[JsonProperty("dedicated_outdoor_air_system_name")]
public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

[Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_BaseboardHeat_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_BaseboardHeat_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_BaseboardHeat_OutdoorAirMethod), "Empty");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
    }
    
    public enum HVACTemplate_Zone_BaseboardHeat_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
    }
    
    public enum HVACTemplate_Zone_BaseboardHeat_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
    
    [Description("4 pipe fan coil unit with optional outdoor air.")]
    [JsonObject("HVACTemplate:Zone:FanCoil")]
    public class HVACTemplate_Zone_FanCoil : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
    " by the Supply Air Sizing Factor and by zone multipliers.")]
[JsonProperty("supply_air_maximum_flow_rate")]
public string SupplyAirMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_cooling_sizing_factor")]
public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

[Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_FanCoil_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_FanCoil_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_FanCoil_OutdoorAirMethod), "Empty");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If blank, always on")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("supply_fan_total_efficiency")]
public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_delta_pressure")]
public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("75", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_efficiency")]
public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_Zone_FanCoil_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_Zone_FanCoil_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_FanCoil_CoolingCoilType), "ChilledWater");
        

[Description("If blank, always on")]
[JsonProperty("cooling_coil_availability_schedule_name")]
public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Used for sizing when Zone Cooling Design Supply Air Temperature Input Method = Su" +
    "pplyAirTemperature")]
[JsonProperty("cooling_coil_design_setpoint")]
public System.Nullable<float> CoolingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("14", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_type")]
public HVACTemplate_Zone_FanCoil_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_Zone_FanCoil_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_FanCoil_HeatingCoilType), "HotWater");
        

[Description("If blank, always on")]
[JsonProperty("heating_coil_availability_schedule_name")]
public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Used for sizing when Zone Heating Design Supply Air Temperature Input Method = Su" +
    "pplyAirTemperature")]
[JsonProperty("heating_coil_design_setpoint")]
public System.Nullable<float> HeatingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
    "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
    "f no DOAS serves this zone.")]
[JsonProperty("dedicated_outdoor_air_system_name")]
public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

[Description("SupplyAirTemperature = use the value from Cooling Coil Design Setpoint (above) Te" +
    "mperatureDifference = use the value from Zone Cooling Design Supply Air Temperat" +
    "ure Difference")]
[JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_FanCoil_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_FanCoil_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_FanCoil_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
[JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

[Description("SupplyAirTemperature = use the value from Heating Coil Design Setpoint (above) Te" +
    "mperatureDifference = use the value from Zone Heating Design Supply Air Temperat" +
    "ure Difference")]
[JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_FanCoil_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_FanCoil_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_FanCoil_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
[JsonProperty("zone_heating_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

[Description("If this field is left blank, it will default to CyclingFan if a Dedicated Outdoor" +
    " Air System is specified (see above), otherwise it will default to ConstantFanVa" +
    "riableFlow.")]
[JsonProperty("capacity_control_method")]
public HVACTemplate_Zone_FanCoil_CapacityControlMethod CapacityControlMethod { get; set; } = (HVACTemplate_Zone_FanCoil_CapacityControlMethod)Enum.Parse(typeof(HVACTemplate_Zone_FanCoil_CapacityControlMethod), "ASHRAE90VariableFan");
        

[JsonProperty("low_speed_supply_air_flow_ratio")]
public System.Nullable<float> LowSpeedSupplyAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.33", CultureInfo.InvariantCulture);
        

[Description("Medium Speed Supply Air Flow Ratio should be greater than Low Speed Supply Air Fl" +
    "ow Ratio")]
[JsonProperty("medium_speed_supply_air_flow_ratio")]
public System.Nullable<float> MediumSpeedSupplyAirFlowRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.66", CultureInfo.InvariantCulture);
        

[Description("Value of schedule multiplies maximum outdoor air flow rate This schedule is ignor" +
    "ed if this zone is served by an HVACTemplate dedicated outdoor air system.")]
[JsonProperty("outdoor_air_schedule_name")]
public string OutdoorAirScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_type")]
public HVACTemplate_Zone_FanCoil_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_FanCoil_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_FanCoil_BaseboardHeatingType), "None");
        

[Description("If blank, always on")]
[JsonProperty("baseboard_heating_availability_schedule_name")]
public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_capacity")]
public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
    }
    
    public enum HVACTemplate_Zone_FanCoil_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
    
    public enum HVACTemplate_Zone_FanCoil_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 1,
        
        [JsonProperty("ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
        
        [JsonProperty("HeatExchangerAssistedChilledWater")]
        HeatExchangerAssistedChilledWater = 3,
    }
    
    public enum HVACTemplate_Zone_FanCoil_HeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
    }
    
    public enum HVACTemplate_Zone_FanCoil_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    public enum HVACTemplate_Zone_FanCoil_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    public enum HVACTemplate_Zone_FanCoil_CapacityControlMethod
    {
        
        [JsonProperty("ASHRAE90VariableFan")]
        ASHRAE90VariableFan = 0,
        
        [JsonProperty("ConstantFanVariableFlow")]
        ConstantFanVariableFlow = 1,
        
        [JsonProperty("CyclingFan")]
        CyclingFan = 2,
        
        [JsonProperty("MultiSpeedFan")]
        MultiSpeedFan = 3,
        
        [JsonProperty("VariableFanConstantFlow")]
        VariableFanConstantFlow = 4,
        
        [JsonProperty("VariableFanVariableFlow")]
        VariableFanVariableFlow = 5,
    }
    
    public enum HVACTemplate_Zone_FanCoil_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    [Description("Packaged Terminal Air Conditioner")]
    [JsonObject("HVACTemplate:Zone:PTAC")]
    public class HVACTemplate_Zone_PTAC : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("Supply air flow rate during cooling operation This field may be set to \"autosize\"" +
    ". If a value is entered, it will be multiplied by the Supply Air Sizing Factor a" +
    "nd by zone multipliers.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public string CoolingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Supply air flow rate during heating operation This field may be set to \"autosize\"" +
    ". If a value is entered, it will be multiplied by the Supply Air Sizing Factor a" +
    "nd by zone multipliers.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description(@"Supply air flow rate when no cooling or heating is needed Only used when heat pump fan operating mode is continuous. This air flow rate is used when no heating or cooling is required and the DX coil compressor is off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used. A value entered in this field will *not* be multiplied by the sizing factor or by zone multipliers. It is best to autosize or leave blank when using zone multipliers.")]
[JsonProperty("no_load_supply_air_flow_rate")]
public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_cooling_sizing_factor")]
public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

[Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_PTAC_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_PTAC_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTAC_OutdoorAirMethod), "Empty");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If blank, always on")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule Name " +
    "values of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous" +
    " fan (on) If this field is left blank, a schedule of always zero (cycling fan) w" +
    "ill be used.")]
[JsonProperty("supply_fan_operating_mode_schedule_name")]
public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

[JsonProperty("supply_fan_placement")]
public HVACTemplate_Zone_PTAC_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_Zone_PTAC_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_Zone_PTAC_SupplyFanPlacement), "DrawThrough");
        

[JsonProperty("supply_fan_total_efficiency")]
public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_delta_pressure")]
public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("75", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_efficiency")]
public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_Zone_PTAC_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_Zone_PTAC_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_PTAC_CoolingCoilType), "SingleSpeedDX");
        

[Description("If blank, always on")]
[JsonProperty("cooling_coil_availability_schedule_name")]
public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat Ratin" +
    "g point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and a" +
    "ir entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("cooling_coil_gross_rated_total_capacity")]
public string CoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
    " and total capacities do not include effect of supply fan heat")]
[JsonProperty("cooling_coil_gross_rated_sensible_heat_ratio")]
public string CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electrical energy input")]
[JsonProperty("cooling_coil_gross_rated_cooling_cop")]
public System.Nullable<float> CoolingCoilGrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_type")]
public HVACTemplate_Zone_PTAC_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_Zone_PTAC_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_PTAC_HeatingCoilType), "Electric");
        

[Description("If blank, always on")]
[JsonProperty("heating_coil_availability_schedule_name")]
public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("heating_coil_capacity")]
public string HeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Applies only if Heating Coil Type is Gas")]
[JsonProperty("gas_heating_coil_efficiency")]
public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[Description("Applies only if Heating Coil Type is Gas")]
[JsonProperty("gas_heating_coil_parasitic_electric_load")]
public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
    "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
    "f no DOAS serves this zone.")]
[JsonProperty("dedicated_outdoor_air_system_name")]
public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

[Description("SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperat" +
    "ure TemperatureDifference = use the value from Zone Cooling Design Supply Air Te" +
    "mperature Difference")]
[JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_PTAC_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_PTAC_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTAC_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_cooling_design_supply_air_temperature")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("14", CultureInfo.InvariantCulture);
        

[Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
[JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

[Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperat" +
    "ure TemperatureDifference = use the value from Zone Heating Design Supply Air Te" +
    "mperature Difference")]
[JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_PTAC_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_PTAC_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTAC_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_heating_design_supply_air_temperature")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
[JsonProperty("zone_heating_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

[JsonProperty("baseboard_heating_type")]
public HVACTemplate_Zone_PTAC_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_PTAC_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_PTAC_BaseboardHeatingType), "None");
        

[Description("If blank, always on")]
[JsonProperty("baseboard_heating_availability_schedule_name")]
public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_capacity")]
public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

[JsonProperty("capacity_control_method")]
public HVACTemplate_Zone_PTAC_CapacityControlMethod CapacityControlMethod { get; set; } = (HVACTemplate_Zone_PTAC_CapacityControlMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTAC_CapacityControlMethod), "None");
    }
    
    public enum HVACTemplate_Zone_PTAC_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
    
    public enum HVACTemplate_Zone_PTAC_SupplyFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_Zone_PTAC_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SingleSpeedDX")]
        SingleSpeedDX = 1,
    }
    
    public enum HVACTemplate_Zone_PTAC_HeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
    }
    
    public enum HVACTemplate_Zone_PTAC_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    public enum HVACTemplate_Zone_PTAC_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    public enum HVACTemplate_Zone_PTAC_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum HVACTemplate_Zone_PTAC_CapacityControlMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("SingleZoneVAV")]
        SingleZoneVAV = 2,
    }
    
    [Description("Packaged Terminal Heat Pump")]
    [JsonObject("HVACTemplate:Zone:PTHP")]
    public class HVACTemplate_Zone_PTHP : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("Supply air flow rate during cooling operation This field may be set to \"autosize\"" +
    ". If a value is entered, it will be multiplied by the Supply Air Sizing Factor a" +
    "nd by zone multipliers.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public string CoolingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Supply air flow rate during heating operation This field may be set to \"autosize\"" +
    ". If a value is entered, it will be multiplied by the Supply Air Sizing Factor a" +
    "nd by zone multipliers.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description(@"Supply air flow rate when no cooling or heating is needed Only used when heat pump fan operating mode is continuous. This air flow rate is used when no heating or cooling is required and the DX coil compressor is off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used. A value entered in this field will *not* be multiplied by the sizing factor or by zone multipliers. It is best to autosize or leave blank when using zone multipliers.")]
[JsonProperty("no_load_supply_air_flow_rate")]
public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_cooling_sizing_factor")]
public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

[Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_PTHP_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_PTHP_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_OutdoorAirMethod), "Empty");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If blank, always on")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
    "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
    "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
    "e used.")]
[JsonProperty("supply_fan_operating_mode_schedule_name")]
public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

[JsonProperty("supply_fan_placement")]
public HVACTemplate_Zone_PTHP_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_Zone_PTHP_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_SupplyFanPlacement), "DrawThrough");
        

[JsonProperty("supply_fan_total_efficiency")]
public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_delta_pressure")]
public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("75", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_efficiency")]
public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_Zone_PTHP_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_Zone_PTHP_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_CoolingCoilType), "SingleSpeedDX");
        

[Description("If blank, always on")]
[JsonProperty("cooling_coil_availability_schedule_name")]
public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat Ratin" +
    "g point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and a" +
    "ir entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("cooling_coil_gross_rated_total_capacity")]
public string CoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
    " and total capacities do not include effect of supply fan heat")]
[JsonProperty("cooling_coil_gross_rated_sensible_heat_ratio")]
public string CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electrical energy input")]
[JsonProperty("cooling_coil_gross_rated_cop")]
public System.Nullable<float> CoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_pump_heating_coil_type")]
public HVACTemplate_Zone_PTHP_HeatPumpHeatingCoilType HeatPumpHeatingCoilType { get; set; } = (HVACTemplate_Zone_PTHP_HeatPumpHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_HeatPumpHeatingCoilType), "SingleSpeedDXHeatPump");
        

[Description("If blank, always on")]
[JsonProperty("heat_pump_heating_coil_availability_schedule_name")]
public string HeatPumpHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Capacity excluding supply air fan heat Rating point outdoor dry-bulb temp 8.33 C," +
    " outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21" +
    ".11 C, coil entering wet-bulb 15.55 C")]
[JsonProperty("heat_pump_heating_coil_gross_rated_capacity")]
public string HeatPumpHeatingCoilGrossRatedCapacity { get; set; } = (System.String)"Autosize";
        

[Description(@"Heat Pump Heating Coil Rated Capacity divided by power input to the compressor and outdoor fan, Does not include supply air fan heat or supply air fan electrical energy Rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
[JsonProperty("heat_pump_heating_coil_gross_rated_cop")]
public System.Nullable<float> HeatPumpHeatingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("2.75", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_pump_heating_minimum_outdoor_dry_bulb_temperature")]
public System.Nullable<float> HeatPumpHeatingMinimumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_pump_defrost_maximum_outdoor_dry_bulb_temperature")]
public System.Nullable<float> HeatPumpDefrostMaximumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_pump_defrost_strategy")]
public HVACTemplate_Zone_PTHP_HeatPumpDefrostStrategy HeatPumpDefrostStrategy { get; set; } = (HVACTemplate_Zone_PTHP_HeatPumpDefrostStrategy)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_HeatPumpDefrostStrategy), "ReverseCycle");
        

[JsonProperty("heat_pump_defrost_control")]
public HVACTemplate_Zone_PTHP_HeatPumpDefrostControl HeatPumpDefrostControl { get; set; } = (HVACTemplate_Zone_PTHP_HeatPumpDefrostControl)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_HeatPumpDefrostControl), "Timed");
        

[Description("Fraction of time in defrost mode only applicable if Timed defrost control is spec" +
    "ified")]
[JsonProperty("heat_pump_defrost_time_period_fraction")]
public System.Nullable<float> HeatPumpDefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

[JsonProperty("supplemental_heating_coil_type")]
public HVACTemplate_Zone_PTHP_SupplementalHeatingCoilType SupplementalHeatingCoilType { get; set; } = (HVACTemplate_Zone_PTHP_SupplementalHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_SupplementalHeatingCoilType), "Electric");
        

[Description("If blank, always on")]
[JsonProperty("supplemental_heating_coil_availability_schedule_name")]
public string SupplementalHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("supplemental_heating_coil_capacity")]
public string SupplementalHeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Supplemental heater will not operate when outdoor temperature exceeds this value." +
    "")]
[JsonProperty("supplemental_heating_coil_maximum_outdoor_dry_bulb_temperature")]
public System.Nullable<float> SupplementalHeatingCoilMaximumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

[Description("Applies only if Supplemental Heating Coil Type is Gas")]
[JsonProperty("supplemental_gas_heating_coil_efficiency")]
public System.Nullable<float> SupplementalGasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[Description("Applies only if Supplemental Heating Coil Type is Gas")]
[JsonProperty("supplemental_gas_heating_coil_parasitic_electric_load")]
public System.Nullable<float> SupplementalGasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
    "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
    "f no DOAS serves this zone.")]
[JsonProperty("dedicated_outdoor_air_system_name")]
public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

[Description("SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperat" +
    "ure TemperatureDifference = use the value from Zone Cooling Design Supply Air Te" +
    "mperature Difference")]
[JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_PTHP_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_PTHP_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_cooling_design_supply_air_temperature")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("14", CultureInfo.InvariantCulture);
        

[Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
[JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

[Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperat" +
    "ure TemperatureDifference = use the value from Zone Heating Design Supply Air Te" +
    "mperature Difference")]
[JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_PTHP_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_PTHP_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_heating_design_supply_air_temperature")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
[JsonProperty("zone_heating_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

[JsonProperty("baseboard_heating_type")]
public HVACTemplate_Zone_PTHP_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_PTHP_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_BaseboardHeatingType), "None");
        

[Description("If blank, always on")]
[JsonProperty("baseboard_heating_availability_schedule_name")]
public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_capacity")]
public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

[JsonProperty("capacity_control_method")]
public HVACTemplate_Zone_PTHP_CapacityControlMethod CapacityControlMethod { get; set; } = (HVACTemplate_Zone_PTHP_CapacityControlMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_CapacityControlMethod), "None");
    }
    
    public enum HVACTemplate_Zone_PTHP_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
    
    public enum HVACTemplate_Zone_PTHP_SupplyFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_Zone_PTHP_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SingleSpeedDX")]
        SingleSpeedDX = 1,
    }
    
    public enum HVACTemplate_Zone_PTHP_HeatPumpHeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SingleSpeedDXHeatPump")]
        SingleSpeedDXHeatPump = 1,
    }
    
    public enum HVACTemplate_Zone_PTHP_HeatPumpDefrostStrategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Resistive")]
        Resistive = 1,
        
        [JsonProperty("ReverseCycle")]
        ReverseCycle = 2,
    }
    
    public enum HVACTemplate_Zone_PTHP_HeatPumpDefrostControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("OnDemand")]
        OnDemand = 1,
        
        [JsonProperty("Timed")]
        Timed = 2,
    }
    
    public enum HVACTemplate_Zone_PTHP_SupplementalHeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
    }
    
    public enum HVACTemplate_Zone_PTHP_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    public enum HVACTemplate_Zone_PTHP_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    public enum HVACTemplate_Zone_PTHP_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum HVACTemplate_Zone_PTHP_CapacityControlMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("SingleZoneVAV")]
        SingleZoneVAV = 2,
    }
    
    [Description("Water to Air Heat Pump to be used with HVACTemplate:Plant:MixedWaterLoop")]
    [JsonObject("HVACTemplate:Zone:WaterToAirHeatPump")]
    public class HVACTemplate_Zone_WaterToAirHeatPump : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("Supply air flow rate during cooling operation This field may be set to \"autosize\"" +
    ". If a value is entered, it will be multiplied by the Supply Air Sizing Factor a" +
    "nd by zone multipliers.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public string CoolingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Supply air flow rate during heating operation This field may be set to \"autosize\"" +
    ". If a value is entered, it will be multiplied by the Supply Air Sizing Factor a" +
    "nd by zone multipliers.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description(@"Supply air flow rate when no cooling or heating is needed Only used when heat pump fan operating mode is continuous. This air flow rate is used when no heating or cooling is required. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used. A value entered in this field will *not* be multiplied by the sizing factor or by zone multipliers. It is best to autosize or leave blank when using zone multipliers.")]
[JsonProperty("no_load_supply_air_flow_rate")]
public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_cooling_sizing_factor")]
public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

[Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_WaterToAirHeatPump_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_OutdoorAirMethod), "Empty");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If blank, always on")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
    "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
    "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
    "e used.")]
[JsonProperty("supply_fan_operating_mode_schedule_name")]
public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

[JsonProperty("supply_fan_placement")]
public HVACTemplate_Zone_WaterToAirHeatPump_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_SupplyFanPlacement), "DrawThrough");
        

[JsonProperty("supply_fan_total_efficiency")]
public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_delta_pressure")]
public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("75", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_efficiency")]
public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_Zone_WaterToAirHeatPump_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_CoolingCoilType), "Empty");
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("cooling_coil_gross_rated_total_capacity")]
public string CoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
    " and total capacities do not include effect of supply fan heat")]
[JsonProperty("cooling_coil_gross_rated_sensible_heat_ratio")]
public string CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electric power input")]
[JsonProperty("cooling_coil_gross_rated_cop")]
public System.Nullable<float> CoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3.5", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_pump_heating_coil_type")]
public HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpHeatingCoilType HeatPumpHeatingCoilType { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpHeatingCoilType), "Empty");
        

[Description("Capacity excluding supply air fan heat")]
[JsonProperty("heat_pump_heating_coil_gross_rated_capacity")]
public string HeatPumpHeatingCoilGrossRatedCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Heat Pump Heating Coil Rated Capacity divided by power input to the compressor an" +
    "d outdoor fan, does not include supply air fan heat or supply air fan electric p" +
    "ower input")]
[JsonProperty("heat_pump_heating_coil_gross_rated_cop")]
public System.Nullable<float> HeatPumpHeatingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("4.2", CultureInfo.InvariantCulture);
        

[Description("If blank, always on")]
[JsonProperty("supplemental_heating_coil_availability_schedule_name")]
public string SupplementalHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("supplemental_heating_coil_capacity")]
public string SupplementalHeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

[Description("The maximum on-off cycling rate for the compressor Suggested value is 2.5 for a t" +
    "ypical heat pump")]
[JsonProperty("maximum_cycling_rate")]
public System.Nullable<float> MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("2.5", CultureInfo.InvariantCulture);
        

[Description("Time constant for the cooling coil\'s capacity to reach steady state after startup" +
    " Suggested value is 60 for a typical heat pump")]
[JsonProperty("heat_pump_time_constant")]
public System.Nullable<float> HeatPumpTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[Description("The fraction of on-cycle power use to adjust the part load fraction based on the " +
    "off-cycle power consumption due to crankcase heaters, controls, fans, and etc. S" +
    "uggested value is 0.01 for a typical heat pump")]
[JsonProperty("fraction_of_on_cycle_power_use")]
public System.Nullable<float> FractionOfOnCyclePowerUse { get; set; } = (System.Nullable<float>)Single.Parse("0.01", CultureInfo.InvariantCulture);
        

[Description("Programmed time delay for heat pump fan to shut off after compressor cycle off. O" +
    "nly required when fan operating mode is cycling Enter 0 when fan operating mode " +
    "is continuous")]
[JsonProperty("heat_pump_fan_delay_time")]
public System.Nullable<float> HeatPumpFanDelayTime { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
    "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
    "f no DOAS serves this zone.")]
[JsonProperty("dedicated_outdoor_air_system_name")]
public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

[JsonProperty("supplemental_heating_coil_type")]
public HVACTemplate_Zone_WaterToAirHeatPump_SupplementalHeatingCoilType SupplementalHeatingCoilType { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_SupplementalHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_SupplementalHeatingCoilType), "Electric");
        

[Description("SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperat" +
    "ure TemperatureDifference = use the value from Zone Cooling Design Supply Air Te" +
    "mperature Difference")]
[JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_WaterToAirHeatPump_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_cooling_design_supply_air_temperature")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("14", CultureInfo.InvariantCulture);
        

[Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
[JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

[Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperat" +
    "ure TemperatureDifference = use the value from Zone Heating Design Supply Air Te" +
    "mperature Difference")]
[JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_WaterToAirHeatPump_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_heating_design_supply_air_temperature")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
[JsonProperty("zone_heating_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description(@"used only when the heat pump coils are of the type WaterToAirHeatPump:EquationFit Constant results in 100% water flow regardless of compressor PLR Cycling results in water flow that matches compressor PLR ConstantOnDemand results in 100% water flow whenever the coil is on, but is 0% whenever the coil has no load")]
[JsonProperty("heat_pump_coil_water_flow_mode")]
public HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode HeatPumpCoilWaterFlowMode { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode), "Cycling");
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

[JsonProperty("baseboard_heating_type")]
public HVACTemplate_Zone_WaterToAirHeatPump_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_BaseboardHeatingType), "None");
        

[Description("If blank, always on")]
[JsonProperty("baseboard_heating_availability_schedule_name")]
public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_capacity")]
public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
    }
    
    public enum HVACTemplate_Zone_WaterToAirHeatPump_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
    
    public enum HVACTemplate_Zone_WaterToAirHeatPump_SupplyFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_Zone_WaterToAirHeatPump_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:EquationFit")]
        CoilCoolingWaterToAirHeatPumpEquationFit = 1,
    }
    
    public enum HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpHeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coil:Heating:WaterToAirHeatPump:EquationFit")]
        CoilHeatingWaterToAirHeatPumpEquationFit = 1,
    }
    
    public enum HVACTemplate_Zone_WaterToAirHeatPump_SupplementalHeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
    }
    
    public enum HVACTemplate_Zone_WaterToAirHeatPump_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    public enum HVACTemplate_Zone_WaterToAirHeatPump_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    public enum HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Constant")]
        Constant = 1,
        
        [JsonProperty("ConstantOnDemand")]
        ConstantOnDemand = 2,
        
        [JsonProperty("Cycling")]
        Cycling = 3,
    }
    
    public enum HVACTemplate_Zone_WaterToAirHeatPump_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    [Description("Zone terminal unit with variable refrigerant flow (VRF) DX cooling and heating co" +
        "ils (air-to-air or water-to-air heat pump). The VRF terminal units are served by" +
        " an HVACTemplate:System:VRF system.")]
    [JsonObject("HVACTemplate:Zone:VRF")]
    public class HVACTemplate_Zone_VRF : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Name of a HVACTemplate:System:VRF object serving this zone")]
[JsonProperty("template_vrf_system_name")]
public string TemplateVrfSystemName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_cooling_sizing_factor")]
public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

[Description(@"If this terminal unit's heating coil is autosized, the heating capacity is sized to be equal to the cooling capacity multiplied by this sizing ratio. This input applies to the terminal unit heating coil and overrides the sizing ratio entered in the HVACTemplate:System:VRF object.")]
[JsonProperty("rated_total_heating_capacity_sizing_ratio")]
public System.Nullable<float> RatedTotalHeatingCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
    " by the Supply Air Sizing Factor and by zone multipliers.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public string CoolingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("This flow rate is used when the terminal is not cooling and the previous mode was" +
    " cooling. This field may be set to \"autosize\". If a value is entered, it will be" +
    " multiplied by the Supply Air Sizing Factor and by zone multipliers.")]
[JsonProperty("no_cooling_supply_air_flow_rate")]
public string NoCoolingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
    " by the Supply Air Sizing Factor and by zone multipliers.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("This flow rate is used when the terminal is not heating and the previous mode was" +
    " heating. This field may be set to \"autosize\". If a value is entered, it will be" +
    " multiplied by the Supply Air Sizing Factor and by zone multipliers.")]
[JsonProperty("no_heating_supply_air_flow_rate")]
public string NoHeatingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("If this field is set to autosize it will be sized based on the outdoor air inputs" +
    " below, unless a dedicated outdoor air system is specified for this zone and the" +
    "n it will be set to zero.")]
[JsonProperty("cooling_outdoor_air_flow_rate")]
public string CoolingOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("If this field is set to autosize it will be sized based on the outdoor air inputs" +
    " below, unless a dedicated outdoor air system is specified for this zone and the" +
    "n it will be set to zero.")]
[JsonProperty("heating_outdoor_air_flow_rate")]
public string HeatingOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("If this field is set to autosize it will be sized based on the outdoor air inputs" +
    " below, unless a dedicated outdoor air system is specified for this zone and the" +
    "n it will be set to zero.")]
[JsonProperty("no_load_outdoor_air_flow_rate")]
public string NoLoadOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_VRF_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_VRF_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_VRF_OutdoorAirMethod), "Empty");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

[Description("If blank, always on")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
    "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
    "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
    "e used.")]
[JsonProperty("supply_fan_operating_mode_schedule_name")]
public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

[Description("Select fan placement as either blow through or draw through.")]
[JsonProperty("supply_air_fan_placement")]
public HVACTemplate_Zone_VRF_SupplyAirFanPlacement SupplyAirFanPlacement { get; set; } = (HVACTemplate_Zone_VRF_SupplyAirFanPlacement)Enum.Parse(typeof(HVACTemplate_Zone_VRF_SupplyAirFanPlacement), "BlowThrough");
        

[JsonProperty("supply_fan_total_efficiency")]
public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_delta_pressure")]
public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("75", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_efficiency")]
public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_Zone_VRF_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_Zone_VRF_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_VRF_CoolingCoilType), "VariableRefrigerantFlowDX");
        

[Description("If blank, always on")]
[JsonProperty("cooling_coil_availability_schedule_name")]
public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat Ratin" +
    "g point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and a" +
    "ir entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("cooling_coil_gross_rated_total_capacity")]
public string CoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
    " and total capacities do not include effect of supply fan heat")]
[JsonProperty("cooling_coil_gross_rated_sensible_heat_ratio")]
public string CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

[JsonProperty("heat_pump_heating_coil_type")]
public HVACTemplate_Zone_VRF_HeatPumpHeatingCoilType HeatPumpHeatingCoilType { get; set; } = (HVACTemplate_Zone_VRF_HeatPumpHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_VRF_HeatPumpHeatingCoilType), "VariableRefrigerantFlowDX");
        

[Description("If blank, always on")]
[JsonProperty("heat_pump_heating_coil_availability_schedule_name")]
public string HeatPumpHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Capacity excluding supply air fan heat Rating point outdoor dry-bulb temp 8.33 C," +
    " outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21" +
    ".11 C, coil entering wet-bulb 15.55 C")]
[JsonProperty("heat_pump_heating_coil_gross_rated_capacity")]
public string HeatPumpHeatingCoilGrossRatedCapacity { get; set; } = (System.String)"Autosize";
        

[JsonProperty("zone_terminal_unit_on_parasitic_electric_energy_use")]
public System.Nullable<float> ZoneTerminalUnitOnParasiticElectricEnergyUse { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("zone_terminal_unit_off_parasitic_electric_energy_use")]
public System.Nullable<float> ZoneTerminalUnitOffParasiticElectricEnergyUse { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
    "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
    "f no DOAS serves this zone.")]
[JsonProperty("dedicated_outdoor_air_system_name")]
public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

[Description("SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperat" +
    "ure TemperatureDifference = use the value from Zone Cooling Design Supply Air Te" +
    "mperature Difference")]
[JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_VRF_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VRF_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VRF_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_cooling_design_supply_air_temperature")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("14", CultureInfo.InvariantCulture);
        

[Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
[JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

[Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperat" +
    "ure TemperatureDifference = use the value from Zone Heating Design Supply Air Te" +
    "mperature Difference")]
[JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_VRF_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VRF_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VRF_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_heating_design_supply_air_temperature")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
[JsonProperty("zone_heating_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[JsonProperty("baseboard_heating_type")]
public HVACTemplate_Zone_VRF_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_VRF_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_VRF_BaseboardHeatingType), "None");
        

[Description("If blank, always on")]
[JsonProperty("baseboard_heating_availability_schedule_name")]
public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_capacity")]
public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
    }
    
    public enum HVACTemplate_Zone_VRF_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
    
    public enum HVACTemplate_Zone_VRF_SupplyAirFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_Zone_VRF_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("VariableRefrigerantFlowDX")]
        VariableRefrigerantFlowDX = 2,
    }
    
    public enum HVACTemplate_Zone_VRF_HeatPumpHeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("VariableRefrigerantFlowDX")]
        VariableRefrigerantFlowDX = 2,
    }
    
    public enum HVACTemplate_Zone_VRF_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    public enum HVACTemplate_Zone_VRF_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    public enum HVACTemplate_Zone_VRF_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    [Description("Zone terminal unit, constant volume, no controls.")]
    [JsonObject("HVACTemplate:Zone:Unitary")]
    public class HVACTemplate_Zone_Unitary : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Enter the name of an HVACTemplate:System:Unitary, HVACTemplate:System:UnitaryHeat" +
    "Pump:AirTtoAir, or HVACTemplate:System:UnitarySystem object serving this zone.")]
[JsonProperty("template_unitary_system_name")]
public string TemplateUnitarySystemName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
    " by the Supply Air Sizing Factor and by zone multipliers.")]
[JsonProperty("supply_air_maximum_flow_rate")]
public string SupplyAirMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_cooling_sizing_factor")]
public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

[Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_Unitary_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_Unitary_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_Unitary_OutdoorAirMethod), "Empty");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Plenum zone name. Supply plenum runs through only this zone. Blank if none.")]
[JsonProperty("supply_plenum_name")]
public string SupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Return plenum runs through only this zone. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[JsonProperty("baseboard_heating_type")]
public HVACTemplate_Zone_Unitary_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_Unitary_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_Unitary_BaseboardHeatingType), "None");
        

[Description("If blank, always on")]
[JsonProperty("baseboard_heating_availability_schedule_name")]
public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_capacity")]
public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

[Description(@"SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperature TemperatureDifference = use the value from Zone Cooling Design Supply Air Temperature Difference SystemSupplyAirTemperature = use the value from HVACTemplate:System:Unitary or HVACTemplate:System:UnitaryHeatPump:AirToAir Cooling Design Supply Air Temperature")]
[JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_Unitary_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_Unitary_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_Unitary_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SystemSupplyAirTemperature");
        

[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_cooling_design_supply_air_temperature")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
[JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

[Description(@"SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperature TemperatureDifference = use the value from Zone Heating Design Supply Air Temperature Difference SystemSupplyAirTemperature = use the value from HVACTemplate:System:Unitary or HVACTemplate:System:UnitaryHeatPump:AirToAir Heating Design Supply Air Temperature")]
[JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_Unitary_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_Unitary_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_Unitary_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SystemSupplyAirTemperature");
        

[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_heating_design_supply_air_temperature")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
[JsonProperty("zone_heating_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
    }
    
    public enum HVACTemplate_Zone_Unitary_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
    
    public enum HVACTemplate_Zone_Unitary_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum HVACTemplate_Zone_Unitary_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("SystemSupplyAirTemperature")]
        SystemSupplyAirTemperature = 2,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 3,
    }
    
    public enum HVACTemplate_Zone_Unitary_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("SystemSupplyAirTemperature")]
        SystemSupplyAirTemperature = 2,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 3,
    }
    
    [Description("Zone terminal unit, variable volume, reheat optional. For heating, this unit acti" +
        "vates reheat coil first, then increases airflow (if reverse action specified).")]
    [JsonObject("HVACTemplate:Zone:VAV")]
    public class HVACTemplate_Zone_VAV : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Name of a HVACTemplate:System:VAV or HVACTemplate:System:PackagedVAV object servi" +
    "ng this zone")]
[JsonProperty("template_vav_system_name")]
public string TemplateVavSystemName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
    " by the Supply Air Sizing Factor and by zone multipliers.")]
[JsonProperty("supply_air_maximum_flow_rate")]
public string SupplyAirMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_cooling_sizing_factor")]
public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

[Description("Constant = Constant Minimum Air Flow Fraction (a fraction of Maximum Air Flow Rat" +
    "e) FixedFlowRate = Fixed Minimum Air Flow Rate (a fixed minimum air volume flow " +
    "rate) Scheduled = Scheduled Minimum Air Flow Fraction (a fraction of Maximum Air" +
    " Flow")]
[JsonProperty("zone_minimum_air_flow_input_method")]
public HVACTemplate_Zone_VAV_ZoneMinimumAirFlowInputMethod ZoneMinimumAirFlowInputMethod { get; set; } = (HVACTemplate_Zone_VAV_ZoneMinimumAirFlowInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_ZoneMinimumAirFlowInputMethod), "Constant");
        

[Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Constant If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional. If a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the following field are entered, the larger result is used.")]
[JsonProperty("constant_minimum_air_flow_fraction")]
public System.Nullable<float> ConstantMinimumAirFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description(@"This field is used if the field Zone Minimum Air Flow Input Method is FixedFlowRate. If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional. If a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the previous field are entered, the larger result is used.")]
[JsonProperty("fixed_minimum_air_flow_rate")]
public System.Nullable<float> FixedMinimumAirFlowRate { get; set; } = null;
        

[Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Scheduled Schedule values are fractions, 0.0 to 1.0. If the field Constant Minimum Air Flow Fraction is blank, then the average of the minimum and maximum schedule values is used for sizing normal-action reheat coils.")]
[JsonProperty("minimum_air_flow_fraction_schedule_name")]
public string MinimumAirFlowFractionScheduleName { get; set; } = "";
        

[Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_VAV_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_VAV_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_OutdoorAirMethod), "Empty");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("reheat_coil_type")]
public HVACTemplate_Zone_VAV_ReheatCoilType ReheatCoilType { get; set; } = (HVACTemplate_Zone_VAV_ReheatCoilType)Enum.Parse(typeof(HVACTemplate_Zone_VAV_ReheatCoilType), "None");
        

[Description("If blank, always on")]
[JsonProperty("reheat_coil_availability_schedule_name")]
public string ReheatCoilAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("damper_heating_action")]
public HVACTemplate_Zone_VAV_DamperHeatingAction DamperHeatingAction { get; set; } = (HVACTemplate_Zone_VAV_DamperHeatingAction)Enum.Parse(typeof(HVACTemplate_Zone_VAV_DamperHeatingAction), "Reverse");
        

[Description(@"Used only when Reheat Coil Object Type = Coil:Heating:Water and Damper Heating Action = Reverse When autocalculating, the maximum flow per zone is set to 0.002032 m3/s-m2 (0.4 cfm/sqft) This optional field limits the maximum flow allowed in reheat mode. If this field and the following field are left blank, the maximum flow will not be limited. At no time will the maximum flow rate calculated here exceed the value of Maximum Air Flow Rate.")]
[JsonProperty("maximum_flow_per_zone_floor_area_during_reheat")]
public string MaximumFlowPerZoneFloorAreaDuringReheat { get; set; } = "";
        

[Description(@"Used only when Reheat Coil Object Type = Coil:Heating:Water and Damper Heating Action = Reverse When autocalculating, the maximum flow fraction is set to the ratio of 0.002032 m3/s-m2 (0.4 cfm/sqft) multiplied by the zone floor area and the Maximum Air Flow Rate. This optional field limits the maximum flow allowed in reheat mode. If this field and the previous field are left blank, the maximum flow will not be limited. At no time will the maximum flow rate calculated here exceed the value of Maximum Air Flow Rate.")]
[JsonProperty("maximum_flow_fraction_during_reheat")]
public string MaximumFlowFractionDuringReheat { get; set; } = "";
        

[Description("Specifies the maximum allowable supply air temperature leaving the reheat coil. I" +
    "f left blank, there is no limit and no default. If unknown, 35C (95F) is recomme" +
    "nded.")]
[JsonProperty("maximum_reheat_air_temperature")]
public System.Nullable<float> MaximumReheatAirTemperature { get; set; } = null;
        

[Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will increase flow as needed to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on the current number of occupants in the zone. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate. If this field is blank, then the terminal unit will not be controlled for outdoor air flow. Note that this field is used only for specifying the design outdoor air flow rate used for control. The field Design Specification Outdoor Air Object Name for Sizing (see below) is used to specify the design outdoor air flow rate.")]
[JsonProperty("design_specification_outdoor_air_object_name_for_control")]
public string DesignSpecificationOutdoorAirObjectNameForControl { get; set; } = "";
        

[Description("Plenum zone name. Supply plenum runs through only this zone. Blank if none.")]
[JsonProperty("supply_plenum_name")]
public string SupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Return plenum runs through only this zone. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[JsonProperty("baseboard_heating_type")]
public HVACTemplate_Zone_VAV_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_VAV_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_VAV_BaseboardHeatingType), "None");
        

[Description("If blank, always on")]
[JsonProperty("baseboard_heating_availability_schedule_name")]
public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_capacity")]
public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

[Description(@"SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperature TemperatureDifference = use the value from Zone Cooling Design Supply Air Temperature Difference SystemSupplyAirTemperature = use the value from HVACTemplate:System:VAV Cooling Coil Design Setpoint")]
[JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_VAV_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VAV_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SystemSupplyAirTemperature");
        

[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_cooling_design_supply_air_temperature")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
[JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

[Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperat" +
    "ure TemperatureDifference = use the value from Zone Heating Design Supply Air Te" +
    "mperature Difference")]
[JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_VAV_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VAV_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_heating_design_supply_air_temperature")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
[JsonProperty("zone_heating_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description(@"This field is used only when Outdoor Air Method=DetailedSpecification. Note that this field is used only for specifying the design outdoor air flow rate used for sizing. The field Design Specification Outdoor Air Object Name for Control (see above) is used to actively control the VAV terminal air flow rate.")]
[JsonProperty("design_specification_outdoor_air_object_name_for_sizing")]
public string DesignSpecificationOutdoorAirObjectNameForSizing { get; set; } = "";
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
    }
    
    public enum HVACTemplate_Zone_VAV_ZoneMinimumAirFlowInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Constant")]
        Constant = 1,
        
        [JsonProperty("FixedFlowRate")]
        FixedFlowRate = 2,
        
        [JsonProperty("Scheduled")]
        Scheduled = 3,
    }
    
    public enum HVACTemplate_Zone_VAV_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
    
    public enum HVACTemplate_Zone_VAV_ReheatCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_Zone_VAV_DamperHeatingAction
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Normal")]
        Normal = 1,
        
        [JsonProperty("Reverse")]
        Reverse = 2,
    }
    
    public enum HVACTemplate_Zone_VAV_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum HVACTemplate_Zone_VAV_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("SystemSupplyAirTemperature")]
        SystemSupplyAirTemperature = 2,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 3,
    }
    
    public enum HVACTemplate_Zone_VAV_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    [Description("Zone terminal unit, fan powered variable volume, reheat optional. Referenced sche" +
        "dules must be defined elsewhere in the idf.")]
    [JsonObject("HVACTemplate:Zone:VAV:FanPowered")]
    public class HVACTemplate_Zone_VAV_FanPowered : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone Name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:System:VAV or HVACTemplate:System:PackagedVAV ob" +
    "ject serving this zone.")]
[JsonProperty("template_vav_system_name")]
public string TemplateVavSystemName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
    " by the Supply Air Sizing Factor and by zone multipliers.")]
[JsonProperty("primary_supply_air_maximum_flow_rate")]
public string PrimarySupplyAirMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_cooling_sizing_factor")]
public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

[JsonProperty("primary_supply_air_minimum_flow_fraction")]
public string PrimarySupplyAirMinimumFlowFraction { get; set; } = (System.String)"Autosize";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
    " by the Supply Air Sizing Factor and by zone multipliers.")]
[JsonProperty("secondary_supply_air_maximum_flow_rate")]
public string SecondarySupplyAirMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("flow_type")]
public HVACTemplate_Zone_VAV_FanPowered_FlowType FlowType { get; set; } = (HVACTemplate_Zone_VAV_FanPowered_FlowType)Enum.Parse(typeof(HVACTemplate_Zone_VAV_FanPowered_FlowType), "Parallel");
        

[Description("The fraction of the primary air flow at which fan turns on Applicable only to Par" +
    "allel Flow Type")]
[JsonProperty("parallel_fan_on_flow_fraction")]
public string ParallelFanOnFlowFraction { get; set; } = (System.String)"Autosize";
        

[Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_VAV_FanPowered_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_VAV_FanPowered_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_FanPowered_OutdoorAirMethod), "Empty");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("reheat_coil_type")]
public HVACTemplate_Zone_VAV_FanPowered_ReheatCoilType ReheatCoilType { get; set; } = (HVACTemplate_Zone_VAV_FanPowered_ReheatCoilType)Enum.Parse(typeof(HVACTemplate_Zone_VAV_FanPowered_ReheatCoilType), "Electric");
        

[Description("If blank, always on")]
[JsonProperty("reheat_coil_availability_schedule_name")]
public string ReheatCoilAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("fan_total_efficiency")]
public System.Nullable<float> FanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("fan_delta_pressure")]
public System.Nullable<float> FanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

[JsonProperty("fan_motor_efficiency")]
public System.Nullable<float> FanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Plenum zone name. Supply plenum runs through only this zone. Blank if none.")]
[JsonProperty("supply_plenum_name")]
public string SupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Return plenum runs through only this zone. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[JsonProperty("baseboard_heating_type")]
public HVACTemplate_Zone_VAV_FanPowered_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_VAV_FanPowered_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_VAV_FanPowered_BaseboardHeatingType), "None");
        

[Description("If blank, always on")]
[JsonProperty("baseboard_heating_availability_schedule_name")]
public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_capacity")]
public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

[Description(@"SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperature TemperatureDifference = use the value from Zone Cooling Design Supply Air Temperature Difference SystemSupplyAirTemperature = use the value from HVACTemplate:System:VAV Cooling Coil Design Setpoint")]
[JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_VAV_FanPowered_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VAV_FanPowered_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_FanPowered_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SystemSupplyAirTemperature");
        

[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_cooling_design_supply_air_temperature")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
[JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

[Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperat" +
    "ure TemperatureDifference = use the value from Zone Heating Design Supply Air Te" +
    "mperature Difference")]
[JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_VAV_FanPowered_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VAV_FanPowered_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_FanPowered_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_heating_design_supply_air_temperature")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
[JsonProperty("zone_heating_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description(@"This is the operating schedule for the zone PIU fan. For a parallel PIU, the fan operates only when the primary air flow is below the Parallel Fan On Flow Fraction and the Zone PIU Fan Schedule is on, or it is activated by an availability manager. For a series PIU, the zone fan operates whenever the Zone PIU Fan Schedule is on, or it is activated by an availability manager. If this field is left blank, the System Availability Schedule for the HVACTemplate:System serving this zone will be used.")]
[JsonProperty("zone_piu_fan_schedule_name")]
public string ZonePiuFanScheduleName { get; set; } = "";
        

[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
    }
    
    public enum HVACTemplate_Zone_VAV_FanPowered_FlowType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Parallel")]
        Parallel = 1,
        
        [JsonProperty("ParallelFromPlenum")]
        ParallelFromPlenum = 2,
        
        [JsonProperty("Series")]
        Series = 3,
        
        [JsonProperty("SeriesFromPlenum")]
        SeriesFromPlenum = 4,
    }
    
    public enum HVACTemplate_Zone_VAV_FanPowered_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
    
    public enum HVACTemplate_Zone_VAV_FanPowered_ReheatCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
    }
    
    public enum HVACTemplate_Zone_VAV_FanPowered_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum HVACTemplate_Zone_VAV_FanPowered_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("SystemSupplyAirTemperature")]
        SystemSupplyAirTemperature = 2,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 3,
    }
    
    public enum HVACTemplate_Zone_VAV_FanPowered_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    [Description("VAV system with VAV for both heating and cooling and optional reheat coil. For he" +
        "ating, this unit increases airflow first, then activates reheat coil.")]
    [JsonObject("HVACTemplate:Zone:VAV:HeatAndCool")]
    public class HVACTemplate_Zone_VAV_HeatAndCool : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Name of a HVACTemplate:System:VAV or HVACTemplate:System:PackagedVAV object servi" +
    "ng this zone")]
[JsonProperty("template_vav_system_name")]
public string TemplateVavSystemName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
    " by the Supply Air Sizing Factor and by zone multipliers.")]
[JsonProperty("supply_air_maximum_flow_rate")]
public string SupplyAirMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_cooling_sizing_factor")]
public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

[Description(@"This field is used if the field Zone Minimum Air Flow Input Method is Constant If the field Zone Minimum Air Flow Input Method is Scheduled, then this field is optional. If a value is entered, then it is used for sizing normal-action reheat coils. If both this field and the following field are entered, the larger result is used.")]
[JsonProperty("constant_minimum_air_flow_fraction")]
public System.Nullable<float> ConstantMinimumAirFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_VAV_HeatAndCool_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_VAV_HeatAndCool_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_HeatAndCool_OutdoorAirMethod), "Empty");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"This field is used only when Outdoor Air Method=DetailedSpecification. Note that this field is used only for specifying the design outdoor air flow rate used for sizing. The field Design Specification Outdoor Air Object Name for Control (see above) is used to actively control the VAV terminal air flow rate.")]
[JsonProperty("design_specification_outdoor_air_object_name_for_sizing")]
public string DesignSpecificationOutdoorAirObjectNameForSizing { get; set; } = "";
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

[JsonProperty("reheat_coil_type")]
public HVACTemplate_Zone_VAV_HeatAndCool_ReheatCoilType ReheatCoilType { get; set; } = (HVACTemplate_Zone_VAV_HeatAndCool_ReheatCoilType)Enum.Parse(typeof(HVACTemplate_Zone_VAV_HeatAndCool_ReheatCoilType), "None");
        

[Description("If blank, always on")]
[JsonProperty("reheat_coil_availability_schedule_name")]
public string ReheatCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Specifies the maximum allowable supply air temperature leaving the reheat coil. I" +
    "f left blank, there is no limit and no default. If unknown, 35C (95F) is recomme" +
    "nded.")]
[JsonProperty("maximum_reheat_air_temperature")]
public System.Nullable<float> MaximumReheatAirTemperature { get; set; } = null;
        

[Description("Plenum zone name. Supply plenum runs through only this zone. Blank if none.")]
[JsonProperty("supply_plenum_name")]
public string SupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Return plenum runs through only this zone. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[JsonProperty("baseboard_heating_type")]
public HVACTemplate_Zone_VAV_HeatAndCool_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_VAV_HeatAndCool_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_VAV_HeatAndCool_BaseboardHeatingType), "None");
        

[Description("If blank, always on")]
[JsonProperty("baseboard_heating_availability_schedule_name")]
public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_capacity")]
public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

[Description(@"SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperature TemperatureDifference = use the value from Zone Cooling Design Supply Air Temperature Difference SystemSupplyAirTemperature = use the value from HVACTemplate:System:VAV Cooling Coil Design Setpoint")]
[JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_VAV_HeatAndCool_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VAV_HeatAndCool_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_HeatAndCool_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SystemSupplyAirTemperature");
        

[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_cooling_design_supply_air_temperature")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
[JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

[Description(@"SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperature SystemSupplyAirTemperature = use the value from HVACTemplate:System:VAV Heating Coil Design Setpoint TemperatureDifference = use the value from Zone Heating Design Supply Air Temperature Difference")]
[JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_VAV_HeatAndCool_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VAV_HeatAndCool_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VAV_HeatAndCool_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_heating_design_supply_air_temperature")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
[JsonProperty("zone_heating_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
    }
    
    public enum HVACTemplate_Zone_VAV_HeatAndCool_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
    
    public enum HVACTemplate_Zone_VAV_HeatAndCool_ReheatCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_Zone_VAV_HeatAndCool_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum HVACTemplate_Zone_VAV_HeatAndCool_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("SystemSupplyAirTemperature")]
        SystemSupplyAirTemperature = 2,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 3,
    }
    
    public enum HVACTemplate_Zone_VAV_HeatAndCool_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    [Description("Zone terminal unit, constant volume, reheat optional. Referenced schedules must b" +
        "e defined elsewhere in the idf.")]
    [JsonObject("HVACTemplate:Zone:ConstantVolume")]
    public class HVACTemplate_Zone_ConstantVolume : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Name of a HVACTemplate:System:ConstantVolume object serving this zone")]
[JsonProperty("template_constant_volume_system_name")]
public string TemplateConstantVolumeSystemName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
    " by the Supply Air Sizing Factor and by zone multipliers.")]
[JsonProperty("supply_air_maximum_flow_rate")]
public string SupplyAirMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_cooling_sizing_factor")]
public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

[Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_ConstantVolume_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_ConstantVolume_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_ConstantVolume_OutdoorAirMethod), "Empty");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

[JsonProperty("reheat_coil_type")]
public HVACTemplate_Zone_ConstantVolume_ReheatCoilType ReheatCoilType { get; set; } = (HVACTemplate_Zone_ConstantVolume_ReheatCoilType)Enum.Parse(typeof(HVACTemplate_Zone_ConstantVolume_ReheatCoilType), "None");
        

[Description("If blank, always on")]
[JsonProperty("reheat_coil_availability_schedule_name")]
public string ReheatCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Specifies the maximum allowable supply air temperature leaving the reheat coil. I" +
    "f left blank, there is no limit and no default. If unknown, 35C (95F) is recomme" +
    "nded.")]
[JsonProperty("maximum_reheat_air_temperature")]
public System.Nullable<float> MaximumReheatAirTemperature { get; set; } = null;
        

[Description("Plenum zone name. Supply plenum runs through only this zone. Blank if none.")]
[JsonProperty("supply_plenum_name")]
public string SupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Return plenum runs through only this zone. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[JsonProperty("baseboard_heating_type")]
public HVACTemplate_Zone_ConstantVolume_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_ConstantVolume_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_ConstantVolume_BaseboardHeatingType), "None");
        

[Description("If blank, always on")]
[JsonProperty("baseboard_heating_availability_schedule_name")]
public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_capacity")]
public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

[Description(@"SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperature TemperatureDifference = use the value from Zone Cooling Design Supply Air Temperature Difference SystemSupplyAirTemperature = use the value from HVACTemplate:System:VAV Cooling Coil Design Setpoint")]
[JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_ConstantVolume_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_ConstantVolume_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_ConstantVolume_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SystemSupplyAirTemperature");
        

[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_cooling_design_supply_air_temperature")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
[JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

[Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperat" +
    "ure TemperatureDifference = use the value from Zone Heating Design Supply Air Te" +
    "mperature Difference")]
[JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_ConstantVolume_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_ConstantVolume_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_ConstantVolume_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_heating_design_supply_air_temperature")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature")]
[JsonProperty("zone_heating_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
    }
    
    public enum HVACTemplate_Zone_ConstantVolume_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
    
    public enum HVACTemplate_Zone_ConstantVolume_ReheatCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_Zone_ConstantVolume_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum HVACTemplate_Zone_ConstantVolume_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("SystemSupplyAirTemperature")]
        SystemSupplyAirTemperature = 2,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 3,
    }
    
    public enum HVACTemplate_Zone_ConstantVolume_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    [Description("Zone terminal unit, dual-duct, constant or variable volume.")]
    [JsonObject("HVACTemplate:Zone:DualDuct")]
    public class HVACTemplate_Zone_DualDuct : BHoMObject, IEnergyPlusClass
    {
        

[Description("Zone name must match a building zone name")]
[JsonProperty("zone_name")]
public string ZoneName { get; set; } = "";
        

[Description("Name of a HVACTemplate:System:DualDuct object serving this zone")]
[JsonProperty("template_dual_duct_system_name")]
public string TemplateDualDuctSystemName { get; set; } = "";
        

[Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
    "that standard thermostat objects have been defined for this zone.")]
[JsonProperty("template_thermostat_name")]
public string TemplateThermostatName { get; set; } = "";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
    " by the Supply Air Sizing Factor and by zone multipliers.")]
[JsonProperty("supply_air_maximum_flow_rate")]
public string SupplyAirMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[Description("If blank, value from Sizing:Parameters will be used.")]
[JsonProperty("zone_cooling_sizing_factor")]
public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

[Description("This field is the Zone Minimum Air Flow Fraction specified as a fraction of the m" +
    "aximum air flow rate. This field is ignored if the system serving this zone is c" +
    "onstant volume.")]
[JsonProperty("zone_minimum_air_flow_fraction")]
public System.Nullable<float> ZoneMinimumAirFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
[JsonProperty("outdoor_air_method")]
public HVACTemplate_Zone_DualDuct_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_DualDuct_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_DualDuct_OutdoorAirMethod), "Empty");
        

[Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
    "Method is Flow/Person, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_person")]
public System.Nullable<float> OutdoorAirFlowRatePerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
[JsonProperty("outdoor_air_flow_rate_per_zone")]
public System.Nullable<float> OutdoorAirFlowRatePerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"This field is used only when Outdoor Air Method=DetailedSpecification. Note that this field is used only for specifying the design outdoor air flow rate used for sizing. The field Design Specification Outdoor Air Object Name for Control (see above) is used to actively control the VAV terminal air flow rate.")]
[JsonProperty("design_specification_outdoor_air_object_name_for_sizing")]
public string DesignSpecificationOutdoorAirObjectNameForSizing { get; set; } = "";
        

[Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

[Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will increase flow as needed to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on the current number of occupants in the zone. At no time will the supply air flow rate exceed the value for Maximum Air Flow Rate. If this field is blank, then the terminal unit will not be controlled for outdoor air flow. Note that this field is used only for specifying the design outdoor air flow rate used for control. The field Design Specification Outdoor Air Object Name for Sizing (see below) is used to specify the design outdoor air flow rate.")]
[JsonProperty("design_specification_outdoor_air_object_name_for_control")]
public string DesignSpecificationOutdoorAirObjectNameForControl { get; set; } = "";
        

[Description("Plenum zone name. Cold supply plenum that serves only this zone. Blank if none.")]
[JsonProperty("cold_supply_plenum_name")]
public string ColdSupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Hot supply plenum that serves only this zone. Blank if none.")]
[JsonProperty("hot_supply_plenum_name")]
public string HotSupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Return plenum that serves only this zone. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[JsonProperty("baseboard_heating_type")]
public HVACTemplate_Zone_DualDuct_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_DualDuct_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_DualDuct_BaseboardHeatingType), "None");
        

[Description("If blank, always on")]
[JsonProperty("baseboard_heating_availability_schedule_name")]
public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("baseboard_heating_capacity")]
public string BaseboardHeatingCapacity { get; set; } = (System.String)"Autosize";
        

[Description(@"SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperature TemperatureDifference = use the value from Zone Cooling Design Supply Air Temperature Difference SystemSupplyAirTemperature = use the value from HVACTemplate:System:DualDuct Cooling Coil Design Setpoint")]
[JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_DualDuct_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_DualDuct_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_DualDuct_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SystemSupplyAirTemperature");
        

[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_cooling_design_supply_air_temperature")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
[JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("11.11", CultureInfo.InvariantCulture);
        

[Description(@"SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperature TemperatureDifference = use the value from Zone Heating Design Supply Air Temperature Difference SystemSupplyAirTemperature = use the value from HVACTemplate:System:DualDuct Heating Coil Design Setpoint")]
[JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
public HVACTemplate_Zone_DualDuct_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_DualDuct_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_DualDuct_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SystemSupplyAirTemperature");
        

[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_heating_design_supply_air_temperature")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
[JsonProperty("zone_heating_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
    }
    
    public enum HVACTemplate_Zone_DualDuct_OutdoorAirMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedSpecification")]
        DetailedSpecification = 1,
        
        [JsonProperty("Flow/Area")]
        FlowArea = 2,
        
        [JsonProperty("Flow/Person")]
        FlowPerson = 3,
        
        [JsonProperty("Flow/Zone")]
        FlowZone = 4,
        
        [JsonProperty("Maximum")]
        Maximum = 5,
        
        [JsonProperty("Sum")]
        Sum = 6,
    }
    
    public enum HVACTemplate_Zone_DualDuct_BaseboardHeatingType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum HVACTemplate_Zone_DualDuct_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("SystemSupplyAirTemperature")]
        SystemSupplyAirTemperature = 2,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 3,
    }
    
    public enum HVACTemplate_Zone_DualDuct_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [JsonProperty("SystemSupplyAirTemperature")]
        SystemSupplyAirTemperature = 2,
        
        [JsonProperty("TemperatureDifference")]
        TemperatureDifference = 3,
    }
    
    [Description("Variable refrigerant flow (VRF) heat pump condensing unit. Serves one or more VRF" +
        " zone terminal units (HVACTemplate:Zone:VRF).")]
    [JsonObject("HVACTemplate:System:VRF")]
    public class HVACTemplate_System_VRF : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[Description("Enter the total cooling capacity in watts at rated conditions or set to autosize." +
    " Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("gross_rated_total_cooling_capacity")]
public string GrossRatedTotalCoolingCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Enter the coefficient of performance at rated conditions or leave blank to use de" +
    "fault. COP includes compressor and condenser fan electrical energy input COP doe" +
    "s not include supply fan heat or supply fan electric power input")]
[JsonProperty("gross_rated_cooling_cop")]
public System.Nullable<float> GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3.3", CultureInfo.InvariantCulture);
        

[Description("Enter the minimum outdoor temperature allowed for cooling operation. Cooling is d" +
    "isabled below this temperature.")]
[JsonProperty("minimum_outdoor_temperature_in_cooling_mode")]
public System.Nullable<float> MinimumOutdoorTemperatureInCoolingMode { get; set; } = (System.Nullable<float>)Single.Parse("-6", CultureInfo.InvariantCulture);
        

[Description("Enter the maximum outdoor temperature allowed for cooling operation. Cooling is d" +
    "isabled above this temperature.")]
[JsonProperty("maximum_outdoor_temperature_in_cooling_mode")]
public System.Nullable<float> MaximumOutdoorTemperatureInCoolingMode { get; set; } = (System.Nullable<float>)Single.Parse("43", CultureInfo.InvariantCulture);
        

[Description("Enter the heating capacity in watts at rated conditions or set to autosize. Heati" +
    "ng capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("gross_rated_heating_capacity")]
public string GrossRatedHeatingCapacity { get; set; } = (System.String)"Autosize";
        

[Description(@"If the Gross Rated Heating Capacity is autosized, the heating capacity is sized to be equal to the cooling capacity multiplied by this sizing ratio. The zone terminal unit heating coils are also sized using this ratio unless the sizing ratio input in the ZoneHVAC:TerminalUnit:VariableRefrigerantFlow object is entered.")]
[JsonProperty("rated_heating_capacity_sizing_ratio")]
public System.Nullable<float> RatedHeatingCapacitySizingRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("COP includes compressor and condenser fan electrical energy input COP does not in" +
    "clude supply fan heat or supply fan electrical energy input")]
[JsonProperty("gross_rated_heating_cop")]
public System.Nullable<float> GrossRatedHeatingCop { get; set; } = (System.Nullable<float>)Single.Parse("3.4", CultureInfo.InvariantCulture);
        

[Description("Enter the minimum outdoor temperature allowed for heating operation.")]
[JsonProperty("minimum_outdoor_temperature_in_heating_mode")]
public System.Nullable<float> MinimumOutdoorTemperatureInHeatingMode { get; set; } = (System.Nullable<float>)Single.Parse("-20", CultureInfo.InvariantCulture);
        

[Description("Enter the maximum outdoor temperature allowed for heating operation.")]
[JsonProperty("maximum_outdoor_temperature_in_heating_mode")]
public System.Nullable<float> MaximumOutdoorTemperatureInHeatingMode { get; set; } = (System.Nullable<float>)Single.Parse("16", CultureInfo.InvariantCulture);
        

[Description("Enter the minimum heat pump part-load ratio (PLR). When the cooling or heating PL" +
    "R is below this value, the heat pump compressor will cycle to meet the cooling o" +
    "r heating demand.")]
[JsonProperty("minimum_heat_pump_part_load_ratio")]
public System.Nullable<float> MinimumHeatPumpPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.15", CultureInfo.InvariantCulture);
        

[Description("Enter the name of the zone where the master thermostat is located.")]
[JsonProperty("zone_name_for_master_thermostat_location")]
public string ZoneNameForMasterThermostatLocation { get; set; } = "";
        

[Description("Choose a thermostat control logic scheme. If these control types fail to control " +
    "zone temperature within a reasonable limit, consider using multiple VRF systems")]
[JsonProperty("master_thermostat_priority_control_type")]
public HVACTemplate_System_VRF_MasterThermostatPriorityControlType MasterThermostatPriorityControlType { get; set; } = (HVACTemplate_System_VRF_MasterThermostatPriorityControlType)Enum.Parse(typeof(HVACTemplate_System_VRF_MasterThermostatPriorityControlType), "MasterThermostatPriority");
        

[Description("this field is required if Master Thermostat Priority Control Type is Scheduled. S" +
    "chedule values of 0 denote cooling, 1 for heating, and all other values disable " +
    "the system.")]
[JsonProperty("thermostat_priority_schedule_name")]
public string ThermostatPriorityScheduleName { get; set; } = "";
        

[Description("This field is reserved for future use. The only valid choice is No.")]
[JsonProperty("heat_pump_waste_heat_recovery")]
public EmptyNoYes HeatPumpWasteHeatRecovery { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Enter the equivalent length of the farthest terminal unit from the condenser")]
[JsonProperty("equivalent_piping_length_used_for_piping_correction_factor_in_cooling_mode")]
public System.Nullable<float> EquivalentPipingLengthUsedForPipingCorrectionFactorInCoolingMode { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("Enter the height difference between the highest and lowest terminal unit")]
[JsonProperty("vertical_height_used_for_piping_correction_factor")]
public System.Nullable<float> VerticalHeightUsedForPipingCorrectionFactor { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("Enter the equivalent length of the farthest terminal unit from the condenser")]
[JsonProperty("equivalent_piping_length_used_for_piping_correction_factor_in_heating_mode")]
public System.Nullable<float> EquivalentPipingLengthUsedForPipingCorrectionFactorInHeatingMode { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("Enter the value of the resistive heater located in the compressor(s). This heater" +
    " is used to warm the refrigerant and oil when the compressor is off.")]
[JsonProperty("crankcase_heater_power_per_compressor")]
public System.Nullable<float> CrankcaseHeaterPowerPerCompressor { get; set; } = (System.Nullable<float>)Single.Parse("33", CultureInfo.InvariantCulture);
        

[Description("Enter the total number of compressor. This input is used only for crankcase heate" +
    "r calculations.")]
[JsonProperty("number_of_compressors")]
public System.Nullable<float> NumberOfCompressors { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("Enter the ratio of the first stage compressor to total compressor capacity. All o" +
    "ther compressors are assumed to be equally sized. This inputs is used only for c" +
    "rankcase heater calculations.")]
[JsonProperty("ratio_of_compressor_size_to_total_compressor_capacity")]
public System.Nullable<float> RatioOfCompressorSizeToTotalCompressorCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("Enter the maximum outdoor temperature above which the crankcase heaters are disab" +
    "led.")]
[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeater { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[Description("Select a defrost strategy. Reverse cycle reverses the operating mode from heating" +
    " to cooling to melt frost formation on the condenser coil. The resistive strateg" +
    "y uses a resistive heater to melt the frost.")]
[JsonProperty("defrost_strategy")]
public HVACTemplate_System_VRF_DefrostStrategy DefrostStrategy { get; set; } = (HVACTemplate_System_VRF_DefrostStrategy)Enum.Parse(typeof(HVACTemplate_System_VRF_DefrostStrategy), "Resistive");
        

[Description("Choose a defrost control type. Either use a fixed Timed defrost period or select " +
    "OnDemand to defrost only when necessary.")]
[JsonProperty("defrost_control")]
public HVACTemplate_System_VRF_DefrostControl DefrostControl { get; set; } = (HVACTemplate_System_VRF_DefrostControl)Enum.Parse(typeof(HVACTemplate_System_VRF_DefrostControl), "Timed");
        

[Description("Fraction of time in defrost mode. Only applicable if timed defrost control is spe" +
    "cified.")]
[JsonProperty("defrost_time_period_fraction")]
public System.Nullable<float> DefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

[Description("Enter the size of the resistive defrost heating element. Only applicable if resis" +
    "tive defrost strategy is specified")]
[JsonProperty("resistive_defrost_heater_capacity")]
public string ResistiveDefrostHeaterCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Enter the maximum outdoor temperature above which defrost operation is disabled.")]
[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_defrost_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForDefrostOperation { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[Description("Select either an air cooled or evaporatively cooled condenser.")]
[JsonProperty("condenser_type")]
public HVACTemplate_System_VRF_CondenserType CondenserType { get; set; } = (HVACTemplate_System_VRF_CondenserType)Enum.Parse(typeof(HVACTemplate_System_VRF_CondenserType), "AirCooled");
        

[Description("Only used when Condenser Type = WaterCooled.")]
[JsonProperty("water_condenser_volume_flow_rate")]
public string WaterCondenserVolumeFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Enter the effectiveness of the evaporatively cooled condenser. This field is only" +
    " used when the Condenser Type = EvaporativelyCooled.")]
[JsonProperty("evaporative_condenser_effectiveness")]
public System.Nullable<float> EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Used to calculate evaporative condenser water use. This field is only used when t" +
    "he Condenser Type = EvaporativelyCooled.")]
[JsonProperty("evaporative_condenser_air_flow_rate")]
public string EvaporativeCondenserAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Rated power consumed by the evaporative condenser\'s water pump. This field is onl" +
    "y used when the Condenser Type = EvaporativelyCooled.")]
[JsonProperty("evaporative_condenser_pump_rated_power_consumption")]
public string EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = (System.String)"0";
        

[Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the DX coil is off.")]
[JsonProperty("basin_heater_capacity")]
public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
    "or dry-bulb temperature when the basin heater turns on.")]
[JsonProperty("basin_heater_setpoint_temperature")]
public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
[JsonProperty("basin_heater_operating_schedule_name")]
public string BasinHeaterOperatingScheduleName { get; set; } = "";
        

[JsonProperty("fuel_type")]
public HVACTemplate_System_VRF_FuelType FuelType { get; set; } = (HVACTemplate_System_VRF_FuelType)Enum.Parse(typeof(HVACTemplate_System_VRF_FuelType), "Electricity");
        

[Description("The minimum outdoor temperature below which heat recovery mode will not operate.")]
[JsonProperty("minimum_outdoor_temperature_in_heat_recovery_mode")]
public System.Nullable<float> MinimumOutdoorTemperatureInHeatRecoveryMode { get; set; } = (System.Nullable<float>)Single.Parse("-15", CultureInfo.InvariantCulture);
        

[Description("The maximum outdoor temperature above which heat recovery mode will not operate.")]
[JsonProperty("maximum_outdoor_temperature_in_heat_recovery_mode")]
public System.Nullable<float> MaximumOutdoorTemperatureInHeatRecoveryMode { get; set; } = (System.Nullable<float>)Single.Parse("45", CultureInfo.InvariantCulture);
    }
    
    public enum HVACTemplate_System_VRF_MasterThermostatPriorityControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LoadPriority")]
        LoadPriority = 1,
        
        [JsonProperty("MasterThermostatPriority")]
        MasterThermostatPriority = 2,
        
        [JsonProperty("Scheduled")]
        Scheduled = 3,
        
        [JsonProperty("ThermostatOffsetPriority")]
        ThermostatOffsetPriority = 4,
        
        [JsonProperty("ZonePriority")]
        ZonePriority = 5,
    }
    
    public enum HVACTemplate_System_VRF_DefrostStrategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Resistive")]
        Resistive = 1,
        
        [JsonProperty("ReverseCycle")]
        ReverseCycle = 2,
    }
    
    public enum HVACTemplate_System_VRF_DefrostControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("OnDemand")]
        OnDemand = 1,
        
        [JsonProperty("Timed")]
        Timed = 2,
    }
    
    public enum HVACTemplate_System_VRF_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCooled")]
        AirCooled = 1,
        
        [JsonProperty("EvaporativelyCooled")]
        EvaporativelyCooled = 2,
        
        [JsonProperty("WaterCooled")]
        WaterCooled = 3,
    }
    
    public enum HVACTemplate_System_VRF_FuelType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("Electricity")]
        Electricity = 2,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 3,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 4,
        
        [JsonProperty("Gasoline")]
        Gasoline = 5,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 6,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 7,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 8,
        
        [JsonProperty("Propane")]
        Propane = 9,
    }
    
    [Description("Unitary furnace with air conditioner")]
    [JsonObject("HVACTemplate:System:Unitary")]
    public class HVACTemplate_System_Unitary : BHoMObject, IEnergyPlusClass
    {
        

[Description("If blank, always on; Unitary System always on. Schedule is used in availability m" +
    "anager and fan scheduling. Also see \"Night Cycle Control\" field.")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("control_zone_or_thermostat_location_name")]
public string ControlZoneOrThermostatLocationName { get; set; } = "";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
    "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
    "value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("supply_fan_maximum_flow_rate")]
public string SupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
    "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
    "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
    "e used.")]
[JsonProperty("supply_fan_operating_mode_schedule_name")]
public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

[JsonProperty("supply_fan_total_efficiency")]
public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_delta_pressure")]
public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("600", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_efficiency")]
public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_System_Unitary_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_Unitary_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_Unitary_CoolingCoilType), "SingleSpeedDX");
        

[Description("If blank, always on")]
[JsonProperty("cooling_coil_availability_schedule_name")]
public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Used for sizing.")]
[JsonProperty("cooling_design_supply_air_temperature")]
public System.Nullable<float> CoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("cooling_coil_gross_rated_total_capacity")]
public string CoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Gross SHR")]
[JsonProperty("cooling_coil_gross_rated_sensible_heat_ratio")]
public string CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply air fan heat or supply air fan electric power")]
[JsonProperty("cooling_coil_gross_rated_cop")]
public System.Nullable<float> CoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_type")]
public HVACTemplate_System_Unitary_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_Unitary_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_Unitary_HeatingCoilType), "Electric");
        

[Description("If blank, always on")]
[JsonProperty("heating_coil_availability_schedule_name")]
public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Used for sizing.")]
[JsonProperty("heating_design_supply_air_temperature")]
public System.Nullable<float> HeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_capacity")]
public string HeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

[JsonProperty("gas_heating_coil_efficiency")]
public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_heating_coil_parasitic_electric_load")]
public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_air_flow_rate")]
public string MaximumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("minimum_outdoor_air_flow_rate")]
public string MinimumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Schedule values multiply the minimum outdoor air flow rate If blank, always one")]
[JsonProperty("minimum_outdoor_air_schedule_name")]
public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

[JsonProperty("economizer_type")]
public HVACTemplate_System_Unitary_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_Unitary_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_Unitary_EconomizerType), "NoEconomizer");
        

[JsonProperty("economizer_lockout")]
public HVACTemplate_System_Unitary_EconomizerLockout EconomizerLockout { get; set; } = (HVACTemplate_System_Unitary_EconomizerLockout)Enum.Parse(typeof(HVACTemplate_System_Unitary_EconomizerLockout), "NoLockout");
        

[Description("Outdoor temperature above which economizer is disabled and heat recovery is enabl" +
    "ed (if available). Blank means no limit.")]
[JsonProperty("economizer_upper_temperature_limit")]
public System.Nullable<float> EconomizerUpperTemperatureLimit { get; set; } = null;
        

[Description("Outdoor temperature below which economizer is disabled and heat recovery is enabl" +
    "ed (if available). Blank means no limit.")]
[JsonProperty("economizer_lower_temperature_limit")]
public System.Nullable<float> EconomizerLowerTemperatureLimit { get; set; } = null;
        

[Description("Outdoor enthalpy above which economizer is disabled and heat recovery is enabled " +
    "(if available). Blank means no limit.")]
[JsonProperty("economizer_upper_enthalpy_limit")]
public System.Nullable<float> EconomizerUpperEnthalpyLimit { get; set; } = null;
        

[Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
    "economizer control type. No input or blank input means this limit is not operati" +
    "ve. Limit is applied regardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_dewpoint_temperature")]
public System.Nullable<float> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

[Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
[JsonProperty("supply_plenum_name")]
public string SupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Return plenum serves all zones on this system. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[JsonProperty("supply_fan_placement")]
public HVACTemplate_System_Unitary_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_Unitary_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_Unitary_SupplyFanPlacement), "BlowThrough");
        

[JsonProperty("night_cycle_control")]
public HVACTemplate_System_Unitary_NightCycleControl NightCycleControl { get; set; } = (HVACTemplate_System_Unitary_NightCycleControl)Enum.Parse(typeof(HVACTemplate_System_Unitary_NightCycleControl), "StayOff");
        

[Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
[JsonProperty("night_cycle_control_zone_name")]
public string NightCycleControlZoneName { get; set; } = "";
        

[JsonProperty("heat_recovery_type")]
public HVACTemplate_System_Unitary_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_Unitary_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_Unitary_HeatRecoveryType), "None");
        

[JsonProperty("sensible_heat_recovery_effectiveness")]
public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Heat Recovery Type is Enthalpy.")]
[JsonProperty("latent_heat_recovery_effectiveness")]
public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[Description(@"None = meet sensible cooling load only CoolReheatHeatingCoil = cool beyond the dry-bulb setpoint as required to meet the humidity setpoint, reheat with main heating coil. CoolReheatDesuperheater = cool beyond the dry-bulb setpoint as required to meet the humidity setpoint, reheat with desuperheater coil.")]
[JsonProperty("dehumidification_control_type")]
public HVACTemplate_System_Unitary_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_Unitary_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_Unitary_DehumidificationControlType), "None");
        

[Description("Zone relative humidity setpoint in percent (0 to 100)")]
[JsonProperty("dehumidification_setpoint")]
public System.Nullable<float> DehumidificationSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[JsonProperty("humidifier_type")]
public HVACTemplate_System_Unitary_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_Unitary_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_Unitary_HumidifierType), "None");
        

[Description("If blank, always available")]
[JsonProperty("humidifier_availability_schedule_name")]
public string HumidifierAvailabilityScheduleName { get; set; } = "";
        

[Description("Moisture output rate at full rated power input. The humidifier does not currently" +
    " autosize, so the default is very large to allow for adequate capacity.")]
[JsonProperty("humidifier_rated_capacity")]
public System.Nullable<float> HumidifierRatedCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1E-06", CultureInfo.InvariantCulture);
        

[Description("Electric power input at rated capacity moisture output. Power consumption is prop" +
    "ortional to moisture output with no part-load penalty.")]
[JsonProperty("humidifier_rated_electric_power")]
public string HumidifierRatedElectricPower { get; set; } = (System.String)"Autosize";
        

[Description("Zone name where humidistat is located")]
[JsonProperty("humidifier_control_zone_name")]
public string HumidifierControlZoneName { get; set; } = "";
        

[Description("Zone relative humidity setpoint in percent (0 to 100)")]
[JsonProperty("humidifier_setpoint")]
public System.Nullable<float> HumidifierSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("Specifies if the system has a return fan.")]
[JsonProperty("return_fan")]
public EmptyNoYes ReturnFan { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("return_fan_total_efficiency")]
public System.Nullable<float> ReturnFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_delta_pressure")]
public System.Nullable<float> ReturnFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_efficiency")]
public System.Nullable<float> ReturnFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> ReturnFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    public enum HVACTemplate_System_Unitary_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("SingleSpeedDX")]
        SingleSpeedDX = 2,
    }
    
    public enum HVACTemplate_System_Unitary_HeatingCoilType
    {
        
        [JsonProperty("Electric")]
        Electric = 0,
        
        [JsonProperty("Gas")]
        Gas = 1,
        
        [JsonProperty("HotWater")]
        HotWater = 2,
    }
    
    public enum HVACTemplate_System_Unitary_EconomizerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [JsonProperty("DifferentialDryBulbAndEnthalpy")]
        DifferentialDryBulbAndEnthalpy = 2,
        
        [JsonProperty("DifferentialEnthalpy")]
        DifferentialEnthalpy = 3,
        
        [JsonProperty("ElectronicEnthalpy")]
        ElectronicEnthalpy = 4,
        
        [JsonProperty("FixedDewPointAndDryBulb")]
        FixedDewPointAndDryBulb = 5,
        
        [JsonProperty("FixedDryBulb")]
        FixedDryBulb = 6,
        
        [JsonProperty("FixedEnthalpy")]
        FixedEnthalpy = 7,
        
        [JsonProperty("NoEconomizer")]
        NoEconomizer = 8,
    }
    
    public enum HVACTemplate_System_Unitary_EconomizerLockout
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LockoutWithCompressor")]
        LockoutWithCompressor = 1,
        
        [JsonProperty("LockoutWithHeating")]
        LockoutWithHeating = 2,
        
        [JsonProperty("NoLockout")]
        NoLockout = 3,
    }
    
    public enum HVACTemplate_System_Unitary_SupplyFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_System_Unitary_NightCycleControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CycleOnAny")]
        CycleOnAny = 1,
        
        [JsonProperty("CycleOnControlZone")]
        CycleOnControlZone = 2,
        
        [JsonProperty("StayOff")]
        StayOff = 3,
    }
    
    public enum HVACTemplate_System_Unitary_HeatRecoveryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Sensible")]
        Sensible = 3,
    }
    
    public enum HVACTemplate_System_Unitary_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheatDesuperheater")]
        CoolReheatDesuperheater = 1,
        
        [JsonProperty("CoolReheatHeatingCoil")]
        CoolReheatHeatingCoil = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum HVACTemplate_System_Unitary_HumidifierType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ElectricSteam")]
        ElectricSteam = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    [Description("Unitary furnace with electric air-to-air heat pump")]
    [JsonObject("HVACTemplate:System:UnitaryHeatPump:AirToAir")]
    public class HVACTemplate_System_UnitaryHeatPump_AirToAir : BHoMObject, IEnergyPlusClass
    {
        

[Description("If blank, always on; Unitary System always on. Schedule is used in availability m" +
    "anager and fan scheduling. Also see \"Night Cycle Control\" field.")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("control_zone_or_thermostat_location_name")]
public string ControlZoneOrThermostatLocationName { get; set; } = "";
        

[Description(@"Supply air flow rate during cooling operation This field may be set to ""autosize"". If a value is entered, it will *not* be multiplied by any sizing factor or by zone multipliers. If using zone multipliers a value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public string CoolingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description(@"Supply air flow rate during heating operation This field may be set to ""autosize"". If a value is entered, it will *not* be multiplied by any sizing factor or by zone multipliers. If using zone multipliers a value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description(@"Supply air flow rate when no cooling or heating is needed Only used when heat pump fan operating mode is Continuous. This air flow rate is used when no heating or cooling is required and the DX coil compressor is off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used. This field may be set to ""autosize"". If a value is entered, it will *not* be multiplied by any sizing factor or by zone multipliers. If using zone multipliers a value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("no_load_supply_air_flow_rate")]
public string NoLoadSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
    "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
    "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
    "e used.")]
[JsonProperty("supply_fan_operating_mode_schedule_name")]
public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

[JsonProperty("supply_fan_placement")]
public HVACTemplate_System_UnitaryHeatPump_AirToAir_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_UnitaryHeatPump_AirToAir_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_UnitaryHeatPump_AirToAir_SupplyFanPlacement), "BlowThrough");
        

[JsonProperty("supply_fan_total_efficiency")]
public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_delta_pressure")]
public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("600", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_efficiency")]
public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_System_UnitaryHeatPump_AirToAir_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_UnitaryHeatPump_AirToAir_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_UnitaryHeatPump_AirToAir_CoolingCoilType), "SingleSpeedDX");
        

[Description("If blank, always on")]
[JsonProperty("cooling_coil_availability_schedule_name")]
public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Used for sizing.")]
[JsonProperty("cooling_design_supply_air_temperature")]
public System.Nullable<float> CoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat Ratin" +
    "g point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and a" +
    "ir entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("cooling_coil_gross_rated_total_capacity")]
public string CoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
    " and total capacities do not include effect of supply fan heat")]
[JsonProperty("cooling_coil_gross_rated_sensible_heat_ratio")]
public string CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electric power input")]
[JsonProperty("cooling_coil_gross_rated_cop")]
public System.Nullable<float> CoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_pump_heating_coil_type")]
public HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpHeatingCoilType HeatPumpHeatingCoilType { get; set; } = (HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpHeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpHeatingCoilType), "SingleSpeedDXHeatPump");
        

[Description("If blank, always on")]
[JsonProperty("heat_pump_heating_coil_availability_schedule_name")]
public string HeatPumpHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Used for sizing.")]
[JsonProperty("heating_design_supply_air_temperature")]
public System.Nullable<float> HeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description("Rated heating capacity excluding the effect of supply air fan heat Rating point o" +
    "utdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating c" +
    "oil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
[JsonProperty("heat_pump_heating_coil_gross_rated_capacity")]
public string HeatPumpHeatingCoilGrossRatedCapacity { get; set; } = (System.String)"Autosize";
        

[Description(@"Heat Pump Heating Coil Rated Capacity divided by power input to the compressor and outdoor fan, does not include supply air fan heat or supply air fan electrical energy. Rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
[JsonProperty("heat_pump_heating_coil_rated_cop")]
public System.Nullable<float> HeatPumpHeatingCoilRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("2.75", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_pump_heating_minimum_outdoor_dry_bulb_temperature")]
public System.Nullable<float> HeatPumpHeatingMinimumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_pump_defrost_maximum_outdoor_dry_bulb_temperature")]
public System.Nullable<float> HeatPumpDefrostMaximumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_pump_defrost_strategy")]
public HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpDefrostStrategy HeatPumpDefrostStrategy { get; set; } = (HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpDefrostStrategy)Enum.Parse(typeof(HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpDefrostStrategy), "ReverseCycle");
        

[JsonProperty("heat_pump_defrost_control")]
public HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpDefrostControl HeatPumpDefrostControl { get; set; } = (HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpDefrostControl)Enum.Parse(typeof(HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpDefrostControl), "Timed");
        

[Description("Fraction of time in defrost mode only applicable if Timed defrost control is spec" +
    "ified")]
[JsonProperty("heat_pump_defrost_time_period_fraction")]
public System.Nullable<float> HeatPumpDefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

[JsonProperty("supplemental_heating_coil_type")]
public HVACTemplate_System_UnitaryHeatPump_AirToAir_SupplementalHeatingCoilType SupplementalHeatingCoilType { get; set; } = (HVACTemplate_System_UnitaryHeatPump_AirToAir_SupplementalHeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_UnitaryHeatPump_AirToAir_SupplementalHeatingCoilType), "Electric");
        

[Description("If blank, always on")]
[JsonProperty("supplemental_heating_coil_availability_schedule_name")]
public string SupplementalHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("supplemental_heating_coil_capacity")]
public string SupplementalHeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Supplemental heater will not operate when outdoor temperature exceeds this value." +
    "")]
[JsonProperty("supplemental_heating_coil_maximum_outdoor_dry_bulb_temperature")]
public System.Nullable<float> SupplementalHeatingCoilMaximumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

[Description("Applies only if Supplemental Heating Coil Type is Gas")]
[JsonProperty("supplemental_gas_heating_coil_efficiency")]
public System.Nullable<float> SupplementalGasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[Description("Applies only if Supplemental Heating Coil Type is Gas")]
[JsonProperty("supplemental_gas_heating_coil_parasitic_electric_load")]
public System.Nullable<float> SupplementalGasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_air_flow_rate")]
public string MaximumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("minimum_outdoor_air_flow_rate")]
public string MinimumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Schedule values multiply the minimum outdoor air flow rate If blank, multiplier i" +
    "s always one")]
[JsonProperty("minimum_outdoor_air_schedule_name")]
public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

[JsonProperty("economizer_type")]
public HVACTemplate_System_UnitaryHeatPump_AirToAir_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_UnitaryHeatPump_AirToAir_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_UnitaryHeatPump_AirToAir_EconomizerType), "NoEconomizer");
        

[JsonProperty("economizer_lockout")]
public HVACTemplate_System_UnitaryHeatPump_AirToAir_EconomizerLockout EconomizerLockout { get; set; } = (HVACTemplate_System_UnitaryHeatPump_AirToAir_EconomizerLockout)Enum.Parse(typeof(HVACTemplate_System_UnitaryHeatPump_AirToAir_EconomizerLockout), "NoLockout");
        

[Description("Enter the maximum outdoor dry-bulb temperature limit for FixedDryBulb economizer " +
    "control type. No input or blank input means this limit is not operative. Limit i" +
    "s applied regardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_dry_bulb_temperature")]
public System.Nullable<float> EconomizerMaximumLimitDryBulbTemperature { get; set; } = null;
        

[Description("Enter the maximum outdoor enthalpy limit for FixedEnthalpy economizer control typ" +
    "e. No input or blank input means this limit is not operative Limit is applied re" +
    "gardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_enthalpy")]
public System.Nullable<float> EconomizerMaximumLimitEnthalpy { get; set; } = null;
        

[Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
    "economizer control type. No input or blank input means this limit is not operati" +
    "ve. Limit is applied regardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_dewpoint_temperature")]
public System.Nullable<float> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

[Description("Enter the minimum outdoor dry-bulb temperature limit for economizer control. No i" +
    "nput or blank input means this limit is not operative Limit is applied regardles" +
    "s of economizer control type.")]
[JsonProperty("economizer_minimum_limit_dry_bulb_temperature")]
public System.Nullable<float> EconomizerMinimumLimitDryBulbTemperature { get; set; } = null;
        

[Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
[JsonProperty("supply_plenum_name")]
public string SupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Return plenum serves all zones on this system. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[JsonProperty("night_cycle_control")]
public HVACTemplate_System_UnitaryHeatPump_AirToAir_NightCycleControl NightCycleControl { get; set; } = (HVACTemplate_System_UnitaryHeatPump_AirToAir_NightCycleControl)Enum.Parse(typeof(HVACTemplate_System_UnitaryHeatPump_AirToAir_NightCycleControl), "StayOff");
        

[Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
[JsonProperty("night_cycle_control_zone_name")]
public string NightCycleControlZoneName { get; set; } = "";
        

[JsonProperty("heat_recovery_type")]
public HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatRecoveryType), "None");
        

[JsonProperty("sensible_heat_recovery_effectiveness")]
public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Heat Recovery Type is Enthalpy.")]
[JsonProperty("latent_heat_recovery_effectiveness")]
public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[JsonProperty("humidifier_type")]
public HVACTemplate_System_UnitaryHeatPump_AirToAir_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_UnitaryHeatPump_AirToAir_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_UnitaryHeatPump_AirToAir_HumidifierType), "None");
        

[Description("If blank, always available")]
[JsonProperty("humidifier_availability_schedule_name")]
public string HumidifierAvailabilityScheduleName { get; set; } = "";
        

[Description("Moisture output rate at full rated power input. The humidifier does not currently" +
    " autosize, so the default is very large to allow for adequate capacity.")]
[JsonProperty("humidifier_rated_capacity")]
public System.Nullable<float> HumidifierRatedCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1E-06", CultureInfo.InvariantCulture);
        

[Description("Electric power input at rated capacity moisture output. Power consumption is prop" +
    "ortional to moisture output with no part-load penalty.")]
[JsonProperty("humidifier_rated_electric_power")]
public string HumidifierRatedElectricPower { get; set; } = (System.String)"Autosize";
        

[Description("Zone name where humidistat is located")]
[JsonProperty("humidifier_control_zone_name")]
public string HumidifierControlZoneName { get; set; } = "";
        

[Description("Zone relative humidity setpoint in percent (0 to 100)")]
[JsonProperty("humidifier_setpoint")]
public System.Nullable<float> HumidifierSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("Specifies if the system has a return fan.")]
[JsonProperty("return_fan")]
public EmptyNoYes ReturnFan { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("return_fan_total_efficiency")]
public System.Nullable<float> ReturnFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_delta_pressure")]
public System.Nullable<float> ReturnFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_efficiency")]
public System.Nullable<float> ReturnFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> ReturnFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_SupplyFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SingleSpeedDX")]
        SingleSpeedDX = 1,
    }
    
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpHeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("SingleSpeedDXHeatPump")]
        SingleSpeedDXHeatPump = 1,
    }
    
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpDefrostStrategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Resistive")]
        Resistive = 1,
        
        [JsonProperty("ReverseCycle")]
        ReverseCycle = 2,
    }
    
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatPumpDefrostControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("OnDemand")]
        OnDemand = 1,
        
        [JsonProperty("Timed")]
        Timed = 2,
    }
    
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_SupplementalHeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
    }
    
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_EconomizerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [JsonProperty("DifferentialDryBulbAndEnthalpy")]
        DifferentialDryBulbAndEnthalpy = 2,
        
        [JsonProperty("DifferentialEnthalpy")]
        DifferentialEnthalpy = 3,
        
        [JsonProperty("ElectronicEnthalpy")]
        ElectronicEnthalpy = 4,
        
        [JsonProperty("FixedDewPointAndDryBulb")]
        FixedDewPointAndDryBulb = 5,
        
        [JsonProperty("FixedDryBulb")]
        FixedDryBulb = 6,
        
        [JsonProperty("FixedEnthalpy")]
        FixedEnthalpy = 7,
        
        [JsonProperty("NoEconomizer")]
        NoEconomizer = 8,
    }
    
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_EconomizerLockout
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LockoutWithCompressor")]
        LockoutWithCompressor = 1,
        
        [JsonProperty("LockoutWithHeating")]
        LockoutWithHeating = 2,
        
        [JsonProperty("NoLockout")]
        NoLockout = 3,
    }
    
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_NightCycleControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CycleOnAny")]
        CycleOnAny = 1,
        
        [JsonProperty("CycleOnControlZone")]
        CycleOnControlZone = 2,
        
        [JsonProperty("StayOff")]
        StayOff = 3,
    }
    
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_HeatRecoveryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Sensible")]
        Sensible = 3,
    }
    
    public enum HVACTemplate_System_UnitaryHeatPump_AirToAir_HumidifierType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ElectricSteam")]
        ElectricSteam = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    [Description("Unitary HVAC system with optional cooling and heating. Supports DX and chilled wa" +
        "ter, cooling, gas, electric, and hot water heating, air-to-air and water-to-air " +
        "heat pumps.")]
    [JsonObject("HVACTemplate:System:UnitarySystem")]
    public class HVACTemplate_System_UnitarySystem : BHoMObject, IEnergyPlusClass
    {
        

[Description("If blank, always available. Also see Supply Fan Operating Mode Schedule Name fiel" +
    "d.")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[Description("Load control requires a Controlling Zone name. SetPoint control requires set poin" +
    "ts at coil outlet nodes. The user must add appropriate SetpointManager objects t" +
    "o the idf file.")]
[JsonProperty("control_type")]
public HVACTemplate_System_UnitarySystem_ControlType ControlType { get; set; } = (HVACTemplate_System_UnitarySystem_ControlType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_ControlType), "Load");
        

[Description("This field is required if Control Type is Load.")]
[JsonProperty("control_zone_or_thermostat_location_name")]
public string ControlZoneOrThermostatLocationName { get; set; } = "";
        

[Description(@"Supply air flow rate during cooling operation This field may be set to ""autosize"". If a value is entered, it will *not* be multiplied by any sizing factor or by zone multipliers. If using zone multipliers a value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public string CoolingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description(@"Supply air flow rate during heating operation This field may be set to ""autosize"". If a value is entered, it will *not* be multiplied by any sizing factor or by zone multipliers. If using zone multipliers a value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description(@"Supply air flow rate when no cooling or heating is needed Only used when heat pump fan operating mode is Continuous. This air flow rate is used when no heating or cooling is required and the DX coil compressor is off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used. This field may be set to ""autosize"". If a value is entered, it will *not* be multiplied by any sizing factor or by zone multipliers. If using zone multipliers a value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("no_load_supply_air_flow_rate")]
public string NoLoadSupplyAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
    "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
    "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
    "e used.")]
[JsonProperty("supply_fan_operating_mode_schedule_name")]
public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

[JsonProperty("supply_fan_placement")]
public HVACTemplate_System_UnitarySystem_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_UnitarySystem_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_SupplyFanPlacement), "BlowThrough");
        

[JsonProperty("supply_fan_total_efficiency")]
public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_delta_pressure")]
public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("600", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_efficiency")]
public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_System_UnitarySystem_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_UnitarySystem_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_CoolingCoilType), "SingleSpeedDX");
        

[Description("Used only for Cooling Coil Type = MultiSpeedDX.")]
[JsonProperty("number_of_speeds_for_cooling")]
public System.Nullable<float> NumberOfSpeedsForCooling { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("If blank, always on")]
[JsonProperty("cooling_coil_availability_schedule_name")]
public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Used for sizing.")]
[JsonProperty("cooling_design_supply_air_temperature")]
public System.Nullable<float> CoolingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat Ratin" +
    "g point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and a" +
    "ir entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("dx_cooling_coil_gross_rated_total_capacity")]
public string DxCoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
    " and total capacities do not include effect of supply fan heat")]
[JsonProperty("dx_cooling_coil_gross_rated_sensible_heat_ratio")]
public string DxCoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electric power input")]
[JsonProperty("dx_cooling_coil_gross_rated_cop")]
public System.Nullable<float> DxCoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_type")]
public HVACTemplate_System_UnitarySystem_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_UnitarySystem_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatingCoilType), "Gas");
        

[Description("Used only for Heating Coil Type = MultiSpeedDXHeatPumpAirSource), MultiStageElect" +
    "ric, or MultiStageGas.")]
[JsonProperty("number_of_speeds_or_stages_for_heating")]
public System.Nullable<float> NumberOfSpeedsOrStagesForHeating { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("If blank, always on")]
[JsonProperty("heating_coil_availability_schedule_name")]
public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Used for sizing.")]
[JsonProperty("heating_design_supply_air_temperature")]
public System.Nullable<float> HeatingDesignSupplyAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description("Rated heating capacity excluding the effect of supply air fan heat Rating point o" +
    "utdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating c" +
    "oil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
[JsonProperty("heating_coil_gross_rated_capacity")]
public string HeatingCoilGrossRatedCapacity { get; set; } = (System.String)"Autosize";
        

[JsonProperty("gas_heating_coil_efficiency")]
public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_heating_coil_parasitic_electric_load")]
public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Heating Coil Rated Capacity divided by power input to the compressor and outdoor fan, does not include supply air fan heat or supply air fan electrical energy. Rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C Applies only to DX coils")]
[JsonProperty("heat_pump_heating_coil_gross_rated_cop")]
public System.Nullable<float> HeatPumpHeatingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("2.75", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_pump_heating_minimum_outdoor_dry_bulb_temperature")]
public System.Nullable<float> HeatPumpHeatingMinimumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_pump_defrost_maximum_outdoor_dry_bulb_temperature")]
public System.Nullable<float> HeatPumpDefrostMaximumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_pump_defrost_strategy")]
public HVACTemplate_System_UnitarySystem_HeatPumpDefrostStrategy HeatPumpDefrostStrategy { get; set; } = (HVACTemplate_System_UnitarySystem_HeatPumpDefrostStrategy)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatPumpDefrostStrategy), "ReverseCycle");
        

[JsonProperty("heat_pump_defrost_control")]
public HVACTemplate_System_UnitarySystem_HeatPumpDefrostControl HeatPumpDefrostControl { get; set; } = (HVACTemplate_System_UnitarySystem_HeatPumpDefrostControl)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatPumpDefrostControl), "Timed");
        

[Description("Fraction of time in defrost mode only applicable if Timed defrost control is spec" +
    "ified")]
[JsonProperty("heat_pump_defrost_time_period_fraction")]
public System.Nullable<float> HeatPumpDefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

[JsonProperty("supplemental_heating_or_reheat_coil_type")]
public HVACTemplate_System_UnitarySystem_SupplementalHeatingOrReheatCoilType SupplementalHeatingOrReheatCoilType { get; set; } = (HVACTemplate_System_UnitarySystem_SupplementalHeatingOrReheatCoilType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_SupplementalHeatingOrReheatCoilType), "None");
        

[Description("If blank, always on")]
[JsonProperty("supplemental_heating_or_reheat_coil_availability_schedule_name")]
public string SupplementalHeatingOrReheatCoilAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("supplemental_heating_or_reheat_coil_capacity")]
public string SupplementalHeatingOrReheatCoilCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Supplemental heater will not operate when outdoor temperature exceeds this value." +
    "")]
[JsonProperty("supplemental_heating_or_reheat_coil_maximum_outdoor_dry_bulb_temperature")]
public System.Nullable<float> SupplementalHeatingOrReheatCoilMaximumOutdoorDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("21", CultureInfo.InvariantCulture);
        

[Description("Applies only if Supplemental Heating Coil Type is Gas")]
[JsonProperty("supplemental_gas_heating_or_reheat_coil_efficiency")]
public System.Nullable<float> SupplementalGasHeatingOrReheatCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[Description("Applies only if Supplemental Heating Coil Type is Gas")]
[JsonProperty("supplemental_gas_heating_or_reheat_coil_parasitic_electric_load")]
public System.Nullable<float> SupplementalGasHeatingOrReheatCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_air_flow_rate")]
public string MaximumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("minimum_outdoor_air_flow_rate")]
public string MinimumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Schedule values multiply the minimum outdoor air flow rate If blank, multiplier i" +
    "s always one")]
[JsonProperty("minimum_outdoor_air_schedule_name")]
public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

[JsonProperty("economizer_type")]
public HVACTemplate_System_UnitarySystem_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_UnitarySystem_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_EconomizerType), "NoEconomizer");
        

[JsonProperty("economizer_lockout")]
public HVACTemplate_System_UnitarySystem_EconomizerLockout EconomizerLockout { get; set; } = (HVACTemplate_System_UnitarySystem_EconomizerLockout)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_EconomizerLockout), "NoLockout");
        

[Description("Enter the maximum outdoor dry-bulb temperature limit for FixedDryBulb economizer " +
    "control type. No input or blank input means this limit is not operative. Limit i" +
    "s applied regardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_dry_bulb_temperature")]
public System.Nullable<float> EconomizerMaximumLimitDryBulbTemperature { get; set; } = null;
        

[Description("Enter the maximum outdoor enthalpy limit for FixedEnthalpy economizer control typ" +
    "e. No input or blank input means this limit is not operative Limit is applied re" +
    "gardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_enthalpy")]
public System.Nullable<float> EconomizerMaximumLimitEnthalpy { get; set; } = null;
        

[Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
    "economizer control type. No input or blank input means this limit is not operati" +
    "ve. Limit is applied regardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_dewpoint_temperature")]
public System.Nullable<float> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

[Description("Enter the minimum outdoor dry-bulb temperature limit for economizer control. No i" +
    "nput or blank input means this limit is not operative Limit is applied regardles" +
    "s of economizer control type.")]
[JsonProperty("economizer_minimum_limit_dry_bulb_temperature")]
public System.Nullable<float> EconomizerMinimumLimitDryBulbTemperature { get; set; } = null;
        

[Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
[JsonProperty("supply_plenum_name")]
public string SupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Return plenum serves all zones on this system. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[JsonProperty("heat_recovery_type")]
public HVACTemplate_System_UnitarySystem_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_UnitarySystem_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatRecoveryType), "None");
        

[JsonProperty("sensible_heat_recovery_effectiveness")]
public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("Applicable only if Heat Recovery Type is Enthalpy.")]
[JsonProperty("latent_heat_recovery_effectiveness")]
public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_recovery_heat_exchanger_type")]
public HVACTemplate_System_UnitarySystem_HeatRecoveryHeatExchangerType HeatRecoveryHeatExchangerType { get; set; } = (HVACTemplate_System_UnitarySystem_HeatRecoveryHeatExchangerType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatRecoveryHeatExchangerType), "Plate");
        

[JsonProperty("heat_recovery_frost_control_type")]
public HVACTemplate_System_UnitarySystem_HeatRecoveryFrostControlType HeatRecoveryFrostControlType { get; set; } = (HVACTemplate_System_UnitarySystem_HeatRecoveryFrostControlType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatRecoveryFrostControlType), "None");
        

[Description(@"None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint, reheat with reheat coil If no reheat coil specified, cold supply temps may occur. Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only for Cooling Coil Type = TwoStageHumidityControlDX or HeatExchangerAssistedDX")]
[JsonProperty("dehumidification_control_type")]
public HVACTemplate_System_UnitarySystem_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_UnitarySystem_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_DehumidificationControlType), "None");
        

[Description("Zone relative humidity setpoint in percent (0 to 100) Ignored if Dehumidification" +
    " Relative Humidity Setpoint Schedule specified below")]
[JsonProperty("dehumidification_relative_humidity_setpoint")]
public System.Nullable<float> DehumidificationRelativeHumiditySetpoint { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[Description("Leave blank to use constant setpoint specified in Dehumidification Relative Humid" +
    "ity Setpoint above. Schedule values must be in percent relative humidity (0 to 1" +
    "00).")]
[JsonProperty("dehumidification_relative_humidity_setpoint_schedule_name")]
public string DehumidificationRelativeHumiditySetpointScheduleName { get; set; } = "";
        

[JsonProperty("humidifier_type")]
public HVACTemplate_System_UnitarySystem_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_UnitarySystem_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HumidifierType), "None");
        

[Description("If blank, always available")]
[JsonProperty("humidifier_availability_schedule_name")]
public string HumidifierAvailabilityScheduleName { get; set; } = "";
        

[Description("Moisture output rate at full rated power input. The humidifier does not currently" +
    " autosize, so the default is very large to allow for adequate capacity.")]
[JsonProperty("humidifier_rated_capacity")]
public System.Nullable<float> HumidifierRatedCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1E-06", CultureInfo.InvariantCulture);
        

[Description("Electric power input at rated capacity moisture output. Power consumption is prop" +
    "ortional to moisture output with no part-load penalty.")]
[JsonProperty("humidifier_rated_electric_power")]
public string HumidifierRatedElectricPower { get; set; } = (System.String)"Autosize";
        

[Description("Zone name where humidistat is located")]
[JsonProperty("humidifier_control_zone_name")]
public string HumidifierControlZoneName { get; set; } = "";
        

[Description("Zone relative humidity setpoint in percent (0 to 100). Ignored if Humidifier Rela" +
    "tive Humidity Setpoint Schedule specified below")]
[JsonProperty("humidifier_relative_humidity_setpoint")]
public System.Nullable<float> HumidifierRelativeHumiditySetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("Leave blank to use constant setpoint specified in Humidifier Relative Humidity Se" +
    "tpoint above. Schedule values must be in percent relative humidity (0 to 100).")]
[JsonProperty("humidifier_relative_humidity_setpoint_schedule_name")]
public string HumidifierRelativeHumiditySetpointScheduleName { get; set; } = "";
        

[Description("Select whether autosized system supply flow rate is the sum of Coincident or NonC" +
    "oincident zone air flow rates.")]
[JsonProperty("sizing_option")]
public HVACTemplate_System_UnitarySystem_SizingOption SizingOption { get; set; } = (HVACTemplate_System_UnitarySystem_SizingOption)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_SizingOption), "NonCoincident");
        

[Description("Specifies if the system has a return fan.")]
[JsonProperty("return_fan")]
public EmptyNoYes ReturnFan { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("return_fan_total_efficiency")]
public System.Nullable<float> ReturnFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_delta_pressure")]
public System.Nullable<float> ReturnFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("300", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_efficiency")]
public System.Nullable<float> ReturnFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> ReturnFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    public enum HVACTemplate_System_UnitarySystem_ControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Load")]
        Load = 1,
        
        [JsonProperty("SetPoint")]
        SetPoint = 2,
    }
    
    public enum HVACTemplate_System_UnitarySystem_SupplyFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_System_UnitarySystem_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 1,
        
        [JsonProperty("ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
        
        [JsonProperty("HeatExchangerAssistedChilledWater")]
        HeatExchangerAssistedChilledWater = 3,
        
        [JsonProperty("HeatExchangerAssistedDX")]
        HeatExchangerAssistedDX = 4,
        
        [JsonProperty("MultiSpeedDX")]
        MultiSpeedDX = 5,
        
        [JsonProperty("None")]
        None = 6,
        
        [JsonProperty("SingleSpeedDX")]
        SingleSpeedDX = 7,
        
        [JsonProperty("SingleSpeedDXWaterCooled")]
        SingleSpeedDXWaterCooled = 8,
        
        [JsonProperty("TwoSpeedDX")]
        TwoSpeedDX = 9,
        
        [JsonProperty("TwoStageDX")]
        TwoStageDX = 10,
        
        [JsonProperty("TwoStageHumidityControlDX")]
        TwoStageHumidityControlDX = 11,
    }
    
    public enum HVACTemplate_System_UnitarySystem_HeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("MultiSpeedDXHeatPumpAirSource")]
        MultiSpeedDXHeatPumpAirSource = 4,
        
        [JsonProperty("MultiStageElectric")]
        MultiStageElectric = 5,
        
        [JsonProperty("MultiStageGas")]
        MultiStageGas = 6,
        
        [JsonProperty("None")]
        None = 7,
        
        [JsonProperty("SingleSpeedDXHeatPumpAirSource")]
        SingleSpeedDXHeatPumpAirSource = 8,
        
        [JsonProperty("SingleSpeedDXHeatPumpWaterSource")]
        SingleSpeedDXHeatPumpWaterSource = 9,
    }
    
    public enum HVACTemplate_System_UnitarySystem_HeatPumpDefrostStrategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Resistive")]
        Resistive = 1,
        
        [JsonProperty("ReverseCycle")]
        ReverseCycle = 2,
    }
    
    public enum HVACTemplate_System_UnitarySystem_HeatPumpDefrostControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("OnDemand")]
        OnDemand = 1,
        
        [JsonProperty("Timed")]
        Timed = 2,
    }
    
    public enum HVACTemplate_System_UnitarySystem_SupplementalHeatingOrReheatCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DesuperHeater")]
        DesuperHeater = 1,
        
        [JsonProperty("Electric")]
        Electric = 2,
        
        [JsonProperty("Gas")]
        Gas = 3,
        
        [JsonProperty("HotWater")]
        HotWater = 4,
        
        [JsonProperty("None")]
        None = 5,
    }
    
    public enum HVACTemplate_System_UnitarySystem_EconomizerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [JsonProperty("DifferentialDryBulbAndEnthalpy")]
        DifferentialDryBulbAndEnthalpy = 2,
        
        [JsonProperty("DifferentialEnthalpy")]
        DifferentialEnthalpy = 3,
        
        [JsonProperty("ElectronicEnthalpy")]
        ElectronicEnthalpy = 4,
        
        [JsonProperty("FixedDewPointAndDryBulb")]
        FixedDewPointAndDryBulb = 5,
        
        [JsonProperty("FixedDryBulb")]
        FixedDryBulb = 6,
        
        [JsonProperty("FixedEnthalpy")]
        FixedEnthalpy = 7,
        
        [JsonProperty("NoEconomizer")]
        NoEconomizer = 8,
    }
    
    public enum HVACTemplate_System_UnitarySystem_EconomizerLockout
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LockoutWithCompressor")]
        LockoutWithCompressor = 1,
        
        [JsonProperty("LockoutWithHeating")]
        LockoutWithHeating = 2,
        
        [JsonProperty("NoLockout")]
        NoLockout = 3,
    }
    
    public enum HVACTemplate_System_UnitarySystem_HeatRecoveryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Sensible")]
        Sensible = 3,
    }
    
    public enum HVACTemplate_System_UnitarySystem_HeatRecoveryHeatExchangerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Plate")]
        Plate = 1,
        
        [JsonProperty("Rotary")]
        Rotary = 2,
    }
    
    public enum HVACTemplate_System_UnitarySystem_HeatRecoveryFrostControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ExhaustAirRecirculation")]
        ExhaustAirRecirculation = 1,
        
        [JsonProperty("ExhaustOnly")]
        ExhaustOnly = 2,
        
        [JsonProperty("MinimumExhaustTemperature")]
        MinimumExhaustTemperature = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_UnitarySystem_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("Multimode")]
        Multimode = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum HVACTemplate_System_UnitarySystem_HumidifierType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ElectricSteam")]
        ElectricSteam = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    public enum HVACTemplate_System_UnitarySystem_SizingOption
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coincident")]
        Coincident = 1,
        
        [JsonProperty("NonCoincident")]
        NonCoincident = 2,
    }
    
    [Description("Variable Air Volume (VAV) air loop with optional heating coil and optional prehea" +
        "t.")]
    [JsonObject("HVACTemplate:System:VAV")]
    public class HVACTemplate_System_VAV : BHoMObject, IEnergyPlusClass
    {
        

[Description("If blank, always on; VAV System always on. Schedule is used in availability manag" +
    "er and fan scheduling. Also see \"Night Cycle Control\" field.")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
    "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
    "value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("supply_fan_maximum_flow_rate")]
public string SupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("This field is only used to set a minimum part load on the VAV fan power curve. Au" +
    "tosize or zero is recommended.")]
[JsonProperty("supply_fan_minimum_flow_rate")]
public string SupplyFanMinimumFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("supply_fan_total_efficiency")]
public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_delta_pressure")]
public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_efficiency")]
public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_System_VAV_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_VAV_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_VAV_CoolingCoilType), "ChilledWater");
        

[Description("If blank, always on")]
[JsonProperty("cooling_coil_availability_schedule_name")]
public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("cooling_coil_setpoint_schedule_name")]
public string CoolingCoilSetpointScheduleName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Nam" +
    "e is specified.")]
[JsonProperty("cooling_coil_design_setpoint")]
public System.Nullable<float> CoolingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_type")]
public HVACTemplate_System_VAV_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_VAV_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_VAV_HeatingCoilType), "None");
        

[Description("If blank, always on")]
[JsonProperty("heating_coil_availability_schedule_name")]
public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("heating_coil_setpoint_schedule_name")]
public string HeatingCoilSetpointScheduleName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Nam" +
    "e is specified.")]
[JsonProperty("heating_coil_design_setpoint")]
public System.Nullable<float> HeatingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_heating_coil_efficiency")]
public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_heating_coil_parasitic_electric_load")]
public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("preheat_coil_type")]
public HVACTemplate_System_VAV_PreheatCoilType PreheatCoilType { get; set; } = (HVACTemplate_System_VAV_PreheatCoilType)Enum.Parse(typeof(HVACTemplate_System_VAV_PreheatCoilType), "None");
        

[Description("If blank, always on")]
[JsonProperty("preheat_coil_availability_schedule_name")]
public string PreheatCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("preheat_coil_setpoint_schedule_name")]
public string PreheatCoilSetpointScheduleName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Preheat Coil Setpoint Schedule Nam" +
    "e specified.")]
[JsonProperty("preheat_coil_design_setpoint")]
public System.Nullable<float> PreheatCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("7.2", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_preheat_coil_efficiency")]
public System.Nullable<float> GasPreheatCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_preheat_coil_parasitic_electric_load")]
public System.Nullable<float> GasPreheatCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_air_flow_rate")]
public string MaximumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("minimum_outdoor_air_flow_rate")]
public string MinimumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("minimum_outdoor_air_control_type")]
public HVACTemplate_System_VAV_MinimumOutdoorAirControlType MinimumOutdoorAirControlType { get; set; } = (HVACTemplate_System_VAV_MinimumOutdoorAirControlType)Enum.Parse(typeof(HVACTemplate_System_VAV_MinimumOutdoorAirControlType), "ProportionalMinimum");
        

[Description("Schedule values multiply the Minimum Outdoor Air Flow Rate If blank, multiplier i" +
    "s always one")]
[JsonProperty("minimum_outdoor_air_schedule_name")]
public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

[JsonProperty("economizer_type")]
public HVACTemplate_System_VAV_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_VAV_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_VAV_EconomizerType), "NoEconomizer");
        

[JsonProperty("economizer_lockout")]
public HVACTemplate_System_VAV_EconomizerLockout EconomizerLockout { get; set; } = (HVACTemplate_System_VAV_EconomizerLockout)Enum.Parse(typeof(HVACTemplate_System_VAV_EconomizerLockout), "NoLockout");
        

[Description("Outdoor temperature above which economizer is disabled and heat recovery is enabl" +
    "ed (if available). Blank means no limit.")]
[JsonProperty("economizer_upper_temperature_limit")]
public System.Nullable<float> EconomizerUpperTemperatureLimit { get; set; } = null;
        

[Description("Outdoor temperature below which economizer is disabled and heat recovery is enabl" +
    "ed (if available). Blank means no limit.")]
[JsonProperty("economizer_lower_temperature_limit")]
public System.Nullable<float> EconomizerLowerTemperatureLimit { get; set; } = null;
        

[Description("Outdoor enthalpy above which economizer is disabled and heat recovery is enabled " +
    "(if available). Blank means no limit.")]
[JsonProperty("economizer_upper_enthalpy_limit")]
public System.Nullable<float> EconomizerUpperEnthalpyLimit { get; set; } = null;
        

[Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
    "economizer control type. No input or blank input means this limit is not operati" +
    "ve. Limit is applied regardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_dewpoint_temperature")]
public System.Nullable<float> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

[Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
[JsonProperty("supply_plenum_name")]
public string SupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[JsonProperty("supply_fan_placement")]
public HVACTemplate_System_VAV_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_VAV_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_VAV_SupplyFanPlacement), "DrawThrough");
        

[Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
    "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
    " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
    "lues table.")]
[JsonProperty("supply_fan_part_load_power_coefficients")]
public HVACTemplate_System_VAV_SupplyFanPartLoadPowerCoefficients SupplyFanPartLoadPowerCoefficients { get; set; } = (HVACTemplate_System_VAV_SupplyFanPartLoadPowerCoefficients)Enum.Parse(typeof(HVACTemplate_System_VAV_SupplyFanPartLoadPowerCoefficients), "InletVaneDampers");
        

[JsonProperty("night_cycle_control")]
public HVACTemplate_System_VAV_NightCycleControl NightCycleControl { get; set; } = (HVACTemplate_System_VAV_NightCycleControl)Enum.Parse(typeof(HVACTemplate_System_VAV_NightCycleControl), "StayOff");
        

[Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
[JsonProperty("night_cycle_control_zone_name")]
public string NightCycleControlZoneName { get; set; } = "";
        

[JsonProperty("heat_recovery_type")]
public HVACTemplate_System_VAV_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_VAV_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_VAV_HeatRecoveryType), "None");
        

[JsonProperty("sensible_heat_recovery_effectiveness")]
public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("latent_heat_recovery_effectiveness")]
public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[Description(@"Overrides Cooling Coil Setpoint Schedule Name None = no reset, control to Cooling Coil Design Setpoint Temperature or Schedule Warmest = reset as warm as possible yet meet all zone cooling loads at max supply air flow rate OutdoorAirTemperatureReset = reset based on outdoor air temperature (18.0C at 15.6C ODB, to the Cooling Design Setpoint at 26.7C) WarmestTemperatureFirst = reset as warm as possible yet meet all zone cooling loads at min supply air flow rate")]
[JsonProperty("cooling_coil_setpoint_reset_type")]
public HVACTemplate_System_VAV_CoolingCoilSetpointResetType CoolingCoilSetpointResetType { get; set; } = (HVACTemplate_System_VAV_CoolingCoilSetpointResetType)Enum.Parse(typeof(HVACTemplate_System_VAV_CoolingCoilSetpointResetType), "None");
        

[Description(@"Overrides Heating Coil Setpoint Schedule Name None = no reset, control to Heating Coil Design Setpoint Temperature or Schedule OutdoorAirTemperatureReset = reset based on outdoor air temperature (Heating Design Setpoint at -6.7C ODB to Heating Design Setpoint minus 5.2C at 10C ODB) min supply air flow rate")]
[JsonProperty("heating_coil_setpoint_reset_type")]
public HVACTemplate_System_VAV_HeatingCoilSetpointResetType HeatingCoilSetpointResetType { get; set; } = (HVACTemplate_System_VAV_HeatingCoilSetpointResetType)Enum.Parse(typeof(HVACTemplate_System_VAV_HeatingCoilSetpointResetType), "None");
        

[Description("None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint as " +
    "required to meet the humidity setpoint.")]
[JsonProperty("dehumidification_control_type")]
public HVACTemplate_System_VAV_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_VAV_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_VAV_DehumidificationControlType), "None");
        

[Description("Zone name where humidistat is located")]
[JsonProperty("dehumidification_control_zone_name")]
public string DehumidificationControlZoneName { get; set; } = "";
        

[Description("Zone relative humidity setpoint in percent (0 to 100)")]
[JsonProperty("dehumidification_setpoint")]
public System.Nullable<float> DehumidificationSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[JsonProperty("humidifier_type")]
public HVACTemplate_System_VAV_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_VAV_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_VAV_HumidifierType), "None");
        

[Description("If blank, always available")]
[JsonProperty("humidifier_availability_schedule_name")]
public string HumidifierAvailabilityScheduleName { get; set; } = "";
        

[Description("Moisture output rate at full rated power input. The humidifier does not currently" +
    " autosize, so the default is very large to allow for adequate capacity.")]
[JsonProperty("humidifier_rated_capacity")]
public System.Nullable<float> HumidifierRatedCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1E-06", CultureInfo.InvariantCulture);
        

[Description("Electric power input at rated capacity moisture output. Power consumption is prop" +
    "ortional to moisture output with no part-load penalty.")]
[JsonProperty("humidifier_rated_electric_power")]
public string HumidifierRatedElectricPower { get; set; } = (System.String)"Autosize";
        

[Description("Zone name where humidistat is located")]
[JsonProperty("humidifier_control_zone_name")]
public string HumidifierControlZoneName { get; set; } = "";
        

[Description("Zone relative humidity setpoint in percent (0 to 100)")]
[JsonProperty("humidifier_setpoint")]
public System.Nullable<float> HumidifierSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("Select whether autosized system supply flow rate is the sum of Coincident or NonC" +
    "oincident zone air flow rates.")]
[JsonProperty("sizing_option")]
public HVACTemplate_System_VAV_SizingOption SizingOption { get; set; } = (HVACTemplate_System_VAV_SizingOption)Enum.Parse(typeof(HVACTemplate_System_VAV_SizingOption), "NonCoincident");
        

[Description("Specifies if the system has a return fan.")]
[JsonProperty("return_fan")]
public EmptyNoYes ReturnFan { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("return_fan_total_efficiency")]
public System.Nullable<float> ReturnFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_delta_pressure")]
public System.Nullable<float> ReturnFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_efficiency")]
public System.Nullable<float> ReturnFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> ReturnFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
    "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
    " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
    "lues table.")]
[JsonProperty("return_fan_part_load_power_coefficients")]
public HVACTemplate_System_VAV_ReturnFanPartLoadPowerCoefficients ReturnFanPartLoadPowerCoefficients { get; set; } = (HVACTemplate_System_VAV_ReturnFanPartLoadPowerCoefficients)Enum.Parse(typeof(HVACTemplate_System_VAV_ReturnFanPartLoadPowerCoefficients), "InletVaneDampers");
    }
    
    public enum HVACTemplate_System_VAV_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 1,
        
        [JsonProperty("ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
    }
    
    public enum HVACTemplate_System_VAV_HeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_VAV_PreheatCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_VAV_MinimumOutdoorAirControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedMinimum")]
        FixedMinimum = 1,
        
        [JsonProperty("ProportionalMinimum")]
        ProportionalMinimum = 2,
    }
    
    public enum HVACTemplate_System_VAV_EconomizerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [JsonProperty("DifferentialDryBulbAndEnthalpy")]
        DifferentialDryBulbAndEnthalpy = 2,
        
        [JsonProperty("DifferentialEnthalpy")]
        DifferentialEnthalpy = 3,
        
        [JsonProperty("ElectronicEnthalpy")]
        ElectronicEnthalpy = 4,
        
        [JsonProperty("FixedDewPointAndDryBulb")]
        FixedDewPointAndDryBulb = 5,
        
        [JsonProperty("FixedDryBulb")]
        FixedDryBulb = 6,
        
        [JsonProperty("FixedEnthalpy")]
        FixedEnthalpy = 7,
        
        [JsonProperty("NoEconomizer")]
        NoEconomizer = 8,
    }
    
    public enum HVACTemplate_System_VAV_EconomizerLockout
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NoLockout")]
        NoLockout = 1,
    }
    
    public enum HVACTemplate_System_VAV_SupplyFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_System_VAV_SupplyFanPartLoadPowerCoefficients
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAE90.1-2004AppendixG")]
        ASHRAE9012004AppendixG = 1,
        
        [JsonProperty("InletVaneDampers")]
        InletVaneDampers = 2,
        
        [JsonProperty("OutletDampers")]
        OutletDampers = 3,
        
        [JsonProperty("VariableSpeedMotor")]
        VariableSpeedMotor = 4,
        
        [JsonProperty("VariableSpeedMotorPressureReset")]
        VariableSpeedMotorPressureReset = 5,
    }
    
    public enum HVACTemplate_System_VAV_NightCycleControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CycleOnAny")]
        CycleOnAny = 1,
        
        [JsonProperty("CycleOnAnyZoneFansOnly")]
        CycleOnAnyZoneFansOnly = 2,
        
        [JsonProperty("CycleOnControlZone")]
        CycleOnControlZone = 3,
        
        [JsonProperty("StayOff")]
        StayOff = 4,
    }
    
    public enum HVACTemplate_System_VAV_HeatRecoveryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Sensible")]
        Sensible = 3,
    }
    
    public enum HVACTemplate_System_VAV_CoolingCoilSetpointResetType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
        
        [JsonProperty("Warmest")]
        Warmest = 3,
        
        [JsonProperty("WarmestTemperatureFirst")]
        WarmestTemperatureFirst = 4,
    }
    
    public enum HVACTemplate_System_VAV_HeatingCoilSetpointResetType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
    }
    
    public enum HVACTemplate_System_VAV_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    public enum HVACTemplate_System_VAV_HumidifierType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ElectricSteam")]
        ElectricSteam = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    public enum HVACTemplate_System_VAV_SizingOption
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coincident")]
        Coincident = 1,
        
        [JsonProperty("NonCoincident")]
        NonCoincident = 2,
    }
    
    public enum HVACTemplate_System_VAV_ReturnFanPartLoadPowerCoefficients
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAE90.1-2004AppendixG")]
        ASHRAE9012004AppendixG = 1,
        
        [JsonProperty("InletVaneDampers")]
        InletVaneDampers = 2,
        
        [JsonProperty("OutletDampers")]
        OutletDampers = 3,
        
        [JsonProperty("VariableSpeedMotor")]
        VariableSpeedMotor = 4,
        
        [JsonProperty("VariableSpeedMotorPressureReset")]
        VariableSpeedMotorPressureReset = 5,
    }
    
    [Description("Packaged Variable Air Volume (PVAV) air loop with optional heating coil and optio" +
        "nal preheat.")]
    [JsonObject("HVACTemplate:System:PackagedVAV")]
    public class HVACTemplate_System_PackagedVAV : BHoMObject, IEnergyPlusClass
    {
        

[Description("If blank, always on; PVAV System always on. Schedule is used in availability mana" +
    "ger and fan scheduling. Also see \"Night Cycle Control\" field.")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
    "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
    "value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("supply_fan_maximum_flow_rate")]
public string SupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("This field is only used to set a minimum part load on the VAV fan power curve. Au" +
    "tosize or zero is recommended.")]
[JsonProperty("supply_fan_minimum_flow_rate")]
public string SupplyFanMinimumFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("supply_fan_placement")]
public HVACTemplate_System_PackagedVAV_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_PackagedVAV_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_SupplyFanPlacement), "DrawThrough");
        

[JsonProperty("supply_fan_total_efficiency")]
public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_delta_pressure")]
public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_efficiency")]
public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_System_PackagedVAV_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_PackagedVAV_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_CoolingCoilType), "TwoSpeedDX");
        

[Description("If blank, always on")]
[JsonProperty("cooling_coil_availability_schedule_name")]
public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("cooling_coil_setpoint_schedule_name")]
public string CoolingCoilSetpointScheduleName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Nam" +
    "e is specified.")]
[JsonProperty("cooling_coil_design_setpoint")]
public System.Nullable<float> CoolingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("cooling_coil_gross_rated_total_capacity")]
public string CoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Gross SHR")]
[JsonProperty("cooling_coil_gross_rated_sensible_heat_ratio")]
public string CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electric power input")]
[JsonProperty("cooling_coil_gross_rated_cop")]
public System.Nullable<float> CoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_type")]
public HVACTemplate_System_PackagedVAV_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_PackagedVAV_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_HeatingCoilType), "None");
        

[Description("If blank, always on")]
[JsonProperty("heating_coil_availability_schedule_name")]
public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("heating_coil_setpoint_schedule_name")]
public string HeatingCoilSetpointScheduleName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Nam" +
    "e is specified.")]
[JsonProperty("heating_coil_design_setpoint")]
public System.Nullable<float> HeatingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_capacity")]
public string HeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

[JsonProperty("gas_heating_coil_efficiency")]
public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_heating_coil_parasitic_electric_load")]
public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_air_flow_rate")]
public string MaximumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("minimum_outdoor_air_flow_rate")]
public string MinimumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("minimum_outdoor_air_control_type")]
public HVACTemplate_System_PackagedVAV_MinimumOutdoorAirControlType MinimumOutdoorAirControlType { get; set; } = (HVACTemplate_System_PackagedVAV_MinimumOutdoorAirControlType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_MinimumOutdoorAirControlType), "ProportionalMinimum");
        

[Description("Schedule values multiply the Minimum Outdoor Air Flow Rate If blank, multiplier i" +
    "s always one")]
[JsonProperty("minimum_outdoor_air_schedule_name")]
public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

[JsonProperty("economizer_type")]
public HVACTemplate_System_PackagedVAV_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_PackagedVAV_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_EconomizerType), "NoEconomizer");
        

[JsonProperty("economizer_lockout")]
public HVACTemplate_System_PackagedVAV_EconomizerLockout EconomizerLockout { get; set; } = (HVACTemplate_System_PackagedVAV_EconomizerLockout)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_EconomizerLockout), "NoLockout");
        

[Description("Enter the maximum outdoor dry-bulb temperature limit for FixedDryBulb economizer " +
    "control type. No input or blank input means this limit is not operative. Limit i" +
    "s applied regardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_dry_bulb_temperature")]
public System.Nullable<float> EconomizerMaximumLimitDryBulbTemperature { get; set; } = null;
        

[Description("Enter the maximum outdoor enthalpy limit for FixedEnthalpy economizer control typ" +
    "e. No input or blank input means this limit is not operative Limit is applied re" +
    "gardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_enthalpy")]
public System.Nullable<float> EconomizerMaximumLimitEnthalpy { get; set; } = null;
        

[Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
    "economizer control type. No input or blank input means this limit is not operati" +
    "ve. Limit is applied regardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_dewpoint_temperature")]
public System.Nullable<float> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

[Description("Enter the minimum outdoor dry-bulb temperature limit for economizer control. No i" +
    "nput or blank input means this limit is not operative Limit is applied regardles" +
    "s of economizer control type.")]
[JsonProperty("economizer_minimum_limit_dry_bulb_temperature")]
public System.Nullable<float> EconomizerMinimumLimitDryBulbTemperature { get; set; } = null;
        

[Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
[JsonProperty("supply_plenum_name")]
public string SupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
    "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
    " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
    "lues table.")]
[JsonProperty("supply_fan_part_load_power_coefficients")]
public HVACTemplate_System_PackagedVAV_SupplyFanPartLoadPowerCoefficients SupplyFanPartLoadPowerCoefficients { get; set; } = (HVACTemplate_System_PackagedVAV_SupplyFanPartLoadPowerCoefficients)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_SupplyFanPartLoadPowerCoefficients), "InletVaneDampers");
        

[JsonProperty("night_cycle_control")]
public HVACTemplate_System_PackagedVAV_NightCycleControl NightCycleControl { get; set; } = (HVACTemplate_System_PackagedVAV_NightCycleControl)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_NightCycleControl), "StayOff");
        

[Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
[JsonProperty("night_cycle_control_zone_name")]
public string NightCycleControlZoneName { get; set; } = "";
        

[JsonProperty("heat_recovery_type")]
public HVACTemplate_System_PackagedVAV_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_PackagedVAV_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_HeatRecoveryType), "None");
        

[JsonProperty("sensible_heat_recovery_effectiveness")]
public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("latent_heat_recovery_effectiveness")]
public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[Description(@"Overrides Cooling Coil Setpoint Schedule Name None = no reset, control to Cooling Coil Design Setpoint Temperature or Schedule Warmest = reset as warm as possible yet meet all zone cooling loads at max supply air flow rate OutdoorAirTemperatureReset = reset based on outdoor air temperature (18.0C at 15.6C ODB, to the Cooling Design Setpoint at 26.7C) WarmestTemperatureFirst = reset as warm as possible yet meet all zone cooling loads at min supply air flow rate")]
[JsonProperty("cooling_coil_setpoint_reset_type")]
public HVACTemplate_System_PackagedVAV_CoolingCoilSetpointResetType CoolingCoilSetpointResetType { get; set; } = (HVACTemplate_System_PackagedVAV_CoolingCoilSetpointResetType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_CoolingCoilSetpointResetType), "None");
        

[Description(@"Overrides Heating Coil Setpoint Schedule Name None = no reset, control to Heating Coil Design Setpoint Temperature or Schedule OutdoorAirTemperatureReset = reset based on outdoor air temperature (Heating Design Setpoint at -6.7C ODB to Heating Design Setpoint minus 5.2C at 10C ODB) min supply air flow rate")]
[JsonProperty("heating_coil_setpoint_reset_type")]
public HVACTemplate_System_PackagedVAV_HeatingCoilSetpointResetType HeatingCoilSetpointResetType { get; set; } = (HVACTemplate_System_PackagedVAV_HeatingCoilSetpointResetType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_HeatingCoilSetpointResetType), "None");
        

[Description("None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint as " +
    "required to meet the humidity setpoint.")]
[JsonProperty("dehumidification_control_type")]
public HVACTemplate_System_PackagedVAV_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_PackagedVAV_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_DehumidificationControlType), "None");
        

[Description("Zone name where humidistat is located")]
[JsonProperty("dehumidification_control_zone_name")]
public string DehumidificationControlZoneName { get; set; } = "";
        

[Description("Zone relative humidity setpoint in percent (0 to 100)")]
[JsonProperty("dehumidification_setpoint")]
public System.Nullable<float> DehumidificationSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[JsonProperty("humidifier_type")]
public HVACTemplate_System_PackagedVAV_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_PackagedVAV_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_HumidifierType), "None");
        

[Description("If blank, always available")]
[JsonProperty("humidifier_availability_schedule_name")]
public string HumidifierAvailabilityScheduleName { get; set; } = "";
        

[Description("Moisture output rate at full rated power input. The humidifier does not currently" +
    " autosize, so the default is very large to allow for adequate capacity.")]
[JsonProperty("humidifier_rated_capacity")]
public System.Nullable<float> HumidifierRatedCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1E-06", CultureInfo.InvariantCulture);
        

[Description("Electric power input at rated capacity moisture output. Power consumption is prop" +
    "ortional to moisture output with no part-load penalty.")]
[JsonProperty("humidifier_rated_electric_power")]
public string HumidifierRatedElectricPower { get; set; } = (System.String)"Autosize";
        

[Description("Zone name where humidistat is located")]
[JsonProperty("humidifier_control_zone_name")]
public string HumidifierControlZoneName { get; set; } = "";
        

[Description("Zone relative humidity setpoint in percent (0 to 100)")]
[JsonProperty("humidifier_setpoint")]
public System.Nullable<float> HumidifierSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("Select whether autosized system supply flow rate is the sum of Coincident or NonC" +
    "oincident zone air flow rates.")]
[JsonProperty("sizing_option")]
public HVACTemplate_System_PackagedVAV_SizingOption SizingOption { get; set; } = (HVACTemplate_System_PackagedVAV_SizingOption)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_SizingOption), "NonCoincident");
        

[Description("Specifies if the system has a return fan.")]
[JsonProperty("return_fan")]
public EmptyNoYes ReturnFan { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("return_fan_total_efficiency")]
public System.Nullable<float> ReturnFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_delta_pressure")]
public System.Nullable<float> ReturnFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_efficiency")]
public System.Nullable<float> ReturnFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> ReturnFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
    "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
    " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
    "lues table.")]
[JsonProperty("return_fan_part_load_power_coefficients")]
public HVACTemplate_System_PackagedVAV_ReturnFanPartLoadPowerCoefficients ReturnFanPartLoadPowerCoefficients { get; set; } = (HVACTemplate_System_PackagedVAV_ReturnFanPartLoadPowerCoefficients)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_ReturnFanPartLoadPowerCoefficients), "InletVaneDampers");
    }
    
    public enum HVACTemplate_System_PackagedVAV_SupplyFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_System_PackagedVAV_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("TwoSpeedDX")]
        TwoSpeedDX = 1,
        
        [JsonProperty("TwoSpeedHumidControlDX")]
        TwoSpeedHumidControlDX = 2,
    }
    
    public enum HVACTemplate_System_PackagedVAV_HeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_PackagedVAV_MinimumOutdoorAirControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedMinimum")]
        FixedMinimum = 1,
        
        [JsonProperty("ProportionalMinimum")]
        ProportionalMinimum = 2,
    }
    
    public enum HVACTemplate_System_PackagedVAV_EconomizerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [JsonProperty("DifferentialDryBulbAndEnthalpy")]
        DifferentialDryBulbAndEnthalpy = 2,
        
        [JsonProperty("DifferentialEnthalpy")]
        DifferentialEnthalpy = 3,
        
        [JsonProperty("ElectronicEnthalpy")]
        ElectronicEnthalpy = 4,
        
        [JsonProperty("FixedDewPointAndDryBulb")]
        FixedDewPointAndDryBulb = 5,
        
        [JsonProperty("FixedDryBulb")]
        FixedDryBulb = 6,
        
        [JsonProperty("FixedEnthalpy")]
        FixedEnthalpy = 7,
        
        [JsonProperty("NoEconomizer")]
        NoEconomizer = 8,
    }
    
    public enum HVACTemplate_System_PackagedVAV_EconomizerLockout
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LockoutWithCompressor")]
        LockoutWithCompressor = 1,
        
        [JsonProperty("LockoutWithHeating")]
        LockoutWithHeating = 2,
        
        [JsonProperty("NoLockout")]
        NoLockout = 3,
    }
    
    public enum HVACTemplate_System_PackagedVAV_SupplyFanPartLoadPowerCoefficients
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAE90.1-2004AppendixG")]
        ASHRAE9012004AppendixG = 1,
        
        [JsonProperty("InletVaneDampers")]
        InletVaneDampers = 2,
        
        [JsonProperty("OutletDampers")]
        OutletDampers = 3,
        
        [JsonProperty("VariableSpeedMotor")]
        VariableSpeedMotor = 4,
        
        [JsonProperty("VariableSpeedMotorPressureReset")]
        VariableSpeedMotorPressureReset = 5,
    }
    
    public enum HVACTemplate_System_PackagedVAV_NightCycleControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CycleOnAny")]
        CycleOnAny = 1,
        
        [JsonProperty("CycleOnAnyZoneFansOnly")]
        CycleOnAnyZoneFansOnly = 2,
        
        [JsonProperty("CycleOnControlZone")]
        CycleOnControlZone = 3,
        
        [JsonProperty("StayOff")]
        StayOff = 4,
    }
    
    public enum HVACTemplate_System_PackagedVAV_HeatRecoveryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Sensible")]
        Sensible = 3,
    }
    
    public enum HVACTemplate_System_PackagedVAV_CoolingCoilSetpointResetType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
        
        [JsonProperty("Warmest")]
        Warmest = 3,
        
        [JsonProperty("WarmestTemperatureFirst")]
        WarmestTemperatureFirst = 4,
    }
    
    public enum HVACTemplate_System_PackagedVAV_HeatingCoilSetpointResetType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
    }
    
    public enum HVACTemplate_System_PackagedVAV_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    public enum HVACTemplate_System_PackagedVAV_HumidifierType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ElectricSteam")]
        ElectricSteam = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    public enum HVACTemplate_System_PackagedVAV_SizingOption
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coincident")]
        Coincident = 1,
        
        [JsonProperty("NonCoincident")]
        NonCoincident = 2,
    }
    
    public enum HVACTemplate_System_PackagedVAV_ReturnFanPartLoadPowerCoefficients
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAE90.1-2004AppendixG")]
        ASHRAE9012004AppendixG = 1,
        
        [JsonProperty("InletVaneDampers")]
        InletVaneDampers = 2,
        
        [JsonProperty("OutletDampers")]
        OutletDampers = 3,
        
        [JsonProperty("VariableSpeedMotor")]
        VariableSpeedMotor = 4,
        
        [JsonProperty("VariableSpeedMotorPressureReset")]
        VariableSpeedMotorPressureReset = 5,
    }
    
    [Description("Constant Air Volume air loop with optional chilled water cooling coil, optional h" +
        "eating coil and optional preheat.")]
    [JsonObject("HVACTemplate:System:ConstantVolume")]
    public class HVACTemplate_System_ConstantVolume : BHoMObject, IEnergyPlusClass
    {
        

[Description("If blank, always on;  Schedule is used in availability manager and fan scheduling" +
    ". Also see \"Night Cycle Control\" field.")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
    "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
    "value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("supply_fan_maximum_flow_rate")]
public string SupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("supply_fan_total_efficiency")]
public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_delta_pressure")]
public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("600", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_efficiency")]
public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_placement")]
public HVACTemplate_System_ConstantVolume_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_ConstantVolume_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_SupplyFanPlacement), "DrawThrough");
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_System_ConstantVolume_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_ConstantVolume_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_CoolingCoilType), "ChilledWater");
        

[Description("If blank, always on")]
[JsonProperty("cooling_coil_availability_schedule_name")]
public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("cooling_coil_setpoint_control_type")]
public HVACTemplate_System_ConstantVolume_CoolingCoilSetpointControlType CoolingCoilSetpointControlType { get; set; } = (HVACTemplate_System_ConstantVolume_CoolingCoilSetpointControlType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_CoolingCoilSetpointControlType), "FixedSetpoint");
        

[Description("name of the HVACTemplate:ZoneConstantVolume object that contains the cooling ther" +
    "mostat when Cooling Coil Setpoint Control Type = ControlZone")]
[JsonProperty("cooling_coil_control_zone_name")]
public string CoolingCoilControlZoneName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Nam" +
    "e is specified.")]
[JsonProperty("cooling_coil_design_setpoint_temperature")]
public System.Nullable<float> CoolingCoilDesignSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("cooling_coil_setpoint_schedule_name")]
public string CoolingCoilSetpointScheduleName { get; set; } = "";
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("cooling_coil_setpoint_at_outdoor_dry_bulb_low")]
public System.Nullable<float> CoolingCoilSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15.6", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control. Defaults are 15.6C (60F) " +
    "at 15.6C (60F) to 12.8C (55F) at 23.3C (74F)")]
[JsonProperty("cooling_coil_reset_outdoor_dry_bulb_low")]
public System.Nullable<float> CoolingCoilResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15.6", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("cooling_coil_setpoint_at_outdoor_dry_bulb_high")]
public System.Nullable<float> CoolingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("cooling_coil_reset_outdoor_dry_bulb_high")]
public System.Nullable<float> CoolingCoilResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("23.3", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_type")]
public HVACTemplate_System_ConstantVolume_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_ConstantVolume_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_HeatingCoilType), "HotWater");
        

[Description("If blank, always on")]
[JsonProperty("heating_coil_availability_schedule_name")]
public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("heating_coil_setpoint_control_type")]
public HVACTemplate_System_ConstantVolume_HeatingCoilSetpointControlType HeatingCoilSetpointControlType { get; set; } = (HVACTemplate_System_ConstantVolume_HeatingCoilSetpointControlType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_HeatingCoilSetpointControlType), "FixedSetpoint");
        

[Description("name of the HVACTemplate:ZoneConstantVolume object that contains the heating ther" +
    "mostat")]
[JsonProperty("heating_coil_control_zone_name")]
public string HeatingCoilControlZoneName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Nam" +
    "e is specified.")]
[JsonProperty("heating_coil_design_setpoint")]
public System.Nullable<float> HeatingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("heating_coil_setpoint_schedule_name")]
public string HeatingCoilSetpointScheduleName { get; set; } = "";
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("heating_coil_setpoint_at_outdoor_dry_bulb_low")]
public System.Nullable<float> HeatingCoilSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control. Defaults are 15.6C (60F) " +
    "at 15.6C (60F) to 12.8C (55F) at 23.3C (74F)")]
[JsonProperty("heating_coil_reset_outdoor_dry_bulb_low")]
public System.Nullable<float> HeatingCoilResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("7.8", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("heating_coil_setpoint_at_outdoor_dry_bulb_high")]
public System.Nullable<float> HeatingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("heating_coil_reset_outdoor_dry_bulb_high")]
public System.Nullable<float> HeatingCoilResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_capacity")]
public string HeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

[JsonProperty("gas_heating_coil_efficiency")]
public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_heating_coil_parasitic_electric_load")]
public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("preheat_coil_type")]
public HVACTemplate_System_ConstantVolume_PreheatCoilType PreheatCoilType { get; set; } = (HVACTemplate_System_ConstantVolume_PreheatCoilType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_PreheatCoilType), "None");
        

[Description("If blank, always on")]
[JsonProperty("preheat_coil_availability_schedule_name")]
public string PreheatCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Preheat Coil Setpoint Schedule Nam" +
    "e specified.")]
[JsonProperty("preheat_coil_design_setpoint")]
public System.Nullable<float> PreheatCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("7.2", CultureInfo.InvariantCulture);
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("preheat_coil_setpoint_schedule_name")]
public string PreheatCoilSetpointScheduleName { get; set; } = "";
        

[JsonProperty("gas_preheat_coil_efficiency")]
public System.Nullable<float> GasPreheatCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_preheat_coil_parasitic_electric_load")]
public System.Nullable<float> GasPreheatCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_air_flow_rate")]
public string MaximumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("minimum_outdoor_air_flow_rate")]
public string MinimumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Schedule values multiply the Minimum Outdoor Air Flow Rate If blank, multiplier i" +
    "s always one")]
[JsonProperty("minimum_outdoor_air_schedule_name")]
public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

[JsonProperty("economizer_type")]
public HVACTemplate_System_ConstantVolume_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_ConstantVolume_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_EconomizerType), "NoEconomizer");
        

[Description("Outdoor temperature above which economizer is disabled and heat recovery is enabl" +
    "ed (if available). Blank means no limit.")]
[JsonProperty("economizer_upper_temperature_limit")]
public System.Nullable<float> EconomizerUpperTemperatureLimit { get; set; } = null;
        

[Description("Outdoor temperature below which economizer is disabled and heat recovery is enabl" +
    "ed (if available). Blank means no limit.")]
[JsonProperty("economizer_lower_temperature_limit")]
public System.Nullable<float> EconomizerLowerTemperatureLimit { get; set; } = null;
        

[Description("Outdoor enthalpy above which economizer is disabled and heat recovery is enabled " +
    "(if available). Blank means no limit.")]
[JsonProperty("economizer_upper_enthalpy_limit")]
public System.Nullable<float> EconomizerUpperEnthalpyLimit { get; set; } = null;
        

[Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
    "economizer control type. No input or blank input means this limit is not operati" +
    "ve. Limit is applied regardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_dewpoint_temperature")]
public System.Nullable<float> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

[Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
[JsonProperty("supply_plenum_name")]
public string SupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[JsonProperty("night_cycle_control")]
public HVACTemplate_System_ConstantVolume_NightCycleControl NightCycleControl { get; set; } = (HVACTemplate_System_ConstantVolume_NightCycleControl)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_NightCycleControl), "StayOff");
        

[Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
[JsonProperty("night_cycle_control_zone_name")]
public string NightCycleControlZoneName { get; set; } = "";
        

[JsonProperty("heat_recovery_type")]
public HVACTemplate_System_ConstantVolume_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_ConstantVolume_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_HeatRecoveryType), "None");
        

[JsonProperty("sensible_heat_recovery_effectiveness")]
public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("latent_heat_recovery_effectiveness")]
public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_recovery_heat_exchanger_type")]
public HVACTemplate_System_ConstantVolume_HeatRecoveryHeatExchangerType HeatRecoveryHeatExchangerType { get; set; } = (HVACTemplate_System_ConstantVolume_HeatRecoveryHeatExchangerType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_HeatRecoveryHeatExchangerType), "Plate");
        

[JsonProperty("heat_recovery_frost_control_type")]
public HVACTemplate_System_ConstantVolume_HeatRecoveryFrostControlType HeatRecoveryFrostControlType { get; set; } = (HVACTemplate_System_ConstantVolume_HeatRecoveryFrostControlType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_HeatRecoveryFrostControlType), "None");
        

[Description("None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint as " +
    "required to meet the humidity setpoint.")]
[JsonProperty("dehumidification_control_type")]
public HVACTemplate_System_ConstantVolume_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_ConstantVolume_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_DehumidificationControlType), "None");
        

[Description("Zone name where humidistat is located")]
[JsonProperty("dehumidification_control_zone_name")]
public string DehumidificationControlZoneName { get; set; } = "";
        

[Description("Zone relative humidity setpoint in percent (0 to 100) Ignored if Dehumidification" +
    " Relative Humidity Setpoint Schedule specified below")]
[JsonProperty("dehumidification_relative_humidity_setpoint")]
public System.Nullable<float> DehumidificationRelativeHumiditySetpoint { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[Description("Leave blank to use constant setpoint specified in Dehumidification Relative Humid" +
    "ity Setpoint above. Schedule values must be in percent relative humidity (0 to 1" +
    "00).")]
[JsonProperty("dehumidification_relative_humidity_setpoint_schedule_name")]
public string DehumidificationRelativeHumiditySetpointScheduleName { get; set; } = "";
        

[JsonProperty("humidifier_type")]
public HVACTemplate_System_ConstantVolume_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_ConstantVolume_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_ConstantVolume_HumidifierType), "None");
        

[Description("If blank, always available")]
[JsonProperty("humidifier_availability_schedule_name")]
public string HumidifierAvailabilityScheduleName { get; set; } = "";
        

[Description("Moisture output rate at full rated power input. The humidifier does not currently" +
    " autosize, so the default is very large to allow for adequate capacity.")]
[JsonProperty("humidifier_rated_capacity")]
public System.Nullable<float> HumidifierRatedCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1E-06", CultureInfo.InvariantCulture);
        

[Description("Electric power input at rated capacity moisture output. Power consumption is prop" +
    "ortional to moisture output with no part-load penalty.")]
[JsonProperty("humidifier_rated_electric_power")]
public string HumidifierRatedElectricPower { get; set; } = (System.String)"Autosize";
        

[Description("Zone name where humidistat is located")]
[JsonProperty("humidifier_control_zone_name")]
public string HumidifierControlZoneName { get; set; } = "";
        

[Description("Zone relative humidity setpoint in percent (0 to 100). Ignored if Humidifier Rela" +
    "tive Humidity Setpoint Schedule specified below")]
[JsonProperty("humidifier_relative_humidity_setpoint")]
public System.Nullable<float> HumidifierRelativeHumiditySetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("Leave blank to use constant setpoint specified in Humidifier Relative Humidity Se" +
    "tpoint above. Schedule values must be in percent relative humidity (0 to 100).")]
[JsonProperty("humidifier_relative_humidity_setpoint_schedule_name")]
public string HumidifierRelativeHumiditySetpointScheduleName { get; set; } = "";
        

[Description("Specifies if the system has a return fan.")]
[JsonProperty("return_fan")]
public EmptyNoYes ReturnFan { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("return_fan_total_efficiency")]
public System.Nullable<float> ReturnFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_delta_pressure")]
public System.Nullable<float> ReturnFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("300", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_efficiency")]
public System.Nullable<float> ReturnFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> ReturnFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    public enum HVACTemplate_System_ConstantVolume_SupplyFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_System_ConstantVolume_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 1,
        
        [JsonProperty("ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
        
        [JsonProperty("HeatExchangerAssistedChilledWater")]
        HeatExchangerAssistedChilledWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_ConstantVolume_CoolingCoilSetpointControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ControlZone")]
        ControlZone = 1,
        
        [JsonProperty("FixedSetpoint")]
        FixedSetpoint = 2,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 3,
        
        [JsonProperty("Scheduled")]
        Scheduled = 4,
        
        [JsonProperty("Warmest")]
        Warmest = 5,
    }
    
    public enum HVACTemplate_System_ConstantVolume_HeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_ConstantVolume_HeatingCoilSetpointControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ControlZone")]
        ControlZone = 1,
        
        [JsonProperty("FixedSetpoint")]
        FixedSetpoint = 2,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 3,
        
        [JsonProperty("Scheduled")]
        Scheduled = 4,
    }
    
    public enum HVACTemplate_System_ConstantVolume_PreheatCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_ConstantVolume_EconomizerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [JsonProperty("DifferentialDryBulbAndEnthalpy")]
        DifferentialDryBulbAndEnthalpy = 2,
        
        [JsonProperty("DifferentialEnthalpy")]
        DifferentialEnthalpy = 3,
        
        [JsonProperty("ElectronicEnthalpy")]
        ElectronicEnthalpy = 4,
        
        [JsonProperty("FixedDewPointAndDryBulb")]
        FixedDewPointAndDryBulb = 5,
        
        [JsonProperty("FixedDryBulb")]
        FixedDryBulb = 6,
        
        [JsonProperty("FixedEnthalpy")]
        FixedEnthalpy = 7,
        
        [JsonProperty("NoEconomizer")]
        NoEconomizer = 8,
    }
    
    public enum HVACTemplate_System_ConstantVolume_NightCycleControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CycleOnAny")]
        CycleOnAny = 1,
        
        [JsonProperty("CycleOnAnyZoneFansOnly")]
        CycleOnAnyZoneFansOnly = 2,
        
        [JsonProperty("CycleOnControlZone")]
        CycleOnControlZone = 3,
        
        [JsonProperty("StayOff")]
        StayOff = 4,
    }
    
    public enum HVACTemplate_System_ConstantVolume_HeatRecoveryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Sensible")]
        Sensible = 3,
    }
    
    public enum HVACTemplate_System_ConstantVolume_HeatRecoveryHeatExchangerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Plate")]
        Plate = 1,
        
        [JsonProperty("Rotary")]
        Rotary = 2,
    }
    
    public enum HVACTemplate_System_ConstantVolume_HeatRecoveryFrostControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ExhaustAirRecirculation")]
        ExhaustAirRecirculation = 1,
        
        [JsonProperty("ExhaustOnly")]
        ExhaustOnly = 2,
        
        [JsonProperty("MinimumExhaustTemperature")]
        MinimumExhaustTemperature = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_ConstantVolume_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    public enum HVACTemplate_System_ConstantVolume_HumidifierType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ElectricSteam")]
        ElectricSteam = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    [Description("Dual-duct constant volume or variable volume air loop")]
    [JsonObject("HVACTemplate:System:DualDuct")]
    public class HVACTemplate_System_DualDuct : BHoMObject, IEnergyPlusClass
    {
        

[Description("If blank, always on;  Schedule is used in availability manager and fan scheduling" +
    ". Also see \"Night Cycle Control\" field.")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[Description("SingleFan - a single supply fan before the split to dual ducts DualFan - two supp" +
    "ly fans, one each for the cold and hot ducts ConstantVolume - constant volume Va" +
    "riableVolume - variable volume")]
[JsonProperty("system_configuration_type")]
public HVACTemplate_System_DualDuct_SystemConfigurationType SystemConfigurationType { get; set; } = (HVACTemplate_System_DualDuct_SystemConfigurationType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_SystemConfigurationType), "SingleFanConstantVolume");
        

[Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
    "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
    "value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("main_supply_fan_maximum_flow_rate")]
public string MainSupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("main_supply_fan_minimum_flow_fraction")]
public System.Nullable<float> MainSupplyFanMinimumFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("main_supply_fan_total_efficiency")]
public System.Nullable<float> MainSupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("main_supply_fan_delta_pressure")]
public System.Nullable<float> MainSupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

[JsonProperty("main_supply_fan_motor_efficiency")]
public System.Nullable<float> MainSupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("main_supply_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> MainSupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
    "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
    " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
    "lues table.")]
[JsonProperty("main_supply_fan_part_load_power_coefficients")]
public HVACTemplate_System_DualDuct_MainSupplyFanPartLoadPowerCoefficients MainSupplyFanPartLoadPowerCoefficients { get; set; } = (HVACTemplate_System_DualDuct_MainSupplyFanPartLoadPowerCoefficients)Enum.Parse(typeof(HVACTemplate_System_DualDuct_MainSupplyFanPartLoadPowerCoefficients), "InletVaneDampers");
        

[Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
    "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
    "value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("cold_duct_supply_fan_maximum_flow_rate")]
public string ColdDuctSupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("cold_duct_supply_fan_minimum_flow_fraction")]
public System.Nullable<float> ColdDuctSupplyFanMinimumFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("cold_duct_supply_fan_total_efficiency")]
public System.Nullable<float> ColdDuctSupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("cold_duct_supply_fan_delta_pressure")]
public System.Nullable<float> ColdDuctSupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

[JsonProperty("cold_duct_supply_fan_motor_efficiency")]
public System.Nullable<float> ColdDuctSupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("cold_duct_supply_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> ColdDuctSupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
    "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
    " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
    "lues table.")]
[JsonProperty("cold_duct_supply_fan_part_load_power_coefficients")]
public HVACTemplate_System_DualDuct_ColdDuctSupplyFanPartLoadPowerCoefficients ColdDuctSupplyFanPartLoadPowerCoefficients { get; set; } = (HVACTemplate_System_DualDuct_ColdDuctSupplyFanPartLoadPowerCoefficients)Enum.Parse(typeof(HVACTemplate_System_DualDuct_ColdDuctSupplyFanPartLoadPowerCoefficients), "InletVaneDampers");
        

[JsonProperty("cold_duct_supply_fan_placement")]
public HVACTemplate_System_DualDuct_ColdDuctSupplyFanPlacement ColdDuctSupplyFanPlacement { get; set; } = (HVACTemplate_System_DualDuct_ColdDuctSupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_DualDuct_ColdDuctSupplyFanPlacement), "DrawThrough");
        

[Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
    "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
    "value entered here must be large enough to serve the multiplied zones.")]
[JsonProperty("hot_duct_supply_fan_maximum_flow_rate")]
public string HotDuctSupplyFanMaximumFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("hot_duct_supply_fan_minimum_flow_fraction")]
public System.Nullable<float> HotDuctSupplyFanMinimumFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("hot_duct_supply_fan_total_efficiency")]
public System.Nullable<float> HotDuctSupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("hot_duct_supply_fan_delta_pressure")]
public System.Nullable<float> HotDuctSupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

[JsonProperty("hot_duct_supply_fan_motor_efficiency")]
public System.Nullable<float> HotDuctSupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("hot_duct_supply_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> HotDuctSupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
    "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
    " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
    "lues table.")]
[JsonProperty("hot_duct_supply_fan_part_load_power_coefficients")]
public HVACTemplate_System_DualDuct_HotDuctSupplyFanPartLoadPowerCoefficients HotDuctSupplyFanPartLoadPowerCoefficients { get; set; } = (HVACTemplate_System_DualDuct_HotDuctSupplyFanPartLoadPowerCoefficients)Enum.Parse(typeof(HVACTemplate_System_DualDuct_HotDuctSupplyFanPartLoadPowerCoefficients), "InletVaneDampers");
        

[JsonProperty("hot_duct_supply_fan_placement")]
public HVACTemplate_System_DualDuct_HotDuctSupplyFanPlacement HotDuctSupplyFanPlacement { get; set; } = (HVACTemplate_System_DualDuct_HotDuctSupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_DualDuct_HotDuctSupplyFanPlacement), "DrawThrough");
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_System_DualDuct_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_DualDuct_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_CoolingCoilType), "ChilledWater");
        

[Description("If blank, always on")]
[JsonProperty("cooling_coil_availability_schedule_name")]
public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("cooling_coil_setpoint_control_type")]
public HVACTemplate_System_DualDuct_CoolingCoilSetpointControlType CoolingCoilSetpointControlType { get; set; } = (HVACTemplate_System_DualDuct_CoolingCoilSetpointControlType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_CoolingCoilSetpointControlType), "FixedSetpoint");
        

[Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Nam" +
    "e is specified.")]
[JsonProperty("cooling_coil_design_setpoint_temperature")]
public System.Nullable<float> CoolingCoilDesignSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("cooling_coil_setpoint_schedule_name")]
public string CoolingCoilSetpointScheduleName { get; set; } = "";
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("cooling_coil_setpoint_at_outdoor_dry_bulb_low")]
public System.Nullable<float> CoolingCoilSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15.6", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control. Defaults are 15.6C (60F) " +
    "at 15.6C (60F) to 12.8C (55F) at 23.3C (74F)")]
[JsonProperty("cooling_coil_reset_outdoor_dry_bulb_low")]
public System.Nullable<float> CoolingCoilResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15.6", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("cooling_coil_setpoint_at_outdoor_dry_bulb_high")]
public System.Nullable<float> CoolingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("cooling_coil_reset_outdoor_dry_bulb_high")]
public System.Nullable<float> CoolingCoilResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("23.3", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_type")]
public HVACTemplate_System_DualDuct_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_DualDuct_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_HeatingCoilType), "HotWater");
        

[Description("If blank, always on")]
[JsonProperty("heating_coil_availability_schedule_name")]
public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("heating_coil_setpoint_control_type")]
public HVACTemplate_System_DualDuct_HeatingCoilSetpointControlType HeatingCoilSetpointControlType { get; set; } = (HVACTemplate_System_DualDuct_HeatingCoilSetpointControlType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_HeatingCoilSetpointControlType), "FixedSetpoint");
        

[Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Nam" +
    "e is specified.")]
[JsonProperty("heating_coil_design_setpoint")]
public System.Nullable<float> HeatingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("heating_coil_setpoint_schedule_name")]
public string HeatingCoilSetpointScheduleName { get; set; } = "";
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("heating_coil_setpoint_at_outdoor_dry_bulb_low")]
public System.Nullable<float> HeatingCoilSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("50", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control. Defaults are 15.6C (60F) " +
    "at 15.6C (60F) to 12.8C (55F) at 23.3C (74F)")]
[JsonProperty("heating_coil_reset_outdoor_dry_bulb_low")]
public System.Nullable<float> HeatingCoilResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("7.8", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("heating_coil_setpoint_at_outdoor_dry_bulb_high")]
public System.Nullable<float> HeatingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("heating_coil_reset_outdoor_dry_bulb_high")]
public System.Nullable<float> HeatingCoilResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_capacity")]
public string HeatingCoilCapacity { get; set; } = (System.String)"Autosize";
        

[JsonProperty("gas_heating_coil_efficiency")]
public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_heating_coil_parasitic_electric_load")]
public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("preheat_coil_type")]
public HVACTemplate_System_DualDuct_PreheatCoilType PreheatCoilType { get; set; } = (HVACTemplate_System_DualDuct_PreheatCoilType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_PreheatCoilType), "None");
        

[Description("If blank, always on")]
[JsonProperty("preheat_coil_availability_schedule_name")]
public string PreheatCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Preheat Coil Setpoint Schedule Nam" +
    "e specified.")]
[JsonProperty("preheat_coil_design_setpoint")]
public System.Nullable<float> PreheatCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("7.2", CultureInfo.InvariantCulture);
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("preheat_coil_setpoint_schedule_name")]
public string PreheatCoilSetpointScheduleName { get; set; } = "";
        

[JsonProperty("gas_preheat_coil_efficiency")]
public System.Nullable<float> GasPreheatCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_preheat_coil_parasitic_electric_load")]
public System.Nullable<float> GasPreheatCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_air_flow_rate")]
public string MaximumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("minimum_outdoor_air_flow_rate")]
public string MinimumOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("minimum_outdoor_air_control_type")]
public HVACTemplate_System_DualDuct_MinimumOutdoorAirControlType MinimumOutdoorAirControlType { get; set; } = (HVACTemplate_System_DualDuct_MinimumOutdoorAirControlType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_MinimumOutdoorAirControlType), "ProportionalMinimum");
        

[Description("Schedule values multiply the Minimum Outdoor Air Flow Rate If blank, multiplier i" +
    "s always one")]
[JsonProperty("minimum_outdoor_air_schedule_name")]
public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

[JsonProperty("economizer_type")]
public HVACTemplate_System_DualDuct_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_DualDuct_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_EconomizerType), "NoEconomizer");
        

[JsonProperty("economizer_lockout")]
public HVACTemplate_System_DualDuct_EconomizerLockout EconomizerLockout { get; set; } = (HVACTemplate_System_DualDuct_EconomizerLockout)Enum.Parse(typeof(HVACTemplate_System_DualDuct_EconomizerLockout), "NoLockout");
        

[Description("Outdoor temperature above which economizer is disabled and heat recovery is enabl" +
    "ed (if available). Blank means no limit.")]
[JsonProperty("economizer_upper_temperature_limit")]
public System.Nullable<float> EconomizerUpperTemperatureLimit { get; set; } = null;
        

[Description("Outdoor temperature below which economizer is disabled and heat recovery is enabl" +
    "ed (if available). Blank means no limit.")]
[JsonProperty("economizer_lower_temperature_limit")]
public System.Nullable<float> EconomizerLowerTemperatureLimit { get; set; } = null;
        

[Description("Outdoor enthalpy above which economizer is disabled and heat recovery is enabled " +
    "(if available). Blank means no limit.")]
[JsonProperty("economizer_upper_enthalpy_limit")]
public System.Nullable<float> EconomizerUpperEnthalpyLimit { get; set; } = null;
        

[Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
    "economizer control type. No input or blank input means this limit is not operati" +
    "ve. Limit is applied regardless of economizer control type.")]
[JsonProperty("economizer_maximum_limit_dewpoint_temperature")]
public System.Nullable<float> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

[Description("Plenum zone name. Supply plenum serves the cold inlets of all zones on this syste" +
    "m. Blank if none.")]
[JsonProperty("cold_supply_plenum_name")]
public string ColdSupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Supply plenum serves the hot inlets of all zones on this system" +
    ". Blank if none.")]
[JsonProperty("hot_supply_plenum_name")]
public string HotSupplyPlenumName { get; set; } = "";
        

[Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
[JsonProperty("return_plenum_name")]
public string ReturnPlenumName { get; set; } = "";
        

[JsonProperty("night_cycle_control")]
public HVACTemplate_System_DualDuct_NightCycleControl NightCycleControl { get; set; } = (HVACTemplate_System_DualDuct_NightCycleControl)Enum.Parse(typeof(HVACTemplate_System_DualDuct_NightCycleControl), "StayOff");
        

[Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
[JsonProperty("night_cycle_control_zone_name")]
public string NightCycleControlZoneName { get; set; } = "";
        

[JsonProperty("heat_recovery_type")]
public HVACTemplate_System_DualDuct_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_DualDuct_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_HeatRecoveryType), "None");
        

[JsonProperty("sensible_heat_recovery_effectiveness")]
public System.Nullable<float> SensibleHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("latent_heat_recovery_effectiveness")]
public System.Nullable<float> LatentHeatRecoveryEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_recovery_heat_exchanger_type")]
public HVACTemplate_System_DualDuct_HeatRecoveryHeatExchangerType HeatRecoveryHeatExchangerType { get; set; } = (HVACTemplate_System_DualDuct_HeatRecoveryHeatExchangerType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_HeatRecoveryHeatExchangerType), "Plate");
        

[JsonProperty("heat_recovery_frost_control_type")]
public HVACTemplate_System_DualDuct_HeatRecoveryFrostControlType HeatRecoveryFrostControlType { get; set; } = (HVACTemplate_System_DualDuct_HeatRecoveryFrostControlType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_HeatRecoveryFrostControlType), "None");
        

[Description("None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint as " +
    "required to meet the humidity setpoint.")]
[JsonProperty("dehumidification_control_type")]
public HVACTemplate_System_DualDuct_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_DualDuct_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_DehumidificationControlType), "None");
        

[Description("Zone name where humidistat is located")]
[JsonProperty("dehumidification_control_zone_name")]
public string DehumidificationControlZoneName { get; set; } = "";
        

[Description("Zone relative humidity setpoint in percent (0 to 100) Ignored if Dehumidification" +
    " Relative Humidity Setpoint Schedule specified below")]
[JsonProperty("dehumidification_relative_humidity_setpoint")]
public System.Nullable<float> DehumidificationRelativeHumiditySetpoint { get; set; } = (System.Nullable<float>)Single.Parse("60", CultureInfo.InvariantCulture);
        

[Description("Leave blank to use constant setpoint specified in Dehumidification Relative Humid" +
    "ity Setpoint above. Schedule values must be in percent relative humidity (0 to 1" +
    "00).")]
[JsonProperty("dehumidification_relative_humidity_setpoint_schedule_name")]
public string DehumidificationRelativeHumiditySetpointScheduleName { get; set; } = "";
        

[JsonProperty("humidifier_type")]
public HVACTemplate_System_DualDuct_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_DualDuct_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_DualDuct_HumidifierType), "None");
        

[Description("If blank, always available")]
[JsonProperty("humidifier_availability_schedule_name")]
public string HumidifierAvailabilityScheduleName { get; set; } = "";
        

[Description("Moisture output rate at full rated power input. The humidifier does not currently" +
    " autosize, so the default is very large to allow for adequate capacity.")]
[JsonProperty("humidifier_rated_capacity")]
public System.Nullable<float> HumidifierRatedCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1E-06", CultureInfo.InvariantCulture);
        

[Description("Electric power input at rated capacity moisture output. Power consumption is prop" +
    "ortional to moisture output with no part-load penalty.")]
[JsonProperty("humidifier_rated_electric_power")]
public string HumidifierRatedElectricPower { get; set; } = (System.String)"Autosize";
        

[Description("Zone name where humidistat is located")]
[JsonProperty("humidifier_control_zone_name")]
public string HumidifierControlZoneName { get; set; } = "";
        

[Description("Zone relative humidity setpoint in percent (0 to 100). Ignored if Humidifier Rela" +
    "tive Humidity Setpoint Schedule specified below")]
[JsonProperty("humidifier_relative_humidity_setpoint")]
public System.Nullable<float> HumidifierRelativeHumiditySetpoint { get; set; } = (System.Nullable<float>)Single.Parse("30", CultureInfo.InvariantCulture);
        

[Description("Leave blank to use constant setpoint specified in Humidifier Relative Humidity Se" +
    "tpoint above. Schedule values must be in percent relative humidity (0 to 100).")]
[JsonProperty("humidifier_relative_humidity_setpoint_schedule_name")]
public string HumidifierRelativeHumiditySetpointScheduleName { get; set; } = "";
        

[Description("Select whether autosized system supply flow rate is the sum of Coincident or NonC" +
    "oincident zone air flow rates.")]
[JsonProperty("sizing_option")]
public HVACTemplate_System_DualDuct_SizingOption SizingOption { get; set; } = (HVACTemplate_System_DualDuct_SizingOption)Enum.Parse(typeof(HVACTemplate_System_DualDuct_SizingOption), "NonCoincident");
        

[Description("Specifies if the system has a return fan.")]
[JsonProperty("return_fan")]
public EmptyNoYes ReturnFan { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("return_fan_total_efficiency")]
public System.Nullable<float> ReturnFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_delta_pressure")]
public System.Nullable<float> ReturnFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("500", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_efficiency")]
public System.Nullable<float> ReturnFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("return_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> ReturnFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
    "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
    " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
    "lues table.")]
[JsonProperty("return_fan_part_load_power_coefficients")]
public HVACTemplate_System_DualDuct_ReturnFanPartLoadPowerCoefficients ReturnFanPartLoadPowerCoefficients { get; set; } = (HVACTemplate_System_DualDuct_ReturnFanPartLoadPowerCoefficients)Enum.Parse(typeof(HVACTemplate_System_DualDuct_ReturnFanPartLoadPowerCoefficients), "InletVaneDampers");
    }
    
    public enum HVACTemplate_System_DualDuct_SystemConfigurationType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DualFanConstantVolume")]
        DualFanConstantVolume = 1,
        
        [JsonProperty("DualFanVariableVolume")]
        DualFanVariableVolume = 2,
        
        [JsonProperty("SingleFanConstantVolume")]
        SingleFanConstantVolume = 3,
        
        [JsonProperty("SingleFanVariableVolume")]
        SingleFanVariableVolume = 4,
    }
    
    public enum HVACTemplate_System_DualDuct_MainSupplyFanPartLoadPowerCoefficients
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAE90.1-2004AppendixG")]
        ASHRAE9012004AppendixG = 1,
        
        [JsonProperty("InletVaneDampers")]
        InletVaneDampers = 2,
        
        [JsonProperty("OutletDampers")]
        OutletDampers = 3,
        
        [JsonProperty("VariableSpeedMotor")]
        VariableSpeedMotor = 4,
        
        [JsonProperty("VariableSpeedMotorPressureReset")]
        VariableSpeedMotorPressureReset = 5,
    }
    
    public enum HVACTemplate_System_DualDuct_ColdDuctSupplyFanPartLoadPowerCoefficients
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAE90.1-2004AppendixG")]
        ASHRAE9012004AppendixG = 1,
        
        [JsonProperty("InletVaneDampers")]
        InletVaneDampers = 2,
        
        [JsonProperty("OutletDampers")]
        OutletDampers = 3,
        
        [JsonProperty("VariableSpeedMotor")]
        VariableSpeedMotor = 4,
        
        [JsonProperty("VariableSpeedMotorPressureReset")]
        VariableSpeedMotorPressureReset = 5,
    }
    
    public enum HVACTemplate_System_DualDuct_ColdDuctSupplyFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_System_DualDuct_HotDuctSupplyFanPartLoadPowerCoefficients
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAE90.1-2004AppendixG")]
        ASHRAE9012004AppendixG = 1,
        
        [JsonProperty("InletVaneDampers")]
        InletVaneDampers = 2,
        
        [JsonProperty("OutletDampers")]
        OutletDampers = 3,
        
        [JsonProperty("VariableSpeedMotor")]
        VariableSpeedMotor = 4,
        
        [JsonProperty("VariableSpeedMotorPressureReset")]
        VariableSpeedMotorPressureReset = 5,
    }
    
    public enum HVACTemplate_System_DualDuct_HotDuctSupplyFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_System_DualDuct_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 1,
        
        [JsonProperty("ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum HVACTemplate_System_DualDuct_CoolingCoilSetpointControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedSetpoint")]
        FixedSetpoint = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
        
        [JsonProperty("Scheduled")]
        Scheduled = 3,
        
        [JsonProperty("Warmest")]
        Warmest = 4,
    }
    
    public enum HVACTemplate_System_DualDuct_HeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_DualDuct_HeatingCoilSetpointControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coldest")]
        Coldest = 1,
        
        [JsonProperty("FixedSetpoint")]
        FixedSetpoint = 2,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 3,
        
        [JsonProperty("Scheduled")]
        Scheduled = 4,
    }
    
    public enum HVACTemplate_System_DualDuct_PreheatCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_DualDuct_MinimumOutdoorAirControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedMinimum")]
        FixedMinimum = 1,
        
        [JsonProperty("ProportionalMinimum")]
        ProportionalMinimum = 2,
    }
    
    public enum HVACTemplate_System_DualDuct_EconomizerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DifferentialDryBulb")]
        DifferentialDryBulb = 1,
        
        [JsonProperty("DifferentialDryBulbAndEnthalpy")]
        DifferentialDryBulbAndEnthalpy = 2,
        
        [JsonProperty("DifferentialEnthalpy")]
        DifferentialEnthalpy = 3,
        
        [JsonProperty("ElectronicEnthalpy")]
        ElectronicEnthalpy = 4,
        
        [JsonProperty("FixedDewPointAndDryBulb")]
        FixedDewPointAndDryBulb = 5,
        
        [JsonProperty("FixedDryBulb")]
        FixedDryBulb = 6,
        
        [JsonProperty("FixedEnthalpy")]
        FixedEnthalpy = 7,
        
        [JsonProperty("NoEconomizer")]
        NoEconomizer = 8,
    }
    
    public enum HVACTemplate_System_DualDuct_EconomizerLockout
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NoLockout")]
        NoLockout = 1,
    }
    
    public enum HVACTemplate_System_DualDuct_NightCycleControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CycleOnAny")]
        CycleOnAny = 1,
        
        [JsonProperty("CycleOnControlZone")]
        CycleOnControlZone = 2,
        
        [JsonProperty("StayOff")]
        StayOff = 3,
    }
    
    public enum HVACTemplate_System_DualDuct_HeatRecoveryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Sensible")]
        Sensible = 3,
    }
    
    public enum HVACTemplate_System_DualDuct_HeatRecoveryHeatExchangerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Plate")]
        Plate = 1,
        
        [JsonProperty("Rotary")]
        Rotary = 2,
    }
    
    public enum HVACTemplate_System_DualDuct_HeatRecoveryFrostControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ExhaustAirRecirculation")]
        ExhaustAirRecirculation = 1,
        
        [JsonProperty("ExhaustOnly")]
        ExhaustOnly = 2,
        
        [JsonProperty("MinimumExhaustTemperature")]
        MinimumExhaustTemperature = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_DualDuct_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheat")]
        CoolReheat = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    public enum HVACTemplate_System_DualDuct_HumidifierType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ElectricSteam")]
        ElectricSteam = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    public enum HVACTemplate_System_DualDuct_SizingOption
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coincident")]
        Coincident = 1,
        
        [JsonProperty("NonCoincident")]
        NonCoincident = 2,
    }
    
    public enum HVACTemplate_System_DualDuct_ReturnFanPartLoadPowerCoefficients
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ASHRAE90.1-2004AppendixG")]
        ASHRAE9012004AppendixG = 1,
        
        [JsonProperty("InletVaneDampers")]
        InletVaneDampers = 2,
        
        [JsonProperty("OutletDampers")]
        OutletDampers = 3,
        
        [JsonProperty("VariableSpeedMotor")]
        VariableSpeedMotor = 4,
        
        [JsonProperty("VariableSpeedMotorPressureReset")]
        VariableSpeedMotorPressureReset = 5,
    }
    
    [Description("This object creates a dedicated outdoor air system that must be used with HVACTem" +
        "plate:Zone:* objects for BaseboardHeat FanCoil PTAC PTHP WaterToAirHeatPump and " +
        "VRF. Does not support HVACTemplate:Zone:VAV or other central multizone systems")]
    [JsonObject("HVACTemplate:System:DedicatedOutdoorAir")]
    public class HVACTemplate_System_DedicatedOutdoorAir : BHoMObject, IEnergyPlusClass
    {
        

[Description("If blank, always on; DOAS System always on. Schedule is used in availability mana" +
    "ger and fan scheduling.")]
[JsonProperty("system_availability_schedule_name")]
public string SystemAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("air_outlet_type")]
public HVACTemplate_System_DedicatedOutdoorAir_AirOutletType AirOutletType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_AirOutletType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_AirOutletType), "DirectIntoZone");
        

[JsonProperty("supply_fan_flow_rate")]
public string SupplyFanFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("supply_fan_total_efficiency")]
public System.Nullable<float> SupplyFanTotalEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_delta_pressure")]
public System.Nullable<float> SupplyFanDeltaPressure { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_efficiency")]
public System.Nullable<float> SupplyFanMotorEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_motor_in_air_stream_fraction")]
public System.Nullable<float> SupplyFanMotorInAirStreamFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_fan_placement")]
public HVACTemplate_System_DedicatedOutdoorAir_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_SupplyFanPlacement), "DrawThrough");
        

[JsonProperty("cooling_coil_type")]
public HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilType), "ChilledWater");
        

[Description("If blank, always on")]
[JsonProperty("cooling_coil_availability_schedule_name")]
public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("cooling_coil_setpoint_control_type")]
public HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilSetpointControlType CoolingCoilSetpointControlType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilSetpointControlType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilSetpointControlType), "FixedSetpoint");
        

[Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Nam" +
    "e is specified.")]
[JsonProperty("cooling_coil_design_setpoint")]
public System.Nullable<float> CoolingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("cooling_coil_setpoint_schedule_name")]
public string CoolingCoilSetpointScheduleName { get; set; } = "";
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("cooling_coil_setpoint_at_outdoor_dry_bulb_low")]
public System.Nullable<float> CoolingCoilSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15.6", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control. Defaults are 15.6C (60F) " +
    "at 15.6C (60F) to 12.8C (55F) at 23.3C (74F)")]
[JsonProperty("cooling_coil_reset_outdoor_dry_bulb_low")]
public System.Nullable<float> CoolingCoilResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15.6", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("cooling_coil_setpoint_at_outdoor_dry_bulb_high")]
public System.Nullable<float> CoolingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.8", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("cooling_coil_reset_outdoor_dry_bulb_high")]
public System.Nullable<float> CoolingCoilResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("23.3", CultureInfo.InvariantCulture);
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("dx_cooling_coil_gross_rated_total_capacity")]
public string DxCoolingCoilGrossRatedTotalCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Gross SHR")]
[JsonProperty("dx_cooling_coil_gross_rated_sensible_heat_ratio")]
public string DxCoolingCoilGrossRatedSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electrical energy input")]
[JsonProperty("dx_cooling_coil_gross_rated_cop")]
public System.Nullable<float> DxCoolingCoilGrossRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_coil_type")]
public HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilType), "HotWater");
        

[Description("If blank, always on")]
[JsonProperty("heating_coil_availability_schedule_name")]
public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

[Description("When selecting OutdoorAirTemperatureReset, the Heating Coil Design Setpoint may n" +
    "eed to be changed")]
[JsonProperty("heating_coil_setpoint_control_type")]
public HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilSetpointControlType HeatingCoilSetpointControlType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilSetpointControlType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilSetpointControlType), "FixedSetpoint");
        

[Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Nam" +
    "e is specified.")]
[JsonProperty("heating_coil_design_setpoint")]
public System.Nullable<float> HeatingCoilDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("heating_coil_setpoint_schedule_name")]
public string HeatingCoilSetpointScheduleName { get; set; } = "";
        

[Description("Applicable only for OutdoorAirTemperatureReset control. Defaults 15.0C (59F) at 7" +
    ".8C (46F) to 12.2C (54F) at 12.2C (54F)")]
[JsonProperty("heating_coil_setpoint_at_outdoor_dry_bulb_low")]
public System.Nullable<float> HeatingCoilSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("heating_coil_reset_outdoor_dry_bulb_low")]
public System.Nullable<float> HeatingCoilResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("7.8", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("heating_coil_setpoint_at_outdoor_dry_bulb_high")]
public System.Nullable<float> HeatingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("heating_coil_reset_outdoor_dry_bulb_high")]
public System.Nullable<float> HeatingCoilResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_heating_coil_efficiency")]
public System.Nullable<float> GasHeatingCoilEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("gas_heating_coil_parasitic_electric_load")]
public System.Nullable<float> GasHeatingCoilParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_recovery_type")]
public HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryType), "None");
        

[JsonProperty("heat_recovery_sensible_effectiveness")]
public System.Nullable<float> HeatRecoverySensibleEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_recovery_latent_effectiveness")]
public System.Nullable<float> HeatRecoveryLatentEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.65", CultureInfo.InvariantCulture);
        

[JsonProperty("heat_recovery_heat_exchanger_type")]
public HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryHeatExchangerType HeatRecoveryHeatExchangerType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryHeatExchangerType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryHeatExchangerType), "Plate");
        

[JsonProperty("heat_recovery_frost_control_type")]
public HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryFrostControlType HeatRecoveryFrostControlType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryFrostControlType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryFrostControlType), "None");
        

[Description(@"None = meet sensible load only CoolReheatHeatingCoil = cool beyond the dry-bulb setpoint, reheat with heating coil Valid for all cooling coil types. If no heating coil specified, cold supply temps may occur. CoolReheatDesuperheater = cool beyond the dry-bulb setpoint as required to meet the humidity setpoint, reheat with desuperheater coil. Valid only for Cooling Coil Type = TwoSpeedDX, TwoStageDX, TwoStageHumidityControlDX, or HeatExchangerAssistedDX. Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only for Cooling Coil Type = TwoStageHumidityControlDX or HeatExchangerAssistedDX")]
[JsonProperty("dehumidification_control_type")]
public HVACTemplate_System_DedicatedOutdoorAir_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_DehumidificationControlType), "None");
        

[Description("The supply air humidity ratio for dehumidification control. Default of 0.00924 kg" +
    "Water/kgDryAir is equivalent to 12.8C (55F) dewpoint. Ignored if Dehumidificatio" +
    "n Setpoint Schedule specified below")]
[JsonProperty("dehumidification_setpoint")]
public System.Nullable<float> DehumidificationSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("0.00924", CultureInfo.InvariantCulture);
        

[JsonProperty("humidifier_type")]
public HVACTemplate_System_DedicatedOutdoorAir_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HumidifierType), "None");
        

[Description("If blank, always available")]
[JsonProperty("humidifier_availability_schedule_name")]
public string HumidifierAvailabilityScheduleName { get; set; } = "";
        

[Description("Moisture output rate at full rated power input. The humidifier does not currently" +
    " autosize, so the default is very large to allow for adequate capacity.")]
[JsonProperty("humidifier_rated_capacity")]
public System.Nullable<float> HumidifierRatedCapacity { get; set; } = (System.Nullable<float>)Single.Parse("1E-06", CultureInfo.InvariantCulture);
        

[Description("Electric power input at rated capacity moisture output. Power consumption is prop" +
    "ortional to moisture output with no part-load penalty.")]
[JsonProperty("humidifier_rated_electric_power")]
public string HumidifierRatedElectricPower { get; set; } = (System.String)"Autosize";
        

[Description("The supply air humidity ratio for humidification control. Ignored if Humidifier S" +
    "etpoint Schedule specified below")]
[JsonProperty("humidifier_constant_setpoint")]
public System.Nullable<float> HumidifierConstantSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("0.003", CultureInfo.InvariantCulture);
        

[Description("Leave blank to use constant setpoint specified in Dehumidification Setpoint above" +
    ". Schedule values must be in units of humidity ratio (kgWater/kgDryAir or lbWate" +
    "r/lbDryAir)")]
[JsonProperty("dehumidification_setpoint_schedule_name")]
public string DehumidificationSetpointScheduleName { get; set; } = "";
        

[Description("Leave blank to use constant setpoint specified in Humidifier Constant Setpoint ab" +
    "ove. Schedule values must be in units of humidity ratio (kgWater/kgDryAir or lbW" +
    "ater/lbDryAir)")]
[JsonProperty("humidifier_setpoint_schedule_name")]
public string HumidifierSetpointScheduleName { get; set; } = "";
    }
    
    public enum HVACTemplate_System_DedicatedOutdoorAir_AirOutletType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DirectIntoZone")]
        DirectIntoZone = 1,
    }
    
    public enum HVACTemplate_System_DedicatedOutdoorAir_SupplyFanPlacement
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlowThrough")]
        BlowThrough = 1,
        
        [JsonProperty("DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 1,
        
        [JsonProperty("ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
        
        [JsonProperty("HeatExchangerAssistedChilledWater")]
        HeatExchangerAssistedChilledWater = 3,
        
        [JsonProperty("HeatExchangerAssistedDX")]
        HeatExchangerAssistedDX = 4,
        
        [JsonProperty("None")]
        None = 5,
        
        [JsonProperty("TwoSpeedDX")]
        TwoSpeedDX = 6,
        
        [JsonProperty("TwoStageDX")]
        TwoStageDX = 7,
        
        [JsonProperty("TwoStageHumidityControlDX")]
        TwoStageHumidityControlDX = 8,
    }
    
    public enum HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilSetpointControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedSetpoint")]
        FixedSetpoint = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
        
        [JsonProperty("Scheduled")]
        Scheduled = 3,
    }
    
    public enum HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Electric")]
        Electric = 1,
        
        [JsonProperty("Gas")]
        Gas = 2,
        
        [JsonProperty("HotWater")]
        HotWater = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilSetpointControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FixedSetpoint")]
        FixedSetpoint = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
        
        [JsonProperty("Scheduled")]
        Scheduled = 3,
    }
    
    public enum HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Enthalpy")]
        Enthalpy = 1,
        
        [JsonProperty("None")]
        None = 2,
        
        [JsonProperty("Sensible")]
        Sensible = 3,
    }
    
    public enum HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryHeatExchangerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Plate")]
        Plate = 1,
        
        [JsonProperty("Rotary")]
        Rotary = 2,
    }
    
    public enum HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryFrostControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ExhaustAirRecirculation")]
        ExhaustAirRecirculation = 1,
        
        [JsonProperty("ExhaustOnly")]
        ExhaustOnly = 2,
        
        [JsonProperty("MinimumExhaustTemperature")]
        MinimumExhaustTemperature = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_DedicatedOutdoorAir_DehumidificationControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolReheatDesuperheater")]
        CoolReheatDesuperheater = 1,
        
        [JsonProperty("CoolReheatHeatingCoil")]
        CoolReheatHeatingCoil = 2,
        
        [JsonProperty("Multimode")]
        Multimode = 3,
        
        [JsonProperty("None")]
        None = 4,
    }
    
    public enum HVACTemplate_System_DedicatedOutdoorAir_HumidifierType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ElectricSteam")]
        ElectricSteam = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    [Description("Plant and condenser loops to serve all HVACTemplate chilled water coils, chillers" +
        ", and towers.")]
    [JsonObject("HVACTemplate:Plant:ChilledWaterLoop")]
    public class HVACTemplate_Plant_ChilledWaterLoop : BHoMObject, IEnergyPlusClass
    {
        

[Description("If blank, always available Applies to both chilled water and condenser loop pumps" +
    "")]
[JsonProperty("pump_schedule_name")]
public string PumpScheduleName { get; set; } = "";
        

[Description("Applies to both chilled water and condenser loop pumps")]
[JsonProperty("pump_control_type")]
public HVACTemplate_Plant_ChilledWaterLoop_PumpControlType PumpControlType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_PumpControlType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_PumpControlType), "Intermittent");
        

[Description("Default operation type makes all equipment available at all times operating in or" +
    "der of Priority specified in HVACTemplate:Plant:Chiller objects.")]
[JsonProperty("chiller_plant_operation_scheme_type")]
public HVACTemplate_Plant_ChilledWaterLoop_ChillerPlantOperationSchemeType ChillerPlantOperationSchemeType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_ChillerPlantOperationSchemeType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_ChillerPlantOperationSchemeType), "Default");
        

[Description("Name of a PlantEquipmentOperationSchemes object Ignored if Chiller Plant Operatio" +
    "n Scheme Type = Default")]
[JsonProperty("chiller_plant_equipment_operation_schemes_name")]
public string ChillerPlantEquipmentOperationSchemesName { get; set; } = "";
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("chilled_water_setpoint_schedule_name")]
public string ChilledWaterSetpointScheduleName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Chilled Water Setpoint Schedule Na" +
    "me is specified.")]
[JsonProperty("chilled_water_design_setpoint")]
public System.Nullable<float> ChilledWaterDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("7.22", CultureInfo.InvariantCulture);
        

[Description(@"VariablePrimaryNoSecondary - variable flow to chillers and coils ConstantPrimaryNoSecondary - constant flow to chillers and coils, excess bypassed ConstantPrimaryVariableSecondary - constant flow to chillers, variable flow to coils VariablePrimaryConstantSecondary - currently unsupported - variable flow to chillers, constant flow to coils")]
[JsonProperty("chilled_water_pump_configuration")]
public HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPumpConfiguration ChilledWaterPumpConfiguration { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPumpConfiguration)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPumpConfiguration), "ConstantPrimaryNoSecondary");
        

[Description("default head is 60 feet H2O")]
[JsonProperty("primary_chilled_water_pump_rated_head")]
public System.Nullable<float> PrimaryChilledWaterPumpRatedHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

[Description("default head is 60 feet H2O")]
[JsonProperty("secondary_chilled_water_pump_rated_head")]
public System.Nullable<float> SecondaryChilledWaterPumpRatedHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

[Description("Default operation type makes all equipment available at all times operating in or" +
    "der of Priority specified in HVACTemplate:Plant:Tower objects. May be left blank" +
    " if not serving any water cooled chillers")]
[JsonProperty("condenser_plant_operation_scheme_type")]
public HVACTemplate_Plant_ChilledWaterLoop_CondenserPlantOperationSchemeType CondenserPlantOperationSchemeType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_CondenserPlantOperationSchemeType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_CondenserPlantOperationSchemeType), "Default");
        

[Description("Name of a CondenserEquipmentOperationSchemes object Ignored if Condenser Plant Op" +
    "eration Scheme Type = Default May be left blank if not serving any water cooled " +
    "chillers")]
[JsonProperty("condenser_equipment_operation_schemes_name")]
public string CondenserEquipmentOperationSchemesName { get; set; } = "";
        

[Description("May be left blank if not serving any water cooled chillers")]
[JsonProperty("condenser_water_temperature_control_type")]
public HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterTemperatureControlType CondenserWaterTemperatureControlType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterTemperatureControlType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterTemperatureControlType), "OutdoorWetBulbTemperature");
        

[Description("Leave blank if constant setpoint May be left blank if not serving any water coole" +
    "d chillers")]
[JsonProperty("condenser_water_setpoint_schedule_name")]
public string CondenserWaterSetpointScheduleName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Condenser Water Setpoint Schedule " +
    "Name is specified. May be left blank if not serving any water cooled chillers")]
[JsonProperty("condenser_water_design_setpoint")]
public System.Nullable<float> CondenserWaterDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("29.4", CultureInfo.InvariantCulture);
        

[Description("May be left blank if not serving any water cooled chillers default head is 60 fee" +
    "t H2O")]
[JsonProperty("condenser_water_pump_rated_head")]
public System.Nullable<float> CondenserWaterPumpRatedHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

[Description("Overrides Chilled Water Setpoint Schedule Name")]
[JsonProperty("chilled_water_setpoint_reset_type")]
public HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSetpointResetType ChilledWaterSetpointResetType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSetpointResetType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSetpointResetType), "None");
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("chilled_water_setpoint_at_outdoor_dry_bulb_low")]
public System.Nullable<float> ChilledWaterSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("12.2", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("chilled_water_reset_outdoor_dry_bulb_low")]
public System.Nullable<float> ChilledWaterResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("15.6", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("chilled_water_setpoint_at_outdoor_dry_bulb_high")]
public System.Nullable<float> ChilledWaterSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("6.7", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("chilled_water_reset_outdoor_dry_bulb_high")]
public System.Nullable<float> ChilledWaterResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("26.7", CultureInfo.InvariantCulture);
        

[Description("Describes the type of pump configuration used for the primary portion of the chil" +
    "led water loop.")]
[JsonProperty("chilled_water_primary_pump_type")]
public HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPrimaryPumpType ChilledWaterPrimaryPumpType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPrimaryPumpType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPrimaryPumpType), "SinglePump");
        

[Description("Describes the type of pump configuration used for the secondary portion of the ch" +
    "illed water loop.")]
[JsonProperty("chilled_water_secondary_pump_type")]
public HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSecondaryPumpType ChilledWaterSecondaryPumpType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSecondaryPumpType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSecondaryPumpType), "SinglePump");
        

[Description("Describes the type of pump configuration used for the condenser water loop.")]
[JsonProperty("condenser_water_pump_type")]
public HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterPumpType CondenserWaterPumpType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterPumpType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterPumpType), "SinglePump");
        

[Description("Determines if a supply side bypass pipe is present in the chilled water loop.")]
[JsonProperty("chilled_water_supply_side_bypass_pipe")]
public EmptyNoYes ChilledWaterSupplySideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("Determines if a demand side bypass pipe is present in the chilled water loop.")]
[JsonProperty("chilled_water_demand_side_bypass_pipe")]
public EmptyNoYes ChilledWaterDemandSideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("Determines if a supply side bypass pipe is present in the condenser water loop.")]
[JsonProperty("condenser_water_supply_side_bypass_pipe")]
public EmptyNoYes CondenserWaterSupplySideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("Determines if a demand side bypass pipe is present in the condenser water loop.")]
[JsonProperty("condenser_water_demand_side_bypass_pipe")]
public EmptyNoYes CondenserWaterDemandSideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("fluid_type")]
public HVACTemplate_Plant_ChilledWaterLoop_FluidType FluidType { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_FluidType)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_FluidType), "Water");
        

[Description("The temperature difference used in sizing the loop flow rate.")]
[JsonProperty("loop_design_delta_temperature")]
public System.Nullable<float> LoopDesignDeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("6.67", CultureInfo.InvariantCulture);
        

[Description("The minimum outdoor dry-bulb temperature that the chilled water loops operate. Le" +
    "ave blank for no limit.")]
[JsonProperty("minimum_outdoor_dry_bulb_temperature")]
public System.Nullable<float> MinimumOutdoorDryBulbTemperature { get; set; } = null;
        

[JsonProperty("chilled_water_load_distribution_scheme")]
public HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterLoadDistributionScheme ChilledWaterLoadDistributionScheme { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterLoadDistributionScheme)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterLoadDistributionScheme), "SequentialLoad");
        

[JsonProperty("condenser_water_load_distribution_scheme")]
public HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterLoadDistributionScheme CondenserWaterLoadDistributionScheme { get; set; } = (HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterLoadDistributionScheme)Enum.Parse(typeof(HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterLoadDistributionScheme), "SequentialLoad");
    }
    
    public enum HVACTemplate_Plant_ChilledWaterLoop_PumpControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Continuous")]
        Continuous = 1,
        
        [JsonProperty("Intermittent")]
        Intermittent = 2,
    }
    
    public enum HVACTemplate_Plant_ChilledWaterLoop_ChillerPlantOperationSchemeType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Default")]
        Default = 1,
        
        [JsonProperty("UserDefined")]
        UserDefined = 2,
    }
    
    public enum HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPumpConfiguration
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantPrimaryNoSecondary")]
        ConstantPrimaryNoSecondary = 1,
        
        [JsonProperty("ConstantPrimaryVariableSecondary")]
        ConstantPrimaryVariableSecondary = 2,
        
        [JsonProperty("VariablePrimaryNoSecondary")]
        VariablePrimaryNoSecondary = 3,
    }
    
    public enum HVACTemplate_Plant_ChilledWaterLoop_CondenserPlantOperationSchemeType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Default")]
        Default = 1,
        
        [JsonProperty("UserDefined")]
        UserDefined = 2,
    }
    
    public enum HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterTemperatureControlType
    {
        
        [JsonProperty("OutdoorWetBulbTemperature")]
        OutdoorWetBulbTemperature = 0,
        
        [JsonProperty("SpecifiedSetpoint")]
        SpecifiedSetpoint = 1,
    }
    
    public enum HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSetpointResetType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
    }
    
    public enum HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterPrimaryPumpType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FiveHeaderedPumps")]
        FiveHeaderedPumps = 1,
        
        [JsonProperty("FourHeaderedPumps")]
        FourHeaderedPumps = 2,
        
        [JsonProperty("PumpPerChiller")]
        PumpPerChiller = 3,
        
        [JsonProperty("SinglePump")]
        SinglePump = 4,
        
        [JsonProperty("ThreeHeaderedPumps")]
        ThreeHeaderedPumps = 5,
        
        [JsonProperty("TwoHeaderedPumps")]
        TwoHeaderedPumps = 6,
    }
    
    public enum HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterSecondaryPumpType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FiveHeaderedPumps")]
        FiveHeaderedPumps = 1,
        
        [JsonProperty("FourHeaderedPumps")]
        FourHeaderedPumps = 2,
        
        [JsonProperty("SinglePump")]
        SinglePump = 3,
        
        [JsonProperty("ThreeHeaderedPumps")]
        ThreeHeaderedPumps = 4,
        
        [JsonProperty("TwoHeaderedPumps")]
        TwoHeaderedPumps = 5,
    }
    
    public enum HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterPumpType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FiveHeaderedPumps")]
        FiveHeaderedPumps = 1,
        
        [JsonProperty("FourHeaderedPumps")]
        FourHeaderedPumps = 2,
        
        [JsonProperty("PumpPerTower")]
        PumpPerTower = 3,
        
        [JsonProperty("SinglePump")]
        SinglePump = 4,
        
        [JsonProperty("ThreeHeaderedPumps")]
        ThreeHeaderedPumps = 5,
        
        [JsonProperty("TwoHeaderedPumps")]
        TwoHeaderedPumps = 6,
    }
    
    public enum HVACTemplate_Plant_ChilledWaterLoop_FluidType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("EthyleneGlycol30")]
        EthyleneGlycol30 = 1,
        
        [JsonProperty("EthyleneGlycol40")]
        EthyleneGlycol40 = 2,
        
        [JsonProperty("EthyleneGlycol50")]
        EthyleneGlycol50 = 3,
        
        [JsonProperty("EthyleneGlycol60")]
        EthyleneGlycol60 = 4,
        
        [JsonProperty("PropyleneGlycol30")]
        PropyleneGlycol30 = 5,
        
        [JsonProperty("PropyleneGlycol40")]
        PropyleneGlycol40 = 6,
        
        [JsonProperty("PropyleneGlycol50")]
        PropyleneGlycol50 = 7,
        
        [JsonProperty("PropyleneGlycol60")]
        PropyleneGlycol60 = 8,
        
        [JsonProperty("Water")]
        Water = 9,
    }
    
    public enum HVACTemplate_Plant_ChilledWaterLoop_ChilledWaterLoadDistributionScheme
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Optimal")]
        Optimal = 1,
        
        [JsonProperty("SequentialLoad")]
        SequentialLoad = 2,
        
        [JsonProperty("SequentialUniformPLR")]
        SequentialUniformPLR = 3,
        
        [JsonProperty("UniformLoad")]
        UniformLoad = 4,
        
        [JsonProperty("UniformPLR")]
        UniformPLR = 5,
    }
    
    public enum HVACTemplate_Plant_ChilledWaterLoop_CondenserWaterLoadDistributionScheme
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Optimal")]
        Optimal = 1,
        
        [JsonProperty("SequentialLoad")]
        SequentialLoad = 2,
        
        [JsonProperty("SequentialUniformPLR")]
        SequentialUniformPLR = 3,
        
        [JsonProperty("UniformLoad")]
        UniformLoad = 4,
        
        [JsonProperty("UniformPLR")]
        UniformPLR = 5,
    }
    
    [Description("This object adds a chiller to an HVACTemplate:Plant:ChilledWaterLoop.")]
    [JsonObject("HVACTemplate:Plant:Chiller")]
    public class HVACTemplate_Plant_Chiller : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("chiller_type")]
public HVACTemplate_Plant_Chiller_ChillerType ChillerType { get; set; } = (HVACTemplate_Plant_Chiller_ChillerType)Enum.Parse(typeof(HVACTemplate_Plant_Chiller_ChillerType), "DistrictChilledWater");
        

[JsonProperty("capacity")]
public string Capacity { get; set; } = (System.String)"Autosize";
        

[Description("Not applicable if Chiller Type is DistrictChilledWater Electric Reciprocating Chi" +
    "ller")]
[JsonProperty("nominal_cop")]
public System.Nullable<float> NominalCop { get; set; } = null;
        

[Description("Not applicable if Chiller Type is DistrictChilledWater")]
[JsonProperty("condenser_type")]
public HVACTemplate_Plant_Chiller_CondenserType CondenserType { get; set; } = (HVACTemplate_Plant_Chiller_CondenserType)Enum.Parse(typeof(HVACTemplate_Plant_Chiller_CondenserType), "WaterCooled");
        

[Description("If Chiller Plant Operation Scheme Type=Default in HVACTemplate:Plant:ChilledWater" +
    "Loop, then equipment operates in Priority order, 1, 2, 3, etc.")]
[JsonProperty("priority")]
public string Priority { get; set; } = "";
        

[Description("Multiplies the autosized capacity and flow rates")]
[JsonProperty("sizing_factor")]
public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Part load ratio below which the chiller starts cycling on/off to meet the load. M" +
    "ust be less than or equal to Maximum Part Load Ratio.")]
[JsonProperty("minimum_part_load_ratio")]
public System.Nullable<float> MinimumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Maximum allowable part load ratio. Must be greater than or equal to Minimum Part " +
    "Load Ratio.")]
[JsonProperty("maximum_part_load_ratio")]
public System.Nullable<float> MaximumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Optimum part load ratio where the chiller is most efficient. Must be greater than" +
    " or equal to the Minimum Part Load Ratio and less than or equal to the Maximum P" +
    "art Load Ratio.")]
[JsonProperty("optimum_part_load_ratio")]
public System.Nullable<float> OptimumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Part load ratio where the chiller can no longer unload and false loading begins. " +
    "Minimum unloading ratio must be greater than or equal to the Minimum Part Load R" +
    "atio and less than or equal to the Maximum Part Load Ratio.")]
[JsonProperty("minimum_unloading_ratio")]
public System.Nullable<float> MinimumUnloadingRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.25", CultureInfo.InvariantCulture);
        

[JsonProperty("leaving_chilled_water_lower_temperature_limit")]
public System.Nullable<float> LeavingChilledWaterLowerTemperatureLimit { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
    }
    
    public enum HVACTemplate_Plant_Chiller_ChillerType
    {
        
        [JsonProperty("DistrictChilledWater")]
        DistrictChilledWater = 0,
        
        [JsonProperty("ElectricCentrifugalChiller")]
        ElectricCentrifugalChiller = 1,
        
        [JsonProperty("ElectricReciprocatingChiller")]
        ElectricReciprocatingChiller = 2,
        
        [JsonProperty("ElectricScrewChiller")]
        ElectricScrewChiller = 3,
    }
    
    public enum HVACTemplate_Plant_Chiller_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCooled")]
        AirCooled = 1,
        
        [JsonProperty("EvaporativelyCooled")]
        EvaporativelyCooled = 2,
        
        [JsonProperty("WaterCooled")]
        WaterCooled = 3,
    }
    
    [Description("This object references a detailed chiller object and adds it to an HVACTemplate:P" +
        "lant:ChilledWaterLoop. The user must create a complete detailed chiller object w" +
        "ith all required curve or performance objects.")]
    [JsonObject("HVACTemplate:Plant:Chiller:ObjectReference")]
    public class HVACTemplate_Plant_Chiller_ObjectReference : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("chiller_object_type")]
public HVACTemplate_Plant_Chiller_ObjectReference_ChillerObjectType ChillerObjectType { get; set; } = (HVACTemplate_Plant_Chiller_ObjectReference_ChillerObjectType)Enum.Parse(typeof(HVACTemplate_Plant_Chiller_ObjectReference_ChillerObjectType), "Empty");
        

[Description("The name of the detailed chiller object.")]
[JsonProperty("chiller_name")]
public string ChillerName { get; set; } = "";
        

[Description("If Chiller Plant Operation Scheme Type=Default in HVACTemplate:Plant:ChilledWater" +
    "Loop, then equipment operates in Priority order, 1, 2, 3, etc.")]
[JsonProperty("priority")]
public System.Nullable<float> Priority { get; set; } = null;
    }
    
    public enum HVACTemplate_Plant_Chiller_ObjectReference_ChillerObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Chiller:Electric:EIR")]
        ChillerElectricEIR = 1,
        
        [JsonProperty("Chiller:Electric:ReformulatedEIR")]
        ChillerElectricReformulatedEIR = 2,
    }
    
    [Description("This object adds a cooling tower to an HVACTemplate:Plant:ChilledWaterLoop or Mix" +
        "edWaterLoop.")]
    [JsonObject("HVACTemplate:Plant:Tower")]
    public class HVACTemplate_Plant_Tower : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("tower_type")]
public HVACTemplate_Plant_Tower_TowerType TowerType { get; set; } = (HVACTemplate_Plant_Tower_TowerType)Enum.Parse(typeof(HVACTemplate_Plant_Tower_TowerType), "SingleSpeed");
        

[Description(@"Applicable for tower type SingleSpeed and TwoSpeed Nominal tower capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature, with the tower fan operating at high speed. Design water flow rate assumed to be 5.382E-8 m3/s per watt(3 gpm/ton). Nominal tower capacity times (1.25) gives the actual tower heat rejection at these operating conditions.")]
[JsonProperty("high_speed_nominal_capacity")]
public string HighSpeedNominalCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Applicable for tower type SingleSpeed and TwoSpeed")]
[JsonProperty("high_speed_fan_power")]
public string HighSpeedFanPower { get; set; } = (System.String)"Autosize";
        

[Description(@"Applicable only for Tower Type TwoSpeed Nominal tower capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature, with the tower fan operating at low speed. Design water flow rate assumed to be 5.382E-8 m3/s per watt of tower high-speed nominal capacity (3 gpm/ton). Nominal tower capacity times (1.25) gives the actual tower heat rejection at these operating conditions.")]
[JsonProperty("low_speed_nominal_capacity")]
public string LowSpeedNominalCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Applicable only for Tower Type TwoSpeed")]
[JsonProperty("low_speed_fan_power")]
public string LowSpeedFanPower { get; set; } = (System.String)"Autosize";
        

[Description(@"Applicable for Tower Type SingleSpeed and TwoSpeed Tower capacity in free convection regime with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt of tower high-speed nominal capacity (3 gpm/ton). Tower free convection capacity times (1.25) gives the actual tower heat rejection at these operating conditions.")]
[JsonProperty("free_convection_capacity")]
public string FreeConvectionCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Applicable for all Tower Types If Condenser Plant Operation Scheme Type=Default i" +
    "n HVACTemplate:Plant:ChilledWaterLoop, then equipment operates in Priority order" +
    ", 1, 2, 3, etc.")]
[JsonProperty("priority")]
public string Priority { get; set; } = "";
        

[Description("Multiplies the autosized capacity and flow rates")]
[JsonProperty("sizing_factor")]
public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Specifies if this tower serves a template chilled water loop or mixed water loop " +
    "If left blank, will serve a chilled water loop if present, or a mixed water loop" +
    " (if no chilled water loop is present).")]
[JsonProperty("template_plant_loop_type")]
public HVACTemplate_Plant_Tower_TemplatePlantLoopType TemplatePlantLoopType { get; set; } = (HVACTemplate_Plant_Tower_TemplatePlantLoopType)Enum.Parse(typeof(HVACTemplate_Plant_Tower_TemplatePlantLoopType), "ChilledWater");
    }
    
    public enum HVACTemplate_Plant_Tower_TowerType
    {
        
        [JsonProperty("SingleSpeed")]
        SingleSpeed = 0,
        
        [JsonProperty("TwoSpeed")]
        TwoSpeed = 1,
    }
    
    public enum HVACTemplate_Plant_Tower_TemplatePlantLoopType
    {
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 0,
        
        [JsonProperty("MixedWater")]
        MixedWater = 1,
    }
    
    [Description("This object references a detailed cooling tower object and adds it to an HVACTemp" +
        "late:Plant:ChilledWaterLoop or MixedWaterLoop. The user must create a complete d" +
        "etailed cooling tower object with all required curve or performance objects.")]
    [JsonObject("HVACTemplate:Plant:Tower:ObjectReference")]
    public class HVACTemplate_Plant_Tower_ObjectReference : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("cooling_tower_object_type")]
public HVACTemplate_Plant_Tower_ObjectReference_CoolingTowerObjectType CoolingTowerObjectType { get; set; } = (HVACTemplate_Plant_Tower_ObjectReference_CoolingTowerObjectType)Enum.Parse(typeof(HVACTemplate_Plant_Tower_ObjectReference_CoolingTowerObjectType), "Empty");
        

[Description("The name of the detailed cooling tower object.")]
[JsonProperty("cooling_tower_name")]
public string CoolingTowerName { get; set; } = "";
        

[Description("If Condenser Plant Operation Scheme Type=Default in HVACTemplate:Plant:ChilledWat" +
    "erLoop or MixedWaterLoop, then equipment operates in Priority order, 1, 2, 3, et" +
    "c.")]
[JsonProperty("priority")]
public System.Nullable<float> Priority { get; set; } = null;
        

[Description("Specifies if this tower serves a template chilled water loop or mixed water loop " +
    "If left blank, will serve a chilled water loop if present, or a mixed water loop" +
    " (if no chilled water loop is present).")]
[JsonProperty("template_plant_loop_type")]
public HVACTemplate_Plant_Tower_ObjectReference_TemplatePlantLoopType TemplatePlantLoopType { get; set; } = (HVACTemplate_Plant_Tower_ObjectReference_TemplatePlantLoopType)Enum.Parse(typeof(HVACTemplate_Plant_Tower_ObjectReference_TemplatePlantLoopType), "ChilledWater");
    }
    
    public enum HVACTemplate_Plant_Tower_ObjectReference_CoolingTowerObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CoolingTower:SingleSpeed")]
        CoolingTowerSingleSpeed = 1,
        
        [JsonProperty("CoolingTower:TwoSpeed")]
        CoolingTowerTwoSpeed = 2,
        
        [JsonProperty("CoolingTower:VariableSpeed")]
        CoolingTowerVariableSpeed = 3,
    }
    
    public enum HVACTemplate_Plant_Tower_ObjectReference_TemplatePlantLoopType
    {
        
        [JsonProperty("ChilledWater")]
        ChilledWater = 0,
        
        [JsonProperty("MixedWater")]
        MixedWater = 1,
    }
    
    [Description("Plant loop to serve all HVACTemplate hot water coils and boilers.")]
    [JsonObject("HVACTemplate:Plant:HotWaterLoop")]
    public class HVACTemplate_Plant_HotWaterLoop : BHoMObject, IEnergyPlusClass
    {
        

[Description("If blank, always available")]
[JsonProperty("pump_schedule_name")]
public string PumpScheduleName { get; set; } = "";
        

[JsonProperty("pump_control_type")]
public HVACTemplate_Plant_HotWaterLoop_PumpControlType PumpControlType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_PumpControlType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_PumpControlType), "Intermittent");
        

[Description("Default operation type makes all equipment available at all times operating in or" +
    "der of Priority specified in HVACTemplate:Plant:Boiler objects.")]
[JsonProperty("hot_water_plant_operation_scheme_type")]
public HVACTemplate_Plant_HotWaterLoop_HotWaterPlantOperationSchemeType HotWaterPlantOperationSchemeType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_HotWaterPlantOperationSchemeType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_HotWaterPlantOperationSchemeType), "Default");
        

[Description("Name of a PlantEquipmentOperationSchemes object Ignored if Plant Operation Scheme" +
    " Type = Default")]
[JsonProperty("hot_water_plant_equipment_operation_schemes_name")]
public string HotWaterPlantEquipmentOperationSchemesName { get; set; } = "";
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("hot_water_setpoint_schedule_name")]
public string HotWaterSetpointScheduleName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Setpoint Schedule Name is specifie" +
    "d.")]
[JsonProperty("hot_water_design_setpoint")]
public System.Nullable<float> HotWaterDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("82", CultureInfo.InvariantCulture);
        

[Description("VariableFlow - variable flow to boilers and coils, excess bypassed ConstantFlow -" +
    " constant flow to boilers and coils, excess bypassed")]
[JsonProperty("hot_water_pump_configuration")]
public HVACTemplate_Plant_HotWaterLoop_HotWaterPumpConfiguration HotWaterPumpConfiguration { get; set; } = (HVACTemplate_Plant_HotWaterLoop_HotWaterPumpConfiguration)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_HotWaterPumpConfiguration), "ConstantFlow");
        

[Description("Default head is 60 feet H2O")]
[JsonProperty("hot_water_pump_rated_head")]
public System.Nullable<float> HotWaterPumpRatedHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

[Description("Overrides Hot Water Setpoint Schedule Name")]
[JsonProperty("hot_water_setpoint_reset_type")]
public HVACTemplate_Plant_HotWaterLoop_HotWaterSetpointResetType HotWaterSetpointResetType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_HotWaterSetpointResetType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_HotWaterSetpointResetType), "None");
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("hot_water_setpoint_at_outdoor_dry_bulb_low")]
public System.Nullable<float> HotWaterSetpointAtOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("82.2", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("hot_water_reset_outdoor_dry_bulb_low")]
public System.Nullable<float> HotWaterResetOutdoorDryBulbLow { get; set; } = (System.Nullable<float>)Single.Parse("-6.7", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("hot_water_setpoint_at_outdoor_dry_bulb_high")]
public System.Nullable<float> HotWaterSetpointAtOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("65.6", CultureInfo.InvariantCulture);
        

[Description("Applicable only for OutdoorAirTemperatureReset control.")]
[JsonProperty("hot_water_reset_outdoor_dry_bulb_high")]
public System.Nullable<float> HotWaterResetOutdoorDryBulbHigh { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("Describes the type of pump configuration used for the hot water loop.")]
[JsonProperty("hot_water_pump_type")]
public HVACTemplate_Plant_HotWaterLoop_HotWaterPumpType HotWaterPumpType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_HotWaterPumpType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_HotWaterPumpType), "SinglePump");
        

[Description("Determines if a supply side bypass pipe is present in the hot water loop.")]
[JsonProperty("supply_side_bypass_pipe")]
public EmptyNoYes SupplySideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("Determines if a demand side bypass pipe is present in the hot water loop.")]
[JsonProperty("demand_side_bypass_pipe")]
public EmptyNoYes DemandSideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("fluid_type")]
public HVACTemplate_Plant_HotWaterLoop_FluidType FluidType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_FluidType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_FluidType), "Water");
        

[Description("The temperature difference used in sizing the loop flow rate.")]
[JsonProperty("loop_design_delta_temperature")]
public System.Nullable<float> LoopDesignDeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("11", CultureInfo.InvariantCulture);
        

[Description("The maximum outdoor dry-bulb temperature that the hot water loops operate. Leave " +
    "blank for no limit.")]
[JsonProperty("maximum_outdoor_dry_bulb_temperature")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperature { get; set; } = null;
        

[JsonProperty("load_distribution_scheme")]
public HVACTemplate_Plant_HotWaterLoop_LoadDistributionScheme LoadDistributionScheme { get; set; } = (HVACTemplate_Plant_HotWaterLoop_LoadDistributionScheme)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_LoadDistributionScheme), "SequentialLoad");
    }
    
    public enum HVACTemplate_Plant_HotWaterLoop_PumpControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Continuous")]
        Continuous = 1,
        
        [JsonProperty("Intermittent")]
        Intermittent = 2,
    }
    
    public enum HVACTemplate_Plant_HotWaterLoop_HotWaterPlantOperationSchemeType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Default")]
        Default = 1,
        
        [JsonProperty("UserDefined")]
        UserDefined = 2,
    }
    
    public enum HVACTemplate_Plant_HotWaterLoop_HotWaterPumpConfiguration
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantFlow")]
        ConstantFlow = 1,
        
        [JsonProperty("VariableFlow")]
        VariableFlow = 2,
    }
    
    public enum HVACTemplate_Plant_HotWaterLoop_HotWaterSetpointResetType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("OutdoorAirTemperatureReset")]
        OutdoorAirTemperatureReset = 2,
    }
    
    public enum HVACTemplate_Plant_HotWaterLoop_HotWaterPumpType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FiveHeaderedPumps")]
        FiveHeaderedPumps = 1,
        
        [JsonProperty("FourHeaderedPumps")]
        FourHeaderedPumps = 2,
        
        [JsonProperty("PumpPerBoiler")]
        PumpPerBoiler = 3,
        
        [JsonProperty("SinglePump")]
        SinglePump = 4,
        
        [JsonProperty("ThreeHeaderedPumps")]
        ThreeHeaderedPumps = 5,
        
        [JsonProperty("TwoHeaderedPumps")]
        TwoHeaderedPumps = 6,
    }
    
    public enum HVACTemplate_Plant_HotWaterLoop_FluidType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("EthyleneGlycol30")]
        EthyleneGlycol30 = 1,
        
        [JsonProperty("EthyleneGlycol40")]
        EthyleneGlycol40 = 2,
        
        [JsonProperty("EthyleneGlycol50")]
        EthyleneGlycol50 = 3,
        
        [JsonProperty("EthyleneGlycol60")]
        EthyleneGlycol60 = 4,
        
        [JsonProperty("PropyleneGlycol30")]
        PropyleneGlycol30 = 5,
        
        [JsonProperty("PropyleneGlycol40")]
        PropyleneGlycol40 = 6,
        
        [JsonProperty("PropyleneGlycol50")]
        PropyleneGlycol50 = 7,
        
        [JsonProperty("PropyleneGlycol60")]
        PropyleneGlycol60 = 8,
        
        [JsonProperty("Water")]
        Water = 9,
    }
    
    public enum HVACTemplate_Plant_HotWaterLoop_LoadDistributionScheme
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Optimal")]
        Optimal = 1,
        
        [JsonProperty("SequentialLoad")]
        SequentialLoad = 2,
        
        [JsonProperty("SequentialUniformPLR")]
        SequentialUniformPLR = 3,
        
        [JsonProperty("UniformLoad")]
        UniformLoad = 4,
        
        [JsonProperty("UniformPLR")]
        UniformPLR = 5,
    }
    
    [Description("This object adds a boiler to an HVACTemplate:Plant:HotWaterLoop or MixedWaterLoop" +
        ".")]
    [JsonObject("HVACTemplate:Plant:Boiler")]
    public class HVACTemplate_Plant_Boiler : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("boiler_type")]
public HVACTemplate_Plant_Boiler_BoilerType BoilerType { get; set; } = (HVACTemplate_Plant_Boiler_BoilerType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_BoilerType), "CondensingHotWaterBoiler");
        

[JsonProperty("capacity")]
public string Capacity { get; set; } = (System.String)"Autosize";
        

[Description("Not applicable  if Boiler Type is DistrictHotWater")]
[JsonProperty("efficiency")]
public System.Nullable<float> Efficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[Description("Not applicable  if Boiler Type is DistrictHotWater")]
[JsonProperty("fuel_type")]
public HVACTemplate_Plant_Boiler_FuelType FuelType { get; set; } = (HVACTemplate_Plant_Boiler_FuelType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_FuelType), "Coal");
        

[Description("If Hot Water Plant Operation Scheme Type=Default in HVACTemplate:Plant:HotWaterLo" +
    "op, then equipment operates in priority order, 1, 2, 3, etc.")]
[JsonProperty("priority")]
public string Priority { get; set; } = "";
        

[Description("Multiplies the autosized capacity and flow rates")]
[JsonProperty("sizing_factor")]
public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_part_load_ratio")]
public System.Nullable<float> MinimumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_part_load_ratio")]
public System.Nullable<float> MaximumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("1.1", CultureInfo.InvariantCulture);
        

[JsonProperty("optimum_part_load_ratio")]
public System.Nullable<float> OptimumPartLoadRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("water_outlet_upper_temperature_limit")]
public System.Nullable<float> WaterOutletUpperTemperatureLimit { get; set; } = (System.Nullable<float>)Single.Parse("100", CultureInfo.InvariantCulture);
        

[Description("Specifies if this boiler serves a template hot water loop or mixed water loop If " +
    "left blank, will serve a hot water loop if present, or a mixed water loop (if no" +
    " hot water loop is present).")]
[JsonProperty("template_plant_loop_type")]
public HVACTemplate_Plant_Boiler_TemplatePlantLoopType TemplatePlantLoopType { get; set; } = (HVACTemplate_Plant_Boiler_TemplatePlantLoopType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_TemplatePlantLoopType), "HotWater");
    }
    
    public enum HVACTemplate_Plant_Boiler_BoilerType
    {
        
        [JsonProperty("CondensingHotWaterBoiler")]
        CondensingHotWaterBoiler = 0,
        
        [JsonProperty("DistrictHotWater")]
        DistrictHotWater = 1,
        
        [JsonProperty("HotWaterBoiler")]
        HotWaterBoiler = 2,
    }
    
    public enum HVACTemplate_Plant_Boiler_FuelType
    {
        
        [JsonProperty("Coal")]
        Coal = 0,
        
        [JsonProperty("Diesel")]
        Diesel = 1,
        
        [JsonProperty("Electricity")]
        Electricity = 2,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 3,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 4,
        
        [JsonProperty("Gasoline")]
        Gasoline = 5,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 6,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 7,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 8,
        
        [JsonProperty("Propane")]
        Propane = 9,
    }
    
    public enum HVACTemplate_Plant_Boiler_TemplatePlantLoopType
    {
        
        [JsonProperty("HotWater")]
        HotWater = 0,
        
        [JsonProperty("MixedWater")]
        MixedWater = 1,
    }
    
    [Description("This object references a detailed boiler object and adds it to an HVACTemplate:Pl" +
        "ant:HotWaterLoop or MixedWaterLoop. The user must create a complete detailed boi" +
        "ler object with all required curve or performance objects.")]
    [JsonObject("HVACTemplate:Plant:Boiler:ObjectReference")]
    public class HVACTemplate_Plant_Boiler_ObjectReference : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("boiler_object_type")]
public HVACTemplate_Plant_Boiler_ObjectReference_BoilerObjectType BoilerObjectType { get; set; } = (HVACTemplate_Plant_Boiler_ObjectReference_BoilerObjectType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_ObjectReference_BoilerObjectType), "Empty");
        

[Description("The name of the detailed boiler object.")]
[JsonProperty("boiler_name")]
public string BoilerName { get; set; } = "";
        

[Description("If Hot Water Plant Operation Scheme Type=Default in HVACTemplate:Plant:HotWaterLo" +
    "op or MixedWaterLoop, then equipment operates in Priority order, 1, 2, 3, etc.")]
[JsonProperty("priority")]
public System.Nullable<float> Priority { get; set; } = null;
        

[Description("Specifies if this boiler serves a template hot water loop or mixed water loop If " +
    "left blank, will serve a hot water loop if present, or a mixed water loop (if no" +
    " hot water loop is present).")]
[JsonProperty("template_plant_loop_type")]
public HVACTemplate_Plant_Boiler_ObjectReference_TemplatePlantLoopType TemplatePlantLoopType { get; set; } = (HVACTemplate_Plant_Boiler_ObjectReference_TemplatePlantLoopType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_ObjectReference_TemplatePlantLoopType), "HotWater");
    }
    
    public enum HVACTemplate_Plant_Boiler_ObjectReference_BoilerObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Boiler:HotWater")]
        BoilerHotWater = 1,
    }
    
    public enum HVACTemplate_Plant_Boiler_ObjectReference_TemplatePlantLoopType
    {
        
        [JsonProperty("HotWater")]
        HotWater = 0,
        
        [JsonProperty("MixedWater")]
        MixedWater = 1,
    }
    
    [Description("Central plant loop portion of a water source heat pump system.")]
    [JsonObject("HVACTemplate:Plant:MixedWaterLoop")]
    public class HVACTemplate_Plant_MixedWaterLoop : BHoMObject, IEnergyPlusClass
    {
        

[Description("If blank, always available Applies to both chilled water and condenser loop pumps" +
    "")]
[JsonProperty("pump_schedule_name")]
public string PumpScheduleName { get; set; } = "";
        

[Description("Applies to both chilled water and condenser loop pumps")]
[JsonProperty("pump_control_type")]
public HVACTemplate_Plant_MixedWaterLoop_PumpControlType PumpControlType { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_PumpControlType)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_PumpControlType), "Intermittent");
        

[Description("Default operation type makes all equipment available at all times operating in or" +
    "der of Priority specified in HVACTemplate:Plant:Boiler and HVACTemplate:Plant:To" +
    "wer objects.")]
[JsonProperty("operation_scheme_type")]
public HVACTemplate_Plant_MixedWaterLoop_OperationSchemeType OperationSchemeType { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_OperationSchemeType)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_OperationSchemeType), "Default");
        

[Description("Name of a PlantEquipmentOperationSchemes object Ignored if Plant Operation Scheme" +
    " Type = Default")]
[JsonProperty("equipment_operation_schemes_name")]
public string EquipmentOperationSchemesName { get; set; } = "";
        

[Description("Leave blank if constant setpoint")]
[JsonProperty("high_temperature_setpoint_schedule_name")]
public string HighTemperatureSetpointScheduleName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Setpoint Schedule Name is specifie" +
    "d.")]
[JsonProperty("high_temperature_design_setpoint")]
public System.Nullable<float> HighTemperatureDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("33", CultureInfo.InvariantCulture);
        

[Description("Leave blank if constant setpoint May be left blank if not serving any water coole" +
    "d chillers")]
[JsonProperty("low_temperature_setpoint_schedule_name")]
public string LowTemperatureSetpointScheduleName { get; set; } = "";
        

[Description("Used for sizing and as constant setpoint if no Condenser Water Setpoint Schedule " +
    "Name is specified. May be left blank if not serving any water cooled chillers")]
[JsonProperty("low_temperature_design_setpoint")]
public System.Nullable<float> LowTemperatureDesignSetpoint { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

[Description("VariableFlow - variable flow to boilers and coils, excess bypassed ConstantFlow -" +
    " constant flow to boilers and coils, excess bypassed")]
[JsonProperty("water_pump_configuration")]
public HVACTemplate_Plant_MixedWaterLoop_WaterPumpConfiguration WaterPumpConfiguration { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_WaterPumpConfiguration)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_WaterPumpConfiguration), "ConstantFlow");
        

[Description("May be left blank if not serving any water cooled chillers default head is 60 fee" +
    "t H2O")]
[JsonProperty("water_pump_rated_head")]
public System.Nullable<float> WaterPumpRatedHead { get; set; } = (System.Nullable<float>)Single.Parse("179352", CultureInfo.InvariantCulture);
        

[Description("Describes the type of pump configuration used for the mixed water loop.")]
[JsonProperty("water_pump_type")]
public HVACTemplate_Plant_MixedWaterLoop_WaterPumpType WaterPumpType { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_WaterPumpType)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_WaterPumpType), "SinglePump");
        

[Description("Determines if a supply side bypass pipe is present in the hot water loop.")]
[JsonProperty("supply_side_bypass_pipe")]
public EmptyNoYes SupplySideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("Determines if a demand side bypass pipe is present in the hot water loop.")]
[JsonProperty("demand_side_bypass_pipe")]
public EmptyNoYes DemandSideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[JsonProperty("fluid_type")]
public HVACTemplate_Plant_MixedWaterLoop_FluidType FluidType { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_FluidType)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_FluidType), "Water");
        

[Description("The temperature difference used in sizing the loop flow rate.")]
[JsonProperty("loop_design_delta_temperature")]
public System.Nullable<float> LoopDesignDeltaTemperature { get; set; } = (System.Nullable<float>)Single.Parse("5.6", CultureInfo.InvariantCulture);
        

[JsonProperty("load_distribution_scheme")]
public HVACTemplate_Plant_MixedWaterLoop_LoadDistributionScheme LoadDistributionScheme { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_LoadDistributionScheme)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_LoadDistributionScheme), "SequentialLoad");
    }
    
    public enum HVACTemplate_Plant_MixedWaterLoop_PumpControlType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Continuous")]
        Continuous = 1,
        
        [JsonProperty("Intermittent")]
        Intermittent = 2,
    }
    
    public enum HVACTemplate_Plant_MixedWaterLoop_OperationSchemeType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Default")]
        Default = 1,
        
        [JsonProperty("UserDefined")]
        UserDefined = 2,
    }
    
    public enum HVACTemplate_Plant_MixedWaterLoop_WaterPumpConfiguration
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConstantFlow")]
        ConstantFlow = 1,
        
        [JsonProperty("VariableFlow")]
        VariableFlow = 2,
    }
    
    public enum HVACTemplate_Plant_MixedWaterLoop_WaterPumpType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("FiveHeaderedPumps")]
        FiveHeaderedPumps = 1,
        
        [JsonProperty("FourHeaderedPumps")]
        FourHeaderedPumps = 2,
        
        [JsonProperty("PumpPerTowerOrBoiler")]
        PumpPerTowerOrBoiler = 3,
        
        [JsonProperty("SinglePump")]
        SinglePump = 4,
        
        [JsonProperty("ThreeHeaderedPumps")]
        ThreeHeaderedPumps = 5,
        
        [JsonProperty("TwoHeaderedPumps")]
        TwoHeaderedPumps = 6,
    }
    
    public enum HVACTemplate_Plant_MixedWaterLoop_FluidType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("EthyleneGlycol30")]
        EthyleneGlycol30 = 1,
        
        [JsonProperty("EthyleneGlycol40")]
        EthyleneGlycol40 = 2,
        
        [JsonProperty("EthyleneGlycol50")]
        EthyleneGlycol50 = 3,
        
        [JsonProperty("EthyleneGlycol60")]
        EthyleneGlycol60 = 4,
        
        [JsonProperty("PropyleneGlycol30")]
        PropyleneGlycol30 = 5,
        
        [JsonProperty("PropyleneGlycol40")]
        PropyleneGlycol40 = 6,
        
        [JsonProperty("PropyleneGlycol50")]
        PropyleneGlycol50 = 7,
        
        [JsonProperty("PropyleneGlycol60")]
        PropyleneGlycol60 = 8,
        
        [JsonProperty("Water")]
        Water = 9,
    }
    
    public enum HVACTemplate_Plant_MixedWaterLoop_LoadDistributionScheme
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Optimal")]
        Optimal = 1,
        
        [JsonProperty("SequentialLoad")]
        SequentialLoad = 2,
        
        [JsonProperty("SequentialUniformPLR")]
        SequentialUniformPLR = 3,
        
        [JsonProperty("UniformLoad")]
        UniformLoad = 4,
        
        [JsonProperty("UniformPLR")]
        UniformPLR = 5,
    }
}
