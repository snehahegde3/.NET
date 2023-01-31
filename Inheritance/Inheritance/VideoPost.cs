using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class VideoPost : Post
    {
        private string VideoURL { get; set; }
        private int Length { get; set; }
        Timer timer;

        protected bool IsPlaying { get; set; }
        protected int currDuration = 0;

        public VideoPost() { }

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
        private void TimerCallback(Object O){
            if (currDuration < Length)
            {

                currDuration++;
                Console.WriteLine($"Video at {currDuration}");

                //calling the garbage collection methiod 
                GC.Collect();
            }
            else
            {
                Console.WriteLine("Video ended");
                Stop();
            }
        }
        public void Play() {
            if(!IsPlaying) {

                IsPlaying = true;

                Console.WriteLine("Playing... ");

                /*timer1 = new Timer(Callback, object? state, int dueTime, int Period)
                 * Timer takes in the above mentioned four parameters
                 * 
                 * Callback: is the function that gets called once the timer ends 
                 * 
                 * state: an object passed into the callback funtion getting called as a piece of information or input that it can read or maipulate. 
                 *        incase you want to send new information each time the timeer period ends, use this 
                 * 
                 * dueTIme: integer that indicated when the first event will be triggered. 
                 *          consider it the time of the first deployment 
                 * 
                 * peirod: integer that denotes the amount of time when the timer should get fired again 
                 * 
                 * */

                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        public void Stop()
        {
            if (IsPlaying)
            {

                IsPlaying = false;
                Console.WriteLine($"Stopped at {currDuration}");
                currDuration = 0;
                timer.Dispose();
            }
        }
    }
}
