public class GameCatalog {
    private List<Game> _games = new List<Game>();
    private readonly List<GameInstall> _installs = new List<GameInstall>();

    public string Name { get; private set; }

    public int GameCount {
        get { return _games.Count; }
    }

    public GameCatalog(string name) {
        Name = name;
    }

    public bool AddGame(Game game) {
        if (FindGameByTitle(game.Title) != null) {
            return false;
        }

        _games.Add(game);
        return true;
    }

    public Game? FindGameByTitle(string title) {
        if (string.IsNullOrWhiteSpace(title)) {
            return null;
        }

        string searchTitle = title.Trim();

        foreach (Game game in _games) {
            if (string.Equals(game.Title, searchTitle, StringComparison.OrdinalIgnoreCase)) {
                return game;
            }
        }

        return null;
    }

    public bool RemoveGame(string title) {
        Game? game = FindGameByTitle(title);
        if (game == null) {
            return false;
        }

        return _games.Remove(game);
    }

    public List<Game> GetGames() {
        List<Game> result = new List<Game>();
        foreach (Game game in _games) {
            result.Add(game);
        }
        return result;
    }

    public int CountHighRated(double minRating) {
        int count = 0;
        foreach (Game game in _games) {
            if (game.Rating >= minRating) {
                count += 1;
            }
        }
        return count;
    }




    public bool AddInstall(GameInstall install) {
        if (install.Status != GameInstallStatus.Open) {
            return false;
        }
        _installs.Add(install);
        return true;
    }



    public bool IsGameBusy(Game game) {
        foreach (GameInstall install in _installs) {
            if (install.Status == GameInstallStatus.Active && install.TargetGame == game) {
                return true;
            }
        }
        return false;
    }



    public bool TryStartInstall(int installId, string title) {
        GameInstall? install = null;
        foreach (GameInstall item in _installs) {
            if (item.Id == installId) {
                install = item;
                break;
            }
        }
        if (install == null) {
            return false;
        }

        Game? game = FindGameByTitle(title);
        if (game == null) {
            return false;
        }

        if (IsGameBusy(game)) {
            return false;
        }

        return install.TryStart(game);
    }

    

    public bool TryCancelInstall(int installId) {
        foreach (GameInstall item in _installs) {
            if (item.Id == installId) {
                return item.TryCancel();
            }
        }
        return false;
    }
}