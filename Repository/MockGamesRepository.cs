using GameIndustry.Models;

namespace GameIndustry.Repository
{
    public class MockGamesRepository : IRepository
    {
        private readonly List<Game> _games;

        public MockGamesRepository()
        {
            _games = new List<Game>() {
                new()
                {
                    Name = "Farming Simulator 2019",
                    Genre = "Simulator",
                    ReleaseDate = new DateTime(2018, 11, 19)
                },
                new()
                {
                    Name = "The Witcher 3",
                    Genre = "Action/RPG",
                    ReleaseDate = new DateTime(2015, 5, 18)
                },
                new()
                {
                    Name = "Destroy All Humans",
                    Genre = "Action/Adventure",
                    ReleaseDate = new DateTime(2020, 7, 28)
                }
            };
        }

        public List<Game> GetAllGames()
        {
            return _games;
        }
    }
}
