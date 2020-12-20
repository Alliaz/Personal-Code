using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace GizmoClean_DustSucker_2000
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    Start:
                char currentFacedDirection = 'X';

                    string input = String.Concat(Console.ReadLine().Where(c => !Char.IsWhiteSpace(c))); //Takes first input like 6 7 and trims away whitespace
                char[] splitString = input.ToCharArray(); //sets input to an char array 

                int tempInt1 = int.Parse(splitString[0].ToString()); //set the first input line to temporary ints
                int tempInt2 = int.Parse(splitString[1].ToString());
                int[,] array2D = new int[tempInt1, tempInt2]; //initalize the 2D array which acts as the room

                input = String.Concat(Console.ReadLine().Where(c => !Char.IsWhiteSpace(c))); //second input, like N 3 2
                
                if (input.Contains("N") || input.Contains("S") || input.Contains("W") || input.Contains("E")) //Checks user input in second line so it's not invalid directions
                {
                    splitString = input.ToCharArray();
                }
                else
                {
                    Console.WriteLine("Starting direciton given to the toy is invalid. Try again from the beginning...\n");
                    goto Start;
                }

                currentFacedDirection = splitString[0]; //setting information from second line to current faced directions etc.

                int currentPlacementOfToyX = 0;
                int currentPlacementOfToyY = 0;


                if (int.Parse(splitString[1].ToString()) < array2D.GetLength(0) || int.Parse(splitString[1].ToString()) < array2D.GetLength(1)) 
                    //Checks if user inputs the wrong placement for Toy (So it's not out of bounds)
                {
                    currentPlacementOfToyX = int.Parse(splitString[1].ToString());
                    currentPlacementOfToyY = int.Parse(splitString[2].ToString());
                }
                else
                {
                    Console.WriteLine("Position of Toy is out of bounds! Try again from the beginning...\n");
                        goto Start; //Throws user back to start to try again
                }

                    input = String.Concat(Console.ReadLine().Where(c => !Char.IsWhiteSpace(c))); //Third input, the commands

                for (int i = 0; i < input.Length; i++) //Runs throug the commands one by one
                {
                    char currentCommand = Convert.ToChar(input.Substring(i, 1));

                    if (currentCommand == 'A')
                    {
                        var values = MoveToyForward(currentFacedDirection, currentPlacementOfToyX, currentPlacementOfToyY); //using methods for readability. 
                        //This also uses Tuples to send 2 return back from above

                        if (values.Item1 > array2D.GetLength(0) || values.Item2 > array2D.GetLength(1) //Checks if the command will send the toy out of bounds and restarts the program for new run
                            || values.Item1 < 0 || values.Item2 < 0) {

                            int positionOfCommand = i + 1;

                            Console.Write("Command '" + currentCommand + "' given at position " + positionOfCommand + " in the list of commands sent the Toy out of the room/into a wall... \n" +
                                "Check your commands and try again from the beginning.\n");
                            goto Start; //Sends back to start
                        }
                        else
                        {
                            currentPlacementOfToyX = values.Item1; //Sets the values from the tuple to the intergers
                            currentPlacementOfToyY = values.Item2;
                        }
                    }
                    else if (currentCommand == 'R' || currentCommand == 'L')
                    {
                        currentFacedDirection = TurnToy(currentCommand, currentFacedDirection); //This line calls the methods for turning the toy
                    }
                    else
                    {
                        Console.WriteLine("Incorrect command given! Moving on to next command..."); //This commandline simply tells the user that they've sent a command that is not A, L or R and skips it
                    }
                }
                Console.WriteLine("\n" +
                    "GizmoClean's DustSucker2000 Simulator by Eddie Magnusson" +
                    "\nThis software is the program for the GizmoCleaner Dustsucker 2000. The function of this program is to simulate how the toy will operate with a set of commands \n" +
                    "in a specified room with an specified set location. The program will initalize with asking for the size of the room in meters. It will then in a new line ask for \n" +
                    "the toys current facing direction with a compass of North, South, West, East as it's directions. That means that the program turn the toy 90 degrees every turn. \n" +
                    "Lastly in the third line it asks for a set of command which consists of A = Forward movmenet, R = Movement to the right by 90 degrees and L = Movement to the left by 90 degrees. \n" +
                    "The program will check the users commands that are given and accordingly execute the commands. If any command given is not one of the mentioned commands it will skip them and move on.\n" +
                    "If any of the commands brings the toy outside the borders of the room the program will tell the user that the toy hit the bounderies of the room.\n" +
                    "The program will also check if you try to assign the toy a location and direction that is either wrong or out of the bounds of the room.\n" +
                    "It will also make sure you don't give the toy invalid directions in the beginning such as SW, SE or NW.\n" +
                    "If all the commands given are correct the program will execute and print this message along with the toys current location in the simulation. \n" +
                    "Exceptions are caught and printed aswell." +
                    "\nResult: " + currentFacedDirection + " " + currentPlacementOfToyX + " " + currentPlacementOfToyY); //Prints the lines when execution is done
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e + "\n"); //Catches error
            }
        }
        public static (int, int) MoveToyForward(char currentFacedDirection, int currentPlacementOfToyX, int currentPlacementOfToyY) //This method moves the toy by X or Y depending on the direction the toy is facing
        {
            if (currentFacedDirection == 'E') //Direction : East
            {
                    currentPlacementOfToyX++;
            }
            if (currentFacedDirection == 'N') //Direction : North
            {
                    currentPlacementOfToyY++;
            }
            if (currentFacedDirection == 'W') //Direction : West
            {
                    currentPlacementOfToyX--;
            }
            if (currentFacedDirection == 'S') //Direction : South
            {
                    currentPlacementOfToyY--;
            }
            return (currentPlacementOfToyX, currentPlacementOfToyY); //Returns tuple
        }
        public static char TurnToy(char currentCommand, char currentFacedDirection) //This method turns the toy accordingly depending on the command : L or R
        {                                                                          //When an direction has been identified and the toy's new direction is set we use a 'goto' to break the if statements
            if (currentCommand == 'R')                                             //This is needed, otherwise if we land on E and change direction to S we will come back to south in the bottom and change it to W
            {
                if (currentFacedDirection == 'E')
                {
                    currentFacedDirection = 'S';
                    goto returner;
                }
                if (currentFacedDirection == 'N')
                {
                    currentFacedDirection = 'E';
                    goto returner;
                }
                if (currentFacedDirection == 'W')
                {
                    currentFacedDirection = 'N';
                    goto returner;
                }
                if (currentFacedDirection == 'S')
                {
                    currentFacedDirection = 'W';
                    goto returner;
                }
            }
            if (currentCommand == 'L')
            {
                if (currentFacedDirection == 'E')
                {
                    currentFacedDirection = 'N';
                    goto returner;
                }
                if (currentFacedDirection == 'N')
                {
                    currentFacedDirection = 'W';
                    goto returner;
                }
                if (currentFacedDirection == 'W')
                {
                    currentFacedDirection = 'S';
                    goto returner;
                }
                if (currentFacedDirection == 'S')
                {
                    currentFacedDirection = 'E';
                    goto returner;
                }
            }
                returner:
            return currentFacedDirection; //returns direction
        }
    }
}
