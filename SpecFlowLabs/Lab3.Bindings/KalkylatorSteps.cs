using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SUT;
using TechTalk.SpecFlow;

namespace Lab3.Bindings
{
    [Binding]
    public class KalkylatorSteps
    {
        private readonly Calculator _calculator = new Calculator();
        private int _result;

        [Given(@"Jag har skrivit in (.*) i kalkylatorn")]
        public void GivetJagHarSkrivitInIKalkylatorn(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given(@"Jag har också skrivit in (.*) i kalkylatorn")]
        public void GivetJagHarOcksaSkrivitInIKalkylatorn(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When(@"Jag klickar på Addera")]
        public void NarJagKlickarPaAddera()
        {
            _result = _calculator.Add();
        }

        [Then(@"Ska resultatet bli (.*) på skärmen")]
        public void SaSkaResultatetBliPaSkarmen(int expected)
        {
            Assert.AreEqual(expected, _result);
        }
    }
}
