public class Game {
    public string Title;
    public string Genre;
    public int ReleaseDate;
    public double Rating;
    public bool IsDownloaded;


    public Game(string title, string genre, int releaseYear, double rating) {
        Title = title;
        Genre = genre;
        ReleaseDate = releaseYear;
        
        if (rating < 0) {
            Rating = 0;
        } else if (rating > 10) {
            Rating = 10;
        } else {
            Rating = rating;
        } 
    }


    public void Download() {
        if (IsDownloaded) {
            return;
        }
        IsDownloaded = true;
    }


    public void ChangeRating(double otziv) {
        double update = Rating + otziv;

        if (update < 0) {
            Rating = 0;
            return;
        }

        if (update > 10) {
            Rating = 10;
            return;
        }

        Rating = update;
    }
    
    public string GetInfo() {
        return $">>> {Title} <<<\n" +
            $"Жанр: {Genre}\n" +
            $"Год релиза: {ReleaseDate}\n" +
            $"Рейтинг: {Rating}\n" +
            $"Скачано: {IsDownloaded}";
    }
}
