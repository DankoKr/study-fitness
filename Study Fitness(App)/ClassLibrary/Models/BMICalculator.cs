using System.ComponentModel.DataAnnotations;

namespace Website.Models
{
    public class BMICalculator
    {
        private string sex;
        private int age;
        private double height;
        private double weight;
        private double myBMI;
        public BMICalculator() { }

        public BMICalculator(string sex, int age, double height, double weight)
        {
            this.Sex = sex;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
        }

        [Required]
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        [Required]
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        [Required]
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        [Required]
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double MyBMI
        {
            get { return myBMI; }
            set { myBMI = value; }
        }

        public void Calculate()
        {
            Height /= 100;
            MyBMI = Weight / (Height * Height);
            MyBMI = Math.Round(MyBMI, 2);
        }
    }
}
