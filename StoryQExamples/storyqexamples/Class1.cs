using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Framework;
using StoryQ;

namespace storyqexamples
{
    [TestFixture]
    public class MultipleScenariosStory
    {
        private Feature _feature;

        [SetUp]
        public void SetUp()
        {
            _feature = new Story("Potatoes Story").InOrderTo("Eat Potatoes").AsA("User").IWant("To Grow Potatoes");
        }

        [Test]
        public void scenario1()
        {
            _feature.WithScenario("Scenario 1")
                .Given(Something)
                .When(Something)
                .Then(Something)
                .ExecuteWithReport(MethodBase.GetCurrentMethod());
        }

        [Test]
        public void scenario2()
        {
            _feature.WithScenario("Scenario 2")
                .Given(Something)
                .When(Something)
                .Then(Something)
                .ExecuteWithReport(MethodBase.GetCurrentMethod());
        }

        [Test]
        public void scenario3()
        {
            _feature.WithScenario("Scenario 3")
                .Given(Something)
                .When(Something)
                .Then(Something)
                .ExecuteWithReport(MethodBase.GetCurrentMethod());
        }

        private void Something()
        {
            throw new NotImplementedException();
        }
    }
}
