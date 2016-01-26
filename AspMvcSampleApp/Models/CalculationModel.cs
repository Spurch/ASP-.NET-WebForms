using System.ComponentModel;

namespace AspMvcSampleApp.Models
{
    public class CalculationModel
    {
        [DisplayName("First value:")]
        public int FirstValue { get; set; }

        [DisplayName("Second value:")]
        public int SecondValue { get; set; }

        [DisplayName("Result:")]
        public int ResultValue { get; set; }
    }
}