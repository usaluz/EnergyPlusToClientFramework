using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Overhangs are typically flat shading surfaces that reference a window or door.")]
    public class Shading_Overhang_Projection : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("window_or_door_name")]
        public string WindowOrDoorName { get; set; } = "";
        

        [JsonProperty("height_above_window_or_door")]
        public System.Nullable<float> HeightAboveWindowOrDoor { get; set; } = null;
        

        [JsonProperty("tilt_angle_from_window_door")]
        public System.Nullable<float> TiltAngleFromWindowDoor { get; set; } = (System.Nullable<float>)Single.Parse("90", CultureInfo.InvariantCulture);
        

        [JsonProperty("left_extension_from_window_door_width")]
        public System.Nullable<float> LeftExtensionFromWindowDoorWidth { get; set; } = null;
        

        [Description("N3 + N4 + Window/Door Width is Overhang Length")]
        [JsonProperty("right_extension_from_window_door_width")]
        public System.Nullable<float> RightExtensionFromWindowDoorWidth { get; set; } = null;
        

        [JsonProperty("depth_as_fraction_of_window_door_height")]
        public System.Nullable<float> DepthAsFractionOfWindowDoorHeight { get; set; } = null;
    }
}