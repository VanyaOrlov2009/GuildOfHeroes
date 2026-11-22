//Probe.Run();
// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);
// Hero alexander = new Hero("   Александр   ", 150);
// Hero sergey = new Hero("Сергей", 110);


// alexander.TakeDamage(10);
// alexander.Heal(10);

// Guild guild = new Guild("Гильдия героев");
// guild.Heroes.Add(yaroslav);
// guild.Heroes.Add(anastasia);
// guild.Heroes.Add(artem);
// guild.Heroes.Add(alexander);
// guild.Heroes.Add(sergey);
// Console.WriteLine($">>> {guild.Name}: перекличка <<<");
// Console.WriteLine($"Участников: {guild.Heroes.Count}");


// if (guild.Heroes.Count > 0) {
//     Console.WriteLine($"Первый: {guild.Heroes[0].Name}");
//     Console.WriteLine($"Последний: {guild.Heroes[guild.Heroes.Count - 1].Name}");
// }

// Console.WriteLine();
// foreach (Hero hero in guild.Heroes) {
//     Console.WriteLine(hero.GetInfo());
//     Console.WriteLine();
// }

// Console.WriteLine();
// int strongCount = 0;
// foreach (Hero hero in guild.Heroes) {
//     if (hero.Health >= 120) {
//         strongCount++;
//     }
// }
// Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {strongCount}");


// Console.WriteLine();
// if (guild.Heroes.Count > 0) {
//     Hero strongest = guild.Heroes[0];
//     foreach (Hero hero in guild.Heroes) {
//         if (hero.Health > strongest.Health) {
//             strongest = hero;
//         }
//     }
//     Console.WriteLine($"Самый здоровый: {strongest.Name}");
// }










Game game1 = new Game("CS2", "Shooter", 2023, 5.5);
Game game2 = new Game("Minecraft", "Sandbox", 2011, 8.4);
Game game3 = new Game("Cyberpunk 2077", "Action", 2020, 8.6);

List<Game> games = new List<Game>();
games.Add(game1);
games.Add(game2);
games.Add(game3);

Console.WriteLine($"Игр в списке: {games.Count}");
if (games.Count > 0) {
    Console.WriteLine($"Первая игра: {games[0].Title}");
    Console.WriteLine($"Последняя игра: {games[games.Count - 1].Title}");
}

Console.WriteLine();
foreach (Game game in games) {
    Console.WriteLine(game.GetInfo());
    Console.WriteLine();
}

Game game4 = new Game("Terraria", "Adventure", 2011, 9.3);
games.Add(game4);

int highCount = 0;
foreach (Game game in games) {
    if (game.Rating >= 8.5) {
        highCount++;
    }
}
Console.WriteLine($"Игр с рейтингом от 8.5: {highCount}");


Console.WriteLine($"До скачивания через список: {games[0].IsDownloaded}");
game1.Download();
Console.WriteLine($"После game1.Download() через список: {games[0].IsDownloaded}");
