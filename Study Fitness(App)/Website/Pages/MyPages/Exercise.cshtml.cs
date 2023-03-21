using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using Website.Models;

namespace Website.Pages.MyPages
{
    public class ExerciseModel : PageModel
    {
        public List<TestDummyData> dummies { get; set; }

        public void OnGet()
        {
            DummyAdmin myDummy = new DummyAdmin();
            myDummy.GetDummyData();
            dummies = myDummy.GetEmployees();
        }

    }
}
