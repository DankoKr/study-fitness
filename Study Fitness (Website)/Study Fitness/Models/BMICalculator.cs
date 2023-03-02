using System.ComponentModel.DataAnnotations;

namespace Study_Fitness.Models
{
    public class BMICalculator
    {
        public BMICalculator() { }

        public BMICalculator(string sex, int age, double height, double weight) 
        {
            this.Sex = sex;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
        }

        [Required]
        public string Sex { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        public double Weight { get; set; }

        public double myBMI { get; set; }

        public void Calculate()
        {
            Height /= 100;
            myBMI = Weight / (Height * Height);
        }
    }
}
