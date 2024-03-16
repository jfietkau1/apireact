namespace APIreactfun.Data
{
    public class BowlerTeamInfo
    {
        // Properties from the Bowlers entity
        public int BowlerId { get; set; }
        public string? BowlerLastName { get; set; }
        public string? BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; }
        public string? BowlerZip { get; set; }
        public string? BowlerPhoneNumber { get; set; }

        // Properties from the Teams entity
        public int TeamId { get; set; }
        public string? TeamName { get; set; }

        // Additional property from the Teams entity
        // If you want to include the captain's information in the DTO
        // You'd also need to make sure you include this in the join operation in the repository
        public int? CaptainId { get; set; }
    }
}
