using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    /*
     * IEquitable is a predefined interface that lets you see if two objects are equal or not 
     * These objects belong to the same class or have the same parent class 
     */
    internal class Ticket : IEquatable<Ticket>
    {
        /* For you to be able to IEquitable<Ticket> there must be function defined 
         * The function should return the same data type that the function Equals returns. i.e. a boolean 
         * The function is user defined hence can have any kind of logic 
        */
        public int DurationInHours { get; set; }
        public Ticket(int durationInHours)
        {
            this.DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
