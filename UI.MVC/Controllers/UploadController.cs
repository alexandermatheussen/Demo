using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using BL;
using Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace D.UI.MVC.Controllers
{
    public class UploadController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        private IIdeationManager mgr;

        public UploadController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            mgr = new IdeationManager();
        }

        [HttpPost]
        public IActionResult Index(IList<IFormFile> files)
        {

           /* foreach (IFormFile item in files )
            {
                string filename = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim().ToString();
                filename = this.EnsureFilename(filename);
               using (FileStream fileStream = System.IO.File.Create(this.Getpath(filename)))
                {
                    item.CopyTo(fileStream);
                }
                  
  
            }
         */
           var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "upload");
           foreach (var file in files) {
               if (file.Length > 0) {
                   var filePath = Path.Combine(uploads, file.FileName);
                   using (var fileStream = new FileStream(filePath, FileMode.Create)) {
                        file.CopyTo(fileStream);
                   }

                   ICollection<Field> fields = new List<Field>();
                   ImageField image = new ImageField();
                   Idea i = new Idea(){};
                   Byte[] data = null;
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
                   
                   
               }
           }
           
            return this.Content("succes");
        }



        private string Getpath(string filename)
        {
            string path = _hostingEnvironment.WebRootPath + "\\upload\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path + filename;
        }

        public ActionResult  Show(int id)
        {

            Idea idea = mgr.getIdea(id);
            Field[] fields = idea.fields.ToArray();
            ImageField imageField = (ImageField) fields[0];
            
            
            var base64 = Convert.ToBase64String(imageField.data);
            var imgSrc = String.Format("data:image/png;base64,{0}", base64);

        

            /* Field[] fields;
             fields = mgr.getIdea(id).fields.ToArray();
             var image = (ImageField) fields[1];
             var data = image.data;
 */
            return base.File(base64,"data:image/gif;base64,{0}");
        }

     /*   public ActionResult ImageTest()
        {
            Idea idea = mgr.getIdea(19);
            Field[] fields = idea.fields.ToArray();
            ImageField imageField = (ImageField) fields[0];
            
            
            var base64 = Convert.ToBase64String(imageField.data);
            var imgSrc = String.Format("data:image/png;base64,{0}", base64);

            ViewBag.ImageData = imgSrc;
            return View();
        }*/
        
        
        
    }
}