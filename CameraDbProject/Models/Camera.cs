using System;
using System.ComponentModel.DataAnnotations;

namespace CameraDbProject.Models {
    public class Camera {
        [Key]
        public long Id { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public Decimal? MaxResolution { get; set; }
        public Decimal? LowResolution { get; set; }
        public Decimal? EffectivePixels { get; set; }
        public Decimal? ZoomWide { get; set; }
        public Decimal? ZoomTele { get; set; }
        public Decimal? NormalFocusRange { get; set; }
        public Decimal? MacroFocusRange { get; set; }
        public Decimal? StorageIncluded { get; set; }
        public Decimal? Weight { get; set; }
        public Decimal? Dimensions { get; set; }
        public Decimal? Price { get; set; }
    }
}