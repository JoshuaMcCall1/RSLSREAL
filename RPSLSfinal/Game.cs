using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSfinal
{
    public class Game
    {
        Player playerone;
        Player playertwo;

        public void GetPlayers()
        {
            Console.WriteLine("enter number of players");
            string input = Console.ReadLine();


            if (input == "1")
            {
                playerone = new Human();
                playertwo = new Computer();
            }


            else if (input == "2")
            {
                playerone = new Human();
                playertwo = new Human();


            }
        }
        public void CompareGestures()
        {
            if(playerone.gesture == playertwo.gesture)
            {
                Console.WriteLine("It's a tie!");
            }
        }

        public void RunGame()
        {
            GetPlayers();
            playerone.SetNames();
            playertwo.SetNames();
            playerone.SetGesture();
            playertwo.SetGesture();
            CompareGestures();
        }
    }
}
