// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace AutoWorldML
{
    public partial class MLModel
    {
        /// <summary>
        /// model input class for MLModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"Url")]
            public string Url { get; set; }

            [ColumnName(@"Make")]
            public string Make { get; set; }

            [ColumnName(@"Model")]
            public string Model { get; set; }

            [ColumnName(@"Year")]
            public float Year { get; set; }

            [ColumnName(@"Power")]
            public float Power { get; set; }

            [ColumnName(@"Mileage")]
            public float Mileage { get; set; }

            [ColumnName(@"Eurostandard")]
            public string Eurostandard { get; set; }

            [ColumnName(@"Gearbox")]
            public string Gearbox { get; set; }

            [ColumnName(@"Price")]
            public float Price { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            public float Score { get; set; }
        }
        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLModel.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
