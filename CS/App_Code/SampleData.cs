using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Sample {
    public static class SampleData {
        static DataTable data;
        public static DataTable Data {
            get {
                if (data == null)
                    data = GenerateSampleData();
                return data;
            }
        }

        static DataTable GenerateSampleData() {
            data = new DataTable();
            var keyColumn = data.Columns.Add("Id");
            data.Columns.Add("Name");
            data.PrimaryKey = new DataColumn[] { keyColumn };

            data.Rows.Add(new object[] { "10115", "Augusta Delono" });
            data.Rows.Add(new object[] { "10501", "Berry Dafoe" });
            data.Rows.Add(new object[] { "10709", "Chris Cadwell" });
            data.Rows.Add(new object[] { "10356", "Esta Mangold" });
            data.Rows.Add(new object[] { "10401", "Frank Diamond" });
            data.Rows.Add(new object[] { "10202", "Liam Bell" });
            data.Rows.Add(new object[] { "10205", "Simon Newman" });
            data.Rows.Add(new object[] { "10403", "Wendy Underwood" });

            return data;
        }

        public static string Lookup(string key) {
            var row = Data.Rows.Find(key);
            return row != null ? row["Name"].ToString() : "";
        }
    }
}