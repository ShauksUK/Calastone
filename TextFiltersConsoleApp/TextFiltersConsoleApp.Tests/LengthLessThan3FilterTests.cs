using NUnit.Framework;
using TextFiltersConsoleApp.TextFilters;

namespace TextFiltersConsoleApp.Tests
{
    public class LengthLessThan3FilterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("destruction", "destruction")]
        [TestCase("interrupt", "interrupt")]
        [TestCase("agreement", "agreement")]
        [TestCase("beginning", "beginning")]
        [TestCase("Movement", "Movement")]
        [TestCase("marriage", "marriage")]
        [TestCase("contempt", "contempt")]
        [TestCase("THISTLE", "THISTLE")]
        [TestCase("gradual", "gradual")]
        [TestCase("lecture", "lecture")]
        [TestCase("dragon", "dragon")]
        [TestCase("unfair", "unfair")]
        [TestCase("report", "report")]
        [TestCase("PLEASE", "PLEASE")]
        [TestCase("rotten", "rotten")]
        [TestCase("Tidy", "Tidy")]
        [TestCase("PILE", "PILE")]
        [TestCase("spot", "spot")]
        [TestCase("SLAB", "SLAB")]
        [TestCase("clue", "clue")]
        [TestCase("red", "red")]
        [TestCase("hat", "hat")]
        [TestCase("Me", "")]
        [TestCase("it", "")]
        [TestCase("as", "")]
        [TestCase("I", "")]

        public void Filter_Input_String_Returns_ValidOutput(string input, string expectedResult)
        {
            var filter = new LengthLessThan3Filter();

            var output = filter.Apply(input);

            Assert.AreEqual(output, expectedResult);
        }
    }
}