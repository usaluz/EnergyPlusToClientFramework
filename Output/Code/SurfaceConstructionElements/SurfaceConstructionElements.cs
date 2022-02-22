namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
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
    
    
    [Description("Regular materials described with full set of thermal properties")]
    [JsonObject("Material")]
    public class Material : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("roughness")]
public Material_Roughness Roughness { get; set; } = (Material_Roughness)Enum.Parse(typeof(Material_Roughness), "MediumRough");
        

[JsonProperty("thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[JsonProperty("conductivity")]
public System.Nullable<float> Conductivity { get; set; } = null;
        

[JsonProperty("density")]
public System.Nullable<float> Density { get; set; } = null;
        

[JsonProperty("specific_heat")]
public System.Nullable<float> SpecificHeat { get; set; } = null;
        

[JsonProperty("thermal_absorptance")]
public System.Nullable<float> ThermalAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("solar_absorptance")]
public System.Nullable<float> SolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("visible_absorptance")]
public System.Nullable<float> VisibleAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
    }
    
    public enum Material_Roughness
    {
        
        [JsonProperty("MediumRough")]
        MediumRough = 0,
        
        [JsonProperty("MediumSmooth")]
        MediumSmooth = 1,
        
        [JsonProperty("Rough")]
        Rough = 2,
        
        [JsonProperty("Smooth")]
        Smooth = 3,
        
        [JsonProperty("VeryRough")]
        VeryRough = 4,
        
        [JsonProperty("VerySmooth")]
        VerySmooth = 5,
    }
    
    [Description("Regular materials properties described whose principal description is R (Thermal " +
        "Resistance)")]
    [JsonObject("Material:NoMass")]
    public class Material_NoMass : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("roughness")]
public Material_NoMass_Roughness Roughness { get; set; } = (Material_NoMass_Roughness)Enum.Parse(typeof(Material_NoMass_Roughness), "MediumRough");
        

[JsonProperty("thermal_resistance")]
public System.Nullable<float> ThermalResistance { get; set; } = null;
        

[JsonProperty("thermal_absorptance")]
public System.Nullable<float> ThermalAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("solar_absorptance")]
public System.Nullable<float> SolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("visible_absorptance")]
public System.Nullable<float> VisibleAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
    }
    
    public enum Material_NoMass_Roughness
    {
        
        [JsonProperty("MediumRough")]
        MediumRough = 0,
        
        [JsonProperty("MediumSmooth")]
        MediumSmooth = 1,
        
        [JsonProperty("Rough")]
        Rough = 2,
        
        [JsonProperty("Smooth")]
        Smooth = 3,
        
        [JsonProperty("VeryRough")]
        VeryRough = 4,
        
        [JsonProperty("VerySmooth")]
        VerySmooth = 5,
    }
    
    [Description(@"Special infrared transparent material. Similar to a Material:Nomass with low thermal resistance. High absorptance in both wavelengths. Area will be doubled internally to make internal radiant exchange accurate. Should be only material in single layer surface construction. All thermal properties are set internally. User needs only to supply name. Cannot be used with ConductionFiniteDifference solution algorithms")]
    [JsonObject("Material:InfraredTransparent")]
    public class Material_InfraredTransparent : BHoMObject, IEnergyPlusClass
    {
    }
    
    [Description("Air Space in Opaque Construction")]
    [JsonObject("Material:AirGap")]
    public class Material_AirGap : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("thermal_resistance")]
public System.Nullable<float> ThermalResistance { get; set; } = null;
    }
    
    [Description(@"EcoRoof model, plant layer plus soil layer Implemented by Portland State University (Sailor et al., January, 2007) only one material must be referenced per simulation though the same EcoRoof material could be used in multiple constructions. New moisture redistribution scheme (2010) requires higher number of timesteps per hour (minimum 12 recommended).")]
    [JsonObject("Material:RoofVegetation")]
    public class Material_RoofVegetation : BHoMObject, IEnergyPlusClass
    {
        

[Description("The ecoroof module is designed for short plants and shrubs.")]
[JsonProperty("height_of_plants")]
public System.Nullable<float> HeightOfPlants { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("Entire surface is assumed covered, so decrease LAI accordingly.")]
[JsonProperty("leaf_area_index")]
public System.Nullable<float> LeafAreaIndex { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Leaf reflectivity (albedo) is typically 0.18-0.25")]
[JsonProperty("leaf_reflectivity")]
public System.Nullable<float> LeafReflectivity { get; set; } = (System.Nullable<float>)Single.Parse("0.22", CultureInfo.InvariantCulture);
        

[JsonProperty("leaf_emissivity")]
public System.Nullable<float> LeafEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.95", CultureInfo.InvariantCulture);
        

[Description("This depends upon plant type")]
[JsonProperty("minimum_stomatal_resistance")]
public System.Nullable<float> MinimumStomatalResistance { get; set; } = (System.Nullable<float>)Single.Parse("180", CultureInfo.InvariantCulture);
        

[JsonProperty("soil_layer_name")]
public string SoilLayerName { get; set; } = (System.String)"Green Roof Soil";
        

[JsonProperty("roughness")]
public Material_RoofVegetation_Roughness Roughness { get; set; } = (Material_RoofVegetation_Roughness)Enum.Parse(typeof(Material_RoofVegetation_Roughness), "MediumRough");
        

[Description("thickness of the soil layer of the EcoRoof Soil depths of 0.15m (6in) and 0.30m (" +
    "12in) are common.")]
[JsonProperty("thickness")]
public System.Nullable<float> Thickness { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("Thermal conductivity of dry soil. Typical ecoroof soils range from 0.3 to 0.5")]
[JsonProperty("conductivity_of_dry_soil")]
public System.Nullable<float> ConductivityOfDrySoil { get; set; } = (System.Nullable<float>)Single.Parse("0.35", CultureInfo.InvariantCulture);
        

[Description("Density of dry soil (the code modifies this as the soil becomes moist) Typical ec" +
    "oroof soils range from 400 to 1000 (dry to wet)")]
[JsonProperty("density_of_dry_soil")]
public System.Nullable<float> DensityOfDrySoil { get; set; } = (System.Nullable<float>)Single.Parse("1100", CultureInfo.InvariantCulture);
        

[Description("Specific heat of dry soil")]
[JsonProperty("specific_heat_of_dry_soil")]
public System.Nullable<float> SpecificHeatOfDrySoil { get; set; } = (System.Nullable<float>)Single.Parse("1200", CultureInfo.InvariantCulture);
        

[Description("Soil emissivity is typically in range of 0.90 to 0.98")]
[JsonProperty("thermal_absorptance")]
public System.Nullable<float> ThermalAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Solar absorptance of dry soil (1-albedo) is typically 0.60 to 0.85 corresponding " +
    "to a dry albedo of 0.15 to 0.40")]
[JsonProperty("solar_absorptance")]
public System.Nullable<float> SolarAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.7", CultureInfo.InvariantCulture);
        

[JsonProperty("visible_absorptance")]
public System.Nullable<float> VisibleAbsorptance { get; set; } = (System.Nullable<float>)Single.Parse("0.75", CultureInfo.InvariantCulture);
        

[Description("Maximum moisture content is typically less than 0.5")]
[JsonProperty("saturation_volumetric_moisture_content_of_the_soil_layer")]
public System.Nullable<float> SaturationVolumetricMoistureContentOfTheSoilLayer { get; set; } = (System.Nullable<float>)Single.Parse("0.3", CultureInfo.InvariantCulture);
        

[JsonProperty("residual_volumetric_moisture_content_of_the_soil_layer")]
public System.Nullable<float> ResidualVolumetricMoistureContentOfTheSoilLayer { get; set; } = (System.Nullable<float>)Single.Parse("0.01", CultureInfo.InvariantCulture);
        

[JsonProperty("initial_volumetric_moisture_content_of_the_soil_layer")]
public System.Nullable<float> InitialVolumetricMoistureContentOfTheSoilLayer { get; set; } = (System.Nullable<float>)Single.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("Advanced calculation requires increased number of timesteps (recommended >20).")]
[JsonProperty("moisture_diffusion_calculation_method")]
public Material_RoofVegetation_MoistureDiffusionCalculationMethod MoistureDiffusionCalculationMethod { get; set; } = (Material_RoofVegetation_MoistureDiffusionCalculationMethod)Enum.Parse(typeof(Material_RoofVegetation_MoistureDiffusionCalculationMethod), "Advanced");
    }
    
    public enum Material_RoofVegetation_Roughness
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MediumRough")]
        MediumRough = 1,
        
        [JsonProperty("MediumSmooth")]
        MediumSmooth = 2,
        
        [JsonProperty("Rough")]
        Rough = 3,
        
        [JsonProperty("Smooth")]
        Smooth = 4,
        
        [JsonProperty("VeryRough")]
        VeryRough = 5,
        
        [JsonProperty("VerySmooth")]
        VerySmooth = 6,
    }
    
    public enum Material_RoofVegetation_MoistureDiffusionCalculationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Advanced")]
        Advanced = 1,
        
        [JsonProperty("Simple")]
        Simple = 2,
    }
    
    [Description("Alternate method of describing windows This window material object is used to def" +
        "ine an entire glazing system using simple performance parameters.")]
    [JsonObject("WindowMaterial:SimpleGlazingSystem")]
    public class WindowMaterial_SimpleGlazingSystem : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter U-Factor including film coefficients Note that the effective upper limit fo" +
    "r U-factor is 5.8 W/m2-K")]
[JsonProperty("u_factor")]
public System.Nullable<float> UFactor { get; set; } = null;
        

[Description("SHGC at Normal Incidence")]
[JsonProperty("solar_heat_gain_coefficient")]
public System.Nullable<float> SolarHeatGainCoefficient { get; set; } = null;
        

[Description("VT at Normal Incidence optional")]
[JsonProperty("visible_transmittance")]
public System.Nullable<float> VisibleTransmittance { get; set; } = null;
    }
    
    [Description("Glass material properties for Windows or Glass Doors Transmittance/Reflectance in" +
        "put method.")]
    [JsonObject("WindowMaterial:Glazing")]
    public class WindowMaterial_Glazing : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("optical_data_type")]
public WindowMaterial_Glazing_OpticalDataType OpticalDataType { get; set; } = (WindowMaterial_Glazing_OpticalDataType)Enum.Parse(typeof(WindowMaterial_Glazing_OpticalDataType), "BSDF");
        

[Description("Used only when Optical Data Type = Spectral")]
[JsonProperty("window_glass_spectral_data_set_name")]
public string WindowGlassSpectralDataSetName { get; set; } = "";
        

[JsonProperty("thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty("solar_transmittance_at_normal_incidence")]
public System.Nullable<float> SolarTransmittanceAtNormalIncidence { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
    "outdoor air")]
[JsonProperty("front_side_solar_reflectance_at_normal_incidence")]
public System.Nullable<float> FrontSideSolarReflectanceAtNormalIncidence { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
    "one air")]
[JsonProperty("back_side_solar_reflectance_at_normal_incidence")]
public System.Nullable<float> BackSideSolarReflectanceAtNormalIncidence { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty("visible_transmittance_at_normal_incidence")]
public System.Nullable<float> VisibleTransmittanceAtNormalIncidence { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty("front_side_visible_reflectance_at_normal_incidence")]
public System.Nullable<float> FrontSideVisibleReflectanceAtNormalIncidence { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty("back_side_visible_reflectance_at_normal_incidence")]
public System.Nullable<float> BackSideVisibleReflectanceAtNormalIncidence { get; set; } = null;
        

[JsonProperty("infrared_transmittance_at_normal_incidence")]
public System.Nullable<float> InfraredTransmittanceAtNormalIncidence { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("front_side_infrared_hemispherical_emissivity")]
public System.Nullable<float> FrontSideInfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[JsonProperty("back_side_infrared_hemispherical_emissivity")]
public System.Nullable<float> BackSideInfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[JsonProperty("conductivity")]
public System.Nullable<float> Conductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("dirt_correction_factor_for_solar_and_visible_transmittance")]
public System.Nullable<float> DirtCorrectionFactorForSolarAndVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("solar_diffusing")]
public EmptyNoYes SolarDiffusing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("coefficient used for deflection calculations. Used only with complex fenestration" +
    " when deflection model is set to TemperatureAndPressureInput")]
[JsonProperty("young_s_modulus")]
public System.Nullable<float> YoungSModulus { get; set; } = (System.Nullable<float>)Single.Parse("72000000000", CultureInfo.InvariantCulture);
        

[Description("coefficient used for deflection calculations. Used only with complex fenestration" +
    " when deflection model is set to TemperatureAndPressureInput")]
[JsonProperty("poisson_s_ratio")]
public System.Nullable<float> PoissonSRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.22", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAndAngle")]
[JsonProperty("window_glass_spectral_and_incident_angle_transmittance_data_set_table_name")]
public string WindowGlassSpectralAndIncidentAngleTransmittanceDataSetTableName { get; set; } = "";
        

[Description("Used only when Optical Data Type = SpectralAndAngle")]
[JsonProperty("window_glass_spectral_and_incident_angle_front_reflectance_data_set_table_name")]
public string WindowGlassSpectralAndIncidentAngleFrontReflectanceDataSetTableName { get; set; } = "";
        

[Description("Used only when Optical Data Type = SpectralAndAngle")]
[JsonProperty("window_glass_spectral_and_incident_angle_back_reflectance_data_set_table_name")]
public string WindowGlassSpectralAndIncidentAngleBackReflectanceDataSetTableName { get; set; } = "";
    }
    
    public enum WindowMaterial_Glazing_OpticalDataType
    {
        
        [JsonProperty("BSDF")]
        BSDF = 0,
        
        [JsonProperty("Spectral")]
        Spectral = 1,
        
        [JsonProperty("SpectralAndAngle")]
        SpectralAndAngle = 2,
        
        [JsonProperty("SpectralAverage")]
        SpectralAverage = 3,
    }
    
    [Description("thermochromic glass at different temperatures")]
    [JsonObject("WindowMaterial:GlazingGroup:Thermochromic")]
    public class WindowMaterial_GlazingGroup_Thermochromic : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("temperature_data")]
public string TemperatureData { get; set; } = "";
    }
    
    [Description("Glass material properties for Windows or Glass Doors Index of Refraction/Extincti" +
        "on Coefficient input method Not to be used for coated glass")]
    [JsonObject("WindowMaterial:Glazing:RefractionExtinctionMethod")]
    public class WindowMaterial_Glazing_RefractionExtinctionMethod : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[JsonProperty("solar_index_of_refraction")]
public System.Nullable<float> SolarIndexOfRefraction { get; set; } = null;
        

[JsonProperty("solar_extinction_coefficient")]
public System.Nullable<float> SolarExtinctionCoefficient { get; set; } = null;
        

[JsonProperty("visible_index_of_refraction")]
public System.Nullable<float> VisibleIndexOfRefraction { get; set; } = null;
        

[JsonProperty("visible_extinction_coefficient")]
public System.Nullable<float> VisibleExtinctionCoefficient { get; set; } = null;
        

[JsonProperty("infrared_transmittance_at_normal_incidence")]
public System.Nullable<float> InfraredTransmittanceAtNormalIncidence { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Emissivity of front and back side assumed equal")]
[JsonProperty("infrared_hemispherical_emissivity")]
public System.Nullable<float> InfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[JsonProperty("conductivity")]
public System.Nullable<float> Conductivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("dirt_correction_factor_for_solar_and_visible_transmittance")]
public System.Nullable<float> DirtCorrectionFactorForSolarAndVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("solar_diffusing")]
public EmptyNoYes SolarDiffusing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
    
    [Description("Gas material properties that are used in Windows or Glass Doors")]
    [JsonObject("WindowMaterial:Gas")]
    public class WindowMaterial_Gas : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("gas_type")]
public WindowMaterial_Gas_GasType GasType { get; set; } = (WindowMaterial_Gas_GasType)Enum.Parse(typeof(WindowMaterial_Gas_GasType), "Air");
        

[JsonProperty("thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("conductivity_coefficient_a")]
public System.Nullable<float> ConductivityCoefficientA { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("conductivity_coefficient_b")]
public System.Nullable<float> ConductivityCoefficientB { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("conductivity_coefficient_c")]
public System.Nullable<float> ConductivityCoefficientC { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("viscosity_coefficient_a")]
public System.Nullable<float> ViscosityCoefficientA { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("viscosity_coefficient_b")]
public System.Nullable<float> ViscosityCoefficientB { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("viscosity_coefficient_c")]
public System.Nullable<float> ViscosityCoefficientC { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("specific_heat_coefficient_a")]
public System.Nullable<float> SpecificHeatCoefficientA { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("specific_heat_coefficient_b")]
public System.Nullable<float> SpecificHeatCoefficientB { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("specific_heat_coefficient_c")]
public System.Nullable<float> SpecificHeatCoefficientC { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("molecular_weight")]
public System.Nullable<float> MolecularWeight { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("specific_heat_ratio")]
public System.Nullable<float> SpecificHeatRatio { get; set; } = null;
    }
    
    public enum WindowMaterial_Gas_GasType
    {
        
        [JsonProperty("Air")]
        Air = 0,
        
        [JsonProperty("Argon")]
        Argon = 1,
        
        [JsonProperty("Custom")]
        Custom = 2,
        
        [JsonProperty("Krypton")]
        Krypton = 3,
        
        [JsonProperty("Xenon")]
        Xenon = 4,
    }
    
    [Description("used to define pillar geometry for support pillars")]
    [JsonObject("WindowGap:SupportPillar")]
    public class WindowGap_SupportPillar : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("spacing")]
public System.Nullable<float> Spacing { get; set; } = (System.Nullable<float>)Single.Parse("0.04", CultureInfo.InvariantCulture);
        

[JsonProperty("radius")]
public System.Nullable<float> Radius { get; set; } = (System.Nullable<float>)Single.Parse("0.0004", CultureInfo.InvariantCulture);
    }
    
    [Description("Used to enter data describing deflection state of the gap. It is referenced from " +
        "WindowMaterial:Gap object only and it is used only when deflection model is set " +
        "to MeasuredDeflection, otherwise it is ignored.")]
    [JsonObject("WindowGap:DeflectionState")]
    public class WindowGap_DeflectionState : BHoMObject, IEnergyPlusClass
    {
        

[Description("If left blank will be considered that gap has no deflection.")]
[JsonProperty("deflected_thickness")]
public System.Nullable<float> DeflectedThickness { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("initial_temperature")]
public System.Nullable<float> InitialTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25", CultureInfo.InvariantCulture);
        

[JsonProperty("initial_pressure")]
public System.Nullable<float> InitialPressure { get; set; } = (System.Nullable<float>)Single.Parse("101325", CultureInfo.InvariantCulture);
    }
    
    [Description("Gas mixtures that are used in Windows or Glass Doors")]
    [JsonObject("WindowMaterial:GasMixture")]
    public class WindowMaterial_GasMixture : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[JsonProperty("number_of_gases_in_mixture")]
public System.Nullable<float> NumberOfGasesInMixture { get; set; } = null;
        

[JsonProperty("gas_1_type")]
public WindowMaterial_GasMixture_Gas1Type Gas1Type { get; set; } = (WindowMaterial_GasMixture_Gas1Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas1Type), "Air");
        

[JsonProperty("gas_1_fraction")]
public System.Nullable<float> Gas1Fraction { get; set; } = null;
        

[JsonProperty("gas_2_type")]
public WindowMaterial_GasMixture_Gas2Type Gas2Type { get; set; } = (WindowMaterial_GasMixture_Gas2Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas2Type), "Air");
        

[JsonProperty("gas_2_fraction")]
public System.Nullable<float> Gas2Fraction { get; set; } = null;
        

[JsonProperty("gas_3_type")]
public WindowMaterial_GasMixture_Gas3Type Gas3Type { get; set; } = (WindowMaterial_GasMixture_Gas3Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas3Type), "Air");
        

[JsonProperty("gas_3_fraction")]
public System.Nullable<float> Gas3Fraction { get; set; } = null;
        

[JsonProperty("gas_4_type")]
public WindowMaterial_GasMixture_Gas4Type Gas4Type { get; set; } = (WindowMaterial_GasMixture_Gas4Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas4Type), "Air");
        

[JsonProperty("gas_4_fraction")]
public System.Nullable<float> Gas4Fraction { get; set; } = null;
    }
    
    public enum WindowMaterial_GasMixture_Gas1Type
    {
        
        [JsonProperty("Air")]
        Air = 0,
        
        [JsonProperty("Argon")]
        Argon = 1,
        
        [JsonProperty("Krypton")]
        Krypton = 2,
        
        [JsonProperty("Xenon")]
        Xenon = 3,
    }
    
    public enum WindowMaterial_GasMixture_Gas2Type
    {
        
        [JsonProperty("Air")]
        Air = 0,
        
        [JsonProperty("Argon")]
        Argon = 1,
        
        [JsonProperty("Krypton")]
        Krypton = 2,
        
        [JsonProperty("Xenon")]
        Xenon = 3,
    }
    
    public enum WindowMaterial_GasMixture_Gas3Type
    {
        
        [JsonProperty("Air")]
        Air = 0,
        
        [JsonProperty("Argon")]
        Argon = 1,
        
        [JsonProperty("Krypton")]
        Krypton = 2,
        
        [JsonProperty("Xenon")]
        Xenon = 3,
    }
    
    public enum WindowMaterial_GasMixture_Gas4Type
    {
        
        [JsonProperty("Air")]
        Air = 0,
        
        [JsonProperty("Argon")]
        Argon = 1,
        
        [JsonProperty("Krypton")]
        Krypton = 2,
        
        [JsonProperty("Xenon")]
        Xenon = 3,
    }
    
    [Description(@"Used to define the gap between two layers in a complex fenestration system, where the Construction:ComplexFenestrationState object is used. It is referenced as a layer in the Construction:ComplexFenestrationState object. It cannot be referenced as a layer from the Construction object.")]
    [JsonObject("WindowMaterial:Gap")]
    public class WindowMaterial_Gap : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[Description("This field should reference only WindowMaterial:Gas or WindowMaterial:GasMixture " +
    "objects")]
[JsonProperty("gas_or_gas_mixture_")]
public string GasOrGasMixture { get; set; } = "";
        

[JsonProperty("pressure")]
public System.Nullable<float> Pressure { get; set; } = (System.Nullable<float>)Single.Parse("101325", CultureInfo.InvariantCulture);
        

[Description("If left blank, it will be considered that gap is not deflected")]
[JsonProperty("deflection_state")]
public string DeflectionState { get; set; } = "";
        

[Description("If left blank, it will be considered that gap does not have support pillars")]
[JsonProperty("support_pillar")]
public string SupportPillar { get; set; } = "";
    }
    
    [Description(@"Specifies the properties of window shade materials. Reflectance and emissivity properties are assumed to be the same on both sides of the shade. Shades are considered to be perfect diffusers (all transmitted and reflected radiation is hemispherically-diffuse) independent of angle of incidence.")]
    [JsonObject("WindowMaterial:Shade")]
    public class WindowMaterial_Shade : BHoMObject, IEnergyPlusClass
    {
        

[Description("Assumed independent of incidence angle")]
[JsonProperty("solar_transmittance")]
public System.Nullable<float> SolarTransmittance { get; set; } = null;
        

[Description("Assumed same for both sides Assumed independent of incidence angle")]
[JsonProperty("solar_reflectance")]
public System.Nullable<float> SolarReflectance { get; set; } = null;
        

[Description("Assumed independent of incidence angle")]
[JsonProperty("visible_transmittance")]
public System.Nullable<float> VisibleTransmittance { get; set; } = null;
        

[Description("Assumed same for both sides Assumed independent of incidence angle")]
[JsonProperty("visible_reflectance")]
public System.Nullable<float> VisibleReflectance { get; set; } = null;
        

[JsonProperty("infrared_hemispherical_emissivity")]
public System.Nullable<float> InfraredHemisphericalEmissivity { get; set; } = null;
        

[JsonProperty("infrared_transmittance")]
public System.Nullable<float> InfraredTransmittance { get; set; } = null;
        

[JsonProperty("thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[JsonProperty("conductivity")]
public System.Nullable<float> Conductivity { get; set; } = null;
        

[JsonProperty("shade_to_glass_distance")]
public System.Nullable<float> ShadeToGlassDistance { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

[JsonProperty("top_opening_multiplier")]
public System.Nullable<float> TopOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty("bottom_opening_multiplier")]
public System.Nullable<float> BottomOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty("left_side_opening_multiplier")]
public System.Nullable<float> LeftSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty("right_side_opening_multiplier")]
public System.Nullable<float> RightSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty("airflow_permeability")]
public System.Nullable<float> AirflowPermeability { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description("Complex window shading layer thermal properties")]
    [JsonObject("WindowMaterial:ComplexShade")]
    public class WindowMaterial_ComplexShade : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("layer_type")]
public WindowMaterial_ComplexShade_LayerType LayerType { get; set; } = (WindowMaterial_ComplexShade_LayerType)Enum.Parse(typeof(WindowMaterial_ComplexShade_LayerType), "OtherShadingType");
        

[JsonProperty("thickness")]
public System.Nullable<float> Thickness { get; set; } = (System.Nullable<float>)Single.Parse("0.002", CultureInfo.InvariantCulture);
        

[JsonProperty("conductivity")]
public System.Nullable<float> Conductivity { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("ir_transmittance")]
public System.Nullable<float> IrTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("front_emissivity")]
public System.Nullable<float> FrontEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[JsonProperty("back_emissivity")]
public System.Nullable<float> BackEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[JsonProperty("top_opening_multiplier")]
public System.Nullable<float> TopOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("bottom_opening_multiplier")]
public System.Nullable<float> BottomOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("left_side_opening_multiplier")]
public System.Nullable<float> LeftSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("right_side_opening_multiplier")]
public System.Nullable<float> RightSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("front_opening_multiplier")]
public System.Nullable<float> FrontOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

[JsonProperty("slat_width")]
public System.Nullable<float> SlatWidth { get; set; } = (System.Nullable<float>)Single.Parse("0.016", CultureInfo.InvariantCulture);
        

[Description("Distance between adjacent slat faces")]
[JsonProperty("slat_spacing")]
public System.Nullable<float> SlatSpacing { get; set; } = (System.Nullable<float>)Single.Parse("0.012", CultureInfo.InvariantCulture);
        

[Description("Distance between top and bottom surfaces of slat Slat is assumed to be rectangula" +
    "r in cross section and flat")]
[JsonProperty("slat_thickness")]
public System.Nullable<float> SlatThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.0006", CultureInfo.InvariantCulture);
        

[JsonProperty("slat_angle")]
public System.Nullable<float> SlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

[JsonProperty("slat_conductivity")]
public System.Nullable<float> SlatConductivity { get; set; } = (System.Nullable<float>)Single.Parse("160", CultureInfo.InvariantCulture);
        

[Description("this value represents curvature radius of the slat. if the slat is flat use zero." +
    " if this value is not zero, then it must be > SlatWidth/2.")]
[JsonProperty("slat_curve")]
public System.Nullable<float> SlatCurve { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    public enum WindowMaterial_ComplexShade_LayerType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BSDF")]
        BSDF = 1,
        
        [JsonProperty("OtherShadingType")]
        OtherShadingType = 2,
        
        [JsonProperty("Perforated")]
        Perforated = 3,
        
        [JsonProperty("VenetianHorizontal")]
        VenetianHorizontal = 4,
        
        [JsonProperty("VenetianVertical")]
        VenetianVertical = 5,
        
        [JsonProperty("Woven")]
        Woven = 6,
    }
    
    [Description("Window blind thermal properties")]
    [JsonObject("WindowMaterial:Blind")]
    public class WindowMaterial_Blind : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("slat_orientation")]
public WindowMaterial_Blind_SlatOrientation SlatOrientation { get; set; } = (WindowMaterial_Blind_SlatOrientation)Enum.Parse(typeof(WindowMaterial_Blind_SlatOrientation), "Horizontal");
        

[JsonProperty("slat_width")]
public System.Nullable<float> SlatWidth { get; set; } = null;
        

[Description("Distance between adjacent slat faces")]
[JsonProperty("slat_separation")]
public System.Nullable<float> SlatSeparation { get; set; } = null;
        

[Description("Distance between top and bottom surfaces of slat Slat is assumed to be rectangula" +
    "r in cross section and flat")]
[JsonProperty("slat_thickness")]
public System.Nullable<float> SlatThickness { get; set; } = (System.Nullable<float>)Single.Parse("0.00025", CultureInfo.InvariantCulture);
        

[Description(@"If WindowShadingControl referencing the window that incorporates this blind has Type of Slat Angle Control for Blinds = FixedSlatAngle, then this is the fixed value of the slat angle; If WindowShadingControl referencing the window that incorporates this blind has Type of Slat Angle Control for Blinds = BlockBeamSolar, then this is the slat angle when slat angle control is not in effect (e.g., when there is no beam solar on the blind); Not used if WindowShadingControl referencing the window that incorporates this blind has Type of Slat Angle Control for Blinds = ScheduledSlatAngle.")]
[JsonProperty("slat_angle")]
public System.Nullable<float> SlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("45", CultureInfo.InvariantCulture);
        

[Description("default is for aluminum")]
[JsonProperty("slat_conductivity")]
public System.Nullable<float> SlatConductivity { get; set; } = (System.Nullable<float>)Single.Parse("221", CultureInfo.InvariantCulture);
        

[JsonProperty("slat_beam_solar_transmittance")]
public System.Nullable<float> SlatBeamSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("front_side_slat_beam_solar_reflectance")]
public System.Nullable<float> FrontSideSlatBeamSolarReflectance { get; set; } = null;
        

[JsonProperty("back_side_slat_beam_solar_reflectance")]
public System.Nullable<float> BackSideSlatBeamSolarReflectance { get; set; } = null;
        

[Description("Must equal \"Slat beam solar transmittance\"")]
[JsonProperty("slat_diffuse_solar_transmittance")]
public System.Nullable<float> SlatDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Must equal \"Front Side Slat Beam Solar Reflectance\"")]
[JsonProperty("front_side_slat_diffuse_solar_reflectance")]
public System.Nullable<float> FrontSideSlatDiffuseSolarReflectance { get; set; } = null;
        

[Description("Must equal \"Back Side Slat Beam Solar Reflectance\"")]
[JsonProperty("back_side_slat_diffuse_solar_reflectance")]
public System.Nullable<float> BackSideSlatDiffuseSolarReflectance { get; set; } = null;
        

[Description("Required for detailed daylighting calculation")]
[JsonProperty("slat_beam_visible_transmittance")]
public System.Nullable<float> SlatBeamVisibleTransmittance { get; set; } = null;
        

[Description("Required for detailed daylighting calculation")]
[JsonProperty("front_side_slat_beam_visible_reflectance")]
public System.Nullable<float> FrontSideSlatBeamVisibleReflectance { get; set; } = null;
        

[Description("Required for detailed daylighting calculation")]
[JsonProperty("back_side_slat_beam_visible_reflectance")]
public System.Nullable<float> BackSideSlatBeamVisibleReflectance { get; set; } = null;
        

[Description("Used only for detailed daylighting calculation Must equal \"Slat Beam Visible Tran" +
    "smittance\"")]
[JsonProperty("slat_diffuse_visible_transmittance")]
public System.Nullable<float> SlatDiffuseVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Required for detailed daylighting calculation Must equal \"Front Side Slat Beam Vi" +
    "sible Reflectance\"")]
[JsonProperty("front_side_slat_diffuse_visible_reflectance")]
public System.Nullable<float> FrontSideSlatDiffuseVisibleReflectance { get; set; } = null;
        

[Description("Required for detailed daylighting calculation Must equal \"Back Side Slat Beam Vis" +
    "ible Reflectance\"")]
[JsonProperty("back_side_slat_diffuse_visible_reflectance")]
public System.Nullable<float> BackSideSlatDiffuseVisibleReflectance { get; set; } = null;
        

[JsonProperty("slat_infrared_hemispherical_transmittance")]
public System.Nullable<float> SlatInfraredHemisphericalTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("front_side_slat_infrared_hemispherical_emissivity")]
public System.Nullable<float> FrontSideSlatInfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("back_side_slat_infrared_hemispherical_emissivity")]
public System.Nullable<float> BackSideSlatInfraredHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[JsonProperty("blind_to_glass_distance")]
public System.Nullable<float> BlindToGlassDistance { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

[JsonProperty("blind_top_opening_multiplier")]
public System.Nullable<float> BlindTopOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty("blind_bottom_opening_multiplier")]
public System.Nullable<float> BlindBottomOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("blind_left_side_opening_multiplier")]
public System.Nullable<float> BlindLeftSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[JsonProperty("blind_right_side_opening_multiplier")]
public System.Nullable<float> BlindRightSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("Used only if WindowShadingControl referencing the window that incorporates this b" +
    "lind varies the slat angle (i.e., WindowShadingControl with Type of Slat Angle C" +
    "ontrol for Blinds = ScheduledSlatAngle or BlockBeamSolar)")]
[JsonProperty("minimum_slat_angle")]
public System.Nullable<float> MinimumSlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only if WindowShadingControl referencing the window that incorporates this b" +
    "lind varies the slat angle (i.e., WindowShadingControl with Type of Slat Angle C" +
    "ontrol for Blinds = ScheduledSlatAngle or BlockBeamSolar)")]
[JsonProperty("maximum_slat_angle")]
public System.Nullable<float> MaximumSlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("180", CultureInfo.InvariantCulture);
    }
    
    public enum WindowMaterial_Blind_SlatOrientation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Horizontal")]
        Horizontal = 1,
        
        [JsonProperty("Vertical")]
        Vertical = 2,
    }
    
    [Description("Window screen physical properties. Can only be located on the exterior side of a " +
        "window construction.")]
    [JsonObject("WindowMaterial:Screen")]
    public class WindowMaterial_Screen : BHoMObject, IEnergyPlusClass
    {
        

[Description("Select the method used to account for the beam solar reflected off the material s" +
    "urface.")]
[JsonProperty("reflected_beam_transmittance_accounting_method")]
public WindowMaterial_Screen_ReflectedBeamTransmittanceAccountingMethod ReflectedBeamTransmittanceAccountingMethod { get; set; } = (WindowMaterial_Screen_ReflectedBeamTransmittanceAccountingMethod)Enum.Parse(typeof(WindowMaterial_Screen_ReflectedBeamTransmittanceAccountingMethod), "ModelAsDiffuse");
        

[Description("Diffuse reflectance of the screen material over the entire solar radiation spectr" +
    "um. Assumed to be the same for both sides of the screen.")]
[JsonProperty("diffuse_solar_reflectance")]
public System.Nullable<float> DiffuseSolarReflectance { get; set; } = null;
        

[Description("Diffuse visible reflectance of the screen material averaged over the solar spectr" +
    "um and weighted by the response of the human eye. Assumed to be the same for bot" +
    "h sides of the screen.")]
[JsonProperty("diffuse_visible_reflectance")]
public System.Nullable<float> DiffuseVisibleReflectance { get; set; } = null;
        

[Description("Long-wave emissivity of the screen material. Assumed to be the same for both side" +
    "s of the screen.")]
[JsonProperty("thermal_hemispherical_emissivity")]
public System.Nullable<float> ThermalHemisphericalEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Thermal conductivity of the screen material. Default is for aluminum.")]
[JsonProperty("conductivity")]
public System.Nullable<float> Conductivity { get; set; } = (System.Nullable<float>)Single.Parse("221", CultureInfo.InvariantCulture);
        

[Description("Spacing assumed to be the same in both directions.")]
[JsonProperty("screen_material_spacing")]
public System.Nullable<float> ScreenMaterialSpacing { get; set; } = null;
        

[Description("Diameter assumed to be the same in both directions.")]
[JsonProperty("screen_material_diameter")]
public System.Nullable<float> ScreenMaterialDiameter { get; set; } = null;
        

[Description("Distance from the window screen to the adjacent glass surface.")]
[JsonProperty("screen_to_glass_distance")]
public System.Nullable<float> ScreenToGlassDistance { get; set; } = (System.Nullable<float>)Single.Parse("0.025", CultureInfo.InvariantCulture);
        

[Description("Effective area for air flow at the top of the screen divided by the perpendicular" +
    " area between the glass and the top of the screen.")]
[JsonProperty("top_opening_multiplier")]
public System.Nullable<float> TopOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Effective area for air flow at the bottom of the screen divided by the perpendicu" +
    "lar area between the glass and the bottom of the screen.")]
[JsonProperty("bottom_opening_multiplier")]
public System.Nullable<float> BottomOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Effective area for air flow at the left side of the screen divided by the perpend" +
    "icular area between the glass and the left side of the screen.")]
[JsonProperty("left_side_opening_multiplier")]
public System.Nullable<float> LeftSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Effective area for air flow at the right side of the screen divided by the perpen" +
    "dicular area between the glass and the right side of the screen.")]
[JsonProperty("right_side_opening_multiplier")]
public System.Nullable<float> RightSideOpeningMultiplier { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Select the resolution of azimuth and altitude angles for the screen transmittance" +
    " map. A value of 0 means no transmittance map will be generated. Valid values fo" +
    "r this field are 0, 1, 2, 3 and 5.")]
[JsonProperty("angle_of_resolution_for_screen_transmittance_output_map")]
public string AngleOfResolutionForScreenTransmittanceOutputMap { get; set; } = (System.String)"0";
    }
    
    public enum WindowMaterial_Screen_ReflectedBeamTransmittanceAccountingMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("DoNotModel")]
        DoNotModel = 1,
        
        [JsonProperty("ModelAsDiffuse")]
        ModelAsDiffuse = 2,
        
        [JsonProperty("ModelAsDirectBeam")]
        ModelAsDirectBeam = 3,
    }
    
    [Description("Specifies the properties of equivalent layer window shade material Shades are con" +
        "sidered to be perfect diffusers (all transmitted and reflected radiation is hemi" +
        "spherically-diffuse) independent of angle of incidence. Shade represents roller " +
        "blinds.")]
    [JsonObject("WindowMaterial:Shade:EquivalentLayer")]
    public class WindowMaterial_Shade_EquivalentLayer : BHoMObject, IEnergyPlusClass
    {
        

[Description("The beam-beam solar transmittance at normal incidence. This value is the same as " +
    "the openness area fraction of the shade material. Assumed to be the same for fro" +
    "nt and back sides.")]
[JsonProperty("shade_beam_beam_solar_transmittance")]
public System.Nullable<float> ShadeBeamBeamSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The front side beam-diffuse solar transmittance at normal incidence averaged over" +
    " the entire spectrum of solar radiation.")]
[JsonProperty("front_side_shade_beam_diffuse_solar_transmittance")]
public System.Nullable<float> FrontSideShadeBeamDiffuseSolarTransmittance { get; set; } = null;
        

[Description("The back side beam-diffuse solar transmittance at normal incidence averaged over " +
    "the entire spectrum of solar radiation.")]
[JsonProperty("back_side_shade_beam_diffuse_solar_transmittance")]
public System.Nullable<float> BackSideShadeBeamDiffuseSolarTransmittance { get; set; } = null;
        

[Description("The front side beam-diffuse solar reflectance at normal incidence averaged over t" +
    "he entire spectrum of solar radiation.")]
[JsonProperty("front_side_shade_beam_diffuse_solar_reflectance")]
public System.Nullable<float> FrontSideShadeBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The back side beam-diffuse solar reflectance at normal incidence averaged over th" +
    "e entire spectrum of solar radiation.")]
[JsonProperty("back_side_shade_beam_diffuse_solar_reflectance")]
public System.Nullable<float> BackSideShadeBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The beam-beam visible transmittance at normal incidence averaged over the visible" +
    " spectrum range of solar radiation. Assumed to be the same for front and back si" +
    "des of the shade.")]
[JsonProperty("shade_beam_beam_visible_transmittance_at_normal_incidence")]
public System.Nullable<float> ShadeBeamBeamVisibleTransmittanceAtNormalIncidence { get; set; } = null;
        

[Description("The beam-diffuse visible transmittance at normal incidence averaged over the visi" +
    "ble spectrum range of solar radiation. Assumed to be the same for front and back" +
    " sides of the shade.")]
[JsonProperty("shade_beam_diffuse_visible_transmittance_at_normal_incidence")]
public System.Nullable<float> ShadeBeamDiffuseVisibleTransmittanceAtNormalIncidence { get; set; } = null;
        

[Description("The beam-diffuse visible reflectance at normal incidence averaged over the visibl" +
    "e spectrum range of solar radiation. Assumed to be the same for front and back s" +
    "ides of the shade.")]
[JsonProperty("shade_beam_diffuse_visible_reflectance_at_normal_incidence")]
public System.Nullable<float> ShadeBeamDiffuseVisibleReflectanceAtNormalIncidence { get; set; } = null;
        

[Description("The long-wave transmittance of the shade material at zero shade openness. Assumed" +
    " to be the same for front and back sides of the shade.")]
[JsonProperty("shade_material_infrared_transmittance")]
public System.Nullable<float> ShadeMaterialInfraredTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

[Description("The front side long-wave emissivity of the shade material at zero shade openness." +
    " Openness fraction is used to calculate the effective emissivity value.")]
[JsonProperty("front_side_shade_material_infrared_emissivity")]
public System.Nullable<float> FrontSideShadeMaterialInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.91", CultureInfo.InvariantCulture);
        

[Description("The back side long-wave emissivity of the shade material at zero shade openness. " +
    "Openness fraction is used to calculate the effective emissivity value.")]
[JsonProperty("back_side_shade_material_infrared_emissivity")]
public System.Nullable<float> BackSideShadeMaterialInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.91", CultureInfo.InvariantCulture);
    }
    
    [Description(@"Specifies the properties of equivalent layer drape fabric materials. Shades are considered to be perfect diffusers (all transmitted and reflected radiation is hemispherically-diffuse) independent of angle of incidence. unpleated drape fabric is treated as thin and flat layer.")]
    [JsonObject("WindowMaterial:Drape:EquivalentLayer")]
    public class WindowMaterial_Drape_EquivalentLayer : BHoMObject, IEnergyPlusClass
    {
        

[Description("The beam-beam solar transmittance at normal incidence. This value is the same as " +
    "the openness area fraction of the drape fabric. Assumed to be same for front and" +
    " back sides.")]
[JsonProperty("drape_beam_beam_solar_transmittance_at_normal_incidence")]
public System.Nullable<float> DrapeBeamBeamSolarTransmittanceAtNormalIncidence { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The front side beam-diffuse solar transmittance at normal incidence averaged over" +
    " the entire spectrum of solar radiation. Assumed to be the same for front and ba" +
    "ck sides.")]
[JsonProperty("front_side_drape_beam_diffuse_solar_transmittance")]
public System.Nullable<float> FrontSideDrapeBeamDiffuseSolarTransmittance { get; set; } = null;
        

[Description("The back side beam-diffuse solar transmittance at normal incidence averaged over " +
    "the entire spectrum of solar radiation. Assumed to be the same for front and bac" +
    "k sides.")]
[JsonProperty("back_side_drape_beam_diffuse_solar_transmittance")]
public System.Nullable<float> BackSideDrapeBeamDiffuseSolarTransmittance { get; set; } = null;
        

[Description("The front side beam-diffuse solar reflectance at normal incidence averaged over t" +
    "he entire spectrum of solar radiation.")]
[JsonProperty("front_side_drape_beam_diffuse_solar_reflectance")]
public System.Nullable<float> FrontSideDrapeBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The back side beam-diffuse solar reflectance at normal incidence averaged over th" +
    "e entire spectrum of solar radiation.")]
[JsonProperty("back_side_drape_beam_diffuse_solar_reflectance")]
public System.Nullable<float> BackSideDrapeBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The beam-beam visible transmittance at normal incidence averaged over the visible" +
    " spectrum of solar radiation. Assumed same for front and back sides.")]
[JsonProperty("drape_beam_beam_visible_transmittance")]
public System.Nullable<float> DrapeBeamBeamVisibleTransmittance { get; set; } = null;
        

[Description("The beam-diffuse visible transmittance at normal incidence averaged over the visi" +
    "ble spectrum range of solar radiation. Assumed to be the same for front and back" +
    " sides.")]
[JsonProperty("drape_beam_diffuse_visible_transmittance")]
public System.Nullable<float> DrapeBeamDiffuseVisibleTransmittance { get; set; } = null;
        

[Description("The beam-diffuse visible reflectance at normal incidence average over the visible" +
    " spectrum range of solar radiation. Assumed to be the same for front and back si" +
    "des.")]
[JsonProperty("drape_beam_diffuse_visible_reflectance")]
public System.Nullable<float> DrapeBeamDiffuseVisibleReflectance { get; set; } = null;
        

[Description("Long-wave transmittance of the drape fabric at zero openness fraction. Assumed sa" +
    "me for front and back sides.")]
[JsonProperty("drape_material_infrared_transmittance")]
public System.Nullable<float> DrapeMaterialInfraredTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0.05", CultureInfo.InvariantCulture);
        

[Description("Front side long-wave emissivity of the drape fabric at zero shade openness. Openn" +
    "ess fraction specified above is used to calculate the effective emissivity value" +
    ".")]
[JsonProperty("front_side_drape_material_infrared_emissivity")]
public System.Nullable<float> FrontSideDrapeMaterialInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.87", CultureInfo.InvariantCulture);
        

[Description("Back side long-wave emissivity of the drape fabric at zero shade openness. Openne" +
    "ss fraction specified above is used to calculate the effective emissivity value." +
    "")]
[JsonProperty("back_side_drape_material_infrared_emissivity")]
public System.Nullable<float> BackSideDrapeMaterialInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.87", CultureInfo.InvariantCulture);
        

[Description("Width of the pleated section of the draped fabric. If the drape fabric is unpleat" +
    "ed or is flat, then the pleated section width is set to zero.")]
[JsonProperty("width_of_pleated_fabric")]
public System.Nullable<float> WidthOfPleatedFabric { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Length of the pleated section of the draped fabric. If the drape fabric is unplea" +
    "ted or is flat, then the pleated section length is set to zero.")]
[JsonProperty("length_of_pleated_fabric")]
public System.Nullable<float> LengthOfPleatedFabric { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description("Window equivalent layer blind slat optical and thermal properties. The model assu" +
        "mes that slats are thin and flat, applies correction empirical correlation to ac" +
        "count for curvature effect. Slats are assumed to transmit and reflect diffusely." +
        "")]
    [JsonObject("WindowMaterial:Blind:EquivalentLayer")]
    public class WindowMaterial_Blind_EquivalentLayer : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("slat_orientation")]
public WindowMaterial_Blind_EquivalentLayer_SlatOrientation SlatOrientation { get; set; } = (WindowMaterial_Blind_EquivalentLayer_SlatOrientation)Enum.Parse(typeof(WindowMaterial_Blind_EquivalentLayer_SlatOrientation), "Horizontal");
        

[JsonProperty("slat_width")]
public System.Nullable<float> SlatWidth { get; set; } = null;
        

[Description("Distance between adjacent slat faces")]
[JsonProperty("slat_separation")]
public System.Nullable<float> SlatSeparation { get; set; } = null;
        

[Description("Perpendicular length between the cord and the curve. Slat is assumed to be rectan" +
    "gular in cross section and flat. Crown=0.0625x\"Slat width\"")]
[JsonProperty("slat_crown")]
public System.Nullable<float> SlatCrown { get; set; } = (System.Nullable<float>)Single.Parse("0.0015", CultureInfo.InvariantCulture);
        

[Description("Slat angle is +ve if the tip of the slat front face is tilted upward, else the sl" +
    "at angle is -ve if the tip of the slat front face is tilted downward. The slat a" +
    "ngle varies between -90 to +90. The default value is 45 degrees.")]
[JsonProperty("slat_angle")]
public System.Nullable<float> SlatAngle { get; set; } = (System.Nullable<float>)Single.Parse("45", CultureInfo.InvariantCulture);
        

[Description("The front side beam-diffuse solar transmittance of the slat at normal incidence a" +
    "veraged over the entire spectrum of solar radiation.")]
[JsonProperty("front_side_slat_beam_diffuse_solar_transmittance")]
public System.Nullable<float> FrontSideSlatBeamDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The back side beam-diffuse solar transmittance of the slat at normal incidence av" +
    "eraged over the entire spectrum of solar radiation.")]
[JsonProperty("back_side_slat_beam_diffuse_solar_transmittance")]
public System.Nullable<float> BackSideSlatBeamDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The front side beam-diffuse solar reflectance of the slat at normal incidence ave" +
    "raged over the entire spectrum of solar radiation.")]
[JsonProperty("front_side_slat_beam_diffuse_solar_reflectance")]
public System.Nullable<float> FrontSideSlatBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The back side beam-diffuse solar reflectance of the slat at normal incidence aver" +
    "aged over the entire spectrum of solar radiation.")]
[JsonProperty("back_side_slat_beam_diffuse_solar_reflectance")]
public System.Nullable<float> BackSideSlatBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The front side beam-diffuse visible transmittance of the slat at normal incidence" +
    " averaged over the visible spectrum range of solar radiation.")]
[JsonProperty("front_side_slat_beam_diffuse_visible_transmittance")]
public System.Nullable<float> FrontSideSlatBeamDiffuseVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The back side beam-diffuse visible transmittance of the slat at normal incidence " +
    "averaged over the visible spectrum range of solar radiation.")]
[JsonProperty("back_side_slat_beam_diffuse_visible_transmittance")]
public System.Nullable<float> BackSideSlatBeamDiffuseVisibleTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The front side beam-diffuse visible reflectance of the slat at normal incidence a" +
    "veraged over the visible spectrum range of solar radiation.")]
[JsonProperty("front_side_slat_beam_diffuse_visible_reflectance")]
public System.Nullable<float> FrontSideSlatBeamDiffuseVisibleReflectance { get; set; } = null;
        

[Description("The back side beam-diffuse visible reflectance of the slat at normal incidence av" +
    "eraged over the visible spectrum range of solar radiation.")]
[JsonProperty("back_side_slat_beam_diffuse_visible_reflectance")]
public System.Nullable<float> BackSideSlatBeamDiffuseVisibleReflectance { get; set; } = null;
        

[Description("The beam-diffuse solar transmittance of the slat averaged over the entire solar s" +
    "pectrum of solar radiation.")]
[JsonProperty("slat_diffuse_diffuse_solar_transmittance")]
public System.Nullable<float> SlatDiffuseDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The front side beam-diffuse solar reflectance of the slat averaged over the entir" +
    "e solar spectrum of solar radiation.")]
[JsonProperty("front_side_slat_diffuse_diffuse_solar_reflectance")]
public System.Nullable<float> FrontSideSlatDiffuseDiffuseSolarReflectance { get; set; } = null;
        

[Description("The back side beam-diffuse solar reflectance of the slat averaged over the entire" +
    " solar spectrum of solar radiation.")]
[JsonProperty("back_side_slat_diffuse_diffuse_solar_reflectance")]
public System.Nullable<float> BackSideSlatDiffuseDiffuseSolarReflectance { get; set; } = null;
        

[Description("The beam-diffuse visible transmittance of the slat averaged over the visible spec" +
    "trum range of solar radiation.")]
[JsonProperty("slat_diffuse_diffuse_visible_transmittance")]
public System.Nullable<float> SlatDiffuseDiffuseVisibleTransmittance { get; set; } = null;
        

[Description("The front side beam-diffuse visible reflectance of the slat averaged over the vis" +
    "ible spectrum range of solar radiation.")]
[JsonProperty("front_side_slat_diffuse_diffuse_visible_reflectance")]
public System.Nullable<float> FrontSideSlatDiffuseDiffuseVisibleReflectance { get; set; } = null;
        

[Description("The back side beam-diffuse visible reflectance of the slat averaged over the visi" +
    "ble spectrum range of solar radiation.")]
[JsonProperty("back_side_slat_diffuse_diffuse_visible_reflectance")]
public System.Nullable<float> BackSideSlatDiffuseDiffuseVisibleReflectance { get; set; } = null;
        

[Description("Long-wave hemispherical transmittance of the slat material. Assumed to be the sam" +
    "e for both sides of the slat.")]
[JsonProperty("slat_infrared_transmittance")]
public System.Nullable<float> SlatInfraredTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Front side long-wave hemispherical emissivity of the slat material.")]
[JsonProperty("front_side_slat_infrared_emissivity")]
public System.Nullable<float> FrontSideSlatInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description("Back side long-wave hemispherical emissivity of the slat material.")]
[JsonProperty("back_side_slat_infrared_emissivity")]
public System.Nullable<float> BackSideSlatInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.9", CultureInfo.InvariantCulture);
        

[Description(@"Used only if slat angle control is desired to either maximize solar gain (MaximizeSolar), maximize visibility while eliminating beam solar radiation (BlockBeamSolar), or fixed slate angle (FixedSlatAngle). If FixedSlatAngle is selected, the slat angle entered above is used.")]
[JsonProperty("slat_angle_control")]
public WindowMaterial_Blind_EquivalentLayer_SlatAngleControl SlatAngleControl { get; set; } = (WindowMaterial_Blind_EquivalentLayer_SlatAngleControl)Enum.Parse(typeof(WindowMaterial_Blind_EquivalentLayer_SlatAngleControl), "FixedSlatAngle");
    }
    
    public enum WindowMaterial_Blind_EquivalentLayer_SlatOrientation
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Horizontal")]
        Horizontal = 1,
        
        [JsonProperty("Vertical")]
        Vertical = 2,
    }
    
    public enum WindowMaterial_Blind_EquivalentLayer_SlatAngleControl
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BlockBeamSolar")]
        BlockBeamSolar = 1,
        
        [JsonProperty("FixedSlatAngle")]
        FixedSlatAngle = 2,
        
        [JsonProperty("MaximizeSolar")]
        MaximizeSolar = 3,
    }
    
    [Description("Equivalent layer window screen physical properties. Can only be located on the ex" +
        "terior side of a window construction.")]
    [JsonObject("WindowMaterial:Screen:EquivalentLayer")]
    public class WindowMaterial_Screen_EquivalentLayer : BHoMObject, IEnergyPlusClass
    {
        

[Description(@"The beam-beam transmittance of the screen material at normal incidence. This input field is the same as the material openness area fraction and can be autocalculated from the wire spacing and wire and diameter. Assumed to be the same for both sides of the screen.")]
[JsonProperty("screen_beam_beam_solar_transmittance")]
public string ScreenBeamBeamSolarTransmittance { get; set; } = (System.String)"Autocalculate";
        

[Description("The beam-diffuse solar transmittance of the screen material at normal incidence a" +
    "veraged over the entire spectrum of solar radiation. Assumed to be the same for " +
    "both sides of the screen.")]
[JsonProperty("screen_beam_diffuse_solar_transmittance")]
public System.Nullable<float> ScreenBeamDiffuseSolarTransmittance { get; set; } = null;
        

[Description("The beam-diffuse solar reflectance of the screen material at normal incidence ave" +
    "raged over the entire spectrum of solar radiation. Assumed to be the same for bo" +
    "th sides of the screen.")]
[JsonProperty("screen_beam_diffuse_solar_reflectance")]
public System.Nullable<float> ScreenBeamDiffuseSolarReflectance { get; set; } = null;
        

[Description("The beam-beam visible transmittance of the screen material at normal incidence av" +
    "eraged over the visible spectrum range of solar radiation. Assumed to be the sam" +
    "e for both sides of the screen.")]
[JsonProperty("screen_beam_beam_visible_transmittance")]
public System.Nullable<float> ScreenBeamBeamVisibleTransmittance { get; set; } = null;
        

[Description("The beam-diffuse visible transmittance of the screen material at normal incidence" +
    " averaged over the visible spectrum range of solar radiation. Assumed to be the " +
    "same for both sides of the screen.")]
[JsonProperty("screen_beam_diffuse_visible_transmittance")]
public System.Nullable<float> ScreenBeamDiffuseVisibleTransmittance { get; set; } = null;
        

[Description("Beam-diffuse visible reflectance of the screen material at normal incidence avera" +
    "ged over the visible spectrum range of solar radiation. Assumed to be the same f" +
    "or both sides of the screen.")]
[JsonProperty("screen_beam_diffuse_visible_reflectance")]
public System.Nullable<float> ScreenBeamDiffuseVisibleReflectance { get; set; } = null;
        

[Description("The long-wave hemispherical transmittance of the screen material. Assumed to be t" +
    "he same for both sides of the screen.")]
[JsonProperty("screen_infrared_transmittance")]
public System.Nullable<float> ScreenInfraredTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0.02", CultureInfo.InvariantCulture);
        

[Description("The long-wave hemispherical emissivity of the screen material. Assumed to be the " +
    "same for both sides of the screen.")]
[JsonProperty("screen_infrared_emissivity")]
public System.Nullable<float> ScreenInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.93", CultureInfo.InvariantCulture);
        

[Description("Spacing assumed to be the same in both directions.")]
[JsonProperty("screen_wire_spacing")]
public System.Nullable<float> ScreenWireSpacing { get; set; } = (System.Nullable<float>)Single.Parse("0.025", CultureInfo.InvariantCulture);
        

[Description("Diameter assumed to be the same in both directions.")]
[JsonProperty("screen_wire_diameter")]
public System.Nullable<float> ScreenWireDiameter { get; set; } = (System.Nullable<float>)Single.Parse("0.005", CultureInfo.InvariantCulture);
    }
    
    [Description("Glass material properties for Windows or Glass Doors Transmittance/Reflectance in" +
        "put method.")]
    [JsonObject("WindowMaterial:Glazing:EquivalentLayer")]
    public class WindowMaterial_Glazing_EquivalentLayer : BHoMObject, IEnergyPlusClass
    {
        

[Description("Spectral is not currently supported and SpectralAverage is the default.")]
[JsonProperty("optical_data_type")]
public WindowMaterial_Glazing_EquivalentLayer_OpticalDataType OpticalDataType { get; set; } = (WindowMaterial_Glazing_EquivalentLayer_OpticalDataType)Enum.Parse(typeof(WindowMaterial_Glazing_EquivalentLayer_OpticalDataType), "SpectralAverage");
        

[Description("Spectral data is not currently supported. Used only when Optical Data Type = Spec" +
    "tral")]
[JsonProperty("window_glass_spectral_data_set_name")]
public string WindowGlassSpectralDataSetName { get; set; } = "";
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty("front_side_beam_beam_solar_transmittance")]
public System.Nullable<float> FrontSideBeamBeamSolarTransmittance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty("back_side_beam_beam_solar_transmittance")]
public System.Nullable<float> BackSideBeamBeamSolarTransmittance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
    "outdoor air")]
[JsonProperty("front_side_beam_beam_solar_reflectance")]
public System.Nullable<float> FrontSideBeamBeamSolarReflectance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
    "one air")]
[JsonProperty("back_side_beam_beam_solar_reflectance")]
public System.Nullable<float> BackSideBeamBeamSolarReflectance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty("front_side_beam_beam_visible_solar_transmittance")]
public System.Nullable<float> FrontSideBeamBeamVisibleSolarTransmittance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty("back_side_beam_beam_visible_solar_transmittance")]
public System.Nullable<float> BackSideBeamBeamVisibleSolarTransmittance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
    "outdoor air")]
[JsonProperty("front_side_beam_beam_visible_solar_reflectance")]
public System.Nullable<float> FrontSideBeamBeamVisibleSolarReflectance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
    "one air")]
[JsonProperty("back_side_beam_beam_visible_solar_reflectance")]
public System.Nullable<float> BackSideBeamBeamVisibleSolarReflectance { get; set; } = null;
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty("front_side_beam_diffuse_solar_transmittance")]
public System.Nullable<float> FrontSideBeamDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty("back_side_beam_diffuse_solar_transmittance")]
public System.Nullable<float> BackSideBeamDiffuseSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
    "outdoor air")]
[JsonProperty("front_side_beam_diffuse_solar_reflectance")]
public System.Nullable<float> FrontSideBeamDiffuseSolarReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
    "one air")]
[JsonProperty("back_side_beam_diffuse_solar_reflectance")]
public System.Nullable<float> BackSideBeamDiffuseSolarReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty("front_side_beam_diffuse_visible_solar_transmittance")]
public System.Nullable<float> FrontSideBeamDiffuseVisibleSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage")]
[JsonProperty("back_side_beam_diffuse_visible_solar_transmittance")]
public System.Nullable<float> BackSideBeamDiffuseVisibleSolarTransmittance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
    "outdoor air")]
[JsonProperty("front_side_beam_diffuse_visible_solar_reflectance")]
public System.Nullable<float> FrontSideBeamDiffuseVisibleSolarReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
    "one air")]
[JsonProperty("back_side_beam_diffuse_visible_solar_reflectance")]
public System.Nullable<float> BackSideBeamDiffuseVisibleSolarReflectance { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description(@"Used only when Optical Data Type = SpectralAverage If this field is autocalculate, then the diffuse-diffuse solar transmittance is automatically estimated from other inputs and used in subsequent calculations. If this field is zero or positive, then the value entered here will be used.")]
[JsonProperty("diffuse_diffuse_solar_transmittance")]
public string DiffuseDiffuseSolarTransmittance { get; set; } = (System.String)"Autocalculate";
        

[Description(@"Used only when Optical Data Type = SpectralAverage If this field is autocalculate, then the front diffuse-diffuse solar reflectance is automatically estimated from other inputs and used in subsequent calculations. If this field is zero or positive, then the value entered here will be used. Front Side is side closest to outdoor air.")]
[JsonProperty("front_side_diffuse_diffuse_solar_reflectance")]
public string FrontSideDiffuseDiffuseSolarReflectance { get; set; } = (System.String)"Autocalculate";
        

[Description(@"Used only when Optical Data Type = SpectralAverage If this field is autocalculate, then the back diffuse-diffuse solar reflectance is automatically estimated from other inputs and used in subsequent calculations. If this field is zero or positive, then the value entered here will be used. Back side is side closest to indoor air.")]
[JsonProperty("back_side_diffuse_diffuse_solar_reflectance")]
public string BackSideDiffuseDiffuseSolarReflectance { get; set; } = (System.String)"Autocalculate";
        

[Description("Used only when Optical Data Type = SpectralAverage This input field is not used c" +
    "urrently.")]
[JsonProperty("diffuse_diffuse_visible_solar_transmittance")]
public string DiffuseDiffuseVisibleSolarTransmittance { get; set; } = (System.String)"Autocalculate";
        

[Description("Used only when Optical Data Type = SpectralAverage This input field is not used c" +
    "urrently.")]
[JsonProperty("front_side_diffuse_diffuse_visible_solar_reflectance")]
public string FrontSideDiffuseDiffuseVisibleSolarReflectance { get; set; } = (System.String)"Autocalculate";
        

[Description("Used only when Optical Data Type = SpectralAverage This input field is not used c" +
    "urrently.")]
[JsonProperty("back_side_diffuse_diffuse_visible_solar_reflectance")]
public string BackSideDiffuseDiffuseVisibleSolarReflectance { get; set; } = (System.String)"Autocalculate";
        

[Description("The long-wave hemispherical transmittance of the glazing. Assumed to be the same " +
    "for both sides of the glazing.")]
[JsonProperty("infrared_transmittance_applies_to_front_and_back_")]
public System.Nullable<float> InfraredTransmittanceAppliesToFrontAndBack { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("The front side long-wave hemispherical emissivity of the glazing.")]
[JsonProperty("front_side_infrared_emissivity")]
public System.Nullable<float> FrontSideInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[Description("The back side long-wave hemispherical emissivity of the glazing.")]
[JsonProperty("back_side_infrared_emissivity")]
public System.Nullable<float> BackSideInfraredEmissivity { get; set; } = (System.Nullable<float>)Single.Parse("0.84", CultureInfo.InvariantCulture);
        

[Description("This is the R-Value in SI for the glass. The default value is an approximation fo" +
    "r a single layer of glass at 1/4\" inch thickness. This field is used only for mo" +
    "vable insulation defined with this material type.")]
[JsonProperty("thermal_resistance")]
public System.Nullable<float> ThermalResistance { get; set; } = (System.Nullable<float>)Single.Parse("0.158", CultureInfo.InvariantCulture);
    }
    
    public enum WindowMaterial_Glazing_EquivalentLayer_OpticalDataType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Spectral")]
        Spectral = 1,
        
        [JsonProperty("SpectralAverage")]
        SpectralAverage = 2,
    }
    
    [Description("Gas material properties that are used in Windows Equivalent Layer References only" +
        " WindowMaterial:Gas properties")]
    [JsonObject("WindowMaterial:Gap:EquivalentLayer")]
    public class WindowMaterial_Gap_EquivalentLayer : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("gas_type")]
public WindowMaterial_Gap_EquivalentLayer_GasType GasType { get; set; } = (WindowMaterial_Gap_EquivalentLayer_GasType)Enum.Parse(typeof(WindowMaterial_Gap_EquivalentLayer_GasType), "AIR");
        

[JsonProperty("thickness")]
public System.Nullable<float> Thickness { get; set; } = null;
        

[Description(@"Sealed means the gap is enclosed and gas tight, i.e., no venting to indoor or outdoor environment. VentedIndoor means the gap is vented to indoor environment, and VentedOutdoor means the gap is vented to the outdoor environment. The gap types VentedIndoor and VentedOutdoor are used with gas type ""Air"" only.")]
[JsonProperty("gap_vent_type")]
public WindowMaterial_Gap_EquivalentLayer_GapVentType GapVentType { get; set; } = (WindowMaterial_Gap_EquivalentLayer_GapVentType)Enum.Parse(typeof(WindowMaterial_Gap_EquivalentLayer_GapVentType), "Sealed");
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("conductivity_coefficient_a")]
public System.Nullable<float> ConductivityCoefficientA { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("conductivity_coefficient_b")]
public System.Nullable<float> ConductivityCoefficientB { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("conductivity_coefficient_c")]
public System.Nullable<float> ConductivityCoefficientC { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("viscosity_coefficient_a")]
public System.Nullable<float> ViscosityCoefficientA { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("viscosity_coefficient_b")]
public System.Nullable<float> ViscosityCoefficientB { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("viscosity_coefficient_c")]
public System.Nullable<float> ViscosityCoefficientC { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("specific_heat_coefficient_a")]
public System.Nullable<float> SpecificHeatCoefficientA { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("specific_heat_coefficient_b")]
public System.Nullable<float> SpecificHeatCoefficientB { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("specific_heat_coefficient_c")]
public System.Nullable<float> SpecificHeatCoefficientC { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("molecular_weight")]
public System.Nullable<float> MolecularWeight { get; set; } = null;
        

[Description("Used only if Gas Type = Custom")]
[JsonProperty("specific_heat_ratio")]
public System.Nullable<float> SpecificHeatRatio { get; set; } = null;
    }
    
    public enum WindowMaterial_Gap_EquivalentLayer_GasType
    {
        
        [JsonProperty("AIR")]
        AIR = 0,
        
        [JsonProperty("ARGON")]
        ARGON = 1,
        
        [JsonProperty("CUSTOM")]
        CUSTOM = 2,
        
        [JsonProperty("KRYPTON")]
        KRYPTON = 3,
        
        [JsonProperty("XENON")]
        XENON = 4,
    }
    
    public enum WindowMaterial_Gap_EquivalentLayer_GapVentType
    {
        
        [JsonProperty("Sealed")]
        Sealed = 0,
        
        [JsonProperty("VentedIndoor")]
        VentedIndoor = 1,
        
        [JsonProperty("VentedOutdoor")]
        VentedOutdoor = 2,
    }
    
    [Description("Additional properties for moisture using EMPD procedure HeatBalanceAlgorithm choi" +
        "ce=MoisturePenetrationDepthConductionTransferFunction only Has no effect with ot" +
        "her HeatBalanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:MoisturePenetrationDepth:Settings")]
    public class MaterialProperty_MoisturePenetrationDepth_Settings : BHoMObject, IEnergyPlusClass
    {
        

[Description("Ratio of water vapor permeability of stagnant air to water vapor permeability of " +
    "material")]
[JsonProperty("water_vapor_diffusion_resistance_factor")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor { get; set; } = null;
        

[JsonProperty("moisture_equation_coefficient_a")]
public System.Nullable<float> MoistureEquationCoefficientA { get; set; } = null;
        

[JsonProperty("moisture_equation_coefficient_b")]
public System.Nullable<float> MoistureEquationCoefficientB { get; set; } = null;
        

[JsonProperty("moisture_equation_coefficient_c")]
public System.Nullable<float> MoistureEquationCoefficientC { get; set; } = null;
        

[JsonProperty("moisture_equation_coefficient_d")]
public System.Nullable<float> MoistureEquationCoefficientD { get; set; } = null;
        

[JsonProperty("surface_layer_penetration_depth")]
public string SurfaceLayerPenetrationDepth { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("deep_layer_penetration_depth")]
public string DeepLayerPenetrationDepth { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("coating_layer_thickness")]
public System.Nullable<float> CoatingLayerThickness { get; set; } = null;
        

[Description("The coating\'s resistance to water vapor diffusion relative to the resistance to w" +
    "ater vapor diffusion in stagnant air (see Water Vapor Diffusion Resistance Facto" +
    "r above).")]
[JsonProperty("coating_layer_water_vapor_diffusion_resistance_factor")]
public System.Nullable<float> CoatingLayerWaterVaporDiffusionResistanceFactor { get; set; } = null;
    }
    
    [Description(@"Additional properties for temperature dependent thermal conductivity and enthalpy for Phase Change Materials (PCM) HeatBalanceAlgorithm = CondFD(ConductionFiniteDifference) solution algorithm only. Constructions with this should use the detailed CondFD process. Has no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:PhaseChange")]
    public class MaterialProperty_PhaseChange : BHoMObject, IEnergyPlusClass
    {
        

[Description("The base temperature is 20C. This is the thermal conductivity change per degree e" +
    "xcursion from 20C. This variable conductivity function is overridden by the Vari" +
    "ableThermalConductivity object, if present.")]
[JsonProperty("temperature_coefficient_for_thermal_conductivity")]
public System.Nullable<float> TemperatureCoefficientForThermalConductivity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_1")]
public System.Nullable<float> Temperature1 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 1")]
[JsonProperty("enthalpy_1")]
public System.Nullable<float> Enthalpy1 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_2")]
public System.Nullable<float> Temperature2 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 2")]
[JsonProperty("enthalpy_2")]
public System.Nullable<float> Enthalpy2 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_3")]
public System.Nullable<float> Temperature3 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 3")]
[JsonProperty("enthalpy_3")]
public System.Nullable<float> Enthalpy3 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_4")]
public System.Nullable<float> Temperature4 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 4")]
[JsonProperty("enthalpy_4")]
public System.Nullable<float> Enthalpy4 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_5")]
public System.Nullable<float> Temperature5 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 5")]
[JsonProperty("enthalpy_5")]
public System.Nullable<float> Enthalpy5 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_6")]
public System.Nullable<float> Temperature6 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 6")]
[JsonProperty("enthalpy_6")]
public System.Nullable<float> Enthalpy6 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_7")]
public System.Nullable<float> Temperature7 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 7")]
[JsonProperty("enthalpy_7")]
public System.Nullable<float> Enthalpy7 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_8")]
public System.Nullable<float> Temperature8 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 8")]
[JsonProperty("enthalpy_8")]
public System.Nullable<float> Enthalpy8 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_9")]
public System.Nullable<float> Temperature9 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 1")]
[JsonProperty("enthalpy_9")]
public System.Nullable<float> Enthalpy9 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_10")]
public System.Nullable<float> Temperature10 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 2")]
[JsonProperty("enthalpy_10")]
public System.Nullable<float> Enthalpy10 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_11")]
public System.Nullable<float> Temperature11 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 3")]
[JsonProperty("enthalpy_11")]
public System.Nullable<float> Enthalpy11 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_12")]
public System.Nullable<float> Temperature12 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 14")]
[JsonProperty("enthalpy_12")]
public System.Nullable<float> Enthalpy12 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_13")]
public System.Nullable<float> Temperature13 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 15")]
[JsonProperty("enthalpy_13")]
public System.Nullable<float> Enthalpy13 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_14")]
public System.Nullable<float> Temperature14 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 16")]
[JsonProperty("enthalpy_14")]
public System.Nullable<float> Enthalpy14 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_15")]
public System.Nullable<float> Temperature15 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 17")]
[JsonProperty("enthalpy_15")]
public System.Nullable<float> Enthalpy15 { get; set; } = null;
        

[Description("for Temperature-enthalpy function")]
[JsonProperty("temperature_16")]
public System.Nullable<float> Temperature16 { get; set; } = null;
        

[Description("for Temperature-enthalpy function corresponding to temperature 16")]
[JsonProperty("enthalpy_16")]
public System.Nullable<float> Enthalpy16 { get; set; } = null;
    }
    
    [Description(@"Additional properties for temperature dependent thermal conductivity and enthalpy for Phase Change Materials (PCM) with separate melting and freezing curves. HeatBalanceAlgorithm = CondFD (ConductionFiniteDifference) solution algorithm only. Constructions with this should use the detailed CondFD process. Has no effect with other HeatBalanceAlgorithm solution algorithms.")]
    [JsonObject("MaterialProperty:PhaseChangeHysteresis")]
    public class MaterialProperty_PhaseChangeHysteresis : BHoMObject, IEnergyPlusClass
    {
        

[Description("The total latent heat absorbed or rejected during the transition from solid to li" +
    "quid, or back")]
[JsonProperty("latent_heat_during_the_entire_phase_change_process")]
public System.Nullable<float> LatentHeatDuringTheEntirePhaseChangeProcess { get; set; } = null;
        

[Description("The thermal conductivity used by this material when the material is fully liquid")]
[JsonProperty("liquid_state_thermal_conductivity")]
public System.Nullable<float> LiquidStateThermalConductivity { get; set; } = null;
        

[Description("The density used by this material when the material is fully liquid")]
[JsonProperty("liquid_state_density")]
public System.Nullable<float> LiquidStateDensity { get; set; } = null;
        

[Description("The constant specific heat used for the fully melted (liquid) state")]
[JsonProperty("liquid_state_specific_heat")]
public System.Nullable<float> LiquidStateSpecificHeat { get; set; } = null;
        

[Description("The total melting range of the material is the sum of low and high temperature di" +
    "fference of melting curve.")]
[JsonProperty("high_temperature_difference_of_melting_curve")]
public System.Nullable<float> HighTemperatureDifferenceOfMeltingCurve { get; set; } = null;
        

[Description("The temperature at which the melting curve peaks")]
[JsonProperty("peak_melting_temperature")]
public System.Nullable<float> PeakMeltingTemperature { get; set; } = null;
        

[Description("The total melting range of the material is the sum of low and high temperature di" +
    "fference of melting curve.")]
[JsonProperty("low_temperature_difference_of_melting_curve")]
public System.Nullable<float> LowTemperatureDifferenceOfMeltingCurve { get; set; } = null;
        

[Description("The thermal conductivity used by this material when the material is fully solid")]
[JsonProperty("solid_state_thermal_conductivity")]
public System.Nullable<float> SolidStateThermalConductivity { get; set; } = null;
        

[Description("The density used by this material when the material is fully solid")]
[JsonProperty("solid_state_density")]
public System.Nullable<float> SolidStateDensity { get; set; } = null;
        

[Description("The constant specific heat used for the fully frozen (crystallized) state")]
[JsonProperty("solid_state_specific_heat")]
public System.Nullable<float> SolidStateSpecificHeat { get; set; } = null;
        

[Description("The total freezing range of the material is the sum of low and high temperature d" +
    "ifference of freezing curve.")]
[JsonProperty("high_temperature_difference_of_freezing_curve")]
public System.Nullable<float> HighTemperatureDifferenceOfFreezingCurve { get; set; } = null;
        

[Description("The temperature at which the freezing curve peaks")]
[JsonProperty("peak_freezing_temperature")]
public System.Nullable<float> PeakFreezingTemperature { get; set; } = null;
        

[Description("The total freezing range of the material is the sum of low and high temperature d" +
    "ifference of freezing curve.")]
[JsonProperty("low_temperature_difference_of_freezing_curve")]
public System.Nullable<float> LowTemperatureDifferenceOfFreezingCurve { get; set; } = null;
    }
    
    [Description(@"Additional properties for temperature dependent thermal conductivity using piecewise linear temperature-conductivity function. HeatBalanceAlgorithm = CondFD(ConductionFiniteDifference) solution algorithm only. Has no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:VariableThermalConductivity")]
    public class MaterialProperty_VariableThermalConductivity : BHoMObject, IEnergyPlusClass
    {
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty("temperature_1")]
public System.Nullable<float> Temperature1 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 1")]
[JsonProperty("thermal_conductivity_1")]
public System.Nullable<float> ThermalConductivity1 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty("temperature_2")]
public System.Nullable<float> Temperature2 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 2")]
[JsonProperty("thermal_conductivity_2")]
public System.Nullable<float> ThermalConductivity2 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty("temperature_3")]
public System.Nullable<float> Temperature3 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 3")]
[JsonProperty("thermal_conductivity_3")]
public System.Nullable<float> ThermalConductivity3 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty("temperature_4")]
public System.Nullable<float> Temperature4 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 4")]
[JsonProperty("thermal_conductivity_4")]
public System.Nullable<float> ThermalConductivity4 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty("temperature_5")]
public System.Nullable<float> Temperature5 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 5")]
[JsonProperty("thermal_conductivity_5")]
public System.Nullable<float> ThermalConductivity5 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty("temperature_6")]
public System.Nullable<float> Temperature6 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 6")]
[JsonProperty("thermal_conductivity_6")]
public System.Nullable<float> ThermalConductivity6 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty("temperature_7")]
public System.Nullable<float> Temperature7 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 7")]
[JsonProperty("thermal_conductivity_7")]
public System.Nullable<float> ThermalConductivity7 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty("temperature_8")]
public System.Nullable<float> Temperature8 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 8")]
[JsonProperty("thermal_conductivity_8")]
public System.Nullable<float> ThermalConductivity8 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty("temperature_9")]
public System.Nullable<float> Temperature9 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 9")]
[JsonProperty("thermal_conductivity_9")]
public System.Nullable<float> ThermalConductivity9 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function")]
[JsonProperty("temperature_10")]
public System.Nullable<float> Temperature10 { get; set; } = null;
        

[Description("for Temperature-Thermal Conductivity function corresponding to temperature 10")]
[JsonProperty("thermal_conductivity_10")]
public System.Nullable<float> ThermalConductivity10 { get; set; } = null;
    }
    
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
        "ly. Additional material properties for surfaces. Has no effect with other HeatBa" +
        "lanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:HeatAndMoistureTransfer:Settings")]
    public class MaterialProperty_HeatAndMoistureTransfer_Settings : BHoMObject, IEnergyPlusClass
    {
        

[Description("Material Name that the moisture properties will be added to. This augments materi" +
    "al properties needed for combined heat and moisture transfer for surfaces.")]
[JsonProperty("material_name")]
public string MaterialName { get; set; } = "";
        

[JsonProperty("porosity")]
public System.Nullable<float> Porosity { get; set; } = null;
        

[Description("units are the water/material density ratio at the beginning of each run period.")]
[JsonProperty("initial_water_content_ratio")]
public System.Nullable<float> InitialWaterContentRatio { get; set; } = (System.Nullable<float>)Single.Parse("0.2", CultureInfo.InvariantCulture);
    }
    
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
        "ly. Relationship between moisture content and relative humidity fraction. Has no" +
        " effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:HeatAndMoistureTransfer:SorptionIsotherm")]
    public class MaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm : BHoMObject, IEnergyPlusClass
    {
        

[Description("The Material Name that the moisture sorption isotherm will be added to.")]
[JsonProperty("material_name")]
public string MaterialName { get; set; } = "";
        

[Description("Number of data Coordinates")]
[JsonProperty("number_of_isotherm_coordinates")]
public System.Nullable<float> NumberOfIsothermCoordinates { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_1")]
public System.Nullable<float> RelativeHumidityFraction1 { get; set; } = null;
        

[JsonProperty("moisture_content_1")]
public System.Nullable<float> MoistureContent1 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_2")]
public System.Nullable<float> RelativeHumidityFraction2 { get; set; } = null;
        

[JsonProperty("moisture_content_2")]
public System.Nullable<float> MoistureContent2 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_3")]
public System.Nullable<float> RelativeHumidityFraction3 { get; set; } = null;
        

[JsonProperty("moisture_content_3")]
public System.Nullable<float> MoistureContent3 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_4")]
public System.Nullable<float> RelativeHumidityFraction4 { get; set; } = null;
        

[JsonProperty("moisture_content_4")]
public System.Nullable<float> MoistureContent4 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_5")]
public System.Nullable<float> RelativeHumidityFraction5 { get; set; } = null;
        

[JsonProperty("moisture_content_5")]
public System.Nullable<float> MoistureContent5 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_6")]
public System.Nullable<float> RelativeHumidityFraction6 { get; set; } = null;
        

[JsonProperty("moisture_content_6")]
public System.Nullable<float> MoistureContent6 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_7")]
public System.Nullable<float> RelativeHumidityFraction7 { get; set; } = null;
        

[JsonProperty("moisture_content_7")]
public System.Nullable<float> MoistureContent7 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_8")]
public System.Nullable<float> RelativeHumidityFraction8 { get; set; } = null;
        

[JsonProperty("moisture_content_8")]
public System.Nullable<float> MoistureContent8 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_9")]
public System.Nullable<float> RelativeHumidityFraction9 { get; set; } = null;
        

[JsonProperty("moisture_content_9")]
public System.Nullable<float> MoistureContent9 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_10")]
public System.Nullable<float> RelativeHumidityFraction10 { get; set; } = null;
        

[JsonProperty("moisture_content_10")]
public System.Nullable<float> MoistureContent10 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_11")]
public System.Nullable<float> RelativeHumidityFraction11 { get; set; } = null;
        

[JsonProperty("moisture_content_11")]
public System.Nullable<float> MoistureContent11 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_12")]
public System.Nullable<float> RelativeHumidityFraction12 { get; set; } = null;
        

[JsonProperty("moisture_content_12")]
public System.Nullable<float> MoistureContent12 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_13")]
public System.Nullable<float> RelativeHumidityFraction13 { get; set; } = null;
        

[JsonProperty("moisture_content_13")]
public System.Nullable<float> MoistureContent13 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_14")]
public System.Nullable<float> RelativeHumidityFraction14 { get; set; } = null;
        

[JsonProperty("moisture_content_14")]
public System.Nullable<float> MoistureContent14 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_15")]
public System.Nullable<float> RelativeHumidityFraction15 { get; set; } = null;
        

[JsonProperty("moisture_content_15")]
public System.Nullable<float> MoistureContent15 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_16")]
public System.Nullable<float> RelativeHumidityFraction16 { get; set; } = null;
        

[JsonProperty("moisture_content_16")]
public System.Nullable<float> MoistureContent16 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_17")]
public System.Nullable<float> RelativeHumidityFraction17 { get; set; } = null;
        

[JsonProperty("moisture_content_17")]
public System.Nullable<float> MoistureContent17 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_18")]
public System.Nullable<float> RelativeHumidityFraction18 { get; set; } = null;
        

[JsonProperty("moisture_content_18")]
public System.Nullable<float> MoistureContent18 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_19")]
public System.Nullable<float> RelativeHumidityFraction19 { get; set; } = null;
        

[JsonProperty("moisture_content_19")]
public System.Nullable<float> MoistureContent19 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_20")]
public System.Nullable<float> RelativeHumidityFraction20 { get; set; } = null;
        

[JsonProperty("moisture_content_20")]
public System.Nullable<float> MoistureContent20 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_21")]
public System.Nullable<float> RelativeHumidityFraction21 { get; set; } = null;
        

[JsonProperty("moisture_content_21")]
public System.Nullable<float> MoistureContent21 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_22")]
public System.Nullable<float> RelativeHumidityFraction22 { get; set; } = null;
        

[JsonProperty("moisture_content_22")]
public System.Nullable<float> MoistureContent22 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_23")]
public System.Nullable<float> RelativeHumidityFraction23 { get; set; } = null;
        

[JsonProperty("moisture_content_23")]
public System.Nullable<float> MoistureContent23 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_24")]
public System.Nullable<float> RelativeHumidityFraction24 { get; set; } = null;
        

[JsonProperty("moisture_content_24")]
public System.Nullable<float> MoistureContent24 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_25")]
public System.Nullable<float> RelativeHumidityFraction25 { get; set; } = null;
        

[JsonProperty("moisture_content_25")]
public System.Nullable<float> MoistureContent25 { get; set; } = null;
    }
    
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
        "ly. Relationship between liquid suction transport coefficient and moisture conte" +
        "nt Has no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:HeatAndMoistureTransfer:Suction")]
    public class MaterialProperty_HeatAndMoistureTransfer_Suction : BHoMObject, IEnergyPlusClass
    {
        

[Description("Material Name that the moisture properties will be added to.")]
[JsonProperty("material_name")]
public string MaterialName { get; set; } = "";
        

[Description("Number of Suction Liquid Transport Coefficient coordinates")]
[JsonProperty("number_of_suction_points")]
public System.Nullable<float> NumberOfSuctionPoints { get; set; } = null;
        

[JsonProperty("moisture_content_1")]
public System.Nullable<float> MoistureContent1 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_1")]
public System.Nullable<float> LiquidTransportCoefficient1 { get; set; } = null;
        

[JsonProperty("moisture_content_2")]
public System.Nullable<float> MoistureContent2 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_2")]
public System.Nullable<float> LiquidTransportCoefficient2 { get; set; } = null;
        

[JsonProperty("moisture_content_3")]
public System.Nullable<float> MoistureContent3 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_3")]
public System.Nullable<float> LiquidTransportCoefficient3 { get; set; } = null;
        

[JsonProperty("moisture_content_4")]
public System.Nullable<float> MoistureContent4 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_4")]
public System.Nullable<float> LiquidTransportCoefficient4 { get; set; } = null;
        

[JsonProperty("moisture_content_5")]
public System.Nullable<float> MoistureContent5 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_5")]
public System.Nullable<float> LiquidTransportCoefficient5 { get; set; } = null;
        

[JsonProperty("moisture_content_6")]
public System.Nullable<float> MoistureContent6 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_6")]
public System.Nullable<float> LiquidTransportCoefficient6 { get; set; } = null;
        

[JsonProperty("moisture_content_7")]
public System.Nullable<float> MoistureContent7 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_7")]
public System.Nullable<float> LiquidTransportCoefficient7 { get; set; } = null;
        

[JsonProperty("moisture_content_8")]
public System.Nullable<float> MoistureContent8 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_8")]
public System.Nullable<float> LiquidTransportCoefficient8 { get; set; } = null;
        

[JsonProperty("moisture_content_9")]
public System.Nullable<float> MoistureContent9 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_9")]
public System.Nullable<float> LiquidTransportCoefficient9 { get; set; } = null;
        

[JsonProperty("moisture_content_10")]
public System.Nullable<float> MoistureContent10 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_10")]
public System.Nullable<float> LiquidTransportCoefficient10 { get; set; } = null;
        

[JsonProperty("moisture_content_11")]
public System.Nullable<float> MoistureContent11 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_11")]
public System.Nullable<float> LiquidTransportCoefficient11 { get; set; } = null;
        

[JsonProperty("moisture_content_12")]
public System.Nullable<float> MoistureContent12 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_12")]
public System.Nullable<float> LiquidTransportCoefficient12 { get; set; } = null;
        

[JsonProperty("moisture_content_13")]
public System.Nullable<float> MoistureContent13 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_13")]
public System.Nullable<float> LiquidTransportCoefficient13 { get; set; } = null;
        

[JsonProperty("moisture_content_14")]
public System.Nullable<float> MoistureContent14 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_14")]
public System.Nullable<float> LiquidTransportCoefficient14 { get; set; } = null;
        

[JsonProperty("moisture_content_15")]
public System.Nullable<float> MoistureContent15 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_15")]
public System.Nullable<float> LiquidTransportCoefficient15 { get; set; } = null;
        

[JsonProperty("moisture_content_16")]
public System.Nullable<float> MoistureContent16 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_16")]
public System.Nullable<float> LiquidTransportCoefficient16 { get; set; } = null;
        

[JsonProperty("moisture_content_17")]
public System.Nullable<float> MoistureContent17 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_17")]
public System.Nullable<float> LiquidTransportCoefficient17 { get; set; } = null;
        

[JsonProperty("moisture_content_18")]
public System.Nullable<float> MoistureContent18 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_18")]
public System.Nullable<float> LiquidTransportCoefficient18 { get; set; } = null;
        

[JsonProperty("moisture_content_19")]
public System.Nullable<float> MoistureContent19 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_19")]
public System.Nullable<float> LiquidTransportCoefficient19 { get; set; } = null;
        

[JsonProperty("moisture_content_20")]
public System.Nullable<float> MoistureContent20 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_20")]
public System.Nullable<float> LiquidTransportCoefficient20 { get; set; } = null;
        

[JsonProperty("moisture_content_21")]
public System.Nullable<float> MoistureContent21 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_21")]
public System.Nullable<float> LiquidTransportCoefficient21 { get; set; } = null;
        

[JsonProperty("moisture_content_22")]
public System.Nullable<float> MoistureContent22 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_22")]
public System.Nullable<float> LiquidTransportCoefficient22 { get; set; } = null;
        

[JsonProperty("moisture_content_23")]
public System.Nullable<float> MoistureContent23 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_23")]
public System.Nullable<float> LiquidTransportCoefficient23 { get; set; } = null;
        

[JsonProperty("moisture_content_24")]
public System.Nullable<float> MoistureContent24 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_24")]
public System.Nullable<float> LiquidTransportCoefficient24 { get; set; } = null;
        

[JsonProperty("moisture_content_25")]
public System.Nullable<float> MoistureContent25 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_25")]
public System.Nullable<float> LiquidTransportCoefficient25 { get; set; } = null;
    }
    
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
        "ly. Relationship between liquid transport coefficient and moisture content Has n" +
        "o effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:HeatAndMoistureTransfer:Redistribution")]
    public class MaterialProperty_HeatAndMoistureTransfer_Redistribution : BHoMObject, IEnergyPlusClass
    {
        

[Description("Moisture Material Name that the moisture properties will be added to.")]
[JsonProperty("material_name")]
public string MaterialName { get; set; } = "";
        

[Description("number of data points")]
[JsonProperty("number_of_redistribution_points")]
public System.Nullable<float> NumberOfRedistributionPoints { get; set; } = null;
        

[JsonProperty("moisture_content_1")]
public System.Nullable<float> MoistureContent1 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_1")]
public System.Nullable<float> LiquidTransportCoefficient1 { get; set; } = null;
        

[JsonProperty("moisture_content_2")]
public System.Nullable<float> MoistureContent2 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_2")]
public System.Nullable<float> LiquidTransportCoefficient2 { get; set; } = null;
        

[JsonProperty("moisture_content_3")]
public System.Nullable<float> MoistureContent3 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_3")]
public System.Nullable<float> LiquidTransportCoefficient3 { get; set; } = null;
        

[JsonProperty("moisture_content_4")]
public System.Nullable<float> MoistureContent4 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_4")]
public System.Nullable<float> LiquidTransportCoefficient4 { get; set; } = null;
        

[JsonProperty("moisture_content_5")]
public System.Nullable<float> MoistureContent5 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_5")]
public System.Nullable<float> LiquidTransportCoefficient5 { get; set; } = null;
        

[JsonProperty("moisture_content_6")]
public System.Nullable<float> MoistureContent6 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_6")]
public System.Nullable<float> LiquidTransportCoefficient6 { get; set; } = null;
        

[JsonProperty("moisture_content_7")]
public System.Nullable<float> MoistureContent7 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_7")]
public System.Nullable<float> LiquidTransportCoefficient7 { get; set; } = null;
        

[JsonProperty("moisture_content_8")]
public System.Nullable<float> MoistureContent8 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_8")]
public System.Nullable<float> LiquidTransportCoefficient8 { get; set; } = null;
        

[JsonProperty("moisture_content_9")]
public System.Nullable<float> MoistureContent9 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_9")]
public System.Nullable<float> LiquidTransportCoefficient9 { get; set; } = null;
        

[JsonProperty("moisture_content_10")]
public System.Nullable<float> MoistureContent10 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_10")]
public System.Nullable<float> LiquidTransportCoefficient10 { get; set; } = null;
        

[JsonProperty("moisture_content_11")]
public System.Nullable<float> MoistureContent11 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_11")]
public System.Nullable<float> LiquidTransportCoefficient11 { get; set; } = null;
        

[JsonProperty("moisture_content_12")]
public System.Nullable<float> MoistureContent12 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_12")]
public System.Nullable<float> LiquidTransportCoefficient12 { get; set; } = null;
        

[JsonProperty("moisture_content_13")]
public System.Nullable<float> MoistureContent13 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_13")]
public System.Nullable<float> LiquidTransportCoefficient13 { get; set; } = null;
        

[JsonProperty("moisture_content_14")]
public System.Nullable<float> MoistureContent14 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_14")]
public System.Nullable<float> LiquidTransportCoefficient14 { get; set; } = null;
        

[JsonProperty("moisture_content_15")]
public System.Nullable<float> MoistureContent15 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_15")]
public System.Nullable<float> LiquidTransportCoefficient15 { get; set; } = null;
        

[JsonProperty("moisture_content_16")]
public System.Nullable<float> MoistureContent16 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_16")]
public System.Nullable<float> LiquidTransportCoefficient16 { get; set; } = null;
        

[JsonProperty("moisture_content_17")]
public System.Nullable<float> MoistureContent17 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_17")]
public System.Nullable<float> LiquidTransportCoefficient17 { get; set; } = null;
        

[JsonProperty("moisture_content_18")]
public System.Nullable<float> MoistureContent18 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_18")]
public System.Nullable<float> LiquidTransportCoefficient18 { get; set; } = null;
        

[JsonProperty("moisture_content_19")]
public System.Nullable<float> MoistureContent19 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_19")]
public System.Nullable<float> LiquidTransportCoefficient19 { get; set; } = null;
        

[JsonProperty("moisture_content_20")]
public System.Nullable<float> MoistureContent20 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_20")]
public System.Nullable<float> LiquidTransportCoefficient20 { get; set; } = null;
        

[JsonProperty("moisture_content_21")]
public System.Nullable<float> MoistureContent21 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_21")]
public System.Nullable<float> LiquidTransportCoefficient21 { get; set; } = null;
        

[JsonProperty("moisture_content_22")]
public System.Nullable<float> MoistureContent22 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_22")]
public System.Nullable<float> LiquidTransportCoefficient22 { get; set; } = null;
        

[JsonProperty("moisture_content_23")]
public System.Nullable<float> MoistureContent23 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_23")]
public System.Nullable<float> LiquidTransportCoefficient23 { get; set; } = null;
        

[JsonProperty("moisture_content_24")]
public System.Nullable<float> MoistureContent24 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_24")]
public System.Nullable<float> LiquidTransportCoefficient24 { get; set; } = null;
        

[JsonProperty("moisture_content_25")]
public System.Nullable<float> MoistureContent25 { get; set; } = null;
        

[JsonProperty("liquid_transport_coefficient_25")]
public System.Nullable<float> LiquidTransportCoefficient25 { get; set; } = null;
    }
    
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
        "ly. Relationship between water vapor diffusion and relative humidity fraction Ha" +
        "s no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:HeatAndMoistureTransfer:Diffusion")]
    public class MaterialProperty_HeatAndMoistureTransfer_Diffusion : BHoMObject, IEnergyPlusClass
    {
        

[Description("Moisture Material Name that the moisture properties will be added to.")]
[JsonProperty("material_name")]
public string MaterialName { get; set; } = "";
        

[Description("Water Vapor Diffusion Resistance Factor")]
[JsonProperty("number_of_data_pairs")]
public System.Nullable<float> NumberOfDataPairs { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_1")]
public System.Nullable<float> RelativeHumidityFraction1 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_1")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor1 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_2")]
public System.Nullable<float> RelativeHumidityFraction2 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_2")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor2 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_3")]
public System.Nullable<float> RelativeHumidityFraction3 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_3")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor3 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_4")]
public System.Nullable<float> RelativeHumidityFraction4 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_4")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor4 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_5")]
public System.Nullable<float> RelativeHumidityFraction5 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_5")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor5 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_6")]
public System.Nullable<float> RelativeHumidityFraction6 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_6")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor6 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_7")]
public System.Nullable<float> RelativeHumidityFraction7 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_7")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor7 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_8")]
public System.Nullable<float> RelativeHumidityFraction8 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_8")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor8 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_9")]
public System.Nullable<float> RelativeHumidityFraction9 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_9")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor9 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_10")]
public System.Nullable<float> RelativeHumidityFraction10 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_10")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor10 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_11")]
public System.Nullable<float> RelativeHumidityFraction11 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_11")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor11 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_12")]
public System.Nullable<float> RelativeHumidityFraction12 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_12")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor12 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_13")]
public System.Nullable<float> RelativeHumidityFraction13 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_13")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor13 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_14")]
public System.Nullable<float> RelativeHumidityFraction14 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_14")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor14 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_15")]
public System.Nullable<float> RelativeHumidityFraction15 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_15")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor15 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_16")]
public System.Nullable<float> RelativeHumidityFraction16 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_16")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor16 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_17")]
public System.Nullable<float> RelativeHumidityFraction17 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_17")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor17 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_18")]
public System.Nullable<float> RelativeHumidityFraction18 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_18")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor18 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_19")]
public System.Nullable<float> RelativeHumidityFraction19 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_19")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor19 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_20")]
public System.Nullable<float> RelativeHumidityFraction20 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_20")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor20 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_21")]
public System.Nullable<float> RelativeHumidityFraction21 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_21")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor21 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_22")]
public System.Nullable<float> RelativeHumidityFraction22 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_22")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor22 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_23")]
public System.Nullable<float> RelativeHumidityFraction23 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_23")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor23 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_24")]
public System.Nullable<float> RelativeHumidityFraction24 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_24")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor24 { get; set; } = null;
        

[Description("The relative humidity is entered as a fraction.")]
[JsonProperty("relative_humidity_fraction_25")]
public System.Nullable<float> RelativeHumidityFraction25 { get; set; } = null;
        

[JsonProperty("water_vapor_diffusion_resistance_factor_25")]
public System.Nullable<float> WaterVaporDiffusionResistanceFactor25 { get; set; } = null;
    }
    
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
        "ly. Relationship between thermal conductivity and moisture content Has no effect" +
        " with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject("MaterialProperty:HeatAndMoistureTransfer:ThermalConductivity")]
    public class MaterialProperty_HeatAndMoistureTransfer_ThermalConductivity : BHoMObject, IEnergyPlusClass
    {
        

[Description("Moisture Material Name that the Thermal Conductivity will be added to.")]
[JsonProperty("material_name")]
public string MaterialName { get; set; } = "";
        

[Description("number of data coordinates")]
[JsonProperty("number_of_thermal_coordinates")]
public System.Nullable<float> NumberOfThermalCoordinates { get; set; } = null;
        

[JsonProperty("moisture_content_1")]
public System.Nullable<float> MoistureContent1 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_1")]
public System.Nullable<float> ThermalConductivity1 { get; set; } = null;
        

[JsonProperty("moisture_content_2")]
public System.Nullable<float> MoistureContent2 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_2")]
public System.Nullable<float> ThermalConductivity2 { get; set; } = null;
        

[JsonProperty("moisture_content_3")]
public System.Nullable<float> MoistureContent3 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_3")]
public System.Nullable<float> ThermalConductivity3 { get; set; } = null;
        

[JsonProperty("moisture_content_4")]
public System.Nullable<float> MoistureContent4 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_4")]
public System.Nullable<float> ThermalConductivity4 { get; set; } = null;
        

[JsonProperty("moisture_content_5")]
public System.Nullable<float> MoistureContent5 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_5")]
public System.Nullable<float> ThermalConductivity5 { get; set; } = null;
        

[JsonProperty("moisture_content_6")]
public System.Nullable<float> MoistureContent6 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_6")]
public System.Nullable<float> ThermalConductivity6 { get; set; } = null;
        

[JsonProperty("moisture_content_7")]
public System.Nullable<float> MoistureContent7 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_7")]
public System.Nullable<float> ThermalConductivity7 { get; set; } = null;
        

[JsonProperty("moisture_content_8")]
public System.Nullable<float> MoistureContent8 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_8")]
public System.Nullable<float> ThermalConductivity8 { get; set; } = null;
        

[JsonProperty("moisture_content_9")]
public System.Nullable<float> MoistureContent9 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_9")]
public System.Nullable<float> ThermalConductivity9 { get; set; } = null;
        

[JsonProperty("moisture_content_10")]
public System.Nullable<float> MoistureContent10 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_10")]
public System.Nullable<float> ThermalConductivity10 { get; set; } = null;
        

[JsonProperty("moisture_content_11")]
public System.Nullable<float> MoistureContent11 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_11")]
public System.Nullable<float> ThermalConductivity11 { get; set; } = null;
        

[JsonProperty("moisture_content_12")]
public System.Nullable<float> MoistureContent12 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_12")]
public System.Nullable<float> ThermalConductivity12 { get; set; } = null;
        

[JsonProperty("moisture_content_13")]
public System.Nullable<float> MoistureContent13 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_13")]
public System.Nullable<float> ThermalConductivity13 { get; set; } = null;
        

[JsonProperty("moisture_content_14")]
public System.Nullable<float> MoistureContent14 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_14")]
public System.Nullable<float> ThermalConductivity14 { get; set; } = null;
        

[JsonProperty("moisture_content_15")]
public System.Nullable<float> MoistureContent15 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_15")]
public System.Nullable<float> ThermalConductivity15 { get; set; } = null;
        

[JsonProperty("moisture_content_16")]
public System.Nullable<float> MoistureContent16 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_16")]
public System.Nullable<float> ThermalConductivity16 { get; set; } = null;
        

[JsonProperty("moisture_content_17")]
public System.Nullable<float> MoistureContent17 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_17")]
public System.Nullable<float> ThermalConductivity17 { get; set; } = null;
        

[JsonProperty("moisture_content_18")]
public System.Nullable<float> MoistureContent18 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_18")]
public System.Nullable<float> ThermalConductivity18 { get; set; } = null;
        

[JsonProperty("moisture_content_19")]
public System.Nullable<float> MoistureContent19 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_19")]
public System.Nullable<float> ThermalConductivity19 { get; set; } = null;
        

[JsonProperty("moisture_content_20")]
public System.Nullable<float> MoistureContent20 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_20")]
public System.Nullable<float> ThermalConductivity20 { get; set; } = null;
        

[JsonProperty("moisture_content_21")]
public System.Nullable<float> MoistureContent21 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_21")]
public System.Nullable<float> ThermalConductivity21 { get; set; } = null;
        

[JsonProperty("moisture_content_22")]
public System.Nullable<float> MoistureContent22 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_22")]
public System.Nullable<float> ThermalConductivity22 { get; set; } = null;
        

[JsonProperty("moisture_content_23")]
public System.Nullable<float> MoistureContent23 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_23")]
public System.Nullable<float> ThermalConductivity23 { get; set; } = null;
        

[JsonProperty("moisture_content_24")]
public System.Nullable<float> MoistureContent24 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_24")]
public System.Nullable<float> ThermalConductivity24 { get; set; } = null;
        

[JsonProperty("moisture_content_25")]
public System.Nullable<float> MoistureContent25 { get; set; } = null;
        

[JsonProperty("thermal_conductivity_25")]
public System.Nullable<float> ThermalConductivity25 { get; set; } = null;
    }
    
    [Description("Name is followed by up to 800 sets of normal-incidence measured values of [wavele" +
        "ngth, transmittance, front reflectance, back reflectance] for wavelengths coveri" +
        "ng the solar spectrum (from about 0.25 to 2.5 microns)")]
    [JsonObject("MaterialProperty:GlazingSpectralData")]
    public class MaterialProperty_GlazingSpectralData : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("wavelength_1")]
public System.Nullable<float> Wavelength1 { get; set; } = null;
        

[JsonProperty("transmittance_1")]
public System.Nullable<float> Transmittance1 { get; set; } = null;
        

[JsonProperty("front_reflectance_1")]
public System.Nullable<float> FrontReflectance1 { get; set; } = null;
        

[JsonProperty("back_reflectance_1")]
public System.Nullable<float> BackReflectance1 { get; set; } = null;
        

[JsonProperty("wavelength_2")]
public System.Nullable<float> Wavelength2 { get; set; } = null;
        

[JsonProperty("transmittance_2")]
public System.Nullable<float> Transmittance2 { get; set; } = null;
        

[JsonProperty("front_reflectance_2")]
public System.Nullable<float> FrontReflectance2 { get; set; } = null;
        

[JsonProperty("back_reflectance_2")]
public System.Nullable<float> BackReflectance2 { get; set; } = null;
        

[JsonProperty("wavelength_3")]
public System.Nullable<float> Wavelength3 { get; set; } = null;
        

[JsonProperty("transmittance_3")]
public System.Nullable<float> Transmittance3 { get; set; } = null;
        

[JsonProperty("front_reflectance_3")]
public System.Nullable<float> FrontReflectance3 { get; set; } = null;
        

[JsonProperty("back_reflectance_3")]
public System.Nullable<float> BackReflectance3 { get; set; } = null;
        

[JsonProperty("wavelength_4")]
public System.Nullable<float> Wavelength4 { get; set; } = null;
        

[JsonProperty("transmittance_4")]
public System.Nullable<float> Transmittance4 { get; set; } = null;
        

[JsonProperty("front_reflectance_4")]
public System.Nullable<float> FrontReflectance4 { get; set; } = null;
        

[JsonProperty("back_reflectance_4")]
public System.Nullable<float> BackReflectance4 { get; set; } = null;
        

[JsonProperty("extensions")]
public string Extensions { get; set; } = "";
    }
    
    [Description("Start with outside layer and work your way to the inside layer Up to 10 layers to" +
        "tal, 8 for windows Enter the material name for each layer")]
    [JsonObject("Construction")]
    public class Construction : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("outside_layer")]
public string OutsideLayer { get; set; } = "";
        

[JsonProperty("layer_2")]
public string Layer2 { get; set; } = "";
        

[JsonProperty("layer_3")]
public string Layer3 { get; set; } = "";
        

[JsonProperty("layer_4")]
public string Layer4 { get; set; } = "";
        

[JsonProperty("layer_5")]
public string Layer5 { get; set; } = "";
        

[JsonProperty("layer_6")]
public string Layer6 { get; set; } = "";
        

[JsonProperty("layer_7")]
public string Layer7 { get; set; } = "";
        

[JsonProperty("layer_8")]
public string Layer8 { get; set; } = "";
        

[JsonProperty("layer_9")]
public string Layer9 { get; set; } = "";
        

[JsonProperty("layer_10")]
public string Layer10 { get; set; } = "";
    }
    
    [Description("Alternate method of describing underground wall constructions")]
    [JsonObject("Construction:CfactorUndergroundWall")]
    public class Construction_CfactorUndergroundWall : BHoMObject, IEnergyPlusClass
    {
        

[Description("Enter C-Factor without film coefficients or soil")]
[JsonProperty("c_factor")]
public System.Nullable<float> CFactor { get; set; } = null;
        

[Description("Enter height of the underground wall")]
[JsonProperty("height")]
public System.Nullable<float> Height { get; set; } = null;
    }
    
    [Description("Alternate method of describing slab-on-grade or underground floor constructions")]
    [JsonObject("Construction:FfactorGroundFloor")]
    public class Construction_FfactorGroundFloor : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("f_factor")]
public System.Nullable<float> FFactor { get; set; } = null;
        

[Description("Enter area of the floor")]
[JsonProperty("area")]
public System.Nullable<float> Area { get; set; } = null;
        

[Description("Enter exposed perimeter of the floor")]
[JsonProperty("perimeterexposed")]
public System.Nullable<float> Perimeterexposed { get; set; } = null;
    }
    
    [Description("Internal heat source to be attached to a construction layer")]
    [JsonObject("ConstructionProperty:InternalHeatSource")]
    public class ConstructionProperty_InternalHeatSource : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("construction_name")]
public string ConstructionName { get; set; } = "";
        

[Description("refers to the list of materials which follows")]
[JsonProperty("thermal_source_present_after_layer_number")]
public System.Nullable<float> ThermalSourcePresentAfterLayerNumber { get; set; } = null;
        

[Description("refers to the list of materials which follows")]
[JsonProperty("temperature_calculation_requested_after_layer_number")]
public System.Nullable<float> TemperatureCalculationRequestedAfterLayerNumber { get; set; } = null;
        

[Description("1 = 1-dimensional calculation, 2 = 2-dimensional calculation")]
[JsonProperty("dimensions_for_the_ctf_calculation")]
public System.Nullable<float> DimensionsForTheCtfCalculation { get; set; } = null;
        

[Description("uniform spacing between tubes or resistance wires in direction perpendicular to m" +
    "ain intended direction of heat transfer")]
[JsonProperty("tube_spacing")]
public System.Nullable<float> TubeSpacing { get; set; } = null;
        

[Description(@"used in conjunction with field Temperature Calculation Requested After Layer Number this field is the location perpendicular to the main direction of heat transfer 0.0 means in line with the tubing, 1.0 means at the midpoint between two adjacent pipes this field is ignored for 1-D calculations")]
[JsonProperty("two_dimensional_temperature_calculation_position")]
public System.Nullable<float> TwoDimensionalTemperatureCalculationPosition { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
    }
    
    [Description(@"Indicates an open boundary between two zones. It may be used for base surfaces and fenestration surfaces. The two adjacent zones are grouped together for solar, daylighting and radiant exchange. When this construction type is used, the Outside Boundary Condition of the surface (or the base surface of a fenestration surface) must be either Surface or Zone. A base surface with Construction:AirBoundary cannot hold any fenestration surfaces.")]
    [JsonObject("Construction:AirBoundary")]
    public class Construction_AirBoundary : BHoMObject, IEnergyPlusClass
    {
        

[Description("This field controls how air exchange is modeled across this boundary.")]
[JsonProperty("air_exchange_method")]
public Construction_AirBoundary_AirExchangeMethod AirExchangeMethod { get; set; } = (Construction_AirBoundary_AirExchangeMethod)Enum.Parse(typeof(Construction_AirBoundary_AirExchangeMethod), "None");
        

[Description("If the Air Exchange Method is SimpleMixing then this field specifies the air chan" +
    "ges per hour using the volume of the smaller zone as the basis. If an AirflowNet" +
    "work simulation is active this field is ignored.")]
[JsonProperty("simple_mixing_air_changes_per_hour")]
public System.Nullable<float> SimpleMixingAirChangesPerHour { get; set; } = (System.Nullable<float>)Single.Parse("0.5", CultureInfo.InvariantCulture);
        

[Description("If the Air Exchange Method is SimpleMixing then this field specifies the air exch" +
    "ange schedule. If this field is blank, the schedule is always 1.0. If an Airflow" +
    "Network simulation is active this field is ignored.")]
[JsonProperty("simple_mixing_schedule_name")]
public string SimpleMixingScheduleName { get; set; } = "";
    }
    
    public enum Construction_AirBoundary_AirExchangeMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("None")]
        None = 1,
        
        [JsonProperty("SimpleMixing")]
        SimpleMixing = 2,
    }
    
    [Description("object is used to select which thermal model should be used in tarcog simulations" +
        "")]
    [JsonObject("WindowThermalModel:Params")]
    public class WindowThermalModel_Params : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("standard")]
public WindowThermalModel_Params_Standard Standard { get; set; } = (WindowThermalModel_Params_Standard)Enum.Parse(typeof(WindowThermalModel_Params_Standard), "ISO15099");
        

[JsonProperty("thermal_model")]
public WindowThermalModel_Params_ThermalModel ThermalModel { get; set; } = (WindowThermalModel_Params_ThermalModel)Enum.Parse(typeof(WindowThermalModel_Params_ThermalModel), "ISO15099");
        

[JsonProperty("sdscalar")]
public System.Nullable<float> Sdscalar { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("deflection_model")]
public WindowThermalModel_Params_DeflectionModel DeflectionModel { get; set; } = (WindowThermalModel_Params_DeflectionModel)Enum.Parse(typeof(WindowThermalModel_Params_DeflectionModel), "NoDeflection");
        

[JsonProperty("vacuum_pressure_limit")]
public System.Nullable<float> VacuumPressureLimit { get; set; } = (System.Nullable<float>)Single.Parse("13.238", CultureInfo.InvariantCulture);
        

[Description("This is temperature in time of window fabrication")]
[JsonProperty("initial_temperature")]
public System.Nullable<float> InitialTemperature { get; set; } = (System.Nullable<float>)Single.Parse("25", CultureInfo.InvariantCulture);
        

[Description("This is pressure in time of window fabrication")]
[JsonProperty("initial_pressure")]
public System.Nullable<float> InitialPressure { get; set; } = (System.Nullable<float>)Single.Parse("101325", CultureInfo.InvariantCulture);
    }
    
    public enum WindowThermalModel_Params_Standard
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("EN673Declared")]
        EN673Declared = 1,
        
        [JsonProperty("EN673Design")]
        EN673Design = 2,
        
        [JsonProperty("ISO15099")]
        ISO15099 = 3,
    }
    
    public enum WindowThermalModel_Params_ThermalModel
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("ConvectiveScalarModel_NoSDThickness")]
        ConvectiveScalarModelNoSDThickness = 1,
        
        [JsonProperty("ConvectiveScalarModel_withSDThickness")]
        ConvectiveScalarModelWithSDThickness = 2,
        
        [JsonProperty("ISO15099")]
        ISO15099 = 3,
        
        [JsonProperty("ScaledCavityWidth")]
        ScaledCavityWidth = 4,
    }
    
    public enum WindowThermalModel_Params_DeflectionModel
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("MeasuredDeflection")]
        MeasuredDeflection = 1,
        
        [JsonProperty("NoDeflection")]
        NoDeflection = 2,
        
        [JsonProperty("TemperatureAndPressureInput")]
        TemperatureAndPressureInput = 3,
    }
    
    [Description(@"Describes which window model will be used in calculations. Built in windows model will use algorithms that are part of EnergyPlus, while ExternalWindowsModel will use Windows-CalcEngine library to perform optical and thermal performances of windows and doors.")]
    [JsonObject("WindowsCalculationEngine")]
    public class WindowsCalculationEngine : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("windows_engine")]
public WindowsCalculationEngine_WindowsEngine WindowsEngine { get; set; } = (WindowsCalculationEngine_WindowsEngine)Enum.Parse(typeof(WindowsCalculationEngine_WindowsEngine), "BuiltInWindowsModel");
    }
    
    public enum WindowsCalculationEngine_WindowsEngine
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("BuiltInWindowsModel")]
        BuiltInWindowsModel = 1,
        
        [JsonProperty("ExternalWindowsModel")]
        ExternalWindowsModel = 2,
    }
    
    [Description("Describes one state for a complex glazing system These input objects are typicall" +
        "y generated by using WINDOW software and export to IDF syntax")]
    [JsonObject("Construction:ComplexFenestrationState")]
    public class Construction_ComplexFenestrationState : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("basis_type")]
public Construction_ComplexFenestrationState_BasisType BasisType { get; set; } = (Construction_ComplexFenestrationState_BasisType)Enum.Parse(typeof(Construction_ComplexFenestrationState_BasisType), "LBNLWINDOW");
        

[JsonProperty("basis_symmetry_type")]
public Construction_ComplexFenestrationState_BasisSymmetryType BasisSymmetryType { get; set; } = (Construction_ComplexFenestrationState_BasisSymmetryType)Enum.Parse(typeof(Construction_ComplexFenestrationState_BasisSymmetryType), "None");
        

[JsonProperty("window_thermal_model")]
public string WindowThermalModel { get; set; } = "";
        

[JsonProperty("basis_matrix_name")]
public string BasisMatrixName { get; set; } = "";
        

[JsonProperty("solar_optical_complex_front_transmittance_matrix_name")]
public string SolarOpticalComplexFrontTransmittanceMatrixName { get; set; } = "";
        

[JsonProperty("solar_optical_complex_back_reflectance_matrix_name")]
public string SolarOpticalComplexBackReflectanceMatrixName { get; set; } = "";
        

[JsonProperty("visible_optical_complex_front_transmittance_matrix_name")]
public string VisibleOpticalComplexFrontTransmittanceMatrixName { get; set; } = "";
        

[JsonProperty("visible_optical_complex_back_transmittance_matrix_name")]
public string VisibleOpticalComplexBackTransmittanceMatrixName { get; set; } = "";
        

[JsonProperty("outside_layer_name")]
public string OutsideLayerName { get; set; } = "";
        

[JsonProperty("outside_layer_directional_front_absoptance_matrix_name")]
public string OutsideLayerDirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("outside_layer_directional_back_absoptance_matrix_name")]
public string OutsideLayerDirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("gap_1_name")]
public string Gap1Name { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty("cfs_gap_1_directional_front_absoptance_matrix_name")]
public string CfsGap1DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty("cfs_gap_1_directional_back_absoptance_matrix_name")]
public string CfsGap1DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("layer_2_name")]
public string Layer2Name { get; set; } = "";
        

[JsonProperty("layer_2_directional_front_absoptance_matrix_name")]
public string Layer2DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("layer_2_directional_back_absoptance_matrix_name")]
public string Layer2DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("gap_2_name")]
public string Gap2Name { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty("gap_2_directional_front_absoptance_matrix_name")]
public string Gap2DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty("gap_2_directional_back_absoptance_matrix_name")]
public string Gap2DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("layer_3_material")]
public string Layer3Material { get; set; } = "";
        

[JsonProperty("layer_3_directional_front_absoptance_matrix_name")]
public string Layer3DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("layer_3_directional_back_absoptance_matrix_name")]
public string Layer3DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("gap_3_name")]
public string Gap3Name { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty("gap_3_directional_front_absoptance_matrix_name")]
public string Gap3DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty("gap_3_directional_back_absoptance_matrix_name")]
public string Gap3DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("layer_4_name")]
public string Layer4Name { get; set; } = "";
        

[JsonProperty("layer_4_directional_front_absoptance_matrix_name")]
public string Layer4DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("layer_4_directional_back_absoptance_matrix_name")]
public string Layer4DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("gap_4_name")]
public string Gap4Name { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty("gap_4_directional_front_absoptance_matrix_name")]
public string Gap4DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[Description("Reserved for future use. Leave it blank for this version")]
[JsonProperty("gap_4_directional_back_absoptance_matrix_name")]
public string Gap4DirectionalBackAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("layer_5_name")]
public string Layer5Name { get; set; } = "";
        

[JsonProperty("layer_5_directional_front_absoptance_matrix_name")]
public string Layer5DirectionalFrontAbsoptanceMatrixName { get; set; } = "";
        

[JsonProperty("layer_5_directional_back_absoptance_matrix_name")]
public string Layer5DirectionalBackAbsoptanceMatrixName { get; set; } = "";
    }
    
    public enum Construction_ComplexFenestrationState_BasisType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("LBNLWINDOW")]
        LBNLWINDOW = 1,
        
        [JsonProperty("UserDefined")]
        UserDefined = 2,
    }
    
    public enum Construction_ComplexFenestrationState_BasisSymmetryType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Axisymmetric")]
        Axisymmetric = 1,
        
        [JsonProperty("None")]
        None = 2,
    }
    
    [Description("Start with outside layer and work your way to the inside Layer Up to 11 layers to" +
        "tal. Up to six solid layers and up to five gaps. Enter the material name for eac" +
        "h layer")]
    [JsonObject("Construction:WindowEquivalentLayer")]
    public class Construction_WindowEquivalentLayer : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("outside_layer")]
public string OutsideLayer { get; set; } = "";
        

[JsonProperty("layer_2")]
public string Layer2 { get; set; } = "";
        

[JsonProperty("layer_3")]
public string Layer3 { get; set; } = "";
        

[JsonProperty("layer_4")]
public string Layer4 { get; set; } = "";
        

[JsonProperty("layer_5")]
public string Layer5 { get; set; } = "";
        

[JsonProperty("layer_6")]
public string Layer6 { get; set; } = "";
        

[JsonProperty("layer_7")]
public string Layer7 { get; set; } = "";
        

[JsonProperty("layer_8")]
public string Layer8 { get; set; } = "";
        

[JsonProperty("layer_9")]
public string Layer9 { get; set; } = "";
        

[JsonProperty("layer_10")]
public string Layer10 { get; set; } = "";
        

[JsonProperty("layer_11")]
public string Layer11 { get; set; } = "";
    }
    
    [Description("Initiates search of the Window data file for a window called Name.")]
    [JsonObject("Construction:WindowDataFile")]
    public class Construction_WindowDataFile : BHoMObject, IEnergyPlusClass
    {
        

[Description("default file name is \"Window5DataFile.dat\" limit on this field is 100 characters." +
    "")]
[JsonProperty("file_name")]
public string FileName { get; set; } = "";
    }
}
