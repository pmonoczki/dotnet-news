using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace MEF
{
    [Serializable]
    [Export("R", typeof(IMessageProvider))]
    class SampleProvider2 : IMessageProvider
    {
        private string msg = "default";

        public string Message
        {
            //get { return "throw new NotImplementedException();"; }
            get { return msg; }
        }

        public SampleProvider2() : base()
        {
            Console.WriteLine("I am the SampleProvider2 instance!");
        }

        // [ImportingConstructor]
        //public SampleProvider2(string message) : base() { this.msg = message; }
    }
}
