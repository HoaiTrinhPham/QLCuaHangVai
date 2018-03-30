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
    public class DatabaseUnitTestsKiemTraHangTon : DatabaseTestClass
    {

        public DatabaseUnitTestsKiemTraHangTon()
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
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction dbo_kiemTraHangTonTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseUnitTestsKiemTraHangTon));
            Microsoft.Data.Schema.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            this.dbo_kiemTraHangTonTestData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
            dbo_kiemTraHangTonTest_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            checksumCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.ChecksumCondition();
            rowCountCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_kiemTraHangTonTest_TestAction
            // 
            dbo_kiemTraHangTonTest_TestAction.Conditions.Add(checksumCondition1);
            dbo_kiemTraHangTonTest_TestAction.Conditions.Add(rowCountCondition1);
            dbo_kiemTraHangTonTest_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(dbo_kiemTraHangTonTest_TestAction, "dbo_kiemTraHangTonTest_TestAction");
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "1441794404";
            checksumCondition1.Enabled = true;
            checksumCondition1.Name = "checksumCondition1";
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 6;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "20000";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // dbo_kiemTraHangTonTestData
            // 
            this.dbo_kiemTraHangTonTestData.PosttestAction = null;
            this.dbo_kiemTraHangTonTestData.PretestAction = null;
            this.dbo_kiemTraHangTonTestData.TestAction = dbo_kiemTraHangTonTest_TestAction;
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
        public void dbo_kiemTraHangTonTest()
        {
            DatabaseTestActions testActions = this.dbo_kiemTraHangTonTestData;
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
        private DatabaseTestActions dbo_kiemTraHangTonTestData;
    }
}
