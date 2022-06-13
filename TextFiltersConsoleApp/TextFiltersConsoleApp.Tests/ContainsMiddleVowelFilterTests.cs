using NUnit.Framework;
using TextFiltersConsoleApp.TextFilters;

namespace TextFiltersConsoleApp.Tests
{
    public class ContainsMiddleVowelFilterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("destruction", "destrction")]
        [TestCase("interrupt", "interrupt")]
        [TestCase("agreement", "agrement")]
        [TestCase("beginning", "beginning")]
        [TestCase("Movement", "Movment")]
        [TestCase("marriage", "marrage")]
        [TestCase("contempt", "contmpt")]
        [TestCase("THISTLE", "THISTLE")]
        [TestCase("gradual", "gradual")]
        [TestCase("lecture", "lecture")]
        [TestCase("dragon", "drgon")]
        [TestCase("unfair", "unfir")]
        [TestCase("report", "reprt")]
        [TestCase("PLEASE", "PLSE")]
        [TestCase("rotten", "rotten")]
        [TestCase("Tidy", "Tdy")]
        [TestCase("PILE", "PLE")]
        [TestCase("spot", "spt")]
        [TestCase("SLAB", "SLB")]
        [TestCase("clue", "cle")]
        [TestCase("red", "rd")]
        [TestCase("hat", "ht")]
        [TestCase("Me", "Me")]
        [TestCase("it", "it")]
        [TestCase("as", "as")]
        [TestCase("I", "I")]
        public void Filter_Input_String_Returns_ValidOutput(string input, string expectedResult)
        {
            var filter = new ContainsMiddleVowelFilter();

            var output = filter.Apply(input);

            Assert.AreEqual(output, expectedResult);
        }
    }
}