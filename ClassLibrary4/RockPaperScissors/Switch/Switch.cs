using NUnit.Framework;

namespace ClassLibrary4.RockPaperScissors.Switch
{
    [TestFixture]
    class SwitchTests
    {
        [Test]
        public void RockBeatsScissors()
        {
            var rock = new Rock();
            Assert.That(rock.Beats("Scissors"), Is.True);
        }
        [Test]
        public void RockLoosesToPaper()
        {
            var rock = new Rock();
            Assert.That(rock.Beats("Paper"), Is.False);
        }
        [Test]
        public void PaperBeatsRock()
        {
            var paper = new Paper();
            Assert.That(paper.Beats("Rock"), Is.True);
        }
        [Test]
        public void PaperLoosesToScissors()
        {
            var paper = new Paper();
            Assert.That(paper.Beats("Scissors"), Is.False);
        }
        [Test]
        public void ScissorsBeatsPaper()
        {
            var scissors = new Scissors();
            Assert.That(scissors.Beats("Paper"), Is.True);
        }
        [Test]
        public void ScissorsLoosesToRock()
        {
            var scissors = new Scissors();
            Assert.That(scissors.Beats("Rock"), Is.False);
        }
    }

    class Paper
    {
        public bool Beats(string opponent)
        {
            switch (opponent)
            {
                case "Rock":
                    return true;
                case "Scissors":
                    return false;
                default:
                    return false;
            }
        }
    }

    class Scissors
    {
        public bool Beats(string opponent)
        {
            switch (opponent)
            {
                case "Paper":
                    return true;
                case "Rock":
                    return false;
                default:
                    return false;
            }
        }
    }

    class Rock
    {
        public bool Beats(string opponent)
        {
            switch (opponent)
            {
                case "Scissors":
                    return true;
                case "Paper":
                    return false;
                default:
                    return false;
            }
        }
    }
}
