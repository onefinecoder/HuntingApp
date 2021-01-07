using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Print welcome message and ask for Username

            //printing Welcome message
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("WELCOME TO THE ANIMAL GAME");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("BY BRANDON");
            //ask user what their Username is
            Console.WriteLine("What is your Username?");


            //making a variable and capturing the data from the user
            string userInput = Console.ReadLine();

            //Print out the usernamemmnm n  
            Console.WriteLine("Hello:" + userInput);


            #endregion

            #region Create Player object and set score to 0
            //created a new instance of Player and set the Username
            Player player1 = new Player();
            player1.Username = userInput;
            player1.Score = 0;



            Console.WriteLine("player1 Username:" + player1.Username);
            Console.WriteLine("player1 Score:" + player1.Score);
            Console.WriteLine("player1 Health:" + player1.Health);
            #endregion


            GameEngine game = new GameEngine();

            for(int i = 1; i<=10; i++)
            {
                Animal animal1 = game.CatchAnimal();
                Console.WriteLine("animal" + i + " AnimalType:" + animal1.AnimalType);
                Console.WriteLine("animal" + i + " Score:" + animal1.Points);
                Console.WriteLine("animal" + i + " DamageDealt:" + animal1.DamageDealt);

                player1.Score = player1.Score + animal1.Points;

                Console.WriteLine("   Score:" + player1.Score);


                player1.Health = player1.Health - animal1.DamageDealt;
                Console.WriteLine("   Health:" + player1.Health);


                if (player1.Health <= 0)
                {
                    Console.WriteLine("YOU DIED OH NO!!!!!!!!!");
                    break;

                }

            }

            Console.WriteLine("******************************************************************************************************************");
                Console.WriteLine("FINAL REPORT CARD");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Score:" + player1.Score);
            Console.WriteLine("Health:" + player1.Health);
            if (player1.Health <= 0)
            {
                Console.WriteLine("YOU DIED OH NO!!!!!!!!!");


            }
            //Animal animal1 = game.CatchAnimal();

            //Console.WriteLine("animal1 AnimalType:" + animal1.AnimalType);
            //Console.WriteLine("animal1 Score:" + animal1.Points);

            //player1.Score = player1.Score + animal1.Points;

            //Console.WriteLine("player1 Score:" + player1.Score);


            //player1.Health = player1.Health - animal1.DamageDealt;
            //Console.WriteLine("player1 Health:" + player1.Health);



            //Animal animal2 = game.CatchAnimal();

            //Console.WriteLine("anmal2 AnimalType:" + animal2.AnimalType);
            //Console.WriteLine("animal2 Score:" + animal2.Points);

            //player1.Score = player1.Score + animal2.Points;
            //player1.Health = player1.Health - animal1.DamageDealt;

            //Console.WriteLine("player1 Score:" + player1.Score);
            //Console.WriteLine("player1 Health:" + player1.Health);

        }
    }
}
