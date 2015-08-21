using NUnit.Framework;

namespace ClassLibrary4.RockPaperScissors.DoubleDispatch
{
    [TestFixture]
    class DoubleDispatchTests
    {
        [Test]
        public void RockBeatsScissors()
        {
            var rock = new Rock();
            var scissors = new Scissors();
            Assert.That(rock.Beats(scissors), Is.True);
        }
        [Test]
        public void RockLoosesToPaper()
        {
            var rock = new Rock();
            var paper = new Paper();
            Assert.That(rock.Beats(paper), Is.False);
        }
        [Test]
        public void PaperBeatsRock()
        {
            var paper = new Paper();
            var rock = new Rock();
            Assert.That(paper.Beats(rock), Is.True);
        }
        [Test]
        public void PaperLoosesToScissors()
        {
            var paper = new Paper();
            var scissors = new Scissors();
            Assert.That(paper.Beats(scissors), Is.False);
        }
        [Test]
        public void ScissorsBeatsPaper()
        {
            var scissors = new Scissors();
            var paper = new Paper();
            Assert.That(scissors.Beats(paper), Is.True);
        }
        [Test]
        public void ScissorsLoosesToRock()
        {
            var rock = new Rock();
            var scissors = new Scissors();
            Assert.That(scissors.Beats(rock), Is.False);
        }
    }

    interface IOpponent
    {
        bool Beats(IOpponent opponent);
        bool BeatenByRock();
        bool BeatenByPaper();
        bool BeatenByScissors();
    }

    class Paper : IOpponent
    {
        public bool Beats(IOpponent opponent)
        {
            return opponent.BeatenByPaper();
        }

        public bool BeatenByRock()
        {
            return false;
        }

        public bool BeatenByPaper()
        {
            return false;
        }

        public bool BeatenByScissors()
        {
            return true;
        }
    }

    class Scissors : IOpponent
    {
        public bool Beats(IOpponent opponent)
        {
            return opponent.BeatenByScissors();
        }

        public bool BeatenByRock()
        {
            return true;
        }

        public bool BeatenByPaper()
        {
            return false;
        }

        public bool BeatenByScissors()
        {
            return false;
        }
    }

    class Rock : IOpponent
    {
        public bool Beats(IOpponent opponent)
        {
            return opponent.BeatenByRock();
        }

        public bool BeatenByRock()
        {
            return false;
        }

        public bool BeatenByPaper()
        {
            return true;
        }

        public bool BeatenByScissors()
        {
            return false;
        }
    }
}
