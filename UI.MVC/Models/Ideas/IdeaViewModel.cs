using System;
using System.Collections.Generic;
using Domain;

namespace D.UI.MVC.Models.Ideas
{
  /*  public static class IdeaExtensions
    {
        public static IdeaViewModel ToViewModel(this Idea idea)
        {
            var model = new IdeaViewModel
            {
                ideaViewModelId = idea.ideaId,
                
                
            };
        }
    }*/
    public class IdeaViewModel
    {
        public int ideaViewModelId { get; set; }
        public string name { get; set; }
      //  public ICollection<FieldViewModel> fields { get; set; }
        public TextFieldViewModel textFieldViewModel { get; set; }
        public ImageFieldViewModel imageFieldViewModel { get; set; }
        public VideoFieldViewModel videoFieldViewModel { get; set; }
        public MapFieldViewModel    mapFieldViewModel { get; set; }
        
    //  public FieldViewModel fieldViewModel { get; set; }
    
    
        
        
    }

    public class FieldViewModel
    {
        public int fieldViewModelId { get; set; }
        public Boolean isRequired { get; set; }

    }

    public class TextFieldViewModel : FieldViewModel
    {
        public String text { get; set; }
        
    }

    public class ImageFieldViewModel : FieldViewModel
    {
        public string imageName { get; set; }
        public byte[] data { get; set; }
        
    }

    public class VideoFieldViewModel : FieldViewModel
    {
        public int length { get; set; }
        public byte[] data { get; set; }
    }

    public class MapFieldViewModel : FieldViewModel
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
    
        
}