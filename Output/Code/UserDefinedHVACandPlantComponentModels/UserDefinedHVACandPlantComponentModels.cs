namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
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
    using BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment;
    using BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage;
    using BH.oM.Adapters.EnergyPlus.WaterSystems;
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("Defines a generic zone air unit for custom modeling using Energy Management Syste" +
        "m or External Interface")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_ForcedAir_UserDefined : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance. It will be the main key of the serial" +
    "ization and all other properties will be sub properties of this key.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="overall_model_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string OverallModelSimulationProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="model_setup_and_sizing_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ModelSetupAndSizingProgramCallingManagerName { get; set; } = "";
        

[Description("Air inlet node for the unit must be a zone air exhaust Node.")]
[JsonProperty(PropertyName="primary_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PrimaryAirInletNodeName { get; set; } = "";
        

[Description("Air outlet node for the unit must be a zone air inlet node.")]
[JsonProperty(PropertyName="primary_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PrimaryAirOutletNodeName { get; set; } = "";
        

[Description("Inlet air used for heat rejection or air source")]
[JsonProperty(PropertyName="secondary_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SecondaryAirInletNodeName { get; set; } = "";
        

[Description("Outlet air used for heat rejection or air source")]
[JsonProperty(PropertyName="secondary_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SecondaryAirOutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="number_of_plant_loop_connections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NumberOfPlantLoopConnections { get; set; } = null;
        

[JsonProperty(PropertyName="plant_connection_1_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection1InletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_1_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection1OutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_2_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection2InletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_2_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection2OutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_3_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection3InletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_3_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection3OutletNodeName { get; set; } = "";
        

[Description("Water use storage tank for alternate source of water consumed by device")]
[JsonProperty(PropertyName="supply_inlet_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SupplyInletWaterStorageTankName { get; set; } = "";
        

[Description("Water use storage tank for collection of condensate by device")]
[JsonProperty(PropertyName="collection_outlet_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string CollectionOutletWaterStorageTankName { get; set; } = "";
        

[Description("Used for modeling device losses to surrounding zone")]
[JsonProperty(PropertyName="ambient_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AmbientZoneName { get; set; } = "";
    }
    
    [Description("Defines a generic single duct air terminal unit for custom modeling using Energy " +
        "Management System or External Interface")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirTerminal_SingleDuct_UserDefined : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance. It will be the main key of the serial" +
    "ization and all other properties will be sub properties of this key.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="overall_model_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string OverallModelSimulationProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="model_setup_and_sizing_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ModelSetupAndSizingProgramCallingManagerName { get; set; } = "";
        

[Description("Air inlet node for the unit must be a zone splitter outlet.")]
[JsonProperty(PropertyName="primary_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PrimaryAirInletNodeName { get; set; } = "";
        

[Description("Air outlet node for the unit must be a zone air inlet node.")]
[JsonProperty(PropertyName="primary_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PrimaryAirOutletNodeName { get; set; } = "";
        

[Description("Inlet air used for heat rejection or air source")]
[JsonProperty(PropertyName="secondary_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SecondaryAirInletNodeName { get; set; } = "";
        

[Description("Outlet air used for heat rejection or air source")]
[JsonProperty(PropertyName="secondary_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SecondaryAirOutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="number_of_plant_loop_connections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NumberOfPlantLoopConnections { get; set; } = null;
        

[JsonProperty(PropertyName="plant_connection_1_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection1InletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_1_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection1OutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_2_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection2InletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_2_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection2OutletNodeName { get; set; } = "";
        

[Description("Water use storage tank for alternate source of water consumed by device")]
[JsonProperty(PropertyName="supply_inlet_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SupplyInletWaterStorageTankName { get; set; } = "";
        

[Description("Water use storage tank for collection of condensate by device")]
[JsonProperty(PropertyName="collection_outlet_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string CollectionOutletWaterStorageTankName { get; set; } = "";
        

[Description("Used for modeling device losses to surrounding zone")]
[JsonProperty(PropertyName="ambient_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AmbientZoneName { get; set; } = "";
    }
    
    [Description("Defines a generic air system component for custom modeling using Energy Managemen" +
        "t System or External Interface")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_UserDefined : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance. It will be the main key of the serial" +
    "ization and all other properties will be sub properties of this key.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="overall_model_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string OverallModelSimulationProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="model_setup_and_sizing_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ModelSetupAndSizingProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="number_of_air_connections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NumberOfAirConnections { get; set; } = null;
        

[Description("Inlet air for primary air stream")]
[JsonProperty(PropertyName="air_connection_1_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AirConnection1InletNodeName { get; set; } = "";
        

[Description("Outlet air for primary air stream")]
[JsonProperty(PropertyName="air_connection_1_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AirConnection1OutletNodeName { get; set; } = "";
        

[Description("Inlet air for secondary air stream")]
[JsonProperty(PropertyName="air_connection_2_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AirConnection2InletNodeName { get; set; } = "";
        

[Description("Outlet air for secondary air stream")]
[JsonProperty(PropertyName="air_connection_2_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AirConnection2OutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_is_used", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Coil_UserDefined_PlantConnectionIsUsed PlantConnectionIsUsed { get; set; } = (Coil_UserDefined_PlantConnectionIsUsed)Enum.Parse(typeof(Coil_UserDefined_PlantConnectionIsUsed), "No");
        

[JsonProperty(PropertyName="plant_connection_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnectionInletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnectionOutletNodeName { get; set; } = "";
        

[Description("Water use storage tank for alternate source of water consumed by device")]
[JsonProperty(PropertyName="supply_inlet_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SupplyInletWaterStorageTankName { get; set; } = "";
        

[Description("Water use storage tank for collection of condensate by device")]
[JsonProperty(PropertyName="collection_outlet_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string CollectionOutletWaterStorageTankName { get; set; } = "";
        

[Description("Used for modeling device losses to surrounding zone")]
[JsonProperty(PropertyName="ambient_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AmbientZoneName { get; set; } = "";
    }
    
    public enum Coil_UserDefined_PlantConnectionIsUsed
    {
        
        [System.Runtime.Serialization.EnumMember(Value="No")]
        No = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="Yes")]
        Yes = 1,
    }
    
    [Description("Defines a generic plant component for custom modeling using Energy Management Sys" +
        "tem or External Interface")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantComponent_UserDefined : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance. It will be the main key of the serial" +
    "ization and all other properties will be sub properties of this key.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="main_model_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string MainModelProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="number_of_plant_loop_connections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NumberOfPlantLoopConnections { get; set; } = null;
        

[JsonProperty(PropertyName="plant_connection_1_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection1InletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_1_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection1OutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_1_loading_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantComponent_UserDefined_PlantConnection1LoadingMode PlantConnection1LoadingMode { get; set; } = (PlantComponent_UserDefined_PlantConnection1LoadingMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection1LoadingMode), "DemandsLoad");
        

[JsonProperty(PropertyName="plant_connection_1_loop_flow_request_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantComponent_UserDefined_PlantConnection1LoopFlowRequestMode PlantConnection1LoopFlowRequestMode { get; set; } = (PlantComponent_UserDefined_PlantConnection1LoopFlowRequestMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection1LoopFlowRequestMode), "NeedsFlowAndTurnsLoopOn");
        

[JsonProperty(PropertyName="plant_connection_1_initialization_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection1InitializationProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_1_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection1SimulationProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_2_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection2InletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_2_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection2OutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_2_loading_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantComponent_UserDefined_PlantConnection2LoadingMode PlantConnection2LoadingMode { get; set; } = (PlantComponent_UserDefined_PlantConnection2LoadingMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection2LoadingMode), "DemandsLoad");
        

[JsonProperty(PropertyName="plant_connection_2_loop_flow_request_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantComponent_UserDefined_PlantConnection2LoopFlowRequestMode PlantConnection2LoopFlowRequestMode { get; set; } = (PlantComponent_UserDefined_PlantConnection2LoopFlowRequestMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection2LoopFlowRequestMode), "NeedsFlowAndTurnsLoopOn");
        

[JsonProperty(PropertyName="plant_connection_2_initialization_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection2InitializationProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_2_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection2SimulationProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_3_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection3InletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_3_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection3OutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_3_loading_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantComponent_UserDefined_PlantConnection3LoadingMode PlantConnection3LoadingMode { get; set; } = (PlantComponent_UserDefined_PlantConnection3LoadingMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection3LoadingMode), "DemandsLoad");
        

[JsonProperty(PropertyName="plant_connection_3_loop_flow_request_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantComponent_UserDefined_PlantConnection3LoopFlowRequestMode PlantConnection3LoopFlowRequestMode { get; set; } = (PlantComponent_UserDefined_PlantConnection3LoopFlowRequestMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection3LoopFlowRequestMode), "NeedsFlowAndTurnsLoopOn");
        

[JsonProperty(PropertyName="plant_connection_3_initialization_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection3InitializationProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_3_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection3SimulationProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_4_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection4InletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_4_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection4OutletNodeName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_4_loading_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantComponent_UserDefined_PlantConnection4LoadingMode PlantConnection4LoadingMode { get; set; } = (PlantComponent_UserDefined_PlantConnection4LoadingMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection4LoadingMode), "DemandsLoad");
        

[JsonProperty(PropertyName="plant_connection_4_loop_flow_request_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public PlantComponent_UserDefined_PlantConnection4LoopFlowRequestMode PlantConnection4LoopFlowRequestMode { get; set; } = (PlantComponent_UserDefined_PlantConnection4LoopFlowRequestMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection4LoopFlowRequestMode), "NeedsFlowAndTurnsLoopOn");
        

[JsonProperty(PropertyName="plant_connection_4_initialization_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection4InitializationProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="plant_connection_4_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string PlantConnection4SimulationProgramCallingManagerName { get; set; } = "";
        

[Description("Inlet air used for heat rejection or air source")]
[JsonProperty(PropertyName="air_connection_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AirConnectionInletNodeName { get; set; } = "";
        

[Description("Outlet air used for heat rejection or air source")]
[JsonProperty(PropertyName="air_connection_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AirConnectionOutletNodeName { get; set; } = "";
        

[Description("Water use storage tank for alternate source of water consumed by device")]
[JsonProperty(PropertyName="supply_inlet_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SupplyInletWaterStorageTankName { get; set; } = "";
        

[Description("Water use storage tank for collection of condensate by device")]
[JsonProperty(PropertyName="collection_outlet_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string CollectionOutletWaterStorageTankName { get; set; } = "";
        

[Description("Used for modeling device losses to surrounding zone")]
[JsonProperty(PropertyName="ambient_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AmbientZoneName { get; set; } = "";
    }
    
    public enum PlantComponent_UserDefined_PlantConnection1LoadingMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="DemandsLoad")]
        DemandsLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetsLoadWithNominalCapacity")]
        MeetsLoadWithNominalCapacity = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetsLoadWithNominalCapacityHiOutLimit")]
        MeetsLoadWithNominalCapacityHiOutLimit = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetsLoadWithNominalCapacityLowOutLimit")]
        MeetsLoadWithNominalCapacityLowOutLimit = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetsLoadWithPassiveCapacity")]
        MeetsLoadWithPassiveCapacity = 4,
    }
    
    public enum PlantComponent_UserDefined_PlantConnection1LoopFlowRequestMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="NeedsFlowAndTurnsLoopOn")]
        NeedsFlowAndTurnsLoopOn = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NeedsFlowIfLoopOn")]
        NeedsFlowIfLoopOn = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ReceivesWhateverFlowAvailable")]
        ReceivesWhateverFlowAvailable = 2,
    }
    
    public enum PlantComponent_UserDefined_PlantConnection2LoadingMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="DemandsLoad")]
        DemandsLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithNominalCapacity")]
        MeetLoadWithNominalCapacity = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithNominalCapacityHiOutLimit")]
        MeetLoadWithNominalCapacityHiOutLimit = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithNominalCapacityLowOutLimit")]
        MeetLoadWithNominalCapacityLowOutLimit = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithPassiveCapacity")]
        MeetLoadWithPassiveCapacity = 4,
    }
    
    public enum PlantComponent_UserDefined_PlantConnection2LoopFlowRequestMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="NeedsFlowAndTurnsLoopOn")]
        NeedsFlowAndTurnsLoopOn = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NeedsFlowIfLoopOn")]
        NeedsFlowIfLoopOn = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ReceivesWhateverFlowAvailable")]
        ReceivesWhateverFlowAvailable = 2,
    }
    
    public enum PlantComponent_UserDefined_PlantConnection3LoadingMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="DemandsLoad")]
        DemandsLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithNominalCapacity")]
        MeetLoadWithNominalCapacity = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithNominalCapacityHiOutLimit")]
        MeetLoadWithNominalCapacityHiOutLimit = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithNominalCapacityLowOutLimit")]
        MeetLoadWithNominalCapacityLowOutLimit = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithPassiveCapacity")]
        MeetLoadWithPassiveCapacity = 4,
    }
    
    public enum PlantComponent_UserDefined_PlantConnection3LoopFlowRequestMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="NeedsFlowAndTurnsLoopOn")]
        NeedsFlowAndTurnsLoopOn = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NeedsFlowIfLoopOn")]
        NeedsFlowIfLoopOn = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ReceivesWhateverFlowAvailable")]
        ReceivesWhateverFlowAvailable = 2,
    }
    
    public enum PlantComponent_UserDefined_PlantConnection4LoadingMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="DemandsLoad")]
        DemandsLoad = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithNominalCapacity")]
        MeetLoadWithNominalCapacity = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithNominalCapacityHiOutLimit")]
        MeetLoadWithNominalCapacityHiOutLimit = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithNominalCapacityLowOutLimit")]
        MeetLoadWithNominalCapacityLowOutLimit = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MeetLoadWithPassiveCapacity")]
        MeetLoadWithPassiveCapacity = 4,
    }
    
    public enum PlantComponent_UserDefined_PlantConnection4LoopFlowRequestMode
    {
        
        [System.Runtime.Serialization.EnumMember(Value="NeedsFlowAndTurnsLoopOn")]
        NeedsFlowAndTurnsLoopOn = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="NeedsFlowIfLoopOn")]
        NeedsFlowIfLoopOn = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ReceivesWhateverFlowAvailable")]
        ReceivesWhateverFlowAvailable = 2,
    }
    
    [Description("Defines a generic plant operation scheme for custom supervisory control using Ene" +
        "rgy Management System or External Interface to dispatch loads")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantEquipmentOperation_UserDefined : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance. It will be the main key of the serial" +
    "ization and all other properties will be sub properties of this key.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="main_model_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string MainModelProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="initialization_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string InitializationProgramCallingManagerName { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_1_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment1ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment1Name { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_2_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment2ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment2Name { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_3_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment3ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_3_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment3Name { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_4_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment4ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_4_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment4Name { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_5_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment5ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_5_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment5Name { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_6_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment6ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_6_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment6Name { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_7_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment7ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_7_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment7Name { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_8_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment8ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_8_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment8Name { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_9_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment9ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_9_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment9Name { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_10_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment10ObjectType { get; set; } = "";
        

[JsonProperty(PropertyName="equipment_10_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string Equipment10Name { get; set; } = "";
    }
}
