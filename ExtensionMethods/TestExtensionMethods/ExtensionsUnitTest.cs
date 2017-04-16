using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common.String.Extensions;
using System.Data;
using Common.Data.Extensions;

namespace TestExtensionMethods
{
    [TestClass]
    public class ExtensionsUnitTest
    {
        [TestMethod]
        public void TestBasicString()
        {
            var source = "";
            var source1 = "ds";
            string str = null;
            Assert.IsTrue(source.IsEmpty(), "failed");
            Assert.IsTrue(str.IsEmpty());
            Assert.IsTrue(source1.IsNotEmpty(), "failed");
        }


        [TestMethod]
        public void TestConversion()
        {
            var source = "";
            var source1 = "ds";
            var source2 = "10";
            var source3 = "102342342343232.75";
            string str = null;
            Assert.IsTrue(source.ToIntSafe() >= 0, "failed");
            Assert.IsTrue(str.ToIntSafe() >= 0, "failed");
            Assert.IsTrue(source1.ToIntSafe() >= 0, "failed");
            Assert.IsTrue(source2.ToInt() == 10, "failed");
            Assert.IsTrue(source3.ToIntSafe() == 0, "failed");
            Assert.IsTrue(source1.ToShortSafe() >= 0, "failed");
            Assert.IsTrue(source2.ToShort() == 10, "failed");
            Assert.IsTrue(source3.ToShortSafe() == 0, "failed");
            Assert.IsTrue(source1.ToLongSafe() >= 0, "failed");
            Assert.IsTrue(source2.ToLong() == 10, "failed");
            Assert.IsTrue(source3.ToLongSafe() == 102342342343232, "failed");

            Assert.IsTrue(source1.ToDoubleSafe() >= 0, "failed");
            Assert.IsTrue(source2.ToDouble() == 10, "failed");
            Assert.IsTrue(source3.ToDoubleSafe() == 102342342343232.75, "failed");

            Assert.IsTrue(source1.ToDecimalSafe() >= 0, "failed");
            Assert.IsTrue(source2.ToDecimal() == 10, "failed");
            Assert.IsTrue(source3.ToDecimalSafe() >= 0232332, "failed");

            Assert.IsTrue(source1.ToFloatSafe() >= 0, "failed");
            Assert.IsTrue(source3.ToFloatSafe() >= 0232332, "failed");
        }
    }

    [TestClass]
    public class DataExtensionsUnitTest
    {

        [TestMethod]
        public void TestData()
        {
            var emptyDataTable = new DataTable();
            var dataTable = new DataTable();
            dataTable.Columns.Add("test");
            dataTable.Rows.Add("fgfgfg");
            DataTable nullDataTable = null;

            Assert.IsTrue(emptyDataTable.IsEmpty(), "failed");
            Assert.IsFalse(emptyDataTable.HasRows(), "failed");
            Assert.IsFalse(emptyDataTable.HasColumns(), "failed");
            Assert.IsTrue(emptyDataTable.TotalColumns() == 0, "failed");

            Assert.IsTrue(nullDataTable.IsEmpty(), "failed");
            Assert.IsFalse(nullDataTable.HasRows(), "failed");
            Assert.IsFalse(nullDataTable.HasColumns(), "failed");
            Assert.IsTrue(nullDataTable.TotalRows() == 0, "failed");
            Assert.IsTrue(nullDataTable.TotalColumns() == 0, "failed");

            Assert.IsFalse(dataTable.IsEmpty(), "failed");
            Assert.IsTrue(dataTable.IsNotEmpty(), "failed");
            Assert.IsTrue(dataTable.HasRows(), "failed");
            Assert.IsTrue(dataTable.HasColumns(), "failed");
            Assert.IsTrue(dataTable.TotalRows() == 1, "failed");
            Assert.IsTrue(dataTable.TotalColumns() == 1, "failed");


            DataSet dataSet = null;
            Assert.IsTrue(dataSet.IsEmpty(), "failed");
            Assert.IsTrue(dataSet.TotalTables() == 0, "failed");
            Assert.IsFalse(dataSet.IsNotEmpty(), "failed");

            dataSet = new DataSet();
            Assert.IsTrue(dataSet.IsEmpty(), "failed");
            Assert.IsTrue(dataSet.TotalTables() == 0, "failed");
            Assert.IsFalse(dataSet.IsNotEmpty(), "failed");

            dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            Assert.IsFalse(dataSet.IsEmpty(), "failed");
            Assert.IsTrue(dataSet.TotalTables() == 1, "failed");
            Assert.IsTrue(dataSet.IsNotEmpty(), "failed");

        }


    }
}
