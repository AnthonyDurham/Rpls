using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpls_Proj
{
    class ComputerAI : Player
    {
        // member variables ( HAS A)
        public int score;
        public string chosenGesture;




        //constructor (SPAWNER)





        // member methods (CAN DO)
        //choose gesture method

        public override void ChooseGesture()
        {
            
            Random random = new Random();
            int index = random.Next(0, 4);
        }
    }
}
