using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleMasterConsoleAPp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] array2D = new char[8, 8];

            for(int i = 0; i < 8; i++)
            {
                string line = Console.ReadLine();
                char[] splitStrings = line.ToCharArray();

                for (int y = 0; y < 8; y++)
                {
                    array2D[i, y] = splitStrings[y];
                }
            }

            string givenCommands = Console.ReadLine();
            int currentFacedDirection = 0;

            int currentPlacementOfTurtleX = 0;
            int currentPlacementOfTurtleY = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 8; i++)
                {
                    if (array2D[i, x] == 'T') //Sets turtles start position on the map
                    {
                        currentPlacementOfTurtleX = x;
                        currentPlacementOfTurtleY = i;
                        break;
                    }
                }
            }
            for (int i = 0; i < givenCommands.Length; i++)
            {
                char currentCommand = Convert.ToChar(givenCommands.Substring(i, 1));

                if(currentCommand == 'F')
                {
                    if(currentFacedDirection == 0) //Direction : Right
                    {
                        currentPlacementOfTurtleX++;
                    }
                    if(currentFacedDirection == 1) //Direction : Up
                    {
                        currentPlacementOfTurtleY--;
                    }
                    if(currentFacedDirection == 2) //Direction : Left
                    {
                        currentPlacementOfTurtleX--;
                    }
                    if(currentFacedDirection == 3) //Direction : Down
                    {
                        currentPlacementOfTurtleY++;
                    }
                    if (array2D[currentPlacementOfTurtleY, currentPlacementOfTurtleX] == 'C' || array2D[currentPlacementOfTurtleY, currentPlacementOfTurtleX] == 'I')
                    {
                        Console.WriteLine("Bug!");
                        Environment.Exit(0);
                    }
                    if (currentPlacementOfTurtleX <= -1 || currentPlacementOfTurtleX >= 8 || currentPlacementOfTurtleY <= -1 || currentPlacementOfTurtleY >= 8)
                    {
                        Console.WriteLine("Bug!");
                        Environment.Exit(0);
                    }
                }
                if(currentCommand == 'R')
                {
                    currentFacedDirection--;
                    if(currentFacedDirection <= -1)
                    {
                        currentFacedDirection = 3;
                    }
                }
                if(currentCommand == 'L')
                {
                    currentFacedDirection++;
                    if(currentFacedDirection >= 4)
                    {
                        currentFacedDirection = 0;
                    }
                }
                if(currentCommand == 'X')
                {
                    int tempDirX = currentPlacementOfTurtleX;
                    int tempDirY = currentPlacementOfTurtleY;

                    if(currentFacedDirection == 0)
                    {
                        tempDirX++;
                    }
                    if(currentFacedDirection == 1)
                    {
                        tempDirY--;
                    }
                    if(currentFacedDirection == 2)
                    {
                        tempDirX--;
                    }
                    if(currentFacedDirection == 3)
                    {
                        tempDirY++;
                    }
                    if (array2D[tempDirY, tempDirX] == 'C' || array2D[tempDirY, tempDirX] == '.')
                    {
                        Console.WriteLine("Bug!");
                        Environment.Exit(0);
                    }
                    if (tempDirX <= -1 || tempDirX >= 8 || tempDirY <= -1 || tempDirY >= 8)
                    {
                        Console.WriteLine("Bug!");
                        Environment.Exit(0);
                    }
                    if(array2D[tempDirY, tempDirX] == 'I')
                    {
                        array2D[tempDirY, tempDirX] = '.';
                    }
                }
            }
            if (array2D[currentPlacementOfTurtleY, currentPlacementOfTurtleX] == 'D')
            {
                Console.WriteLine("Diamond!");
            }
            else
            {
                Console.WriteLine("Bug!");
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}
