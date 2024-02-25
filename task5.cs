using functions;
using System;
using System.Runtime.CompilerServices;
Func nfu = new Func();
nfu.MoveChain();
nfu.Turn();
nfu.MoveChain();
nfu.trippleturn();
nfu.Move();
nfu.Move();
nfu.pattern3();
nfu.trippleturn();
nfu.inverse1();
nfu.Turn();
nfu.MoveChain();
nfu.doubleturn();
nfu.Move();
nfu.move1();
if(nfu.AtGoal()){


Console.WriteLine("you made it");}
