using MillingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MillingManagement.Helper
{
    public class PlantHelper
    {

        public IEnumerable<SelectListItem> GetPlants()
        {
            DataBaseContext db = new DataBaseContext();
            var plant = db.Plants.ToList();
            var plants = db.Plants.Select(s => new SelectListItem { Text = s.Title, Value = s.Id.ToString() }).ToList();
            return plants;
        }
                
    }
}