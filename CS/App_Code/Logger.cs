using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DevExpress.Spreadsheet;
using DevExpress.Web.Office;

namespace Sample {
    public static class Logger {
        static List<string> Log = new List<string>();
        public static void SaveChangesToLog(object sender, string cellReference, CellValue oldValue, CellValue newValue) {
            SpreadsheetDocumentInfo documentInfo = sender as SpreadsheetDocumentInfo;

            var userId = Users.GetUserByDocument(documentInfo.DocumentId);

            Log.Add(string.Format("User {0} changed document {1} cell {2} from {3} to {4}",
                userId,
                documentInfo.DocumentId,
                cellReference,
                oldValue,
                newValue
                ));
        }
    }
}