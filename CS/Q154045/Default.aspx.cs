using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxPivotGrid;
using System.Drawing;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ASPxPivotGrid1.CellTemplate = new CellTemplate();      
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
