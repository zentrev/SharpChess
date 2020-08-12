using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpChess.Model;
namespace ChessTest
{
    [TestClass]
    public class ChessTest
    {
        [TestMethod]
        public void Check96ModeOff()
        {
            Game.New();
            Game.UseRandomOpeningMoves = false;
            Assert.AreEqual("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", Fen.GameStartPosition);
        }

        [TestMethod]
        public void Check96ModeOn()
        {
            Game.New();
            Game.UseRandomOpeningMoves = true;
            Assert.AreNotEqual("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", Fen.GameStartPosition);
        }

        [TestMethod]
        public void Check96ModeOnReset()
        {
            Game.New();
            Game.UseRandomOpeningMoves = false;
            Assert.AreEqual("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", Fen.GameStartPosition);
            Game.UseRandomOpeningMoves = true;
            Assert.AreNotEqual("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", Fen.GameStartPosition);
        }

        [TestMethod]
        public void Check96ModeOffReset()
        {
            Game.New();
            Game.UseRandomOpeningMoves = true;
            Assert.AreNotEqual("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", Fen.GameStartPosition);
            Game.UseRandomOpeningMoves = false;
            Assert.AreEqual("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", Fen.GameStartPosition);
        }

        [TestMethod]
        public void Check96ModeDefault()
        {
            Game.New();
            Assert.IsNotNull(Fen.GameStartPosition);
        }
    }
}
