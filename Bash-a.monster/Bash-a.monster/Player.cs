public class Player
{
public string Name = "Player";
public int hp = 100;
public int Damage = 15;


public int Attack()
{
Console.WriteLine("The " + Name + " attacks there enemy");

return Damage;
}
}