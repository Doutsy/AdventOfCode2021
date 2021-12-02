using System;
using System.IO;

namespace AOC2021
{
    class Day02
    {
        public static void Exec(string _path, int _part)
        {
            int xPos = 0;
            int yPos = 0;
            int aim = 0;
            int answer = 0;
            string[] lines = File.ReadAllText(_path).Split("\n", StringSplitOptions.TrimEntries);
            switch(_part)
            {
                case 1:
                    foreach(var line in lines)
                    {
                        if (line.Contains("forward"))
                            xPos += int.Parse(line.Substring(7));
                        else if (line.Contains("up"))
                            yPos -= int.Parse(line.Substring(2));
                        else if (line.Contains("down"))
                            yPos += int.Parse(line.Substring(4));
                    }
                    answer = xPos * yPos;
                    Console.WriteLine($"Day 02 | Part 1 : {answer}");
                    break;
                case 2:
                    foreach(var line in lines)
                    {
                        if(line.Contains("forward"))
                        {
                            xPos += int.Parse(line.Substring(7));
                            yPos += int.Parse(line.Substring(7)) * aim;
                        }
                        else if(line.Contains("up"))
                        {
                            aim -= int.Parse(line.Substring(2));
                        }
                        else if(line.Contains("down"))
                        {
                            aim += int.Parse(line.Substring(4));
                        }
                    }
                    answer = xPos * yPos;
                    Console.WriteLine($"Day 02 | Part 2 : {answer}");
                    break;
            }
        }
    }
}
