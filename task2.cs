using functions;
using System;
Func nfu = new Func();
 void MoveChain()
        {
            while (!nfu.AtGoal())
            {
                if (nfu.Peek())
                {
                    nfu.Move();
                }
                else
                {
                    nfu.Turn();
                }
            }
            Console.WriteLine("you made it");
        }
