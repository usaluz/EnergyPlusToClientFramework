namespace BH.oM.Adapters.EnergyPlus.PerformanceTables
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
    
    
    [Description("An independent variable representing a single dimension of a Table:Lookup object." +
        "")]
    [JsonObject("Table:IndependentVariable")]
    public class Table_IndependentVariable : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("interpolation_method")]
public Table_IndependentVariable_InterpolationMethod InterpolationMethod { get; set; } = (Table_IndependentVariable_InterpolationMethod)Enum.Parse(typeof(Table_IndependentVariable_InterpolationMethod), "Linear");
        

[JsonProperty("extrapolation_method")]
public Table_IndependentVariable_ExtrapolationMethod ExtrapolationMethod { get; set; } = (Table_IndependentVariable_ExtrapolationMethod)Enum.Parse(typeof(Table_IndependentVariable_ExtrapolationMethod), "Constant");
        

[JsonProperty("minimum_value")]
public System.Nullable<float> MinimumValue { get; set; } = null;
        

[JsonProperty("maximum_value")]
public System.Nullable<float> MaximumValue { get; set; } = null;
        

[JsonProperty("normalization_reference_value")]
public System.Nullable<float> NormalizationReferenceValue { get; set; } = null;
        

[JsonProperty("unit_type")]
public Table_IndependentVariable_UnitType UnitType { get; set; } = (Table_IndependentVariable_UnitType)Enum.Parse(typeof(Table_IndependentVariable_UnitType), "Dimensionless");
        

[JsonProperty("external_file_name")]
public string ExternalFileName { get; set; } = "";
        

[JsonProperty("external_file_column_number")]
public System.Nullable<float> ExternalFileColumnNumber { get; set; } = null;
        

[JsonProperty("external_file_starting_row_number")]
public System.Nullable<float> ExternalFileStartingRowNumber { get; set; } = null;
        

[JsonProperty("values")]
public string Values { get; set; } = "";
    }
    
    public enum Table_IndependentVariable_InterpolationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Cubic")]
        Cubic = 1,
        
        [JsonProperty("Linear")]
        Linear = 2,
    }
    
    public enum Table_IndependentVariable_ExtrapolationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Constant")]
        Constant = 1,
        
        [JsonProperty("Linear")]
        Linear = 2,
    }
    
    public enum Table_IndependentVariable_UnitType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Angle")]
        Angle = 1,
        
        [JsonProperty("Dimensionless")]
        Dimensionless = 2,
        
        [JsonProperty("Distance")]
        Distance = 3,
        
        [JsonProperty("MassFlow")]
        MassFlow = 4,
        
        [JsonProperty("Power")]
        Power = 5,
        
        [JsonProperty("Temperature")]
        Temperature = 6,
        
        [JsonProperty("VolumetricFlow")]
        VolumetricFlow = 7,
    }
    
    [Description("A sorted list of independent variables used by one or more Table:Lookup objects.")]
    [JsonObject("Table:IndependentVariableList")]
    public class Table_IndependentVariableList : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("independent_variables")]
public string IndependentVariables { get; set; } = "";
    }
    
    [Description(@"Lookup tables are used in place of curves and can represent any number of independent variables (defined as Table:IndependentVariable objects in a Table:IndependentVariableList). Output values are interpolated within the bounds defined by each independent variable and extrapolated beyond the bounds according to the interpolation/extrapolation methods defined by each independent variable.")]
    [JsonObject("Table:Lookup")]
    public class Table_Lookup : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("independent_variable_list_name")]
public string IndependentVariableListName { get; set; } = "";
        

[JsonProperty("normalization_method")]
public Table_Lookup_NormalizationMethod NormalizationMethod { get; set; } = (Table_Lookup_NormalizationMethod)Enum.Parse(typeof(Table_Lookup_NormalizationMethod), "None");
        

[JsonProperty("normalization_divisor")]
public System.Nullable<float> NormalizationDivisor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty("minimum_output")]
public System.Nullable<float> MinimumOutput { get; set; } = null;
        

[JsonProperty("maximum_output")]
public System.Nullable<float> MaximumOutput { get; set; } = null;
        

[JsonProperty("output_unit_type")]
public Table_Lookup_OutputUnitType OutputUnitType { get; set; } = (Table_Lookup_OutputUnitType)Enum.Parse(typeof(Table_Lookup_OutputUnitType), "Dimensionless");
        

[JsonProperty("external_file_name")]
public string ExternalFileName { get; set; } = "";
        

[JsonProperty("external_file_column_number")]
public System.Nullable<float> ExternalFileColumnNumber { get; set; } = null;
        

[JsonProperty("external_file_starting_row_number")]
public System.Nullable<float> ExternalFileStartingRowNumber { get; set; } = null;
        

[JsonProperty("values")]
public string Values { get; set; } = "";
    }
    
    public enum Table_Lookup_NormalizationMethod
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("AutomaticWithDivisor")]
        AutomaticWithDivisor = 1,
        
        [JsonProperty("DivisorOnly")]
        DivisorOnly = 2,
        
        [JsonProperty("None")]
        None = 3,
    }
    
    public enum Table_Lookup_OutputUnitType
    {
        
        [JsonProperty("")]
        Empty = 0,
        
        [JsonProperty("Capacity")]
        Capacity = 1,
        
        [JsonProperty("Dimensionless")]
        Dimensionless = 2,
        
        [JsonProperty("Power")]
        Power = 3,
        
        [JsonProperty("Pressure")]
        Pressure = 4,
        
        [JsonProperty("Temperature")]
        Temperature = 5,
    }
}
