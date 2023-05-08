using System.ComponentModel.DataAnnotations;

namespace Website.Models
{
    public class TDEECalculator
    {
        private string sex;
        private int age;
        private double height;
        private double weight;
        private string activity;
        private double tEF;
        private double bMR;
        private double eEE;
        private double nEAT;
        private double myTDEE;
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

        [Required]
        public string Activity
        {
            get { return activity; }
            set { activity = value; }
        }

        public double TEF
        {
            get { return tEF; }
            set { tEF = value; }
        }

        public double BMR
        {
            get { return bMR; }
            set { bMR = value; }
        }

        public double EEE
        {
            get { return eEE; }
            set { eEE = value; }
        }

        public double NEAT
        {
            get { return nEAT; }
            set { nEAT = value; }
        }

        public double MyTDEE
        {
            get { return myTDEE; }
            set { myTDEE = value; }
        }

        public void Calculate()
        {
			if (Activity == "low")
			{
				EEE = 250;
			}
			else if (Activity == "medium")
			{
				EEE = 350;
			}
			else if (Activity == "high")
			{
				EEE = 500;
			}

			BMR = Weight * 20;
			TEF = BMR * 0.1;
			NEAT = EEE;
			MyTDEE = BMR + TEF + EEE + NEAT;
		}
    }
}
