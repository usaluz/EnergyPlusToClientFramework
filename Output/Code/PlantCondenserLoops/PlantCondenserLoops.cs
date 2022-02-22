namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
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
    
    
    [Description("Defines a central plant loop.")]
    public class PlantLoop : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("fluid_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantLoop_FluidType FluidType { get; set; } = (PlantLoop_FluidType)Enum.Parse(typeof(PlantLoop_FluidType), "Water");
        

[Description("This field is only required when Fluid Type is UserDefinedFluidType")]
[JsonProperty("user_defined_fluid_type")]
public string UserDefinedFluidType { get; set; } = "";
        

[JsonProperty("plant_equipment_operation_scheme_name")]
public string PlantEquipmentOperationSchemeName { get; set; } = "";
        

[JsonProperty("loop_temperature_setpoint_node_name")]
public string LoopTemperatureSetpointNodeName { get; set; } = "";
        

[JsonProperty("maximum_loop_temperature")]
public System.Nullable<float> MaximumLoopTemperature { get; set; } = null;
        

[JsonProperty("minimum_loop_temperature")]
public System.Nullable<float> MinimumLoopTemperature { get; set; } = null;
        

[JsonProperty("maximum_loop_flow_rate")]
public string MaximumLoopFlowRate { get; set; } = "";
        

[JsonProperty("minimum_loop_flow_rate")]
public System.Nullable<float> MinimumLoopFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("plant_loop_volume")]
public string PlantLoopVolume { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("plant_side_inlet_node_name")]
public string PlantSideInletNodeName { get; set; } = "";
        

[JsonProperty("plant_side_outlet_node_name")]
public string PlantSideOutletNodeName { get; set; } = "";
        

[JsonProperty("plant_side_branch_list_name")]
public string PlantSideBranchListName { get; set; } = "";
        

[JsonProperty("plant_side_connector_list_name")]
public string PlantSideConnectorListName { get; set; } = "";
        

[JsonProperty("demand_side_inlet_node_name")]
public string DemandSideInletNodeName { get; set; } = "";
        

[JsonProperty("demand_side_outlet_node_name")]
public string DemandSideOutletNodeName { get; set; } = "";
        

[JsonProperty("demand_side_branch_list_name")]
public string DemandSideBranchListName { get; set; } = "";
        

[JsonProperty("demand_side_connector_list_name")]
public string DemandSideConnectorListName { get; set; } = "";
        

[JsonProperty("load_distribution_scheme")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantLoop_LoadDistributionScheme LoadDistributionScheme { get; set; } = (PlantLoop_LoadDistributionScheme)Enum.Parse(typeof(PlantLoop_LoadDistributionScheme), "SequentialLoad");
        

[JsonProperty("availability_manager_list_name")]
public string AvailabilityManagerListName { get; set; } = "";
        

[JsonProperty("plant_loop_demand_calculation_scheme")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantLoop_PlantLoopDemandCalculationScheme PlantLoopDemandCalculationScheme { get; set; } = (PlantLoop_PlantLoopDemandCalculationScheme)Enum.Parse(typeof(PlantLoop_PlantLoopDemandCalculationScheme), "SingleSetpoint");
        

[Description(@"Specifies a primary-secondary loop configuration. The plant side is the primary loop, and the demand side is the secondary loop. A secondary supply pump is required on the demand side. None = Primary-only, no secondary simulation CommonPipe = Primary-secondary with no temperature control at primary-secondary interface TwoWayCommonPipe = Primary-secondary with control of secondary supply temperature or primary return temperature (requires a setpoint be placed on the plant side or demand side inlet node).")]
[JsonProperty("common_pipe_simulation")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantLoop_CommonPipeSimulation CommonPipeSimulation { get; set; } = (PlantLoop_CommonPipeSimulation)Enum.Parse(typeof(PlantLoop_CommonPipeSimulation), "None");
        

[JsonProperty("pressure_simulation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantLoop_PressureSimulationType PressureSimulationType { get; set; } = (PlantLoop_PressureSimulationType)Enum.Parse(typeof(PlantLoop_PressureSimulationType), "None");
        

[Description("This field is only used to autocalulate the Plant Loop Volume. Loop Volume = Loop" +
    " Circulation Time * Maximum Loop Flow Rate")]
[JsonProperty("loop_circulation_time")]
public System.Nullable<float> LoopCirculationTime { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
    
    public enum PlantLoop_FluidType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Steam")]
        Steam = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefinedFluidType")]
        UserDefinedFluidType = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="Water")]
        Water = 3,
    }
    
    public enum PlantLoop_LoadDistributionScheme
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Optimal")]
        Optimal = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SequentialLoad")]
        SequentialLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SequentialUniformPLR")]
        SequentialUniformPLR = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="UniformLoad")]
        UniformLoad = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="UniformPLR")]
        UniformPLR = 5,
    }
    
    public enum PlantLoop_PlantLoopDemandCalculationScheme
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="DualSetpointDeadband")]
        DualSetpointDeadband = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SingleSetpoint")]
        SingleSetpoint = 2,
    }
    
    public enum PlantLoop_CommonPipeSimulation
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CommonPipe")]
        CommonPipe = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="TwoWayCommonPipe")]
        TwoWayCommonPipe = 3,
    }
    
    public enum PlantLoop_PressureSimulationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LoopFlowCorrection")]
        LoopFlowCorrection = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PumpPowerCorrection")]
        PumpPowerCorrection = 3,
    }
    
    [Description("Defines a central plant condenser loop. CondenserLoop and PlantLoop are nearly id" +
        "entical except some components and operation schemes are applicable to only one " +
        "loop type or the other.")]
    public class CondenserLoop : BHoMObject, IEnergyPlusClass
    {
        

[JsonProperty("fluid_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CondenserLoop_FluidType FluidType { get; set; } = (CondenserLoop_FluidType)Enum.Parse(typeof(CondenserLoop_FluidType), "Water");
        

[Description("This field is only required when Fluid Type is UserDefinedFluidType")]
[JsonProperty("user_defined_fluid_type")]
public string UserDefinedFluidType { get; set; } = "";
        

[JsonProperty("condenser_equipment_operation_scheme_name")]
public string CondenserEquipmentOperationSchemeName { get; set; } = "";
        

[JsonProperty("condenser_loop_temperature_setpoint_node_name")]
public string CondenserLoopTemperatureSetpointNodeName { get; set; } = "";
        

[JsonProperty("maximum_loop_temperature")]
public System.Nullable<float> MaximumLoopTemperature { get; set; } = null;
        

[JsonProperty("minimum_loop_temperature")]
public System.Nullable<float> MinimumLoopTemperature { get; set; } = null;
        

[JsonProperty("maximum_loop_flow_rate")]
public string MaximumLoopFlowRate { get; set; } = "";
        

[JsonProperty("minimum_loop_flow_rate")]
public System.Nullable<float> MinimumLoopFlowRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty("condenser_loop_volume")]
public string CondenserLoopVolume { get; set; } = (System.String)"Autocalculate";
        

[JsonProperty("condenser_side_inlet_node_name")]
public string CondenserSideInletNodeName { get; set; } = "";
        

[JsonProperty("condenser_side_outlet_node_name")]
public string CondenserSideOutletNodeName { get; set; } = "";
        

[JsonProperty("condenser_side_branch_list_name")]
public string CondenserSideBranchListName { get; set; } = "";
        

[JsonProperty("condenser_side_connector_list_name")]
public string CondenserSideConnectorListName { get; set; } = "";
        

[JsonProperty("demand_side_inlet_node_name")]
public string DemandSideInletNodeName { get; set; } = "";
        

[JsonProperty("demand_side_outlet_node_name")]
public string DemandSideOutletNodeName { get; set; } = "";
        

[JsonProperty("condenser_demand_side_branch_list_name")]
public string CondenserDemandSideBranchListName { get; set; } = "";
        

[JsonProperty("condenser_demand_side_connector_list_name")]
public string CondenserDemandSideConnectorListName { get; set; } = "";
        

[JsonProperty("load_distribution_scheme")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CondenserLoop_LoadDistributionScheme LoadDistributionScheme { get; set; } = (CondenserLoop_LoadDistributionScheme)Enum.Parse(typeof(CondenserLoop_LoadDistributionScheme), "SequentialLoad");
        

[JsonProperty("pressure_simulation_type")]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CondenserLoop_PressureSimulationType PressureSimulationType { get; set; } = (CondenserLoop_PressureSimulationType)Enum.Parse(typeof(CondenserLoop_PressureSimulationType), "None");
        

[Description("This field is only used to autocalulate the Condenser Loop Volume. Loop Volume = " +
    "Loop Circulation Time * Maximum Loop Flow Rate")]
[JsonProperty("loop_circulation_time")]
public System.Nullable<float> LoopCirculationTime { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
    }
    
    public enum CondenserLoop_FluidType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="UserDefinedFluidType")]
        UserDefinedFluidType = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="Water")]
        Water = 2,
    }
    
    public enum CondenserLoop_LoadDistributionScheme
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Optimal")]
        Optimal = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="SequentialLoad")]
        SequentialLoad = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="SequentialUniformPLR")]
        SequentialUniformPLR = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="UniformLoad")]
        UniformLoad = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="UniformPLR")]
        UniformPLR = 5,
    }
    
    public enum CondenserLoop_PressureSimulationType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="null")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="LoopFlowCorrection")]
        LoopFlowCorrection = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="PumpPowerCorrection")]
        PumpPowerCorrection = 3,
    }
}