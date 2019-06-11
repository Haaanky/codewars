using System;
using System.Collections.Generic;

namespace directionsbad
{
    class Program
    {
        static void Main(string[] args)
        {
            DirReduction.dirReduc(new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" });
        }
    }
    public class DirReduction
    {
        public static string[] dirReduc(string[] arr)
        {
            var arrList = new List<string>(arr);
            var result = new List<string>();

            for (int i = 0; i < arrList.Count - 1; i++)
            {
                switch (arrList[i])
                {
                    case "NORTH":
                        if (arrList[i + 1] == "SOUTH")
                        {
                            arrList.RemoveRange(i, 2);
                            i = -1;
                            break;
                        }
                        break;
                    case "SOUTH":
                        if (arrList[i + 1] == "NORTH")
                        {
                            arrList.RemoveRange(i, 2);
                            i = -1;
                            break;
                        }
                        break;
                    case "EAST":
                        if (arrList[i + 1] == "WEST")
                        {
                            arrList.RemoveRange(i, 2);
                            i = -1;
                            break;
                        }
                        break;
                    case "WEST":
                        if (arrList[i + 1] == "EAST")
                        {
                            arrList.RemoveRange(i, 2);
                            i = -1;
                            break;
                        }
                        break;
                    default:
                        break;
                }
            }
            return arrList.ToArray();
        }
    }
}
