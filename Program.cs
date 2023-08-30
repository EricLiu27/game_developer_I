// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Enemy Guard = new Enemy("John Cena");


Attack FirePunch = new Attack("fire punch", 20);
Attack RoundHouseKick = new Attack("Round House Kick", 25);
Attack Jab = new Attack("Jab", 10);


Guard.AttackList.Add(FirePunch);
Guard.AttackList.Add(RoundHouseKick);
Guard.AttackList.Add(Jab);

Console.WriteLine(Guard.RandomAttack().Name);
