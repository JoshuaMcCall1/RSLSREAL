using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSfinal
{
    public class Player
    {
        public int score;
        public string name;
        public string gesture;

        public List<string> gestures = new List<string>();

        public int Score { get => score; set => score = value; }

        public Player()
        {
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");
        }


        public void SetNames()
        {
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
        }
        public void SetScore()
        {
            Console.WriteLine("display score");


        }
        public virtual void SetGesture()
        {
            Console.WriteLine("pick Gesture!",name);
        }
         



    }
        }
        


        
      







