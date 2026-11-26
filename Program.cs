// Probe.Run();
// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);
// Hero alexander = new Hero("   Александр   ", 150);
// Hero sergey = new Hero("Сергей", 110);


// alexander.TakeDamage(10);
// alexander.Heal(10);

// Guild guild = new Guild("Гильдия героев");
// guild.AddHero(yaroslav);
// guild.AddHero(anastasia);
// guild.AddHero(artem);
// guild.AddHero(alexander);
// guild.AddHero(sergey);
// List<Hero> members = guild.GetMembers();

// Console.WriteLine($">>> {guild.Name}: перекличка <<<");
// Console.WriteLine($"Участников: {guild.MemberCount}");


// if (members.Count > 0) {
//     Console.WriteLine($"Первый: {members[0].Name}");
//     Console.WriteLine($"Последний: {members[members.Count - 1].Name}");
// }

// Console.WriteLine();
// foreach (Hero hero in members) {
//     Console.WriteLine(hero.GetInfo());
//     Console.WriteLine();
// }


// Hero? found = guild.FindHeroByName(" аРтЁм ");
// if (found != null) {
//     Console.WriteLine($"Найден по запросу « аРтЁм »: {found.Name}");
// } else {
//     Console.WriteLine("По запросу « аРтЁм » никого нет.");
// }

// Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");


// Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
// Console.WriteLine($"Участников после проверок: {guild.MemberCount}");



// Console.WriteLine();
// Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");


// Console.WriteLine();
// Hero? strongest = guild.FindStrongest();
// if (strongest != null) {
//     Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
// }











Console.WriteLine(">>> Каталог игр <<<");

GameCatalog catalog = new GameCatalog("Моя библиотека");

Game game1 = new Game("CS2", "Shooter", 2023, 5.5);
Game game2 = new Game("Minecraft", "Sandbox", 2011, 8.4);
Game game3 = new Game("Cyberpunk 2077", "Action", 2020, 8.6);
Game duplicateGame = new Game("  cs2  ", "Shooter", 2023, 6.0);

Console.WriteLine($"Добавлена CS2: {catalog.AddGame(game1)}");
Console.WriteLine($"Добавлен Minecraft: {catalog.AddGame(game2)}");
Console.WriteLine($"Добавлен Cyberpunk 2077: {catalog.AddGame(game3)}");
Console.WriteLine($"Повтор «  cs2  » принят: {catalog.AddGame(duplicateGame)}");

Console.WriteLine($"Игр до удаления: {catalog.GameCount}");

Game? foundGame = catalog.FindGameByTitle("  mInEcRaFt ");
if (foundGame != null) {
    Console.WriteLine($"Найдена игра: {foundGame.Title} (рейтинг {foundGame.Rating})");
} else {
    Console.WriteLine("Игра по запросу не найдена");
}

Game? missingGame = catalog.FindGameByTitle("Dota 2");
if (missingGame != null) {
    Console.WriteLine($"Найдена игра: {missingGame.Title}");
} else {
    Console.WriteLine("Игра «Dota 2» не найдена");
}

Console.WriteLine($"Игр с рейтингом от 8.5: {catalog.CountHighRated(8.5)}");

Console.WriteLine($"Удалена CS2: {catalog.RemoveGame("cs2")}");
Console.WriteLine($"Игр после удаления: {catalog.GameCount}");

Console.WriteLine();
List<Game> catalogGames = catalog.GetGames();
foreach (Game game in catalogGames) {
    Console.WriteLine(game.GetInfo());
    Console.WriteLine();
}



