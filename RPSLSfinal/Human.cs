using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSfinal
{
    public class Human : Player
    {

        public override void SetGesture()
        {
            //define how computer picks gesture
            Console.WriteLine("Please Pick Gesture");
            string pickedGesture = Console.ReadLine();
        }
    }
}
