// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);

// Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(25);
// anastasia.TakeDamage(30);

// Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");


// yaroslav.TakeDamage(-20);
// Console.WriteLine($"После неверного урона: {yaroslav.Health}");

// artem.TakeDamage(200);
// Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

// yaroslav.Heal(10);
// yaroslav.GainExperience(40);
// yaroslav.GainExperience(25);

// Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
// Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");





// bool yaroslavAlive = yaroslav.IsAlive();
// Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
// Console.WriteLine($"Артём жив: {artem.IsAlive()}");

// if (yaroslavAlive) {
//     Console.WriteLine("Ярослав может продолжать приключение.");
// } else {
//     Console.WriteLine("Ярослав больше не может сражаться.");
// }



// string info = yaroslav.GetInfo();
// Console.WriteLine("Строка получена. Сейчас выведем её:");
// Console.WriteLine(info);

// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());












Game game1 = new Game("CS2", "Shooter", 2023, 5.5);
Game game2 = new Game("Minecraft", "Sandbox", 2011, 8.4);


Console.WriteLine($"Скачана ли игра: {game2.IsDownloaded}");
game2.Download(); 
Console.WriteLine($"После скачивания: {game2.IsDownloaded}");
game2.Download();


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