using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class VideoPost : Post
    {
        private string VideoURL { get; set; }
        private int Length { get; set; }

        public VideoPost(string videoURL, int length, string title, bool isPublic, string sendByUser): base(title, isPublic, sendByUser)
        {
            //parent function called 

            this.ID = GetNextID();
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {VideoURL} - {Length}";
        }
    }
}
