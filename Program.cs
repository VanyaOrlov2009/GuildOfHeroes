Game game1 = new Game("CS2", "Shooter", 2023, 5.5);
Game game2 = new Game("Minecraft", "sandbox", 2011, 8.4);
Game game3 = new Game("Cyberpunk 2077", "Action", 2020, 8.6);

game1.Rating = 5.4;
game2.Rating = 9.0;

Console.WriteLine(">>> Игра 1 <<<");
Console.WriteLine($"Название: {game1.Title}");
Console.WriteLine($"Жанр: {game1.Genre}");
Console.WriteLine($"Год релиза: {game1.ReleaseDate}");
Console.WriteLine($"Рейтинг: {game1.Rating}");
Console.WriteLine($"Скачано: {game1.IsDownloaded}");

Console.WriteLine();

Console.WriteLine(">>> Игра 2 <<<");
Console.WriteLine($"Название: {game2.Title}");
Console.WriteLine($"Жанр: {game2.Genre}");
Console.WriteLine($"Год релиза: {game2.ReleaseDate}");
Console.WriteLine($"Рейтинг: {game2.Rating}");
Console.WriteLine($"Скачано: {game2.IsDownloaded}");

Console.WriteLine();

Console.WriteLine(">>> Игра 3 <<<");
Console.WriteLine($"Название: {game3.Title}");
Console.WriteLine($"Жанр: {game3.Genre}");
Console.WriteLine($"Год релиза: {game3.ReleaseDate}");
Console.WriteLine($"Рейтинг: {game3.Rating}");
Console.WriteLine($"Скачано: {game3.IsDownloaded}");