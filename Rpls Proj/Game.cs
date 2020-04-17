using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpls_Proj
{
    class Game
    {
        // 1) Dispaly Rules (also include how many rounds)
        // 2) What are we playing? (HvsH or HvsCAI?)

        ///// One Round Of Game//////
        /// 3) Display gesture options to the player
        /// 4) Player 1 chooses gesture
        /// 5) Player 2 chooses gesture 
        /// 6) compare gestures ( assign a point to Round winner/ check for tie )
        /// 7 ) display current score 
        /// 8) check for game winner first the 5 points win 
        /// 

        /// if no 
        /// 9a) repeat stetps 3-8 
        /// if yes 
        /// 9b) display final results 

        // member variables ( HAS A)
        public int pointsNeededToWin;
        public Player player1;
        public Player player2;

        //constructor (SPAWNER)
        public Game()
        {
            player1 = new Human();
            pointsNeededToWin = 5;
        }

        // member methods (CAN DO)
        public void RunGame()
        {
            ChooseGameMode();

            player1.ChooseGesture();
            player2.ChooseGesture();
        }
        public void DisplayRules()
        {
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper cover Rock");
            Console.WriteLine("Rock crushes Lizzard");
            Console.WriteLine("Lizzard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizzard");
            Console.WriteLine("Lizzard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");

        }
        public void ChooseGameMode()
        {
            Console.WriteLine("Please enter 1 for Human Vs Human, or enter 2 for Human Vs ComputerAI");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
    
                 player2 = new Human();
            }
            else if (userInput == "2")
            {

                 player2 = new ComputerAI();

            }
            else 
            {
                Console.WriteLine("Please retry choose 1 for Human Vs Human, or enter 2 for Human Vs ComputerAI");
                ChooseGameMode();
            }
                    


        }
        public void CompareGestures()
        
        {
            string option = "gestureOptions";
              for  (int i = 0; i < gestureOptions.Count; i++)
                {
                    
           
            
               }
        }  

        


       
    }
}
