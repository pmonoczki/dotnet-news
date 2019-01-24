using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryWithPrivateMembers 
{

    public class FooBase 
    {
        private int _somePrivateIntegerField = -1;

        private int AddIntegers(int n1, int n2) 
        {
            return n1 + n2;
        }
    }

    public class Foo: FooBase 
    {
        private Bar _bar = new Bar();
        private Bar _barNull;

        internal int SomeInternalInteger { get; set; }
        public bool SomePublicBool { get; set; }
        private string SomePrivateString { get; set; }

        private int AddIntegers(int n1, int n2, int n3) 
        {
            return n1 + n2 + n3;
        }

        private Dictionary<string, string> _dict = new Dictionary<string, string>();
    
        internal string this[string s] 
        {
            get 
            {
                return _dict[s];
            }
            set 
            {
                _dict[s] = value;
            }
        }
    }

    internal class Bar 
    {
        private string SomeBarStringProperty { get; set; }
    }
}
