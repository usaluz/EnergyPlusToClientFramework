namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
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
    using BH.oM.Adapters.EnergyPlus.SetpointManagers;
    using BH.oM.Adapters.EnergyPlus.SimulationParameters;
    using BH.oM.Adapters.EnergyPlus.SolarCollectors;
    using BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements;
    using BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers;
    using BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces;
    using BH.oM.Adapters.EnergyPlus.UnitaryEquipment;
    using BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels;
    using BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment;
    using BH.oM.Adapters.EnergyPlus.WaterSystems;
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("Water heater with well-mixed, single-node water tank. May be used to model a tank" +
        "less water heater (small tank volume), a hot water storage tank (zero heater cap" +
        "acity), or a heat pump water heater (see WaterHeater:HeatPump:PumpedCondenser.)")]
    public class WaterHeater_Mixed : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("tank_volume")]
public string TankVolume { get; set; } = (System.String)"0";
        

[JsonProperty("setpoint_temperature_schedule_name")]
public string SetpointTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("deadband_temperature_difference")]
public System.Nullable<float> DeadbandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_temperature_limit")]
public System.Nullable<float> MaximumTemperatureLimit { get; set; } = null;
        

[JsonProperty("heater_control_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Mixed_HeaterControlType HeaterControlType { get; set; } = (WaterHeater_Mixed_HeaterControlType)Enum.Parse(typeof(WaterHeater_Mixed_HeaterControlType), "Cycle");
        

[JsonProperty("heater_maximum_capacity")]
public string HeaterMaximumCapacity { get; set; } = "";
        

[Description("Only used when Heater Control Type is set to Modulate")]
[JsonProperty("heater_minimum_capacity")]
public System.Nullable<float> HeaterMinimumCapacity { get; set; } = null;
        

[Description("Not yet implemented")]
[JsonProperty("heater_ignition_minimum_flow_rate")]
public System.Nullable<float> HeaterIgnitionMinimumFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Not yet implemented")]
[JsonProperty("heater_ignition_delay")]
public System.Nullable<float> HeaterIgnitionDelay { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("heater_fuel_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Mixed_HeaterFuelType HeaterFuelType { get; set; } = (WaterHeater_Mixed_HeaterFuelType)Enum.Parse(typeof(WaterHeater_Mixed_HeaterFuelType), "Coal");
        

[JsonProperty("heater_thermal_efficiency")]
public System.Nullable<float> HeaterThermalEfficiency { get; set; } = null;
        

[JsonProperty("part_load_factor_curve_name")]
public string PartLoadFactorCurveName { get; set; } = "";
        

[JsonProperty("off_cycle_parasitic_fuel_consumption_rate")]
public System.Nullable<float> OffCycleParasiticFuelConsumptionRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("off_cycle_parasitic_fuel_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Mixed_OffCycleParasiticFuelType OffCycleParasiticFuelType { get; set; } = (WaterHeater_Mixed_OffCycleParasiticFuelType)Enum.Parse(typeof(WaterHeater_Mixed_OffCycleParasiticFuelType), "Coal");
        

[JsonProperty("off_cycle_parasitic_heat_fraction_to_tank")]
public System.Nullable<float> OffCycleParasiticHeatFractionToTank { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("on_cycle_parasitic_fuel_consumption_rate")]
public System.Nullable<float> OnCycleParasiticFuelConsumptionRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("on_cycle_parasitic_fuel_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Mixed_OnCycleParasiticFuelType OnCycleParasiticFuelType { get; set; } = (WaterHeater_Mixed_OnCycleParasiticFuelType)Enum.Parse(typeof(WaterHeater_Mixed_OnCycleParasiticFuelType), "Coal");
        

[JsonProperty("on_cycle_parasitic_heat_fraction_to_tank")]
public System.Nullable<float> OnCycleParasiticHeatFractionToTank { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("ambient_temperature_indicator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Mixed_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (WaterHeater_Mixed_AmbientTemperatureIndicator)Enum.Parse(typeof(WaterHeater_Mixed_AmbientTemperatureIndicator), "Outdoors");
        

[JsonProperty("ambient_temperature_schedule_name")]
public string AmbientTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("ambient_temperature_zone_name")]
public string AmbientTemperatureZoneName { get; set; } = "";
        

[Description("required for Ambient Temperature Indicator=Outdoors")]
[JsonProperty("ambient_temperature_outdoor_air_node_name")]
public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

[JsonProperty("off_cycle_loss_coefficient_to_ambient_temperature")]
public System.Nullable<float> OffCycleLossCoefficientToAmbientTemperature { get; set; } = null;
        

[JsonProperty("off_cycle_loss_fraction_to_zone")]
public System.Nullable<float> OffCycleLossFractionToZone { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("on_cycle_loss_coefficient_to_ambient_temperature")]
public System.Nullable<float> OnCycleLossCoefficientToAmbientTemperature { get; set; } = null;
        

[JsonProperty("on_cycle_loss_fraction_to_zone")]
public System.Nullable<float> OnCycleLossFractionToZone { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Only used if Use Side Node connections are blank")]
[JsonProperty("peak_use_flow_rate")]
public System.Nullable<float> PeakUseFlowRate { get; set; } = null;
        

[Description("Only used if Use Side Node connections are blank")]
[JsonProperty("use_flow_rate_fraction_schedule_name")]
public string UseFlowRateFractionScheduleName { get; set; } = "";
        

[Description("Only used if Use Side Node connections are blank Defaults to water temperatures c" +
    "alculated by Site:WaterMainsTemperature object")]
[JsonProperty("cold_water_supply_temperature_schedule_name")]
public string ColdWaterSupplyTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("use_side_inlet_node_name")]
public string UseSideInletNodeName { get; set; } = "";
        

[JsonProperty("use_side_outlet_node_name")]
public string UseSideOutletNodeName { get; set; } = "";
        

[JsonProperty("use_side_effectiveness")]
public System.Nullable<float> UseSideEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("source_side_inlet_node_name")]
public string SourceSideInletNodeName { get; set; } = "";
        

[JsonProperty("source_side_outlet_node_name")]
public string SourceSideOutletNodeName { get; set; } = "";
        

[JsonProperty("source_side_effectiveness")]
public System.Nullable<float> SourceSideEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("use_side_design_flow_rate")]
public string UseSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("source_side_design_flow_rate")]
public string SourceSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Parameter for autosizing design flow rates for indirectly heated water tanks Time" +
    " required to raise temperature of entire tank from 14.4C to 57.2C")]
[JsonProperty("indirect_water_heating_recovery_time")]
public System.Nullable<float> IndirectWaterHeatingRecoveryTime { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
        

[Description(@"StorageTank mode always requests flow unless tank is at its Maximum Temperature Limit IndirectHeatPrimarySetpoint mode requests flow whenever primary setpoint calls for heat IndirectHeatAlternateSetpoint mode requests flow whenever alternate indirect setpoint calls for heat")]
[JsonProperty("source_side_flow_control_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Mixed_SourceSideFlowControlMode SourceSideFlowControlMode { get; set; } = (WaterHeater_Mixed_SourceSideFlowControlMode)Enum.Parse(typeof(WaterHeater_Mixed_SourceSideFlowControlMode), "IndirectHeatPrimarySetpoint");
        

[Description("This field is only used if the previous is set to IndirectHeatAlternateSetpoint")]
[JsonProperty("indirect_alternate_setpoint_temperature_schedule_name")]
public string IndirectAlternateSetpointTemperatureScheduleName { get; set; } = "";
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
    
    public enum WaterHeater_Mixed_HeaterControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Cycle")]
        Cycle = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Modulate")]
        Modulate = 2,
    }
    
    public enum WaterHeater_Mixed_HeaterFuelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coal")]
        Coal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Diesel")]
        Diesel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictHeating")]
        DistrictHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity")]
        Electricity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo1")]
        FuelOilNo1 = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo2")]
        FuelOilNo2 = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Gasoline")]
        Gasoline = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="NaturalGas")]
        NaturalGas = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel1")]
        OtherFuel1 = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel2")]
        OtherFuel2 = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Propane")]
        Propane = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 11,
    }
    
    public enum WaterHeater_Mixed_OffCycleParasiticFuelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coal")]
        Coal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Diesel")]
        Diesel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictHeating")]
        DistrictHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity")]
        Electricity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo1")]
        FuelOilNo1 = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo2")]
        FuelOilNo2 = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Gasoline")]
        Gasoline = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="NaturalGas")]
        NaturalGas = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel1")]
        OtherFuel1 = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel2")]
        OtherFuel2 = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Propane")]
        Propane = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 11,
    }
    
    public enum WaterHeater_Mixed_OnCycleParasiticFuelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coal")]
        Coal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Diesel")]
        Diesel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictHeating")]
        DistrictHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity")]
        Electricity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo1")]
        FuelOilNo1 = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo2")]
        FuelOilNo2 = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Gasoline")]
        Gasoline = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="NaturalGas")]
        NaturalGas = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel1")]
        OtherFuel1 = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel2")]
        OtherFuel2 = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Propane")]
        Propane = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 11,
    }
    
    public enum WaterHeater_Mixed_AmbientTemperatureIndicator
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 2,
    }
    
    public enum WaterHeater_Mixed_SourceSideFlowControlMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="IndirectHeatAlternateSetpoint")]
        IndirectHeatAlternateSetpoint = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="IndirectHeatPrimarySetpoint")]
        IndirectHeatPrimarySetpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="StorageTank")]
        StorageTank = 3,
    }
    
    [Description("Water heater with stratified, multi-node water tank. May be used to model a tankl" +
        "ess water heater (small tank volume), a hot water storage tank (zero heater capa" +
        "city), or a heat pump water heater (see WaterHeater:HeatPump:*.)")]
    public class WaterHeater_Stratified : BHoMObject, IEnergyPlusClass
    {
        

[Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
    "category table.")]
[JsonProperty("end_use_subcategory")]
public string EndUseSubcategory { get; set; } = (System.String)"General";
        

[JsonProperty("tank_volume")]
public string TankVolume { get; set; } = "";
        

[Description("Height is measured in the axial direction for horizontal cylinders")]
[JsonProperty("tank_height")]
public string TankHeight { get; set; } = "";
        

[JsonProperty("tank_shape")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Stratified_TankShape TankShape { get; set; } = (WaterHeater_Stratified_TankShape)Enum.Parse(typeof(WaterHeater_Stratified_TankShape), "VerticalCylinder");
        

[Description("Only used if Tank Shape is Other")]
[JsonProperty("tank_perimeter")]
public System.Nullable<float> TankPerimeter { get; set; } = null;
        

[JsonProperty("maximum_temperature_limit")]
public System.Nullable<float> MaximumTemperatureLimit { get; set; } = null;
        

[JsonProperty("heater_priority_control")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Stratified_HeaterPriorityControl HeaterPriorityControl { get; set; } = (WaterHeater_Stratified_HeaterPriorityControl)Enum.Parse(typeof(WaterHeater_Stratified_HeaterPriorityControl), "MasterSlave");
        

[JsonProperty("heater_1_setpoint_temperature_schedule_name")]
public string Heater1SetpointTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("heater_1_deadband_temperature_difference")]
public System.Nullable<float> Heater1DeadbandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("heater_1_capacity")]
public string Heater1Capacity { get; set; } = "";
        

[JsonProperty("heater_1_height")]
public System.Nullable<float> Heater1Height { get; set; } = null;
        

[JsonProperty("heater_2_setpoint_temperature_schedule_name")]
public string Heater2SetpointTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("heater_2_deadband_temperature_difference")]
public System.Nullable<float> Heater2DeadbandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("heater_2_capacity")]
public System.Nullable<float> Heater2Capacity { get; set; } = null;
        

[JsonProperty("heater_2_height")]
public System.Nullable<float> Heater2Height { get; set; } = null;
        

[JsonProperty("heater_fuel_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Stratified_HeaterFuelType HeaterFuelType { get; set; } = (WaterHeater_Stratified_HeaterFuelType)Enum.Parse(typeof(WaterHeater_Stratified_HeaterFuelType), "Coal");
        

[JsonProperty("heater_thermal_efficiency")]
public System.Nullable<float> HeaterThermalEfficiency { get; set; } = null;
        

[JsonProperty("off_cycle_parasitic_fuel_consumption_rate")]
public System.Nullable<float> OffCycleParasiticFuelConsumptionRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("off_cycle_parasitic_fuel_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Stratified_OffCycleParasiticFuelType OffCycleParasiticFuelType { get; set; } = (WaterHeater_Stratified_OffCycleParasiticFuelType)Enum.Parse(typeof(WaterHeater_Stratified_OffCycleParasiticFuelType), "Coal");
        

[JsonProperty("off_cycle_parasitic_heat_fraction_to_tank")]
public System.Nullable<float> OffCycleParasiticHeatFractionToTank { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("off_cycle_parasitic_height")]
public System.Nullable<float> OffCycleParasiticHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("on_cycle_parasitic_fuel_consumption_rate")]
public System.Nullable<float> OnCycleParasiticFuelConsumptionRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("on_cycle_parasitic_fuel_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Stratified_OnCycleParasiticFuelType OnCycleParasiticFuelType { get; set; } = (WaterHeater_Stratified_OnCycleParasiticFuelType)Enum.Parse(typeof(WaterHeater_Stratified_OnCycleParasiticFuelType), "Coal");
        

[JsonProperty("on_cycle_parasitic_heat_fraction_to_tank")]
public System.Nullable<float> OnCycleParasiticHeatFractionToTank { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("on_cycle_parasitic_height")]
public System.Nullable<float> OnCycleParasiticHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("ambient_temperature_indicator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Stratified_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (WaterHeater_Stratified_AmbientTemperatureIndicator)Enum.Parse(typeof(WaterHeater_Stratified_AmbientTemperatureIndicator), "Outdoors");
        

[JsonProperty("ambient_temperature_schedule_name")]
public string AmbientTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("ambient_temperature_zone_name")]
public string AmbientTemperatureZoneName { get; set; } = "";
        

[Description("required for Ambient Temperature Indicator=Outdoors")]
[JsonProperty("ambient_temperature_outdoor_air_node_name")]
public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

[JsonProperty("uniform_skin_loss_coefficient_per_unit_area_to_ambient_temperature")]
public System.Nullable<float> UniformSkinLossCoefficientPerUnitAreaToAmbientTemperature { get; set; } = null;
        

[JsonProperty("skin_loss_fraction_to_zone")]
public System.Nullable<float> SkinLossFractionToZone { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("off_cycle_flue_loss_coefficient_to_ambient_temperature")]
public System.Nullable<float> OffCycleFlueLossCoefficientToAmbientTemperature { get; set; } = null;
        

[JsonProperty("off_cycle_flue_loss_fraction_to_zone")]
public System.Nullable<float> OffCycleFlueLossFractionToZone { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Only used if Use Side Node connections are blank")]
[JsonProperty("peak_use_flow_rate")]
public System.Nullable<float> PeakUseFlowRate { get; set; } = null;
        

[Description("If blank, defaults to 1.0 at all times Only used if use side node connections are" +
    " blank")]
[JsonProperty("use_flow_rate_fraction_schedule_name")]
public string UseFlowRateFractionScheduleName { get; set; } = "";
        

[Description("Only used if use side node connections are blank Defaults to water temperatures c" +
    "alculated by Site:WaterMainsTemperature object")]
[JsonProperty("cold_water_supply_temperature_schedule_name")]
public string ColdWaterSupplyTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("use_side_inlet_node_name")]
public string UseSideInletNodeName { get; set; } = "";
        

[JsonProperty("use_side_outlet_node_name")]
public string UseSideOutletNodeName { get; set; } = "";
        

[Description(@"The use side effectiveness in the stratified tank model is a simplified analogy of a heat exchanger's effectiveness. This effectiveness is equal to the fraction of use mass flow rate that directly mixes with the tank fluid. And one minus the effectiveness is the fraction that bypasses the tank. The use side mass flow rate that bypasses the tank is mixed with the fluid or water leaving the stratified tank.")]
[JsonProperty("use_side_effectiveness")]
public System.Nullable<float> UseSideEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Defaults to bottom of tank")]
[JsonProperty("use_side_inlet_height")]
public System.Nullable<float> UseSideInletHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Defaults to top of tank")]
[JsonProperty("use_side_outlet_height")]
public string UseSideOutletHeight { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("source_side_inlet_node_name")]
public string SourceSideInletNodeName { get; set; } = "";
        

[JsonProperty("source_side_outlet_node_name")]
public string SourceSideOutletNodeName { get; set; } = "";
        

[Description(@"The source side effectiveness in the stratified tank model is a simplified analogy of a heat exchanger's effectiveness. This effectiveness is equal to the fraction of source mass flow rate that directly mixes with the tank fluid. And one minus the effectiveness is the fraction that bypasses the tank. The source side mass flow rate that bypasses the tank is mixed with the fluid or water leaving the stratified tank.")]
[JsonProperty("source_side_effectiveness")]
public System.Nullable<float> SourceSideEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Defaults to top of tank")]
[JsonProperty("source_side_inlet_height")]
public string SourceSideInletHeight { get; set; } = (System.String)"Autocalculate";
        

[Description("Defaults to bottom of tank")]
[JsonProperty("source_side_outlet_height")]
public System.Nullable<float> SourceSideOutletHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("inlet_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Stratified_InletMode InletMode { get; set; } = (WaterHeater_Stratified_InletMode)Enum.Parse(typeof(WaterHeater_Stratified_InletMode), "Fixed");
        

[JsonProperty("use_side_design_flow_rate")]
public string UseSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("source_side_design_flow_rate")]
public string SourceSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Parameter for autosizing design flow rates for indirectly heated water tanks time" +
    " required to raise temperature of entire tank from 14.4C to 57.2C")]
[JsonProperty("indirect_water_heating_recovery_time")]
public System.Nullable<float> IndirectWaterHeatingRecoveryTime { get; set; } = (System.Nullable<float>)Single.Parse("1.5", CultureInfo.InvariantCulture);
        

[JsonProperty("number_of_nodes")]
public System.Nullable<float> NumberOfNodes { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("additional_destratification_conductivity")]
public System.Nullable<float> AdditionalDestratificationConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_1_additional_loss_coefficient")]
public System.Nullable<float> Node1AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_2_additional_loss_coefficient")]
public System.Nullable<float> Node2AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_3_additional_loss_coefficient")]
public System.Nullable<float> Node3AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_4_additional_loss_coefficient")]
public System.Nullable<float> Node4AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_5_additional_loss_coefficient")]
public System.Nullable<float> Node5AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_6_additional_loss_coefficient")]
public System.Nullable<float> Node6AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_7_additional_loss_coefficient")]
public System.Nullable<float> Node7AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_8_additional_loss_coefficient")]
public System.Nullable<float> Node8AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_9_additional_loss_coefficient")]
public System.Nullable<float> Node9AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_10_additional_loss_coefficient")]
public System.Nullable<float> Node10AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_11_additional_loss_coefficient")]
public System.Nullable<float> Node11AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_12_additional_loss_coefficient")]
public System.Nullable<float> Node12AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"StorageTank mode always requests flow unless tank is at its Maximum Temperature Limit IndirectHeatPrimarySetpoint mode requests flow whenever primary setpoint for heater 1 calls for heat IndirectHeatAlternateSetpoint mode requests flow whenever alternate indirect setpoint calls for heat")]
[JsonProperty("source_side_flow_control_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Stratified_SourceSideFlowControlMode SourceSideFlowControlMode { get; set; } = (WaterHeater_Stratified_SourceSideFlowControlMode)Enum.Parse(typeof(WaterHeater_Stratified_SourceSideFlowControlMode), "IndirectHeatPrimarySetpoint");
        

[Description("This field is only used if the previous is set to IndirectHeatAlternateSetpoint")]
[JsonProperty("indirect_alternate_setpoint_temperature_schedule_name")]
public string IndirectAlternateSetpointTemperatureScheduleName { get; set; } = "";
    }
    
    public enum WaterHeater_Stratified_TankShape
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HorizontalCylinder")]
        HorizontalCylinder = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Other")]
        Other = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="VerticalCylinder")]
        VerticalCylinder = 3,
    }
    
    public enum WaterHeater_Stratified_HeaterPriorityControl
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MasterSlave")]
        MasterSlave = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Simultaneous")]
        Simultaneous = 2,
    }
    
    public enum WaterHeater_Stratified_HeaterFuelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coal")]
        Coal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Diesel")]
        Diesel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictHeating")]
        DistrictHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity")]
        Electricity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo1")]
        FuelOilNo1 = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo2")]
        FuelOilNo2 = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Gasoline")]
        Gasoline = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="NaturalGas")]
        NaturalGas = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel1")]
        OtherFuel1 = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel2")]
        OtherFuel2 = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Propane")]
        Propane = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 11,
    }
    
    public enum WaterHeater_Stratified_OffCycleParasiticFuelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coal")]
        Coal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Diesel")]
        Diesel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictHeating")]
        DistrictHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity")]
        Electricity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo1")]
        FuelOilNo1 = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo2")]
        FuelOilNo2 = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Gasoline")]
        Gasoline = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="NaturalGas")]
        NaturalGas = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel1")]
        OtherFuel1 = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel2")]
        OtherFuel2 = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Propane")]
        Propane = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 11,
    }
    
    public enum WaterHeater_Stratified_OnCycleParasiticFuelType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Coal")]
        Coal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Diesel")]
        Diesel = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DistrictHeating")]
        DistrictHeating = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Electricity")]
        Electricity = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo1")]
        FuelOilNo1 = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="FuelOilNo2")]
        FuelOilNo2 = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Gasoline")]
        Gasoline = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="NaturalGas")]
        NaturalGas = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel1")]
        OtherFuel1 = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="OtherFuel2")]
        OtherFuel2 = 9,
        
        [System.Runtime.Serialization.EnumMember(Value="Propane")]
        Propane = 10,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 11,
    }
    
    public enum WaterHeater_Stratified_AmbientTemperatureIndicator
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 2,
    }
    
    public enum WaterHeater_Stratified_InletMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Fixed")]
        Fixed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Seeking")]
        Seeking = 2,
    }
    
    public enum WaterHeater_Stratified_SourceSideFlowControlMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="IndirectHeatAlternateSetpoint")]
        IndirectHeatAlternateSetpoint = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="IndirectHeatPrimarySetpoint")]
        IndirectHeatPrimarySetpoint = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="StorageTank")]
        StorageTank = 3,
    }
    
    [Description("This input object is used with WaterHeater:Mixed or with WaterHeater:Stratified t" +
        "o autosize tank volume and heater capacity This object is not needed if water he" +
        "aters are not autosized.")]
    public class WaterHeater_Sizing : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("waterheater_name")]
public string WaterheaterName { get; set; } = "";
        

[JsonProperty("design_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_Sizing_DesignMode DesignMode { get; set; } = (WaterHeater_Sizing_DesignMode)Enum.Parse(typeof(WaterHeater_Sizing_DesignMode), "PeakDraw");
        

[Description("Only used for Design Mode = PeakDraw")]
[JsonProperty("time_storage_can_meet_peak_draw")]
public System.Nullable<float> TimeStorageCanMeetPeakDraw { get; set; } = null;
        

[Description("Only used for Design Mode = PeakDraw")]
[JsonProperty("time_for_tank_recovery")]
public System.Nullable<float> TimeForTankRecovery { get; set; } = null;
        

[Description("Only used if Design Mode = PeakDraw and the water heater also has autosized flow " +
    "rates for connections on the demand side of a plant loop")]
[JsonProperty("nominal_tank_volume_for_autosizing_plant_connections")]
public System.Nullable<float> NominalTankVolumeForAutosizingPlantConnections { get; set; } = null;
        

[Description("Only used for Design Mode = ResidentialHUD-FHAMinimum")]
[JsonProperty("number_of_bedrooms")]
public System.Nullable<float> NumberOfBedrooms { get; set; } = null;
        

[Description("Only used for Design Mode = ResidentialHUD-FHAMinimum")]
[JsonProperty("number_of_bathrooms")]
public System.Nullable<float> NumberOfBathrooms { get; set; } = null;
        

[Description("Only used for Design Mode = PerPerson")]
[JsonProperty("storage_capacity_per_person")]
public System.Nullable<float> StorageCapacityPerPerson { get; set; } = null;
        

[Description("Only used for Design Mode = PerPerson")]
[JsonProperty("recovery_capacity_per_person")]
public System.Nullable<float> RecoveryCapacityPerPerson { get; set; } = null;
        

[Description("Only used for Design Mode = PerFloorArea")]
[JsonProperty("storage_capacity_per_floor_area")]
public System.Nullable<float> StorageCapacityPerFloorArea { get; set; } = null;
        

[Description("Only used for Design Mode = PerFloorArea")]
[JsonProperty("recovery_capacity_per_floor_area")]
public System.Nullable<float> RecoveryCapacityPerFloorArea { get; set; } = null;
        

[Description("Only used for Design Mode = PerUnit")]
[JsonProperty("number_of_units")]
public System.Nullable<float> NumberOfUnits { get; set; } = null;
        

[Description("Only used for Design Mode = PerUnit")]
[JsonProperty("storage_capacity_per_unit")]
public System.Nullable<float> StorageCapacityPerUnit { get; set; } = null;
        

[Description("Only used for Design Mode = PerUnit")]
[JsonProperty("recovery_capacity_perunit")]
public System.Nullable<float> RecoveryCapacityPerunit { get; set; } = null;
        

[Description("Only used for Design Mode = PerSolarCollectorArea")]
[JsonProperty("storage_capacity_per_collector_area")]
public System.Nullable<float> StorageCapacityPerCollectorArea { get; set; } = null;
        

[Description("only used if for WaterHeater:Stratified")]
[JsonProperty("height_aspect_ratio")]
public System.Nullable<float> HeightAspectRatio { get; set; } = null;
    }
    
    public enum WaterHeater_Sizing_DesignMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="PeakDraw")]
        PeakDraw = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="PerFloorArea")]
        PerFloorArea = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PerPerson")]
        PerPerson = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PerSolarCollectorArea")]
        PerSolarCollectorArea = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="PerUnit")]
        PerUnit = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="ResidentialHUD-FHAMinimum")]
        ResidentialHUDFHAMinimum = 5,
    }
    
    [Description(@"This object models an air-source heat pump for water heating where the water is pumped out of the tank, through a heating coil and returned to the tank. For wrapped condenser HPWHs, see WaterHeater:HeatPump:WrappedCondenser. WaterHeater:HeatPump:PumpedCondenser is a compound object that references other component objects - Coil:WaterHeating:AirToWaterHeatPump:*, Fan:OnOff, WaterHeater:Mixed or WaterHeater:Stratified")]
    public class WaterHeater_HeatPump_PumpedCondenser : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. Schedule values of 0 denote the heat pump compressor is off and the parasitic electric energy is also off.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Defines the cut-out temperature where the heat pump compressor turns off. The hea" +
    "t pump compressor setpoint temperature should always be greater than the water t" +
    "ank\'s heater (element or burner) setpoint temperature.")]
[JsonProperty("compressor_setpoint_temperature_schedule_name")]
public string CompressorSetpointTemperatureScheduleName { get; set; } = "";
        

[Description(@"Setpoint temperature minus the dead band temperature difference defines the cut-in temperature where the heat pump compressor turns on. The water tank's heater (element or burner) setpoint temperature should always be less than the heat pump compressor cut-in temperature.")]
[JsonProperty("dead_band_temperature_difference")]
public System.Nullable<float> DeadBandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[Description("Should match the field Source Outlet Node Name in the water heater tank object. S" +
    "hould also match the Condenser Water Inlet Node Name in the associated DX coil o" +
    "bject.")]
[JsonProperty("condenser_water_inlet_node_name")]
public string CondenserWaterInletNodeName { get; set; } = "";
        

[Description("Should match the field Source Inlet Node Name in water heater tank object. Should" +
    " also match the Condenser Water Outlet Node Name in the associated DX Coil objec" +
    "t.")]
[JsonProperty("condenser_water_outlet_node_name")]
public string CondenserWaterOutletNodeName { get; set; } = "";
        

[Description("Actual water flow rate through the heat pump\'s water coil (condenser). If autocal" +
    "culated, the water flow rate is set equal to 4.487E-8 m3/s/W times the rated hea" +
    "ting capacity of the heat pump\'s DX coil.")]
[JsonProperty("condenser_water_flow_rate")]
public string CondenserWaterFlowRate { get; set; } = "";
        

[Description("Actual air flow rate across the heat pump\'s air coil (evaporator). If autocalcula" +
    "ted, the air flow rate is set equal to 5.035E-5 m3/s/W times the rated heating c" +
    "apacity of the heat pump\'s DX coil.")]
[JsonProperty("evaporator_air_flow_rate")]
public string EvaporatorAirFlowRate { get; set; } = "";
        

[Description("Defines the configuration of the airflow path through the air coil and fan sectio" +
    "n.")]
[JsonProperty("inlet_air_configuration")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_PumpedCondenser_InletAirConfiguration InletAirConfiguration { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_InletAirConfiguration)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_InletAirConfiguration), "OutdoorAirOnly");
        

[Description("Zone air exhaust node name if Inlet Air Configuration is ZoneAirOnly or ZoneAndOu" +
    "tdoorAir. Simply a unique Node Name if Inlet Air Configuration is Schedule. Othe" +
    "rwise, leave field blank.")]
[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[Description("Zone Air Inlet Node Name if Inlet Air Configuration is ZoneAirOnly or ZoneAndOutd" +
    "oorAir. Simply a unique Node Name if Inlet Air Configuration is Schedule. Otherw" +
    "ise, leave field blank.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Outdoor air node name if inlet air configuration is ZoneAndOutdoorAir or OutdoorA" +
    "irOnly, otherwise leave field blank.")]
[JsonProperty("outdoor_air_node_name")]
public string OutdoorAirNodeName { get; set; } = "";
        

[Description("Simply a unique Node Name if Inlet Air Configuration is ZoneAndOutdoorAir or Outd" +
    "oorAirOnly, otherwise leave field blank.")]
[JsonProperty("exhaust_air_node_name")]
public string ExhaustAirNodeName { get; set; } = "";
        

[Description("Used only if Inlet Air Configuration is Schedule, otherwise leave blank. Schedule" +
    " values should be degrees C.")]
[JsonProperty("inlet_air_temperature_schedule_name")]
public string InletAirTemperatureScheduleName { get; set; } = "";
        

[Description("Used only if Inlet Air Configuration is Schedule, otherwise leave blank. Schedule" +
    " values are entered as a fraction (e.g. 0.5 is equal to 50%RH)")]
[JsonProperty("inlet_air_humidity_schedule_name")]
public string InletAirHumidityScheduleName { get; set; } = "";
        

[Description("Used only if Inlet Air Configuration is ZoneAirOnly or ZoneAndOutdoorAir. Otherwi" +
    "se, leave field blank.")]
[JsonProperty("inlet_air_zone_name")]
public string InletAirZoneName { get; set; } = "";
        

[Description("Specify the type of water heater tank used by this heat pump water heater.")]
[JsonProperty("tank_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_PumpedCondenser_TankObjectType TankObjectType { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_TankObjectType)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_TankObjectType), "Empty");
        

[Description("Needs to match the name used in the corresponding Water Heater object.")]
[JsonProperty("tank_name")]
public string TankName { get; set; } = "";
        

[Description("Used only when the heat pump water heater is connected to a plant loop, otherwise" +
    " leave blank. Needs to match the name used in the corresponding Water Heater obj" +
    "ect when connected to a plant loop.")]
[JsonProperty("tank_use_side_inlet_node_name")]
public string TankUseSideInletNodeName { get; set; } = "";
        

[Description("Used only when the heat pump water heater is connected to a plant loop, otherwise" +
    " leave blank. Needs to match the name used in the corresponding Water Heater obj" +
    "ect when connected to a plant loop.")]
[JsonProperty("tank_use_side_outlet_node_name")]
public string TankUseSideOutletNodeName { get; set; } = "";
        

[Description("Specify the type of DX coil used by this heat pump water heater. The only valid c" +
    "hoice is Coil:WaterHeating:AirToWaterHeatPump:Pumped and Coil:WaterHeating:AirTo" +
    "WaterHeatPump:VariableSpeed, and CoilSystem:IntegratedHeatPump:AirSource")]
[JsonProperty("dx_coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_PumpedCondenser_DxCoilObjectType DxCoilObjectType { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_DxCoilObjectType)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_DxCoilObjectType), "Empty");
        

[Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
    "p:* object, or CoilSystem:IntegratedHeatPump:AirSource")]
[JsonProperty("dx_coil_name")]
public string DxCoilName { get; set; } = "";
        

[Description("Heat pump compressor will not operate when the inlet air dry-bulb temperature is " +
    "below this value.")]
[JsonProperty("minimum_inlet_air_temperature_for_compressor_operation")]
public System.Nullable<float> MinimumInletAirTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("Heat pump compressor will not operate when the inlet air dry-bulb temperature is " +
    "above this value.")]
[JsonProperty("maximum_inlet_air_temperature_for_compressor_operation")]
public System.Nullable<float> MaximumInletAirTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("48.88888888889", CultureInfo.InvariantCulture);
        

[Description("If Zone is selected, Inlet Air Configuration must be ZoneAirOnly or ZoneAndOutdoo" +
    "rAir. If Schedule is selected, then you must provide a Compressor Ambient Temper" +
    "ature Schedule Name below.")]
[JsonProperty("compressor_location")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_PumpedCondenser_CompressorLocation CompressorLocation { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_CompressorLocation)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_CompressorLocation), "Outdoors");
        

[Description("Used only if Compressor Location is Schedule, otherwise leave field blank.")]
[JsonProperty("compressor_ambient_temperature_schedule_name")]
public string CompressorAmbientTemperatureScheduleName { get; set; } = "";
        

[Description("Specify the type of fan used by this heat pump water heater. The only valid choic" +
    "es are Fan:SystemModel or Fan:OnOff.")]
[JsonProperty("fan_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_PumpedCondenser_FanObjectType FanObjectType { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_FanObjectType)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_FanObjectType), "Empty");
        

[Description("Needs to match the name used in the corresponding Fan:SystemModel or Fan:OnOff ob" +
    "ject.")]
[JsonProperty("fan_name")]
public string FanName { get; set; } = "";
        

[Description("BlowThrough means the fan is located before the air coil (upstream). DrawThrough " +
    "means the fan is located after the air coil (downstream).")]
[JsonProperty("fan_placement")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_PumpedCondenser_FanPlacement FanPlacement { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_FanPlacement)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_FanPlacement), "DrawThrough");
        

[Description("Parasitic electric power consumed when the heat pump compressor operates. Does no" +
    "t contribute to water heating but can impact the zone air heat balance.")]
[JsonProperty("on_cycle_parasitic_electric_load")]
public System.Nullable<float> OnCycleParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Parasitic electric power consumed when the heat pump compressor is off. Does not " +
    "contribute to water heating but can impact the zone air heat balance. Off-cycle " +
    "parasitic power is 0 when the availability schedule is 0.")]
[JsonProperty("off_cycle_parasitic_electric_load")]
public System.Nullable<float> OffCycleParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field determines if the parasitic electric load impacts the zone air heat ba" +
    "lance. If Zone is selected, Inlet Air Configuration must be ZoneAirOnly or ZoneA" +
    "ndOutdoorAir.")]
[JsonProperty("parasitic_heat_rejection_location")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_PumpedCondenser_ParasiticHeatRejectionLocation ParasiticHeatRejectionLocation { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_ParasiticHeatRejectionLocation)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_ParasiticHeatRejectionLocation), "Outdoors");
        

[Description("Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise leave fi" +
    "eld blank.")]
[JsonProperty("inlet_air_mixer_node_name")]
public string InletAirMixerNodeName { get; set; } = "";
        

[Description("Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise leave fi" +
    "eld blank.")]
[JsonProperty("outlet_air_splitter_node_name")]
public string OutletAirSplitterNodeName { get; set; } = "";
        

[Description(@"Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise leave field blank. Schedule values define whether the heat pump draws its inlet air from the zone, outdoors or a combination of zone and outdoor air. A schedule value of 0 denotes inlet air is drawn only from the zone. A schedule value of 1 denotes inlet air is drawn only from outdoors. Schedule values between 0 and 1 denote a mixture of zone and outdoor air proportional to the schedule value (i.e. 0.4 = 40% outdoor air, 60% zone air).")]
[JsonProperty("inlet_air_mixer_schedule_name")]
public string InletAirMixerScheduleName { get; set; } = "";
        

[Description(@"MutuallyExclusive means that once the tank heating element is active the heat pump is shut down until setpoint is reached. Simultaneous (default) means that both the tank heating element and heat pump are used at the same time recover the tank temperature.")]
[JsonProperty("tank_element_control_logic")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_PumpedCondenser_TankElementControlLogic TankElementControlLogic { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_TankElementControlLogic)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_TankElementControlLogic), "Simultaneous");
        

[Description("Used to indicate height of control sensor for Tank Object Type = WaterHeater:Stra" +
    "tified If left blank, it will default to the height of Heater1")]
[JsonProperty("control_sensor_1_height_in_stratified_tank")]
public System.Nullable<float> ControlSensor1HeightInStratifiedTank { get; set; } = null;
        

[Description("Weight to give Control Sensor 1 temperature The weight of Control Sensor 2 will b" +
    "e 1 - (wt. of control sensor 1)")]
[JsonProperty("control_sensor_1_weight")]
public System.Nullable<float> ControlSensor1Weight { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Used to indicate height of control sensor for Tank Object Type = WaterHeater:Stra" +
    "tified If left blank, it will default to the height of Heater2")]
[JsonProperty("control_sensor_2_height_in_stratified_tank")]
public System.Nullable<float> ControlSensor2HeightInStratifiedTank { get; set; } = null;
    }
    
    public enum WaterHeater_HeatPump_PumpedCondenser_InletAirConfiguration
    {
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAirOnly")]
        OutdoorAirOnly = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAirOnly")]
        ZoneAirOnly = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAndOutdoorAir")]
        ZoneAndOutdoorAir = 3,
    }
    
    public enum WaterHeater_HeatPump_PumpedCondenser_TankObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="WaterHeater:Mixed")]
        WaterHeaterMixed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="WaterHeater:Stratified")]
        WaterHeaterStratified = 2,
    }
    
    public enum WaterHeater_HeatPump_PumpedCondenser_DxCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:WaterHeating:AirToWaterHeatPump:Pumped")]
        CoilWaterHeatingAirToWaterHeatPumpPumped = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:WaterHeating:AirToWaterHeatPump:VariableSpeed")]
        CoilWaterHeatingAirToWaterHeatPumpVariableSpeed = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CoilSystem:IntegratedHeatPump:AirSource")]
        CoilSystemIntegratedHeatPumpAirSource = 3,
    }
    
    public enum WaterHeater_HeatPump_PumpedCondenser_CompressorLocation
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 2,
    }
    
    public enum WaterHeater_HeatPump_PumpedCondenser_FanObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:OnOff")]
        FanOnOff = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:SystemModel")]
        FanSystemModel = 2,
    }
    
    public enum WaterHeater_HeatPump_PumpedCondenser_FanPlacement
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BlowThrough")]
        BlowThrough = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum WaterHeater_HeatPump_PumpedCondenser_ParasiticHeatRejectionLocation
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 2,
    }
    
    public enum WaterHeater_HeatPump_PumpedCondenser_TankElementControlLogic
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MutuallyExclusive")]
        MutuallyExclusive = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Simultaneous")]
        Simultaneous = 2,
    }
    
    [Description(@"This object models an air-source heat pump for water heating where the heating coil is wrapped around the tank, which is typical of residential HPWHs. For pumped condenser HPWHs, see WaterHeater:HeatPump:PumpedCondenser. WaterHeater:HeatPump:WrappedCondenser is a compound object that references other component objects - Coil:WaterHeating:AirToWaterHeatPump:Pumped, Fan:OnOff, WaterHeater:Mixed")]
    public class WaterHeater_HeatPump_WrappedCondenser : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. Schedule values of 0 denote the heat pump compressor is off and the parasitic electric energy is also off.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Defines the cut-out temperature where the heat pump compressor turns off. The hea" +
    "t pump compressor setpoint temperature should always be greater than the water t" +
    "ank\'s heater (element or burner) setpoint temperature.")]
[JsonProperty("compressor_setpoint_temperature_schedule_name")]
public string CompressorSetpointTemperatureScheduleName { get; set; } = "";
        

[Description(@"Setpoint temperature minus the dead band temperature difference defines the cut-in temperature where the heat pump compressor turns on. The water tank's heater (element or burner) setpoint temperature should always be less than the heat pump compressor cut-in temperature.")]
[JsonProperty("dead_band_temperature_difference")]
public System.Nullable<float> DeadBandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[Description("Distance from the bottom of the tank to the bottom of the wrapped condenser.")]
[JsonProperty("condenser_bottom_location")]
public System.Nullable<float> CondenserBottomLocation { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Distance from the bottom of the tank to the top of the wrapped condenser.")]
[JsonProperty("condenser_top_location")]
public System.Nullable<float> CondenserTopLocation { get; set; } = null;
        

[Description("Actual air flow rate across the heat pump\'s air coil (evaporator). If autocalcula" +
    "ted, the air flow rate is set equal to 5.035E-5 m3/s/W times the rated heating c" +
    "apacity of the heat pump\'s DX coil.")]
[JsonProperty("evaporator_air_flow_rate")]
public string EvaporatorAirFlowRate { get; set; } = "";
        

[Description("Defines the configuration of the airflow path through the air coil and fan sectio" +
    "n.")]
[JsonProperty("inlet_air_configuration")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_WrappedCondenser_InletAirConfiguration InletAirConfiguration { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_InletAirConfiguration)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_InletAirConfiguration), "OutdoorAirOnly");
        

[Description("Zone air exhaust node name if Inlet Air Configuration is ZoneAirOnly or ZoneAndOu" +
    "tdoorAir. Simply a unique Node Name if Inlet Air Configuration is Schedule. Othe" +
    "rwise, leave field blank.")]
[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[Description("Zone Air Inlet Node Name if Inlet Air Configuration is ZoneAirOnly or ZoneAndOutd" +
    "oorAir. Simply a unique Node Name if Inlet Air Configuration is Schedule. Otherw" +
    "ise, leave field blank.")]
[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Outdoor air node name if inlet air configuration is ZoneAndOutdoorAir or OutdoorA" +
    "irOnly, otherwise leave field blank.")]
[JsonProperty("outdoor_air_node_name")]
public string OutdoorAirNodeName { get; set; } = "";
        

[Description("Simply a unique Node Name if Inlet Air Configuration is ZoneAndOutdoorAir or Outd" +
    "oorAirOnly, otherwise leave field blank.")]
[JsonProperty("exhaust_air_node_name")]
public string ExhaustAirNodeName { get; set; } = "";
        

[Description("Used only if Inlet Air Configuration is Schedule, otherwise leave blank. Schedule" +
    " values should be degrees C.")]
[JsonProperty("inlet_air_temperature_schedule_name")]
public string InletAirTemperatureScheduleName { get; set; } = "";
        

[Description("Used only if Inlet Air Configuration is Schedule, otherwise leave blank. Schedule" +
    " values are entered as a fraction (e.g. 0.5 is equal to 50%RH)")]
[JsonProperty("inlet_air_humidity_schedule_name")]
public string InletAirHumidityScheduleName { get; set; } = "";
        

[Description("Used only if Inlet Air Configuration is ZoneAirOnly or ZoneAndOutdoorAir. Otherwi" +
    "se, leave field blank.")]
[JsonProperty("inlet_air_zone_name")]
public string InletAirZoneName { get; set; } = "";
        

[Description("Specify the type of water heater tank used by this heat pump water heater.")]
[JsonProperty("tank_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_WrappedCondenser_TankObjectType TankObjectType { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_TankObjectType)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_TankObjectType), "Empty");
        

[Description("Needs to match the name used in the corresponding Water Heater object. Must be a " +
    "WaterHeater:Stratified tank.")]
[JsonProperty("tank_name")]
public string TankName { get; set; } = "";
        

[Description("Used only when the heat pump water heater is connected to a plant loop, otherwise" +
    " leave blank. Needs to match the name used in the corresponding Water Heater obj" +
    "ect when connected to a plant loop.")]
[JsonProperty("tank_use_side_inlet_node_name")]
public string TankUseSideInletNodeName { get; set; } = "";
        

[Description("Used only when the heat pump water heater is connected to a plant loop, otherwise" +
    " leave blank. Needs to match the name used in the corresponding Water Heater obj" +
    "ect when connected to a plant loop.")]
[JsonProperty("tank_use_side_outlet_node_name")]
public string TankUseSideOutletNodeName { get; set; } = "";
        

[Description("Specify the type of DX coil used by this heat pump water heater. The only valid c" +
    "hoice is Coil:WaterHeating:AirToWaterHeatPump:Wrapped")]
[JsonProperty("dx_coil_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_WrappedCondenser_DxCoilObjectType DxCoilObjectType { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_DxCoilObjectType)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_DxCoilObjectType), "Empty");
        

[Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
    "p:Wrapped object.")]
[JsonProperty("dx_coil_name")]
public string DxCoilName { get; set; } = "";
        

[Description("Heat pump compressor will not operate when the inlet air dry-bulb temperature is " +
    "below this value.")]
[JsonProperty("minimum_inlet_air_temperature_for_compressor_operation")]
public System.Nullable<float> MinimumInletAirTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("Heat pump compressor will not operate when the inlet air dry-bulb temperature is " +
    "above this value.")]
[JsonProperty("maximum_inlet_air_temperature_for_compressor_operation")]
public System.Nullable<float> MaximumInletAirTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("48.88888888889", CultureInfo.InvariantCulture);
        

[Description("If Zone is selected, Inlet Air Configuration must be ZoneAirOnly or ZoneAndOutdoo" +
    "rAir. If Schedule is selected, then you must provide a Compressor Ambient Temper" +
    "ature Schedule Name below.")]
[JsonProperty("compressor_location")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_WrappedCondenser_CompressorLocation CompressorLocation { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_CompressorLocation)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_CompressorLocation), "Outdoors");
        

[Description("Used only if Compressor Location is Schedule, otherwise leave field blank.")]
[JsonProperty("compressor_ambient_temperature_schedule_name")]
public string CompressorAmbientTemperatureScheduleName { get; set; } = "";
        

[Description("Specify the type of fan used by this heat pump water heater. The only valid choic" +
    "es are Fan:SystemModel or Fan:OnOff.")]
[JsonProperty("fan_object_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_WrappedCondenser_FanObjectType FanObjectType { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_FanObjectType)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_FanObjectType), "Empty");
        

[Description("Needs to match the name used in the corresponding Fan:SystemModel or Fan:OnOff ob" +
    "ject.")]
[JsonProperty("fan_name")]
public string FanName { get; set; } = "";
        

[Description("BlowThrough means the fan is located before the air coil (upstream). DrawThrough " +
    "means the fan is located after the air coil (downstream).")]
[JsonProperty("fan_placement")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_WrappedCondenser_FanPlacement FanPlacement { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_FanPlacement)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_FanPlacement), "DrawThrough");
        

[Description("Parasitic electric power consumed when the heat pump compressor operates. Does no" +
    "t contribute to water heating but can impact the zone air heat balance.")]
[JsonProperty("on_cycle_parasitic_electric_load")]
public System.Nullable<float> OnCycleParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Parasitic electric power consumed when the heat pump compressor is off. Does not " +
    "contribute to water heating but can impact the zone air heat balance. Off-cycle " +
    "parasitic power is 0 when the availability schedule is 0.")]
[JsonProperty("off_cycle_parasitic_electric_load")]
public System.Nullable<float> OffCycleParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field determines if the parasitic electric load impacts the zone air heat ba" +
    "lance. If Zone is selected, Inlet Air Configuration must be ZoneAirOnly or ZoneA" +
    "ndOutdoorAir.")]
[JsonProperty("parasitic_heat_rejection_location")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_WrappedCondenser_ParasiticHeatRejectionLocation ParasiticHeatRejectionLocation { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_ParasiticHeatRejectionLocation)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_ParasiticHeatRejectionLocation), "Outdoors");
        

[Description("Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise leave fi" +
    "eld blank.")]
[JsonProperty("inlet_air_mixer_node_name")]
public string InletAirMixerNodeName { get; set; } = "";
        

[Description("Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise leave fi" +
    "eld blank.")]
[JsonProperty("outlet_air_splitter_node_name")]
public string OutletAirSplitterNodeName { get; set; } = "";
        

[Description(@"Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise leave field blank. Schedule values define whether the heat pump draws its inlet air from the zone, outdoors or a combination of zone and outdoor air. A schedule value of 0 denotes inlet air is drawn only from the zone. A schedule value of 1 denotes inlet air is drawn only from outdoors. Schedule values between 0 and 1 denote a mixture of zone and outdoor air proportional to the schedule value.")]
[JsonProperty("inlet_air_mixer_schedule_name")]
public string InletAirMixerScheduleName { get; set; } = "";
        

[Description(@"MutuallyExclusive means that once the tank heating element is active the heat pump is shut down until setpoint is reached. Simultaneous (default) means that both the tank heating element and heat pump are used at the same time recover the tank temperature.")]
[JsonProperty("tank_element_control_logic")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public WaterHeater_HeatPump_WrappedCondenser_TankElementControlLogic TankElementControlLogic { get; set; } = (WaterHeater_HeatPump_WrappedCondenser_TankElementControlLogic)Enum.Parse(typeof(WaterHeater_HeatPump_WrappedCondenser_TankElementControlLogic), "Simultaneous");
        

[Description("Used to indicate height of control sensor if Tank Object Type is WaterHeater:Stra" +
    "tified If left blank, it will default to the height of Heater1")]
[JsonProperty("control_sensor_1_height_in_stratified_tank")]
public System.Nullable<float> ControlSensor1HeightInStratifiedTank { get; set; } = null;
        

[Description("Weight to give Control Sensor 1 temperature")]
[JsonProperty("control_sensor_1_weight")]
public System.Nullable<float> ControlSensor1Weight { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Used to indicate height of control sensor if Tank Object Type is WaterHeater:Stra" +
    "tified If left blank, it will default to the height of Heater2 The weight of thi" +
    "s control sensor will be 1 - (wt. of control sensor 1)")]
[JsonProperty("control_sensor_2_height_in_stratified_tank")]
public System.Nullable<float> ControlSensor2HeightInStratifiedTank { get; set; } = null;
    }
    
    public enum WaterHeater_HeatPump_WrappedCondenser_InletAirConfiguration
    {
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorAirOnly")]
        OutdoorAirOnly = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAirOnly")]
        ZoneAirOnly = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ZoneAndOutdoorAir")]
        ZoneAndOutdoorAir = 3,
    }
    
    public enum WaterHeater_HeatPump_WrappedCondenser_TankObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="WaterHeater:Stratified")]
        WaterHeaterStratified = 1,
    }
    
    public enum WaterHeater_HeatPump_WrappedCondenser_DxCoilObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Coil:WaterHeating:AirToWaterHeatPump:Wrapped")]
        CoilWaterHeatingAirToWaterHeatPumpWrapped = 1,
    }
    
    public enum WaterHeater_HeatPump_WrappedCondenser_CompressorLocation
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 2,
    }
    
    public enum WaterHeater_HeatPump_WrappedCondenser_FanObjectType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:OnOff")]
        FanOnOff = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Fan:SystemModel")]
        FanSystemModel = 2,
    }
    
    public enum WaterHeater_HeatPump_WrappedCondenser_FanPlacement
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="BlowThrough")]
        BlowThrough = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DrawThrough")]
        DrawThrough = 2,
    }
    
    public enum WaterHeater_HeatPump_WrappedCondenser_ParasiticHeatRejectionLocation
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 2,
    }
    
    public enum WaterHeater_HeatPump_WrappedCondenser_TankElementControlLogic
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MutuallyExclusive")]
        MutuallyExclusive = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Simultaneous")]
        Simultaneous = 2,
    }
    
    [Description(@"This ice storage model is a simplified model It requires a setpoint placed on the Chilled Water Side Outlet Node It should be placed in the chilled water supply side outlet branch followed by a pipe. Use the PlantEquipmentOperation:ComponentSetpoint plant operation scheme.")]
    public class ThermalStorage_Ice_Simple : BHoMObject, IEnergyPlusClass
    {
        

[Description("IceOnCoilInternal = Ice-on-Coil, internal melt IceOnCoilExternal = Ice-on-Coil, e" +
    "xternal melt")]
[JsonProperty("ice_storage_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ThermalStorage_Ice_Simple_IceStorageType IceStorageType { get; set; } = (ThermalStorage_Ice_Simple_IceStorageType)Enum.Parse(typeof(ThermalStorage_Ice_Simple_IceStorageType), "IceOnCoilExternal");
        

[JsonProperty("capacity")]
public System.Nullable<float> Capacity { get; set; } = null;
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
    }
    
    public enum ThermalStorage_Ice_Simple_IceStorageType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="IceOnCoilExternal")]
        IceOnCoilExternal = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="IceOnCoilInternal")]
        IceOnCoilInternal = 1,
    }
    
    [Description("This input syntax is intended to describe a thermal storage system that includes " +
        "smaller containers filled with water that are placed in a larger tank or series " +
        "of tanks. The model uses polynomial equations to describe the system performance" +
        ".")]
    public class ThermalStorage_Ice_Detailed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("This includes only the latent storage capacity")]
[JsonProperty("capacity")]
public System.Nullable<float> Capacity { get; set; } = null;
        

[JsonProperty("inlet_node_name")]
public string InletNodeName { get; set; } = "";
        

[JsonProperty("outlet_node_name")]
public string OutletNodeName { get; set; } = "";
        

[JsonProperty("discharging_curve_variable_specifications")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ThermalStorage_Ice_Detailed_DischargingCurveVariableSpecifications DischargingCurveVariableSpecifications { get; set; } = (ThermalStorage_Ice_Detailed_DischargingCurveVariableSpecifications)Enum.Parse(typeof(ThermalStorage_Ice_Detailed_DischargingCurveVariableSpecifications), "FractionChargedLMTD");
        

[JsonProperty("discharging_curve_name")]
public string DischargingCurveName { get; set; } = "";
        

[JsonProperty("charging_curve_variable_specifications")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ThermalStorage_Ice_Detailed_ChargingCurveVariableSpecifications ChargingCurveVariableSpecifications { get; set; } = (ThermalStorage_Ice_Detailed_ChargingCurveVariableSpecifications)Enum.Parse(typeof(ThermalStorage_Ice_Detailed_ChargingCurveVariableSpecifications), "FractionChargedLMTD");
        

[JsonProperty("charging_curve_name")]
public string ChargingCurveName { get; set; } = "";
        

[JsonProperty("timestep_of_the_curve_data")]
public System.Nullable<float> TimestepOfTheCurveData { get; set; } = null;
        

[JsonProperty("parasitic_electric_load_during_discharging")]
public System.Nullable<float> ParasiticElectricLoadDuringDischarging { get; set; } = null;
        

[JsonProperty("parasitic_electric_load_during_charging")]
public System.Nullable<float> ParasiticElectricLoadDuringCharging { get; set; } = null;
        

[Description("This is the fraction the total storage capacity that is lost or melts each hour")]
[JsonProperty("tank_loss_coefficient")]
public System.Nullable<float> TankLossCoefficient { get; set; } = null;
        

[Description("This temperature is typically 0C for water. Simply changing this temperature with" +
    "out adjusting the performance parameters input above is inappropriate and not ad" +
    "vised.")]
[JsonProperty("freezing_temperature_of_storage_medium")]
public System.Nullable<float> FreezingTemperatureOfStorageMedium { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field determines whether the system uses internal or external melt during di" +
    "scharging. This will then have an impact on charging performance.")]
[JsonProperty("thaw_process_indicator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ThermalStorage_Ice_Detailed_ThawProcessIndicator ThawProcessIndicator { get; set; } = (ThermalStorage_Ice_Detailed_ThawProcessIndicator)Enum.Parse(typeof(ThermalStorage_Ice_Detailed_ThawProcessIndicator), "OutsideMelt");
    }
    
    public enum ThermalStorage_Ice_Detailed_DischargingCurveVariableSpecifications
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FractionChargedLMTD")]
        FractionChargedLMTD = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionDischargedLMTD")]
        FractionDischargedLMTD = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="LMTDFractionCharged")]
        LMTDFractionCharged = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="LMTDMassFlow")]
        LMTDMassFlow = 3,
    }
    
    public enum ThermalStorage_Ice_Detailed_ChargingCurveVariableSpecifications
    {
        
        [System.Runtime.Serialization.EnumMember(Value="FractionChargedLMTD")]
        FractionChargedLMTD = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FractionDischargedLMTD")]
        FractionDischargedLMTD = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="LMTDFractionCharged")]
        LMTDFractionCharged = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="LMTDMassFlow")]
        LMTDMassFlow = 3,
    }
    
    public enum ThermalStorage_Ice_Detailed_ThawProcessIndicator
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="InsideMelt")]
        InsideMelt = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="OutsideMelt")]
        OutsideMelt = 2,
    }
    
    [Description("Chilled water storage with a well-mixed, single-node tank. The chilled water is \"" +
        "used\" by drawing from the \"Use Side\" of the water tank. The tank is indirectly c" +
        "harged by circulating cold water through the \"Source Side\" of the water tank.")]
    public class ThermalStorage_ChilledWater_Mixed : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("tank_volume")]
public System.Nullable<float> TankVolume { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[JsonProperty("setpoint_temperature_schedule_name")]
public string SetpointTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("deadband_temperature_difference")]
public System.Nullable<float> DeadbandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_temperature_limit")]
public System.Nullable<float> MinimumTemperatureLimit { get; set; } = null;
        

[JsonProperty("nominal_cooling_capacity")]
public System.Nullable<float> NominalCoolingCapacity { get; set; } = null;
        

[JsonProperty("ambient_temperature_indicator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ThermalStorage_ChilledWater_Mixed_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (ThermalStorage_ChilledWater_Mixed_AmbientTemperatureIndicator)Enum.Parse(typeof(ThermalStorage_ChilledWater_Mixed_AmbientTemperatureIndicator), "Outdoors");
        

[JsonProperty("ambient_temperature_schedule_name")]
public string AmbientTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("ambient_temperature_zone_name")]
public string AmbientTemperatureZoneName { get; set; } = "";
        

[Description("required when field Ambient Temperature Indicator=Outdoors")]
[JsonProperty("ambient_temperature_outdoor_air_node_name")]
public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

[JsonProperty("heat_gain_coefficient_from_ambient_temperature")]
public System.Nullable<float> HeatGainCoefficientFromAmbientTemperature { get; set; } = null;
        

[JsonProperty("use_side_inlet_node_name")]
public string UseSideInletNodeName { get; set; } = "";
        

[JsonProperty("use_side_outlet_node_name")]
public string UseSideOutletNodeName { get; set; } = "";
        

[JsonProperty("use_side_heat_transfer_effectiveness")]
public System.Nullable<float> UseSideHeatTransferEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Availability schedule name for use side. Schedule value > 0 means the system is a" +
    "vailable. If this field is blank, the system is always available.")]
[JsonProperty("use_side_availability_schedule_name")]
public string UseSideAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("use_side_design_flow_rate")]
public string UseSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("source_side_inlet_node_name")]
public string SourceSideInletNodeName { get; set; } = "";
        

[JsonProperty("source_side_outlet_node_name")]
public string SourceSideOutletNodeName { get; set; } = "";
        

[JsonProperty("source_side_heat_transfer_effectiveness")]
public System.Nullable<float> SourceSideHeatTransferEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Availability schedule name for source side. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("source_side_availability_schedule_name")]
public string SourceSideAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("source_side_design_flow_rate")]
public string SourceSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Parameter for autosizing design flow rates for indirectly cooled water tanks time" +
    " required to lower temperature of entire tank from 14.4C to 9.0C")]
[JsonProperty("tank_recovery_time")]
public System.Nullable<float> TankRecoveryTime { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
    }
    
    public enum ThermalStorage_ChilledWater_Mixed_AmbientTemperatureIndicator
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 2,
    }
    
    [Description("Chilled water storage with a stratified, multi-node tank. The chilled water is \"u" +
        "sed\" by drawing from the \"Use Side\" of the water tank. The tank is indirectly ch" +
        "arged by circulating cold water through the \"Source Side\" of the water tank.")]
    public class ThermalStorage_ChilledWater_Stratified : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("tank_volume")]
public System.Nullable<float> TankVolume { get; set; } = null;
        

[Description("Height is measured in the axial direction for horizontal cylinders")]
[JsonProperty("tank_height")]
public System.Nullable<float> TankHeight { get; set; } = null;
        

[JsonProperty("tank_shape")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ThermalStorage_ChilledWater_Stratified_TankShape TankShape { get; set; } = (ThermalStorage_ChilledWater_Stratified_TankShape)Enum.Parse(typeof(ThermalStorage_ChilledWater_Stratified_TankShape), "VerticalCylinder");
        

[Description("Only used if Tank Shape is Other")]
[JsonProperty("tank_perimeter")]
public System.Nullable<float> TankPerimeter { get; set; } = null;
        

[JsonProperty("setpoint_temperature_schedule_name")]
public string SetpointTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("deadband_temperature_difference")]
public System.Nullable<float> DeadbandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("temperature_sensor_height")]
public System.Nullable<float> TemperatureSensorHeight { get; set; } = null;
        

[JsonProperty("minimum_temperature_limit")]
public System.Nullable<float> MinimumTemperatureLimit { get; set; } = null;
        

[JsonProperty("nominal_cooling_capacity")]
public System.Nullable<float> NominalCoolingCapacity { get; set; } = null;
        

[JsonProperty("ambient_temperature_indicator")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ThermalStorage_ChilledWater_Stratified_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (ThermalStorage_ChilledWater_Stratified_AmbientTemperatureIndicator)Enum.Parse(typeof(ThermalStorage_ChilledWater_Stratified_AmbientTemperatureIndicator), "Outdoors");
        

[JsonProperty("ambient_temperature_schedule_name")]
public string AmbientTemperatureScheduleName { get; set; } = "";
        

[JsonProperty("ambient_temperature_zone_name")]
public string AmbientTemperatureZoneName { get; set; } = "";
        

[Description("required for Ambient Temperature Indicator=Outdoors")]
[JsonProperty("ambient_temperature_outdoor_air_node_name")]
public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

[JsonProperty("uniform_skin_loss_coefficient_per_unit_area_to_ambient_temperature")]
public System.Nullable<float> UniformSkinLossCoefficientPerUnitAreaToAmbientTemperature { get; set; } = null;
        

[JsonProperty("use_side_inlet_node_name")]
public string UseSideInletNodeName { get; set; } = "";
        

[JsonProperty("use_side_outlet_node_name")]
public string UseSideOutletNodeName { get; set; } = "";
        

[Description(@"The use side effectiveness in the stratified tank model is a simplified analogy of a heat exchanger's effectiveness. This effectiveness is equal to the fraction of use mass flow rate that directly mixes with the tank fluid. And one minus the effectiveness is the fraction that bypasses the tank. The use side mass flow rate that bypasses the tank is mixed with the fluid or water leaving the stratified tank.")]
[JsonProperty("use_side_heat_transfer_effectiveness")]
public System.Nullable<float> UseSideHeatTransferEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Availability schedule name for use side. Schedule value > 0 means the system is a" +
    "vailable. If this field is blank, the system is always available.")]
[JsonProperty("use_side_availability_schedule_name")]
public string UseSideAvailabilityScheduleName { get; set; } = "";
        

[Description("Defaults to top of tank")]
[JsonProperty("use_side_inlet_height")]
public string UseSideInletHeight { get; set; } = (System.String)"Autocalculate";
        

[Description("Defaults to bottom of tank")]
[JsonProperty("use_side_outlet_height")]
public System.Nullable<float> UseSideOutletHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("use_side_design_flow_rate")]
public string UseSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("source_side_inlet_node_name")]
public string SourceSideInletNodeName { get; set; } = "";
        

[JsonProperty("source_side_outlet_node_name")]
public string SourceSideOutletNodeName { get; set; } = "";
        

[Description(@"The source side effectiveness in the stratified tank model is a simplified analogy of a heat exchanger's effectiveness. This effectiveness is equal to the fraction of source mass flow rate that directly mixes with the tank fluid. And one minus the effectiveness is the fraction that bypasses the tank. The source side mass flow rate that bypasses the tank is mixed with the fluid or water leaving the stratified tank.")]
[JsonProperty("source_side_heat_transfer_effectiveness")]
public System.Nullable<float> SourceSideHeatTransferEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Availability schedule name for use side. Schedule value > 0 means the system is a" +
    "vailable. If this field is blank, the system is always available.")]
[JsonProperty("source_side_availability_schedule_name")]
public string SourceSideAvailabilityScheduleName { get; set; } = "";
        

[Description("Defaults to bottom of tank")]
[JsonProperty("source_side_inlet_height")]
public System.Nullable<float> SourceSideInletHeight { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Defaults to top of tank")]
[JsonProperty("source_side_outlet_height")]
public string SourceSideOutletHeight { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("source_side_design_flow_rate")]
public string SourceSideDesignFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Parameter for autosizing design flow rates for indirectly cooled water tanks time" +
    " required to lower temperature of entire tank from 14.4C to 9.0C")]
[JsonProperty("tank_recovery_time")]
public System.Nullable<float> TankRecoveryTime { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

[JsonProperty("inlet_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ThermalStorage_ChilledWater_Stratified_InletMode InletMode { get; set; } = (ThermalStorage_ChilledWater_Stratified_InletMode)Enum.Parse(typeof(ThermalStorage_ChilledWater_Stratified_InletMode), "Fixed");
        

[JsonProperty("number_of_nodes")]
public System.Nullable<float> NumberOfNodes { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("additional_destratification_conductivity")]
public System.Nullable<float> AdditionalDestratificationConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_1_additional_loss_coefficient")]
public System.Nullable<float> Node1AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_2_additional_loss_coefficient")]
public System.Nullable<float> Node2AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_3_additional_loss_coefficient")]
public System.Nullable<float> Node3AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_4_additional_loss_coefficient")]
public System.Nullable<float> Node4AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_5_additional_loss_coefficient")]
public System.Nullable<float> Node5AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_6_additional_loss_coefficient")]
public System.Nullable<float> Node6AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_7_additional_loss_coefficient")]
public System.Nullable<float> Node7AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_8_additional_loss_coefficient")]
public System.Nullable<float> Node8AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_9_additional_loss_coefficient")]
public System.Nullable<float> Node9AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("node_10_additional_loss_coefficient")]
public System.Nullable<float> Node10AdditionalLossCoefficient { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum ThermalStorage_ChilledWater_Stratified_TankShape
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="HorizontalCylinder")]
        HorizontalCylinder = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Other")]
        Other = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="VerticalCylinder")]
        VerticalCylinder = 3,
    }
    
    public enum ThermalStorage_ChilledWater_Stratified_AmbientTemperatureIndicator
    {
        
        [System.Runtime.Serialization.EnumMember(Value="Outdoors")]
        Outdoors = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Schedule")]
        Schedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Zone")]
        Zone = 2,
    }
    
    public enum ThermalStorage_ChilledWater_Stratified_InletMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Fixed")]
        Fixed = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Seeking")]
        Seeking = 2,
    }
}