using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpls_Proj
{
    public class Human : Player
    {
        // member variables ( HAS A)
        public int score;
        public string chosenGesture;



        //constructor (SPAWNER)
        public Human()
        {
            
        }


        // member methods (CAN DO) 
        //choose gesture method
        public override void ChooseGesture()
        {
            Console.WriteLine("Gesture options");
            for (int i = 0; i < gestureOptions.Count; i++)
            {
                Console.WriteLine(gestureOptions[i]);
            }

        }

        


}


}

