namespace ChessLogic
{
    public enum player
    {
        None,
        White,
        Black

    }
    public static class PlayerExtensions
    {
        public static player opponent(this player player)
        {
            return player switch
            {
                player.White => player.Black,
                player.Black => player.White,
                _ => player.None,
            };
        }
    }
}
