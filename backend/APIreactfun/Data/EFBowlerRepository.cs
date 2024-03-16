namespace APIreactfun.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private readonly BowlerContext _bowlerContext;

        public EFBowlerRepository(BowlerContext temp)
        {
            _bowlerContext = temp;
        }

        public IEnumerable<Bowlers> Bowlers => _bowlerContext.Bowlers;

        public IEnumerable<Teams> Teams => _bowlerContext.Teams;

        // Implement the GetBowlerTeams method to perform the join
        public IEnumerable<BowlerTeamInfo> GetBowlerTeams()
        {
            var bowlerTeams = _bowlerContext.Bowlers
                .Join(_bowlerContext.Teams,
                    bowler => bowler.TeamId,
                    team => team.TeamId,
                    (bowler, team) => new BowlerTeamInfo
                    {
                        BowlerId = bowler.BowlerId,
                        BowlerLastName = bowler.BowlerLastName,
                        BowlerFirstName = bowler.BowlerFirstName,
                        BowlerMiddleInit = bowler.BowlerMiddleInit,
                        BowlerAddress = bowler.BowlerAddress,
                        BowlerCity = bowler.BowlerCity,
                        BowlerState = bowler.BowlerState,
                        BowlerZip = bowler.BowlerZip,
                        BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                        TeamId = team.TeamId,
                        TeamName = team.TeamName,
                        CaptainId = team.CaptainId 
                    })
                .ToList();

            return bowlerTeams;
        }
    }
}
