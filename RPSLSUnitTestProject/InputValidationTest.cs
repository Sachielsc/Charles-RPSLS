using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPSLSUnitTestProject
{
    [TestClass]
    public class InputValidationTest
    {
		[TestMethod]
		public void ValidInputTestMethods()
		{
			Assert.AreEqual("Valid input", RPSLS.MainProgram.InputValidation("1"));
			Assert.AreEqual("Valid input", RPSLS.MainProgram.InputValidation("2"));
			Assert.AreEqual("Valid input", RPSLS.MainProgram.InputValidation("3"));
			Assert.AreEqual("Valid input", RPSLS.MainProgram.InputValidation("4"));
			Assert.AreEqual("Valid input", RPSLS.MainProgram.InputValidation("5"));
		}
		[TestMethod]
		public void InvalidInputTestMethods()
		{
			Assert.AreEqual("Invalid input!", RPSLS.MainProgram.InputValidation("6"));
			Assert.AreEqual("Invalid input!", RPSLS.MainProgram.InputValidation("10"));
			Assert.AreEqual("Invalid input!", RPSLS.MainProgram.InputValidation("1a"));
			Assert.AreEqual("Invalid input!", RPSLS.MainProgram.InputValidation("a"));
			Assert.AreEqual("Invalid input!", RPSLS.MainProgram.InputValidation("exi t"));
		}
		[TestMethod]
		public void ExitProgramTestMethod()
		{
			Assert.AreEqual("exit program", RPSLS.MainProgram.InputValidation("exit"));
		}
	}
}
