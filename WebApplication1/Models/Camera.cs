using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Camera
    {
        [Key]
        public long Id { get; set; }
        public string Model { get; set; }
        public decimal? ReleaseDate { get; set; }
        public decimal? MaxResolution { get; set; }
        public decimal? LowResolution { get; set; }
        public decimal? EffectivePixels { get; set; }
        public decimal? ZoomWide { get; set; }
        public decimal? ZoomTele { get; set; }
        public decimal? NormalFocusRange { get; set; }
        public decimal? MacroFocusRange { get; set; }
        public decimal? StorageIncluded { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Dimensions { get; set; }
        public decimal? Price { get; set; }
    }
}

/*

<td>{c.Id}</td>
<td>{c.Model}</td>
<td>{c.ReleaseDate}</td>
<td>{c.MaxResolution}</td>
<td>{c.LowResolution}</td>
<td>{c.EffectivePixels}</td>
<td>{c.ZoomWide}</td>
<td>{c.ZoomTele}</td>
<td>{c.NormalFocusRange}</td>
<td>{c.MacroFocusRange}</td>
<td>{c.StorageIncluded}</td>
<td>{c.Weight}</td>
<td>{c.Dimensions}</td>
<td>{c.Price}</td>

    */
