using TrainSolution_ServerApp.Models;

namespace TrainSolution_UniTest
{
    public class UploadTrainCompoments
    {     
        public TrainComponents ParseCsv(string line)
        {
            var fields = line.Split(',');
            if (fields.Length != 4)
                throw new FormatException("Incorrect number of fields");

            return new TrainComponents
            {
                SerialNumber = fields[0].Trim(),
                Description = fields[1].Trim(),
                VehicleNumber = fields[2].Trim(),
                InstallDate = DateTime.Parse(fields[3].Trim())
            };
        }
    }
}
