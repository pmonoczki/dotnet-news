using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.IO;
using System.Reflection;
using System.ComponentModel.Composition.Hosting;

namespace MEF
{
    [Export(typeof(IMessageProvider))]
    public class SampleMessageProvider : IMessageProvider
    {
        public string Message
        {
            get { return "A message provider as the add-in."; }
        }
    } 
}
