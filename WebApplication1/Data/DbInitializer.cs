using System.Linq;
using System;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1
{
    internal class DbInitializer
    {
        internal static void Init(ApplicationDbContext context, string cameraCSVStr)
        {
            context.Database.EnsureCreated();

            if (context.Cameras.Any())
            {
                return;
            }
            Func<string, decimal?> convertDecimal = (string field) =>
            {
                decimal? d = null;
                try
                {
                    d = Convert.ToDecimal(field);
                }
                catch
                {
                    d = null;
                }
                return d;
            };
            var lines = cameraCSVStr.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var line1 = true;
            foreach (var line in lines)
            {
                if (line1)
                {
                    line1 = false;
                    continue;
                }
                var columns = line.Split(',');
                var c = new Camera();
                c.Model = columns[0].ToString();
                c.ReleaseDate = convertDecimal(columns[1].ToString());
                c.MaxResolution = convertDecimal(columns[2].ToString());
                c.LowResolution = convertDecimal(columns[3].ToString());
                c.EffectivePixels = convertDecimal(columns[4].ToString());
                c.ZoomWide = convertDecimal(columns[5].ToString());
                c.ZoomTele = convertDecimal(columns[6].ToString());
                c.NormalFocusRange = convertDecimal(columns[7].ToString());
                c.MacroFocusRange = convertDecimal(columns[8].ToString());
                c.StorageIncluded = convertDecimal(columns[9].ToString());
                c.Weight = convertDecimal(columns[10].ToString());
                c.Dimensions = convertDecimal(columns[11].ToString());
                c.Price = convertDecimal(columns[12].ToString());
                context.Cameras.Add(c);
            }
            context.SaveChanges();
        }
      
    }
}