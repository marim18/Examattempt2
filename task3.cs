using functions;
using System;
Func nfu = new Func();
nfu.pattern1();
nfu.pattern1();
nfu.trippleturn();
while(!nfu.AtGoal()){
    nfu.pattern2();
}
Console.WriteLine("you made it");
