using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Study_Fitness.Pages
{
    public class BMIModel : PageModel
    {
        public bool hasData = false;
        public string? sex;
        public int age;
        public double height;
        public double weight;
        public double result;

        public void OnGet()
        {
        }

        public void OnPost() 
        {
            hasData = true;
            sex = Request.Form["sex"];
            age = Convert.ToInt32(Request.Form["age"]);
            height = Convert.ToDouble(Request.Form["height"]);
            weight = Convert.ToDouble(Request.Form["weight"]);
            Calculate(height, weight);
        }

        public void Calculate(double height, double weight) 
        {
            result = weight / height * height;
        }
    }
}
