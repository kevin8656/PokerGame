using NUnit.Framework;

namespace PokerGame
{
    public class PokerGameTest
    {
        [Test]
        public void full_house_vs_four_of_a_kind()
        {
            var pokerGame = new PokerGame("S9,DA,CA,C9,H9","S2,D2,H2,C2,D9");
        }
    }
}