using functions;
using System;
Func nfu = new Func();
nfu.pattern1();
nfu.pattern1();
nfu.trippleturn();
while(!nfu.AtGoal()){
    nfu.pattern1();
}
Console.WriteLine("you made it");