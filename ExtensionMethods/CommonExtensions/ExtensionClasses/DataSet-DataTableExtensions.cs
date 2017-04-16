using System.Data;

namespace Common.Data.Extensions
{
    public static class DataTableExtensions
    {
        public static bool HasRows(this DataTable dataTable) => dataTable != null && dataTable.Rows.Count > 0;

        public static bool HasColumns(this DataTable dataTable) => dataTable != null && dataTable.Columns.Count > 0;

        public static bool IsEmpty(this DataTable dataTable) => dataTable == null || dataTable.Rows.Count == 0;

        public static bool IsNotEmpty(this DataTable dataTable) => dataTable != null && dataTable.Rows.Count > 0;

        public static long TotalRows(this DataTable dataTable) => dataTable == null ? 0 : dataTable.Rows.Count;

        public static long TotalColumns(this DataTable dataTable) => dataTable == null ? 0 : dataTable.Columns.Count;   
    }

    public static class DataSetExtensions
    {
        public static bool IsEmpty(this DataSet dataSet) => dataSet == null || dataSet.Tables.Count == 0;

        public static bool IsNotEmpty(this DataSet dataSet) => dataSet != null && dataSet.Tables.Count > 0;

        public static long TotalTables(this DataSet dataSet) => dataSet == null ? 0 : dataSet.Tables.Count;
    }
}
