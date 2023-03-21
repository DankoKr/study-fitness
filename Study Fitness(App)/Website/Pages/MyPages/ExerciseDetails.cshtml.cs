using ClassLibrary;
using ClassLibrary.ExerciseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Website.Models;

namespace Website.Pages.MyPages
{
    public class ExerciseDetailscshtmlModel : PageModel
    {
        public TestDummyData dummyData { get; set; }
        public void OnGet(int id)
        {
            DummyAdmin dataManager = new DummyAdmin();
            dummyData = dataManager.GetDummyId(id);
        }

    }
}
