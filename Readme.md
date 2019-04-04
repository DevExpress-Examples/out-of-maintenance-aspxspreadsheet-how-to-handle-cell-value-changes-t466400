<!-- default file list -->
*Files to look at*:

* [Logger.cs](./CS/App_Code/Logger.cs) (VB: [Logger.vb](./VB/App_Code/Logger.vb))
* [SampleData.cs](./CS/App_Code/SampleData.cs) (VB: [SampleData.vb](./VB/App_Code/SampleData.vb))
* [Users.cs](./CS/App_Code/Users.cs) (VB: [Users.vb](./VB/App_Code/Users.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
* **[Global.asax](./CS/Global.asax) (VB: [Global.asax](./VB/Global.asax))**
<!-- default file list end -->
# ASPxSpreadsheet - How to handle cell value changes


<p>Starting with version <strong><em>16.2</em></strong>, ASPxSpreadsheet provides a functionality to handle cell value changes. Use the <strong><em>static </em></strong><a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxSpreadsheetASPxSpreadsheet_CellValueChangedtopic"><strong>ASPxSpreadsheet.CellValueChanged</strong></a> event for this purpose. Please note, this event handles cell value changes at <strong><em>the application level</em></strong> and it is raised for all documents opened within all instances of the ASPxSpreadsheet control. This way, the page hierarchy is not recreated and values of other controls located on the page are not available in this event handler.<br><br>See also: <a href="https://demos.devexpress.com/ASPxSpreadsheetDemos/API/CellValueChanged.aspx">The "Spreadsheet - API - CellValueChanged Event" demo</a></p>

<br/>


