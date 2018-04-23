using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxPivotGrid;
using System.Drawing;
using DevExpress.Web.ASPxGridView;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ASPxPivotGrid1.CellTemplate = new CellTemplate();
        string columnIndex = Page.Request["ColumnIndex"];
        string rowIndex = Page.Request["RowIndex"];
        if (!(string.IsNullOrEmpty(columnIndex) || string.IsNullOrEmpty(rowIndex))) {
            ASPxGridView1.DataSource = 
                ASPxPivotGrid1.CreateDrillDownDataSource(int.Parse(columnIndex), int.Parse(rowIndex));
            ASPxGridView1.DataBind();
        }
    }

    protected void OnASPxGridViewCustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e) {
        string[] param = e.Parameters.Split('|');
        if (param.Length != 3) return;
        ASPxGridView1.DataSource =
            ASPxPivotGrid1.CreateDrillDownDataSource(int.Parse(param[1]), int.Parse(param[2]));
        ASPxGridView1.DataBind();
        ASPxGridView1.PageIndex = 0;
    }
}

public class CellTemplate :ITemplate {
    #region ITemplate Members

    public void InstantiateIn(Control container) {
        PivotGridCellTemplateContainer cellContainer = (PivotGridCellTemplateContainer)container;
        Label label = new Label();
        label.Attributes.Add("onclick", "OnCellClick(this)");
        label.Text = cellContainer.Text;
        cellContainer.Controls.Add(label);
    }

    #endregion
}
