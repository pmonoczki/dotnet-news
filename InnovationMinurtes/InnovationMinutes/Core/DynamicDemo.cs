//-----------------------------------------------------------------------

// <copyright file="DynamicDemo.cs" component="CORE">

//     Represents the new CORE functionalities.

// </copyright>

//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.Collections;
using System.Diagnostics;

namespace Core
{
    /// <summary>
    /// This class support the demonstration of the dynamic variable in DotNet 4.0
    /// </summary>
    static class DynamicDemo
    {
        /// <summary>
        /// Showes the dynamic keyword
        /// </summary>
        public static void DoDynamucIntro()
        {

            #region Dynamic

            dynamic d = "hello";
            Console.WriteLine(d);
            d = 10;
            Console.WriteLine(d);
            d = new Point(1, 1);
            d.X += 1;
            Console.WriteLine(d.X.ToString());

            d = GetDic();
            Console.WriteLine(d[1]);
            d[1] += d[2];
            Console.WriteLine(d[1]);

            # endregion
        }

        private static dynamic GetDic()
        {
            return new Dictionary<int, string>()
                {
                { 1, "egy" },
                { 2, "kettő" },
                { 3, "három" }
                };
        }

        /// <summary>
        /// Showes the DuckType
        /// </summary>
        public static void DoDuckTypingIntro()
        {

            // First
            ScrumTeam st1 = new ScrumTeam() { Name= "Erlangen", MaxStoryPoint = 150, TeamMemberCount = 10 };
            ScrumTeam st2 = new ScrumTeam() { Name="Miskolc", MaxStoryPoint = 145, TeamMemberCount = 6 };

            Console.WriteLine(GetWinner<ScrumTeam>(st1, st2).Name);
            
            // DuckType
            Console.WriteLine(GetWinner_d(st1, st2).Name);
            //With dynamic
        }

        /// <summary>
        /// Compares dynamic to reflection
        /// </summary>
        public static void DoReflectionCompare()
        {
            object target = "alma";
            object arg = "m";

            string a2 = (string)arg;

            Stopwatch w = Stopwatch.StartNew();

            const int callNumber = 1000 * 1000;
            for (int i = 0; i < callNumber; i++)
            {
                Type[] argTypes = new Type[] { typeof(string) };
                MethodInfo mi = target.GetType().GetMethod("Contains", argTypes);
                object[] oa = new object[] { a2 };
                bool b = (bool)mi.Invoke(target, oa);
            }

            w.Stop();
            Console.WriteLine("Reflection hívási idő: {0}", w.Elapsed);
            double elapsedTickForReflection = w.ElapsedTicks;

            w.Restart();

            for (int i = 0; i < callNumber; i++)
            {
                bool b = ((dynamic)target).Contains(a2);
            }

            w.Stop();
            Console.WriteLine("Dynamic hívási idő: {0}", w.Elapsed);

            Console.WriteLine("A dynamic {0}x gyorsabb volt.", elapsedTickForReflection / w.ElapsedTicks);

        }

        /// <summary>
        /// Non DuckType example
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static T GetWinner<T>(T x, T y) where T : IComparable<T>
        {
            int result = x.CompareTo(y);
            if (result < 0)
                return x;
            else if (result > 0)
                return y;
            else return default(T);
        }

        /// <summary>
        /// DuckType example
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static dynamic GetWinner_d(dynamic x, dynamic y) 
        {
            int result = x.CompareTo(y);
            if (result < 0)
                return x;
            else if (result > 0)
                return y;
            else return null;
        }

    }

    /// <summary>
    /// Class to the ducktype
    /// </summary>
    class ScrumTeam : IComparable<ScrumTeam>
    {
        public int MaxStoryPoint { get; set; }
        public int TeamMemberCount { get; set; }
        public string Name { get; set; }
        

        public int CompareTo(ScrumTeam other)
        {

            if (this.MaxStoryPoint == other.MaxStoryPoint) return 0;

            if ((this.MaxStoryPoint / this.TeamMemberCount) < (other.MaxStoryPoint / other.TeamMemberCount))
            {
                return 1;
            }
            else
            {
                return -1;
            }

            
        }
    }
}
