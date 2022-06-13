using NUnit.Framework;
using TextFiltersConsoleApp.TextFilters;

namespace TextFiltersConsoleApp.Tests
{
    public class ContainsLetterTFilterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("destruction", "")]
        [TestCase("interrupt", "")]
        [TestCase("agreement", "")]
        [TestCase("beginning", "beginning")]
        [TestCase("Movement", "")]
        [TestCase("marriage", "marriage")]
        [TestCase("contempt", "")]
        [TestCase("THISTLE", "THISTLE")]
        [TestCase("gradual", "gradual")]
        [TestCase("lecture", "")]
        [TestCase("dragon", "dragon")]
        [TestCase("unfair", "unfair")]
        [TestCase("report", "")]
        [TestCase("PLEASE", "PLEASE")]
        [TestCase("rotten", "")]
        [TestCase("Tidy", "Tidy")]
        [TestCase("PILE", "PILE")]
        [TestCase("spot", "")]
        [TestCase("SLAB", "SLAB")]
        [TestCase("clue", "clue")]
        [TestCase("red", "red")]
        [TestCase("hat", "")]
        [TestCase("Me", "Me")]
        [TestCase("it", "")]
        [TestCase("as", "as")]
        [TestCase("I", "I")]
        public void Filter_Input_String_Returns_ValidOutput(string input, string expectedResult)
        {
            var filter = new ContainsLetterTFilter();

            var output = filter.Apply(input);

            Assert.AreEqual(output, expectedResult);
        }
    }
}