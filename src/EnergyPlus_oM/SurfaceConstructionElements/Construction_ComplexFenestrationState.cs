using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Describes one state for a complex glazing system These input objects are typicall" +
                 "y generated by using WINDOW software and export to IDF syntax")]
    public class Construction_ComplexFenestrationState : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("basis_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Construction_ComplexFenestrationState_BasisType BasisType { get; set; } = (Construction_ComplexFenestrationState_BasisType)Enum.Parse(typeof(Construction_ComplexFenestrationState_BasisType), "LBNLWINDOW");
        

        [JsonProperty("basis_symmetry_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
}