// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace AutoWorldML.Model
{
    public class ModelInput
    {
        [ColumnName("Url"), LoadColumn(0)]
        public string Url { get; set; }


        [ColumnName("Make"), LoadColumn(1)]
        public string Make { get; set; }


        [ColumnName("Model"), LoadColumn(2)]
        public string Model { get; set; }


        [ColumnName("Year"), LoadColumn(3)]
        public float Year { get; set; }


        [ColumnName("Power"), LoadColumn(4)]
        public float Power { get; set; }


        [ColumnName("Mileage"), LoadColumn(5)]
        public float Mileage { get; set; }


        [ColumnName("Eurostandard"), LoadColumn(6)]
        public string Eurostandard { get; set; }


        [ColumnName("Gearbox"), LoadColumn(7)]
        public string Gearbox { get; set; }


        [ColumnName("Price"), LoadColumn(8)]
        public float Price { get; set; }


    }
}