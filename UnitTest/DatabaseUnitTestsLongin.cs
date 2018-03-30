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
    public class DatabaseUnitTestsLongin : DatabaseTestClass
    {

        public DatabaseUnitTestsLongin()
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
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction dbo_LoginNhanVienTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseUnitTestsLongin));
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction dbo_LoginQuanLyTest_TestAction;
            Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Schema.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            Microsoft.Data.Schema.UnitTesting.Conditions.ChecksumCondition checksumCondition2;
            Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            this.dbo_LoginNhanVienTestData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
            this.dbo_LoginQuanLyTestData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
            dbo_LoginNhanVienTest_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            dbo_LoginQuanLyTest_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
            checksumCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.ChecksumCondition();
            checksumCondition2 = new Microsoft.Data.Schema.UnitTesting.Conditions.ChecksumCondition();
            rowCountCondition2 = new Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition2 = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_LoginNhanVienTestData
            // 
            this.dbo_LoginNhanVienTestData.PosttestAction = null;
            this.dbo_LoginNhanVienTestData.PretestAction = null;
            this.dbo_LoginNhanVienTestData.TestAction = dbo_LoginNhanVienTest_TestAction;
            // 
            // dbo_LoginNhanVienTest_TestAction
            // 
            dbo_LoginNhanVienTest_TestAction.Conditions.Add(checksumCondition2);
            dbo_LoginNhanVienTest_TestAction.Conditions.Add(rowCountCondition2);
            dbo_LoginNhanVienTest_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(dbo_LoginNhanVienTest_TestAction, "dbo_LoginNhanVienTest_TestAction");
            // 
            // dbo_LoginQuanLyTestData
            // 
            this.dbo_LoginQuanLyTestData.PosttestAction = null;
            this.dbo_LoginQuanLyTestData.PretestAction = null;
            this.dbo_LoginQuanLyTestData.TestAction = dbo_LoginQuanLyTest_TestAction;
            // 
            // dbo_LoginQuanLyTest_TestAction
            // 
            dbo_LoginQuanLyTest_TestAction.Conditions.Add(rowCountCondition1);
            dbo_LoginQuanLyTest_TestAction.Conditions.Add(scalarValueCondition1);
            dbo_LoginQuanLyTest_TestAction.Conditions.Add(checksumCondition1);
            resources.ApplyResources(dbo_LoginQuanLyTest_TestAction, "dbo_LoginQuanLyTest_TestAction");
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
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "12345";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "592676916";
            checksumCondition1.Enabled = true;
            checksumCondition1.Name = "checksumCondition1";
            // 
            // checksumCondition2
            // 
            checksumCondition2.Checksum = "459016561";
            checksumCondition2.Enabled = true;
            checksumCondition2.Name = "checksumCondition2";
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 1;
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 1;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "123456";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
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
        public void dbo_LoginNhanVienTest()
        {
            DatabaseTestActions testActions = this.dbo_LoginNhanVienTestData;
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

        [TestMethod()]
        public void dbo_LoginQuanLyTest()
        {
            DatabaseTestActions testActions = this.dbo_LoginQuanLyTestData;
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
private DatabaseTestActions dbo_LoginNhanVienTestData;
private DatabaseTestActions dbo_LoginQuanLyTestData;
    }
}
