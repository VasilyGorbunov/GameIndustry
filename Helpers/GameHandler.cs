namespace GameIndustry.Helpers
{
    public class GameHandler
    {
        public GameHandler(RSPOptions choose, RSPOptions winCondition, RSPOptions looseCondition, string image)
        {
            Choose = choose;
            WinCondition = winCondition;
            LooseCondition = looseCondition;
            Image = image;
        }

        public RSPOptions Choose { get; set; }
        public RSPOptions WinCondition { get; set; }
        public RSPOptions LooseCondition { get; set; }
        public string Image { get; set; }

        public GameState GameResult(GameHandler opponent)
        {
            if (Choose == opponent.Choose) return GameState.Draw;
            if (LooseCondition == opponent.Choose) return GameState.Loss;

            return GameState.Victory;
        }
    }
}
