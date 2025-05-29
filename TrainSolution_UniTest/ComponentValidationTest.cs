using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSolution_ServerApp.Models;

namespace TrainSolution_UniTest
{
    public class ComponentValidationTest
    {
        [Fact]
        public void IsValid_ValidComponent_ReturnsTrue()
        {
            var validator = new ComponentValidation();
            var component = new TrainComponents
            {
                SerialNumber = "SN100",
                Description = "Test 23",
                VehicleNumber = "Train02",
                InstallDate = DateTime.Today
            };

            var result = validator.IsValidComponents(component, out var errors);

            Assert.True(result);
            Assert.Empty(errors);
        }

        [Fact]
        public void IsValid_MissingFields_ReturnsErrors()
        {
            var validator = new ComponentValidation();
            var component = new TrainComponents();

            var result = validator.IsValidComponents(component, out var errors);

            Assert.False(result);
            Assert.Contains("SerialNumber is required.", errors);
            Assert.Contains("Description is required.", errors);
            Assert.Contains("VehicleNumber is required.", errors);
            Assert.Contains("InstallDate is invalid.", errors);
        }
    }
}
