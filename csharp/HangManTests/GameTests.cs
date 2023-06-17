using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangMan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Tests {
  [TestClass()]
  public class GameTests {
    Game game = new Game();
    [TestMethod()]
    public void CheckLetterLowerCaseHTest() {
      bool expected = true;
      bool result = game.CheckLetter('h');
      Assert.AreEqual(expected, result);
    }
    [TestMethod()]
    public void CheckLetterLowerCaseATest() {
      bool expected = true;
      bool result = game.CheckLetter('a');
      Assert.AreEqual(expected, result);
    }
    [TestMethod()]
    public void CheckLetterUpperCaseGTest() {
      bool expected = true;
      bool result = game.CheckLetter('G');
      Assert.AreEqual(expected, result);
    }
    [TestMethod()]
    public void CheckLetterUpperCaseNTest() {
      bool expected = true;
      bool result = game.CheckLetter('N');
      Assert.AreEqual(expected, result);
    }
    [TestMethod()]
    public void CheckLetterLowerCasemTest() {
      bool expected = true;
      bool result = game.CheckLetter('m');
      Assert.AreEqual(expected, result);
    }
    [TestMethod()]
    public void CheckLetterUpperCaseMTest() {
      bool expected = true;
      bool result = game.CheckLetter('M');
      Assert.AreEqual(expected, result);
    }
    [TestMethod()]
    public void CheckLetterLowerCaseNegativeOTest() {
      bool expected = false;
      bool result = game.CheckLetter('o');
      Assert.AreEqual(expected, result);
    }
    [TestMethod()]
    public void CheckLetterUpperCaseNegativeBTest() {
      bool expected = false;
      bool result = game.CheckLetter('B');
      Assert.AreEqual(expected, result);
    }
    [TestMethod()]
    public void CheckLetterNumberTest() {
      bool expected = false;
      bool result = game.CheckLetter('5');
      Assert.AreEqual(expected, result);
    }
    [TestMethod()]
    public void CheckLetterNewlineTest() {
      bool expected = false;
      bool result = game.CheckLetter('\n');
      Assert.AreEqual(expected, result);
    }
    [TestMethod()]
    public void CheckLetterSpaceTest() {
      bool expected = false;
      bool result = game.CheckLetter(' ');
      Assert.AreEqual(expected, result);
    }
    [TestMethod()]
    public void CheckCanBeUsedUpperATest() {
      Assert.IsTrue(game.CheckCanBeUsed('A'));
    }
    [TestMethod()]
    public void CheckCanBeUsedLowerGTest() {
      Assert.IsTrue(game.CheckCanBeUsed('g'));
    }
    [TestMethod()]
    public void CheckCanBeUsedUpperZTest() {
      Assert.IsTrue(game.CheckCanBeUsed('Z'));
    }
    [TestMethod()]
    public void CheckCanBeUsedLowerXTest() {
      Assert.IsTrue(game.CheckCanBeUsed('x'));
    }
    [TestMethod()]
    public void CheckCanBeUsedNumberTest() {
      Assert.IsFalse(game.CheckCanBeUsed('5'));
    }
    [TestMethod()]
    public void CheckCanBeUsedWhiteSpaceTest() {
      Assert.IsFalse(game.CheckCanBeUsed('\t'));
    }
    [TestMethod()]
    public void CheckCanBeUsedSpaceTest() {
      Assert.IsFalse(game.CheckCanBeUsed(' '));
    }
    [TestMethod()]
    public void ShowGuessedLowerHTest() {
      string expected = "H______";
      game.ShowGuessed('h');
      Assert.AreEqual(expected, game.Guess);
    }
    [TestMethod()]
    public void ShowGuessedUpperATest() {
      string expected = "_A___A_";
      game.ShowGuessed('A');
      Assert.AreEqual(expected, game.Guess);
    }
    [TestMethod()]
    public void ShowGuessedNumberTest() {
      string expected = "_______";
      game.ShowGuessed('5');
      Assert.AreEqual(expected, game.Guess);
    }
    [TestMethod()]
    public void ShowGuessedSpaceTest() {
      string expected = "_______";
      game.ShowGuessed(' ');
      Assert.AreEqual(expected, game.Guess);
    }
    [TestMethod()]
    public void ShowGuessedUpperDTest() {
      string expected = "_______";
      game.ShowGuessed('D');
      Assert.AreEqual(expected, game.Guess);
    }
    [TestMethod()]
    public void ShowGuessedLowerMandNTest() {
      string expected = "__N_M_N";
      game.ShowGuessed('n');
      game.ShowGuessed('m');
      Assert.AreEqual(expected, game.Guess);
    }
    [TestMethod()]
    public void RemoveLetterLowerBTest() {
      game.RemoveLetter('b');
      Assert.IsTrue(!game.AvailableLetters.Contains('b'));
    }
    [TestMethod()]
    public void RemoveLetterUpperKTest() {
      game.RemoveLetter('K');
      Assert.IsTrue(!game.AvailableLetters.Contains('K'));
    }
    [TestMethod()]
    public void RemoveLetterSignTest() {
      game.RemoveLetter(':');
      Assert.IsTrue(!game.AvailableLetters.Contains(':'));
    }
    [TestMethod()]
    public void RemoveLifeTest() {
      game.RemoveLife();
      int expected = 5;
      Assert.AreEqual(expected, game.Lives);
    }
    [TestMethod()]
    public void RemoveFiveLivesTest() {
      for(int i = 0; i<5; i++)
        game.RemoveLife();
      int expected = 1;
      Assert.AreEqual(expected, game.Lives);
    }
    [TestMethod()]
    public void CheckIfWinLoseTest() {
      Game newGame = new Game();
      Assert.IsFalse(newGame.CheckIfWin());
    }
    [TestMethod()]
    public void CheckIfWinWinTest() {
      Game newGame = new Game();
      foreach (char letter in newGame.Word.Distinct())
        newGame.ShowGuessed(letter);
      Assert.IsTrue(newGame.CheckIfWin());
    }
  }
}

