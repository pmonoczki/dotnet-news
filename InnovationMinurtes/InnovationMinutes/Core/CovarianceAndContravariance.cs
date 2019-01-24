
//-----------------------------------------------------------------------

// <copyright file="CovarianceAndContravariance.cs" component="CORE">

//     Represents the new CORE functionalities.

// </copyright>

//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    /// <summary>
    /// This class is support the demonstartion of the Covariance and contravariance features.
    /// </summary>
    class CovarianceAndContravariance
    {
        /// <summary>
        /// Demonstrator method
        /// </summary>
        public static void DoCovarianceAndContravariance()
        {
            // Covariance

             List<Giraffe> giraffeList = new List<Giraffe> { new Giraffe() };  
             IProcessor<IAnimal> proc = new Processor<IAnimal>();
              // .net 3.0 
              //proc.Process(giraffeList.OfType<IAnimal>());
             proc.Process(giraffeList);

             // Contravariance
            
             IProcessor_contra < IAnimal > animalProc = new Processor_contra<IAnimal>();
             IProcessor_contra < Giraffe > giraffeProcessor = animalProc;
             IProcessor_contra < Whale > whaleProcessor = animalProc;

             List<Giraffe> giraffes = new List<Giraffe> { new Giraffe() };
             List<Whale> whales = new List<Whale> { new Whale() };

            giraffeProcessor.Process(giraffes);
            whaleProcessor.Process(whales);  

        }

    }

    interface IAnimal
    {
        void Speak();
    }

    class Whale : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("I'm a Whale");
        }
    }

    class Giraffe : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("I'm a Giraffe");
        }
    }

    interface IProcessor<T>
    {
        void Process(IEnumerable<T> ts);
    }

    class Processor<T> : IProcessor<T> where T : IAnimal
    {
        public void Process(IEnumerable<T> ts)
        {
            foreach (var t in ts)
            {
                t.Speak();
            }
        }
    }

    interface IProcessor_contra<in T>
    {
        void Process(IEnumerable<T> ts);
    }

    class Processor_contra<T> : IProcessor_contra<T> where T : IAnimal
    {
        public void Process(IEnumerable<T> ts)
        {
            foreach (var t in ts)
            {
                t.Speak();
            }
        }
    }

}
