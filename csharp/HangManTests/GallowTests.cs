using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangMan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Tests {
  [TestClass()]
  public class GallowTests {
    [TestMethod()]
    public void ReturnStageOneTest() {
      string expected =
        "  +---+\n" +
        "  |   |\n" +
        "      |\n" +
        "      |\n" +
        "      |\n" +
        "      |\n" +
        "=========\n";
      Assert.AreEqual(expected, Gallow.ReturnStage(6));
    }
    [TestMethod()]
    public void ReturnStageTwoTest() {
      string expected =
        "  +---+\n" +
        "  |   |\n" +
        "  O   |\n" +
        "      |\n" +
        "      |\n" +
        "      |\n" +
        "=========\n";
      Assert.AreEqual(expected, Gallow.ReturnStage(5));
    }
    [TestMethod()]
    public void ReturnStageThreeTest() {
      string expected =
        "  +---+\n" +
        "  |   |\n" +
        "  O   |\n" +
        "  |   |\n" +
        "      |\n" +
        "      |\n" +
        "=========\n";
      Assert.AreEqual(expected, Gallow.ReturnStage(4));
    }
    [TestMethod()]
    public void ReturnStageFourTest() {
      string expected =
        "  +---+\n" +
        "  |   |\n" +
        "  O   |\n" +
        " /|   |\n" +
        "      |\n" +
        "      |\n" +
        "=========\n";
      Assert.AreEqual(expected, Gallow.ReturnStage(3));
    }
    [TestMethod()]
    public void ReturnStageFiveTest() {
      string expected =
        "  +---+\n" +
        "  |   |\n" +
        "  O   |\n" +
        " /|\\  |\n" +
        "      |\n" +
        "      |\n" +
        "=========\n";
      Assert.AreEqual(expected, Gallow.ReturnStage(2));
    }
    [TestMethod()]
    public void ReturnStageSixTest() {
      string expected =
        "  +---+\n" +
        "  |   |\n" +
        "  O   |\n" +
        " /|\\  |\n" +
        " /    |\n" +
        "      |\n" +
        "=========\n";
      Assert.AreEqual(expected, Gallow.ReturnStage(1));
    }
    [TestMethod()]
    public void ReturnStageFinalTest() {
      string expected =
        "  +---+\n" +
        "  |   |\n" +
        "  O   |\n" +
        " /|\\  |\n" +
        " / \\  |\n" +
        "      |\n" +
        "=========\n";
      Assert.AreEqual(expected, Gallow.ReturnStage(0));
    }
    [TestMethod()]
    public void ReturnStage_OutOfRange_Throws() {
      Assert.ThrowsException <System.Exception>(() => Gallow.ReturnStage(10));
    }
    [TestMethod()]
    public void ReturnStage_NegativeOutOfRange_Throws() {
      Assert.ThrowsException<System.Exception>(() => Gallow.ReturnStage(-5));
    }
  }
}

