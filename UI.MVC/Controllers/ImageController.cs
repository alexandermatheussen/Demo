using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BL;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace D.UI.MVC.Controllers
{
    public class ImageController : Controller
    {
        private IIdeationManager ideationMgr;
        
        public ImageController()
        {
           // projectMgr = new ProjectManager();
            ideationMgr = new IdeationManager();
        }
        
        
        // GET
        public ActionResult ImageTest()
        {
            Idea idea = ideationMgr.getIdea(19);
            // Field[] fields = idea.fields.ToArray();
            var fields = idea.fields.ToArray();
            ICollection<ImageField> imageFields = new List<ImageField>();
           
            foreach (var imagefield in fields)
            {
                imageFields.Add((ImageField)imagefield);
            }
                
            
            return
            View(imageFields);
        }

     /*   [HttpPost]
        public IActionResult SaveTempData(FormCollection formCollection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Idea idea = new Idea();
                    TextField textField = new TextField();
                    ImageField imageField = new ImageField();
                    VideoField videoField = new VideoField();
                    MapField mapField = new MapField();

                    textField.text = formCollection["Text"].ToString();
                    //imageField.data = 

                    var file = formCollection["Type"];
                     
                    using (var reader = file.OpenReadStream())
                    using (var stream = new MemoryStream())
                    {
                        {    
                            reader.CopyTo(stream);
                            data = stream.ToArray();
                            image.data = data;
                            fields.Add(image);
                            i.fields = fields;
                            mgr.createIdea(i);
                              
                            var base64 = Convert.ToBase64String(data);
                            var imgSrc = String.Format("data:image/gif;base64,{0}", base64);
                            ViewBag.ImageSource = imgSrc;


                        }    
                                        
                    }
                    
                    idea.fields.Add(textField);
                        
                       

                    // TempData.Add(imageField);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return new UnsupportedMediaTypeResult();

        }
*/

    }
    
    
  
}