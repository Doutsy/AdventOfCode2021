using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2021
{
    class Day01
    {
        public static void Exec(string _path, int _part)
        {
            string[] lines = File.ReadAllText(_path).Split("\n", StringSplitOptions.TrimEntries);
            int previousDepth = int.MaxValue;
            int currentDepth = 0;
            int answer = 0;

            switch (_part)
            {
                case 1:
                    foreach (string line in lines)
                    {
                        currentDepth = int.Parse(line);
                        if (currentDepth > previousDepth)
                        {
                            answer++;
                        }
                        previousDepth = currentDepth;
                    }
                    break;
                case 2:
                    for (int i = 0; i < lines.Length - 2; i++)
                    {
                        currentDepth = int.Parse(lines[i]) + int.Parse(lines[i + 1]) + int.Parse(lines[i + 2]);
                        if (currentDepth > previousDepth)
                        {
                            answer++;
                        }
                        previousDepth = currentDepth;
                    }
                    break;
            }
            Console.WriteLine($"Day 01 | Part {_part} : {answer}");
        }
    }
}
