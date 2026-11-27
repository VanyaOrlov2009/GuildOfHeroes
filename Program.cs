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



// board.AddQuest(new Quest(101, "Вернуть поплавок", 100, 30));
// board.TryAssign(101, "Сергей");
// board.TryComplete(101);

// board.AddQuest(new Quest(102, "Проверить нижнюю площадку", 100, 10));
// board.AddQuest(new Quest(103, "Снять мерки для насоса больницы", 100, 20));
// board.AddQuest(new Quest(104, "Обследовать ответвление", 100, 15));

// Console.WriteLine($"Сергей на №102: {board.TryAssign(102, "Сергей")}");
// Console.WriteLine($"Сергей на №103: {board.TryAssign(103, "Сергей")}");
// Console.WriteLine($"Отмена №102: {board.TryCancel(102)}");
// Console.WriteLine($"Сергей на №103: {board.TryAssign(103, "Сергей")}");
// Console.WriteLine($"Завершение №103: {board.TryComplete(103)}");
// Console.WriteLine($"Ярослав на №104: {board.TryAssign(104, "Ярослав")}");
// Console.WriteLine($"Удалить Сергея: {board.TryRemoveMember("Сергей")}");

// Console.WriteLine();
// List<Quest> quests = board.GetQuests();
// foreach (Quest quest in quests) {
//     Console.WriteLine(quest.GetInfo());
// }


// Console.WriteLine($"Открыто: {board.CountByStatus(QuestStatus.Open)}, " +
//                   $"назначено: {board.CountByStatus(QuestStatus.Assigned)}, " +
//                   $"выполнено: {board.CountByStatus(QuestStatus.Completed)}, " +
//                   $"отменено: {board.CountByStatus(QuestStatus.Cancelled)}");

// Quest? yaroslavQuest = board.FindActiveQuest("Ярослав");
// if (yaroslavQuest != null) {
//     Console.WriteLine($"Ярослав сейчас: №{yaroslavQuest.Id} «{yaroslavQuest.Title}»");
// }

// Quest? sergeyQuest = board.FindActiveQuest("Сергей");
// if (sergeyQuest == null) {
//     Console.WriteLine("Сергей сейчас: свободен");
// }



// Console.WriteLine();
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





Console.WriteLine(">>> Состояния установки <<<");

GameInstall install1 = new GameInstall(601, 8.0);
GameInstall install2 = new GameInstall(602, 8.0);

catalog.AddInstall(install1);
catalog.AddInstall(install2);

Console.WriteLine($"Первый старт для Minecraft: {catalog.TryStartInstall(601, "Minecraft")}");
Console.WriteLine($"Второй старт для Minecraft: {catalog.TryStartInstall(602, "Minecraft")}");
Console.WriteLine($"Отмена первой установки: {catalog.TryCancelInstall(601)}");
Console.WriteLine($"Повторный старт для Minecraft: {catalog.TryStartInstall(602, "Minecraft")}");