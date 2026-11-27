public class GameInstall {
    public int Id { get; private set; }
    public double MinRating { get; private set; }
    public Game? TargetGame { get; private set; }
    public GameInstallStatus Status { get; private set; }

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
        Status = GameInstallStatus.Open;
    }

    public bool TryStart(Game game) {
        if (Status != GameInstallStatus.Open) {
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
        Status = GameInstallStatus.Active;
        return true;
    }

    public bool TryFinish() {
        if (Status != GameInstallStatus.Active) {
            return false;
        }

        Game? game = TargetGame;
        if (game == null) {
            return false;
        }

        game.Download();
        Status = GameInstallStatus.Completed;
        return true;
    }



    public bool TryCancel() {
        if (Status != GameInstallStatus.Open && Status != GameInstallStatus.Active) {
            return false;
        }

        Status = GameInstallStatus.Cancelled;
        return true;
    }
}