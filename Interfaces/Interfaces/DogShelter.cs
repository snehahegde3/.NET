using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class DogShelter: IEnumerable<Dog>
    {

        // The IEnumerable and IEnumerator interfaces
        // when used, need to implement the GetEnumerator() method
        // GetEnumerator returns a IEnumerator<T> object, providing the ability to iterate through the collection 
        public List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper", false), 
                new Dog("Sif", true), 
                new Dog("Oreo", false), 
                new Dog("Pixel", false),
            };
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            // we have not implemented it yet, thats why we have the exception
            //throw new NotImplementedException();


            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
