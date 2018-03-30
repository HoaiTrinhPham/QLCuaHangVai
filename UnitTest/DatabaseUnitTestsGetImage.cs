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
    public class DatabaseUnitTestsGetImage : DatabaseTestClass
    {

        public DatabaseUnitTestsGetImage()
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
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction dbo_GetImagesNhanVienTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseUnitTestsGetImage));
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction dbo_GetImagesQuanLyTest_TestAction;
            Microsoft.Data.Schema.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Schema.UnitTesting.Conditions.ChecksumCondition checksumCondition2;
            Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            this.dbo_GetImagesNhanVienTestData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
            this.dbo_GetImagesQuanLyTestData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
            dbo_GetImagesNhanVienTest_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            dbo_GetImagesQuanLyTest_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            checksumCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.ChecksumCondition();
            rowCountCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
            checksumCondition2 = new Microsoft.Data.Schema.UnitTesting.Conditions.ChecksumCondition();
            rowCountCondition2 = new Microsoft.Data.Schema.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition2 = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_GetImagesNhanVienTestData
            // 
            this.dbo_GetImagesNhanVienTestData.PosttestAction = null;
            this.dbo_GetImagesNhanVienTestData.PretestAction = null;
            this.dbo_GetImagesNhanVienTestData.TestAction = dbo_GetImagesNhanVienTest_TestAction;
            // 
            // dbo_GetImagesNhanVienTest_TestAction
            // 
            dbo_GetImagesNhanVienTest_TestAction.Conditions.Add(checksumCondition2);
            dbo_GetImagesNhanVienTest_TestAction.Conditions.Add(rowCountCondition2);
            dbo_GetImagesNhanVienTest_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(dbo_GetImagesNhanVienTest_TestAction, "dbo_GetImagesNhanVienTest_TestAction");
            // 
            // dbo_GetImagesQuanLyTestData
            // 
            this.dbo_GetImagesQuanLyTestData.PosttestAction = null;
            this.dbo_GetImagesQuanLyTestData.PretestAction = null;
            this.dbo_GetImagesQuanLyTestData.TestAction = dbo_GetImagesQuanLyTest_TestAction;
            // 
            // dbo_GetImagesQuanLyTest_TestAction
            // 
            dbo_GetImagesQuanLyTest_TestAction.Conditions.Add(checksumCondition1);
            dbo_GetImagesQuanLyTest_TestAction.Conditions.Add(rowCountCondition1);
            dbo_GetImagesQuanLyTest_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(dbo_GetImagesQuanLyTest_TestAction, "dbo_GetImagesQuanLyTest_TestAction");
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "2059828697";
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
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "1";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // checksumCondition2
            // 
            checksumCondition2.Checksum = "2059828697";
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
            scalarValueCondition2.ExpectedValue = "1";
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
        public void dbo_GetImagesNhanVienTest()
        {
            DatabaseTestActions testActions = this.dbo_GetImagesNhanVienTestData;
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
        public void dbo_GetImagesQuanLyTest()
        {
            DatabaseTestActions testActions = this.dbo_GetImagesQuanLyTestData;
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
private DatabaseTestActions dbo_GetImagesNhanVienTestData;
private DatabaseTestActions dbo_GetImagesQuanLyTestData;
    }
}
