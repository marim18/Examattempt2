using functions;
using System;

Func nfu = new Func();
while (!nfu.AtGoal())
{
    nfu.MoveChain();
    nfu.Turn();
}
Console.WriteLine("you made it");
