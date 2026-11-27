public class GameInstall {
    public int Id { get; private set; }
    public double MinRating { get; private set; }
    public Game? TargetGame { get; private set; }
    public bool IsCompleted { get; private set; }

    public GameInstall(int id, double minRating) {
        Id = id;

        if (minRating < 0) {
            MinRating = 0;
        } else if (minRating > 10) {
            MinRating = 10;
        } else {
            MinRating = minRating;
        }

        TargetGame = null;
        IsCompleted = false;
    }

    public bool TryStart(Game game) {
        if (IsCompleted) {
            return false;
        }
        if (TargetGame != null) {
            return false;
        }
        if (game == null) {
            return false;
        }
        if (game.Rating < MinRating) {
            return false;
        }

        TargetGame = game;
        return true;
    }

    public bool TryFinish() {
        if (IsCompleted) {
            return false;
        }

        Game? game = TargetGame;
        if (game == null) {
            return false;
        }

        game.Download();
        IsCompleted = true;
        return true;
    }
}