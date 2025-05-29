using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSolution_UniTest
{
    public class UploadTrainCompomentsTest
    {
        [Fact]
        public void ParseCsv_ValidCsv_ReturnsTrainComponentTrue()
        {
            var parser = new UploadTrainCompoments();
            var csvLine = "SN12345,Test Train,Train01,2021-01-12";

            var result = parser.ParseCsv(csvLine);

            Assert.Equal("SN12345", result.SerialNumber);
            Assert.Equal("Test Train", result.Description);
            Assert.Equal("Train01", result.VehicleNumber);
            Assert.Equal(new DateTime(2023, 12, 1), result.InstallDate);
        }

        [Fact]
        public void ParseCsv_InvalidFieldCount_ThrowsException()
        {
            var parser = new UploadTrainCompoments();
            var csvLine = "SN12345,Test Train,Train01";

            Assert.Throws<FormatException>(() => parser.ParseCsv(csvLine));
        }

        [Fact]
        public void ParseCsv_InvalidDate_ThrowsException()
        {
            var parser = new UploadTrainCompoments();
            var csvLine = "SN12345,Test Train,Train01,null";

            Assert.Throws<FormatException>(() => parser.ParseCsv(csvLine));
        }
    }
}
