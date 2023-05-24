using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.MyPages
{
    [Authorize(Policy = "AdminOnly")]
    public class UploadImageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly IWebHostEnvironment _he;
        [BindProperty]
        public IFormFile UploadFile { get; set; }
        public string Message { get; set; }

        public UploadImageModel(IWebHostEnvironment he)
        {
            _he = he;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var FileUpload = Path.Combine(_he.WebRootPath, "Images", UploadFile.FileName);
            using (var Fs = new FileStream(FileUpload, FileMode.Create))
            {
                await UploadFile.CopyToAsync(Fs);
                ViewData["Message"] = "The Selected File " + UploadFile.FileName + " is uploaded!";
            }

            return RedirectToPage("/MyPages/AddCardio", new { FileName = UploadFile.FileName });
        }
    }
}
