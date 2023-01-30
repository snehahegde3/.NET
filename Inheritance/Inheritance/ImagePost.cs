using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }
        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic): base(title, isPublic, sendByUsername)
        {
            //parent function called 

            this.ID = GetNextID();
            this.ImageURL= imageURL;
        }

        public override string ToString()
        {
            return base.ToString() + $"{ImageURL}";
        }
    }
}
