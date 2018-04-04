using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Data.Schema.UnitTesting;
using Microsoft.Data.Schema.UnitTesting.Conditions;

namespace UnitTest
{
    [TestClass()]
    public class DatabaseUnitTestsXuatHang : DatabaseTestClass
    {

        public DatabaseUnitTestsXuatHang()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction dbo_XuatHangTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseUnitTestsXuatHang));
            Microsoft.Data.Schema.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            this.dbo_XuatHangTestData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
            dbo_XuatHangTest_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            checksumCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.ChecksumCondition();
            // 
            // dbo_XuatHangTest_TestAction
            // 
            dbo_XuatHangTest_TestAction.Conditions.Add(checksumCondition1);
            resources.ApplyResources(dbo_XuatHangTest_TestAction, "dbo_XuatHangTest_TestAction");
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "-1113720315";
            checksumCondition1.Enabled = true;
            checksumCondition1.Name = "checksumCondition1";
            // 
            // dbo_XuatHangTestData
            // 
            this.dbo_XuatHangTestData.PosttestAction = null;
            this.dbo_XuatHangTestData.PretestAction = null;
            this.dbo_XuatHangTestData.TestAction = dbo_XuatHangTest_TestAction;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion


        [TestMethod()]
        public void dbo_XuatHangTest()
        {
            DatabaseTestActions testActions = this.dbo_XuatHangTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            ExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            ExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            ExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        private DatabaseTestActions dbo_XuatHangTestData;
    }
}
