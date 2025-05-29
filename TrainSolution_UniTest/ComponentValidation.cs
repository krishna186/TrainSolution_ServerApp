using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSolution_ServerApp.Models;

namespace TrainSolution_UniTest
{
    public class ComponentValidation
    {
        public bool IsValidComponents(TrainComponents comp, out List<string> errors)
        {
            errors = new List<string>();

            if (string.IsNullOrWhiteSpace(comp.SerialNumber))
                errors.Add("SerialNumber is required.");
            if (string.IsNullOrWhiteSpace(comp.Description))
                errors.Add("Description is required.");
            if (string.IsNullOrWhiteSpace(comp.VehicleNumber))
                errors.Add("VehicleNumber is required.");
            if (comp.InstallDate == default)
                errors.Add("InstallDate is invalid.");

            return errors.Count == 0;
        }
    }
}
