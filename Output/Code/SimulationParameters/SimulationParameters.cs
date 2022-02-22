namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
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
    
    
    [Description("Specifies the EnergyPlus version of the IDF file.")]
    public class Version : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("version_identifier")]
public string VersionIdentifier { get; set; } = (System.String)"9.5";
    }
    
    [Description(@"Note that the following 3 fields are related to the Sizing:Zone, Sizing:System, and Sizing:Plant objects. Having these fields set to Yes but no corresponding Sizing object will not cause the sizing to be done. However, having any of these fields set to No, the corresponding Sizing object is ignored. Note also, if you want to do system sizing, you must also do zone sizing in the same run or an error will result.")]
    public class SimulationControl : BHoMObject, IEnergyPlusClass
    {
        

[Description("If Yes, Zone sizing is accomplished from corresponding Sizing:Zone objects and au" +
    "tosize fields.")]
[JsonProperty("do_zone_sizing_calculation")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes DoZoneSizingCalculation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("If Yes, System sizing is accomplished from corresponding Sizing:System objects an" +
    "d autosize fields. If Yes, Zone sizing (previous field) must also be Yes.")]
[JsonProperty("do_system_sizing_calculation")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes DoSystemSizingCalculation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("If Yes, Plant sizing is accomplished from corresponding Sizing:Plant objects and " +
    "autosize fields.")]
[JsonProperty("do_plant_sizing_calculation")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes DoPlantSizingCalculation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("If Yes, SizingPeriod:* objects are executed and results from those may be display" +
    "ed..")]
[JsonProperty("run_simulation_for_sizing_periods")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes RunSimulationForSizingPeriods { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("If Yes, RunPeriod:* objects are executed and results from those may be displayed." +
    ".")]
[JsonProperty("run_simulation_for_weather_file_run_periods")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes RunSimulationForWeatherFileRunPeriods { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

[Description("If Yes, SizingPeriod:* objects are exectuted additional times for advanced sizing" +
    ". Currently limited to use with coincident plant sizing, see Sizing:Plant object" +
    "")]
[JsonProperty("do_hvac_sizing_simulation_for_sizing_periods")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes DoHvacSizingSimulationForSizingPeriods { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("the entire set of SizingPeriod:* objects may be repeated to fine tune size result" +
    "s this input sets a limit on the number of passes that the sizing algorithms can" +
    " repeate the set")]
[JsonProperty("maximum_number_of_hvac_sizing_simulation_passes")]
public System.Nullable<float> MaximumNumberOfHvacSizingSimulationPasses { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    [Description("This object enables users to choose certain options that speed up EnergyPlus simu" +
        "lation, but may lead to small decreases in accuracy of results.")]
    public class PerformancePrecisionTradeoffs : BHoMObject, IEnergyPlusClass
    {
        

[Description("If Yes, an analytical or empirical solution will be used to replace iterations in" +
    " the coil performance calculations.")]
[JsonProperty("use_coil_direct_solutions")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes UseCoilDirectSolutions { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Determines which algorithm will be used to solve long wave radiant exchange among" +
    " surfaces within a zone.")]
[JsonProperty("zone_radiant_exchange_algorithm")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PerformancePrecisionTradeoffs_ZoneRadiantExchangeAlgorithm ZoneRadiantExchangeAlgorithm { get; set; } = (PerformancePrecisionTradeoffs_ZoneRadiantExchangeAlgorithm)Enum.Parse(typeof(PerformancePrecisionTradeoffs_ZoneRadiantExchangeAlgorithm), "ScriptF");
        

[Description("The increasing mode number roughly correspond with increased speed. A description" +
    " of each mode are shown in the documentation. When Advanced is selected the N1 f" +
    "ield value is used.")]
[JsonProperty("override_mode")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PerformancePrecisionTradeoffs_OverrideMode OverrideMode { get; set; } = (PerformancePrecisionTradeoffs_OverrideMode)Enum.Parse(typeof(PerformancePrecisionTradeoffs_OverrideMode), "Normal");
        

[Description("Maximum zone temperature change before HVAC timestep is shortened. Only used when" +
    " Override Mode is set to Advanced")]
[JsonProperty("maxzonetempdiff")]
public System.Nullable<float> Maxzonetempdiff { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

[Description("Maximum surface temperature change before HVAC timestep is shortened. Only used w" +
    "hen Override Mode is set to Advanced")]
[JsonProperty("maxalloweddeltemp")]
public System.Nullable<float> Maxalloweddeltemp { get; set; } = (System.Nullable<float>)Single.Parse("0.002", CultureInfo.InvariantCulture);
    }
    
    public enum PerformancePrecisionTradeoffs_ZoneRadiantExchangeAlgorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CarrollMRT")]
        CarrollMRT = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ScriptF")]
        ScriptF = 2,
    }
    
    public enum PerformancePrecisionTradeoffs_OverrideMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Advanced")]
        Advanced = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Mode01")]
        Mode01 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Mode02")]
        Mode02 = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Mode03")]
        Mode03 = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Mode04")]
        Mode04 = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="Mode05")]
        Mode05 = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="Mode06")]
        Mode06 = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="Mode07")]
        Mode07 = 8,
        
        [System.Runtime.Serialization.EnumMember(Value="Normal")]
        Normal = 9,
    }
    
    [Description("Describes parameters that are used during the simulation of the building. There a" +
        "re necessary correlations between the entries for this object and some entries i" +
        "n the Site:WeatherStation and Site:HeightVariation objects, specifically the Ter" +
        "rain field.")]
    public class Building : BHoMObject, IEnergyPlusClass
    {
        

[Description("degrees from true North")]
[JsonProperty("north_axis")]
public System.Nullable<float> NorthAxis { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Country=FlatOpenCountry | Suburbs=CountryTownsSuburbs | City=CityCenter | Ocean=b" +
    "ody of water (5km) | Urban=Urban-Industrial-Forest")]
[JsonProperty("terrain")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Building_Terrain Terrain { get; set; } = (Building_Terrain)Enum.Parse(typeof(Building_Terrain), "Suburbs");
        

[Description("Loads Convergence Tolerance Value is a change in load from one warmup day to the " +
    "next")]
[JsonProperty("loads_convergence_tolerance_value")]
public System.Nullable<float> LoadsConvergenceToleranceValue { get; set; } = (System.Nullable<float>)Single.Parse("0.04", CultureInfo.InvariantCulture);
        

[JsonProperty("temperature_convergence_tolerance_value")]
public System.Nullable<float> TemperatureConvergenceToleranceValue { get; set; } = (System.Nullable<float>)Single.Parse("0.4", CultureInfo.InvariantCulture);
        

[Description("MinimalShadowing | FullExterior | FullInteriorAndExterior | FullExteriorWithRefle" +
    "ctions | FullInteriorAndExteriorWithReflections")]
[JsonProperty("solar_distribution")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Building_SolarDistribution SolarDistribution { get; set; } = (Building_SolarDistribution)Enum.Parse(typeof(Building_SolarDistribution), "FullExterior");
        

[Description("EnergyPlus will only use as many warmup days as needed to reach convergence toler" +
    "ance. This field\'s value should NOT be set less than 25.")]
[JsonProperty("maximum_number_of_warmup_days")]
public System.Nullable<float> MaximumNumberOfWarmupDays { get; set; } = (System.Nullable<float>)Single.Parse("25", CultureInfo.InvariantCulture);
        

[Description(@"The minimum number of warmup days that produce enough temperature and flux history to start EnergyPlus simulation for all reference buildings was suggested to be 6. However this can lead to excessive run times as warmup days can be repeated needlessly. For faster execution rely on the convergence criteria to detect when warmup is complete. When this field is greater than the maximum warmup days defined previous field the maximum number of warmup days will be reset to the minimum value entered here. Warmup days will be set to be the value you entered. The default is 1.")]
[JsonProperty("minimum_number_of_warmup_days")]
public System.Nullable<float> MinimumNumberOfWarmupDays { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    public enum Building_Terrain
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="City")]
        City = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Country")]
        Country = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Ocean")]
        Ocean = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Suburbs")]
        Suburbs = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="Urban")]
        Urban = 5,
    }
    
    public enum Building_SolarDistribution
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FullExterior")]
        FullExterior = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FullExteriorWithReflections")]
        FullExteriorWithReflections = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="FullInteriorAndExterior")]
        FullInteriorAndExterior = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="FullInteriorAndExteriorWithReflections")]
        FullInteriorAndExteriorWithReflections = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="MinimalShadowing")]
        MinimalShadowing = 5,
    }
    
    [Description("This object is used to control details of the solar, shading, and daylighting mod" +
        "els")]
    public class ShadowCalculation : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Select between CPU-based polygon clipping method, the GPU-based pixel counting method, or importing from external shading data. If PixelCounting is selected and GPU hardware (or GPU emulation) is not available, a warning will be displayed and EnergyPlus will revert to PolygonClipping. If Scheduled is chosen, the External Shading Fraction Schedule Name is required in SurfaceProperty:LocalEnvironment. If Imported is chosen, the Schedule:File:Shading object is required.")]
[JsonProperty("shading_calculation_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ShadowCalculation_ShadingCalculationMethod ShadingCalculationMethod { get; set; } = (ShadowCalculation_ShadingCalculationMethod)Enum.Parse(typeof(ShadowCalculation_ShadingCalculationMethod), "PolygonClipping");
        

[Description("choose calculation frequency method. note that Timestep is only needed for certai" +
    "n cases and can increase execution time significantly.")]
[JsonProperty("shading_calculation_update_frequency_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ShadowCalculation_ShadingCalculationUpdateFrequencyMethod ShadingCalculationUpdateFrequencyMethod { get; set; } = (ShadowCalculation_ShadingCalculationUpdateFrequencyMethod)Enum.Parse(typeof(ShadowCalculation_ShadingCalculationUpdateFrequencyMethod), "Periodic");
        

[Description("enter number of days this field is only used if the previous field is set to Peri" +
    "odic warning issued if >31")]
[JsonProperty("shading_calculation_update_frequency")]
public System.Nullable<float> ShadingCalculationUpdateFrequency { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

[Description("Number of allowable figures in shadow overlap in PolygonClipping calculations")]
[JsonProperty("maximum_figures_in_shadow_overlap_calculations")]
public System.Nullable<float> MaximumFiguresInShadowOverlapCalculations { get; set; } = (System.Nullable<float>)Single.Parse("15000", CultureInfo.InvariantCulture);
        

[Description("Advanced Feature. Internal default is SutherlandHodgman Refer to InputOutput Refe" +
    "rence and Engineering Reference for more information")]
[JsonProperty("polygon_clipping_algorithm")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ShadowCalculation_PolygonClippingAlgorithm PolygonClippingAlgorithm { get; set; } = (ShadowCalculation_PolygonClippingAlgorithm)Enum.Parse(typeof(ShadowCalculation_PolygonClippingAlgorithm), "SutherlandHodgman");
        

[Description("Number of pixels in both dimensions of the surface rendering")]
[JsonProperty("pixel_counting_resolution")]
public System.Nullable<float> PixelCountingResolution { get; set; } = (System.Nullable<float>)Single.Parse("512", CultureInfo.InvariantCulture);
        

[Description("Advanced Feature. Internal default is SimpleSkyDiffuseModeling If you have shadin" +
    "g elements that change transmittance over the year, you may wish to choose the d" +
    "etailed method. Refer to InputOutput Reference and Engineering Reference for mor" +
    "e information")]
[JsonProperty("sky_diffuse_modeling_algorithm")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ShadowCalculation_SkyDiffuseModelingAlgorithm SkyDiffuseModelingAlgorithm { get; set; } = (ShadowCalculation_SkyDiffuseModelingAlgorithm)Enum.Parse(typeof(ShadowCalculation_SkyDiffuseModelingAlgorithm), "SimpleSkyDiffuseModeling");
        

[Description("If Yes is chosen, the calculated external shading fraction results will be saved " +
    "to an external CSV file with surface names as the column headers.")]
[JsonProperty("output_external_shading_calculation_results")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes OutputExternalShadingCalculationResults { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description(@"If Yes, self-shading will be disabled from all exterior surfaces in a given Shading Zone Group to surfaces within the same Shading Zone Group. If both Disable Self-Shading Within Shading Zone Groups and Disable Self-Shading From Shading Zone Groups to Other Zones = Yes, then all self-shading from exterior surfaces will be disabled. If only one of these fields = Yes, then at least one Shading Zone Group must be specified, or this field will be ignored. Shading from Shading:* surfaces, overhangs, fins, and reveals will not be disabled.")]
[JsonProperty("disable_self_shading_within_shading_zone_groups")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes DisableSelfShadingWithinShadingZoneGroups { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description(@"If Yes, self-shading will be disabled from all exterior surfaces in a given Shading Zone Group to all other zones in the model. If both Disable Self-Shading Within Shading Zone Groups and Disable Self-Shading From Shading Zone Groups to Other Zones = Yes, then all self-shading from exterior surfaces will be disabled. If only one of these fields = Yes, then at least one Shading Zone Group must be specified, or this field will be ignored. Shading from Shading:* surfaces, overhangs, fins, and reveals will not be disabled.")]
[JsonProperty("disable_self_shading_from_shading_zone_groups_to_other_zones")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes DisableSelfShadingFromShadingZoneGroupsToOtherZones { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[JsonProperty("shading_zone_groups")]
public string ShadingZoneGroups { get; set; } = "";
    }
    
    public enum ShadowCalculation_ShadingCalculationMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Imported")]
        Imported = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="PixelCounting")]
        PixelCounting = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PolygonClipping")]
        PolygonClipping = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Scheduled")]
        Scheduled = 4,
    }
    
    public enum ShadowCalculation_ShadingCalculationUpdateFrequencyMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Periodic")]
        Periodic = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Timestep")]
        Timestep = 2,
    }
    
    public enum ShadowCalculation_PolygonClippingAlgorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ConvexWeilerAtherton")]
        ConvexWeilerAtherton = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SlaterBarskyandSutherlandHodgman")]
        SlaterBarskyandSutherlandHodgman = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SutherlandHodgman")]
        SutherlandHodgman = 3,
    }
    
    public enum ShadowCalculation_SkyDiffuseModelingAlgorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DetailedSkyDiffuseModeling")]
        DetailedSkyDiffuseModeling = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SimpleSkyDiffuseModeling")]
        SimpleSkyDiffuseModeling = 2,
    }
    
    [Description("Default indoor surface heat transfer convection algorithm to be used for all zone" +
        "s")]
    public class SurfaceConvectionAlgorithm_Inside : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Simple = constant value natural convection (ASHRAE) TARP = variable natural convection based on temperature difference (ASHRAE, Walton) CeilingDiffuser = ACH-based forced and mixed convection correlations for ceiling diffuser configuration with simple natural convection limit AdaptiveConvectionAlgorithm = dynamic selection of convection models based on conditions ASTMC1340 = mixed convection correlations based on heat flow direction, surface tilt angle, surface characteristic length, and air speed past the surface.")]
[JsonProperty("algorithm")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public SurfaceConvectionAlgorithm_Inside_Algorithm Algorithm { get; set; } = (SurfaceConvectionAlgorithm_Inside_Algorithm)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_Algorithm), "TARP");
    }
    
    public enum SurfaceConvectionAlgorithm_Inside_Algorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ASTMC1340")]
        ASTMC1340 = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="CeilingDiffuser")]
        CeilingDiffuser = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="Simple")]
        Simple = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="TARP")]
        TARP = 5,
    }
    
    [Description("Default outside surface heat transfer convection algorithm to be used for all zon" +
        "es")]
    public class SurfaceConvectionAlgorithm_Outside : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"SimpleCombined = Combined radiation and convection coefficient using simple ASHRAE model TARP = correlation from models developed by ASHRAE, Walton, and Sparrow et. al. MoWiTT = correlation from measurements by Klems and Yazdanian for smooth surfaces DOE-2 = correlation from measurements by Klems and Yazdanian for rough surfaces AdaptiveConvectionAlgorithm = dynamic selection of correlations based on conditions")]
[JsonProperty("algorithm")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public SurfaceConvectionAlgorithm_Outside_Algorithm Algorithm { get; set; } = (SurfaceConvectionAlgorithm_Outside_Algorithm)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Outside_Algorithm), "Empty");
    }
    
    public enum SurfaceConvectionAlgorithm_Outside_Algorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdaptiveConvectionAlgorithm")]
        AdaptiveConvectionAlgorithm = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="DOE-2")]
        DOE2 = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MoWiTT")]
        MoWiTT = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="SimpleCombined")]
        SimpleCombined = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="TARP")]
        TARP = 5,
    }
    
    [Description(@"Determines which Heat Balance Algorithm will be used ie. CTF (Conduction Transfer Functions), EMPD (Effective Moisture Penetration Depth with Conduction Transfer Functions). Advanced/Research Usage: CondFD (Conduction Finite Difference) Advanced/Research Usage: ConductionFiniteDifferenceSimplified Advanced/Research Usage: HAMT (Combined Heat And Moisture Finite Element)")]
    public class HeatBalanceAlgorithm : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("algorithm")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public HeatBalanceAlgorithm_Algorithm Algorithm { get; set; } = (HeatBalanceAlgorithm_Algorithm)Enum.Parse(typeof(HeatBalanceAlgorithm_Algorithm), "ConductionTransferFunction");
        

[JsonProperty("surface_temperature_upper_limit")]
public System.Nullable<float> SurfaceTemperatureUpperLimit { get; set; } = (System.Nullable<float>)Single.Parse("200", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_surface_convection_heat_transfer_coefficient_value")]
public System.Nullable<float> MinimumSurfaceConvectionHeatTransferCoefficientValue { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[JsonProperty("maximum_surface_convection_heat_transfer_coefficient_value")]
public System.Nullable<float> MaximumSurfaceConvectionHeatTransferCoefficientValue { get; set; } = (System.Nullable<float>)Single.Parse("1000", CultureInfo.InvariantCulture);
    }
    
    public enum HeatBalanceAlgorithm_Algorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CombinedHeatAndMoistureFiniteElement")]
        CombinedHeatAndMoistureFiniteElement = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ConductionFiniteDifference")]
        ConductionFiniteDifference = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ConductionTransferFunction")]
        ConductionTransferFunction = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MoisturePenetrationDepthConductionTransferFunction")]
        MoisturePenetrationDepthConductionTransferFunction = 4,
    }
    
    [Description("Determines settings for the Conduction Finite Difference algorithm for surface he" +
        "at transfer modeling.")]
    public class HeatBalanceSettings_ConductionFiniteDifference : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("difference_scheme")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public HeatBalanceSettings_ConductionFiniteDifference_DifferenceScheme DifferenceScheme { get; set; } = (HeatBalanceSettings_ConductionFiniteDifference_DifferenceScheme)Enum.Parse(typeof(HeatBalanceSettings_ConductionFiniteDifference_DifferenceScheme), "FullyImplicitFirstOrder");
        

[Description("increase or decrease number of nodes")]
[JsonProperty("space_discretization_constant")]
public System.Nullable<float> SpaceDiscretizationConstant { get; set; } = (System.Nullable<float>)Single.Parse("3", CultureInfo.InvariantCulture);
        

[JsonProperty("relaxation_factor")]
public System.Nullable<float> RelaxationFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("inside_face_surface_temperature_convergence_criteria")]
public System.Nullable<float> InsideFaceSurfaceTemperatureConvergenceCriteria { get; set; } = (System.Nullable<float>)Single.Parse("0.002", CultureInfo.InvariantCulture);
    }
    
    public enum HeatBalanceSettings_ConductionFiniteDifference_DifferenceScheme
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CrankNicholsonSecondOrder")]
        CrankNicholsonSecondOrder = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FullyImplicitFirstOrder")]
        FullyImplicitFirstOrder = 2,
    }
    
    [Description("Determines which algorithm will be used to solve the zone air heat balance.")]
    public class ZoneAirHeatBalanceAlgorithm : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("algorithm")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneAirHeatBalanceAlgorithm_Algorithm Algorithm { get; set; } = (ZoneAirHeatBalanceAlgorithm_Algorithm)Enum.Parse(typeof(ZoneAirHeatBalanceAlgorithm_Algorithm), "ThirdOrderBackwardDifference");
    }
    
    public enum ZoneAirHeatBalanceAlgorithm_Algorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AnalyticalSolution")]
        AnalyticalSolution = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="EulerMethod")]
        EulerMethod = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ThirdOrderBackwardDifference")]
        ThirdOrderBackwardDifference = 3,
    }
    
    [Description("Determines which contaminant concentration will be simulates.")]
    public class ZoneAirContaminantBalance : BHoMObject, IEnergyPlusClass
    {
        

[Description("If Yes, CO2 simulation will be performed.")]
[JsonProperty("carbon_dioxide_concentration")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes CarbonDioxideConcentration { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Schedule values should be in parts per million (ppm)")]
[JsonProperty("outdoor_carbon_dioxide_schedule_name")]
public string OutdoorCarbonDioxideScheduleName { get; set; } = "";
        

[Description("If Yes, generic contaminant simulation will be performed.")]
[JsonProperty("generic_contaminant_concentration")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes GenericContaminantConcentration { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("Schedule values should be generic contaminant concentration in parts per million " +
    "(ppm)")]
[JsonProperty("outdoor_generic_contaminant_schedule_name")]
public string OutdoorGenericContaminantScheduleName { get; set; } = "";
    }
    
    [Description(@"Enforces the zone air mass flow balance by either adjusting zone mixing object flow only, adjusting zone total return flow only, zone mixing and the zone total return flows, or adjusting the zone total return and zone mixing object flows. Zone infiltration flow air flow is increased or decreased depending user selection in the infiltration treatment method. If either of zone mixing or zone return flow adjusting methods or infiltration is active, then the zone air mass flow balance calculation will attempt to enforce conservation of mass for each zone. If flow balancing method is ""None"" and infiltration is ""None"", then the zone air mass flow calculation defaults to assume self-balanced simple flow mixing and infiltration objects.")]
    public class ZoneAirMassFlowConservation : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"If ""AdjustMixingOnly"", zone mixing object flow rates are adjusted to balance the zone air mass flow and zone infiltration air flow may be increased or decreased if required in order to balance the zone air mass flow. If ""AdjustReturnOnly"", zone total return flow rate is adjusted to balance the zone air mass flow and zone infiltration air flow may be increased or decreased if required in order to balance the zone air mass flow. If ""AdjustMixingThenReturn"", first the zone mixing objects flow rates are adjusted to balance the zone air flow, second zone total return flow rate is adjusted and zone infiltration air flow may be increased or decreased if required in order to balance the zone air mass flow. If ""AdjustReturnThenMixing"", first zone total return flow rate is adjusted to balance the zone air flow, second the zone mixing object flow rates are adjusted and infiltration air flow may be increased or decreased if required in order to balance the zone air mass flow.")]
[JsonProperty("adjust_zone_mixing_and_return_for_air_mass_flow_balance")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneAirMassFlowConservation_AdjustZoneMixingAndReturnForAirMassFlowBalance AdjustZoneMixingAndReturnForAirMassFlowBalance { get; set; } = (ZoneAirMassFlowConservation_AdjustZoneMixingAndReturnForAirMassFlowBalance)Enum.Parse(typeof(ZoneAirMassFlowConservation_AdjustZoneMixingAndReturnForAirMassFlowBalance), "None");
        

[Description(@"This input field allows user to choose how zone infiltration flow is treated during the zone air mass flow balance calculation. AddInfiltrationFlow may add infiltration to the base flow specified in the infiltration object to balance the zone air mass flow. The additional infiltration air mass flow is not self-balanced. The base flow is assumed to be self-balanced. AdjustInfiltrationFlow may adjust the base flow calculated using the base flow specified in the infiltration object to balance the zone air mass flow. If it If no adjustment is required, then the base infiltration is assumed to be self-balanced. None will make no changes to the base infiltration flow.")]
[JsonProperty("infiltration_balancing_method")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneAirMassFlowConservation_InfiltrationBalancingMethod InfiltrationBalancingMethod { get; set; } = (ZoneAirMassFlowConservation_InfiltrationBalancingMethod)Enum.Parse(typeof(ZoneAirMassFlowConservation_InfiltrationBalancingMethod), "AddInfiltrationFlow");
        

[Description(@"This input field allows user to choose which zones are included in infiltration balancing. MixingSourceZonesOnly allows infiltration balancing only in zones which as source zones for mixing which also have an infiltration object defined. AllZones allows infiltration balancing in any zone which has an infiltration object defined.")]
[JsonProperty("infiltration_balancing_zones")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public ZoneAirMassFlowConservation_InfiltrationBalancingZones InfiltrationBalancingZones { get; set; } = (ZoneAirMassFlowConservation_InfiltrationBalancingZones)Enum.Parse(typeof(ZoneAirMassFlowConservation_InfiltrationBalancingZones), "MixingSourceZonesOnly");
    }
    
    public enum ZoneAirMassFlowConservation_AdjustZoneMixingAndReturnForAirMassFlowBalance
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjustMixingOnly")]
        AdjustMixingOnly = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjustMixingThenReturn")]
        AdjustMixingThenReturn = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjustReturnOnly")]
        AdjustReturnOnly = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjustReturnThenMixing")]
        AdjustReturnThenMixing = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 5,
    }
    
    public enum ZoneAirMassFlowConservation_InfiltrationBalancingMethod
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AddInfiltrationFlow")]
        AddInfiltrationFlow = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="AdjustInfiltrationFlow")]
        AdjustInfiltrationFlow = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 3,
    }
    
    public enum ZoneAirMassFlowConservation_InfiltrationBalancingZones
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="AllZones")]
        AllZones = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MixingSourceZonesOnly")]
        MixingSourceZonesOnly = 2,
    }
    
    [Description("Multiplier altering the relative capacitance of the air compared to an empty zone" +
        "")]
    public class ZoneCapacitanceMultiplier_ResearchSpecial : BHoMObject, IEnergyPlusClass
    {
        

[Description("If this field is left blank, the multipliers are applied to all the zones not spe" +
    "cified")]
[JsonProperty("zone_or_zonelist_name")]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description("Used to alter the capacitance of zone air with respect to heat or temperature")]
[JsonProperty("temperature_capacity_multiplier")]
public System.Nullable<float> TemperatureCapacityMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Used to alter the capacitance of zone air with respect to moisture or humidity ra" +
    "tio")]
[JsonProperty("humidity_capacity_multiplier")]
public System.Nullable<float> HumidityCapacityMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Used to alter the capacitance of zone air with respect to zone air carbon dioxide" +
    " concentration")]
[JsonProperty("carbon_dioxide_capacity_multiplier")]
public System.Nullable<float> CarbonDioxideCapacityMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Used to alter the capacitance of zone air with respect to zone air generic contam" +
    "inant concentration")]
[JsonProperty("generic_contaminant_capacity_multiplier")]
public System.Nullable<float> GenericContaminantCapacityMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
    }
    
    [Description("Specifies the \"basic\" timestep for the simulation. The value entered here is also" +
        " known as the Zone Timestep. This is used in the Zone Heat Balance Model calcula" +
        "tion as the driving timestep for heat transfer and load calculations.")]
    public class Timestep : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"Number in hour: normal validity 4 to 60: 6 suggested Must be evenly divisible into 60 Allowable values include 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, and 60 Normal 6 is minimum as lower values may cause inaccuracies A minimum value of 20 is suggested for both ConductionFiniteDifference and CombinedHeatAndMoistureFiniteElement surface heat balance algorithms A minimum of 12 is suggested for simulations involving a Vegetated Roof (Material:RoofVegetation).")]
[JsonProperty("number_of_timesteps_per_hour")]
public System.Nullable<float> NumberOfTimestepsPerHour { get; set; } = (System.Nullable<float>)Single.Parse("6", CultureInfo.InvariantCulture);
    }
    
    [Description("Specifies limits on HVAC system simulation timesteps and iterations. This item is" +
        " an advanced feature that should be used only with caution.")]
    public class ConvergenceLimits : BHoMObject, IEnergyPlusClass
    {
        

[Description("0 sets the minimum to the zone timestep (ref: Timestep) 1 is normal (ratchet down" +
    " to 1 minute) setting greater than zone timestep (in minutes) will effectively s" +
    "et to zone timestep")]
[JsonProperty("minimum_system_timestep")]
public System.Nullable<float> MinimumSystemTimestep { get; set; } = null;
        

[JsonProperty("maximum_hvac_iterations")]
public System.Nullable<float> MaximumHvacIterations { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

[Description(@"Controls the minimum number of plant system solver iterations within a single HVAC iteration Larger values will increase runtime but might improve solution accuracy for complicated plant systems Complex plants include: several interconnected loops, heat recovery, thermal load following generators, etc.")]
[JsonProperty("minimum_plant_iterations")]
public System.Nullable<float> MinimumPlantIterations { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

[Description("Controls the maximum number of plant system solver iterations within a single HVA" +
    "C iteration Smaller values might decrease runtime but could decrease solution ac" +
    "curacy for complicated plant systems")]
[JsonProperty("maximum_plant_iterations")]
public System.Nullable<float> MaximumPlantIterations { get; set; } = (System.Nullable<float>)Single.Parse("8", CultureInfo.InvariantCulture);
    }
    
    [Description("Specifies a HVAC system solver algorithm to find a root")]
    public class HVACSystemRootFindingAlgorithm : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("algorithm")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public HVACSystemRootFindingAlgorithm_Algorithm Algorithm { get; set; } = (HVACSystemRootFindingAlgorithm_Algorithm)Enum.Parse(typeof(HVACSystemRootFindingAlgorithm_Algorithm), "RegulaFalsi");
        

[Description("This field is used when RegulaFalsiThenBisection or BisectionThenRegulaFalsi is e" +
    "ntered. When iteration number is greater than the value, algorithm switches.")]
[JsonProperty("number_of_iterations_before_algorithm_switch")]
public System.Nullable<float> NumberOfIterationsBeforeAlgorithmSwitch { get; set; } = (System.Nullable<float>)Single.Parse("5", CultureInfo.InvariantCulture);
    }
    
    public enum HVACSystemRootFindingAlgorithm_Algorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Alternation")]
        Alternation = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Bisection")]
        Bisection = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="BisectionThenRegulaFalsi")]
        BisectionThenRegulaFalsi = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="RegulaFalsi")]
        RegulaFalsi = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="RegulaFalsiThenBisection")]
        RegulaFalsiThenBisection = 5,
    }
}