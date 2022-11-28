using CA1_v2.Repository;

namespace CA1_v2.Models
{
    public class Stats 
    {
        public IEnumerable<Match> matches;
        public int Won { get; set; }
        public int Lost { get; set; }
        public int Drew { get; set; }
        public int Points { get; set; }
        public int GoalDiff { get; set; }

        public Stats(IMatchRepo m)
        {
            matches = m.GetFixtures();
            IEnumerable<Match> PlayedMatches = matches.Where(p => p.MatchDate < DateTime.Today.Date);
            Won = PlayedMatches.Where(p => (p.GoalsFor > p.GoalsAgainst)).ToList().Count;
            Lost = PlayedMatches.Where(p => (p.GoalsFor < p.GoalsAgainst)).ToList().Count;
            Drew = PlayedMatches.Where(p => (p.GoalsFor == p.GoalsAgainst)).ToList().Count;
            Points = PlayedMatches.Select(p =>
            {
                if (p.GoalsFor > p.GoalsFor) return 3; //Win
                if (p.GoalsFor == p.GoalsFor) return 1; //Draw
                return 0;                              //Lose                                            
            }).Sum();                                //Now sum list of ints
            //GoalDiff = (PlayedMatches.Sum(p => p.GoalsFor)) - (PlayedMatches.Sum(p => p.GoalsAgainst));

        }


    }
}
