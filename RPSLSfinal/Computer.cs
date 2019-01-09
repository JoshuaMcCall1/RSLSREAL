using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSfinal
{
    public class Computer : Player
    {
        public override void SetGesture()
        {
            // How  the computer picks its gesture
            //random pick using index (0,5)
            Random random = new Random();
            var index = random.Next(0, 5);
            string pickedGesture = gestures[index];
        }
        
    }

}
