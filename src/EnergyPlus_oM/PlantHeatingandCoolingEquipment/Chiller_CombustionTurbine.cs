using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("This chiller model is the empirical model from the Building Loads and System Ther" +
                 "modynamics (BLAST) program. Chiller performance curves are generated by fitting " +
                 "catalog data to third order polynomial equations. Three sets of coefficients are" +
                 " required.")]
    public class Chiller_CombustionTurbine : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("condenser_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Chiller_CombustionTurbine_CondenserType CondenserType { get; set; } = (Chiller_CombustionTurbine_CondenserType)Enum.Parse(typeof(Chiller_CombustionTurbine_CondenserType), "AirCooled");
        

        [JsonProperty("nominal_capacity")]
        public string NominalCapacity { get; set; } = "";
        

        [JsonProperty("nominal_cop")]
        public System.Nullable<float> NominalCop { get; set; } = null;
        

        [JsonProperty("chilled_water_inlet_node_name")]
        public string ChilledWaterInletNodeName { get; set; } = "";
        

        [JsonProperty("chilled_water_outlet_node_name")]
        public string ChilledWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_inlet_node_name")]
        public string CondenserInletNodeName { get; set; } = "";
        

        [JsonProperty("condenser_outlet_node_name")]
        public string CondenserOutletNodeName { get; set; } = "";
        

        [JsonProperty("minimum_part_load_ratio")]
        public System.Nullable<float> MinimumPartLoadRatio { get; set; } = null;
        

        [JsonProperty("maximum_part_load_ratio")]
        public System.Nullable<float> MaximumPartLoadRatio { get; set; } = null;
        

        [JsonProperty("optimum_part_load_ratio")]
        public System.Nullable<float> OptimumPartLoadRatio { get; set; } = null;
        

        [JsonProperty("design_condenser_inlet_temperature")]
        public System.Nullable<float> DesignCondenserInletTemperature { get; set; } = null;
        

        [JsonProperty("temperature_rise_coefficient")]
        public System.Nullable<float> TemperatureRiseCoefficient { get; set; } = null;
        

        [JsonProperty("design_chilled_water_outlet_temperature")]
        public System.Nullable<float> DesignChilledWaterOutletTemperature { get; set; } = null;
        

        [Description("For variable volume this is the max flow & for constant flow this is the flow.")]
        [JsonProperty("design_chilled_water_flow_rate")]
        public string DesignChilledWaterFlowRate { get; set; } = "";
        

        [Description("This field is not used for Condenser Type = AirCooled or EvaporativelyCooled")]
        [JsonProperty("design_condenser_water_flow_rate")]
        public string DesignCondenserWaterFlowRate { get; set; } = "";
        

        [JsonProperty("coefficient_1_of_capacity_ratio_curve")]
        public System.Nullable<float> Coefficient1OfCapacityRatioCurve { get; set; } = null;
        

        [JsonProperty("coefficient_2_of_capacity_ratio_curve")]
        public System.Nullable<float> Coefficient2OfCapacityRatioCurve { get; set; } = null;
        

        [JsonProperty("coefficient_3_of_capacity_ratio_curve")]
        public System.Nullable<float> Coefficient3OfCapacityRatioCurve { get; set; } = null;
        

        [JsonProperty("coefficient_1_of_power_ratio_curve")]
        public System.Nullable<float> Coefficient1OfPowerRatioCurve { get; set; } = null;
        

        [JsonProperty("coefficient_2_of_power_ratio_curve")]
        public System.Nullable<float> Coefficient2OfPowerRatioCurve { get; set; } = null;
        

        [JsonProperty("coefficient_3_of_power_ratio_curve")]
        public System.Nullable<float> Coefficient3OfPowerRatioCurve { get; set; } = null;
        

        [JsonProperty("coefficient_1_of_full_load_ratio_curve")]
        public System.Nullable<float> Coefficient1OfFullLoadRatioCurve { get; set; } = null;
        

        [JsonProperty("coefficient_2_of_full_load_ratio_curve")]
        public System.Nullable<float> Coefficient2OfFullLoadRatioCurve { get; set; } = null;
        

        [JsonProperty("coefficient_3_of_full_load_ratio_curve")]
        public System.Nullable<float> Coefficient3OfFullLoadRatioCurve { get; set; } = null;
        

        [Description("Special Gas Turbine Chiller Parameters Below")]
        [JsonProperty("chilled_water_outlet_temperature_lower_limit")]
        public System.Nullable<float> ChilledWaterOutletTemperatureLowerLimit { get; set; } = null;
        

        [JsonProperty("coefficient_1_of_fuel_input_curve")]
        public System.Nullable<float> Coefficient1OfFuelInputCurve { get; set; } = null;
        

        [JsonProperty("coefficient_2_of_fuel_input_curve")]
        public System.Nullable<float> Coefficient2OfFuelInputCurve { get; set; } = null;
        

        [JsonProperty("coefficient_3_of_fuel_input_curve")]
        public System.Nullable<float> Coefficient3OfFuelInputCurve { get; set; } = null;
        

        [JsonProperty("coefficient_1_of_temperature_based_fuel_input_curve")]
        public System.Nullable<float> Coefficient1OfTemperatureBasedFuelInputCurve { get; set; } = null;
        

        [JsonProperty("coefficient_2_of_temperature_based_fuel_input_curve")]
        public System.Nullable<float> Coefficient2OfTemperatureBasedFuelInputCurve { get; set; } = null;
        

        [JsonProperty("coefficient_3_of_temperature_based_fuel_input_curve")]
        public System.Nullable<float> Coefficient3OfTemperatureBasedFuelInputCurve { get; set; } = null;
        

        [JsonProperty("coefficient_1_of_exhaust_flow_curve")]
        public System.Nullable<float> Coefficient1OfExhaustFlowCurve { get; set; } = null;
        

        [JsonProperty("coefficient_2_of_exhaust_flow_curve")]
        public System.Nullable<float> Coefficient2OfExhaustFlowCurve { get; set; } = null;
        

        [JsonProperty("coefficient_3_of_exhaust_flow_curve")]
        public System.Nullable<float> Coefficient3OfExhaustFlowCurve { get; set; } = null;
        

        [JsonProperty("coefficient_1_of_exhaust_gas_temperature_curve")]
        public System.Nullable<float> Coefficient1OfExhaustGasTemperatureCurve { get; set; } = null;
        

        [JsonProperty("coefficient_2_of_exhaust_gas_temperature_curve")]
        public System.Nullable<float> Coefficient2OfExhaustGasTemperatureCurve { get; set; } = null;
        

        [JsonProperty("coefficient_3_of_exhaust_gas_temperature_curve")]
        public System.Nullable<float> Coefficient3OfExhaustGasTemperatureCurve { get; set; } = null;
        

        [JsonProperty("coefficient_1_of_temperature_based_exhaust_gas_temperature_curve")]
        public System.Nullable<float> Coefficient1OfTemperatureBasedExhaustGasTemperatureCurve { get; set; } = null;
        

        [JsonProperty("coefficient_2_of_temperature_based_exhaust_gas_temperature_curve")]
        public System.Nullable<float> Coefficient2OfTemperatureBasedExhaustGasTemperatureCurve { get; set; } = null;
        

        [JsonProperty("coefficient_3_of_temperature_based_exhaust_gas_temperature_curve")]
        public System.Nullable<float> Coefficient3OfTemperatureBasedExhaustGasTemperatureCurve { get; set; } = null;
        

        [JsonProperty("coefficient_1_of_recovery_lube_heat_curve")]
        public System.Nullable<float> Coefficient1OfRecoveryLubeHeatCurve { get; set; } = null;
        

        [JsonProperty("coefficient_2_of_recovery_lube_heat_curve")]
        public System.Nullable<float> Coefficient2OfRecoveryLubeHeatCurve { get; set; } = null;
        

        [JsonProperty("coefficient_3_of_recovery_lube_heat_curve")]
        public System.Nullable<float> Coefficient3OfRecoveryLubeHeatCurve { get; set; } = null;
        

        [JsonProperty("coefficient_1_of_u_factor_times_area_curve")]
        public System.Nullable<float> Coefficient1OfUFactorTimesAreaCurve { get; set; } = null;
        

        [Description("typical value .9")]
        [JsonProperty("coefficient_2_of_u_factor_times_area_curve")]
        public System.Nullable<float> Coefficient2OfUFactorTimesAreaCurve { get; set; } = null;
        

        [JsonProperty("gas_turbine_engine_capacity")]
        public string GasTurbineEngineCapacity { get; set; } = "";
        

        [JsonProperty("maximum_exhaust_flow_per_unit_of_power_output")]
        public System.Nullable<float> MaximumExhaustFlowPerUnitOfPowerOutput { get; set; } = null;
        

        [JsonProperty("design_steam_saturation_temperature")]
        public System.Nullable<float> DesignSteamSaturationTemperature { get; set; } = null;
        

        [JsonProperty("fuel_higher_heating_value")]
        public System.Nullable<float> FuelHigherHeatingValue { get; set; } = null;
        

        [Description("If non-zero, then the heat recovery inlet and outlet node names must be entered.")]
        [JsonProperty("design_heat_recovery_water_flow_rate")]
        public string DesignHeatRecoveryWaterFlowRate { get; set; } = (System.String)"0";
        

        [JsonProperty("heat_recovery_inlet_node_name")]
        public string HeatRecoveryInletNodeName { get; set; } = "";
        

        [JsonProperty("heat_recovery_outlet_node_name")]
        public string HeatRecoveryOutletNodeName { get; set; } = "";
        

        [Description(@"Select operating mode for fluid flow through the chiller. ""NotModulated"" is for either variable or constant pumping with flow controlled by the external plant system. ""ConstantFlow"" is for constant pumping with flow controlled by chiller to operate at full design flow rate. ""LeavingSetpointModulated"" is for variable pumping with flow controlled by chiller to vary flow to target a leaving temperature setpoint.")]
        [JsonProperty("chiller_flow_mode")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Chiller_CombustionTurbine_ChillerFlowMode ChillerFlowMode { get; set; } = (Chiller_CombustionTurbine_ChillerFlowMode)Enum.Parse(typeof(Chiller_CombustionTurbine_ChillerFlowMode), "NotModulated");
        

        [JsonProperty("fuel_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Chiller_CombustionTurbine_FuelType FuelType { get; set; } = (Chiller_CombustionTurbine_FuelType)Enum.Parse(typeof(Chiller_CombustionTurbine_FuelType), "NaturalGas");
        

        [JsonProperty("heat_recovery_maximum_temperature")]
        public System.Nullable<float> HeatRecoveryMaximumTemperature { get; set; } = (System.Nullable<float>)Single.Parse("80", CultureInfo.InvariantCulture);
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty("sizing_factor")]
        public System.Nullable<float> SizingFactor { get; set; } = (System.Nullable<float>)Single.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, The heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the chiller is not operating.")]
        [JsonProperty("basin_heater_capacity")]
        public System.Nullable<float> BasinHeaterCapacity { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
                     "or dry-bulb temperature when the basin heater turns on.")]
        [JsonProperty("basin_heater_setpoint_temperature")]
        public System.Nullable<float> BasinHeaterSetpointTemperature { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty("basin_heater_operating_schedule_name")]
        public string BasinHeaterOperatingScheduleName { get; set; } = "";
        

        [Description("This optional field is the fraction of total rejected heat that can be recovered " +
                     "at full load. Also used to autosize Design Heat Recovery Water Flow Rate as a fr" +
                     "action of Design Condenser Water Flow Rate.")]
        [JsonProperty("condenser_heat_recovery_relative_capacity_fraction")]
        public System.Nullable<float> CondenserHeatRecoveryRelativeCapacityFraction { get; set; } = null;
        

        [Description("This optional field is the nominal turbine engine efficiency and is used when Gas" +
                     " Turbine Engine Capacity is set to Autosize")]
        [JsonProperty("turbine_engine_efficiency")]
        public System.Nullable<float> TurbineEngineEfficiency { get; set; } = (System.Nullable<float>)Single.Parse("0.35", CultureInfo.InvariantCulture);
    }
}