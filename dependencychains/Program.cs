﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace dependencychains
{
    class Program
    {
        static void Main(string[] args)
        {
            var startFiles = new Dictionary<string, string[]>();
            startFiles["A"] = new string[] { "C", "D", "B" };
            startFiles["B"] = new string[] { "A" };
            startFiles["C"] = new string[] { "D" };
            startFiles["D"] = new string[] { "B" };

            foreach (var item in Kata.ExpandDependencies(startFiles))
            {
                Console.WriteLine(item);
            }
            /*
                    correctFiles["A"] = new string[] {"B", "C", "D"};
                    correctFiles["B"] = new string[] {"C", "D"};
                    correctFiles["C"] = new string[] {"D"};
                    correctFiles["D"] = new string[] {};
             
             */
        }
    }
    public class Kata
    {
        public static Dictionary<string, string[]> ExpandDependencies(Dictionary<string, string[]> dependencies)
        {
            if (dependencies.Distinct().Count() != dependencies.Count)
                throw new InvalidOperationException();

            foreach (var item in dependencies)
            {
                Console.WriteLine($"{item.Key}: ");
                foreach (var value in item.Value)
                {
                    if (item.Key == value)
                        throw new InvalidOperationException();
                    Console.Write(value + " ");
                }
            }

            if (dependencies.Count == 0)
                return dependencies;

            var hashsetDictionary = new Dictionary<string, HashSet<string>>();
            foreach (var item in dependencies)
            {
                hashsetDictionary.Add(item.Key, new HashSet<string>(item.Value));
            }

            foreach (var (keyValuePair, value) in hashsetDictionary.SelectMany(item => hashsetDictionary.Values.SelectMany(thing => thing.ToArray().Where(final => item.Key == final).Select(final => (item, thing)))))
            {
                value.UnionWith(keyValuePair.Value);
            }

            var result = new Dictionary<string, string[]>();
            foreach (var item in hashsetDictionary)
            {
                result.Add(item.Key, new string[item.Value.Count]);
                result[item.Key] = item.Value.ToArray();
            }

            //if (result.All(x => x.Value.All(a => result.Values.All(b => b.Contains(a)))))
            //    throw new InvalidOperationException();

            var count = 0;
            foreach (var keyValuePair in result)
            {
                foreach (var value in result.Values)
                {
                    if (value.Contains(keyValuePair.Key))
                    {
                        count++;
                        break;
                    }
                }
            }

            if (count == result.Count)
                throw new InvalidOperationException();

            return result;
            //return result;
        }
        public void TestCircularDependencies()
        {
            // Arrange
            var startFiles = new Dictionary<string, string[]>();
            startFiles["A"] = new string[] { "B" };
            startFiles["B"] = new string[] { "C" };
            startFiles["C"] = new string[] { "D" };
            startFiles["D"] = new string[] { "A" };

            //// Act/Assert
            //Assert.Throws(typeof(InvalidOperationException),
            //  delegate { Kata.ExpandDependencies(startFiles); },
            //  "A circular dependency should have thrown an InvalidOperationException.");
        }
    }
}

//foreach (var (item, thing) in result.Values.SelectMany(item => item.Where(x => result.Keys.Contains(x)).Select(thing => (item, thing))))
//{
//    item.Add(thing);
//}