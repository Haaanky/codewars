﻿using System;

namespace wholikesit
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.Likes(new string[0]);
            Kata.Likes(new string[] { "Peter" });
            Kata.Likes(new string[] { "Jacob", "Alex" });
            Kata.Likes(new string[] { "Max", "John", "Mark" });
            Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" });
        }
    }
    public static class Kata
    {
        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                default:
                    return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }
    }
}
