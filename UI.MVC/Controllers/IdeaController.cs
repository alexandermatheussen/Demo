using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace D.UI.MVC.Controllers
{
    public class IdeaController : Controller
    {
        public IActionResult Idea()
        {
            return View();
        }

        public IActionResult MapInput()
        {
            return View();
        }
            


        public IActionResult CreateIdea(IFormCollection form)
        {
            Idea idea = new Idea();
            //idea.fields.Add();


            return RedirectToAction("");
        }
        
        
      /*  
        [HttpPost("UploadFiles")]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count, size, filePath});
        }*/


      
    }
    
}