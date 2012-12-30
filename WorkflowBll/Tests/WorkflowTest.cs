using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using WorkflowBll.Domain;
using WorkflowBll.Service;

namespace WorkflowBll.Tests
{
    [TestFixture]
    public class WorkflowTest
    {

        [SetUp]
        protected void Setup()
        {

        }

        [Test]
        public void GetExistingRenameStage()
        {
            WorkflowService _wService = new WorkflowService();
            var actual = _wService.GetRenameStage(2);
            Assert.AreEqual(actual.WaveName,"Wave 1" );
        }

        [Test]
        public void GetNonExistingRenameStage()
        {
            WorkflowService _wService = new WorkflowService();
            var actual = _wService.GetRenameStage(2);
            Assert.AreNotEqual(actual.WaveName, "Wave 2");
        }

        [TestCase (1,  TestName= "Value 1") ]
        [TestCase(2, TestName = "Value 2")]
        [TestCase(5, TestName = "Value 5")]
        [TestCase(6, TestName = "Value 6")]
        [TestCase(7, TestName = "Value 7")]
        public void GetManyRenameStage(double id)
        {
            WorkflowService _wService = new WorkflowService();
            var actual = _wService.GetRenameStage(id);
            Assert.AreEqual(actual.WaveName, "Wave 1");
        }
    }
}
