using System.ComponentModel.DataAnnotations;
namespace Website.Models
{
    public class TDEECalculator
    {
        public TDEECalculator() { }

        public TDEECalculator(string sex, int age, double height, double weight, string activity)
        {
            this.Sex = sex;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
            this.Activity = activity;
        }

        [Required]
        public string Sex { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        public string Activity { get; set; }
        public double TEF { get; set; }
        public double BMR { get; set; }
        public double EEE { get; set; }
        public double NEAT { get; set; }

        public double myTDEE { get; set; }

        //public void CalculateEEE(string level) 
        //{
        //    if (level == "low") { EEE = 250; }
        //    else if (level == "medium") { EEE = 350; }
        //    else { EEE = 500; }
        //}

        public void Calculate()
        {
            BMR = Weight * 20;
            TEF = BMR * 0.1;
            EEE = 250;
            NEAT = EEE;
            myTDEE = BMR + TEF + EEE + NEAT;
        }
    }
}
