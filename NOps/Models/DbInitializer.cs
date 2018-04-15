using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Antiforgery.Internal;

namespace NOps.Models
{
    public static class DbInitializer
    {
        public static void InitializeDatabase(NOpsContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Railroads.Any())
            {
                return;   // DB has been seeded
            }

            Railroad railroad = new Railroad();
            //railroad.Id = 1;
            railroad.Name = "MB&W";
            railroad.Description = "Mud Bay & Western";
            railroad.UseScaleUnits = true;
            railroad.UseMetric = false;
            railroad.LengthByCount = true;
            railroad.WeightByCount = true;
        

            context.Railroads.Add(railroad);

            context.SaveChanges();
        }
    }
}
