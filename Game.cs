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
        Rating = rating;
    }
    

    public void Download() {
        if (IsDownloaded) {
            return;
        }
        IsDownloaded = true;
    }
}
