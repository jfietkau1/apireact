namespace APIreactfun.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowlers> Bowlers { get; }
        IEnumerable<Teams> Teams { get; }
        IEnumerable<BowlerTeamInfo> GetBowlerTeams(); // Add this method
    }
}