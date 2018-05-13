using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SUT;
using SUT_MVC.Controllers;
using SUT_MVC.Models;
using TechTalk.SpecFlow;

namespace Lab4.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly Calculator _calculator = new Calculator();
        private readonly ViewCalculator _mcvCalculator = new ViewCalculator();
        private int _result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given(@"I have entered (.*) into the calculator"), Scope(Tag = "mvc")]
        public void GivenIHaveEnteredTerm1(int number)
        {
            _mcvCalculator.Term1 = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            _calculator.SecondNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator"), Scope(Tag = "mvc")]
        public void GivenIHaveEnteredTerm2(int number)
        {
            _mcvCalculator.Term2 = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [When(@"I press add"), Scope(Tag="mvc")]
        public void WhenIPressAddMvc()
        {
            DefaultController controller = new DefaultController();

            ViewResult result = controller.Index(_mcvCalculator) as ViewResult;
            var res = result.Model as ViewCalculator;
            _result = res.Sum;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, _result, "Sums should be equal.");
        }

        //[Then(@"the result should be (.*) on the screen"), Scope(Tag="mvc")]
        //public void ThenTheResultFromControllerShouldBe(int expectedResult)
        //{
        //    // Arrange
        //    var model = new CalculationModel() { FirstNumber = 1, SecondNumber = 15 };
        //    int expected = 16;
        //    // Act
        //    var res = result.Model as CalculationModel;
        //    Assert.AreEqual(expected, res.Result);
        //    // Assert
        //    Assert.IsNotNull(result);

        //}

        [Then(@"the result should not be (.*)")]
        public void ThenTheResultShouldNotBe(int wrongAnswer)
        {
            Assert.AreNotEqual(wrongAnswer, _result, "Should not have subtracted.");
        }

    }
}
