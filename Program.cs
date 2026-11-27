//Probe.Run();
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

// Console.WriteLine($">>> {guild.Name}: участников {guild.MemberCount} <<<");
// Console.WriteLine();


// QuestBoard board = new QuestBoard(guild);

// Quest floatQuest = new Quest(101, "Вернуть поплавок", 100, 30);
// Console.WriteLine($"Поручение добавлено: {board.AddQuest(floatQuest)}");
// Console.WriteLine($">>> №{floatQuest.Id}: {floatQuest.Title} <<<");


// Console.WriteLine($"Назначение Сергея: {board.TryAssign(101, " сЕрГеЙ ")}");
// Hero? assigned = floatQuest.AssignedHero;
// if (assigned != null) {
//     Console.WriteLine($"Исполнитель: {assigned.Name}");
// }
// Console.WriteLine($"Опыт после назначения: {sergey.Experience}");


// Console.WriteLine($"Завершение: {board.TryComplete(101)}");
// Console.WriteLine($"Опыт после завершения: {sergey.Experience}");
// Console.WriteLine($"Повторное завершение: {board.TryComplete(101)}");
// Console.WriteLine($"Опыт после повтора: {sergey.Experience}");


// Console.WriteLine();
// Console.WriteLine(floatQuest.GetInfo());
// Console.WriteLine(sergey.GetInfo());








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





Console.WriteLine(">>> Операция установки игры <<<");

GameInstall install = new GameInstall(501, 8.0);

Console.WriteLine($"Завершить до старта: {install.TryFinish()}");
Console.WriteLine($"Старт для CS2: {install.TryStart(game1)}");
Console.WriteLine($"Старт для Minecraft: {install.TryStart(game2)}");
Console.WriteLine($"Повторный старт: {install.TryStart(game3)}");

Console.WriteLine($"Завершение установки: {install.TryFinish()}");
Console.WriteLine($"Повторное завершение: {install.TryFinish()}");

Game? checkGame = catalog.FindGameByTitle("minecraft");
if (checkGame != null) {
    Console.WriteLine($"Игра после операции: {checkGame.Title}, скачано: {checkGame.IsDownloaded}");
}