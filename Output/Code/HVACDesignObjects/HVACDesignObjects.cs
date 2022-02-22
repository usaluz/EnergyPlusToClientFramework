namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
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
    
    
    [Description("This object is used to describe general outdoor air requirements which are refere" +
        "nced by other objects.")]
    public class DesignSpecification_OutdoorAir : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Flow/Person => Outdoor Air Flow per Person * Occupancy = Design Flow Rate, Flow/Area => Outdoor Air Flow per Zone Floor Area * Zone Floor Area = Design Flow Rate, Flow/Zone => Outdoor Air Flow per Zone = Design Flow Rate, AirChanges/Hour => Outdoor Air Flow Air Changes per Hour * Zone Volume adjusted for m3/s = Design Flow Rate")]
[JsonProperty("outdoor_air_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DesignSpecification_OutdoorAir_OutdoorAirMethod OutdoorAirMethod { get; set; } = (DesignSpecification_OutdoorAir_OutdoorAirMethod)Enum.Parse(typeof(DesignSpecification_OutdoorAir_OutdoorAirMethod), "Empty");
        

[Description(@"0.00944 m3/s is equivalent to 20 cfm per person This input is only used if the field Outdoor Air Method is Flow/Person, Sum, or Maximum For sizing, the design number of occupants is used. For outdoor air flow control, the use of design occupants or current occupants depends on the component and DCV options. AirTerminal:SingleDuct:VAV:NoReheat, AirTerminal:SingleDuct:VAV:Reheat use the DCV flag specified in Controller:MechanicalVentilation AirTerminal:DualDuct:VAV:OutdoorAir and ZoneHVAC:IdealLoadsAirSystem have their own DCV control input. ZoneHVAC:FourPipeFanCoil always uses current occupants.")]
[JsonProperty("outdoor_air_flow_per_person")]
public System.Nullable<float> OutdoorAirFlowPerPerson { get; set; } = (System.Nullable<float>)Single.Parse("0.00944", CultureInfo.InvariantCulture);
        

[Description("This input is only used if the field Outdoor Air Method is Flow/Area, Sum, or Max" +
    "imum")]
[JsonProperty("outdoor_air_flow_per_zone_floor_area")]
public System.Nullable<float> OutdoorAirFlowPerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is only used if the field Outdoor Air Method is Flow/Zone, Sum, or Max" +
    "imum")]
[JsonProperty("outdoor_air_flow_per_zone")]
public System.Nullable<float> OutdoorAirFlowPerZone { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This input is only used if the field Outdoor Air Method is AirChanges/Hour, Sum, " +
    "or Maximum")]
[JsonProperty("outdoor_air_flow_air_changes_per_hour")]
public System.Nullable<float> OutdoorAirFlowAirChangesPerHour { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Schedule values are multiplied by the Outdoor Air Flow rate calculated using the previous four inputs. Schedule values are limited to 0 to 1. If left blank, the schedule defaults to 1.0. This schedule is ignored during sizing. All other components which reference this design specification use the current schedule value to calculate the current outdoor air requirement. This includes AirTerminal:SingleDuct:VAV:NoReheat, AirTerminal:SingleDuct:VAV:Reheat, AirTerminal:DualDuct:VAV:OutdoorAir, ZoneHVAC:FourPipeFanCoil, and ZoneHVAC:IdealLoadsAirSystem. This schedule will also be applied by Controller:MechanicalVentilation for all System Outdoor Air Methods.")]
[JsonProperty("outdoor_air_schedule_name")]
public string OutdoorAirScheduleName { get; set; } = "";
        

[Description("This input is only used to calculate the minimum outdoor air flow rate when the f" +
    "ield System Outdoor Air Method = ProportionalControlBasedOnDesignOARate in Contr" +
    "oller:MechanicalVentilation.")]
[JsonProperty("proportional_control_minimum_outdoor_air_flow_rate_schedule_name")]
public string ProportionalControlMinimumOutdoorAirFlowRateScheduleName { get; set; } = "";
    }
    
    public enum DesignSpecification_OutdoorAir_OutdoorAirMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AirChanges/Hour")]
        AirChangesHour = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Area")]
        FlowArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Person")]
        FlowPerson = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Zone")]
        FlowZone = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="IndoorAirQualityProcedure")]
        IndoorAirQualityProcedure = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Maximum")]
        Maximum = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="ProportionalControlBasedOnDesignOccupancy")]
        ProportionalControlBasedOnDesignOccupancy = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="ProportionalControlBasedOnOccupancySchedule")]
        ProportionalControlBasedOnOccupancySchedule = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Sum")]
        Sum = 9,
    }
    
    [Description("This object is used to describe zone air distribution in terms of air distributio" +
        "n effectiveness and secondary recirculation fraction. It is referenced by Sizing" +
        ":Zone and Controller:MechanicalVentilation objects")]
    public class DesignSpecification_ZoneAirDistribution : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("zone_air_distribution_effectiveness_in_cooling_mode")]
public System.Nullable<float> ZoneAirDistributionEffectivenessInCoolingMode { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("zone_air_distribution_effectiveness_in_heating_mode")]
public System.Nullable<float> ZoneAirDistributionEffectivenessInHeatingMode { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("optionally used to replace Zone Air Distribution Effectiveness in Cooling and Hea" +
    "ting Mode")]
[JsonProperty("zone_air_distribution_effectiveness_schedule_name")]
public string ZoneAirDistributionEffectivenessScheduleName { get; set; } = "";
        

[JsonProperty("zone_secondary_recirculation_fraction")]
public System.Nullable<float> ZoneSecondaryRecirculationFraction { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_zone_ventilation_efficiency")]
public System.Nullable<float> MinimumZoneVentilationEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description(@"Specifies global heating and cooling sizing factors/ratios. These ratios are applied at the zone level to all of the zone heating and cooling loads and air flow rates. Then these new loads and air flow rates are used to calculate the system level flow rates and capacities and are used in all component sizing calculations. Specifies the width (in load timesteps) of a moving average window which is used to smooth the peak load across more than one timestep.")]
    public class Sizing_Parameters : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("heating_sizing_factor")]
public System.Nullable<float> HeatingSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_sizing_factor")]
public System.Nullable<float> CoolingSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("blank => set the timesteps in averaging window to Number of Timesteps per Hour re" +
    "sulting in a 1 hour averaging window default is number of timesteps for 1 hour a" +
    "veraging window")]
[JsonProperty("timesteps_in_averaging_window")]
public System.Nullable<float> TimestepsInAveragingWindow { get; set; } = null;
    }
    
    [Description(@"Specifies the data needed to perform a zone design air flow calculation. The calculation is done for every sizing period included in the input. The maximum cooling and heating load and cooling, heating, and ventilation air flows are then saved for system level and zone component design calculations.")]
    public class Sizing_Zone : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[JsonProperty("zone_cooling_design_supply_air_temperature_input_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_Zone_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (Sizing_Zone_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(Sizing_Zone_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_cooling_design_supply_air_temperature")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperature { get; set; } = null;
        

[Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
[JsonProperty("zone_cooling_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = null;
        

[JsonProperty("zone_heating_design_supply_air_temperature_input_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_Zone_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (Sizing_Zone_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(Sizing_Zone_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

[Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
    "Supply Air Temperature Input Method = SupplyAirTemperature")]
[JsonProperty("zone_heating_design_supply_air_temperature")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperature { get; set; } = null;
        

[Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
[JsonProperty("zone_heating_design_supply_air_temperature_difference")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = null;
        

[JsonProperty("zone_cooling_design_supply_air_humidity_ratio")]
public System.Nullable<float> ZoneCoolingDesignSupplyAirHumidityRatio { get; set; } = null;
        

[JsonProperty("zone_heating_design_supply_air_humidity_ratio")]
public System.Nullable<float> ZoneHeatingDesignSupplyAirHumidityRatio { get; set; } = null;
        

[JsonProperty("design_specification_outdoor_air_object_name")]
public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

[Description("if blank or zero, global heating sizing factor from Sizing:Parameters is used.")]
[JsonProperty("zone_heating_sizing_factor")]
public System.Nullable<float> ZoneHeatingSizingFactor { get; set; } = null;
        

[Description("if blank or zero, global cooling sizing factor from Sizing:Parameters is used.")]
[JsonProperty("zone_cooling_sizing_factor")]
public System.Nullable<float> ZoneCoolingSizingFactor { get; set; } = null;
        

[JsonProperty("cooling_design_air_flow_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_Zone_CoolingDesignAirFlowMethod CoolingDesignAirFlowMethod { get; set; } = (Sizing_Zone_CoolingDesignAirFlowMethod)Enum.Parse(typeof(Sizing_Zone_CoolingDesignAirFlowMethod), "DesignDay");
        

[Description("This input is used if Cooling Design Air Flow Method is Flow/Zone This value will" +
    " be multiplied by the global or zone sizing factor and by zone multipliers.")]
[JsonProperty("cooling_design_air_flow_rate")]
public System.Nullable<float> CoolingDesignAirFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("default is .15 cfm/ft2 This input is used if Cooling Design Air Flow Method is De" +
    "signDayWithLimit")]
[JsonProperty("cooling_minimum_air_flow_per_zone_floor_area")]
public System.Nullable<float> CoolingMinimumAirFlowPerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0.000762", CultureInfo.InvariantCulture);
        

[Description("This input is used if Cooling Design Air Flow Method is DesignDayWithLimit")]
[JsonProperty("cooling_minimum_air_flow")]
public System.Nullable<float> CoolingMinimumAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("fraction of the Cooling design Air Flow Rate This input is currently used in sizi" +
    "ng the VAV air terminal unit and fan minimum flow rate It does not currently aff" +
    "ect other component autosizing.")]
[JsonProperty("cooling_minimum_air_flow_fraction")]
public System.Nullable<float> CoolingMinimumAirFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[JsonProperty("heating_design_air_flow_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_Zone_HeatingDesignAirFlowMethod HeatingDesignAirFlowMethod { get; set; } = (Sizing_Zone_HeatingDesignAirFlowMethod)Enum.Parse(typeof(Sizing_Zone_HeatingDesignAirFlowMethod), "DesignDay");
        

[Description("This input is used if Heating Design Air Flow Method is Flow/Zone. This value wil" +
    "l be multiplied by the global or zone sizing factor and by zone multipliers.")]
[JsonProperty("heating_design_air_flow_rate")]
public System.Nullable<float> HeatingDesignAirFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("default is .40 cfm/ft2 This field is used to size the heating design flow rate wh" +
    "en Heating Design Air Flow Method = Flow/Zone. This input is used for autosizing" +
    " components when Heating Design Air Flow Method = DesignDayWithLimit.")]
[JsonProperty("heating_maximum_air_flow_per_zone_floor_area")]
public System.Nullable<float> HeatingMaximumAirFlowPerZoneFloorArea { get; set; } = (System.Nullable<float>)Single.Parse("0.002032", CultureInfo.InvariantCulture);
        

[Description("default is 300 cfm This input is used for autosizing components when Heating Desi" +
    "gn Air Flow Method = DesignDayWithLimit.")]
[JsonProperty("heating_maximum_air_flow")]
public System.Nullable<float> HeatingMaximumAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("0.1415762", CultureInfo.InvariantCulture);
        

[Description("fraction of the Heating Design Air Flow Rate This input is used for autosizing co" +
    "mponents when Heating Design Air Flow Method = DesignDayWithLimit.")]
[JsonProperty("heating_maximum_air_flow_fraction")]
public System.Nullable<float> HeatingMaximumAirFlowFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

[JsonProperty("design_specification_zone_air_distribution_object_name")]
public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

[Description("account for effect of dedicated outdoor air system supplying air directly to the " +
    "zone")]
[JsonProperty("account_for_dedicated_outdoor_air_system")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes AccountForDedicatedOutdoorAirSystem { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("1)supply neutral ventilation air; 2)supply neutral dehumidified and reheated vent" +
    "ilation air; 3)supply cold ventilation air")]
[JsonProperty("dedicated_outdoor_air_system_control_strategy")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_Zone_DedicatedOutdoorAirSystemControlStrategy DedicatedOutdoorAirSystemControlStrategy { get; set; } = (Sizing_Zone_DedicatedOutdoorAirSystemControlStrategy)Enum.Parse(typeof(Sizing_Zone_DedicatedOutdoorAirSystemControlStrategy), "NeutralSupplyAir");
        

[JsonProperty("dedicated_outdoor_air_low_setpoint_temperature_for_design")]
public string DedicatedOutdoorAirLowSetpointTemperatureForDesign { get; set; } = (System.String)"Autosize";
        

[JsonProperty("dedicated_outdoor_air_high_setpoint_temperature_for_design")]
public string DedicatedOutdoorAirHighSetpointTemperatureForDesign { get; set; } = (System.String)"Autosize";
    }
    
    public enum Sizing_Zone_ZoneCoolingDesignSupplyAirTemperatureInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    public enum Sizing_Zone_ZoneHeatingDesignSupplyAirTemperatureInputMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplyAirTemperature")]
        SupplyAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureDifference")]
        TemperatureDifference = 2,
    }
    
    public enum Sizing_Zone_CoolingDesignAirFlowMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DesignDay")]
        DesignDay = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DesignDayWithLimit")]
        DesignDayWithLimit = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Zone")]
        FlowZone = 3,
    }
    
    public enum Sizing_Zone_HeatingDesignAirFlowMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DesignDay")]
        DesignDay = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DesignDayWithLimit")]
        DesignDayWithLimit = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/Zone")]
        FlowZone = 3,
    }
    
    public enum Sizing_Zone_DedicatedOutdoorAirSystemControlStrategy
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ColdSupplyAir")]
        ColdSupplyAir = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="NeutralDehumidifiedSupplyAir")]
        NeutralDehumidifiedSupplyAir = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="NeutralSupplyAir")]
        NeutralSupplyAir = 3,
    }
    
    [Description("This object is used to describe general scalable zone HVAC equipment sizing which" +
        " are referenced by other objects.")]
    public class DesignSpecification_ZoneHVAC_Sizing : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Enter the method used to determine the cooling supply air volume flow rate. None is used when a cooling coil is not included in the Zone HVAC Equip or this field may be blank. SupplyAirFlowRate => selected when the magnitude of the supply air volume flow rate is specified. FlowPerFloorArea => selected when the supply air volume flow rate is determined from total floor area served by the Zone HVAC unit and Flow Per Floor Area value specified. FractionOfAutosizedCoolingAirflow => is selected when the supply air volume is determined from a user specified fraction and the autosized cooling supply air flow rate value determined by the simulation. FlowPerCoolingCapacity => is selected when the supply air volume is determined from user specified flow per Cooling Capacity and Cooling Capacity determined by the simulation.")]
[JsonProperty("cooling_supply_air_flow_rate_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DesignSpecification_ZoneHVAC_Sizing_CoolingSupplyAirFlowRateMethod CoolingSupplyAirFlowRateMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_CoolingSupplyAirFlowRateMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_CoolingSupplyAirFlowRateMethod), "SupplyAirFlowRate");
        

[Description("Enter the magnitude of supply air volume flow rate during cooling operation. Requ" +
    "ired field when Cooling Supply Air Flow Rate Method is SupplyAirFlowRate. This f" +
    "ield may be blank if a cooling coil is not included in the Zone HVAC equipment.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public string CoolingSupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the cooling supply air volume flow rate per total conditioned floor area. R" +
    "equired field when Cooling Supply Air Flow Rate Method is FlowPerFloorArea. This" +
    " field may be blank if a cooling coil is not included in the Zone HVAC equipment" +
    ".")]
[JsonProperty("cooling_supply_air_flow_rate_per_floor_area")]
public System.Nullable<float> CoolingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

[Description(@"Enter the supply air volume flow rate as a fraction of the cooling supply air flow rate. Required field when Cooling Supply Air Flow Rate Method is FractionOfAutosizedCoolingAirflow. This field may be blank if a cooling coil is not included in the Zone HVAC equipment.")]
[JsonProperty("cooling_fraction_of_autosized_cooling_supply_air_flow_rate")]
public System.Nullable<float> CoolingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the cooling supply air volume flow rate unit cooling capacity. Required fie" +
    "ld when Cooling Supply Air Flow Rate Method is FlowPerCoolingCapacity. This fiel" +
    "d may be blank if a cooling coil is not included in the Zone HVAC equipment.")]
[JsonProperty("cooling_supply_air_flow_rate_per_unit_cooling_capacity")]
public System.Nullable<float> CoolingSupplyAirFlowRatePerUnitCoolingCapacity { get; set; } = null;
        

[Description(@"Enter the method used to determine the supply air volume flow rate When No Cooling or Heating is Required. None is used when a cooling or heating coil is not included in the Zone HVAC Equipment or this field may be blank. SupplyAirFlowRate => selected when the magnitude of the supply air volume flow rate is specified. FlowPerFloorArea => selected when the supply air volume flow rate is determined from total floor area served by the Zone HVAC unit and Flow Per Floor Area is specified. FractionOfAutosizedCoolingAirflow => is selected when the supply air volume is determined from a user specified fraction and the Autosized cooling supply air flow rate value determined by the simulation. FractionOfAutosizedHeatingAirflow => is selected when the supply air volume is determined from a user specified fraction and the Autosized heating supply air flow rate value determined by the simulation.")]
[JsonProperty("no_load_supply_air_flow_rate_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DesignSpecification_ZoneHVAC_Sizing_NoLoadSupplyAirFlowRateMethod NoLoadSupplyAirFlowRateMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_NoLoadSupplyAirFlowRateMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_NoLoadSupplyAirFlowRateMethod), "SupplyAirFlowRate");
        

[Description("Enter the magnitude of the supply air volume flow rate during when no cooling or " +
    "heating is required. Required field when No Load Supply Air Flow Rate Method is " +
    "SupplyAirFlowRate.")]
[JsonProperty("no_load_supply_air_flow_rate")]
public string NoLoadSupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the supply air volume flow rate per total floor area. Required field when N" +
    "o Load Supply Air Flow Rate Method is FlowPerFloorArea.")]
[JsonProperty("no_load_supply_air_flow_rate_per_floor_area")]
public System.Nullable<float> NoLoadSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flo" +
    "w rate. Required field when No Load Supply Air Flow Rate Method is FractionOfAut" +
    "osizedCoolingAirflow.")]
[JsonProperty("no_load_fraction_of_cooling_supply_air_flow_rate")]
public System.Nullable<float> NoLoadFractionOfCoolingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the heating supply air flo" +
    "w rate. Required field when No Load Supply Air Flow Rate Method is FractionOfAut" +
    "osizedHeatingAirflow.")]
[JsonProperty("no_load_fraction_of_heating_supply_air_flow_rate")]
public System.Nullable<float> NoLoadFractionOfHeatingSupplyAirFlowRate { get; set; } = null;
        

[Description(@"Enter the method used to determine the heating supply air volume flow rate. None is used when a heating coil is not included in the Zone HVAC Equipment or this field may be blank. SupplyAirFlowRate => selected when the magnitude of the heating supply air volume flow rate is specified. FlowPerFloorArea => selected when the supply air volume flow rate is determined from total floor area served by a Zone HVAC unit and user specified value of Flow Per Floor Area. FractionOfAutosizedHeatingAirflow => is selected when the supply air volume is determined from a user specified fraction and the Autosized heating supply air flow rate value determined by the simulation. FlowPerHeatingCapacity => is selected when the supply air volume is determined from user specified flow per Heating Capacity and Heating Capacity determined by the simulation.")]
[JsonProperty("heating_supply_air_flow_rate_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DesignSpecification_ZoneHVAC_Sizing_HeatingSupplyAirFlowRateMethod HeatingSupplyAirFlowRateMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_HeatingSupplyAirFlowRateMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_HeatingSupplyAirFlowRateMethod), "SupplyAirFlowRate");
        

[Description("Enter the magnitude of the supply air volume flow rate during heating operation. " +
    "Required field when Heating Supply Air Flow Rate Method is SupplyAirFlowRate. Th" +
    "is field may be blank if a heating coil is not included in the Zone HVAC equipme" +
    "nt.")]
[JsonProperty("heating_supply_air_flow_rate")]
public string HeatingSupplyAirFlowRate { get; set; } = "";
        

[Description("Enter the heating supply air volume flow rate per total conditioned floor area. R" +
    "equired field when Heating Supply Air Flow Rate Method is FlowPerFloorArea. This" +
    " field may be blank if a heating coil is not included in the Zone HVAC equipment" +
    ".")]
[JsonProperty("heating_supply_air_flow_rate_per_floor_area")]
public System.Nullable<float> HeatingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

[Description(@"Enter the supply air volume flow rate as a fraction of the heating supply air flow rate. Required field when Heating Supply Air Flow Rate Method is FractionOfAutosizedHeatingAirflow. This field may be blank if a heating coil is not included in the Zone HVAC equipment.")]
[JsonProperty("heating_fraction_of_heating_supply_air_flow_rate")]
public System.Nullable<float> HeatingFractionOfHeatingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the supply air volume flow rate per unit heating capacity. Required field w" +
    "hen Heating Supply Air Flow Rate Method is FlowPerHeatingCapacity. This field ma" +
    "y be blank if a heating coil is not included in the Zone HVAC equipment.")]
[JsonProperty("heating_supply_air_flow_rate_per_unit_heating_capacity")]
public System.Nullable<float> HeatingSupplyAirFlowRatePerUnitHeatingCapacity { get; set; } = null;
        

[Description(@"Enter the method used to determine the cooling design capacity for scalable sizing. None is used when a cooling coils is not included in the Zone HVAC Equipment or this field may be blank. If this input field is left blank, then the design cooling capacity is set to zero. CoolingDesignCapacity => selected when the design cooling capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determine from user specified cooling capacity per floor area and zone floor area. FractionOfAutosizedCoolingCapacity => is selected when the design cooling capacity is determined from a user specified fraction and the auto-sized design cooling capacity.")]
[JsonProperty("cooling_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DesignSpecification_ZoneHVAC_Sizing_CoolingDesignCapacityMethod CoolingDesignCapacityMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_CoolingDesignCapacityMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_CoolingDesignCapacityMethod), "None");
        

[Description("Enter the design cooling capacity. Required field when the cooling design capacit" +
    "y method CoolingDesignCapacity.")]
[JsonProperty("cooling_design_capacity")]
public string CoolingDesignCapacity { get; set; } = "";
        

[Description("Enter the cooling design capacity per zone floor area. Required field when the co" +
    "oling design capacity method field is CapacityPerFloorArea.")]
[JsonProperty("cooling_design_capacity_per_floor_area")]
public System.Nullable<float> CoolingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of auto-sized cooling design capacity. Required field when the" +
    " cooling design capacity method field is FractionOfAutosizedCoolingCapacity.")]
[JsonProperty("fraction_of_autosized_cooling_design_capacity")]
public System.Nullable<float> FractionOfAutosizedCoolingDesignCapacity { get; set; } = null;
        

[Description(@"Enter the method used to determine the heating design capacity for scalable sizing. None is used when a heating coil is not included in the Zone HVAC Equipment or this field may be blank. If this input field is left blank, then the design heating capacity is set to zero. HeatingDesignCapacity => selected when the design heating capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determine from user specified heating capacity per flow area and zone floor area. FractionOfAutosizedHeatingCapacity => is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity")]
[JsonProperty("heating_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public DesignSpecification_ZoneHVAC_Sizing_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_HeatingDesignCapacityMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_HeatingDesignCapacityMethod), "None");
        

[Description("Enter the design heating capacity. Required field when the heating design capacit" +
    "y method HeatingDesignCapacity.")]
[JsonProperty("heating_design_capacity")]
public string HeatingDesignCapacity { get; set; } = "";
        

[Description("Enter the heating design capacity per zone floor area. Required field when the he" +
    "ating design capacity method field is CapacityPerFloorArea.")]
[JsonProperty("heating_design_capacity_per_floor_area")]
public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of auto-sized heating design capacity. Required field when cap" +
    "acity the heating design capacity method field is FractionOfAutosizedHeatingCapa" +
    "city.")]
[JsonProperty("fraction_of_autosized_heating_design_capacity")]
public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = null;
    }
    
    public enum DesignSpecification_ZoneHVAC_Sizing_CoolingSupplyAirFlowRateMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerCoolingCapacity")]
        FlowPerCoolingCapacity = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerFloorArea")]
        FlowPerFloorArea = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingAirflow")]
        FractionOfAutosizedCoolingAirflow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplyAirFlowRate")]
        SupplyAirFlowRate = 5,
    }
    
    public enum DesignSpecification_ZoneHVAC_Sizing_NoLoadSupplyAirFlowRateMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerFloorArea")]
        FlowPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingAirflow")]
        FractionOfAutosizedCoolingAirflow = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingAirflow")]
        FractionOfAutosizedHeatingAirflow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplyAirFlowRate")]
        SupplyAirFlowRate = 5,
    }
    
    public enum DesignSpecification_ZoneHVAC_Sizing_HeatingSupplyAirFlowRateMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerFloorArea")]
        FlowPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerHeatingCapacity")]
        FlowPerHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingAirflow")]
        FractionOfAutosizedHeatingAirflow = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="SupplyAirFlowRate")]
        SupplyAirFlowRate = 5,
    }
    
    public enum DesignSpecification_ZoneHVAC_Sizing_CoolingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingDesignCapacity")]
        CoolingDesignCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingCapacity")]
        FractionOfAutosizedCoolingCapacity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
    }
    
    public enum DesignSpecification_ZoneHVAC_Sizing_HeatingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
    }
    
    [Description("This object is used to scale the sizing of air terminal units.")]
    public class DesignSpecification_AirTerminal_Sizing : BHoMObject, IEnergyPlusClass
    {
        

[Description("The fraction of the design sensible cooling load to be met by this terminal unit." +
    " This fraction is applied after the Zone Cooling Sizing Factor (see Sizing:Zone)" +
    ".")]
[JsonProperty("fraction_of_design_cooling_load")]
public System.Nullable<float> FractionOfDesignCoolingLoad { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This ratio adjusts the supply air temperature difference used to calculate the co" +
    "oling design supply air flow rate for this terminal unit.")]
[JsonProperty("cooling_design_supply_air_temperature_difference_ratio")]
public System.Nullable<float> CoolingDesignSupplyAirTemperatureDifferenceRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("The fraction of the design sensible heating load to be met by this terminal unit." +
    " This fraction is applied after the Zone Heating Sizing Factor (see Sizing:Zone)" +
    ".")]
[JsonProperty("fraction_of_design_heating_load")]
public System.Nullable<float> FractionOfDesignHeatingLoad { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("This ratio adjusts the supply air temperature difference used to calculate the he" +
    "ating design supply air flow rate for this terminal unit.")]
[JsonProperty("heating_design_supply_air_temperature_difference_ratio")]
public System.Nullable<float> HeatingDesignSupplyAirTemperatureDifferenceRatio { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("The fraction of the zone minimum outdoor air requirement to be met by this termin" +
    "al unit.")]
[JsonProperty("fraction_of_minimum_outdoor_air_flow")]
public System.Nullable<float> FractionOfMinimumOutdoorAirFlow { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    [Description("Specifies the input needed to perform sizing calculations for a central forced ai" +
        "r system. System design air flow, heating capacity, and cooling capacity will be" +
        " calculated using this input data.")]
    public class Sizing_System : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("airloop_name")]
public string AirloopName { get; set; } = "";
        

[Description(@"Specifies the basis for sizing the system supply air flow rate Sensible and Total use the zone design air flow rates to size the system supply air flow rate The cooling coil will then be sized at either the peak Sensible or Total flow rate and conditions The heating coil is always sized at the peak sensible heating load. VentilationRequirement uses the system ventilation requirement")]
[JsonProperty("type_of_load_to_size_on")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_System_TypeOfLoadToSizeOn TypeOfLoadToSizeOn { get; set; } = (Sizing_System_TypeOfLoadToSizeOn)Enum.Parse(typeof(Sizing_System_TypeOfLoadToSizeOn), "Sensible");
        

[JsonProperty("design_outdoor_air_flow_rate")]
public string DesignOutdoorAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("central_heating_maximum_system_air_flow_ratio")]
public string CentralHeatingMaximumSystemAirFlowRatio { get; set; } = (System.String)"Autosize";
        

[JsonProperty("preheat_design_temperature")]
public System.Nullable<float> PreheatDesignTemperature { get; set; } = null;
        

[JsonProperty("preheat_design_humidity_ratio")]
public System.Nullable<float> PreheatDesignHumidityRatio { get; set; } = null;
        

[JsonProperty("precool_design_temperature")]
public System.Nullable<float> PrecoolDesignTemperature { get; set; } = null;
        

[JsonProperty("precool_design_humidity_ratio")]
public System.Nullable<float> PrecoolDesignHumidityRatio { get; set; } = null;
        

[JsonProperty("central_cooling_design_supply_air_temperature")]
public System.Nullable<float> CentralCoolingDesignSupplyAirTemperature { get; set; } = null;
        

[JsonProperty("central_heating_design_supply_air_temperature")]
public System.Nullable<float> CentralHeatingDesignSupplyAirTemperature { get; set; } = null;
        

[JsonProperty("type_of_zone_sum_to_use")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_System_TypeOfZoneSumToUse TypeOfZoneSumToUse { get; set; } = (Sizing_System_TypeOfZoneSumToUse)Enum.Parse(typeof(Sizing_System_TypeOfZoneSumToUse), "NonCoincident");
        

[JsonProperty("100_outdoor_air_in_cooling")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes _100OutdoorAirInCooling { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("100_outdoor_air_in_heating")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes _100OutdoorAirInHeating { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("central_cooling_design_supply_air_humidity_ratio")]
public System.Nullable<float> CentralCoolingDesignSupplyAirHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

[JsonProperty("central_heating_design_supply_air_humidity_ratio")]
public System.Nullable<float> CentralHeatingDesignSupplyAirHumidityRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.008", CultureInfo.InvariantCulture);
        

[JsonProperty("cooling_supply_air_flow_rate_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_System_CoolingSupplyAirFlowRateMethod CoolingSupplyAirFlowRateMethod { get; set; } = (Sizing_System_CoolingSupplyAirFlowRateMethod)Enum.Parse(typeof(Sizing_System_CoolingSupplyAirFlowRateMethod), "DesignDay");
        

[Description("This input is used if Cooling Supply Air Flow Rate Method is Flow/System This val" +
    "ue will *not* be multiplied by any sizing factor or by zone multipliers. If usin" +
    "g zone multipliers, this value must be large enough to serve the multiplied zone" +
    "s.")]
[JsonProperty("cooling_supply_air_flow_rate")]
public System.Nullable<float> CoolingSupplyAirFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the cooling supply air volume flow rate per total conditioned floor area. R" +
    "equired field when Cooling Supply Air Flow Rate Method is FlowPerFloorArea.")]
[JsonProperty("cooling_supply_air_flow_rate_per_floor_area")]
public System.Nullable<float> CoolingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flo" +
    "w rate. Required field when Cooling Supply Air Flow Rate Method is FractionOfAut" +
    "osizedCoolingAirflow.")]
[JsonProperty("cooling_fraction_of_autosized_cooling_supply_air_flow_rate")]
public System.Nullable<float> CoolingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the supply air volume flow rate per unit cooling capacity. Required field w" +
    "hen Cooling Supply Air Flow Rate Method is FlowPerCoolingCapacity.")]
[JsonProperty("cooling_supply_air_flow_rate_per_unit_cooling_capacity")]
public System.Nullable<float> CoolingSupplyAirFlowRatePerUnitCoolingCapacity { get; set; } = null;
        

[JsonProperty("heating_supply_air_flow_rate_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_System_HeatingSupplyAirFlowRateMethod HeatingSupplyAirFlowRateMethod { get; set; } = (Sizing_System_HeatingSupplyAirFlowRateMethod)Enum.Parse(typeof(Sizing_System_HeatingSupplyAirFlowRateMethod), "DesignDay");
        

[Description("Required field when Heating Supply Air Flow Rate Method is Flow/System This value" +
    " will *not* be multiplied by any sizing factor or by zone multipliers. If using " +
    "zone multipliers, this value must be large enough to serve the multiplied zones." +
    "")]
[JsonProperty("heating_supply_air_flow_rate")]
public System.Nullable<float> HeatingSupplyAirFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the heating supply air volume flow rate per total conditioned floor area. R" +
    "equired field when Heating Supply Air Flow Rate Method is FlowPerFloorArea.")]
[JsonProperty("heating_supply_air_flow_rate_per_floor_area")]
public System.Nullable<float> HeatingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the heating supply air flo" +
    "w rate. Required field when Heating Supply Air Flow Rate Method is FractionOfAut" +
    "osizedHeatingAirflow.")]
[JsonProperty("heating_fraction_of_autosized_heating_supply_air_flow_rate")]
public System.Nullable<float> HeatingFractionOfAutosizedHeatingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flo" +
    "w rate. Required field when Heating Supply Air Flow Rate Method is FractionOfAut" +
    "osizedCoolingAirflow.")]
[JsonProperty("heating_fraction_of_autosized_cooling_supply_air_flow_rate")]
public System.Nullable<float> HeatingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the heating supply air volume flow rate per unit heating capacity. Required" +
    " field when Heating Supply Air Flow Rate Method is FlowPerHeatingCapacity.")]
[JsonProperty("heating_supply_air_flow_rate_per_unit_heating_capacity")]
public System.Nullable<float> HeatingSupplyAirFlowRatePerUnitHeatingCapacity { get; set; } = null;
        

[JsonProperty("system_outdoor_air_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_System_SystemOutdoorAirMethod SystemOutdoorAirMethod { get; set; } = (Sizing_System_SystemOutdoorAirMethod)Enum.Parse(typeof(Sizing_System_SystemOutdoorAirMethod), "ZoneSum");
        

[JsonProperty("zone_maximum_outdoor_air_fraction")]
public System.Nullable<float> ZoneMaximumOutdoorAirFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description(@"Enter the method used to determine the system cooling design capacity for scalable sizing. None is used when a cooling coils is not included in an airloop or this field may be blank. If this input field is left blank, then the design cooling capacity is set to zero. CoolingDesignCapacity => selected when the design cooling capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determined from user specified cooling capacity per floor area and total floor area of cooled zones served by an airloop. FractionOfAutosizedCoolingCapacity => is selected when the design cooling capacity is determined from a user specified fraction and the auto-sized design cooling capacity of the system.")]
[JsonProperty("cooling_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_System_CoolingDesignCapacityMethod CoolingDesignCapacityMethod { get; set; } = (Sizing_System_CoolingDesignCapacityMethod)Enum.Parse(typeof(Sizing_System_CoolingDesignCapacityMethod), "CoolingDesignCapacity");
        

[Description("Enter the design cooling capacity.")]
[JsonProperty("cooling_design_capacity")]
public string CoolingDesignCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Enter the cooling design capacity per total floor area of cooled zones served by " +
    "an airloop. Required field when the cooling design capacity method field is Capa" +
    "cityPerFloorArea.")]
[JsonProperty("cooling_design_capacity_per_floor_area")]
public System.Nullable<float> CoolingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of auto-sized cooling design capacity. Required field when the" +
    " cooling design capacity method field is FractionOfAutosizedCoolingCapacity.")]
[JsonProperty("fraction_of_autosized_cooling_design_capacity")]
public System.Nullable<float> FractionOfAutosizedCoolingDesignCapacity { get; set; } = null;
        

[Description(@"Enter the method used to determine the heating design capacity for scalable sizing. None is used when a heating coil not included in an airloop or this field may be blank. If this input field is left blank, then the design heating capacity is set to zero. HeatingDesignCapacity => selected when the design heating capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design heating capacity is determined from user specified heating capacity per flow area and total floor area of heated zones served by an airloop. FractionOfAutosizedHeatingCapacity => is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity of the system.")]
[JsonProperty("heating_design_capacity_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_System_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (Sizing_System_HeatingDesignCapacityMethod)Enum.Parse(typeof(Sizing_System_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

[Description("Enter the design heating capacity.")]
[JsonProperty("heating_design_capacity")]
public string HeatingDesignCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Enter the heating design capacity per zone floor area. Required field when the he" +
    "ating design capacity method field is CapacityPerFloorArea.")]
[JsonProperty("heating_design_capacity_per_floor_area")]
public System.Nullable<float> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

[Description("Enter the fraction of auto-sized heating design capacity. Required field when cap" +
    "acity the heating design capacity method field is FractionOfAutosizedHeatingCapa" +
    "city.")]
[JsonProperty("fraction_of_autosized_heating_design_capacity")]
public System.Nullable<float> FractionOfAutosizedHeatingDesignCapacity { get; set; } = null;
        

[Description("Method used to control the coil\'s output")]
[JsonProperty("central_cooling_capacity_control_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_System_CentralCoolingCapacityControlMethod CentralCoolingCapacityControlMethod { get; set; } = (Sizing_System_CentralCoolingCapacityControlMethod)Enum.Parse(typeof(Sizing_System_CentralCoolingCapacityControlMethod), "OnOff");
    }
    
    public enum Sizing_System_TypeOfLoadToSizeOn
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Sensible")]
        Sensible = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Total")]
        Total = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="VentilationRequirement")]
        VentilationRequirement = 3,
    }
    
    public enum Sizing_System_TypeOfZoneSumToUse
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coincident")]
        Coincident = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="NonCoincident")]
        NonCoincident = 2,
    }
    
    public enum Sizing_System_CoolingSupplyAirFlowRateMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DesignDay")]
        DesignDay = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/System")]
        FlowSystem = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerCoolingCapacity")]
        FlowPerCoolingCapacity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerFloorArea")]
        FlowPerFloorArea = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingAirflow")]
        FractionOfAutosizedCoolingAirflow = 5,
    }
    
    public enum Sizing_System_HeatingSupplyAirFlowRateMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DesignDay")]
        DesignDay = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Flow/System")]
        FlowSystem = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerFloorArea")]
        FlowPerFloorArea = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowPerHeatingCapacity")]
        FlowPerHeatingCapacity = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingAirflow")]
        FractionOfAutosizedCoolingAirflow = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingAirflow")]
        FractionOfAutosizedHeatingAirflow = 6,
    }
    
    public enum Sizing_System_SystemOutdoorAirMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="VentilationRateProcedure")]
        VentilationRateProcedure = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneSum")]
        ZoneSum = 2,
    }
    
    public enum Sizing_System_CoolingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="CoolingDesignCapacity")]
        CoolingDesignCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedCoolingCapacity")]
        FractionOfAutosizedCoolingCapacity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
    }
    
    public enum Sizing_System_HeatingDesignCapacityMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CapacityPerFloorArea")]
        CapacityPerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionOfAutosizedHeatingCapacity")]
        FractionOfAutosizedHeatingCapacity = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatingDesignCapacity")]
        HeatingDesignCapacity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 4,
    }
    
    public enum Sizing_System_CentralCoolingCapacityControlMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Bypass")]
        Bypass = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OnOff")]
        OnOff = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="VAV")]
        VAV = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="VT")]
        VT = 4,
    }
    
    [Description(@"Specifies the input needed to autosize plant loop flow rates and equipment capacities. This information is initially used by components that use water for heating or cooling such as hot or chilled water coils to calculate their maximum water flow rates. These flow rates are then summed for use in calculating the Plant Loop flow rates.")]
    public class Sizing_Plant : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of a PlantLoop or a CondenserLoop object")]
[JsonProperty("plant_or_condenser_loop_name")]
public string PlantOrCondenserLoopName { get; set; } = "";
        

[JsonProperty("loop_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_Plant_LoopType LoopType { get; set; } = (Sizing_Plant_LoopType)Enum.Parse(typeof(Sizing_Plant_LoopType), "Condenser");
        

[JsonProperty("design_loop_exit_temperature")]
public System.Nullable<float> DesignLoopExitTemperature { get; set; } = null;
        

[JsonProperty("loop_design_temperature_difference")]
public System.Nullable<float> LoopDesignTemperatureDifference { get; set; } = null;
        

[Description("if Coincident is chosen, then sizing is based on HVAC Sizing Simulations and the " +
    "input field called Do HVAC Sizing Simulation for Sizing Periods in SimulationCon" +
    "trol must be set to Yes")]
[JsonProperty("sizing_option")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_Plant_SizingOption SizingOption { get; set; } = (Sizing_Plant_SizingOption)Enum.Parse(typeof(Sizing_Plant_SizingOption), "NonCoincident");
        

[Description("this is used in the coincident sizing algorithm to apply a running average to pea" +
    "k flow rates that occur during HVAC Sizing Simulations")]
[JsonProperty("zone_timesteps_in_averaging_window")]
public System.Nullable<float> ZoneTimestepsInAveragingWindow { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("this is used to adjust the result for coincident sizing by applying a sizing fact" +
    "or")]
[JsonProperty("coincident_sizing_factor_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Sizing_Plant_CoincidentSizingFactorMode CoincidentSizingFactorMode { get; set; } = (Sizing_Plant_CoincidentSizingFactorMode)Enum.Parse(typeof(Sizing_Plant_CoincidentSizingFactorMode), "GlobalCoolingSizingFactor");
    }
    
    public enum Sizing_Plant_LoopType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Condenser")]
        Condenser = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Cooling")]
        Cooling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Heating")]
        Heating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 3,
    }
    
    public enum Sizing_Plant_SizingOption
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coincident")]
        Coincident = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="NonCoincident")]
        NonCoincident = 2,
    }
    
    public enum Sizing_Plant_CoincidentSizingFactorMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="GlobalCoolingSizingFactor")]
        GlobalCoolingSizingFactor = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="GlobalHeatingSizingFactor")]
        GlobalHeatingSizingFactor = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="LoopComponentSizingFactor")]
        LoopComponentSizingFactor = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 3,
    }
    
    [Description("Default style for the Sizing output files is comma -- this works well for importi" +
        "ng into spreadsheet programs such as Excel(tm) but not so well for word processi" +
        "ng programs -- there tab may be a better choice. Fixed puts spaces between the \"" +
        "columns\"")]
    public class OutputControl_Sizing_Style : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("column_separator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public OutputControl_Sizing_Style_ColumnSeparator ColumnSeparator { get; set; } = (OutputControl_Sizing_Style_ColumnSeparator)Enum.Parse(typeof(OutputControl_Sizing_Style_ColumnSeparator), "Comma");
    }
    
    public enum OutputControl_Sizing_Style_ColumnSeparator
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Comma")]
        Comma = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Fixed")]
        Fixed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Tab")]
        Tab = 2,
    }
}