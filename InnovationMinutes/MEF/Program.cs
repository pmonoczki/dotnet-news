using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.IO;
using System.Reflection;
using System.ComponentModel.Composition.Hosting;
using Microsoft.ComponentModel.Composition.Diagnostics;


namespace MEF
{

    class Program
    {
        [Import("R", typeof(IMessageProvider))]
        public IMessageProvider MessageProviders { get; set; } 

        static void Main(string[] args)
        {
            
            Program p = new Program();
            
            p.Initialize();

            Console.ReadKey();

        }
        
        public void Initialize()
        {
            Compose();
            
            Console.ForegroundColor = ConsoleColor.Cyan;

            //foreach (var messageprovider in messageproviders)
            //{
            //    console.writeline(messageprovider.message);
            //}

            Console.WriteLine(MessageProviders.Message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private void Compose()
        {
            AssemblyCatalog cat = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(cat);
            container.ComposeExportedValue("pakko");
            container.ComposeParts(this);

             // Diagnostic
             //var ci = new CompositionInfo(cat, container);
             //CompositionInfoTextFormatter.Write(ci, Console.Out);


            // For lazy loading
            //Console.WriteLine("START POINT");

        }

    }
}
