using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SUT;
using TechTalk.SpecFlow;

namespace Lab4.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly Calculator _calculator = new Calculator();
        private int _result;

        //[Given(@"Jag har skrivit in (.*) i kalkylatorn")]
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given(@"I have entered (.*) into the calculator"), Scope(Tag = "mydemotag")]
        public void GivenIHaveEnteredIntoTheCalculator2(int number)
        {
            _calculator.FirstNumber = number;
        }

        //[Then(@"the result should be (.*) on the screen")]
        //public void ThenTheResultHouldBeOnTheScreen(int p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}


        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, _result, "Sums should be equal.");
        }

        [Then(@"the result should not be (.*)")]
        public void ThenTheResultShouldNotBe(int wrongAnswer)
        {
            Assert.AreNotEqual(wrongAnswer, _result, "Should not have subtracted.");
        }

    }
}
