using System.Configuration.Assemblies;

namespace functions
{
    

#region Basic functions
public class Func{

public void trippleturn(){
Turn();
 Turn();
 Turn();
}

public void doubleturn(){
Turn();
Turn();
}

public void MoveChain()
{
    while (Peek())
    {
        Move();
    }
}
public void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

public void Turn()
{
    // Turns the car 90 deg clockwise.
}

public bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

public bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
} }
}

#endregion

