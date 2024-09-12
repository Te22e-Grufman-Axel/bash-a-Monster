Player player = new Player();
Enemy Enemy = new Enemy();

Console.WriteLine("Welcome to the arena!");

Console.WriteLine(player.Name + " has " + player.hp + " health");
Console.WriteLine(Enemy.Name + " has " + Enemy.hp + " health");
Console.WriteLine();
Console.WriteLine();
int Damage = player.Attack();
Console.WriteLine(Damage);

Console.WriteLine("The " + Enemy.Name + " now has " + Enemy.hp + " health");

Console.WriteLine();
Console.WriteLine("Press any key to continue");
Console.ReadKey();