using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpls_Proj
{
    public abstract class Player
    {
        


        // member variables ( HAS A)
        public int score;
        public string chosenGesture;
       public List<string> gestureOptions = new List<string>();




        //constructor (SPAWNER)
        public Player()
        {
            

            gestureOptions.Add("Rock");
            gestureOptions.Add("Paper");
            gestureOptions.Add("Siccors");
            gestureOptions.Add("Lizzard");
            gestureOptions.Add("Spock");
        }

        // member methods (CAN DO)
        public void ViewGesturesOptions()
        {
           

            Console.WriteLine("Gesture options");
            for (int i = 0; i < gestureOptions.Count; i++)
            {
                Console.WriteLine(gestureOptions[i]);
            }
           
        }

        //create an abstract method for choseing a gesture
        public abstract void ChooseGesture();
        
    }

}
