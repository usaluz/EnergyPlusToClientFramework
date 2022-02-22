namespace BH.oM.Adapters.EnergyPlus.Coils
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
    using BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage;
    using BH.oM.Adapters.EnergyPlus.WaterSystems;
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("Chilled water cooling coil, NTU-effectiveness model, with inputs for design enter" +
        "ing and leaving conditions.")]
    [JsonObject("Coil:Cooling:Water")]
    public class Coil_Cooling_Water : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("design_water_flow_rate")]
public string DesignWaterFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_air_flow_rate")]
public string DesignAirFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_inlet_water_temperature")]
public string DesignInletWaterTemperature { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_inlet_air_temperature")]
public string DesignInletAirTemperature { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_outlet_air_temperature")]
public string DesignOutletAirTemperature { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_inlet_air_humidity_ratio")]
public string DesignInletAirHumidityRatio { get; set; } = (System.String)"Autosize";
        

[JsonProperty("design_outlet_air_humidity_ratio")]
public string DesignOutletAirHumidityRatio { get; set; } = (System.String)"Autosize";
        

[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("type_of_analysis")]
public Coil_Cooling_Water_TypeOfAnalysis TypeOfAnalysis { get; set; } = (Coil_Cooling_Water_TypeOfAnalysis)Enum.Parse(typeof(Coil_Cooling_Water_TypeOfAnalysis), "SimpleAnalysis");
        

[JsonProperty("heat_exchanger_configuration")]
public Coil_Cooling_Water_HeatExchangerConfiguration HeatExchangerConfiguration { get; set; } = (Coil_Cooling_Water_HeatExchangerConfiguration)Enum.Parse(typeof(Coil_Cooling_Water_HeatExchangerConfiguration), "CounterFlow");
        

[JsonProperty("condensate_collection_water_storage_tank_name")]
public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

[Description("This input field is optional. If specified, it is used for sizing the Design Wate" +
    "r Flow Rate. If blank or omitted, the Loop Design Temperature Difference value s" +
    "pecified in Sizing:Plant object is used for sizing the Design Water Flow Rate.")]
[JsonProperty("design_water_temperature_difference")]
public System.Nullable<float> DesignWaterTemperatureDifference { get; set; } = null;
    }
    
    public enum Coil_Cooling_Water_TypeOfAnalysis
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DetailedAnalysis")]
        DetailedAnalysis = 1,
        
        [JsonProperty("SimpleAnalysis")]
        SimpleAnalysis = 2,
    }
    
    public enum Coil_Cooling_Water_HeatExchangerConfiguration
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("CounterFlow")]
        CounterFlow = 1,
        
        [JsonProperty("CrossFlow")]
        CrossFlow = 2,
    }
    
    [Description("Chilled water cooling coil, detailed flat fin coil model for continuous plate fin" +
        "s, with inputs for detailed coil geometry specifications.")]
    [JsonObject("Coil:Cooling:Water:DetailedGeometry")]
    public class Coil_Cooling_Water_DetailedGeometry : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("maximum_water_flow_rate")]
public string MaximumWaterFlowRate { get; set; } = (System.String)"Autosize";
        

[Description("Tube Primary Surface Area")]
[JsonProperty("tube_outside_surface_area")]
public string TubeOutsideSurfaceArea { get; set; } = (System.String)"Autosize";
        

[Description("Total tube inside surface area")]
[JsonProperty("total_tube_inside_area")]
public string TotalTubeInsideArea { get; set; } = (System.String)"Autosize";
        

[JsonProperty("fin_surface_area")]
public string FinSurfaceArea { get; set; } = (System.String)"Autosize";
        

[JsonProperty("minimum_airflow_area")]
public string MinimumAirflowArea { get; set; } = (System.String)"Autosize";
        

[JsonProperty("coil_depth")]
public string CoilDepth { get; set; } = (System.String)"Autosize";
        

[Description("Fin diameter or the coil height")]
[JsonProperty("fin_diameter")]
public string FinDiameter { get; set; } = (System.String)"Autosize";
        

[JsonProperty("fin_thickness")]
public System.Nullable<float> FinThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.0015", CultureInfo.InvariantCulture);
        

[Description("Inner diameter of tubes")]
[JsonProperty("tube_inside_diameter")]
public System.Nullable<float> TubeInsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.01445", CultureInfo.InvariantCulture);
        

[Description("Outer diameter of tubes")]
[JsonProperty("tube_outside_diameter")]
public System.Nullable<float> TubeOutsideDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.0159", CultureInfo.InvariantCulture);
        

[JsonProperty("tube_thermal_conductivity")]
public System.Nullable<float> TubeThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("386", CultureInfo.InvariantCulture);
        

[JsonProperty("fin_thermal_conductivity")]
public System.Nullable<float> FinThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("204", CultureInfo.InvariantCulture);
        

[Description("Fin spacing or distance")]
[JsonProperty("fin_spacing")]
public System.Nullable<float> FinSpacing { get; set; } = (System.Nullable<float>)Single.Parse("0.0018", CultureInfo.InvariantCulture);
        

[JsonProperty("tube_depth_spacing")]
public System.Nullable<float> TubeDepthSpacing { get; set; } = (System.Nullable<float>)Single.Parse("0.026", CultureInfo.InvariantCulture);
        

[JsonProperty("number_of_tube_rows")]
public System.Nullable<float> NumberOfTubeRows { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

[JsonProperty("number_of_tubes_per_row")]
public string NumberOfTubesPerRow { get; set; } = (System.String)"Autosize";
        

[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("condensate_collection_water_storage_tank_name")]
public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

[Description("This input field is optional. If specified, it is used for sizing the Design Wate" +
    "r Flow Rate. If blank or omitted, the Loop Design Temperature Difference value s" +
    "pecified in Sizing:Plant object is used for sizing the Design Water Flow Rate.")]
[JsonProperty("design_water_temperature_difference")]
public System.Nullable<float> DesignWaterTemperatureDifference { get; set; } = null;
    }
    
    [Description(@"New general DX cooling coil supporting on or more speeds and one or or operating  modes. Includes DX evaporator coil, compressor, and condenser. Object is currently only supported by the AIRLOOPHVAC:UNITARYSYSTEM object. Remaining Coil:Cooling:DX* objects will be deprecated at a future date, after which, this object will replace all other Coil:Cooling:DX* objects.")]
    [JsonObject("Coil:Cooling:DX")]
    public class Coil_Cooling_DX : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("evaporator_inlet_node_name")]
public string EvaporatorInletNodeName { get; set; } = "";
        

[JsonProperty("evaporator_outlet_node_name")]
public string EvaporatorOutletNodeName { get; set; } = "";
        

[Description("Schedule value > 0 means the coil is available. If this field is blank, the coil " +
    "is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (condenser) of a DX system or heat pump is to be placed. This is an optional input field specified only when the user desires to reject the condenser heat into a zone. The heat rejected is modeled as internal sensible heat gain of the zone.")]
[JsonProperty("condenser_zone_name")]
public string CondenserZoneName { get; set; } = "";
        

[Description("This is the name of an air node in the simulation. This may be an explicitly defi" +
    "ned outdoor air node, or it may be a separate air node.")]
[JsonProperty("condenser_inlet_node_name")]
public string CondenserInletNodeName { get; set; } = "";
        

[Description("This is the name of an air node in the simulation.")]
[JsonProperty("condenser_outlet_node_name")]
public string CondenserOutletNodeName { get; set; } = "";
        

[JsonProperty("performance_object_name")]
public string PerformanceObjectName { get; set; } = "";
        

[JsonProperty("condensate_collection_water_storage_tank_name")]
public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

[JsonProperty("evaporative_condenser_supply_water_storage_tank_name")]
public string EvaporativeCondenserSupplyWaterStorageTankName { get; set; } = "";
    }
    
    [Description("DX cooling coil performance specification referencing one or more operating modes" +
        ". Mode 1 is always the base design operating mode. Additional modes are optional" +
        " states such as subcool reheat for humidity control.")]
    [JsonObject("Coil:Cooling:DX:CurveFit:Performance")]
    public class Coil_Cooling_DX_CurveFit_Performance : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("crankcase_heater_capacity")]
public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-25", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description(@"Enter pressure drop for the unit containing the coil. This value is only used to calculate Energy Efficiency Ratio (EER), Integrated Energy Efficiency Ratio (IEER), and the Standard Rating (Net) Cooling Capacity. This value is not used for modeling the evaporator fan during simulations.")]
[JsonProperty("unit_internal_static_air_pressure")]
public System.Nullable<float> UnitInternalStaticAirPressure { get; set; } = null;
        

[JsonProperty("capacity_control_method")]
public Coil_Cooling_DX_CurveFit_Performance_CapacityControlMethod CapacityControlMethod { get; set; } = (Coil_Cooling_DX_CurveFit_Performance_CapacityControlMethod)Enum.Parse(typeof(Coil_Cooling_DX_CurveFit_Performance_CapacityControlMethod), "Discrete");
        

[Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the DX coil is off.")]
[JsonProperty("evaporative_condenser_basin_heater_capacity")]
public System.Nullable<float> EvaporativeCondenserBasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
    "or dry-bulb temperature when the basin heater turns on.")]
[JsonProperty("evaporative_condenser_basin_heater_setpoint_temperature")]
public System.Nullable<float> EvaporativeCondenserBasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
[JsonProperty("evaporative_condenser_basin_heater_operating_schedule_name")]
public string EvaporativeCondenserBasinHeaterOperatingScheduleName { get; set; } = "";
        

[JsonProperty("compressor_fuel_type")]
public Coil_Cooling_DX_CurveFit_Performance_CompressorFuelType CompressorFuelType { get; set; } = (Coil_Cooling_DX_CurveFit_Performance_CompressorFuelType)Enum.Parse(typeof(Coil_Cooling_DX_CurveFit_Performance_CompressorFuelType), "Electricity");
        

[Description("Operating Mode 1 is always used as the base design operating mode.")]
[JsonProperty("base_operating_mode")]
public string BaseOperatingMode { get; set; } = "";
        

[Description(@"The alternative operating mode is used for enhanced dehumidification. If this is blank, the coil will always operate in the base operating mode. If an alternate mode is defined here, the coil will use the enhanced mode if activated by the parent system controls.")]
[JsonProperty("alternative_operating_mode_1")]
public string AlternativeOperatingMode1 { get; set; } = "";
        

[Description(@"The alternative operating mode is used for enhanced dehumidification. If this is blank, the coil will always operate in the base operating mode or Alternative Mode 1. If both Alternative Operating Mode 1 and Mode 2 are defined here, the coil will perform both Subcool and Reheat modes for enhanced dehumidification. Alternative Operating Mode 1 is used as Subcool mode, and Alternative Operating Mode 2 is used as Reheat mode.")]
[JsonProperty("alternative_operating_mode_2")]
public string AlternativeOperatingMode2 { get; set; } = "";
    }
    
    public enum Coil_Cooling_DX_CurveFit_Performance_CapacityControlMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Continuous")]
        Continuous = 1,
        
        [JsonProperty("Discrete")]
        Discrete = 2,
    }
    
    public enum Coil_Cooling_DX_CurveFit_Performance_CompressorFuelType
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
    
    [Description("DX cooling coil performance for a single operating mode which may have one or mor" +
        "e speeds.")]
    [JsonObject("Coil:Cooling:DX:CurveFit:OperatingMode")]
    public class Coil_Cooling_DX_CurveFit_OperatingMode : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Total (sensible+latent) cooling capacity not accounting for the effect of supply air fan heat. Rating point: air entering the evaporator coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the condenser coil at 35 C dry-bulb/23.9 C wet-bulb. gross capacity excluding supply air fan heat")]
[JsonProperty("rated_gross_total_cooling_capacity")]
public string RatedGrossTotalCoolingCapacity { get; set; } = (System.String)"Autosize";
        

[Description("Flow rate corresponding to rated total cooling capacity, Rated SHR and Rated COP." +
    " Should be between 0.00004027 m3/s and 0.00006041 m3/s per watt of rated total c" +
    "ooling capacity.")]
[JsonProperty("rated_evaporator_air_flow_rate")]
public string RatedEvaporatorAirFlowRate { get; set; } = "";
        

[Description("Used to calculate evaporative condenser water use.")]
[JsonProperty("rated_condenser_air_flow_rate")]
public string RatedCondenserAirFlowRate { get; set; } = "";
        

[Description("The maximum on-off cycling Rate for the compressor, which occurs at 50% run time " +
    "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("maximum_cycling_rate")]
public System.Nullable<float> MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
[JsonProperty("ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capacity")]
public System.Nullable<float> RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
    "startup. Suggested value is 45; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("latent_capacity_time_constant")]
public System.Nullable<float> LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
[JsonProperty("nominal_time_for_condensate_removal_to_begin")]
public System.Nullable<float> NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("apply_latent_degradation_to_speeds_greater_than_1")]
public EmptyNoYes ApplyLatentDegradationToSpeedsGreaterThan1 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("condenser_type")]
public Coil_Cooling_DX_CurveFit_OperatingMode_CondenserType CondenserType { get; set; } = (Coil_Cooling_DX_CurveFit_OperatingMode_CondenserType)Enum.Parse(typeof(Coil_Cooling_DX_CurveFit_OperatingMode_CondenserType), "AirCooled");
        

[Description("Rated power consumed by the evaporative condenser\'s water pump")]
[JsonProperty("nominal_evaporative_condenser_pump_power")]
public string NominalEvaporativeCondenserPumpPower { get; set; } = (System.String)"0";
        

[Description("Must be lower than or equal to the highest speed number. If blank, defaults to th" +
    "e highest speed number used.")]
[JsonProperty("nominal_speed_number")]
public System.Nullable<float> NominalSpeedNumber { get; set; } = null;
        

[JsonProperty("speed_1_name")]
public string Speed1Name { get; set; } = "";
        

[JsonProperty("speed_2_name")]
public string Speed2Name { get; set; } = "";
        

[JsonProperty("speed_3_name")]
public string Speed3Name { get; set; } = "";
        

[JsonProperty("speed_4_name")]
public string Speed4Name { get; set; } = "";
        

[JsonProperty("speed_5_name")]
public string Speed5Name { get; set; } = "";
        

[JsonProperty("speed_6_name")]
public string Speed6Name { get; set; } = "";
        

[JsonProperty("speed_7_name")]
public string Speed7Name { get; set; } = "";
        

[JsonProperty("speed_8_name")]
public string Speed8Name { get; set; } = "";
        

[JsonProperty("speed_9_name")]
public string Speed9Name { get; set; } = "";
        

[JsonProperty("speed_10_name")]
public string Speed10Name { get; set; } = "";
    }
    
    public enum Coil_Cooling_DX_CurveFit_OperatingMode_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCooled")]
        AirCooled = 1,
        
        [JsonProperty("EvaporativelyCooled")]
        EvaporativelyCooled = 2,
    }
    
    [Description("DX cooling coil performance for a single speed within a single operating mode.")]
    [JsonObject("Coil:Cooling:DX:CurveFit:Speed")]
    public class Coil_Cooling_DX_CurveFit_Speed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Ratio of capacity at this speed to the operating mode Rated Gross Total Cooling C" +
    "apacity")]
[JsonProperty("gross_total_cooling_capacity_fraction")]
public System.Nullable<float> GrossTotalCoolingCapacityFraction { get; set; } = null;
        

[Description("Ratio of capacity at this speed to the operating mode Rated Evaporator Air Flow R" +
    "ate")]
[JsonProperty("evaporator_air_flow_rate_fraction")]
public System.Nullable<float> EvaporatorAirFlowRateFraction { get; set; } = null;
        

[Description("Ratio of condenser air flow at this speed to the operating mode Rated Condenser A" +
    "ir Flow Rate")]
[JsonProperty("condenser_air_flow_rate_fraction")]
public System.Nullable<float> CondenserAirFlowRateFraction { get; set; } = null;
        

[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) sensible" +
    " and total capacities do not include supply fan heat")]
[JsonProperty("gross_sensible_heat_ratio")]
public string GrossSensibleHeatRatio { get; set; } = (System.String)"Autosize";
        

[Description("Gross cooling capacity divided by power input to the compressor and condenser fan" +
    ". Does not include supply fan heat or supply fan electrical energy input.")]
[JsonProperty("gross_cooling_cop")]
public System.Nullable<float> GrossCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("The fraction of the cooling coil face which is actively cooled at this speed. For" +
    " non-split-face coils, this should be 1.0.")]
[JsonProperty("active_fraction_of_coil_face_area")]
public System.Nullable<float> ActiveFractionOfCoilFaceArea { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description(@"Enter the evaporator fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on total cooling capacity. This value is only used to calculate Seasonal Energy Efficiency Ratio (SEER), and the Standard Rating (Net) Cooling Capacity which will be outputs in the EnergyPlus eio file. This value is not used for modeling the evaporator fan during simulations.")]
[JsonProperty("rated_evaporator_fan_power_per_volume_flow_rate")]
public System.Nullable<float> RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

[Description("Ratio of evaporative condenser pump power at this speed to the operating mode Nom" +
    "inal Evaporative Condenser Pump Power")]
[JsonProperty("evaporative_condenser_pump_power_fraction")]
public System.Nullable<float> EvaporativeCondenserPumpPowerFraction { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("evaporative_condenser_effectiveness")]
public System.Nullable<float> EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("biquadratic curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb quadratic cu" +
    "rve = a + b*edb + c*edb**2 wb = entering wet-bulb temperature (C) edb = dry-bulb" +
    " temperature seen by the condenser (C)")]
[JsonProperty("total_cooling_capacity_modifier_function_of_temperature_curve_name")]
public string TotalCoolingCapacityModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = Fraction of the full load flow")]
[JsonProperty("total_cooling_capacity_modifier_function_of_air_flow_fraction_curve_name")]
public string TotalCoolingCapacityModifierFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("energy_input_ratio_modifier_function_of_temperature_curve_name")]
public string EnergyInputRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = Fraction of the full load flow")]
[JsonProperty("energy_input_ratio_modifier_function_of_air_flow_fraction_curve_name")]
public string EnergyInputRatioModifierFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (cooling load/steady state capacity)")]
[JsonProperty("part_load_fraction_correlation_curve_name")]
public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description("Recoverable waste heat at full load and rated conditions")]
[JsonProperty("rated_waste_heat_fraction_of_power_input")]
public System.Nullable<float> RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*cdb + c*cdb**2 + d*edb + e*edb**2 + f*cdb*edb cdb = entering conden" +
    "ser dry-bulb temperature (C) edb = entering coil dry-bulb temperature (C)")]
[JsonProperty("waste_heat_modifier_function_of_temperature_curve_name")]
public string WasteHeatModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the DX cooling coil (C) db = entering dry-bulb temperature seen by the DX cooling coil (C) entering temperature can be outside air or pretreated air. If this curve is used and the Sensible Heat Ratio Modifier Function of Flow Fraction (SHRFFF) Curve Name is blank, the SHRFFF is assumed to be a constant value of 1.0.")]
[JsonProperty("sensible_heat_ratio_modifier_function_of_temperature_curve_name")]
public string SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = fraction of the full load flow If this curve is used and the Sensible Heat Ratio Modifier Function of Temperature Curve Name (SHRFT) Curve Name is blank, the SHRFT is assumed to be a constant value of 1.0.")]
[JsonProperty("sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name")]
public string SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
    }
    
    [Description("Direct expansion (DX) cooling coil and condensing unit (includes electric compres" +
        "sor and condenser fan), single-speed. Optional inputs for moisture evaporation f" +
        "rom wet coil when compressor cycles off with continuous fan operation.")]
    [JsonObject("Coil:Cooling:DX:SingleSpeed")]
    public class Coil_Cooling_DX_SingleSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description(@"Total cooling capacity not accounting for the effect of supply air fan heat gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("gross_rated_total_cooling_capacity")]
public string GrossRatedTotalCoolingCapacity { get; set; } = "";
        

[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) sensible" +
    " and total capacities do not include supply fan heat")]
[JsonProperty("gross_rated_sensible_heat_ratio")]
public string GrossRatedSensibleHeatRatio { get; set; } = "";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electrical energy input")]
[JsonProperty("gross_rated_cooling_cop")]
public System.Nullable<float> GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("Flow rate corresponding to rated total cooling capacity, Rated SHR and Rated COP " +
    "should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total coo" +
    "ling capacity")]
[JsonProperty("rated_air_flow_rate")]
public string RatedAirFlowRate { get; set; } = "";
        

[Description(@"Enter the evaporator fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on total cooling capacity. This value is only used to calculate Seasonal Energy Efficiency Ratio (SEER), Energy Efficiency Ratio (EER), Integrated Energy Efficiency Ratio (IEER), and the Standard Rating (Net) Cooling Capacity which will be outputs in the EnergyPlus eio file. This value is not used for modeling the evaporator fan during simulations.")]
[JsonProperty("rated_evaporator_fan_power_per_volume_flow_rate")]
public System.Nullable<float> RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("total_cooling_capacity_function_of_temperature_curve_name")]
public string TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = Fraction of the full load flow")]
[JsonProperty("total_cooling_capacity_function_of_flow_fraction_curve_name")]
public string TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("energy_input_ratio_function_of_temperature_curve_name")]
public string EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = Fraction of the full load flow")]
[JsonProperty("energy_input_ratio_function_of_flow_fraction_curve_name")]
public string EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (cooling load/steady state capacity)")]
[JsonProperty("part_load_fraction_correlation_curve_name")]
public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-25", CultureInfo.InvariantCulture);
        

[Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
[JsonProperty("nominal_time_for_condensate_removal_to_begin")]
public System.Nullable<float> NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
[JsonProperty("ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capacity")]
public System.Nullable<float> RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The maximum on-off cycling Rate for the compressor, which occurs at 50% run time " +
    "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("maximum_cycling_rate")]
public System.Nullable<float> MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
    "startup. Suggested value is 45; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("latent_capacity_time_constant")]
public System.Nullable<float> LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
    "doorAir:Node or OutdoorAir:NodeList object.")]
[JsonProperty("condenser_air_inlet_node_name")]
public string CondenserAirInletNodeName { get; set; } = "";
        

[JsonProperty("condenser_type")]
public Coil_Cooling_DX_SingleSpeed_CondenserType CondenserType { get; set; } = (Coil_Cooling_DX_SingleSpeed_CondenserType)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_CondenserType), "AirCooled");
        

[JsonProperty("evaporative_condenser_effectiveness")]
public System.Nullable<float> EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Used to calculate evaporative condenser water use")]
[JsonProperty("evaporative_condenser_air_flow_rate")]
public string EvaporativeCondenserAirFlowRate { get; set; } = "";
        

[Description("Rated power consumed by the evaporative condenser\'s water pump")]
[JsonProperty("evaporative_condenser_pump_rated_power_consumption")]
public string EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = (System.String)"0";
        

[JsonProperty("crankcase_heater_capacity")]
public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
        

[JsonProperty("condensate_collection_water_storage_tank_name")]
public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

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
        

[Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temp" +
    "erature seen by the DX cooling coil (C) db = entering dry-bulb temperature seen " +
    "by the DX cooling coil (C) entering temperature can be outside air or pretreated" +
    " air.")]
[JsonProperty("sensible_heat_ratio_function_of_temperature_curve_name")]
public string SensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("sensible_heat_ratio_function_of_flow_fraction_curve_name")]
public string SensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("when this input field is specified as Yes then the program calculates the net coo" +
    "ling capacity and total electric power input of DX cooling coils per ANSI/ASHRAE" +
    " 127.")]
[JsonProperty("report_ashrae_standard_127_performance_ratings")]
public EmptyNoYes ReportAshraeStandard127PerformanceRatings { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (condenser) of DX system or a heat pump is to be placed. This is an optional input field specified only when user desires to reject the condenser heat into a zone. The heat rejected is modelled as internal sensible heat gain of the zone.")]
[JsonProperty("zone_name_for_condenser_placement")]
public string ZoneNameForCondenserPlacement { get; set; } = "";
    }
    
    public enum Coil_Cooling_DX_SingleSpeed_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCooled")]
        AirCooled = 1,
        
        [JsonProperty("EvaporativelyCooled")]
        EvaporativelyCooled = 2,
    }
    
    [Description(@"Direct expansion (DX) cooling coil and condensing unit (includes electric compressor and condenser fan), two-speed (or variable-speed). Requires two sets of performance data and will interpolate between speeds. Modeled as a single coil (multi-speed compressor or multiple compressors with row split or intertwined coil).")]
    [JsonObject("Coil:Cooling:DX:TwoSpeed")]
    public class Coil_Cooling_DX_TwoSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description(@"Total cooling capacity not accounting for the effect of supply air fan heat gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("high_speed_gross_rated_total_cooling_capacity")]
public string HighSpeedGrossRatedTotalCoolingCapacity { get; set; } = "";
        

[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) sensible" +
    " and total capacities do not include supply fan heat")]
[JsonProperty("high_speed_rated_sensible_heat_ratio")]
public string HighSpeedRatedSensibleHeatRatio { get; set; } = "";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electrical energy input")]
[JsonProperty("high_speed_gross_rated_cooling_cop")]
public System.Nullable<float> HighSpeedGrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("Flow rate corresponding to rated total cooling capacity, Rated SHR and Rated COP." +
    " Should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total co" +
    "oling capacity.")]
[JsonProperty("high_speed_rated_air_flow_rate")]
public string HighSpeedRatedAirFlowRate { get; set; } = "";
        

[Description(@"Enter pressure drop for the unit containing the coil. This value is only used to calculate Energy Efficiency Ratio (EER), Integrated Energy Efficiency Ratio (IEER), and the Standard Rating (Net) Cooling Capacity. This value is not used for modeling the evaporator fan during simulations.")]
[JsonProperty("unit_internal_static_air_pressure")]
public System.Nullable<float> UnitInternalStaticAirPressure { get; set; } = null;
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("total_cooling_capacity_function_of_temperature_curve_name")]
public string TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("total_cooling_capacity_function_of_flow_fraction_curve_name")]
public string TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("energy_input_ratio_function_of_temperature_curve_name")]
public string EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("energy_input_ratio_function_of_flow_fraction_curve_name")]
public string EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (cooling load/steady state capacity)")]
[JsonProperty("part_load_fraction_correlation_curve_name")]
public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description(@"Total cooling capacity not accounting for the effect of supply air fan heat gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("low_speed_gross_rated_total_cooling_capacity")]
public string LowSpeedGrossRatedTotalCoolingCapacity { get; set; } = "";
        

[Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity) se" +
    "nsible and total capacities do not include supply fan heat")]
[JsonProperty("low_speed_gross_rated_sensible_heat_ratio")]
public string LowSpeedGrossRatedSensibleHeatRatio { get; set; } = "";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electrical energy input")]
[JsonProperty("low_speed_gross_rated_cooling_cop")]
public System.Nullable<float> LowSpeedGrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("Flow rate corresponding to rated total cooling capacity, Rated SHR and Rated COP." +
    " Should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total co" +
    "oling capacity.")]
[JsonProperty("low_speed_rated_air_flow_rate")]
public string LowSpeedRatedAirFlowRate { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("low_speed_total_cooling_capacity_function_of_temperature_curve_name")]
public string LowSpeedTotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("low_speed_energy_input_ratio_function_of_temperature_curve_name")]
public string LowSpeedEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
    "doorAir:Node or OutdoorAir:NodeList object.")]
[JsonProperty("condenser_air_inlet_node_name")]
public string CondenserAirInletNodeName { get; set; } = "";
        

[JsonProperty("condenser_type")]
public Coil_Cooling_DX_TwoSpeed_CondenserType CondenserType { get; set; } = (Coil_Cooling_DX_TwoSpeed_CondenserType)Enum.Parse(typeof(Coil_Cooling_DX_TwoSpeed_CondenserType), "AirCooled");
        

[JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-25", CultureInfo.InvariantCulture);
        

[JsonProperty("high_speed_evaporative_condenser_effectiveness")]
public System.Nullable<float> HighSpeedEvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Used to calculate evaporative condenser water use")]
[JsonProperty("high_speed_evaporative_condenser_air_flow_rate")]
public string HighSpeedEvaporativeCondenserAirFlowRate { get; set; } = "";
        

[Description("Rated power consumed by the evaporative condenser\'s water pump at high speed")]
[JsonProperty("high_speed_evaporative_condenser_pump_rated_power_consumption")]
public string HighSpeedEvaporativeCondenserPumpRatedPowerConsumption { get; set; } = "";
        

[JsonProperty("low_speed_evaporative_condenser_effectiveness")]
public System.Nullable<float> LowSpeedEvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Used to calculate evaporative condenser water use")]
[JsonProperty("low_speed_evaporative_condenser_air_flow_rate")]
public string LowSpeedEvaporativeCondenserAirFlowRate { get; set; } = "";
        

[Description("Rated power consumed by the evaporative condenser\'s water pump at low speed")]
[JsonProperty("low_speed_evaporative_condenser_pump_rated_power_consumption")]
public string LowSpeedEvaporativeCondenserPumpRatedPowerConsumption { get; set; } = "";
        

[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
        

[JsonProperty("condensate_collection_water_storage_tank_name")]
public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

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
        

[Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temp" +
    "erature seen by the DX cooling coil (C) db = entering dry-bulb temperature seen " +
    "by the DX cooling coil (C) entering temperature can be outside air or pretreated" +
    " air.")]
[JsonProperty("sensible_heat_ratio_function_of_temperature_curve_name")]
public string SensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("sensible_heat_ratio_function_of_flow_fraction_curve_name")]
public string SensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temp" +
    "erature seen by the DX cooling coil (C) db = entering dry-bulb temperature seen " +
    "by the DX cooling coil (C) entering temperature can be outside air or pretreated" +
    " air.")]
[JsonProperty("low_speed_sensible_heat_ratio_function_of_temperature_curve_name")]
public string LowSpeedSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("low_speed_sensible_heat_ratio_function_of_flow_fraction_curve_name")]
public string LowSpeedSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (condenser) of DX system or a heat pump is to be placed. This is an optional input field specified only when user desires to reject the condenser heat into a zone. The heat rejected is modelled as internal sensible heat gain of the zone.")]
[JsonProperty("zone_name_for_condenser_placement")]
public string ZoneNameForCondenserPlacement { get; set; } = "";
    }
    
    public enum Coil_Cooling_DX_TwoSpeed_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCooled")]
        AirCooled = 1,
        
        [JsonProperty("EvaporativelyCooled")]
        EvaporativelyCooled = 2,
    }
    
    [Description(@"Direct expansion (DX) cooling coil and condensing unit (includes electric or engine-driven compressor and condenser fan), multi-speed (or variable-speed). Optional moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Requires two to four sets of performance data and will interpolate between speeds. Modeled as a single coil (multi-speed compressor or multiple compressors with row split or intertwined coil).")]
    [JsonObject("Coil:Cooling:DX:MultiSpeed")]
    public class Coil_Cooling_DX_MultiSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
    "doorAir:Node or OutdoorAir:NodeList object.")]
[JsonProperty("condenser_air_inlet_node_name")]
public string CondenserAirInletNodeName { get; set; } = "";
        

[JsonProperty("condenser_type")]
public Coil_Cooling_DX_MultiSpeed_CondenserType CondenserType { get; set; } = (Coil_Cooling_DX_MultiSpeed_CondenserType)Enum.Parse(typeof(Coil_Cooling_DX_MultiSpeed_CondenserType), "AirCooled");
        

[JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-25", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
        

[JsonProperty("condensate_collection_water_storage_tank_name")]
public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

[JsonProperty("apply_part_load_fraction_to_speeds_greater_than_1")]
public EmptyNoYes ApplyPartLoadFractionToSpeedsGreaterThan1 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("apply_latent_degradation_to_speeds_greater_than_1")]
public EmptyNoYes ApplyLatentDegradationToSpeedsGreaterThan1 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("crankcase_heater_capacity")]
public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

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
public Coil_Cooling_DX_MultiSpeed_FuelType FuelType { get; set; } = (Coil_Cooling_DX_MultiSpeed_FuelType)Enum.Parse(typeof(Coil_Cooling_DX_MultiSpeed_FuelType), "Diesel");
        

[Description("Enter the number of the following sets of data for coil capacity, SHR, COP, flow " +
    "rate, and associated curves.")]
[JsonProperty("number_of_speeds")]
public System.Nullable<float> NumberOfSpeeds { get; set; } = null;
        

[Description(@"Total cooling capacity not accounting for the effect of supply air fan heat Gross capacity excluding supply air fan heat Rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb Speed 1 is defined as low speed")]
[JsonProperty("speed_1_gross_rated_total_cooling_capacity")]
public string Speed1GrossRatedTotalCoolingCapacity { get; set; } = "";
        

[Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity) Se" +
    "nsible and total capacities do not include supply fan heat")]
[JsonProperty("speed_1_gross_rated_sensible_heat_ratio")]
public string Speed1GrossRatedSensibleHeatRatio { get; set; } = "";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electrical energy input")]
[JsonProperty("speed_1_gross_rated_cooling_cop")]
public System.Nullable<float> Speed1GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("Flow rate corresponding to rated total cooling capacity, rated SHR and rated COP " +
    "should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total coo" +
    "ling capacity")]
[JsonProperty("speed_1_rated_air_flow_rate")]
public string Speed1RatedAirFlowRate { get; set; } = "";
        

[Description(@"Enter the evaporator fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on total cooling capacity. This value is only used to calculate Seasonal Energy Efficiency Ratio (SEER), and the Standard Rating (Net) Cooling Capacity which will be outputs in the EnergyPlus eio file. This value is not used for modeling the evaporator fan during simulations.")]
[JsonProperty("speed_1_rated_evaporator_fan_power_per_volume_flow_rate")]
public System.Nullable<float> Speed1RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("speed_1_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed1TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = Fraction of the full load Flow")]
[JsonProperty("speed_1_total_cooling_capacity_function_of_flow_fraction_curve_name")]
public string Speed1TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("speed_1_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_1_energy_input_ratio_function_of_flow_fraction_curve_name")]
public string Speed1EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (cooling load/steady state capacity)")]
[JsonProperty("speed_1_part_load_fraction_correlation_curve_name")]
public string Speed1PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
[JsonProperty("speed_1_nominal_time_for_condensate_removal_to_begin")]
public System.Nullable<float> Speed1NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Ratio of the initial moisture evaporation Rate from the Cooling Coil (when the compressor first turns off) and the Coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
[JsonProperty("speed_1_ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capaci" +
    "ty")]
public System.Nullable<float> Speed1RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time " +
    "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("speed_1_maximum_cycling_rate")]
public System.Nullable<float> Speed1MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
    "startup. Suggested value is 45; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("speed_1_latent_capacity_time_constant")]
public System.Nullable<float> Speed1LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Recoverable waste heat at full load and rated conditions")]
[JsonProperty("speed_1_rated_waste_heat_fraction_of_power_input")]
public System.Nullable<float> Speed1RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
    "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
[JsonProperty("speed_1_waste_heat_function_of_temperature_curve_name")]
public string Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[JsonProperty("speed_1_evaporative_condenser_effectiveness")]
public System.Nullable<float> Speed1EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Used to calculate evaporative condenser water use")]
[JsonProperty("speed_1_evaporative_condenser_air_flow_rate")]
public string Speed1EvaporativeCondenserAirFlowRate { get; set; } = "";
        

[Description("Rated power consumed by the evaporative condenser\'s water pump at high speed")]
[JsonProperty("speed_1_rated_evaporative_condenser_pump_power_consumption")]
public string Speed1RatedEvaporativeCondenserPumpPowerConsumption { get; set; } = "";
        

[Description(@"Total cooling capacity not accounting for the effect of supply air fan heat Gross capacity excluding supply air fan heat Rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("speed_2_gross_rated_total_cooling_capacity")]
public string Speed2GrossRatedTotalCoolingCapacity { get; set; } = "";
        

[Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity) Se" +
    "nsible and total capacities do not include supply fan heat")]
[JsonProperty("speed_2_gross_rated_sensible_heat_ratio")]
public string Speed2GrossRatedSensibleHeatRatio { get; set; } = "";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electrical energy input")]
[JsonProperty("speed_2_gross_rated_cooling_cop")]
public System.Nullable<float> Speed2GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("Flow rate corresponding to rated total cooling capacity, rated SHR and rated COP " +
    "should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total coo" +
    "ling capacity for Speed 2.")]
[JsonProperty("speed_2_rated_air_flow_rate")]
public string Speed2RatedAirFlowRate { get; set; } = "";
        

[Description(@"Enter the evaporator fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on total cooling capacity. This value is only used to calculate Seasonal Energy Efficiency Ratio (SEER), and the Standard Rating (Net) Cooling Capacity which will be outputs in the EnergyPlus eio file. This value is not used for modeling the evaporator fan during simulations.")]
[JsonProperty("speed_2_rated_evaporator_fan_power_per_volume_flow_rate")]
public System.Nullable<float> Speed2RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("speed_2_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed2TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_2_total_cooling_capacity_function_of_flow_fraction_curve_name")]
public string Speed2TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("speed_2_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = Fraction of the full load Flow")]
[JsonProperty("speed_2_energy_input_ratio_function_of_flow_fraction_curve_name")]
public string Speed2EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (Cooling load/steady state capacity)")]
[JsonProperty("speed_2_part_load_fraction_correlation_curve_name")]
public string Speed2PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
[JsonProperty("speed_2_nominal_time_for_condensate_removal_to_begin")]
public System.Nullable<float> Speed2NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
[JsonProperty("speed_2_ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capaci" +
    "ty")]
public System.Nullable<float> Speed2RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time " +
    "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("speed_2_maximum_cycling_rate")]
public System.Nullable<float> Speed2MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
    "startup. Suggested value is 45; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("speed_2_latent_capacity_time_constant")]
public System.Nullable<float> Speed2LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Recoverable waste heat at full load and rated conditions")]
[JsonProperty("speed_2_rated_waste_heat_fraction_of_power_input")]
public System.Nullable<float> Speed2RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
    "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
[JsonProperty("speed_2_waste_heat_function_of_temperature_curve_name")]
public string Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[JsonProperty("speed_2_evaporative_condenser_effectiveness")]
public System.Nullable<float> Speed2EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Used to calculate evaporative condenser water use")]
[JsonProperty("speed_2_evaporative_condenser_air_flow_rate")]
public string Speed2EvaporativeCondenserAirFlowRate { get; set; } = "";
        

[Description("Rated power consumed by the evaporative condenser\'s water pump at low speed")]
[JsonProperty("speed_2_rated_evaporative_condenser_pump_power_consumption")]
public string Speed2RatedEvaporativeCondenserPumpPowerConsumption { get; set; } = "";
        

[Description(@"Total cooling capacity not accounting for the effect of supply air fan heat Gross capacity excluding supply air fan heat Rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("speed_3_gross_rated_total_cooling_capacity")]
public string Speed3GrossRatedTotalCoolingCapacity { get; set; } = "";
        

[Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity) Se" +
    "nsible and total capacities do not include supply fan heat")]
[JsonProperty("speed_3_gross_rated_sensible_heat_ratio")]
public string Speed3GrossRatedSensibleHeatRatio { get; set; } = "";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electrical energy input")]
[JsonProperty("speed_3_gross_rated_cooling_cop")]
public System.Nullable<float> Speed3GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("Flow rate corresponding to rated total cooling capacity, rated SHR and rated COP " +
    "should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total coo" +
    "ling capacity for Speed 3.")]
[JsonProperty("speed_3_rated_air_flow_rate")]
public string Speed3RatedAirFlowRate { get; set; } = "";
        

[Description(@"Enter the evaporator fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on total cooling capacity. This value is only used to calculate Seasonal Energy Efficiency Ratio (SEER), and the Standard Rating (Net) Cooling Capacity which will be outputs in the EnergyPlus eio file. This value is not used for modeling the evaporator fan during simulations.")]
[JsonProperty("speed_3_rated_evaporator_fan_power_per_volume_flow_rate")]
public System.Nullable<float> Speed3RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("speed_3_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed3TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_3_total_cooling_capacity_function_of_flow_fraction_curve_name")]
public string Speed3TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("speed_3_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_3_energy_input_ratio_function_of_flow_fraction_curve_name")]
public string Speed3EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (Cooling load/steady state capacity)")]
[JsonProperty("speed_3_part_load_fraction_correlation_curve_name")]
public string Speed3PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
[JsonProperty("speed_3_nominal_time_for_condensate_removal_to_begin")]
public System.Nullable<float> Speed3NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
[JsonProperty("speed_3_ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capaci" +
    "ty")]
public System.Nullable<float> Speed3RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time " +
    "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("speed_3_maximum_cycling_rate")]
public System.Nullable<float> Speed3MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
    "startup. Suggested value is 45; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("speed_3_latent_capacity_time_constant")]
public System.Nullable<float> Speed3LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Recoverable waste heat at full load and rated conditions")]
[JsonProperty("speed_3_rated_waste_heat_fraction_of_power_input")]
public System.Nullable<float> Speed3RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
    "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
[JsonProperty("speed_3_waste_heat_function_of_temperature_curve_name")]
public string Speed3WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[JsonProperty("speed_3_evaporative_condenser_effectiveness")]
public System.Nullable<float> Speed3EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Used to calculate evaporative condenser water use")]
[JsonProperty("speed_3_evaporative_condenser_air_flow_rate")]
public string Speed3EvaporativeCondenserAirFlowRate { get; set; } = "";
        

[Description("Rated power consumed by the evaporative condenser\'s water pump at Low speed")]
[JsonProperty("speed_3_rated_evaporative_condenser_pump_power_consumption")]
public string Speed3RatedEvaporativeCondenserPumpPowerConsumption { get; set; } = "";
        

[Description(@"Total cooling capacity not accounting for the effect of supply air fan heat Gross capacity excluding supply air fan heat Rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("speed_4_gross_rated_total_cooling_capacity")]
public string Speed4GrossRatedTotalCoolingCapacity { get; set; } = "";
        

[Description("Gross Rated Sensible Heat Ratio (gross sensible capacity/gross total capacity) Se" +
    "nsible and total capacities do not include supply fan heat")]
[JsonProperty("speed_4_gross_rated_sensible_heat_ratio")]
public string Speed4GrossRatedSensibleHeatRatio { get; set; } = "";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electrical energy input")]
[JsonProperty("speed_4_gross_rated_cooling_cop")]
public System.Nullable<float> Speed4GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("Flow rate corresponding to rated total cooling capacity, rated SHR and rated COP " +
    "should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total coo" +
    "ling capacity for Speed 4")]
[JsonProperty("speed_4_rated_air_flow_rate")]
public string Speed4RatedAirFlowRate { get; set; } = "";
        

[Description(@"Enter the evaporator fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on total cooling capacity. This value is only used to calculate Seasonal Energy Efficiency Ratio (SEER), and the Standard Rating (Net) Cooling Capacity which will be outputs in the EnergyPlus eio file. This value is not used for modeling the evaporator fan during simulations.")]
[JsonProperty("speed_4_rated_evaporator_fan_power_per_volume_flow_rate")]
public System.Nullable<float> Speed4RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("speed_4_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed4TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_4_total_cooling_capacity_function_of_flow_fraction_curve_name")]
public string Speed4TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("speed_4_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_4_energy_input_ratio_function_of_flow_fraction_curve_name")]
public string Speed4EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (cooling load/steady state capacity)")]
[JsonProperty("speed_4_part_load_fraction_correlation_curve_name")]
public string Speed4PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
[JsonProperty("speed_4_nominal_time_for_condensate_removal_to_begin")]
public System.Nullable<float> Speed4NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
[JsonProperty("speed_4_ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capaci" +
    "ty")]
public System.Nullable<float> Speed4RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time " +
    "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("speed_4_maximum_cycling_rate")]
public System.Nullable<float> Speed4MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
    "startup. Suggested value is 45; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("speed_4_latent_capacity_time_constant")]
public System.Nullable<float> Speed4LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Recoverable waste heat at full load and rated conditions")]
[JsonProperty("speed_4_rated_waste_heat_fraction_of_power_input")]
public System.Nullable<float> Speed4RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
    "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
[JsonProperty("speed_4_waste_heat_function_of_temperature_curve_name")]
public string Speed4WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[JsonProperty("speed_4_evaporative_condenser_effectiveness")]
public System.Nullable<float> Speed4EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Used to calculate evaporative condenser water use")]
[JsonProperty("speed_4_evaporative_condenser_air_flow_rate")]
public string Speed4EvaporativeCondenserAirFlowRate { get; set; } = "";
        

[Description("Rated power consumed by the evaporative condenser\'s water pump at Speed 4")]
[JsonProperty("speed_4_rated_evaporative_condenser_pump_power_consumption")]
public string Speed4RatedEvaporativeCondenserPumpPowerConsumption { get; set; } = "";
        

[Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (condenser) of DX system or a heat pump is to be placed. This is an optional input field specified only when user desires to reject the condenser heat into a zone. The heat rejected is modelled as internal sensible heat gain of the zone.")]
[JsonProperty("zone_name_for_condenser_placement")]
public string ZoneNameForCondenserPlacement { get; set; } = "";
    }
    
    public enum Coil_Cooling_DX_MultiSpeed_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCooled")]
        AirCooled = 1,
        
        [JsonProperty("EvaporativelyCooled")]
        EvaporativelyCooled = 2,
    }
    
    public enum Coil_Cooling_DX_MultiSpeed_FuelType
    {
        
        [JsonProperty("Diesel")]
        Diesel = 0,
        
        [JsonProperty("Electricity")]
        Electricity = 1,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 2,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 3,
        
        [JsonProperty("Gasoline")]
        Gasoline = 4,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 5,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 6,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 7,
        
        [JsonProperty("Propane")]
        Propane = 8,
    }
    
    [Description(@"Direct expansion (DX) cooling coil and condensing unit (includes electric compressor and condenser fan), variable-speed. Optional inputs for moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Requires two to ten sets of performance data and will interpolate between speeds. Modeled as a single coil with variable-speed compressor.")]
    [JsonObject("Coil:Cooling:DX:VariableSpeed")]
    public class Coil_Cooling_DX_VariableSpeed : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("indoor_air_inlet_node_name")]
public string IndoorAirInletNodeName { get; set; } = "";
        

[JsonProperty("indoor_air_outlet_node_name")]
public string IndoorAirOutletNodeName { get; set; } = "";
        

[JsonProperty("number_of_speeds")]
public System.Nullable<float> NumberOfSpeeds { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("must be lower than or equal to the highest speed number")]
[JsonProperty("nominal_speed_level")]
public System.Nullable<float> NominalSpeedLevel { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("gross_rated_total_cooling_capacity_at_selected_nominal_speed_level")]
public string GrossRatedTotalCoolingCapacityAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

[JsonProperty("rated_air_flow_rate_at_selected_nominal_speed_level")]
public string RatedAirFlowRateAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

[JsonProperty("nominal_time_for_condensate_to_begin_leaving_the_coil")]
public System.Nullable<float> NominalTimeForCondensateToBeginLeavingTheCoil { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("initial_moisture_evaporation_rate_divided_by_steady_state_ac_latent_capacity")]
public System.Nullable<float> InitialMoistureEvaporationRateDividedBySteadyStateAcLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (cooling load/steady state capacity)")]
[JsonProperty("energy_part_load_fraction_curve_name")]
public string EnergyPartLoadFractionCurveName { get; set; } = "";
        

[Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
    "doorAir:Node or OutdoorAir:NodeList object.")]
[JsonProperty("condenser_air_inlet_node_name")]
public string CondenserAirInletNodeName { get; set; } = "";
        

[JsonProperty("condenser_type")]
public Coil_Cooling_DX_VariableSpeed_CondenserType CondenserType { get; set; } = (Coil_Cooling_DX_VariableSpeed_CondenserType)Enum.Parse(typeof(Coil_Cooling_DX_VariableSpeed_CondenserType), "AirCooled");
        

[Description("Rated power consumed by the evaporative condenser\'s water pump")]
[JsonProperty("evaporative_condenser_pump_rated_power_consumption")]
public string EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = (System.String)"0";
        

[JsonProperty("crankcase_heater_capacity")]
public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-25", CultureInfo.InvariantCulture);
        

[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
        

[JsonProperty("condensate_collection_water_storage_tank_name")]
public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

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
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_1_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed1ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed1ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed1ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed1ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("This field is only used for Condenser Type = EvaporativelyCooled")]
[JsonProperty("speed_1_reference_unit_rated_condenser_air_flow_rate")]
public System.Nullable<float> Speed1ReferenceUnitRatedCondenserAirFlowRate { get; set; } = null;
        

[Description("This field is only used for Condenser Type = EvaporativelyCooled")]
[JsonProperty("speed_1_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
public System.Nullable<float> Speed1ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_1_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed1TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_1_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed1TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_1_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_1_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed1EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_2_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed2ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed2ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed2ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed2ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_rated_condenser_air_flow_rate")]
public System.Nullable<float> Speed2ReferenceUnitRatedCondenserAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
public System.Nullable<float> Speed2ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_2_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed2TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_2_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed2TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_2_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_2_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed2EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_3_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed3ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed3ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed3ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed3ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_rated_condenser_air_flow_rate")]
public System.Nullable<float> Speed3ReferenceUnitRatedCondenserAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
public System.Nullable<float> Speed3ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_3_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed3TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_3_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed3TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_3_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_3_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed3EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_4_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed4ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed4ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed4ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed4ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_rated_condenser_air_flow_rate")]
public System.Nullable<float> Speed4ReferenceUnitRatedCondenserAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
public System.Nullable<float> Speed4ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_4_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed4TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_4_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed4TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_4_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_4_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed4EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_5_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed5ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed5ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed5ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed5ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_rated_condenser_air_flow_rate")]
public System.Nullable<float> Speed5ReferenceUnitRatedCondenserAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
public System.Nullable<float> Speed5ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_5_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed5TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_5_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed5TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_5_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed5EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_5_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed5EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_6_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed6ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed6ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed6ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed6ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_condenser_air_flow_rate")]
public System.Nullable<float> Speed6ReferenceUnitCondenserAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
public System.Nullable<float> Speed6ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_6_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed6TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_6_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed6TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_6_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed6EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_6_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed6EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_7_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed7ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed7ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed7ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed7ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_condenser_flow_rate")]
public System.Nullable<float> Speed7ReferenceUnitCondenserFlowRate { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
public System.Nullable<float> Speed7ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_7_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed7TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_7_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed7TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_7_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed7EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_7_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed7EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_8_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed8ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed8ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed8ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed8ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_condenser_air_flow_rate")]
public System.Nullable<float> Speed8ReferenceUnitCondenserAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
public System.Nullable<float> Speed8ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_8_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed8TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_8_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed8TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_8_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed8EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_8_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed8EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_9_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed9ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed9ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed9ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed9ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("optional")]
[JsonProperty("speed_9_reference_unit_condenser_air_flow_rate")]
public System.Nullable<float> Speed9ReferenceUnitCondenserAirFlowRate { get; set; } = null;
        

[Description("optional")]
[JsonProperty("speed_9_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
public System.Nullable<float> Speed9ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_9_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed9TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_9_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed9TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_9_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed9EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_9_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed9EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_10_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed10ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed10ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed10ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed10ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("optional")]
[JsonProperty("speed_10_reference_unit_condenser_air_flow_rate")]
public System.Nullable<float> Speed10ReferenceUnitCondenserAirFlowRate { get; set; } = null;
        

[Description("optional")]
[JsonProperty("speed_10_reference_unit_rated_pad_effectiveness_of_evap_precooling")]
public System.Nullable<float> Speed10ReferenceUnitRatedPadEffectivenessOfEvapPrecooling { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_10_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed10TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_10_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed10TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*odb + e*odb**2 + f*wb*odb wb = entering wet-bulb t" +
    "emperature (C) odb = air entering temperature seen by the condenser (C)")]
[JsonProperty("speed_10_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed10EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_10_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed10EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
    }
    
    public enum Coil_Cooling_DX_VariableSpeed_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCooled")]
        AirCooled = 1,
        
        [JsonProperty("EvaporativelyCooled")]
        EvaporativelyCooled = 2,
    }
    
    [Description(@"Direct expansion (DX) cooling coil and condensing unit (includes electric compressor and condenser fan), two-stage with humidity control mode (e.g. sub-cool or hot gas reheat). Optional inputs for moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Requires two to four sets of performance data, see CoilPerformance:DX:Cooling. Stages are modeled as a face-split coil.")]
    [JsonObject("Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
    public class Coil_Cooling_DX_TwoStageWithHumidityControlMode : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("crankcase_heater_capacity")]
public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[JsonProperty("number_of_capacity_stages")]
public System.Nullable<float> NumberOfCapacityStages { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("number_of_enhanced_dehumidification_modes")]
public System.Nullable<float> NumberOfEnhancedDehumidificationModes { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("normal_mode_stage_1_coil_performance_object_type")]
public Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage1CoilPerformanceObjectType NormalModeStage1CoilPerformanceObjectType { get; set; } = (Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage1CoilPerformanceObjectType)Enum.Parse(typeof(Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage1CoilPerformanceObjectType), "CoilPerformanceDXCooling");
        

[JsonProperty("normal_mode_stage_1_coil_performance_name")]
public string NormalModeStage1CoilPerformanceName { get; set; } = "";
        

[JsonProperty("normal_mode_stage_1_2_coil_performance_object_type")]
public Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage12CoilPerformanceObjectType NormalModeStage12CoilPerformanceObjectType { get; set; } = (Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage12CoilPerformanceObjectType)Enum.Parse(typeof(Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage12CoilPerformanceObjectType), "CoilPerformanceDXCooling");
        

[JsonProperty("normal_mode_stage_1_2_coil_performance_name")]
public string NormalModeStage12CoilPerformanceName { get; set; } = "";
        

[JsonProperty("dehumidification_mode_1_stage_1_coil_performance_object_type")]
public Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage1CoilPerformanceObjectType DehumidificationMode1Stage1CoilPerformanceObjectType { get; set; } = (Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage1CoilPerformanceObjectType)Enum.Parse(typeof(Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage1CoilPerformanceObjectType), "CoilPerformanceDXCooling");
        

[JsonProperty("dehumidification_mode_1_stage_1_coil_performance_name")]
public string DehumidificationMode1Stage1CoilPerformanceName { get; set; } = "";
        

[JsonProperty("dehumidification_mode_1_stage_1_2_coil_performance_object_type")]
public Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage12CoilPerformanceObjectType DehumidificationMode1Stage12CoilPerformanceObjectType { get; set; } = (Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage12CoilPerformanceObjectType)Enum.Parse(typeof(Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage12CoilPerformanceObjectType), "CoilPerformanceDXCooling");
        

[JsonProperty("dehumidification_mode_1_stage_1_2_coil_performance_name")]
public string DehumidificationMode1Stage12CoilPerformanceName { get; set; } = "";
        

[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
        

[JsonProperty("condensate_collection_water_storage_tank_name")]
public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

[JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-25", CultureInfo.InvariantCulture);
        

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
    }
    
    public enum Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage1CoilPerformanceObjectType
    {
        
        [JsonProperty("CoilPerformance:DX:Cooling")]
        CoilPerformanceDXCooling = 0,
    }
    
    public enum Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage12CoilPerformanceObjectType
    {
        
        [JsonProperty("CoilPerformance:DX:Cooling")]
        CoilPerformanceDXCooling = 0,
    }
    
    public enum Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage1CoilPerformanceObjectType
    {
        
        [JsonProperty("CoilPerformance:DX:Cooling")]
        CoilPerformanceDXCooling = 0,
    }
    
    public enum Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage12CoilPerformanceObjectType
    {
        
        [JsonProperty("CoilPerformance:DX:Cooling")]
        CoilPerformanceDXCooling = 0,
    }
    
    [Description(@"Used to specify DX cooling coil performance for one mode of operation for a Coil:Cooling:DX:TwoStageWithHumidityControlMode object which may reference one to four CoilPerformance:DX:Cooling objects depending on the specified number of stages and dehumidification modes. In nearly all cases, the Rated Air Flow Rate will be the same for all performance objects associated with a given coil. If bypass is specified, the Rated Air Flow Rate includes both the bypassed flow and the flow through the active part of the coil.")]
    [JsonObject("CoilPerformance:DX:Cooling")]
    public class CoilPerformance_DX_Cooling : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Total cooling capacity not accounting for the effect of supply air fan heat gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("gross_rated_total_cooling_capacity")]
public string GrossRatedTotalCoolingCapacity { get; set; } = "";
        

[Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) sensible" +
    " and total capacities do not include supply fan heat")]
[JsonProperty("gross_rated_sensible_heat_ratio")]
public string GrossRatedSensibleHeatRatio { get; set; } = "";
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electrical energy input")]
[JsonProperty("gross_rated_cooling_cop")]
public System.Nullable<float> GrossRatedCoolingCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("Flow rate corresponding to Rated total Cooling capacity, Rated SHR and Rated COP")]
[JsonProperty("rated_air_flow_rate")]
public string RatedAirFlowRate { get; set; } = "";
        

[Description(@"Fraction of Rated Air Flow Rate which bypasses the cooling coil in this performance mode. The remaining portion of the flow should be between 0.00004027 m3/s and .00006041 m3/s per watt of rated total cooling capacity. This is used to model face-split coils on multi-stage units or bypass dampers. If total flow rate varies during simulation, the same fraction is bypassed.")]
[JsonProperty("fraction_of_air_flow_bypassed_around_coil")]
public System.Nullable<float> FractionOfAirFlowBypassedAroundCoil { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("total_cooling_capacity_function_of_temperature_curve_name")]
public string TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("total_cooling_capacity_function_of_flow_fraction_curve_name")]
public string TotalCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
    "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("energy_input_ratio_function_of_temperature_curve_name")]
public string EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("energy_input_ratio_function_of_flow_fraction_curve_name")]
public string EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (cooling load/steady state capacity)")]
[JsonProperty("part_load_fraction_correlation_curve_name")]
public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
[JsonProperty("nominal_time_for_condensate_removal_to_begin")]
public System.Nullable<float> NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
[JsonProperty("ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capacity")]
public System.Nullable<float> RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The maximum on-off cycling rate for the compressor, which occurs at 50% run time " +
    "fraction. Suggested value is 3; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("maximum_cycling_rate")]
public System.Nullable<float> MaximumCyclingRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Time constant for the cooling coil\'s latent capacity to reach steady state after " +
    "startup. Suggested value is 45; zero value means latent degradation model is dis" +
    "abled.")]
[JsonProperty("latent_capacity_time_constant")]
public System.Nullable<float> LatentCapacityTimeConstant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
    "doorAir:Node or OutdoorAir:NodeList object.")]
[JsonProperty("condenser_air_inlet_node_name")]
public string CondenserAirInletNodeName { get; set; } = "";
        

[JsonProperty("condenser_type")]
public CoilPerformance_DX_Cooling_CondenserType CondenserType { get; set; } = (CoilPerformance_DX_Cooling_CondenserType)Enum.Parse(typeof(CoilPerformance_DX_Cooling_CondenserType), "AirCooled");
        

[JsonProperty("evaporative_condenser_effectiveness")]
public System.Nullable<float> EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Used to calculate evaporative condenser water use")]
[JsonProperty("evaporative_condenser_air_flow_rate")]
public string EvaporativeCondenserAirFlowRate { get; set; } = "";
        

[Description("Rated power consumed by the evaporative condenser\'s water pump")]
[JsonProperty("evaporative_condenser_pump_rated_power_consumption")]
public string EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = (System.String)"0";
        

[Description("curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temp" +
    "erature seen by the DX cooling coil (C) db = entering dry-bulb temperature seen " +
    "by the DX cooling coil (C) entering temperature can be outside air or pretreated" +
    " air.")]
[JsonProperty("sensible_heat_ratio_function_of_temperature_curve_name")]
public string SensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("sensible_heat_ratio_function_of_flow_fraction_curve_name")]
public string SensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
    }
    
    public enum CoilPerformance_DX_Cooling_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCooled")]
        AirCooled = 1,
        
        [JsonProperty("EvaporativelyCooled")]
        EvaporativelyCooled = 2,
    }
    
    [Description("Variable refrigerant flow (VRF) direct expansion (DX) cooling coil. Used with Zon" +
        "eHVAC:TerminalUnit:VariableRefrigerantFlow. Condensing unit is modeled separatel" +
        "y, see AirConditioner:VariableRefrigerantFlow.")]
    [JsonObject("Coil:Cooling:DX:VariableRefrigerantFlow")]
    public class Coil_Cooling_DX_VariableRefrigerantFlow : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat Cooli" +
    "ng capacity excluding supply air fan heat")]
[JsonProperty("gross_rated_total_cooling_capacity")]
public string GrossRatedTotalCoolingCapacity { get; set; } = "";
        

[Description("Sensible heat ratio excluding supply air fan heat")]
[JsonProperty("gross_rated_sensible_heat_ratio")]
public string GrossRatedSensibleHeatRatio { get; set; } = "";
        

[Description("Volume flow rate corresponding to rated total cooling capacity should be between " +
    "0.00004027 m3/s and .00006041 m3/s per watt of rated total cooling capacity")]
[JsonProperty("rated_air_flow_rate")]
public string RatedAirFlowRate { get; set; } = "";
        

[JsonProperty("cooling_capacity_ratio_modifier_function_of_temperature_curve_name")]
public string CoolingCapacityRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("cooling_capacity_modifier_curve_function_of_flow_fraction_name")]
public string CoolingCapacityModifierCurveFunctionOfFlowFractionName { get; set; } = "";
        

[JsonProperty("coil_air_inlet_node")]
public string CoilAirInletNode { get; set; } = "";
        

[JsonProperty("coil_air_outlet_node")]
public string CoilAirOutletNode { get; set; } = "";
        

[JsonProperty("name_of_water_storage_tank_for_condensate_collection")]
public string NameOfWaterStorageTankForCondensateCollection { get; set; } = "";
    }
    
    [Description("Variable refrigerant flow (VRF) direct expansion (DX) heating coil (air-to-air he" +
        "at pump). Used with ZoneHVAC:TerminalUnit:VariableRefrigerantFlow. Condensing un" +
        "it is modeled separately, see AirConditioner:VariableRefrigerantFlow.")]
    [JsonObject("Coil:Heating:DX:VariableRefrigerantFlow")]
    public class Coil_Heating_DX_VariableRefrigerantFlow : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule")]
public string AvailabilitySchedule { get; set; } = "";
        

[Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outside dry-bulb temp 8.33 C, outside wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wetbulb 15.55 C")]
[JsonProperty("gross_rated_heating_capacity")]
public string GrossRatedHeatingCapacity { get; set; } = "";
        

[Description("volume flow rate corresponding to rated total capacity should be between 0.000040" +
    "27 m3/s and .00006041 m3/s per watt of rated heating capacity")]
[JsonProperty("rated_air_flow_rate")]
public string RatedAirFlowRate { get; set; } = "";
        

[JsonProperty("coil_air_inlet_node")]
public string CoilAirInletNode { get; set; } = "";
        

[JsonProperty("coil_air_outlet_node")]
public string CoilAirOutletNode { get; set; } = "";
        

[JsonProperty("heating_capacity_ratio_modifier_function_of_temperature_curve_name")]
public string HeatingCapacityRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("heating_capacity_modifier_function_of_flow_fraction_curve_name")]
public string HeatingCapacityModifierFunctionOfFlowFractionCurveName { get; set; } = "";
    }
    
    [Description(@"This is a key object in the new physics based VRF model applicable for Fluid Temperature Control. It describes the the indoor unit coil of the system at cooling mode. Used with ZoneHVAC:TerminalUnit:VariableRefrigerantFlow. Outdoor unit is modeled separately, see AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl or AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR")]
    [JsonObject("Coil:Cooling:DX:VariableRefrigerantFlow:FluidTemperatureControl")]
    public class Coil_Cooling_DX_VariableRefrigerantFlow_FluidTemperatureControl : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of a schedule that defines the availability of the coil Schedule v" +
    "alues of 0 denote the unit is off. All other values denote the unit is available" +
    " If this field is left blank, the unit is available the entire simulation")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("the inlet node to the coil")]
[JsonProperty("coil_air_inlet_node")]
public string CoilAirInletNode { get; set; } = "";
        

[Description("the outlet node to the coil")]
[JsonProperty("coil_air_outlet_node")]
public string CoilAirOutletNode { get; set; } = "";
        

[Description("Supply air fan heat is not included")]
[JsonProperty("rated_total_cooling_capacity")]
public string RatedTotalCoolingCapacity { get; set; } = "";
        

[Description("Supply air fan heat is not included")]
[JsonProperty("rated_sensible_heat_ratio")]
public string RatedSensibleHeatRatio { get; set; } = "";
        

[JsonProperty("indoor_unit_reference_superheating")]
public System.Nullable<float> IndoorUnitReferenceSuperheating { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[JsonProperty("indoor_unit_evaporating_temperature_function_of_superheating_curve_name")]
public string IndoorUnitEvaporatingTemperatureFunctionOfSuperheatingCurveName { get; set; } = "";
        

[JsonProperty("name_of_water_storage_tank_for_condensate_collection")]
public string NameOfWaterStorageTankForCondensateCollection { get; set; } = "";
    }
    
    [Description(@"This is a key object in the new physics based VRF model applicable for Fluid Temperature Control. It describes the the indoor unit coil of the system at heating mode. Used with ZoneHVAC:TerminalUnit:VariableRefrigerantFlow. Outdoor unit is modeled separately, see AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl or AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR")]
    [JsonObject("Coil:Heating:DX:VariableRefrigerantFlow:FluidTemperatureControl")]
    public class Coil_Heating_DX_VariableRefrigerantFlow_FluidTemperatureControl : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter the name of a schedule that defines the availability of the coil Schedule v" +
    "alues of 0 denote the unit is off. All other values denote the unit is available" +
    " If this field is left blank, the unit is available the entire simulation")]
[JsonProperty("availability_schedule")]
public string AvailabilitySchedule { get; set; } = "";
        

[Description("the inlet node to the coil")]
[JsonProperty("coil_air_inlet_node")]
public string CoilAirInletNode { get; set; } = "";
        

[Description("the outlet node to the coil")]
[JsonProperty("coil_air_outlet_node")]
public string CoilAirOutletNode { get; set; } = "";
        

[Description("Supply air fan heat is not included")]
[JsonProperty("rated_total_heating_capacity")]
public string RatedTotalHeatingCapacity { get; set; } = "";
        

[JsonProperty("indoor_unit_reference_subcooling")]
public System.Nullable<float> IndoorUnitReferenceSubcooling { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[JsonProperty("indoor_unit_condensing_temperature_function_of_subcooling_curve_name")]
public string IndoorUnitCondensingTemperatureFunctionOfSubcoolingCurveName { get; set; } = "";
    }
    
    [Description("Hot water heating coil, NTU-effectiveness model, assumes a cross-flow heat exchan" +
        "ger. Two options for capacity inputs: UA and water flow rate or capacity and des" +
        "ign temperatures.")]
    [JsonObject("Coil:Heating:Water")]
    public class Coil_Heating_Water : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("UA value under rating conditions")]
[JsonProperty("u_factor_times_area_value")]
public string UFactorTimesAreaValue { get; set; } = (System.String)"Autosize";
        

[JsonProperty("maximum_water_flow_rate")]
public string MaximumWaterFlowRate { get; set; } = (System.String)"Autosize";
        

[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("performance_input_method")]
public Coil_Heating_Water_PerformanceInputMethod PerformanceInputMethod { get; set; } = (Coil_Heating_Water_PerformanceInputMethod)Enum.Parse(typeof(Coil_Heating_Water_PerformanceInputMethod), "UFactorTimesAreaAndDesignWaterFlowRate");
        

[JsonProperty("rated_capacity")]
public string RatedCapacity { get; set; } = (System.String)"Autosize";
        

[JsonProperty("rated_inlet_water_temperature")]
public System.Nullable<float> RatedInletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("82.2", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_inlet_air_temperature")]
public System.Nullable<float> RatedInletAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("16.6", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_outlet_water_temperature")]
public System.Nullable<float> RatedOutletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("71.1", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_outlet_air_temperature")]
public System.Nullable<float> RatedOutletAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("32.2", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_ratio_for_air_and_water_convection")]
public System.Nullable<float> RatedRatioForAirAndWaterConvection { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("This input field is optional. If specified, it is used for sizing the Design Wate" +
    "r Flow Rate. If blank or omitted, the Loop Design Temperature Difference value s" +
    "pecified in Sizing:Plant object is used for sizing the Design Water Flow Rate.")]
[JsonProperty("design_water_temperature_difference")]
public System.Nullable<float> DesignWaterTemperatureDifference { get; set; } = null;
    }
    
    public enum Coil_Heating_Water_PerformanceInputMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("NominalCapacity")]
        NominalCapacity = 1,
        
        [JsonProperty("UFactorTimesAreaAndDesignWaterFlowRate")]
        UFactorTimesAreaAndDesignWaterFlowRate = 2,
    }
    
    [Description("Steam heating coil. Condenses and sub-cools steam at loop pressure and discharges" +
        " condensate through steam traps to low pressure condensate line.")]
    [JsonObject("Coil:Heating:Steam")]
    public class Coil_Heating_Steam : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("maximum_steam_flow_rate")]
public string MaximumSteamFlowRate { get; set; } = "";
        

[JsonProperty("degree_of_subcooling")]
public System.Nullable<float> DegreeOfSubcooling { get; set; } = null;
        

[JsonProperty("degree_of_loop_subcooling")]
public System.Nullable<float> DegreeOfLoopSubcooling { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Use ZoneLoadControl if the coil is contained within another component such as an " +
    "air terminal unit, zone HVAC equipment, or unitary system. Use TemperatureSetpoi" +
    "ntControl if the coil is located directly in an air loop branch or outdoor air e" +
    "quipment list.")]
[JsonProperty("coil_control_type")]
public Coil_Heating_Steam_CoilControlType CoilControlType { get; set; } = (Coil_Heating_Steam_CoilControlType)Enum.Parse(typeof(Coil_Heating_Steam_CoilControlType), "TemperatureSetpointControl");
        

[Description("Required if Coil Control Type is TemperatureSetpointControl")]
[JsonProperty("temperature_setpoint_node_name")]
public string TemperatureSetpointNodeName { get; set; } = "";
    }
    
    public enum Coil_Heating_Steam_CoilControlType
    {
        
        [JsonProperty("TemperatureSetpointControl")]
        TemperatureSetpointControl = 0,
        
        [JsonProperty("ZoneLoadControl")]
        ZoneLoadControl = 1,
    }
    
    [Description(@"Electric heating coil. If the coil is located directly in an air loop branch or outdoor air equipment list, then it is controlled on leaving air temperature and the Temperature Setpoint Node Name must be specified. If the coil is contained within another component such as an air terminal unit, zone HVAC equipment, or unitary system, then the coil is controlled by the parent component and the setpoint node name is not entered.")]
    [JsonObject("Coil:Heating:Electric")]
    public class Coil_Heating_Electric : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("efficiency")]
public System.Nullable<float> Efficiency { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("nominal_capacity")]
public string NominalCapacity { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Required if coil is temperature controlled.")]
[JsonProperty("temperature_setpoint_node_name")]
public string TemperatureSetpointNodeName { get; set; } = "";
    }
    
    [Description(@"Electric heating coil, multi-stage. If the coil is located directly in an air loop branch or outdoor air equipment list, then it is controlled on leaving air temperature and the Temperature Setpoint Node Name must be specified. If the coil is contained within another component such as an air terminal unit, zone HVAC equipment, or unitary system, then the coil is controlled by the parent component and the setpoint node name is not entered.")]
    [JsonObject("Coil:Heating:Electric:MultiStage")]
    public class Coil_Heating_Electric_MultiStage : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Required if coil is temperature controlled. controlled")]
[JsonProperty("temperature_setpoint_node_name")]
public string TemperatureSetpointNodeName { get; set; } = "";
        

[Description("Enter the number of the following sets of data for coil capacity and Efficiency.")]
[JsonProperty("number_of_stages")]
public System.Nullable<float> NumberOfStages { get; set; } = null;
        

[JsonProperty("stage_1_efficiency")]
public System.Nullable<float> Stage1Efficiency { get; set; } = null;
        

[JsonProperty("stage_1_nominal_capacity")]
public string Stage1NominalCapacity { get; set; } = "";
        

[JsonProperty("stage_2_efficiency")]
public System.Nullable<float> Stage2Efficiency { get; set; } = null;
        

[JsonProperty("stage_2_nominal_capacity")]
public string Stage2NominalCapacity { get; set; } = "";
        

[JsonProperty("stage_3_efficiency")]
public System.Nullable<float> Stage3Efficiency { get; set; } = null;
        

[JsonProperty("stage_3_nominal_capacity")]
public string Stage3NominalCapacity { get; set; } = "";
        

[JsonProperty("stage_4_efficiency")]
public System.Nullable<float> Stage4Efficiency { get; set; } = null;
        

[JsonProperty("stage_4_nominal_capacity")]
public string Stage4NominalCapacity { get; set; } = "";
    }
    
    [Description(@"Gas or other fuel heating coil. If the coil is located directly in an air loop branch or outdoor air equipment list, then it is controlled on leaving air temperature and the Temperature Setpoint Node Name must be specified. If the coil is contained within another component such as an air terminal unit, zone HVAC equipment, or unitary system, then the coil is controlled by the parent component and the setpoint node name is not entered.")]
    [JsonObject("Coil:Heating:Fuel")]
    public class Coil_Heating_Fuel : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("fuel_type")]
public Coil_Heating_Fuel_FuelType FuelType { get; set; } = (Coil_Heating_Fuel_FuelType)Enum.Parse(typeof(Coil_Heating_Fuel_FuelType), "NaturalGas");
        

[JsonProperty("burner_efficiency")]
public System.Nullable<float> BurnerEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.8", CultureInfo.InvariantCulture);
        

[JsonProperty("nominal_capacity")]
public string NominalCapacity { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("optional, used if coil is temperature control and not load-base controlled")]
[JsonProperty("temperature_setpoint_node_name")]
public string TemperatureSetpointNodeName { get; set; } = "";
        

[Description("parasitic electric load associated with the coil operation such as an inducer fan" +
    ", etc... This will be modified by the part load ratio to reflect the time of ope" +
    "ration in a timestep.")]
[JsonProperty("parasitic_electric_load")]
public System.Nullable<float> ParasiticElectricLoad { get; set; } = null;
        

[Description(@"quadratic curve, PLF = a + b*PLR + c*PLR**2 cubic curve, PLF = a + b*PLR + c*PLR**2 + d*PLR**3 PLF = part load fraction PLR = part load ratio (sensible heating load/steady state heating capacity) Coil runtime fraction = Part Load Ratio / PLF This part load degradation is for coil performance & will increase the fuel consumption of the coil due to transient coil operation.")]
[JsonProperty("part_load_fraction_correlation_curve_name")]
public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description("parasitic fuel load associated with the coil operation (i.e., standing pilot)")]
[JsonProperty("parasitic_fuel_load")]
public System.Nullable<float> ParasiticFuelLoad { get; set; } = null;
    }
    
    public enum Coil_Heating_Fuel_FuelType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Coal")]
        Coal = 1,
        
        [JsonProperty("Diesel")]
        Diesel = 2,
        
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
    
    [Description(@"Gas heating coil, multi-stage. If the coil is located directly in an air loop branch or outdoor air equipment list, then it is controlled on leaving air temperature and the Temperature Setpoint Node Name must be specified. If the coil is contained within another component such as an air terminal unit, zone HVAC equipment, or unitary system, then the coil is controlled by the parent component and the setpoint node name is not entered.")]
    [JsonObject("Coil:Heating:Gas:MultiStage")]
    public class Coil_Heating_Gas_MultiStage : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("optional, used if coil is temperature control and not load-base controlled.")]
[JsonProperty("temperature_setpoint_node_name")]
public string TemperatureSetpointNodeName { get; set; } = "";
        

[Description(@"quadratic curve, PLF = a + b*PLR + c*PLR**2 cubic curve, PLF = a + b*PLR + c*PLR**2 + d*PLR**3 PLF = part load fraction PLR = part load ratio (sensible heating load/steady state heating capacity) Coil runtime fraction = Part Load Ratio / PLF This part load degradation is for coil performance & will increase the gas consumption of the coil due to transient coil operation.")]
[JsonProperty("part_load_fraction_correlation_curve_name")]
public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description("parasitic gas load associated with the gas coil operation (i.e., standing pilot)")]
[JsonProperty("parasitic_gas_load")]
public System.Nullable<float> ParasiticGasLoad { get; set; } = null;
        

[Description("Enter the number of the following sets of data for coil capacity and Gas Burner E" +
    "fficiency.")]
[JsonProperty("number_of_stages")]
public System.Nullable<float> NumberOfStages { get; set; } = null;
        

[JsonProperty("stage_1_gas_burner_efficiency")]
public System.Nullable<float> Stage1GasBurnerEfficiency { get; set; } = null;
        

[JsonProperty("stage_1_nominal_capacity")]
public string Stage1NominalCapacity { get; set; } = "";
        

[Description("Stage 1 parasitic electric load associated with the gas coil operation such as an" +
    " inducer fan, etc. This will be modified by the part load ratio to reflect the t" +
    "ime of operation in a timestep.")]
[JsonProperty("stage_1_parasitic_electric_load")]
public System.Nullable<float> Stage1ParasiticElectricLoad { get; set; } = null;
        

[JsonProperty("stage_2_gas_burner_efficiency")]
public System.Nullable<float> Stage2GasBurnerEfficiency { get; set; } = null;
        

[JsonProperty("stage_2_nominal_capacity")]
public string Stage2NominalCapacity { get; set; } = "";
        

[Description("Stage 2 parasitic electric load associated with the gas coil operation such as an" +
    " inducer fan, etc. This will be modified by the part load ratio to reflect the t" +
    "ime of operation in a timestep.")]
[JsonProperty("stage_2_parasitic_electric_load")]
public System.Nullable<float> Stage2ParasiticElectricLoad { get; set; } = null;
        

[JsonProperty("stage_3_gas_burner_efficiency")]
public System.Nullable<float> Stage3GasBurnerEfficiency { get; set; } = null;
        

[JsonProperty("stage_3_nominal_capacity")]
public string Stage3NominalCapacity { get; set; } = "";
        

[Description("Stage 3 parasitic electric load associated with the gas coil operation such as an" +
    " inducer fan, etc. This will be modified by the part load ratio to reflect the t" +
    "ime of operation in a timestep.")]
[JsonProperty("stage_3_parasitic_electric_load")]
public System.Nullable<float> Stage3ParasiticElectricLoad { get; set; } = null;
        

[JsonProperty("stage_4_gas_burner_efficiency")]
public System.Nullable<float> Stage4GasBurnerEfficiency { get; set; } = null;
        

[JsonProperty("stage_4_nominal_capacity")]
public string Stage4NominalCapacity { get; set; } = "";
        

[Description("Stage 4 parasitic electric load associated with the gas coil operation such as an" +
    " inducer fan, etc. This will be modified by the part load ratio to reflect the t" +
    "ime of operation in a timestep.")]
[JsonProperty("stage_4_parasitic_electric_load")]
public System.Nullable<float> Stage4ParasiticElectricLoad { get; set; } = null;
    }
    
    [Description(@"Desuperheater air heating coil. The heating energy provided by this coil is reclaimed from the superheated refrigerant gas leaving a compressor and does not impact the performance of the compressor. If the coil is located directly in an air loop branch or outdoor air equipment list, then it is controlled on leaving air temperature and the Temperature Setpoint Node Name must be specified. If the coil is contained within another component such as a unitary system, then the coil is controlled by the parent component and the setpoint node name is not entered.")]
    [JsonObject("Coil:Heating:Desuperheater")]
    public class Coil_Heating_Desuperheater : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("heat_reclaim_recovery_efficiency")]
public System.Nullable<float> HeatReclaimRecoveryEfficiency { get; set; } = null;
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("heating_source_object_type")]
public Coil_Heating_Desuperheater_HeatingSourceObjectType HeatingSourceObjectType { get; set; } = (Coil_Heating_Desuperheater_HeatingSourceObjectType)Enum.Parse(typeof(Coil_Heating_Desuperheater_HeatingSourceObjectType), "CoilCoolingDXSingleSpeed");
        

[JsonProperty("heating_source_name")]
public string HeatingSourceName { get; set; } = "";
        

[Description("Required if coil is temperature controlled. Temperature-based control requires th" +
    "e use of a SetpointManager object")]
[JsonProperty("temperature_setpoint_node_name")]
public string TemperatureSetpointNodeName { get; set; } = "";
        

[Description("parasitic electric load associated with the desuperheater coil operation such as " +
    "solenoid valves, etc.")]
[JsonProperty("parasitic_electric_load")]
public System.Nullable<float> ParasiticElectricLoad { get; set; } = null;
    }
    
    public enum Coil_Heating_Desuperheater_HeatingSourceObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 1,
        
        [JsonProperty("Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 2,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 3,
        
        [JsonProperty("Refrigeration:CompressorRack")]
        RefrigerationCompressorRack = 4,
        
        [JsonProperty("Refrigeration:Condenser:AirCooled")]
        RefrigerationCondenserAirCooled = 5,
        
        [JsonProperty("Refrigeration:Condenser:EvaporativeCooled")]
        RefrigerationCondenserEvaporativeCooled = 6,
        
        [JsonProperty("Refrigeration:Condenser:WaterCooled")]
        RefrigerationCondenserWaterCooled = 7,
    }
    
    [Description("Direct expansion (DX) heating coil (air-to-air heat pump) and compressor unit (in" +
        "cludes electric compressor and outdoor fan), single-speed, with defrost controls" +
        ".")]
    [JsonObject("Coil:Heating:DX:SingleSpeed")]
    public class Coil_Heating_DX_SingleSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
[JsonProperty("gross_rated_heating_capacity")]
public string GrossRatedHeatingCapacity { get; set; } = "";
        

[Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply air fan heat or supply air fan electrical energy does no" +
    "t include supply air fan heat or supply air fan electrical energy")]
[JsonProperty("gross_rated_heating_cop")]
public System.Nullable<float> GrossRatedHeatingCop { get; set; } = null;
        

[Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
    " and .00006041 m3/s per watt of rated heating capacity")]
[JsonProperty("rated_air_flow_rate")]
public string RatedAirFlowRate { get; set; } = "";
        

[Description(@"Enter the supply fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply (condenser) fan during simulations.")]
[JsonProperty("rated_supply_fan_power_per_volume_flow_rate")]
public System.Nullable<float> RatedSupplyFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) Biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
[JsonProperty("heating_capacity_function_of_temperature_curve_name")]
public string HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("heating_capacity_function_of_flow_fraction_curve_name")]
public string HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
[JsonProperty("energy_input_ratio_function_of_temperature_curve_name")]
public string EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("energy_input_ratio_function_of_flow_fraction_curve_name")]
public string EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
[JsonProperty("part_load_fraction_correlation_curve_name")]
public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description("biquadratic curve = a + b*wb + c*wb**2 + d*oat + e*oat**2 + f*wb*oat wb = wet-bul" +
    "b temperature (C) of air entering the indoor coil oat = outdoor air dry-bulb tem" +
    "perature (C) only required if ReverseCycle defrost strategy is specified")]
[JsonProperty("defrost_energy_input_ratio_function_of_temperature_curve_name")]
public string DefrostEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

[Description(@"The outdoor temperature when the compressor is automatically turned back on following an automatic shut off because of low outdoor dry-bulb temperature. This field is only used for the calculation of HSPF. If this field is not provided, then outdoor bin temperature used in the HSPF calculation is always considered to be greater than this temperature and 'Minimum Outdoor Dry-Bulb Temperature for Compressor Operation' field described above. This assumption is based on AHRI standard 210/240 (2008) and can introduce significant error in the final value of HSPF.")]
[JsonProperty("outdoor_dry_bulb_temperature_to_turn_on_compressor")]
public System.Nullable<float> OutdoorDryBulbTemperatureToTurnOnCompressor { get; set; } = null;
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_defrost_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForDefrostOperation { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[JsonProperty("crankcase_heater_capacity")]
public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[JsonProperty("defrost_strategy")]
public Coil_Heating_DX_SingleSpeed_DefrostStrategy DefrostStrategy { get; set; } = (Coil_Heating_DX_SingleSpeed_DefrostStrategy)Enum.Parse(typeof(Coil_Heating_DX_SingleSpeed_DefrostStrategy), "ReverseCycle");
        

[JsonProperty("defrost_control")]
public Coil_Heating_DX_SingleSpeed_DefrostControl DefrostControl { get; set; } = (Coil_Heating_DX_SingleSpeed_DefrostControl)Enum.Parse(typeof(Coil_Heating_DX_SingleSpeed_DefrostControl), "Timed");
        

[Description("Fraction of time in defrost mode only applicable if timed defrost control is spec" +
    "ified")]
[JsonProperty("defrost_time_period_fraction")]
public System.Nullable<float> DefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

[Description("only applicable if resistive defrost strategy is specified")]
[JsonProperty("resistive_defrost_heater_capacity")]
public string ResistiveDefrostHeaterCapacity { get; set; } = (System.String)"0";
        

[Description("Standard Region number for which HSPF and other standard ratings are calculated")]
[JsonProperty("region_number_for_calculating_hspf")]
public System.Nullable<float> RegionNumberForCalculatingHspf { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

[Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
    "doorAir:Node or OutdoorAir:NodeList object.")]
[JsonProperty("evaporator_air_inlet_node_name")]
public string EvaporatorAirInletNodeName { get; set; } = "";
        

[Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (evaporator) of a heat pump is to be placed. This is an optional input field specified only when user desires to extract heat from the zone. The heat extracted is modelled as internal gain of the zone. If the primary DX system is a heat pump, then the zone name should be the same as the zone name specified for placing the secondary cooling DX coil.")]
[JsonProperty("zone_name_for_evaporator_placement")]
public string ZoneNameForEvaporatorPlacement { get; set; } = "";
        

[Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
    "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
    "e when the heat pump is working in cooling mode.")]
[JsonProperty("secondary_coil_air_flow_rate")]
public string SecondaryCoilAirFlowRate { get; set; } = "";
        

[Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
[JsonProperty("secondary_coil_fan_flow_scaling_factor")]
public System.Nullable<float> SecondaryCoilFanFlowScalingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

[Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
[JsonProperty("nominal_sensible_heat_ratio_of_secondary_coil")]
public System.Nullable<float> NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

[Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
[JsonProperty("sensible_heat_ratio_modifier_function_of_temperature_curve_name")]
public string SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
[JsonProperty("sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name")]
public string SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
    }
    
    public enum Coil_Heating_DX_SingleSpeed_DefrostStrategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Resistive")]
        Resistive = 1,
        
        [JsonProperty("ReverseCycle")]
        ReverseCycle = 2,
    }
    
    public enum Coil_Heating_DX_SingleSpeed_DefrostControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("OnDemand")]
        OnDemand = 1,
        
        [JsonProperty("Timed")]
        Timed = 2,
    }
    
    [Description(@"Direct expansion (DX) heating coil (air-to-air heat pump) and compressor unit (includes electric or engine-driven compressor and outdoor fan), multi-speed (or variable-speed), with defrost controls. Requires two to four sets of performance data and will interpolate between speeds.")]
    [JsonObject("Coil:Heating:DX:MultiSpeed")]
    public class Coil_Heating_DX_MultiSpeed : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

[Description(@"The outdoor temperature when the compressor is automatically turned back on following an automatic shut off because of low outdoor dry-bulb temperature. This field is only used for the calculation of HSPF. If this field is not provided, then outdoor bin temperature used in the HSPF calculation is always considered to be greater than this temperature and 'Minimum Outdoor Dry-Bulb Temperature for Compressor Operation' field described above. This assumption is based on AHRI standard 210/240 (2008) and can introduce significant error in the final value of HSPF.")]
[JsonProperty("outdoor_dry_bulb_temperature_to_turn_on_compressor")]
public System.Nullable<float> OutdoorDryBulbTemperatureToTurnOnCompressor { get; set; } = null;
        

[JsonProperty("crankcase_heater_capacity")]
public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("biquadratic curve = a + b*wb + c*wb**2 + d*oat + e*oat**2 + f*wb*oat wb = wet-bul" +
    "b temperature (C) of air entering the indoor coil oat = outdoor air dry-bulb tem" +
    "perature (C) only required if ReverseCycle defrost strategy is specified")]
[JsonProperty("defrost_energy_input_ratio_function_of_temperature_curve_name")]
public string DefrostEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_defrost_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForDefrostOperation { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[JsonProperty("defrost_strategy")]
public Coil_Heating_DX_MultiSpeed_DefrostStrategy DefrostStrategy { get; set; } = (Coil_Heating_DX_MultiSpeed_DefrostStrategy)Enum.Parse(typeof(Coil_Heating_DX_MultiSpeed_DefrostStrategy), "ReverseCycle");
        

[JsonProperty("defrost_control")]
public Coil_Heating_DX_MultiSpeed_DefrostControl DefrostControl { get; set; } = (Coil_Heating_DX_MultiSpeed_DefrostControl)Enum.Parse(typeof(Coil_Heating_DX_MultiSpeed_DefrostControl), "Timed");
        

[Description("Fraction of time in defrost mode only applicable if timed defrost control is spec" +
    "ified")]
[JsonProperty("defrost_time_period_fraction")]
public System.Nullable<float> DefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

[Description("only applicable if resistive defrost strategy is specified")]
[JsonProperty("resistive_defrost_heater_capacity")]
public string ResistiveDefrostHeaterCapacity { get; set; } = (System.String)"0";
        

[JsonProperty("apply_part_load_fraction_to_speeds_greater_than_1")]
public EmptyNoYes ApplyPartLoadFractionToSpeedsGreaterThan1 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("fuel_type")]
public Coil_Heating_DX_MultiSpeed_FuelType FuelType { get; set; } = (Coil_Heating_DX_MultiSpeed_FuelType)Enum.Parse(typeof(Coil_Heating_DX_MultiSpeed_FuelType), "Diesel");
        

[Description("Standard Region number for which HSPF and other standard ratings are calculated")]
[JsonProperty("region_number_for_calculating_hspf")]
public System.Nullable<float> RegionNumberForCalculatingHspf { get; set; } = (System.Nullable<float>)Single.Parse("4", CultureInfo.InvariantCulture);
        

[Description("Enter the number of the following sets of data for coil capacity, COP, flow rate," +
    " and associated curves.")]
[JsonProperty("number_of_speeds")]
public System.Nullable<float> NumberOfSpeeds { get; set; } = null;
        

[Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
[JsonProperty("speed_1_gross_rated_heating_capacity")]
public string Speed1GrossRatedHeatingCapacity { get; set; } = "";
        

[Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply air fan heat or supply air fan electrical energy")]
[JsonProperty("speed_1_gross_rated_heating_cop")]
public System.Nullable<float> Speed1GrossRatedHeatingCop { get; set; } = null;
        

[Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
    " and .00006041 m3/s per watt of rated total heating capacity")]
[JsonProperty("speed_1_rated_air_flow_rate")]
public string Speed1RatedAirFlowRate { get; set; } = "";
        

[Description(@"Enter the supply air fan power per air volume flow rate at the rated speed 1 test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply air fan during simulations.")]
[JsonProperty("speed_1_rated_supply_air_fan_power_per_volume_flow_rate")]
public System.Nullable<float> Speed1RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

[Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
[JsonProperty("speed_1_heating_capacity_function_of_temperature_curve_name")]
public string Speed1HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_1_heating_capacity_function_of_flow_fraction_curve_name")]
public string Speed1HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
[JsonProperty("speed_1_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_1_energy_input_ratio_function_of_flow_fraction_curve_name")]
public string Speed1EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
[JsonProperty("speed_1_part_load_fraction_correlation_curve_name")]
public string Speed1PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description("recoverable waste heat at full load and rated conditions")]
[JsonProperty("speed_1_rated_waste_heat_fraction_of_power_input")]
public System.Nullable<float> Speed1RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
    "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
[JsonProperty("speed_1_waste_heat_function_of_temperature_curve_name")]
public string Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
[JsonProperty("speed_2_gross_rated_heating_capacity")]
public string Speed2GrossRatedHeatingCapacity { get; set; } = "";
        

[Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply air fan heat or supply air fan electrical energy")]
[JsonProperty("speed_2_gross_rated_heating_cop")]
public System.Nullable<float> Speed2GrossRatedHeatingCop { get; set; } = null;
        

[Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
    " and .00006041 m3/s per watt of rated total heating capacity")]
[JsonProperty("speed_2_rated_air_flow_rate")]
public string Speed2RatedAirFlowRate { get; set; } = "";
        

[Description(@"Enter the supply air fan power per air volume flow rate at the rated speed 2 test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply air fan during simulations.")]
[JsonProperty("speed_2_rated_supply_air_fan_power_per_volume_flow_rate")]
public System.Nullable<float> Speed2RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

[Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
[JsonProperty("speed_2_heating_capacity_function_of_temperature_curve_name")]
public string Speed2HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_2_heating_capacity_function_of_flow_fraction_curve_name")]
public string Speed2HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
[JsonProperty("speed_2_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_2_energy_input_ratio_function_of_flow_fraction_curve_name")]
public string Speed2EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
[JsonProperty("speed_2_part_load_fraction_correlation_curve_name")]
public string Speed2PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description("recoverable waste heat at full load and rated conditions")]
[JsonProperty("speed_2_rated_waste_heat_fraction_of_power_input")]
public System.Nullable<float> Speed2RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
    "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
[JsonProperty("speed_2_waste_heat_function_of_temperature_curve_name")]
public string Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
[JsonProperty("speed_3_gross_rated_heating_capacity")]
public string Speed3GrossRatedHeatingCapacity { get; set; } = "";
        

[Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply air fan heat or supply air fan electrical energy")]
[JsonProperty("speed_3_gross_rated_heating_cop")]
public System.Nullable<float> Speed3GrossRatedHeatingCop { get; set; } = null;
        

[Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
    " and .00006041 m3/s per watt of rated total heating capacity")]
[JsonProperty("speed_3_rated_air_flow_rate")]
public string Speed3RatedAirFlowRate { get; set; } = "";
        

[Description(@"Enter the supply air fan power per air volume flow rate at the rated speed 3 test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply air fan during simulations.")]
[JsonProperty("speed_3_rated_supply_air_fan_power_per_volume_flow_rate")]
public System.Nullable<float> Speed3RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

[Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
[JsonProperty("speed_3_heating_capacity_function_of_temperature_curve_name")]
public string Speed3HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_3_heating_capacity_function_of_flow_fraction_curve_name")]
public string Speed3HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
[JsonProperty("speed_3_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_3_energy_input_ratio_function_of_flow_fraction_curve_name")]
public string Speed3EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
[JsonProperty("speed_3_part_load_fraction_correlation_curve_name")]
public string Speed3PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description("recoverable waste heat at full load and rated conditions")]
[JsonProperty("speed_3_rated_waste_heat_fraction_of_power_input")]
public System.Nullable<float> Speed3RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
    "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
[JsonProperty("speed_3_waste_heat_function_of_temperature_curve_name")]
public string Speed3WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
[JsonProperty("speed_4_gross_rated_heating_capacity")]
public string Speed4GrossRatedHeatingCapacity { get; set; } = "";
        

[Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply air fan heat or supply air fan electrical energy")]
[JsonProperty("speed_4_gross_rated_heating_cop")]
public System.Nullable<float> Speed4GrossRatedHeatingCop { get; set; } = null;
        

[Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
    " and .00006041 m3/s per watt of rated total heating capacity")]
[JsonProperty("speed_4_rated_air_flow_rate")]
public string Speed4RatedAirFlowRate { get; set; } = "";
        

[Description(@"Enter the supply air fan power per air volume flow rate at the rated speed 4 test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply air fan during simulations.")]
[JsonProperty("speed_4_rated_supply_air_fan_power_per_volume_flow_rate")]
public System.Nullable<float> Speed4RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("773.3", CultureInfo.InvariantCulture);
        

[Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
[JsonProperty("speed_4_heating_capacity_function_of_temperature_curve_name")]
public string Speed4HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_4_heating_capacity_function_of_flow_fraction_curve_name")]
public string Speed4HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
[JsonProperty("speed_4_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
    "f = fraction of the full load flow")]
[JsonProperty("speed_4_energy_input_ratio_function_of_flow_fraction_curve_name")]
public string Speed4EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
[JsonProperty("speed_4_part_load_fraction_correlation_curve_name")]
public string Speed4PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description("recoverable waste heat at full load and rated conditions")]
[JsonProperty("speed_4_rated_waste_heat_fraction_of_power_input")]
public System.Nullable<float> Speed4RatedWasteHeatFractionOfPowerInput { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
    "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
[JsonProperty("speed_4_waste_heat_function_of_temperature_curve_name")]
public string Speed4WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (evaporator) of a heat pump is to be placed. This is an optional input field specified only when user desires to extract heat from the zone. The heat extracted is modeled as internal heat gain of the zone. If the primary DX system is a heat pump, then the zone name should be the same as the zone name specified for placing the secondary cooling DX coil.")]
[JsonProperty("zone_name_for_evaporator_placement")]
public string ZoneNameForEvaporatorPlacement { get; set; } = "";
        

[Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
    "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
    "e when the heat pump is working in cooling mode.")]
[JsonProperty("speed_1_secondary_coil_air_flow_rate")]
public string Speed1SecondaryCoilAirFlowRate { get; set; } = "";
        

[Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
[JsonProperty("speed_1_secondary_coil_fan_flow_scaling_factor")]
public System.Nullable<float> Speed1SecondaryCoilFanFlowScalingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

[Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
[JsonProperty("speed_1_nominal_sensible_heat_ratio_of_secondary_coil")]
public System.Nullable<float> Speed1NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

[Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
[JsonProperty("speed_1_sensible_heat_ratio_modifier_function_of_temperature_curve_name")]
public string Speed1SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
[JsonProperty("speed_1_sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name")]
public string Speed1SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
    "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
    "e when the heat pump is working in cooling mode.")]
[JsonProperty("speed_2_secondary_coil_air_flow_rate")]
public string Speed2SecondaryCoilAirFlowRate { get; set; } = "";
        

[Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
[JsonProperty("speed_2_secondary_coil_fan_flow_scaling_factor")]
public System.Nullable<float> Speed2SecondaryCoilFanFlowScalingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

[Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
[JsonProperty("speed_2_nominal_sensible_heat_ratio_of_secondary_coil")]
public System.Nullable<float> Speed2NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

[Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
[JsonProperty("speed_2_sensible_heat_ratio_modifier_function_of_temperature_curve_name")]
public string Speed2SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
[JsonProperty("speed_2_sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name")]
public string Speed2SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
    "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
    "e when the heat pump is working in cooling mode.")]
[JsonProperty("speed_3_secondary_coil_air_flow_rate")]
public string Speed3SecondaryCoilAirFlowRate { get; set; } = "";
        

[Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
[JsonProperty("speed_3_secondary_coil_fan_flow_scaling_factor")]
public System.Nullable<float> Speed3SecondaryCoilFanFlowScalingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

[Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
[JsonProperty("speed_3_nominal_sensible_heat_ratio_of_secondary_coil")]
public System.Nullable<float> Speed3NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

[Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
[JsonProperty("speed_3_sensible_heat_ratio_modifier_function_of_temperature_curve_name")]
public string Speed3SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
[JsonProperty("speed_3_sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name")]
public string Speed3SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
    "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
    "e when the heat pump is working in cooling mode.")]
[JsonProperty("speed_4_secondary_coil_air_flow_rate")]
public string Speed4SecondaryCoilAirFlowRate { get; set; } = "";
        

[Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
[JsonProperty("speed_4_secondary_coil_fan_flow_scaling_factor")]
public System.Nullable<float> Speed4SecondaryCoilFanFlowScalingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1.25", CultureInfo.InvariantCulture);
        

[Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
[JsonProperty("speed_4_nominal_sensible_heat_ratio_of_secondary_coil")]
public System.Nullable<float> Speed4NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

[Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
[JsonProperty("speed_4_sensible_heat_ratio_modifier_function_of_temperature_curve_name")]
public string Speed4SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
[JsonProperty("speed_4_sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name")]
public string Speed4SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
    }
    
    public enum Coil_Heating_DX_MultiSpeed_DefrostStrategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Resistive")]
        Resistive = 1,
        
        [JsonProperty("ReverseCycle")]
        ReverseCycle = 2,
    }
    
    public enum Coil_Heating_DX_MultiSpeed_DefrostControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("OnDemand")]
        OnDemand = 1,
        
        [JsonProperty("Timed")]
        Timed = 2,
    }
    
    public enum Coil_Heating_DX_MultiSpeed_FuelType
    {
        
        [JsonProperty("Diesel")]
        Diesel = 0,
        
        [JsonProperty("Electricity")]
        Electricity = 1,
        
        [JsonProperty("FuelOilNo1")]
        FuelOilNo1 = 2,
        
        [JsonProperty("FuelOilNo2")]
        FuelOilNo2 = 3,
        
        [JsonProperty("Gasoline")]
        Gasoline = 4,
        
        [JsonProperty("NaturalGas")]
        NaturalGas = 5,
        
        [JsonProperty("OtherFuel1")]
        OtherFuel1 = 6,
        
        [JsonProperty("OtherFuel2")]
        OtherFuel2 = 7,
        
        [JsonProperty("Propane")]
        Propane = 8,
    }
    
    [Description("Direct expansion (DX) heating coil (air-to-air heat pump) and compressor unit (in" +
        "cludes electric compressor and outdoor fan), variable-speed, with defrost contro" +
        "ls. Requires two to ten sets of performance data and will interpolate between sp" +
        "eeds.")]
    [JsonObject("Coil:Heating:DX:VariableSpeed")]
    public class Coil_Heating_DX_VariableSpeed : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("indoor_air_inlet_node_name")]
public string IndoorAirInletNodeName { get; set; } = "";
        

[JsonProperty("indoor_air_outlet_node_name")]
public string IndoorAirOutletNodeName { get; set; } = "";
        

[JsonProperty("number_of_speeds")]
public System.Nullable<float> NumberOfSpeeds { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("must be lower than or equal to the highest speed number")]
[JsonProperty("nominal_speed_level")]
public System.Nullable<float> NominalSpeedLevel { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_heating_capacity_at_selected_nominal_speed_level")]
public string RatedHeatingCapacityAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

[JsonProperty("rated_air_flow_rate_at_selected_nominal_speed_level")]
public string RatedAirFlowRateAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (heating load/steady state capacity)")]
[JsonProperty("energy_part_load_fraction_curve_name")]
public string EnergyPartLoadFractionCurveName { get; set; } = "";
        

[Description("biquadratic curve = a + b*wb + c*wb**2 + d*oat + e*oat**2 + f*wb*oat wb = wet-bul" +
    "b temperature (C) of air entering the indoor coil oat = outdoor air dry-bulb tem" +
    "perature (C) only required if ReverseCycle defrost strategy is specified")]
[JsonProperty("defrost_energy_input_ratio_function_of_temperature_curve_name")]
public string DefrostEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[JsonProperty("minimum_outdoor_dry_bulb_temperature_for_compressor_operation")]
public System.Nullable<float> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = (System.Nullable<float>)Single.Parse("-8", CultureInfo.InvariantCulture);
        

[Description(@"The outdoor temperature when the compressor is automatically turned back on following an automatic shut off because of low outdoor dry-bulb temperature. This field is only used for the calculation of HSPF. If this field is not provided, then outdoor bin temperature used in the HSPF calculation is always considered to be greater than this temperature and 'Minimum Outdoor Dry-Bulb Temperature for Compressor Operation' field described above. This assumption is based on AHRI standard 210/240 (2008) and can introduce significant error in the final value of HSPF.")]
[JsonProperty("outdoor_dry_bulb_temperature_to_turn_on_compressor")]
public System.Nullable<float> OutdoorDryBulbTemperatureToTurnOnCompressor { get; set; } = null;
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_defrost_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForDefrostOperation { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[JsonProperty("crankcase_heater_capacity")]
public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation")]
public System.Nullable<float> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[JsonProperty("defrost_strategy")]
public Coil_Heating_DX_VariableSpeed_DefrostStrategy DefrostStrategy { get; set; } = (Coil_Heating_DX_VariableSpeed_DefrostStrategy)Enum.Parse(typeof(Coil_Heating_DX_VariableSpeed_DefrostStrategy), "ReverseCycle");
        

[JsonProperty("defrost_control")]
public Coil_Heating_DX_VariableSpeed_DefrostControl DefrostControl { get; set; } = (Coil_Heating_DX_VariableSpeed_DefrostControl)Enum.Parse(typeof(Coil_Heating_DX_VariableSpeed_DefrostControl), "Timed");
        

[Description("Fraction of time in defrost mode only applicable if timed defrost control is spec" +
    "ified")]
[JsonProperty("defrost_time_period_fraction")]
public System.Nullable<float> DefrostTimePeriodFraction { get; set; } = (System.Nullable<float>)Single.Parse("0.058333", CultureInfo.InvariantCulture);
        

[Description("only applicable if resistive defrost strategy is specified")]
[JsonProperty("resistive_defrost_heater_capacity")]
public string ResistiveDefrostHeaterCapacity { get; set; } = (System.String)"0";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_1_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed1ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed1ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed1ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_1_heating_capacity_function_of_temperature_curve_name")]
public string Speed1HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_1_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed1TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_1_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_1_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed1EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_2_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed2ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed2ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed2ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_2_heating_capacity_function_of_temperature_curve_name")]
public string Speed2HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_2_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed2TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_2_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_2_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed2EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_3_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed3ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed3ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed3ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_3_heating_capacity_function_of_temperature_curve_name")]
public string Speed3HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_3_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed3TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_3_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_3_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed3EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_4_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed4ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed4ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed4ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_4_heating_capacity_function_of_temperature_curve_name")]
public string Speed4HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_4_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed4HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_4_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_4_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed4EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_5_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed5ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed5ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed5ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_5_heating_capacity_function_of_temperature_curve_name")]
public string Speed5HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_5_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed5HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_5_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed5EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_5_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed5EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_6_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed6ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed6ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed6ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_6_heating_capacity_function_of_temperature_curve_name")]
public string Speed6HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_6_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed6HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_6_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed6EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_6_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed6EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_7_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed7ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed7ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed7ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_7_heating_capacity_function_of_temperature_curve_name")]
public string Speed7HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_7_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed7HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_7_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed7EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_7_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed7EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_8_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed8ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed8ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed8ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_8_heating_capacity_function_of_temperature_curve_name")]
public string Speed8HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_8_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed8HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_8_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed8EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_8_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed8EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_9_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed9ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed9ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed9ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_9_heating_capacity_function_of_temperature_curve_name")]
public string Speed9HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_9_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed9HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_9_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed9EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_9_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed9EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_10_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed10ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed10ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed10ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_10_heating_capacity_function_of_temperature_curve_name")]
public string Speed10HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_10_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed10HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*db + c*db**2 + d*oat + e*oat**2 + f*db*oat db = entering air dry-bu" +
    "lb temperature (C) oat = air entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_10_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed10EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_10_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed10EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
    }
    
    public enum Coil_Heating_DX_VariableSpeed_DefrostStrategy
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Resistive")]
        Resistive = 1,
        
        [JsonProperty("ReverseCycle")]
        ReverseCycle = 2,
    }
    
    public enum Coil_Heating_DX_VariableSpeed_DefrostControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("OnDemand")]
        OnDemand = 1,
        
        [JsonProperty("Timed")]
        Timed = 2,
    }
    
    [Description(@"Direct expansion (DX) cooling coil for water-to-air heat pump (includes electric compressor), single-speed, parameter estimation model. Optional inputs for moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Parameter estimation model is a deterministic model that requires a consistent set of parameters to describe the operating conditions of the heat pump components.")]
    [JsonObject("Coil:Cooling:WaterToAirHeatPump:ParameterEstimation")]
    public class Coil_Cooling_WaterToAirHeatPump_ParameterEstimation : BHoMObject, IEnergyPlusClass
    {
        

[Description("Parameters 1-5 are as named below. Parameters 6-10 depend on the type of compress" +
    "or and fluid. Refer to the InputOutputReference on the parameters required")]
[JsonProperty("compressor_type")]
public Coil_Cooling_WaterToAirHeatPump_ParameterEstimation_CompressorType CompressorType { get; set; } = (Coil_Cooling_WaterToAirHeatPump_ParameterEstimation_CompressorType)Enum.Parse(typeof(Coil_Cooling_WaterToAirHeatPump_ParameterEstimation_CompressorType), "Reciprocating");
        

[JsonProperty("refrigerant_type")]
public string RefrigerantType { get; set; } = (System.String)"R22";
        

[JsonProperty("design_source_side_flow_rate")]
public System.Nullable<float> DesignSourceSideFlowRate { get; set; } = null;
        

[JsonProperty("nominal_cooling_coil_capacity")]
public System.Nullable<float> NominalCoolingCoilCapacity { get; set; } = null;
        

[Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
[JsonProperty("nominal_time_for_condensate_removal_to_begin")]
public System.Nullable<float> NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
[JsonProperty("ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capacity")]
public System.Nullable<float> RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("high_pressure_cutoff")]
public System.Nullable<float> HighPressureCutoff { get; set; } = null;
        

[JsonProperty("low_pressure_cutoff")]
public System.Nullable<float> LowPressureCutoff { get; set; } = null;
        

[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Previously called Parameter 1")]
[JsonProperty("load_side_total_heat_transfer_coefficient")]
public System.Nullable<float> LoadSideTotalHeatTransferCoefficient { get; set; } = null;
        

[Description("Previously called Parameter 2")]
[JsonProperty("load_side_outside_surface_heat_transfer_coefficient")]
public System.Nullable<float> LoadSideOutsideSurfaceHeatTransferCoefficient { get; set; } = null;
        

[Description("Previously called Parameter 3")]
[JsonProperty("superheat_temperature_at_the_evaporator_outlet")]
public System.Nullable<float> SuperheatTemperatureAtTheEvaporatorOutlet { get; set; } = null;
        

[Description("Accounts for the loss of work due to mechanical and electrical losses in the comp" +
    "ressor. Previously called Parameter 4")]
[JsonProperty("compressor_power_losses")]
public System.Nullable<float> CompressorPowerLosses { get; set; } = null;
        

[Description("Previously called Parameter 5")]
[JsonProperty("compressor_efficiency")]
public System.Nullable<float> CompressorEfficiency { get; set; } = null;
        

[Description("Use when Compressor Type is Reciprocating or Rotary Leave this field blank for Co" +
    "mpressor Type is Scroll. Previously part of Parameter 6")]
[JsonProperty("compressor_piston_displacement")]
public System.Nullable<float> CompressorPistonDisplacement { get; set; } = null;
        

[Description("Used when Compressor Type is Rotary or Reciprocating Leave this field blank for C" +
    "ompressor Type is Scroll. Previously part of Parameter 7")]
[JsonProperty("compressor_suction_discharge_pressure_drop")]
public System.Nullable<float> CompressorSuctionDischargePressureDrop { get; set; } = null;
        

[Description("Used when Compressor Type is Reciprocating. Leave this field blank for Compressor" +
    " Type is Rotary or Scroll. Previously part of Parameter 8")]
[JsonProperty("compressor_clearance_factor")]
public System.Nullable<float> CompressorClearanceFactor { get; set; } = null;
        

[Description("Use when Compressor Type is Scroll Leave this field blank for Compressor Type is " +
    "Rotary or Reciprocating. Previously part of Parameter 6")]
[JsonProperty("refrigerant_volume_flow_rate")]
public System.Nullable<float> RefrigerantVolumeFlowRate { get; set; } = null;
        

[Description("Use when Compressor Type is Scroll. Leave this field blank for Compressor Type is" +
    " Rotary or Reciprocating. Previously part of Parameter 7")]
[JsonProperty("volume_ratio")]
public System.Nullable<float> VolumeRatio { get; set; } = null;
        

[Description("Use when Compressor Type is Scroll. Leave this field blank for Compressor Type is" +
    " Rotary or Reciprocating. Previously part of Parameter 8")]
[JsonProperty("leak_rate_coefficient")]
public System.Nullable<float> LeakRateCoefficient { get; set; } = null;
        

[Description("Use when Source Side Fluid Name is Water Leave this field blank when Source Side " +
    "Fluid Name is an antifreeze Previously part of Parameter 9")]
[JsonProperty("source_side_heat_transfer_coefficient")]
public System.Nullable<float> SourceSideHeatTransferCoefficient { get; set; } = null;
        

[Description("Use when Source Side Fluid Name is an antifreeze Leave this field blank for Sourc" +
    "e Side Fluid is Water Previously part of Parameter 9")]
[JsonProperty("source_side_heat_transfer_resistance1")]
public System.Nullable<float> SourceSideHeatTransferResistance1 { get; set; } = null;
        

[Description("Use when Source Side Fluid Name is an antifreeze Leave this field blank for Sourc" +
    "e Side Fluid is Water Previously part of Parameter 10")]
[JsonProperty("source_side_heat_transfer_resistance2")]
public System.Nullable<float> SourceSideHeatTransferResistance2 { get; set; } = null;
    }
    
    public enum Coil_Cooling_WaterToAirHeatPump_ParameterEstimation_CompressorType
    {
        
        [JsonProperty("Reciprocating")]
        Reciprocating = 0,
        
        [JsonProperty("Rotary")]
        Rotary = 1,
        
        [JsonProperty("Scroll")]
        Scroll = 2,
    }
    
    [Description(@"Direct expansion (DX) heating coil for water-to-air heat pump (includes electric compressor), single-speed, parameter estimation model. Parameter estimation model is a deterministic model that requires a consistent set of parameters to describe the operating conditions of the heat pump components.")]
    [JsonObject("Coil:Heating:WaterToAirHeatPump:ParameterEstimation")]
    public class Coil_Heating_WaterToAirHeatPump_ParameterEstimation : BHoMObject, IEnergyPlusClass
    {
        

[Description("Parameters 1-4 are as named below. Parameters 5-9 depend on the type of compresso" +
    "r. Refer to the InputOutputReference on the parameters required")]
[JsonProperty("compressor_type")]
public Coil_Heating_WaterToAirHeatPump_ParameterEstimation_CompressorType CompressorType { get; set; } = (Coil_Heating_WaterToAirHeatPump_ParameterEstimation_CompressorType)Enum.Parse(typeof(Coil_Heating_WaterToAirHeatPump_ParameterEstimation_CompressorType), "Reciprocating");
        

[JsonProperty("refrigerant_type")]
public string RefrigerantType { get; set; } = (System.String)"R22";
        

[JsonProperty("design_source_side_flow_rate")]
public System.Nullable<float> DesignSourceSideFlowRate { get; set; } = null;
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("gross_rated_heating_capacity")]
public System.Nullable<float> GrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("high_pressure_cutoff")]
public System.Nullable<float> HighPressureCutoff { get; set; } = null;
        

[JsonProperty("low_pressure_cutoff")]
public System.Nullable<float> LowPressureCutoff { get; set; } = null;
        

[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[Description("Previously called Parameter 1")]
[JsonProperty("load_side_total_heat_transfer_coefficient")]
public System.Nullable<float> LoadSideTotalHeatTransferCoefficient { get; set; } = null;
        

[Description("Previously called Parameter 2")]
[JsonProperty("superheat_temperature_at_the_evaporator_outlet")]
public System.Nullable<float> SuperheatTemperatureAtTheEvaporatorOutlet { get; set; } = null;
        

[Description("Accounts for the loss of work due to mechanical and electrical losses in the comp" +
    "ressor. Previously called Parameter 3")]
[JsonProperty("compressor_power_losses")]
public System.Nullable<float> CompressorPowerLosses { get; set; } = null;
        

[Description("Previously called Parameter 4")]
[JsonProperty("compressor_efficiency")]
public System.Nullable<float> CompressorEfficiency { get; set; } = null;
        

[Description("Use when Compressor Type is Reciprocating or Rotary Leave this field blank for Co" +
    "mpressor Type is Scroll. Previously part of Parameter 5")]
[JsonProperty("compressor_piston_displacement")]
public System.Nullable<float> CompressorPistonDisplacement { get; set; } = null;
        

[Description("Used when Compressor Type is Rotary or Reciprocating Leave this field blank for C" +
    "ompressor Type is Scroll. Previously part of Parameter 6")]
[JsonProperty("compressor_suction_discharge_pressure_drop")]
public System.Nullable<float> CompressorSuctionDischargePressureDrop { get; set; } = null;
        

[Description("Used when Compressor Type is Reciprocating. Leave this field blank for Compressor" +
    " Type is Rotary or Scroll. Previously part of Parameter 7")]
[JsonProperty("compressor_clearance_factor")]
public System.Nullable<float> CompressorClearanceFactor { get; set; } = null;
        

[Description("Use when Compressor Type is Scroll Leave this field blank for Compressor Type is " +
    "Rotary or Reciprocating. Previously part of Parameter 5")]
[JsonProperty("refrigerant_volume_flow_rate")]
public System.Nullable<float> RefrigerantVolumeFlowRate { get; set; } = null;
        

[Description("Use when Compressor Type is Scroll. Leave this field blank for Compressor Type is" +
    " Rotary or Reciprocating. Previously part of Parameter 6")]
[JsonProperty("volume_ratio")]
public System.Nullable<float> VolumeRatio { get; set; } = null;
        

[Description("Use when Compressor Type is Scroll. Leave this field blank for Compressor Type is" +
    " Rotary or Reciprocating. Previously part of Parameter 7")]
[JsonProperty("leak_rate_coefficient")]
public System.Nullable<float> LeakRateCoefficient { get; set; } = null;
        

[Description("Use when Source Side Fluid Name is Water Leave this field blank when Source Side " +
    "Fluid is an antifreeze Previously part of Parameter 8")]
[JsonProperty("source_side_heat_transfer_coefficient")]
public System.Nullable<float> SourceSideHeatTransferCoefficient { get; set; } = null;
        

[Description("Use when Source Side Fluid Name is an antifreeze Leave this field blank for Sourc" +
    "e Side Fluid is Water Previously part of Parameter 8")]
[JsonProperty("source_side_heat_transfer_resistance1")]
public System.Nullable<float> SourceSideHeatTransferResistance1 { get; set; } = null;
        

[Description("Use when Source Side Fluid Name is an antifreeze Leave this field blank for Sourc" +
    "e Side Fluid is Water Previously part of Parameter 9")]
[JsonProperty("source_side_heat_transfer_resistance2")]
public System.Nullable<float> SourceSideHeatTransferResistance2 { get; set; } = null;
    }
    
    public enum Coil_Heating_WaterToAirHeatPump_ParameterEstimation_CompressorType
    {
        
        [JsonProperty("Reciprocating")]
        Reciprocating = 0,
        
        [JsonProperty("Rotary")]
        Rotary = 1,
        
        [JsonProperty("Scroll")]
        Scroll = 2,
    }
    
    [Description(@"Direct expansion (DX) cooling coil for water-to-air heat pump (includes electric compressor), single-speed, equation-fit model. Optional inputs for moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Equation-fit model uses normalized curves to describe the heat pump performance.")]
    [JsonObject("Coil:Cooling:WaterToAirHeatPump:EquationFit")]
    public class Coil_Cooling_WaterToAirHeatPump_EquationFit : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("rated_air_flow_rate")]
public string RatedAirFlowRate { get; set; } = "";
        

[JsonProperty("rated_water_flow_rate")]
public string RatedWaterFlowRate { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("gross_rated_total_cooling_capacity")]
public string GrossRatedTotalCoolingCapacity { get; set; } = "";
        

[JsonProperty("gross_rated_sensible_cooling_capacity")]
public string GrossRatedSensibleCoolingCapacity { get; set; } = "";
        

[JsonProperty("gross_rated_cooling_cop")]
public System.Nullable<float> GrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("total_cooling_capacity_curve_name")]
public string TotalCoolingCapacityCurveName { get; set; } = "";
        

[JsonProperty("sensible_cooling_capacity_curve_name")]
public string SensibleCoolingCapacityCurveName { get; set; } = "";
        

[JsonProperty("cooling_power_consumption_curve_name")]
public string CoolingPowerConsumptionCurveName { get; set; } = "";
        

[Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
[JsonProperty("nominal_time_for_condensate_removal_to_begin")]
public System.Nullable<float> NominalTimeForCondensateRemovalToBegin { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
[JsonProperty("ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capacity")]
public System.Nullable<float> RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description(@"Direct expansion (DX) cooling coil for water-to-air heat pump (includes electric compressor), variable-speed, equation-fit model. Optional inputs for moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Equation-fit model uses normalized curves to describe the heat pump performance. Requires two to ten sets of performance data and will interpolate between speeds. Modeled as a single coil with variable-speed compressor.")]
    [JsonObject("Coil:Cooling:WaterToAirHeatPump:VariableSpeedEquationFit")]
    public class Coil_Cooling_WaterToAirHeatPump_VariableSpeedEquationFit : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("water_to_refrigerant_hx_water_inlet_node_name")]
public string WaterToRefrigerantHxWaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_to_refrigerant_hx_water_outlet_node_name")]
public string WaterToRefrigerantHxWaterOutletNodeName { get; set; } = "";
        

[JsonProperty("indoor_air_inlet_node_name")]
public string IndoorAirInletNodeName { get; set; } = "";
        

[JsonProperty("indoor_air_outlet_node_name")]
public string IndoorAirOutletNodeName { get; set; } = "";
        

[JsonProperty("number_of_speeds")]
public System.Nullable<float> NumberOfSpeeds { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("must be lower than or equal to the highest speed number")]
[JsonProperty("nominal_speed_level")]
public System.Nullable<float> NominalSpeedLevel { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("gross_rated_total_cooling_capacity_at_selected_nominal_speed_level")]
public string GrossRatedTotalCoolingCapacityAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

[JsonProperty("rated_air_flow_rate_at_selected_nominal_speed_level")]
public string RatedAirFlowRateAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

[JsonProperty("rated_water_flow_rate_at_selected_nominal_speed_level")]
public string RatedWaterFlowRateAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

[JsonProperty("nominal_time_for_condensate_to_begin_leaving_the_coil")]
public System.Nullable<float> NominalTimeForCondensateToBeginLeavingTheCoil { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("initial_moisture_evaporation_rate_divided_by_steady_state_ac_latent_capacity")]
public System.Nullable<float> InitialMoistureEvaporationRateDividedBySteadyStateAcLatentCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Flag for using hot gas reheat, 0 - not used, 1 - used")]
[JsonProperty("flag_for_using_hot_gas_reheat_0_or_1")]
public System.Nullable<float> FlagForUsingHotGasReheat0Or1 { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (cooling load/steady state capacity)")]
[JsonProperty("energy_part_load_fraction_curve_name")]
public string EnergyPartLoadFractionCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_1_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed1ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed1ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed1ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed1ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed1ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering wet-bulb t" +
    "emperature (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_1_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed1TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_1_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed1TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
    "**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_1_total_cooling_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed1TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering wet-bulb t" +
    "emperature (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_1_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_1_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed1EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
    "**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_1_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed1EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_1_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed1ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering wet-bulb t" +
    "emperature (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_1_waste_heat_function_of_temperature_curve_name")]
public string Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_2_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed2ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed2ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed2ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed2ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed2ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering wet-bulb t" +
    "emperature (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_2_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed2TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_2_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed2TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
    "**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_2_total_cooling_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed2TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*wb + c*wb**2 + d*ewet + e*ewt**2 + f*wb*ewt wb = entering wet-bulb " +
    "temperature (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_2_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_2_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed2EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
    "**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_2_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed2EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_2_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed2ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering wet-bulb t" +
    "emperature (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_2_waste_heat_function_of_temperature_curve_name")]
public string Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_3_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed3ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed3ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed3ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed3ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed3ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_3_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed3TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_3_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed3TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_3_total_cooling_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed3TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_3_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_3_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed3EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_3_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed3EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_3_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed3ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_3_waste_heat_function_of_temperature_curve_name")]
public string Speed3WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_4_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed4ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed4ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed4ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed4ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed4ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_4_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed4TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_4_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed4TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_4_total_cooling_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed4TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_4_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_4_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed4EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_4_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed4EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_4_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed4ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_4_waste_heat_function_of_temperature_curve_name")]
public string Speed4WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_5_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed5ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed5ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed5ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed5ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed5ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_5_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed5TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_5_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed5TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_5_total_cooling_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed5TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_5_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed5EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_5_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed5EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_5_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed5EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_5_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed5ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_5_waste_heat_function_of_temperature_curve_name")]
public string Speed5WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_6_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed6ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed6ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed6ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed6ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed6ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_6_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed6TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_6_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed6TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_6_total_cooling_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed6TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_6_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed6EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_6_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed6EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_6_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed6EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_6_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed6ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_6_waste_heat_function_of_temperature_curve_name")]
public string Speed6WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_7_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed7ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed7ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed7ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed7ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed7ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_7_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed7TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_7_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed7TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_7_total_cooling_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed7TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_7_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed7EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_7_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed7EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_7_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed7EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_7_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed7ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_7_waste_heat_function_of_temperature_curve_name")]
public string Speed7WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_8_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed8ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed8ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed8ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed8ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed8ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_8_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed8TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_8_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed8TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_8_total_cooling_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed8TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_8_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed8EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_8_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed8EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_8_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed8EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_8_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed8ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_8_waste_heat_function_of_temperature_curve_name")]
public string Speed8WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_9_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed9ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed9ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed9ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed9ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed9ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_9_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed9TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_9_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed9TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_9_total_cooling_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed9TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_9_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed9EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_9_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed9EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_9_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed9EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_9_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed9ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_9_waste_heat_function_of_temperature_curve_name")]
public string Speed9WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_10_reference_unit_gross_rated_total_cooling_capacity")]
public System.Nullable<float> Speed10ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_gross_rated_sensible_heat_ratio")]
public System.Nullable<float> Speed10ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_gross_rated_cooling_cop")]
public System.Nullable<float> Speed10ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed10ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed10ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_10_total_cooling_capacity_function_of_temperature_curve_name")]
public string Speed10TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_10_total_cooling_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed10TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_10_total_cooling_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed10TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_10_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed10EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_10_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed10EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_10_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed10EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_10_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed10ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
    "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
    "C)")]
[JsonProperty("speed_10_waste_heat_function_of_temperature_curve_name")]
public string Speed10WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
    }
    
    [Description("Direct expansion (DX) heating coil for water-to-air heat pump (includes electric " +
        "compressor), single-speed, equation-fit model. Equation-fit model uses normalize" +
        "d curves to describe the heat pump performance.")]
    [JsonObject("Coil:Heating:WaterToAirHeatPump:EquationFit")]
    public class Coil_Heating_WaterToAirHeatPump_EquationFit : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[JsonProperty("air_inlet_node_name")]
public string AirInletNodeName { get; set; } = "";
        

[JsonProperty("air_outlet_node_name")]
public string AirOutletNodeName { get; set; } = "";
        

[JsonProperty("rated_air_flow_rate")]
public string RatedAirFlowRate { get; set; } = "";
        

[JsonProperty("rated_water_flow_rate")]
public string RatedWaterFlowRate { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("gross_rated_heating_capacity")]
public string GrossRatedHeatingCapacity { get; set; } = "";
        

[JsonProperty("gross_rated_heating_cop")]
public System.Nullable<float> GrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("heating_capacity_curve_name")]
public string HeatingCapacityCurveName { get; set; } = "";
        

[JsonProperty("heating_power_consumption_curve_name")]
public string HeatingPowerConsumptionCurveName { get; set; } = "";
    }
    
    [Description(@"Direct expansion (DX) heating coil for water-to-air heat pump (includes electric compressor), variable-speed, equation-fit model. Equation-fit model uses normalized curves to describe the heat pump performance. Requires two to ten sets of performance data and will interpolate between speeds.")]
    [JsonObject("Coil:Heating:WaterToAirHeatPump:VariableSpeedEquationFit")]
    public class Coil_Heating_WaterToAirHeatPump_VariableSpeedEquationFit : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("water_to_refrigerant_hx_water_inlet_node_name")]
public string WaterToRefrigerantHxWaterInletNodeName { get; set; } = "";
        

[JsonProperty("water_to_refrigerant_hx_water_outlet_node_name")]
public string WaterToRefrigerantHxWaterOutletNodeName { get; set; } = "";
        

[JsonProperty("indoor_air_inlet_node_name")]
public string IndoorAirInletNodeName { get; set; } = "";
        

[JsonProperty("indoor_air_outlet_node_name")]
public string IndoorAirOutletNodeName { get; set; } = "";
        

[JsonProperty("number_of_speeds")]
public System.Nullable<float> NumberOfSpeeds { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("must be lower than or equal to the highest speed number")]
[JsonProperty("nominal_speed_level")]
public System.Nullable<float> NominalSpeedLevel { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[JsonProperty("rated_heating_capacity_at_selected_nominal_speed_level")]
public string RatedHeatingCapacityAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

[JsonProperty("rated_air_flow_rate_at_selected_nominal_speed_level")]
public string RatedAirFlowRateAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

[JsonProperty("rated_water_flow_rate_at_selected_nominal_speed_level")]
public string RatedWaterFlowRateAtSelectedNominalSpeedLevel { get; set; } = (System.String)"Autosize";
        

[Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
    "**3 PLR = part load ratio (heating load/steady state capacity)")]
[JsonProperty("energy_part_load_fraction_curve_name")]
public string EnergyPartLoadFractionCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_1_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed1ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed1ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_rated_air_flow")]
public System.Nullable<float> Speed1ReferenceUnitRatedAirFlow { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed1ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering air dry-bu" +
    "lb temperature (C) ewt = water entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_1_heating_capacity_function_of_temperature_curve_name")]
public string Speed1HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_1_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed1TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
    "**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_1_heating_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed1HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering air dry-bu" +
    "lb temperature (C) ewt = water entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_1_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_1_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed1EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
    "**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_1_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed1EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_1_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed1ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering air dry-bu" +
    "lb temperature (C) ewt = water entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_1_waste_heat_function_of_temperature_curve_name")]
public string Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_2_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed2ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed2ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed2ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed2ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering air dry-bu" +
    "lb temperature (C) ewt = water entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_2_heating_capacity_function_of_temperature_curve_name")]
public string Speed2HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_2_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed2TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
    "**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_2_heating_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed2HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering air dry-bu" +
    "lb temperature (C) ewt = water entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_2_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
    "**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_2_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed2EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_2_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed2EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_2_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed2ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering air dry-bu" +
    "lb temperature (C) ewt = water entering temperature seen by the evaporator (C)")]
[JsonProperty("speed_2_waste_heat_function_of_temperature_curve_name")]
public string Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_3_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed3ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed3ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed3ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed3ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_3_heating_capacity_function_of_temperature_curve_name")]
public string Speed3HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_3_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed3TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_3_heating_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed3HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_3_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_3_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed3EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_3_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed3EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_3_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed3ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_3_waste_heat_function_of_temperature_curve_name")]
public string Speed3WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_4_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed4ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed4ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed4ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed4ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_4_heating_capacity_function_of_temperature_curve_name")]
public string Speed4HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_4_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed4TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_4_heating_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed4HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_4_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_4_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed4EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_4_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed4EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_4_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed4ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_4_waste_heat_function_of_temperature_curve_name")]
public string Speed4WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_5_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed5ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed5ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed5ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed5ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_5_heating_capacity_function_of_temperature_curve_name")]
public string Speed5HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_5_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed5TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_5_heating_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed5HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_5_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed5EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_5_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed5EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_5_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed5EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_5_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed5ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_5_waste_heat_function_of_temperature_curve_name")]
public string Speed5WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_6_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed6ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed6ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed6ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed6ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_6_heating_capacity_function_of_temperature_curve_name")]
public string Speed6HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_6_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed6TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_6_heating_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed6HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_6_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed6EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_6_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed6EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_6_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed6EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_6_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed6ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_6_waste_heat_function_of_temperature_curve_name")]
public string Speed6WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_7_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed7ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed7ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed7ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed7ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_7_heating_capacity_function_of_temperature_curve_name")]
public string Speed7HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_7_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed7TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_7_heating_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed7HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_7_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed7EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_7_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed7EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_7_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed7EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_7_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed7ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_7_waste_heat_function_of_temperature_curve_name")]
public string Speed7WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_8_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed8ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed8ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed8ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed8ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_8_heating_capacity_function_of_temperature_curve_name")]
public string Speed8HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_8_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed8TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_8_heating_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed8HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_8_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed8EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_8_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed8EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_8_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed8EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_8_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed8ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_8_waste_heat_function_of_temperature_curve_name")]
public string Speed8WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_9_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed9ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed9ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed9ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed9ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_9_heating_capacity_function_of_temperature_curve_name")]
public string Speed9HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_9_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed9TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_9_heating_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed9HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_9_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed9EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_9_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed9EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_9_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed9EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_9_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed9ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_9_waste_heat_function_of_temperature_curve_name")]
public string Speed9WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Heating capacity not accounting for the effect of supply air fan heat")]
[JsonProperty("speed_10_reference_unit_gross_rated_heating_capacity")]
public System.Nullable<float> Speed10ReferenceUnitGrossRatedHeatingCapacity { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_gross_rated_heating_cop")]
public System.Nullable<float> Speed10ReferenceUnitGrossRatedHeatingCop { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed10ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed10ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_10_heating_capacity_function_of_temperature_curve_name")]
public string Speed10HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_10_total_heating_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed10TotalHeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_10_heating_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed10HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_10_energy_input_ratio_function_of_temperature_curve_name")]
public string Speed10EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
    "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
[JsonProperty("speed_10_energy_input_ratio_function_of_air_flow_fraction_curve_name")]
public string Speed10EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
    "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
[JsonProperty("speed_10_energy_input_ratio_function_of_water_flow_fraction_curve_name")]
public string Speed10EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("speed_10_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions")]
public System.Nullable<float> Speed10ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

[Description("optional curve = a + b*db + c*db**2 + d*ewt + e*ewt**2 + f*db*ewt db = entering a" +
    "ir dry-bulb temperature (C) ewt = water entering temperature seen by the evapora" +
    "tor (C)")]
[JsonProperty("speed_10_waste_heat_function_of_temperature_curve_name")]
public string Speed10WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
    }
    
    [Description("Heat pump water heater (HPWH) heating coil, air-to-water direct-expansion (DX) sy" +
        "stem which includes a water heating coil, evaporator air coil, evaporator fan, e" +
        "lectric compressor, and water pump. Part of a WaterHeater:HeatPump:PumpedCondens" +
        "er system.")]
    [JsonObject("Coil:WaterHeating:AirToWaterHeatPump:Pumped")]
    public class Coil_WaterHeating_AirToWaterHeatPump_Pumped : BHoMObject, IEnergyPlusClass
    {
        

[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
    " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
    "lude condenser pump heat.")]
[JsonProperty("rated_heating_capacity")]
public System.Nullable<float> RatedHeatingCapacity { get; set; } = null;
        

[Description("Heating coefficient of performance at the rated inlet air temperatures, rated con" +
    "denser inlet water temperature, rated air flow rate, and rated water flow rate. " +
    "Can optionally include condenser pump power and evaporator fan power (see fields" +
    " below).")]
[JsonProperty("rated_cop")]
public System.Nullable<float> RatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

[Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
[JsonProperty("rated_sensible_heat_ratio")]
public System.Nullable<float> RatedSensibleHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[Description("Evaporator inlet air dry-bulb temperature corresponding to rated coil performance" +
    " (heating capacity, COP and SHR).")]
[JsonProperty("rated_evaporator_inlet_air_dry_bulb_temperature")]
public System.Nullable<float> RatedEvaporatorInletAirDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("19.7", CultureInfo.InvariantCulture);
        

[Description("Evaporator inlet air wet-bulb temperature corresponding to rated coil performance" +
    " (heating capacity, COP and SHR).")]
[JsonProperty("rated_evaporator_inlet_air_wet_bulb_temperature")]
public System.Nullable<float> RatedEvaporatorInletAirWetBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13.5", CultureInfo.InvariantCulture);
        

[Description("Condenser inlet water temperature corresponding to rated coil performance (heatin" +
    "g capacity, COP and SHR).")]
[JsonProperty("rated_condenser_inlet_water_temperature")]
public System.Nullable<float> RatedCondenserInletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("57.5", CultureInfo.InvariantCulture);
        

[Description("Evaporator air flow rate corresponding to rated coil performance (heating capacit" +
    "y, COP and SHR). Default is 5.035E-5 m3/s/W (31.25 cfm/MBH) of rated heating cap" +
    "acity when autocalculated.")]
[JsonProperty("rated_evaporator_air_flow_rate")]
public string RatedEvaporatorAirFlowRate { get; set; } = "";
        

[Description(@"Condenser water flow rate corresponding to rated coil performance (heating capacity, COP and SHR). Default is 4.487E-8 m3/s/W (0.208 gpm/MBH) of rated heating capacity when autocalculated. A warning message will be issued if the ratio of Rated Condenser Water Flow Rate to Heating Capacity is less than 1.79405E-8 m3/s/W (0.083 gpm/MBH) or greater than 8.97024E-8 m3/s/W (0.417 gpm/MBH), but the simulation will continue.")]
[JsonProperty("rated_condenser_water_flow_rate")]
public string RatedCondenserWaterFlowRate { get; set; } = "";
        

[Description("Select Yes if the evaporator fan power is included in the rated COP. This choice " +
    "field impacts the calculation of compressor electric power.")]
[JsonProperty("evaporator_fan_power_included_in_rated_cop")]
public EmptyNoYes EvaporatorFanPowerIncludedInRatedCop { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("Select Yes if the condenser pump power is included in the rated COP. This choice " +
    "field impacts the calculation of compressor electric power.")]
[JsonProperty("condenser_pump_power_included_in_rated_cop")]
public EmptyNoYes CondenserPumpPowerIncludedInRatedCop { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Select Yes if the condenser pump heat is included in the rated heating capacity a" +
    "nd rated COP. This choice field impacts the calculation of water heating capacit" +
    "y.")]
[JsonProperty("condenser_pump_heat_included_in_rated_heating_capacity_and_rated_cop")]
public EmptyNoYes CondenserPumpHeatIncludedInRatedHeatingCapacityAndRatedCop { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("A warning message will be issued if the ratio of Condenser Water Pump Power to Ra" +
    "ted Heating Capacity exceeds 0.1422 W/W (41.67 Watts/MBH), but the simulation wi" +
    "ll continue.")]
[JsonProperty("condenser_water_pump_power")]
public System.Nullable<float> CondenserWaterPumpPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Fraction of pump heat transferred to the condenser water. The pump is assumed to " +
    "be located downstream of the condenser.")]
[JsonProperty("fraction_of_condenser_pump_heat_to_water")]
public System.Nullable<float> FractionOfCondenserPumpHeatToWater { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("The node from which the DX coil draws its inlet air.")]
[JsonProperty("evaporator_air_inlet_node_name")]
public string EvaporatorAirInletNodeName { get; set; } = "";
        

[Description("The node to which the DX coil sends its outlet air.")]
[JsonProperty("evaporator_air_outlet_node_name")]
public string EvaporatorAirOutletNodeName { get; set; } = "";
        

[Description("The node from which the DX coil condenser draws its inlet water. This name should" +
    " match the source side outlet node name in the associated water heater tank obje" +
    "ct.")]
[JsonProperty("condenser_water_inlet_node_name")]
public string CondenserWaterInletNodeName { get; set; } = "";
        

[Description("The node to which the DX coil condenser sends its outlet water. This name should " +
    "match the source side inlet node name in the associated water heater tank object" +
    ".")]
[JsonProperty("condenser_water_outlet_node_name")]
public string CondenserWaterOutletNodeName { get; set; } = "";
        

[Description(@"The compressor crankcase heater only operates when the dry-bulb temperature of air surrounding the compressor is below the Maximum Ambient Temperature for Crankcase Heater Operation and the DX coil is off. The ambient temperature surrounding the compressor is set by the WaterHeater:HeatPump:PumpedCondenser parent object (field Compressor Location).")]
[JsonProperty("crankcase_heater_capacity")]
public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"The compressor crankcase heater only operates when the dry-bulb temperature of air surrounding the compressor is below the Maximum Outdoor Temperature for Crankcase Heater Operation and the unit is off. The ambient temperature surrounding the compressor is set by the WaterHeater:HeatPump:PumpedCondenser parent object (field Compressor Location).")]
[JsonProperty("maximum_ambient_temperature_for_crankcase_heater_operation")]
public System.Nullable<float> MaximumAmbientTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("Determines temperature type for heating capacity curves and heating COP curves. T" +
    "his input determines whether the inlet air dry-bulb or wet-bulb temperature is u" +
    "sed to evaluate these curves.")]
[JsonProperty("evaporator_air_temperature_type_for_curve_objects")]
public Coil_WaterHeating_AirToWaterHeatPump_Pumped_EvaporatorAirTemperatureTypeForCurveObjects EvaporatorAirTemperatureTypeForCurveObjects { get; set; } = (Coil_WaterHeating_AirToWaterHeatPump_Pumped_EvaporatorAirTemperatureTypeForCurveObjects)Enum.Parse(typeof(Coil_WaterHeating_AirToWaterHeatPump_Pumped_EvaporatorAirTemperatureTypeForCurveObjects), "WetBulbTemperature");
        

[Description(@"Heating capacity modifier curve (function of temperature) should be biquadratic or cubic. Biquadratic curve = a + b(ta) + c(ta)^2 + d(tw) + e(tw)^2 + f(ta)(tw). Cubic curve = a + b(ta) + c(ta)^2 + d(ta)^3. ta = evaporator inlet air [dry-bulb or wet-bulb] temperature (C). tw = condenser inlet water temperature (C). The field Evaporator Air Temperature Type for Curve Objects determines if dry-bulb or wet-bulb is used as the evaporator inlet air temperature (ta).")]
[JsonProperty("heating_capacity_function_of_temperature_curve_name")]
public string HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"Heating capacity modifier curve (function of air flow fraction) should be quadratic or cubic. Quadratic curve = a + b(ff) + c(ff)^2. Cubic curve = a + b(ff) + c(ff)^2 + d(ff)^3. ff = fraction of the rated evaporator air flow rate. Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in air flow rate fraction.")]
[JsonProperty("heating_capacity_function_of_air_flow_fraction_curve_name")]
public string HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description(@"Heating capacity modifier curve (function of water flow fraction) should be quadratic or cubic. Quadratic curve = a + b(ff) + c(ff)^2. Cubic curve = a + b(ff) + c(ff)^2 + d(ff)^3. ff = fraction of the rated condenser water flow rate. Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in water flow rate fraction.")]
[JsonProperty("heating_capacity_function_of_water_flow_fraction_curve_name")]
public string HeatingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description(@"Heating COP modifier curve (function of temperature) should be biquadratic or cubic. Biquadratic curve = a + b(ta) + c(ta)^2 + d(tw) + e(tw)^2 + f(ta)(tw). Cubic curve = a + b(ta) + c(ta)^2 + d(ta)^3. ta = evaporator inlet air [dry-bulb or wet-bulb] temperature (C). tw = condenser inlet water temperature (C). The field Evaporator Air Temperature Type for Curve Objects determines if dry-bulb or wet-bulb is used as the evaporator inlet air temperature (ta).")]
[JsonProperty("heating_cop_function_of_temperature_curve_name")]
public string HeatingCopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"Heating COP modifier curve (function of air flow fraction) should be quadratic or cubic. Quadratic curve = a + b(ff) + c(ff)^2. Cubic curve = a + b(ff) + c(ff)^2 + d(ff)^3. ff = fraction of the rated evaporator air flow rate. Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in air flow rate fraction.")]
[JsonProperty("heating_cop_function_of_air_flow_fraction_curve_name")]
public string HeatingCopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description(@"Heating COP modifier curve (function of water flow fraction) should be quadratic or cubic. Quadratic curve = a + b(ff) + c(ff)^2. Cubic curve = a + b(ff) + c(ff)^2 + d(ff)^3. ff = fraction of the rated condenser water flow rate. Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in water flow rate fraction.")]
[JsonProperty("heating_cop_function_of_water_flow_fraction_curve_name")]
public string HeatingCopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description(@"Part Load Fraction Correlation (function of part load ratio) should be quadratic or cubic. Quadratic curve = a + b(PLR) + c(PLR)^2. Cubic curve = a + b(PLR) + c(PLR)^2 + d(PLR)^3. PLR = part load ratio (heating delivered/steady state heating capacity). Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in part load ratio.")]
[JsonProperty("part_load_fraction_correlation_curve_name")]
public string PartLoadFractionCorrelationCurveName { get; set; } = "";
    }
    
    public enum Coil_WaterHeating_AirToWaterHeatPump_Pumped_EvaporatorAirTemperatureTypeForCurveObjects
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DryBulbTemperature")]
        DryBulbTemperature = 1,
        
        [JsonProperty("WetBulbTemperature")]
        WetBulbTemperature = 2,
    }
    
    [Description("Heat pump water heater (HPWH) heating coil, air-to-water direct-expansion (DX) sy" +
        "stem which includes a water heating coil, evaporator air coil, evaporator fan, e" +
        "lectric compressor, and water pump. Part of a WaterHeater:HeatPump:WrappedConden" +
        "ser system.")]
    [JsonObject("Coil:WaterHeating:AirToWaterHeatPump:Wrapped")]
    public class Coil_WaterHeating_AirToWaterHeatPump_Wrapped : BHoMObject, IEnergyPlusClass
    {
        

[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
    " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
    "lude condenser pump heat.")]
[JsonProperty("rated_heating_capacity")]
public System.Nullable<float> RatedHeatingCapacity { get; set; } = null;
        

[Description("Heating coefficient of performance at the rated inlet air temperatures, rated con" +
    "denser inlet water temperature, rated air flow rate, and rated water flow rate. " +
    "Can optionally include condenser pump power and evaporator fan power (see fields" +
    " below).")]
[JsonProperty("rated_cop")]
public System.Nullable<float> RatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

[Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
[JsonProperty("rated_sensible_heat_ratio")]
public System.Nullable<float> RatedSensibleHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[Description("Evaporator inlet air dry-bulb temperature corresponding to rated coil performance" +
    " (heating capacity, COP and SHR).")]
[JsonProperty("rated_evaporator_inlet_air_dry_bulb_temperature")]
public System.Nullable<float> RatedEvaporatorInletAirDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("19.7", CultureInfo.InvariantCulture);
        

[Description("Evaporator inlet air wet-bulb temperature corresponding to rated coil performance" +
    " (heating capacity, COP and SHR).")]
[JsonProperty("rated_evaporator_inlet_air_wet_bulb_temperature")]
public System.Nullable<float> RatedEvaporatorInletAirWetBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13.5", CultureInfo.InvariantCulture);
        

[Description("Condenser inlet water temperature corresponding to rated coil performance (heatin" +
    "g capacity, COP and SHR).")]
[JsonProperty("rated_condenser_water_temperature")]
public System.Nullable<float> RatedCondenserWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("57.5", CultureInfo.InvariantCulture);
        

[Description("Evaporator air flow rate corresponding to rated coil performance (heating capacit" +
    "y, COP and SHR). Default is 5.035E-5 m3/s/W (31.25 cfm/MBH) of rated heating cap" +
    "acity when autocalculated.")]
[JsonProperty("rated_evaporator_air_flow_rate")]
public string RatedEvaporatorAirFlowRate { get; set; } = "";
        

[Description("Select Yes if the evaporator fan power is included in the rated COP. This choice " +
    "field impacts the calculation of compressor electric power.")]
[JsonProperty("evaporator_fan_power_included_in_rated_cop")]
public EmptyNoYes EvaporatorFanPowerIncludedInRatedCop { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("The node from which the DX coil draws its inlet air.")]
[JsonProperty("evaporator_air_inlet_node_name")]
public string EvaporatorAirInletNodeName { get; set; } = "";
        

[Description("The node to which the DX coil sends its outlet air.")]
[JsonProperty("evaporator_air_outlet_node_name")]
public string EvaporatorAirOutletNodeName { get; set; } = "";
        

[Description(@"The compressor crankcase heater only operates when the dry-bulb temperature of air surrounding the compressor is below the Maximum Ambient Temperature for Crankcase Heater Operation and the DX coil is off. The ambient temperature surrounding the compressor is set by the WaterHeater:HeatPump:WrappedCondenser parent object (field Compressor Location).")]
[JsonProperty("crankcase_heater_capacity")]
public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"The compressor crankcase heater only operates when the dry-bulb temperature of air surrounding the compressor is below the Maximum Outdoor Temperature for Crankcase Heater Operation and the unit is off. The ambient temperature surrounding the compressor is set by the WaterHeater:HeatPump:WrappedCondenser parent object (field Compressor Location).")]
[JsonProperty("maximum_ambient_temperature_for_crankcase_heater_operation")]
public System.Nullable<float> MaximumAmbientTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("Determines temperature type for heating capacity curves and heating COP curves. T" +
    "his input determines whether the inlet air dry-bulb or wet-bulb temperature is u" +
    "sed to evaluate these curves.")]
[JsonProperty("evaporator_air_temperature_type_for_curve_objects")]
public Coil_WaterHeating_AirToWaterHeatPump_Wrapped_EvaporatorAirTemperatureTypeForCurveObjects EvaporatorAirTemperatureTypeForCurveObjects { get; set; } = (Coil_WaterHeating_AirToWaterHeatPump_Wrapped_EvaporatorAirTemperatureTypeForCurveObjects)Enum.Parse(typeof(Coil_WaterHeating_AirToWaterHeatPump_Wrapped_EvaporatorAirTemperatureTypeForCurveObjects), "WetBulbTemperature");
        

[Description(@"Heating capacity modifier curve (function of temperature) should be biquadratic or cubic. Biquadratic curve = a + b(ta) + c(ta)^2 + d(tw) + e(tw)^2 + f(ta)(tw). Cubic curve = a + b(ta) + c(ta)^2 + d(ta)^3. ta = evaporator inlet air [dry-bulb or wet-bulb] temperature (C). tw = condenser inlet water temperature (C). The field Evaporator Air Temperature Type for Curve Objects determines if dry-bulb or wet-bulb is used as the evaporator inlet air temperature (ta).")]
[JsonProperty("heating_capacity_function_of_temperature_curve_name")]
public string HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"Heating capacity modifier curve (function of air flow fraction) should be quadratic or cubic. Quadratic curve = a + b(ff) + c(ff)^2. Cubic curve = a + b(ff) + c(ff)^2 + d(ff)^3. ff = fraction of the rated evaporator air flow rate. Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in air flow rate fraction.")]
[JsonProperty("heating_capacity_function_of_air_flow_fraction_curve_name")]
public string HeatingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description(@"Heating COP modifier curve (function of temperature) should be biquadratic or cubic. Biquadratic curve = a + b(ta) + c(ta)^2 + d(tw) + e(tw)^2 + f(ta)(tw). Cubic curve = a + b(ta) + c(ta)^2 + d(ta)^3. ta = evaporator inlet air [dry-bulb or wet-bulb] temperature (C). tw = condenser inlet water temperature (C). The field Evaporator Air Temperature Type for Curve Objects determines if dry-bulb or wet-bulb is used as the evaporator inlet air temperature (ta).")]
[JsonProperty("heating_cop_function_of_temperature_curve_name")]
public string HeatingCopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"Heating COP modifier curve (function of air flow fraction) should be quadratic or cubic. Quadratic curve = a + b(ff) + c(ff)^2. Cubic curve = a + b(ff) + c(ff)^2 + d(ff)^3. ff = fraction of the rated evaporator air flow rate. Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in air flow rate fraction.")]
[JsonProperty("heating_cop_function_of_air_flow_fraction_curve_name")]
public string HeatingCopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description(@"Part Load Fraction Correlation (function of part load ratio) should be quadratic or cubic. Quadratic curve = a + b(PLR) + c(PLR)^2. Cubic curve = a + b(PLR) + c(PLR)^2 + d(PLR)^3. PLR = part load ratio (heating delivered/steady state heating capacity). Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in part load ratio.")]
[JsonProperty("part_load_fraction_correlation_curve_name")]
public string PartLoadFractionCorrelationCurveName { get; set; } = "";
    }
    
    public enum Coil_WaterHeating_AirToWaterHeatPump_Wrapped_EvaporatorAirTemperatureTypeForCurveObjects
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DryBulbTemperature")]
        DryBulbTemperature = 1,
        
        [JsonProperty("WetBulbTemperature")]
        WetBulbTemperature = 2,
    }
    
    [Description(@"vairlable-speed Heat pump water heater (VSHPWH) heating coil, air-to-water direct-expansion (DX) system which includes a variable-speed water heating coil, evaporator air coil, evaporator fan, electric compressor, and water pump. Part of a WaterHeater:HeatPump system.")]
    [JsonObject("Coil:WaterHeating:AirToWaterHeatPump:VariableSpeed")]
    public class Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("number_of_speeds")]
public System.Nullable<float> NumberOfSpeeds { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("must be lower than or equal to the highest speed number")]
[JsonProperty("nominal_speed_level")]
public System.Nullable<float> NominalSpeedLevel { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Water Heating capacity at the rated inlet air temperatures, rated condenser inlet" +
    " water temperature, rated air flow rate, and rated water flow rate. Can optional" +
    "ly include condenser pump heat.")]
[JsonProperty("rated_water_heating_capacity")]
public System.Nullable<float> RatedWaterHeatingCapacity { get; set; } = null;
        

[Description("Evaporator inlet air dry-bulb temperature corresponding to rated coil performance" +
    " (heating capacity, COP and SHR).")]
[JsonProperty("rated_evaporator_inlet_air_dry_bulb_temperature")]
public System.Nullable<float> RatedEvaporatorInletAirDryBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("19.7", CultureInfo.InvariantCulture);
        

[Description("Evaporator inlet air wet-bulb temperature corresponding to rated coil performance" +
    " (heating capacity, COP and SHR).")]
[JsonProperty("rated_evaporator_inlet_air_wet_bulb_temperature")]
public System.Nullable<float> RatedEvaporatorInletAirWetBulbTemperature { get; set; } = (System.Nullable<float>)Single.Parse("13.5", CultureInfo.InvariantCulture);
        

[Description("Condenser inlet water temperature corresponding to rated coil performance (heatin" +
    "g capacity, COP and SHR).")]
[JsonProperty("rated_condenser_inlet_water_temperature")]
public System.Nullable<float> RatedCondenserInletWaterTemperature { get; set; } = (System.Nullable<float>)Single.Parse("57.5", CultureInfo.InvariantCulture);
        

[Description("Evaporator air flow rate corresponding to rated coil performance (heating capacit" +
    "y, COP and SHR). Default is 5.035E-5 m3/s/W (31.25 cfm/MBH) of rated heating cap" +
    "acity when autocalculated.")]
[JsonProperty("rated_evaporator_air_flow_rate")]
public string RatedEvaporatorAirFlowRate { get; set; } = "";
        

[Description(@"Condenser water flow rate corresponding to rated coil performance (heating capacity, COP and SHR). Default is 4.487E-8 m3/s/W (0.208 gpm/MBH) of rated heating capacity when autocalculated. A warning message will be issued if the ratio of Rated Condenser Water Flow Rate to Heating Capacity is less than 1.79405E-8 m3/s/W (0.083 gpm/MBH) or greater than 8.97024E-8 m3/s/W (0.417 gpm/MBH), but the simulation will continue.")]
[JsonProperty("rated_condenser_water_flow_rate")]
public string RatedCondenserWaterFlowRate { get; set; } = "";
        

[Description("Select Yes if the evaporator fan power is included in the rated COP. This choice " +
    "field impacts the calculation of compressor electric power.")]
[JsonProperty("evaporator_fan_power_included_in_rated_cop")]
public EmptyNoYes EvaporatorFanPowerIncludedInRatedCop { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("Select Yes if the condenser pump power is included in the rated COP. This choice " +
    "field impacts the calculation of compressor electric power.")]
[JsonProperty("condenser_pump_power_included_in_rated_cop")]
public EmptyNoYes CondenserPumpPowerIncludedInRatedCop { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Select Yes if the condenser pump heat is included in the rated heating capacity a" +
    "nd rated COP. This choice field impacts the calculation of water heating capacit" +
    "y.")]
[JsonProperty("condenser_pump_heat_included_in_rated_heating_capacity_and_rated_cop")]
public EmptyNoYes CondenserPumpHeatIncludedInRatedHeatingCapacityAndRatedCop { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Fraction of pump heat transferred to the condenser water. The pump is assumed to " +
    "be located downstream of the condenser.")]
[JsonProperty("fraction_of_condenser_pump_heat_to_water")]
public System.Nullable<float> FractionOfCondenserPumpHeatToWater { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("The node from which the DX coil draws its inlet air.")]
[JsonProperty("evaporator_air_inlet_node_name")]
public string EvaporatorAirInletNodeName { get; set; } = "";
        

[Description("The node to which the DX coil sends its outlet air.")]
[JsonProperty("evaporator_air_outlet_node_name")]
public string EvaporatorAirOutletNodeName { get; set; } = "";
        

[Description("The node from which the DX coil condenser draws its inlet water. This name should" +
    " match the source side outlet node name in the associated water heater tank obje" +
    "ct.")]
[JsonProperty("condenser_water_inlet_node_name")]
public string CondenserWaterInletNodeName { get; set; } = "";
        

[Description("The node to which the DX coil condenser sends its outlet water. This name should " +
    "match the source side inlet node name in the associated water heater tank object" +
    ".")]
[JsonProperty("condenser_water_outlet_node_name")]
public string CondenserWaterOutletNodeName { get; set; } = "";
        

[Description(@"The compressor crankcase heater only operates when the dry-bulb temperature of air surrounding the compressor is below the Maximum Ambient Temperature for Crankcase Heater Operation and the DX coil is off. The ambient temperature surrounding the compressor is set by the WaterHeater:HeatPump parent object (field Compressor Location).")]
[JsonProperty("crankcase_heater_capacity")]
public System.Nullable<float> CrankcaseHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"The compressor crankcase heater only operates when the dry-bulb temperature of air surrounding the compressor is below the Maximum Outdoor Temperature for Crankcase Heater Operation and the unit is off. The ambient temperature surrounding the compressor is set by the WaterHeater:HeatPump parent object (field Compressor Location).")]
[JsonProperty("maximum_ambient_temperature_for_crankcase_heater_operation")]
public System.Nullable<float> MaximumAmbientTemperatureForCrankcaseHeaterOperation { get; set; } = (System.Nullable<float>)Single.Parse("10", CultureInfo.InvariantCulture);
        

[Description("Determines temperature type for heating capacity curves and heating COP curves. T" +
    "his input determines whether the inlet air dry-bulb or wet-bulb temperature is u" +
    "sed to evaluate these curves.")]
[JsonProperty("evaporator_air_temperature_type_for_curve_objects")]
public Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed_EvaporatorAirTemperatureTypeForCurveObjects EvaporatorAirTemperatureTypeForCurveObjects { get; set; } = (Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed_EvaporatorAirTemperatureTypeForCurveObjects)Enum.Parse(typeof(Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed_EvaporatorAirTemperatureTypeForCurveObjects), "WetBulbTemperature");
        

[Description(@"Table:Lookup object can also be used Part Load Fraction Correlation (function of part load ratio) should be quadratic or cubic. Quadratic curve = a + b(PLR) + c(PLR)^2. Cubic curve = a + b(PLR) + c(PLR)^2 + d(PLR)^3. PLR = part load ratio (heating delivered/steady state heating capacity). Use curve coefficients of 1,0,0 or leave this field blank when neglecting performance impacts due to variations in part load ratio.")]
[JsonProperty("part_load_fraction_correlation_curve_name")]
public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
    " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
    "lude condenser pump heat.")]
[JsonProperty("rated_water_heating_capacity_at_speed_1")]
public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed1 { get; set; } = null;
        

[Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
[JsonProperty("rated_water_heating_cop_at_speed_1")]
public System.Nullable<float> RatedWaterHeatingCopAtSpeed1 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

[Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
[JsonProperty("rated_sensible_heat_ratio_at_speed_1")]
public System.Nullable<float> RatedSensibleHeatRatioAtSpeed1 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[JsonProperty("speed_1_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed1ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed1ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[JsonProperty("speed_1_reference_unit_water_pump_input_power_at_rated_conditions")]
public System.Nullable<float> Speed1ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_1_total_wh_capacity_function_of_temperature_curve_name")]
public string Speed1TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_1_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed1TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_1_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed1TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_1_cop_function_of_temperature_curve_name")]
public string Speed1CopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_1_cop_function_of_air_flow_fraction_curve_name")]
public string Speed1CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_1_cop_function_of_water_flow_fraction_curve_name")]
public string Speed1CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
    " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
    "lude condenser pump heat.")]
[JsonProperty("rated_water_heating_capacity_at_speed_2")]
public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed2 { get; set; } = null;
        

[Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
[JsonProperty("rated_water_heating_cop_at_speed_2")]
public System.Nullable<float> RatedWaterHeatingCopAtSpeed2 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

[Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
[JsonProperty("rated_sensible_heat_ratio_at_speed_2")]
public System.Nullable<float> RatedSensibleHeatRatioAtSpeed2 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[JsonProperty("speed_2_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed2ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed2ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[JsonProperty("speed_2_reference_unit_water_pump_input_power_at_rated_conditions")]
public System.Nullable<float> Speed2ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_2_total_wh_capacity_function_of_temperature_curve_name")]
public string Speed2TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_2_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed2TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_2_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed2TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_2_cop_function_of_temperature_curve_name")]
public string Speed2CopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_2_cop_function_of_air_flow_fraction_curve_name")]
public string Speed2CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_2_cop_function_of_water_flow_fraction_curve_name")]
public string Speed2CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
    " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
    "lude condenser pump heat.")]
[JsonProperty("rated_water_heating_capacity_at_speed_3")]
public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed3 { get; set; } = null;
        

[Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
[JsonProperty("rated_water_heating_cop_at_speed_3")]
public System.Nullable<float> RatedWaterHeatingCopAtSpeed3 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

[Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
[JsonProperty("rated_sensible_heat_ratio_at_speed_3")]
public System.Nullable<float> RatedSensibleHeatRatioAtSpeed3 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[JsonProperty("speed_3_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed3ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed3ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[JsonProperty("speed_3_reference_unit_water_pump_input_power_at_rated_conditions")]
public System.Nullable<float> Speed3ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_3_total_wh_capacity_function_of_temperature_curve_name")]
public string Speed3TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_3_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed3TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_3_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed3TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_3_cop_function_of_temperature_curve_name")]
public string Speed3CopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_3_cop_function_of_air_flow_fraction_curve_name")]
public string Speed3CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_3_cop_function_of_water_flow_fraction_curve_name")]
public string Speed3CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
    " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
    "lude condenser pump heat.")]
[JsonProperty("rated_water_heating_capacity_at_speed_4")]
public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed4 { get; set; } = null;
        

[Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
[JsonProperty("rated_water_heating_cop_at_speed_4")]
public System.Nullable<float> RatedWaterHeatingCopAtSpeed4 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

[Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
[JsonProperty("rated_sensible_heat_ratio_at_speed_4")]
public System.Nullable<float> RatedSensibleHeatRatioAtSpeed4 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[JsonProperty("speed_4_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed4ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed4ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[JsonProperty("speed_4_reference_unit_water_pump_input_power_at_rated_conditions")]
public System.Nullable<float> Speed4ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_4_total_wh_capacity_function_of_temperature_curve_name")]
public string Speed4TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_4_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed4TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_4_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed4TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_4_cop_function_of_temperature_curve_name")]
public string Speed4CopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_4_cop_function_of_air_flow_fraction_curve_name")]
public string Speed4CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_4_cop_function_of_water_flow_fraction_curve_name")]
public string Speed4CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
    " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
    "lude condenser pump heat.")]
[JsonProperty("rated_water_heating_capacity_at_speed_5")]
public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed5 { get; set; } = null;
        

[Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
[JsonProperty("rated_water_heating_cop_at_speed_5")]
public System.Nullable<float> RatedWaterHeatingCopAtSpeed5 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

[Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
[JsonProperty("rated_sensible_heat_ratio_at_speed_5")]
public System.Nullable<float> RatedSensibleHeatRatioAtSpeed5 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[JsonProperty("speed_5_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed5ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed5ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[JsonProperty("speed_5_reference_unit_water_pump_input_power_at_rated_conditions")]
public System.Nullable<float> Speed5ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_5_total_wh_capacity_function_of_temperature_curve_name")]
public string Speed5TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_5_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed5TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_5_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed5TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_5_cop_function_of_temperature_curve_name")]
public string Speed5CopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_5_cop_function_of_air_flow_fraction_curve_name")]
public string Speed5CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_5_cop_function_of_water_flow_fraction_curve_name")]
public string Speed5CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
    " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
    "lude condenser pump heat.")]
[JsonProperty("rated_water_heating_capacity_at_speed_6")]
public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed6 { get; set; } = null;
        

[Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
[JsonProperty("rated_water_heating_cop_at_speed_6")]
public System.Nullable<float> RatedWaterHeatingCopAtSpeed6 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

[Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
[JsonProperty("rated_sensible_heat_ratio_at_speed_6")]
public System.Nullable<float> RatedSensibleHeatRatioAtSpeed6 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[JsonProperty("speed_6_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed6ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed6ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[JsonProperty("speed_6_reference_unit_water_pump_input_power_at_rated_conditions")]
public System.Nullable<float> Speed6ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_6_total_wh_capacity_function_of_temperature_curve_name")]
public string Speed6TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_6_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed6TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_6_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed6TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_6_cop_function_of_temperature_curve_name")]
public string Speed6CopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_6_cop_function_of_air_flow_fraction_curve_name")]
public string Speed6CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_6_cop_function_of_water_flow_fraction_curve_name")]
public string Speed6CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
    " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
    "lude condenser pump heat.")]
[JsonProperty("rated_water_heating_capacity_at_speed_7")]
public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed7 { get; set; } = null;
        

[Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
[JsonProperty("rated_water_heating_cop_at_speed_7")]
public System.Nullable<float> RatedWaterHeatingCopAtSpeed7 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

[Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
[JsonProperty("rated_sensible_heat_ratio_at_speed_7")]
public System.Nullable<float> RatedSensibleHeatRatioAtSpeed7 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[JsonProperty("speed_7_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed7ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed7ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[JsonProperty("speed_7_reference_unit_water_pump_input_power_at_rated_conditions")]
public System.Nullable<float> Speed7ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_7_total_wh_capacity_function_of_temperature_curve_name")]
public string Speed7TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_7_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed7TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_7_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed7TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_7_cop_function_of_temperature_curve_name")]
public string Speed7CopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_7_cop_function_of_air_flow_fraction_curve_name")]
public string Speed7CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_7_cop_function_of_water_flow_fraction_curve_name")]
public string Speed7CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
    " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
    "lude condenser pump heat.")]
[JsonProperty("rated_water_heating_capacity_at_speed_8")]
public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed8 { get; set; } = null;
        

[Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
[JsonProperty("rated_water_heating_cop_at_speed_8")]
public System.Nullable<float> RatedWaterHeatingCopAtSpeed8 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

[Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
[JsonProperty("rated_sensible_heat_ratio_at_speed_8")]
public System.Nullable<float> RatedSensibleHeatRatioAtSpeed8 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[JsonProperty("speed_8_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed8ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed8ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[JsonProperty("speed_8_reference_unit_water_pump_input_power_at_rated_conditions")]
public System.Nullable<float> Speed8ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_8_total_wh_capacity_function_of_temperature_curve_name")]
public string Speed8TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_8_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed8TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_8_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed8TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_8_cop_function_of_temperature_curve_name")]
public string Speed8CopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_8_cop_function_of_air_flow_fraction_curve_name")]
public string Speed8CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_8_cop_function_of_water_flow_fraction_curve_name")]
public string Speed8CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
    " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
    "lude condenser pump heat.")]
[JsonProperty("rated_water_heating_capacity_at_speed_9")]
public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed9 { get; set; } = null;
        

[Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
[JsonProperty("rated_water_heating_cop_at_speed_9")]
public System.Nullable<float> RatedWaterHeatingCopAtSpeed9 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

[Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
[JsonProperty("rated_sensible_heat_ratio_at_speed_9")]
public System.Nullable<float> RatedSensibleHeatRatioAtSpeed9 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[JsonProperty("speed_9_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed9ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed9ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[JsonProperty("speed_9_reference_unit_water_pump_input_power_at_rated_conditions")]
public System.Nullable<float> Speed9ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_9_total_wh_capacity_function_of_temperature_curve_name")]
public string Speed9TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_9_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed9TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_9_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed9TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_9_cop_function_of_temperature_curve_name")]
public string Speed9CopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_9_cop_function_of_air_flow_fraction_curve_name")]
public string Speed9CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_9_cop_function_of_water_flow_fraction_curve_name")]
public string Speed9CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Heating capacity at the rated inlet air temperatures, rated condenser inlet water" +
    " temperature, rated air flow rate, and rated water flow rate. Can optionally inc" +
    "lude condenser pump heat.")]
[JsonProperty("rated_water_heating_capacity_at_speed_10")]
public System.Nullable<float> RatedWaterHeatingCapacityAtSpeed10 { get; set; } = null;
        

[Description(@"Heating coefficient of performance at the rated inlet air and water temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Can optionally include condenser pump power and evaporator fan power (see fields below).")]
[JsonProperty("rated_water_heating_cop_at_speed_10")]
public System.Nullable<float> RatedWaterHeatingCopAtSpeed10 { get; set; } = (System.Nullable<float>)Single.Parse("3.2", CultureInfo.InvariantCulture);
        

[Description(@"Gross air-side sensible heat ratio at the rated inlet air temperatures, rated condenser inlet water temperature, rated air flow rate, and rated water flow rate. Sensible heat ratio equals gross sensible cooling capacity divided by gross total cooling capacity. Rated SHR (gross) should not include evaporator fan heat, only sensible cooling and dehumidification by the coil alone.")]
[JsonProperty("rated_sensible_heat_ratio_at_speed_10")]
public System.Nullable<float> RatedSensibleHeatRatioAtSpeed10 { get; set; } = (System.Nullable<float>)Single.Parse("0.85", CultureInfo.InvariantCulture);
        

[JsonProperty("speed_10_reference_unit_rated_air_flow_rate")]
public System.Nullable<float> Speed10ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_rated_water_flow_rate")]
public System.Nullable<float> Speed10ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

[JsonProperty("speed_10_reference_unit_water_pump_input_power_at_rated_conditions")]
public System.Nullable<float> Speed10ReferenceUnitWaterPumpInputPowerAtRatedConditions { get; set; } = null;
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_10_total_wh_capacity_function_of_temperature_curve_name")]
public string Speed10TotalWhCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_10_total_wh_capacity_function_of_air_flow_fraction_curve_name")]
public string Speed10TotalWhCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_10_total_wh_capacity_function_of_water_flow_fraction_curve_name")]
public string Speed10TotalWhCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**" +
    "2 + f*wb*ewt wb = entering wet-bulb temperature or dry bulb temperature upon sel" +
    "ection (C) ewt = water entering temperature seen by the condenser (C)")]
[JsonProperty("speed_10_cop_function_of_temperature_curve_name")]
public string Speed10CopFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffa + c*ffa**2 cubic" +
    " curve = a + b*ffa + c*ffa**2 + d*ffa**3 ffa = Fraction of the full load Air Flo" +
    "w")]
[JsonProperty("speed_10_cop_function_of_air_flow_fraction_curve_name")]
public string Speed10CopFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

[Description("Table:Lookup object can also be used quadratic curve = a + b*ffw + c*ffw**2 cubic" +
    " curve = a + b*ffw + c*ffw**2 + d*ffw**3 ffw = Fraction of the full load Water F" +
    "low")]
[JsonProperty("speed_10_cop_function_of_water_flow_fraction_curve_name")]
public string Speed10CopFunctionOfWaterFlowFractionCurveName { get; set; } = "";
    }
    
    public enum Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed_EvaporatorAirTemperatureTypeForCurveObjects
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DryBulbTemperature")]
        DryBulbTemperature = 1,
        
        [JsonProperty("WetBulbTemperature")]
        WetBulbTemperature = 2,
    }
    
    [Description(@"Desuperheater air heating coil. The heating energy provided by this coil is reclaimed from the superheated refrigerant gas leaving a compressor and does not impact the performance of the compressor. This coil must be used with a water heater tank, see Water Heater:Mixed.")]
    [JsonObject("Coil:WaterHeating:Desuperheater")]
    public class Coil_WaterHeating_Desuperheater : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. Schedule values of 0 denote the desuperheater heating coil is off and the parasitic electric energy is also off.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description(@"Defines the cut-out temperature where the desuperheater water heating coil turns off. The desuperheater heating coil setpoint temperature should always be greater than the water tank's heater (element or burner) setpoint temperature. Temperature schedule values should be in degrees C.")]
[JsonProperty("setpoint_temperature_schedule_name")]
public string SetpointTemperatureScheduleName { get; set; } = "";
        

[Description(@"Setpoint temperature minus the dead band temperature difference defines the cut-in temperature where the desuperheater water heating coil turns on. The water tank's heater (element or burner) setpoint temperature should always be less than the desuperheater heating coil cut-in temperature.")]
[JsonProperty("dead_band_temperature_difference")]
public System.Nullable<float> DeadBandTemperatureDifference { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
        

[Description("Enter the fraction of waste heat reclaimed by the desuperheater water heating coi" +
    "l.")]
[JsonProperty("rated_heat_reclaim_recovery_efficiency")]
public System.Nullable<float> RatedHeatReclaimRecoveryEfficiency { get; set; } = null;
        

[Description("The inlet water temperature corresponding to the rated heat reclaim recovery effi" +
    "ciency.")]
[JsonProperty("rated_inlet_water_temperature")]
public System.Nullable<float> RatedInletWaterTemperature { get; set; } = null;
        

[Description("The outdoor air dry-bulb temperature corresponding to the rated heat reclaim reco" +
    "very efficiency.")]
[JsonProperty("rated_outdoor_air_temperature")]
public System.Nullable<float> RatedOutdoorAirTemperature { get; set; } = null;
        

[Description("The desuperheater water heating coil is off when the inlet water temperature is a" +
    "bove the maximum inlet water temperature for heat reclaim.")]
[JsonProperty("maximum_inlet_water_temperature_for_heat_reclaim")]
public System.Nullable<float> MaximumInletWaterTemperatureForHeatReclaim { get; set; } = null;
        

[Description(@"A biquadratic curve defining the performance of the desuperheater heating coil. Performance can be specified as a function of inlet water temperature, outdoor air dry-bulb temperature, or both. Curve = a + b*Tw + c*Tw**2 + d*odb + e*odb**2 + f*Tw*odb. Tw = desuperheater heating coil entering water temperature (C). Odb = outdoor dry-bulb temperature at DX system condenser (C).")]
[JsonProperty("heat_reclaim_efficiency_function_of_temperature_curve_name")]
public string HeatReclaimEfficiencyFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("The node from which the desuperheater heating coil draws its inlet water. This na" +
    "me should match the source side outlet node name in the associated water heater " +
    "tank object.")]
[JsonProperty("water_inlet_node_name")]
public string WaterInletNodeName { get; set; } = "";
        

[Description("The node to which the desuperheater heating coil sends its outlet water. This nam" +
    "e should match the source side inlet node name in the associated water heater ta" +
    "nk object.")]
[JsonProperty("water_outlet_node_name")]
public string WaterOutletNodeName { get; set; } = "";
        

[Description("Specify the type of water heater tank used by this desuperheater water heating co" +
    "il.")]
[JsonProperty("tank_object_type")]
public Coil_WaterHeating_Desuperheater_TankObjectType TankObjectType { get; set; } = (Coil_WaterHeating_Desuperheater_TankObjectType)Enum.Parse(typeof(Coil_WaterHeating_Desuperheater_TankObjectType), "Empty");
        

[Description("The name of the water heater tank used by this desuperheater water heating coil. " +
    "Needs to match the name used in the corresponding water heater object.")]
[JsonProperty("tank_name")]
public string TankName { get; set; } = "";
        

[Description("The type of DX system that is providing waste heat for reclaim.")]
[JsonProperty("heating_source_object_type")]
public Coil_WaterHeating_Desuperheater_HeatingSourceObjectType HeatingSourceObjectType { get; set; } = (Coil_WaterHeating_Desuperheater_HeatingSourceObjectType)Enum.Parse(typeof(Coil_WaterHeating_Desuperheater_HeatingSourceObjectType), "CoilCoolingDXMultiSpeed");
        

[Description("The name of the DX system used for heat reclaim.")]
[JsonProperty("heating_source_name")]
public string HeatingSourceName { get; set; } = "";
        

[Description("The operating water flow rate.")]
[JsonProperty("water_flow_rate")]
public System.Nullable<float> WaterFlowRate { get; set; } = null;
        

[Description("The water circulation pump electric power.")]
[JsonProperty("water_pump_power")]
public System.Nullable<float> WaterPumpPower { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The fraction of pump heat transferred to the water. The pump is assumed to be dow" +
    "nstream of the desuperheater water heating coil.")]
[JsonProperty("fraction_of_pump_heat_to_water")]
public System.Nullable<float> FractionOfPumpHeatToWater { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("Parasitic electric power consumed when the desuperheater water heating coil opera" +
    "tes. Parasitic electric load does not contribute to water heating or the zone ai" +
    "r heat balance.")]
[JsonProperty("on_cycle_parasitic_electric_load")]
public System.Nullable<float> OnCycleParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Parasitic electric load consumed when the desuperheater water heating coil is off" +
    ". Parasitic electric load does not contribute to water heating or the zone air h" +
    "eat balance. Off-cycle parasitic power is 0 when the availability schedule is 0." +
    "")]
[JsonProperty("off_cycle_parasitic_electric_load")]
public System.Nullable<float> OffCycleParasiticElectricLoad { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum Coil_WaterHeating_Desuperheater_TankObjectType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("WaterHeater:Mixed")]
        WaterHeaterMixed = 1,
        
        [JsonProperty("WaterHeater:Stratified")]
        WaterHeaterStratified = 2,
    }
    
    public enum Coil_WaterHeating_Desuperheater_HeatingSourceObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:MultiSpeed")]
        CoilCoolingDXMultiSpeed = 0,
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 1,
        
        [JsonProperty("Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 2,
        
        [JsonProperty("Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 3,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 4,
        
        [JsonProperty("Coil:Cooling:WaterToAirHeatPump:EquationFit")]
        CoilCoolingWaterToAirHeatPumpEquationFit = 5,
        
        [JsonProperty("Refrigeration:CompressorRack")]
        RefrigerationCompressorRack = 6,
        
        [JsonProperty("Refrigeration:Condenser:AirCooled")]
        RefrigerationCondenserAirCooled = 7,
        
        [JsonProperty("Refrigeration:Condenser:EvaporativeCooled")]
        RefrigerationCondenserEvaporativeCooled = 8,
        
        [JsonProperty("Refrigeration:Condenser:WaterCooled")]
        RefrigerationCondenserWaterCooled = 9,
    }
    
    [Description("Virtual container component that consists of a DX cooling coil and its associated" +
        " controls. This control object supports several different types of DX cooling co" +
        "ils and may be placed directly in an air loop branch or outdoor air equipment li" +
        "st.")]
    [JsonObject("CoilSystem:Cooling:DX")]
    public class CoilSystem_Cooling_DX : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("dx_cooling_coil_system_inlet_node_name")]
public string DxCoolingCoilSystemInletNodeName { get; set; } = "";
        

[JsonProperty("dx_cooling_coil_system_outlet_node_name")]
public string DxCoolingCoilSystemOutletNodeName { get; set; } = "";
        

[JsonProperty("dx_cooling_coil_system_sensor_node_name")]
public string DxCoolingCoilSystemSensorNodeName { get; set; } = "";
        

[JsonProperty("cooling_coil_object_type")]
public CoilSystem_Cooling_DX_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (CoilSystem_Cooling_DX_CoolingCoilObjectType)Enum.Parse(typeof(CoilSystem_Cooling_DX_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

[JsonProperty("cooling_coil_name")]
public string CoolingCoilName { get; set; } = "";
        

[Description(@"None = meet sensible load only Multimode = activate enhanced dehumidification mode as needed and meet sensible load. If no sensible load exists, and Run on Latent Load = Yes, and a latent load exists, the unit will operate to meet the latent load. Valid only with Coil:Cooling:DX:TwoStageWithHumidityControlMode or CoilSystem:Cooling:DX:HeatExchangerAssisted. CoolReheat = cool beyond the dry-bulb setpoint. as required to meet the humidity setpoint. Valid for all coil types. For all dehumidification controls, the max humidity setpoint on the Sensor Node is used. SetpointManager:SingleZone:Humidity:Maximum, SetpointManager:MultiZone:Humidity:Maximum, or SetpointManager:MultiZone:MaximumHumidity:Average, and SetpointManager:OutdoorAirPretreat (optional) objects.")]
[JsonProperty("dehumidification_control_type")]
public CoilSystem_Cooling_DX_DehumidificationControlType DehumidificationControlType { get; set; } = (CoilSystem_Cooling_DX_DehumidificationControlType)Enum.Parse(typeof(CoilSystem_Cooling_DX_DehumidificationControlType), "None");
        

[Description("If Yes, unit will run if there is a sensible load. If No, unit will not run if th" +
    "ere is only a sensible load. Dehumidification controls will be active if specifi" +
    "ed.")]
[JsonProperty("run_on_sensible_load")]
public EmptyNoYes RunOnSensibleLoad { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("If Yes, unit will run if there is a latent load. even if there is no sensible loa" +
    "d. If No, unit will not run only if there is a latent load. Dehumidification con" +
    "trols will be active if specified.")]
[JsonProperty("run_on_latent_load")]
public EmptyNoYes RunOnLatentLoad { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description(@"This input field is designed for use with DX cooling coils with low air flow to capacity ratio range (100 - 300 cfm/ton). Typical application is 100% dedicated outdoor air system (DOAS). Other air loop or zone HVAC systems with low flow to capacity ratio range may also use this input field. If Yes, the DX cooling coil runs as 100% DOAS DX coil or low flow to capacity ratio range. If No, the DX cooling coil runs as a regular DX coil. If left blank the default is regular DX coil.")]
[JsonProperty("use_outdoor_air_dx_cooling_coil")]
public EmptyNoYes UseOutdoorAirDxCoolingCoil { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("DX cooling coil leaving minimum air temperature defines the minimum DX cooling co" +
    "il leaving air temperature that should be maintained to avoid frost formation. T" +
    "his input field is optional and only used along with the input field above.")]
[JsonProperty("outdoor_air_dx_cooling_coil_leaving_minimum_air_temperature")]
public System.Nullable<float> OutdoorAirDxCoolingCoilLeavingMinimumAirTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
    
    public enum CoilSystem_Cooling_DX_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed:ThermalStorage")]
        CoilCoolingDXSingleSpeedThermalStorage = 1,
        
        [JsonProperty("Coil:Cooling:DX:TwoSpeed")]
        CoilCoolingDXTwoSpeed = 2,
        
        [JsonProperty("Coil:Cooling:DX:TwoStageWithHumidityControlMode")]
        CoilCoolingDXTwoStageWithHumidityControlMode = 3,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 4,
        
        [JsonProperty("CoilSystem:Cooling:DX:HeatExchangerAssisted")]
        CoilSystemCoolingDXHeatExchangerAssisted = 5,
    }
    
    public enum CoilSystem_Cooling_DX_DehumidificationControlType
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
    
    [Description("Virtual container component that consists of a DX heating coil (heat pump) and it" +
        "s associated controls. This control object supports two different types of DX he" +
        "ating coils and may be placed directly in an air loop branch or outdoor air equi" +
        "pment list.")]
    [JsonObject("CoilSystem:Heating:DX")]
    public class CoilSystem_Heating_DX : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("heating_coil_object_type")]
public CoilSystem_Heating_DX_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (CoilSystem_Heating_DX_HeatingCoilObjectType)Enum.Parse(typeof(CoilSystem_Heating_DX_HeatingCoilObjectType), "CoilHeatingDXSingleSpeed");
        

[JsonProperty("heating_coil_name")]
public string HeatingCoilName { get; set; } = "";
    }
    
    public enum CoilSystem_Heating_DX_HeatingCoilObjectType
    {
        
        [JsonProperty("Coil:Heating:DX:SingleSpeed")]
        CoilHeatingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Heating:DX:VariableSpeed")]
        CoilHeatingDXVariableSpeed = 1,
    }
    
    [Description(@"Virtual component consisting of a chilled-water cooling coil and an air-to-air heat exchanger. The air-to-air heat exchanger precools the air entering the cooling coil and reuses this energy to reheat the supply air leaving the cooling coil. This heat exchange process improves the latent removal performance of the cooling coil (lower sensible heat ratio).")]
    [JsonObject("CoilSystem:Cooling:Water:HeatExchangerAssisted")]
    public class CoilSystem_Cooling_Water_HeatExchangerAssisted : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("heat_exchanger_object_type")]
public CoilSystem_Cooling_Water_HeatExchangerAssisted_HeatExchangerObjectType HeatExchangerObjectType { get; set; } = (CoilSystem_Cooling_Water_HeatExchangerAssisted_HeatExchangerObjectType)Enum.Parse(typeof(CoilSystem_Cooling_Water_HeatExchangerAssisted_HeatExchangerObjectType), "HeatExchangerAirToAirFlatPlate");
        

[JsonProperty("heat_exchanger_name")]
public string HeatExchangerName { get; set; } = "";
        

[JsonProperty("cooling_coil_object_type")]
public CoilSystem_Cooling_Water_HeatExchangerAssisted_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (CoilSystem_Cooling_Water_HeatExchangerAssisted_CoolingCoilObjectType)Enum.Parse(typeof(CoilSystem_Cooling_Water_HeatExchangerAssisted_CoolingCoilObjectType), "CoilCoolingWater");
        

[JsonProperty("cooling_coil_name")]
public string CoolingCoilName { get; set; } = "";
    }
    
    public enum CoilSystem_Cooling_Water_HeatExchangerAssisted_HeatExchangerObjectType
    {
        
        [JsonProperty("HeatExchanger:AirToAir:FlatPlate")]
        HeatExchangerAirToAirFlatPlate = 0,
        
        [JsonProperty("HeatExchanger:AirToAir:SensibleAndLatent")]
        HeatExchangerAirToAirSensibleAndLatent = 1,
    }
    
    public enum CoilSystem_Cooling_Water_HeatExchangerAssisted_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:Water")]
        CoilCoolingWater = 0,
        
        [JsonProperty("Coil:Cooling:Water:DetailedGeometry")]
        CoilCoolingWaterDetailedGeometry = 1,
    }
    
    [Description(@"Virtual component consisting of a direct expansion (DX) cooling coil and an air-to-air heat exchanger. The air-to-air heat exchanger precools the air entering the cooling coil and reuses this energy to reheat the supply air leaving the cooling coil. This heat exchange process improves the latent removal performance of the cooling coil (lower sensible heat ratio).")]
    [JsonObject("CoilSystem:Cooling:DX:HeatExchangerAssisted")]
    public class CoilSystem_Cooling_DX_HeatExchangerAssisted : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("heat_exchanger_object_type")]
public CoilSystem_Cooling_DX_HeatExchangerAssisted_HeatExchangerObjectType HeatExchangerObjectType { get; set; } = (CoilSystem_Cooling_DX_HeatExchangerAssisted_HeatExchangerObjectType)Enum.Parse(typeof(CoilSystem_Cooling_DX_HeatExchangerAssisted_HeatExchangerObjectType), "HeatExchangerAirToAirFlatPlate");
        

[JsonProperty("heat_exchanger_name")]
public string HeatExchangerName { get; set; } = "";
        

[JsonProperty("cooling_coil_object_type")]
public CoilSystem_Cooling_DX_HeatExchangerAssisted_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (CoilSystem_Cooling_DX_HeatExchangerAssisted_CoolingCoilObjectType)Enum.Parse(typeof(CoilSystem_Cooling_DX_HeatExchangerAssisted_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

[JsonProperty("cooling_coil_name")]
public string CoolingCoilName { get; set; } = "";
    }
    
    public enum CoilSystem_Cooling_DX_HeatExchangerAssisted_HeatExchangerObjectType
    {
        
        [JsonProperty("HeatExchanger:AirToAir:FlatPlate")]
        HeatExchangerAirToAirFlatPlate = 0,
        
        [JsonProperty("HeatExchanger:AirToAir:SensibleAndLatent")]
        HeatExchangerAirToAirSensibleAndLatent = 1,
        
        [JsonProperty("HeatExchanger:Desiccant:BalancedFlow")]
        HeatExchangerDesiccantBalancedFlow = 2,
    }
    
    public enum CoilSystem_Cooling_DX_HeatExchangerAssisted_CoolingCoilObjectType
    {
        
        [JsonProperty("Coil:Cooling:DX:SingleSpeed")]
        CoilCoolingDXSingleSpeed = 0,
        
        [JsonProperty("Coil:Cooling:DX:VariableSpeed")]
        CoilCoolingDXVariableSpeed = 1,
    }
    
    [Description("This object is used for air-source integrated heat pump, a collection of its work" +
        "ing modes.")]
    [JsonObject("CoilSystem:IntegratedHeatPump:AirSource")]
    public class CoilSystem_IntegratedHeatPump_AirSource : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("supply_hot_water_flow_sensor_node_name")]
public string SupplyHotWaterFlowSensorNodeName { get; set; } = "";
        

[Description("Must match the name used in the corresponding Coil:Cooling:DX:VariableSpeed objec" +
    "t.")]
[JsonProperty("space_cooling_coil_name")]
public string SpaceCoolingCoilName { get; set; } = "";
        

[Description("Must match the name used in the corresponding Coil:Heating:DX:VariableSpeed objec" +
    "t.")]
[JsonProperty("space_heating_coil_name")]
public string SpaceHeatingCoilName { get; set; } = "";
        

[Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
    "p:VariableSpeed object.")]
[JsonProperty("dedicated_water_heating_coil_name")]
public string DedicatedWaterHeatingCoilName { get; set; } = "";
        

[Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
    "p:VariableSpeed object.")]
[JsonProperty("scwh_coil_name")]
public string ScwhCoilName { get; set; } = "";
        

[Description("Must match the name used in the corresponding Coil:Cooling:DX:VariableSpeed objec" +
    "t.")]
[JsonProperty("scdwh_cooling_coil_name")]
public string ScdwhCoolingCoilName { get; set; } = "";
        

[Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
    "p:VariableSpeed object.")]
[JsonProperty("scdwh_water_heating_coil_name")]
public string ScdwhWaterHeatingCoilName { get; set; } = "";
        

[Description("Must match the name used in the corresponding Coil:Heating:DX:VariableSpeed objec" +
    "t.")]
[JsonProperty("shdwh_heating_coil_name")]
public string ShdwhHeatingCoilName { get; set; } = "";
        

[Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
    "p:VariableSpeed object.")]
[JsonProperty("shdwh_water_heating_coil_name")]
public string ShdwhWaterHeatingCoilName { get; set; } = "";
        

[Description("Indoor Temperature above which Indoor Overcooling is Allowed during Cooling Opera" +
    "tion")]
[JsonProperty("indoor_temperature_limit_for_scwh_mode")]
public System.Nullable<float> IndoorTemperatureLimitForScwhMode { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

[Description("Ambient Temperature above which Indoor Overcooling is Allowed during Cooling Oper" +
    "ation")]
[JsonProperty("ambient_temperature_limit_for_scwh_mode")]
public System.Nullable<float> AmbientTemperatureLimitForScwhMode { get; set; } = (System.Nullable<float>)Single.Parse("27", CultureInfo.InvariantCulture);
        

[Description("Indoor Temperature above which Water Heating has the higher priority and Space He" +
    "ating Call Can be ignored.")]
[JsonProperty("indoor_temperature_above_which_wh_has_higher_priority")]
public System.Nullable<float> IndoorTemperatureAboveWhichWhHasHigherPriority { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

[Description("Ambient Temperature above which Water Heating has the higher priority and Space H" +
    "eating Call Can be ignored.")]
[JsonProperty("ambient_temperature_above_which_wh_has_higher_priority")]
public System.Nullable<float> AmbientTemperatureAboveWhichWhHasHigherPriority { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

[Description("0: match space cooling load in SCWH mode, 1: match water heating load in SCWH mod" +
    "e")]
[JsonProperty("flag_to_indicate_load_control_in_scwh_mode")]
public System.Nullable<float> FlagToIndicateLoadControlInScwhMode { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_speed_level_for_scwh_mode")]
public System.Nullable<float> MinimumSpeedLevelForScwhMode { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_water_flow_volume_before_switching_from_scdwh_to_scwh_mode")]
public System.Nullable<float> MaximumWaterFlowVolumeBeforeSwitchingFromScdwhToScwhMode { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_speed_level_for_scdwh_mode")]
public System.Nullable<float> MinimumSpeedLevelForScdwhMode { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_running_time_before_allowing_electric_resistance_heat_use_during_shdwh_mo" +
    "de")]
public System.Nullable<float> MaximumRunningTimeBeforeAllowingElectricResistanceHeatUseDuringShdwhMode { get; set; } = (System.Nullable<float>)Single.Parse("360", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_speed_level_for_shdwh_mode")]
public System.Nullable<float> MinimumSpeedLevelForShdwhMode { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    [Description("Direct expansion (DX) cooling coil and condensing unit (includes electric compres" +
        "sor and condenser fan), single-speed with packaged integrated thermal storage fo" +
        "r cooling.")]
    [JsonObject("Coil:Cooling:DX:SingleSpeed:ThermalStorage")]
    public class Coil_Cooling_DX_SingleSpeed_ThermalStorage : BHoMObject, IEnergyPlusClass
    {
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty("availability_schedule_name")]
public string AvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("operating_mode_control_method")]
public Coil_Cooling_DX_SingleSpeed_ThermalStorage_OperatingModeControlMethod OperatingModeControlMethod { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_OperatingModeControlMethod)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_OperatingModeControlMethod), "EMSControlled");
        

[Description("This field is used if the control method is set to ScheduledModes Schedule values" +
    " control operating mode: 0=off, 1=cooling only, 2= cooling and charge, 3= coolin" +
    "g and discharge, 4= charge only, and 5= discharge only")]
[JsonProperty("operation_mode_control_schedule_name")]
public string OperationModeControlScheduleName { get; set; } = "";
        

[JsonProperty("storage_type")]
public Coil_Cooling_DX_SingleSpeed_ThermalStorage_StorageType StorageType { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_StorageType)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_StorageType), "Ice");
        

[Description("This field is required when Storage Type is UserDefinedFluidType")]
[JsonProperty("user_defined_fluid_type")]
public string UserDefinedFluidType { get; set; } = "";
        

[Description("required field if Storage Type is Water or UserDefinedFluidType")]
[JsonProperty("fluid_storage_volume")]
public string FluidStorageVolume { get; set; } = "";
        

[Description("required field if Storage Type is Ice")]
[JsonProperty("ice_storage_capacity")]
public string IceStorageCapacity { get; set; } = "";
        

[Description("If one of the previous two fields is set to autocalculate, this determines the st" +
    "orage capacity as a function of Cooling Only Mode Rated Total Evaporator Cooling" +
    " Capacity")]
[JsonProperty("storage_capacity_sizing_factor")]
public System.Nullable<float> StorageCapacitySizingFactor { get; set; } = null;
        

[JsonProperty("storage_tank_ambient_temperature_node_name")]
public string StorageTankAmbientTemperatureNodeName { get; set; } = "";
        

[JsonProperty("storage_tank_to_ambient_u_value_times_area_heat_transfer_coefficient")]
public System.Nullable<float> StorageTankToAmbientUValueTimesAreaHeatTransferCoefficient { get; set; } = null;
        

[Description("required field if Storage Type is Water or UserDefinedFluidType")]
[JsonProperty("fluid_storage_tank_rating_temperature")]
public System.Nullable<float> FluidStorageTankRatingTemperature { get; set; } = null;
        

[Description("Flow rate corresponding to rated total cooling capacity, Rated SHR and Rated COP")]
[JsonProperty("rated_evaporator_air_flow_rate")]
public string RatedEvaporatorAirFlowRate { get; set; } = "";
        

[JsonProperty("evaporator_air_inlet_node_name")]
public string EvaporatorAirInletNodeName { get; set; } = "";
        

[JsonProperty("evaporator_air_outlet_node_name")]
public string EvaporatorAirOutletNodeName { get; set; } = "";
        

[JsonProperty("cooling_only_mode_available")]
public Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingOnlyModeAvailable CoolingOnlyModeAvailable { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingOnlyModeAvailable)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingOnlyModeAvailable), "No");
        

[Description(@"required field if Cooling Only Mode is available or if autocalculating sizes gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
[JsonProperty("cooling_only_mode_rated_total_evaporator_cooling_capacity")]
public string CoolingOnlyModeRatedTotalEvaporatorCoolingCapacity { get; set; } = "";
        

[Description("required field if Cooling Only Mode is available Rated sensible heat ratio (gross" +
    " sensible capacity/gross total capacity) sensible and total capacities do not in" +
    "clude supply fan heat")]
[JsonProperty("cooling_only_mode_rated_sensible_heat_ratio")]
public System.Nullable<float> CoolingOnlyModeRatedSensibleHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
    "does not include supply fan heat or supply fan electrical energy input required " +
    "field if Cooling Only Mode is available")]
[JsonProperty("cooling_only_mode_rated_cop")]
public System.Nullable<float> CoolingOnlyModeRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description(@"required field if Cooling Only Mode is available Any curve or table with two independent variables can be used biquadratic curve = a + b*ewb + c*ewb**2 + d*db + e*db**2 + f*ewb*db x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("cooling_only_mode_total_evaporator_cooling_capacity_function_of_temperature_curve" +
    "_name")]
public string CoolingOnlyModeTotalEvaporatorCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Cooling Only Mode is available Any curve or table with one inde" +
    "pendent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve = " +
    "a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air f" +
    "low rate")]
[JsonProperty("cooling_only_mode_total_evaporator_cooling_capacity_function_of_flow_fraction_cur" +
    "ve_name")]
public string CoolingOnlyModeTotalEvaporatorCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"required field if Cooling Only Mode is available Any curve or table with two independent variables can be used curve = a + b*ewb + c*ewb**2 + d*db + e*db**2 + f*ewb*db x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C)")]
[JsonProperty("cooling_only_mode_energy_input_ratio_function_of_temperature_curve_name")]
public string CoolingOnlyModeEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Cooling Only Mode is available Any curve or table with one inde" +
    "pendent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve = " +
    "a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air f" +
    "low")]
[JsonProperty("cooling_only_mode_energy_input_ratio_function_of_flow_fraction_curve_name")]
public string CoolingOnlyModeEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"required field if Cooling Only Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
[JsonProperty("cooling_only_mode_part_load_fraction_correlation_curve_name")]
public string CoolingOnlyModePartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description(@"required field if Cooling Only Mode is available Any curve or table with two independent variables can be used curve = a + b*ewb + c*ewb**2 + d*edb + e*edb**2 + f*ewb*edb x = ewb = evaporator entering wet-bulb temperature seen by the cooling coil (C) y = edb = evaporator entering dry-bulb temperature seen by the cooling coil (C)")]
[JsonProperty("cooling_only_mode_sensible_heat_ratio_function_of_temperature_curve_name")]
public string CoolingOnlyModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Cooling Only Mode is available Any curve or table with one inde" +
    "pendent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve = " +
    "a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air f" +
    "low")]
[JsonProperty("cooling_only_mode_sensible_heat_ratio_function_of_flow_fraction_curve_name")]
public string CoolingOnlyModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("cooling_and_charge_mode_available")]
public Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndChargeModeAvailable CoolingAndChargeModeAvailable { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndChargeModeAvailable)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndChargeModeAvailable), "No");
        

[Description(@"required field if Cooling And Charge Mode is available gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb thermal storage tank at Fluid Storage Tank Rating Temperature (water or fluid) or storage faction of 0.5 (ice)")]
[JsonProperty("cooling_and_charge_mode_rated_total_evaporator_cooling_capacity")]
public string CoolingAndChargeModeRatedTotalEvaporatorCoolingCapacity { get; set; } = "";
        

[Description("If previous field is autocalculate, this determines the evaporator capacity as a " +
    "multiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
[JsonProperty("cooling_and_charge_mode_capacity_sizing_factor")]
public System.Nullable<float> CoolingAndChargeModeCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description(@"required field if Cooling And Charge Mode is available net capacity including any internal devices rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb thermal storage tank at Fluid Storage Tank Rating Temperature (water or fluid) or storage faction of 0.5 (ice)")]
[JsonProperty("cooling_and_charge_mode_rated_storage_charging_capacity")]
public string CoolingAndChargeModeRatedStorageChargingCapacity { get; set; } = "";
        

[Description("If previous field is autocalculate, this determines the storage cooling capacity " +
    "as a multiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity" +
    "")]
[JsonProperty("cooling_and_charge_mode_storage_capacity_sizing_factor")]
public System.Nullable<float> CoolingAndChargeModeStorageCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("required field if Cooling And Charge Mode is available Rated sensible heat ratio " +
    "(gross sensible evaporator capacity/gross total evaporator capacity) sensible an" +
    "d total capacities do not include supply fan heat")]
[JsonProperty("cooling_and_charge_mode_rated_sensible_heat_ratio")]
public System.Nullable<float> CoolingAndChargeModeRatedSensibleHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("Gross evaporator cooling capacity divided by power input to the compressor (for c" +
    "ooling) and outdoor fan, does not include supply fan heat or supply fan electric" +
    "al energy input required field if Cooling And Charge Mode is available")]
[JsonProperty("cooling_and_charge_mode_cooling_rated_cop")]
public System.Nullable<float> CoolingAndChargeModeCoolingRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("net cooling capacity divided by power input to the compressor (for charging) and " +
    "outdoor fan, includes any internal devices required field if Cooling And Charge " +
    "Mode is available")]
[JsonProperty("cooling_and_charge_mode_charging_rated_cop")]
public System.Nullable<float> CoolingAndChargeModeChargingRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description(@"required field if Cooling And Charge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("cooling_and_charge_mode_total_evaporator_cooling_capacity_function_of_temperature" +
    "_curve_name")]
public string CoolingAndChargeModeTotalEvaporatorCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Cooling And Charge Mode is available Any curve or table with on" +
    "e independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic cu" +
    "rve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator" +
    " air flow")]
[JsonProperty("cooling_and_charge_mode_total_evaporator_cooling_capacity_function_of_flow_fracti" +
    "on_curve_name")]
public string CoolingAndChargeModeTotalEvaporatorCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Charge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("cooling_and_charge_mode_evaporator_energy_input_ratio_function_of_temperature_cur" +
    "ve_name")]
public string CoolingAndChargeModeEvaporatorEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Cooling And Charge Mode is available Any curve or table with on" +
    "e independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic cu" +
    "rve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator" +
    " air flow")]
[JsonProperty("cooling_and_charge_mode_evaporator_energy_input_ratio_function_of_flow_fraction_c" +
    "urve_name")]
public string CoolingAndChargeModeEvaporatorEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Charge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
[JsonProperty("cooling_and_charge_mode_evaporator_part_load_fraction_correlation_curve_name")]
public string CoolingAndChargeModeEvaporatorPartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Charge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("cooling_and_charge_mode_storage_charge_capacity_function_of_temperature_curve_nam" +
    "e")]
public string CoolingAndChargeModeStorageChargeCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Charge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
[JsonProperty("cooling_and_charge_mode_storage_charge_capacity_function_of_total_evaporator_plr_" +
    "curve_name")]
public string CoolingAndChargeModeStorageChargeCapacityFunctionOfTotalEvaporatorPlrCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Charge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("cooling_and_charge_mode_storage_energy_input_ratio_function_of_temperature_curve_" +
    "name")]
public string CoolingAndChargeModeStorageEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Cooling And Charge Mode is available Any curve or table with on" +
    "e independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic cu" +
    "rve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator" +
    " air flow")]
[JsonProperty("cooling_and_charge_mode_storage_energy_input_ratio_function_of_flow_fraction_curv" +
    "e_name")]
public string CoolingAndChargeModeStorageEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Charge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
[JsonProperty("cooling_and_charge_mode_storage_energy_part_load_fraction_correlation_curve_name")]
public string CoolingAndChargeModeStorageEnergyPartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Charge Mode is available Curves or tables with either two or three independent variables can be used. Curve:Biquadratic, Table:Lookup, Curve:Bicubic and Curve:QuadraticLinear allowed curve = a + b*ewb + c*ewb**2 + d*edb + e*edb**2 + f*ewb*edb x = ewb = entering wet-bulb temperature seen by the cooling coil (C) y = edb = entering dry-bulb temperature seen by the cooling coil (C) Also allows Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = edb, z = stes) z = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("cooling_and_charge_mode_sensible_heat_ratio_function_of_temperature_curve_name")]
public string CoolingAndChargeModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Cooling And Charge Mode is available Any curve or table with on" +
    "e independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic cu" +
    "rve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator" +
    " air flow")]
[JsonProperty("cooling_and_charge_mode_sensible_heat_ratio_function_of_flow_fraction_curve_name")]
public string CoolingAndChargeModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("cooling_and_discharge_mode_available")]
public Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndDischargeModeAvailable CoolingAndDischargeModeAvailable { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndDischargeModeAvailable)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndDischargeModeAvailable), "No");
        

[Description(@"required field if Cooling And Discharge Mode is available gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb thermal storage tank at Fluid Storage Tank Rating Temperature (water or fluid) or storage faction of 0.5 (ice)")]
[JsonProperty("cooling_and_discharge_mode_rated_total_evaporator_cooling_capacity")]
public string CoolingAndDischargeModeRatedTotalEvaporatorCoolingCapacity { get; set; } = "";
        

[Description("If previous field is autocalculate, this determines the charging capacity as a mu" +
    "ltiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
[JsonProperty("cooling_and_discharge_mode_evaporator_capacity_sizing_factor")]
public System.Nullable<float> CoolingAndDischargeModeEvaporatorCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description(@"required field if Cooling And Discharge Mode is available net capacity including any internal devices rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb thermal storage tank at 26.7 C (water) or storage faction of 0.5 (ice)")]
[JsonProperty("cooling_and_discharge_mode_rated_storage_discharging_capacity")]
public string CoolingAndDischargeModeRatedStorageDischargingCapacity { get; set; } = "";
        

[Description("If previous field is autocalculate, this determines the charging capacity as a mu" +
    "ltiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
[JsonProperty("cooling_and_discharge_mode_storage_discharge_capacity_sizing_factor")]
public System.Nullable<float> CoolingAndDischargeModeStorageDischargeCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("required field if Cooling And Discharge Mode is available Rated sensible heat rat" +
    "io (gross sensible evaporator capacity/gross total evaporator capacity) sensible" +
    " and total capacities do not include supply fan heat")]
[JsonProperty("cooling_and_discharge_mode_rated_sensible_heat_ratio")]
public System.Nullable<float> CoolingAndDischargeModeRatedSensibleHeatRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("Gross evaporator cooling capacity divided by power input to the compressor (for c" +
    "ooling) and outdoor fan, does not include supply fan heat or supply fan electric" +
    "al energy input required field if Cooling And Discharge Mode is available")]
[JsonProperty("cooling_and_discharge_mode_cooling_rated_cop")]
public System.Nullable<float> CoolingAndDischargeModeCoolingRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description("gross cooling capacity divided by power input to the compressor (for discharging)" +
    ", includes any internal devices for discharging storage but not supply fan requi" +
    "red field if Cooling And Discharge Mode is available")]
[JsonProperty("cooling_and_discharge_mode_discharging_rated_cop")]
public System.Nullable<float> CoolingAndDischargeModeDischargingRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description(@"required field if Cooling Only Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("cooling_and_discharge_mode_total_evaporator_cooling_capacity_function_of_temperat" +
    "ure_curve_name")]
public string CoolingAndDischargeModeTotalEvaporatorCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
    " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
    " curve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evapora" +
    "tor air flow")]
[JsonProperty("cooling_and_discharge_mode_total_evaporator_cooling_capacity_function_of_flow_fra" +
    "ction_curve_name")]
public string CoolingAndDischargeModeTotalEvaporatorCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Discharge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("cooling_and_discharge_mode_evaporator_energy_input_ratio_function_of_temperature_" +
    "curve_name")]
public string CoolingAndDischargeModeEvaporatorEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
    " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
    " curve = a + b*ff + c*ff**2 + d*ff**3 ff = Fraction of the full load evaporator " +
    "air flow")]
[JsonProperty("cooling_and_discharge_mode_evaporator_energy_input_ratio_function_of_flow_fractio" +
    "n_curve_name")]
public string CoolingAndDischargeModeEvaporatorEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Discharge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
[JsonProperty("cooling_and_discharge_mode_evaporator_part_load_fraction_correlation_curve_name")]
public string CoolingAndDischargeModeEvaporatorPartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Discharge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("cooling_and_discharge_mode_storage_discharge_capacity_function_of_temperature_cur" +
    "ve_name")]
public string CoolingAndDischargeModeStorageDischargeCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
    " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
    " curve = a + b*ff + c*ff**2 + d*ff**3 ff = Fraction of the full load evaporator " +
    "air flow")]
[JsonProperty("cooling_and_discharge_mode_storage_discharge_capacity_function_of_flow_fraction_c" +
    "urve_name")]
public string CoolingAndDischargeModeStorageDischargeCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Discharge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x =PLR = part load ratio (evaporator cooling load/steady state capacity)")]
[JsonProperty("cooling_and_discharge_mode_storage_discharge_capacity_function_of_total_evaporato" +
    "r_plr_curve_name")]
public string CoolingAndDischargeModeStorageDischargeCapacityFunctionOfTotalEvaporatorPlrCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Discharge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("cooling_and_discharge_mode_storage_energy_input_ratio_function_of_temperature_cur" +
    "ve_name")]
public string CoolingAndDischargeModeStorageEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
    " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
    " curve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evapora" +
    "tor air flow")]
[JsonProperty("cooling_and_discharge_mode_storage_energy_input_ratio_function_of_flow_fraction_c" +
    "urve_name")]
public string CoolingAndDischargeModeStorageEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Discharge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
[JsonProperty("cooling_and_discharge_mode_storage_energy_part_load_fraction_correlation_curve_na" +
    "me")]
public string CoolingAndDischargeModeStorageEnergyPartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description(@"required field if Cooling And Discharge Mode is available Curves or tables with either two or three independent variables can be used. curve = a + b*ewb + c*ewb**2 + d*edb + e*edb**2 + f*ewb*edb x = ewb = entering wet-bulb temperature seen by the cooling coil (C) y = edb = entering dry-bulb temperature seen by the cooling coil (C) Also allows Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = edb, z = stes) z = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("cooling_and_discharge_mode_sensible_heat_ratio_function_of_temperature_curve_name" +
    "")]
public string CoolingAndDischargeModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
    " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
    " curve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evapora" +
    "tor air flow")]
[JsonProperty("cooling_and_discharge_mode_sensible_heat_ratio_function_of_flow_fraction_curve_na" +
    "me")]
public string CoolingAndDischargeModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[JsonProperty("charge_only_mode_available")]
public Coil_Cooling_DX_SingleSpeed_ThermalStorage_ChargeOnlyModeAvailable ChargeOnlyModeAvailable { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_ChargeOnlyModeAvailable)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_ChargeOnlyModeAvailable), "No");
        

[Description("required field if Charge Only  Mode is available net capacity including any inter" +
    "nal devices air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-" +
    "bulb thermal storage tank at 26.7 C (water) or storage faction of 0.5 (ice)")]
[JsonProperty("charge_only_mode_rated_storage_charging_capacity")]
public string ChargeOnlyModeRatedStorageChargingCapacity { get; set; } = "";
        

[Description("If previous field is autocalculate, this determines the charging capacity as a mu" +
    "ltiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
[JsonProperty("charge_only_mode_capacity_sizing_factor")]
public System.Nullable<float> ChargeOnlyModeCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("net cooling capacity divided by power input to the compressor (for charging) and " +
    "outdoor fan, includes any internal devices required field if Charge Only Mode is" +
    " available")]
[JsonProperty("charge_only_mode_charging_rated_cop")]
public System.Nullable<float> ChargeOnlyModeChargingRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description(@"required field if Charge Only Mode is available Any curve or table with two independent variables can be used curve = a + b*db + c*db**2 + d*stes + e*stes**2 + f*db*stes x = db = dry-bulb temperature seen by the condenser (C) y = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("charge_only_mode_storage_charge_capacity_function_of_temperature_curve_name")]
public string ChargeOnlyModeStorageChargeCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description(@"required field if Charge Only Mode is available Any curve or table with two independent variables can be used curve = a + b*db + c*db**2 + d*stes + e*stes**2 + f*db*stes x = db = dry-bulb temperature seen by the condenser (C) y = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("charge_only_mode_storage_energy_input_ratio_function_of_temperature_curve_name")]
public string ChargeOnlyModeStorageEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[JsonProperty("discharge_only_mode_available")]
public Coil_Cooling_DX_SingleSpeed_ThermalStorage_DischargeOnlyModeAvailable DischargeOnlyModeAvailable { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_DischargeOnlyModeAvailable)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_DischargeOnlyModeAvailable), "No");
        

[Description("required field if Discharge Only Mode is available net capacity including any int" +
    "ernal devices rating point: air entering the cooling coil at 26.7 C dry-bulb/19." +
    "4 C wet-bulb, and thermal storage tank at 26.7 C (water) or storage faction of 0" +
    ".5 (ice)")]
[JsonProperty("discharge_only_mode_rated_storage_discharging_capacity")]
public string DischargeOnlyModeRatedStorageDischargingCapacity { get; set; } = "";
        

[Description("If previous field is autocalculate, this determines the discharging capacity as a" +
    " multiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
[JsonProperty("discharge_only_mode_capacity_sizing_factor")]
public System.Nullable<float> DischargeOnlyModeCapacitySizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("required field if Discharge Only Mode is available Rated sensible heat ratio (gro" +
    "ss sensible evaporator capacity/gross total evaporator capacity) sensible and to" +
    "tal capacities do not include supply fan heat")]
[JsonProperty("discharge_only_mode_rated_sensible_heat_ratio")]
public System.Nullable<float> DischargeOnlyModeRatedSensibleHeatRatio { get; set; } = null;
        

[Description("required field if Discharge Only Mode is available gross cooling capacity divided" +
    " by power input to the compressor (for discharging), includes any internal devic" +
    "es for discharging storage but not supply fan")]
[JsonProperty("discharge_only_mode_rated_cop")]
public System.Nullable<float> DischargeOnlyModeRatedCop { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[Description(@"required field if Discharge Only Mode is available Any curve or table with two independent variables can be used curve = a + b*ewb + c*ewb**2 + d*stes + e*stes**2 + f*ewb*stes x = ewb = evaporator entering wet-bulb temperature (C) y = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("discharge_only_mode_storage_discharge_capacity_function_of_temperature_curve_name" +
    "")]
public string DischargeOnlyModeStorageDischargeCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Discharge Only Mode is available Any curve or table with one in" +
    "dependent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve " +
    "= a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air" +
    " flow")]
[JsonProperty("discharge_only_mode_storage_discharge_capacity_function_of_flow_fraction_curve_na" +
    "me")]
public string DischargeOnlyModeStorageDischargeCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description(@"required field if Discharge Only Mode is available Any curve or table with two independent variables can be used curve = a + b*ewb + c*ewb**2 + d*stes + e*stes**2 + f*ewb*stes x = ewb = evaporator entering wet-bulb temperature (C) y = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("discharge_only_mode_energy_input_ratio_function_of_temperature_curve_name")]
public string DischargeOnlyModeEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Discharge Only Mode is available Any curve or table with one in" +
    "dependent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve " +
    "= a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air" +
    " flow")]
[JsonProperty("discharge_only_mode_energy_input_ratio_function_of_flow_fraction_curve_name")]
public string DischargeOnlyModeEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("required field if Discharge Only Mode is available Any curve or table with one in" +
    "dependent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curv" +
    "e = a + b*PLR + c*PLR**2 + d*PLR**3")]
[JsonProperty("discharge_only_mode_part_load_fraction_correlation_curve_name")]
public string DischargeOnlyModePartLoadFractionCorrelationCurveName { get; set; } = "";
        

[Description(@"required field if Discharge Only Mode is available Curves or tables with either two or three independent variables can be used. For two independent variables: x = ewb = entering wet-bulb temperature seen by the cooling coil (C) y = edb = entering dry-bulb temperature seen by the cooling coil (C) For three independent variables: curve or table = func(x = ewb, y = edb, z = stes) z = stes = state of thermal energy storage (C or fraction)")]
[JsonProperty("discharge_only_mode_sensible_heat_ratio_function_of_temperature_curve_name")]
public string DischargeOnlyModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

[Description("required field if Discharge Only Mode is available Any curve or table with one in" +
    "dependent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve " +
    "= a + b*ff + c*ff**2 + d*ff**3 ff = Fraction of the full load evaporator air flo" +
    "w")]
[JsonProperty("discharge_only_mode_sensible_heat_ratio_function_of_flow_fraction_curve_name")]
public string DischargeOnlyModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

[Description("controls and miscellaneous standby ancillary electric power draw, when available")]
[JsonProperty("ancillary_electric_power")]
public System.Nullable<float> AncillaryElectricPower { get; set; } = null;
        

[JsonProperty("cold_weather_operation_minimum_outdoor_air_temperature")]
public System.Nullable<float> ColdWeatherOperationMinimumOutdoorAirTemperature { get; set; } = null;
        

[JsonProperty("cold_weather_operation_ancillary_power")]
public System.Nullable<float> ColdWeatherOperationAncillaryPower { get; set; } = null;
        

[Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
    "doorAir:Node or OutdoorAir:NodeList object.")]
[JsonProperty("condenser_air_inlet_node_name")]
public string CondenserAirInletNodeName { get; set; } = "";
        

[JsonProperty("condenser_air_outlet_node_name")]
public string CondenserAirOutletNodeName { get; set; } = "";
        

[Description("Used to calculate condenser leaving conditions and water use if evaporatively coo" +
    "led.")]
[JsonProperty("condenser_design_air_flow_rate")]
public string CondenserDesignAirFlowRate { get; set; } = "";
        

[Description("If previous field is autocalculate, this determines the condenser air flow size a" +
    "s a multiplier on the Rated Evaporator Air Flow Rate.")]
[JsonProperty("condenser_air_flow_sizing_factor")]
public System.Nullable<float> CondenserAirFlowSizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("condenser_type")]
public Coil_Cooling_DX_SingleSpeed_ThermalStorage_CondenserType CondenserType { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_CondenserType)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_CondenserType), "AirCooled");
        

[Description("required field if condenser type is evaporatively cooled")]
[JsonProperty("evaporative_condenser_effectiveness")]
public System.Nullable<float> EvaporativeCondenserEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("Rated power consumed by the evaporative condenser\'s water pump")]
[JsonProperty("evaporative_condenser_pump_rated_power_consumption")]
public string EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = (System.String)"0";
        

[Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the DX coil is off. If this field is blank, the basin heater is always available.")]
[JsonProperty("basin_heater_capacity")]
public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
    "or dry-bulb temperature when the basin heater turns on.")]
[JsonProperty("basin_heater_setpoint_temperature")]
public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
[JsonProperty("basin_heater_availability_schedule_name")]
public string BasinHeaterAvailabilityScheduleName { get; set; } = "";
        

[JsonProperty("supply_water_storage_tank_name")]
public string SupplyWaterStorageTankName { get; set; } = "";
        

[JsonProperty("condensate_collection_water_storage_tank_name")]
public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

[JsonProperty("storage_tank_plant_connection_inlet_node_name")]
public string StorageTankPlantConnectionInletNodeName { get; set; } = "";
        

[JsonProperty("storage_tank_plant_connection_outlet_node_name")]
public string StorageTankPlantConnectionOutletNodeName { get; set; } = "";
        

[JsonProperty("storage_tank_plant_connection_design_flow_rate")]
public System.Nullable<float> StorageTankPlantConnectionDesignFlowRate { get; set; } = null;
        

[JsonProperty("storage_tank_plant_connection_heat_transfer_effectiveness")]
public System.Nullable<float> StorageTankPlantConnectionHeatTransferEffectiveness { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[Description("For fluid storage tanks only, minimum limit for storage tank If omitted,then the " +
    "minimum temperature limit is that used for fluid property data.")]
[JsonProperty("storage_tank_minimum_operating_limit_fluid_temperature")]
public System.Nullable<float> StorageTankMinimumOperatingLimitFluidTemperature { get; set; } = null;
        

[Description("For fluid storage tanks only, maximum limit for storage tank If omitted,then the " +
    "maximum temperature limit is that used for fluid property data.")]
[JsonProperty("storage_tank_maximum_operating_limit_fluid_temperature")]
public System.Nullable<float> StorageTankMaximumOperatingLimitFluidTemperature { get; set; } = null;
    }
    
    public enum Coil_Cooling_DX_SingleSpeed_ThermalStorage_OperatingModeControlMethod
    {
        
        [JsonProperty("EMSControlled")]
        EMSControlled = 0,
        
        [JsonProperty("ScheduledModes")]
        ScheduledModes = 1,
    }
    
    public enum Coil_Cooling_DX_SingleSpeed_ThermalStorage_StorageType
    {
        
        [JsonProperty("Ice")]
        Ice = 0,
        
        [JsonProperty("UserDefinedFluidType")]
        UserDefinedFluidType = 1,
        
        [JsonProperty("Water")]
        Water = 2,
    }
    
    public enum Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingOnlyModeAvailable
    {
        
        [JsonProperty("No")]
        No = 0,
        
        [JsonProperty("Yes")]
        Yes = 1,
    }
    
    public enum Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndChargeModeAvailable
    {
        
        [JsonProperty("No")]
        No = 0,
        
        [JsonProperty("Yes")]
        Yes = 1,
    }
    
    public enum Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndDischargeModeAvailable
    {
        
        [JsonProperty("No")]
        No = 0,
        
        [JsonProperty("Yes")]
        Yes = 1,
    }
    
    public enum Coil_Cooling_DX_SingleSpeed_ThermalStorage_ChargeOnlyModeAvailable
    {
        
        [JsonProperty("No")]
        No = 0,
        
        [JsonProperty("Yes")]
        Yes = 1,
    }
    
    public enum Coil_Cooling_DX_SingleSpeed_ThermalStorage_DischargeOnlyModeAvailable
    {
        
        [JsonProperty("No")]
        No = 0,
        
        [JsonProperty("Yes")]
        Yes = 1,
    }
    
    public enum Coil_Cooling_DX_SingleSpeed_ThermalStorage_CondenserType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AirCooled")]
        AirCooled = 1,
        
        [JsonProperty("EvaporativelyCooled")]
        EvaporativelyCooled = 2,
    }
}
