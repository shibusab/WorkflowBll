using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using WorkflowBll.ZFramework2.Service;
using WorkflowBll.ZFramework2.Domain.Impl;

namespace WorkflowBll.ZFramework2.Tests
{
    [TestFixture]
    public class ZFramework2Test
    {
        [SetUp]
        protected void Setup()
        {

        }

        [Test]
        public void GetExistingVideoCaptureStage()
        {
            WorkflowService _wService = new WorkflowService();
            var actual = _wService.GetWorkVideoCaptureStage (2);
            Assert.AreEqual(actual.WorkflowName , "Workflow-1");
        }

        [Test]
        public void GetExistingAudioCaptureStage()
        {
            WorkflowService _wService = new WorkflowService();
            var actual = _wService.GetAudioCaptureStage(2);
            Assert.AreEqual(actual.WorkflowName, "Workflow-1");
        }

        [Test]
        public void GetExistingRenameStage()
        {
            WorkflowService _wService = new WorkflowService();
            var actual = (Rename)_wService.GetRenameStage(2);
            Assert.AreEqual(actual.NewFileName , "new file1");
        }
    }
}
