using CA1_v2.Models;

namespace CA1_v2.Repository
{
    public interface IMatchRepo
    {
        List<Match> GetFixtures();
        Match GetFixture(int Id);

        void CreateFixture(Match m);
        void EditFixture(Match m);

    }
}
