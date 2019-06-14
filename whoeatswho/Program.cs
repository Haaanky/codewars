using System;
using System.Linq;
using System.Collections.Generic;

namespace whoeatswho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dinglemouse.WhoEatsWho(""));
            //Dinglemouse.WhoEatsWho("fox,fox,fox,bug,chicken,grass,sheep");
        }
    }
    public class Dinglemouse
    {
        public static string[] WhoEatsWho(string zoo)
        {
            if (zoo == string.Empty)
                return new string[1] { string.Empty };
            var animals = new string[] { "antelope", "big-fish", "bug", "bear", "chicken", "cow", "fox", "giraffe", "lion", "panda", "sheep" };
            var results = new List<string>() { zoo };
            var zooList = new List<string>(zoo.Split(','));
            var eaten = false;
            var bearFood = new string[] { "big-fish", "bug", "chicken", "cow", "leaves", "sheep" };
            var stopLoop = false;

            do
            {
                for (int i = 0; i < zooList.Count; stopLoop = (++i == zooList.Count) ? true : false)
                {
                    if (zooList.Count == 1)
                    {
                        stopLoop = true;
                        break;
                    }

                    eaten = false;
                    if (i == 0)
                        switch (zooList[0])
                        {
                            case "antelope":
                                if (zooList[1] == "grass")
                                {
                                    results.Add($"{zooList[0]} eats {zooList[1]}");
                                    zooList.RemoveAt(1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "big-fish":
                                if (zooList[1] == "little-fish")
                                {
                                    results.Add($"{zooList[0]} eats {zooList[1]}");
                                    zooList.RemoveAt(1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "bug":
                                if (zooList[1] == "leaves")
                                {
                                    results.Add($"{zooList[0]} eats {zooList[1]}");
                                    zooList.RemoveAt(1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "bear":
                                if (bearFood.Any(x => x == zooList[1]))
                                {
                                    results.Add($"{zooList[0]} eats {zooList[1]}");
                                    zooList.RemoveAt(1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "chicken":
                                if (zooList[1] == "bug")
                                {
                                    results.Add($"{zooList[0]} eats {zooList[1]}");
                                    zooList.RemoveAt(1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "cow":
                                if (zooList[1] == "grass")
                                {
                                    results.Add($"{zooList[0]} eats {zooList[1]}");
                                    zooList.RemoveAt(1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "fox":
                                if (zooList[1] == "chicken" || zooList[1] == "sheep")
                                {
                                    results.Add($"{zooList[0]} eats {zooList[1]}");
                                    zooList.RemoveAt(1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "giraffe":
                                if (zooList[1] == "leaves")
                                {
                                    results.Add($"{zooList[0]} eats {zooList[1]}");
                                    zooList.RemoveAt(1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "lion":
                                if (zooList[1] == "antelope" || zooList[1] == "cow")
                                {
                                    results.Add($"{zooList[0]} eats {zooList[1]}");
                                    zooList.RemoveAt(1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "panda":
                                if (zooList[1] == "leaves")
                                {
                                    results.Add($"{zooList[0]} eats {zooList[1]}");
                                    zooList.RemoveAt(1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "sheep":
                                if (zooList[1] == "grass")
                                {
                                    results.Add($"{zooList[0]} eats {zooList[1]}");
                                    zooList.RemoveAt(1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            default:
                                break;
                        }
                    else if (i == zooList.Count - 1)
                        switch (zooList[i])
                        {
                            case "antelope":
                                if (zooList[i - 1] == "grass")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "big-fish":
                                if (zooList[i - 1] == "little-fish")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "bug":
                                if (zooList[i - 1] == "leaves")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "bear":
                                if (bearFood.Any(x => x == zooList[i - 1]))
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "chicken":
                                if (zooList[i - 1] == "bug")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "cow":
                                if (zooList[i - 1] == "grass")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "fox":
                                if (zooList[i - 1] == "chicken" || zooList[i - 1] == "sheep")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "giraffe":
                                if (zooList[i - 1] == "leaves")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "lion":
                                if (zooList[i - 1] == "antelope" || zooList[i - 1] == "cow")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "panda":
                                if (zooList[i - 1] == "leaves")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "sheep":
                                if (zooList[i - 1] == "grass")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            default:
                                break;
                        }
                    else
                        switch (zooList[i])
                        {
                            case "antelope":
                                if (zooList[i - 1] == "grass")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                else if (zooList[i + 1] == "grass")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i + 1]}");
                                    zooList.RemoveAt(i + 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "big-fish":
                                if (zooList[i - 1] == "little-fish")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                else if (zooList[i + 1] == "little-fish")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i + 1]}");
                                    zooList.RemoveAt(i + 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "bug":
                                if (zooList[i - 1] == "leaves")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                else if (zooList[i + 1] == "leaves")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i + 1]}");
                                    zooList.RemoveAt(i + 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "bear":
                                if (bearFood.Any(x => x == zooList[i - 1]))
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                else if (bearFood.Any(x => x == zooList[i + 1]))
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i + 1]}");
                                    zooList.RemoveAt(i + 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "chicken":
                                if (zooList[i - 1] == "bug")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                else if (zooList[i + 1] == "bug")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i + 1]}");
                                    zooList.RemoveAt(i + 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "cow":
                                if (zooList[i - 1] == "grass")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                else if (zooList[i + 1] == "grass")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i + 1]}");
                                    zooList.RemoveAt(i + 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "fox":
                                if (zooList[i - 1] == "chicken" || zooList[i - 1] == "sheep")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                else if (zooList[i + 1] == "chicken" || zooList[i + 1] == "sheep")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i + 1]}");
                                    zooList.RemoveAt(i + 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "giraffe":
                                if (zooList[i - 1] == "leaves")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                else if (zooList[i + 1] == "leaves")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i + 1]}");
                                    zooList.RemoveAt(i + 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "lion":
                                if (zooList[i - 1] == "antelope" || zooList[i - 1] == "cow")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                else if (zooList[i + 1] == "antelope" || zooList[i + 1] == "cow")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i + 1]}");
                                    zooList.RemoveAt(i + 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "panda":
                                if (zooList[i - 1] == "leaves")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                else if (zooList[i + 1] == "leaves")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i + 1]}");
                                    zooList.RemoveAt(i + 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            case "sheep":
                                if (zooList[i - 1] == "grass")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i - 1]}");
                                    zooList.RemoveAt(i - 1);
                                    eaten = true;
                                    break;
                                }
                                else if (zooList[i + 1] == "grass")
                                {
                                    results.Add($"{zooList[i]} eats {zooList[i + 1]}");
                                    zooList.RemoveAt(i + 1);
                                    eaten = true;
                                    break;
                                }
                                break;
                            default:
                                break;
                        }
                    if (eaten)
                        break;
                }

            } while (!stopLoop);
            var tmp = "";

            for (int i = 0; i < zooList.Count; i++)
            {
                if (i != 0)
                    tmp += ",";
                tmp += zooList[i];
            }
            results.Add(tmp);
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
            return results.ToArray();
        }

    }
}
