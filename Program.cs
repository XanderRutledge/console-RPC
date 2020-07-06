using System; //using : import
using System.Collections.Generic;
using System.Threading;

namespace projectone  //structure
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notPlaying = true;
            int pcWins= 0;
            int playerWins = 0;
            int draws = 0;
            Console.Clear();
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock...");
            Console.WriteLine("Would you like to play? (Y/N)");
            char choice = Console.ReadKey().KeyChar;
            Dictionary<string,List<string>> items = new Dictionary<string,List<String>>(){
            {"rock", new List<string>(){"scissors","lizard"}},
            {"paper", new List<string>(){"rock","spock"}},
            {"scissors", new List<string>(){"paper","lizard"}},
            {"lizard", new List<string>(){"paper","spock"}},
            {"spock", new List<string>(){"paper","rock"}},
            };
            if(choice == 'y'){
            notPlaying = false;
            }
            else
            {
                Console.Clear();
                System.Console.WriteLine("Have a nice day");
            }
        while(!notPlaying)
            {
            Random random =new Random();
            int rand = random.Next(1,6);
            string compChoice="";
            if (rand == 1)
            {
                compChoice = "paper";
            }
            else if (rand==2)
            {
                compChoice = "rock";
            }
             else if (rand==3)
            {
                compChoice = "lizard";
            }
             else if (rand==4)
            {
                compChoice = "spock";
            }
            else 
            {
                compChoice = "scissors";
            };
                Console.Clear();
                System.Console.WriteLine("What's your choice?");
                foreach (var item in items){
                    System.Console.WriteLine(item.Key);
                }
                System.Console.WriteLine($"My Wins: {pcWins} Your Wins: {playerWins} Draws: {draws} \ntype quit to quit");
                string playerChoice = Console.ReadLine().ToLower();
                if (items.ContainsKey(playerChoice)){
                var compare = items[playerChoice];
                Console.Clear();
                System.Console.WriteLine($"You chose {playerChoice} \nI chose {compChoice}");
                    if (compChoice == playerChoice){
                    System.Console.WriteLine("It's a draw");
                    draws++;
                    Thread.Sleep(3000);
                    }
                    else if (compare.Contains(compChoice)){ 
                        playerWins++;
                        for (int i = 0; i < 10; i++)
                        {
                             if (Console.BackgroundColor == ConsoleColor.Black)
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                }
                                Console.Clear();
                                System.Console.WriteLine($"You chose {playerChoice} \nI chose {compChoice}");
                                System.Console.WriteLine("You Win!!!");
                                Thread.Sleep(300); 
                        }
                    Console.Clear();
                    } 
                    else {
                        pcWins++;
                             for (int i = 0; i < 10; i++)
                        {
                             if (Console.BackgroundColor == ConsoleColor.Black)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                }
                                Console.Clear();
                                System.Console.WriteLine($"You chose {playerChoice} \nI chose {compChoice}");
                                System.Console.WriteLine("I Win!!!");
                                Thread.Sleep(300); 
                        }
                    Console.Clear();
                                }
                }
                else if (playerChoice == "quit"){
                    notPlaying=true;
                    Console.Clear();
                    System.Console.WriteLine("Thanks for playing");
                }
                else
                {
                 Console.Clear();
                 Console.Beep();
                 System.Console.WriteLine("not a valid choice");  
                 Thread.Sleep(2000); 
                }
            
            };




        }
    }
}
