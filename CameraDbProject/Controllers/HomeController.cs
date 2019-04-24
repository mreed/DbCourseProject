using CameraDbProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CameraDbProject.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult MoveCamerasToDatabase() {
            string contentRootPath = Server.MapPath("~/APP_DATA/");
            List<Camera> cameras = new List<Camera>();

            try {
                var csv = System.IO.File.ReadLines($"{contentRootPath}/Data/Camera.csv");
                //using (var reader = new StreamReader($"{contentRootPath}/Data/Camera.csv"))
                //using (var csv = new CsvReader(reader)) {
                //    csv.Configuration.Delimiter = ";";
                //    csv.Configuration.HasHeaderRecord = true;
                //    cameras = csv.GetRecords<Camera>().ToList();
                //}
                //Model;Year;MaxResolution;LowResolution;EffectivePixels;ZoomWide;ZoomTele;NormalFocusRange;MacroFocusRange;StorageIncluded;Weight;Dimensions;Price
                Func<string, Decimal?> decimalConverter = (string str) => {
                    if (String.IsNullOrEmpty(str)) {
                        return null;
                    }
                    else
                        return Convert.ToDecimal(str);
                };

                //Console.WriteLine($"csv has ${csv.Count()} lines.");
                int lineCount = 0;

                if (csv != null && csv.Count() > 0) {
                    foreach (var line in csv) {
                        if (lineCount < 1) {
                            lineCount++;
                            continue;
                        }
                        var splitLine = line.Split(new char[] { ';' });
                        if (splitLine.Count() != 13) {
                            throw new InvalidOperationException($"line ${line} is not 13 in length");
                        }
                        Camera c = new Camera();
                        c.Model = splitLine[0];
                        c.Year = splitLine[1];
                        c.MaxResolution = decimalConverter(splitLine[2]);
                        c.LowResolution = decimalConverter(splitLine[3]);
                        c.EffectivePixels = decimalConverter(splitLine[4]);
                        c.ZoomWide = decimalConverter(splitLine[5]);
                        c.ZoomTele = decimalConverter(splitLine[6]);
                        c.NormalFocusRange = decimalConverter(splitLine[7]);
                        c.MacroFocusRange = decimalConverter(splitLine[8]);
                        c.StorageIncluded = decimalConverter(splitLine[9]);
                        c.Weight = decimalConverter(splitLine[10]);
                        c.Dimensions = decimalConverter(splitLine[11]);
                        c.Price = decimalConverter(splitLine[12]);
                        cameras.Add(c);
                    }
                    using (var db = new ApplicationDbContext()) {
                        db.Cameras.AddRange(cameras);
                        db.SaveChanges();
                    }
                    return Content("Success");
                }
                else {
                    throw new InvalidOperationException("Could not load camera csv");
                }

            }
            catch (System.IO.IOException ex) {
                Console.WriteLine($"Could not get file ${ex.Message}");
                throw;
            }
            catch (Exception ex) {
                Console.WriteLine($"Exception thrown ${ex.Message}");
                throw;
            }
        }
    }
}