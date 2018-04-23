using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Spreadsheet;
using DevExpress.Web;
using DevExpress.Web.Office;


using Sample;

public partial class Default : System.Web.UI.Page {

    protected void Page_Load(object sender, EventArgs e) {
        if (!Page.IsPostBack) {
            string currentUserID = GenerateUniqueId();
            var user = Users.Register(currentUserID);

            var templatePath = Server.MapPath("~/App_Data/WorkDirectory/CellValueChangedSample.xlsx");
            var documentId = GenerateUniqueId();
            user.DocumentIDs.Add(documentId);
            spreadsheet.Open(documentId, DocumentFormat.Xlsx, () => System.IO.File.ReadAllBytes(templatePath));
        }
    }

    private static string GenerateUniqueId() {
        return Guid.NewGuid().ToString();
    }

}