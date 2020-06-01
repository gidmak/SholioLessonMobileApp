using System;
using System.Collections.Generic;
using System.Text;

namespace SholioLessonMobileApp.Models
{
    public class Meaning
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string Translation { get; set; }
        public string RelatedWord { get; set; }
        public string ImageUrl { get; set; }
        public string AudioClip { get; set; }
    }
}
