// See https://aka.ms/new-console-template for more information
using functions;
using System;
Func nfu = new Func();

void pattern1(){
    nfu.MoveChain();
    nfu.Turn();
    nfu.MoveChain();
    nfu.Turn();
    nfu.MoveChain();
    nfu.trippleturn();
    nfu.MoveChain();

}
while (!nfu.AtGoal())
{
  pattern1();

}
Console.WriteLine("you made it");
