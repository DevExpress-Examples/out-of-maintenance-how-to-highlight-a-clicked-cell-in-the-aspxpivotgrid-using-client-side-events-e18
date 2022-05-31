<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v21.2, Version=21.2.7.0, Culture=neutral, PublicKeyToken=B88D1754D700E49A" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dxwpg" %>
<%@ Register assembly="DevExpress.Web.v21.2, Version=21.2.7.0, Culture=neutral, PublicKeyToken=B88D1754D700E49A" namespace="DevExpress.Web" tagprefix="dxpc" %>
<%@ Register assembly="DevExpress.Web.v21.2, Version=21.2.7.0, Culture=neutral, PublicKeyToken=B88D1754D700E49A" namespace="DevExpress.Web" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.v21.2, Version=21.2.7.0, Culture=neutral, PublicKeyToken=B88D1754D700E49A" namespace="DevExpress.Web" tagprefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<script type="text/javascript">
		var selectedControl;
		function OnCellClick(control) {
			if (selectedControl != null)
				selectedControl.style.backgroundColor = 'transparent';
			selectedControl = control;
			selectedControl.style.backgroundColor = 'gold';
		}
	</script>
</head>
<body>
	<form id="form1" runat="server">
	<div>

        <dxwpg:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" 
            DataSourceID="SqlDataSource1" ClientInstanceName="pivot">
            <Fields>
                <dxwpg:PivotGridField ID="fieldSalesPerson" Area="RowArea" AreaIndex="0" 
                    FieldName="Sales_Person">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldExtendedPrice" Area="DataArea" AreaIndex="0" 
                    FieldName="Extended_Price">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldCategoryName" Area="ColumnArea" AreaIndex="0" 
                    FieldName="CategoryName">
                </dxwpg:PivotGridField>
            </Fields>
            <ClientSideEvents CellClick="function(s, e) {
	grid.PerformCallback(&quot;D|&quot; + e.ColumnIndex + &quot;|&quot; + e.RowIndex);
	var table = pivot.GetMainTable();
	popup.ShowAtPos(_aspxGetAbsoluteX(table), _aspxGetAbsoluteY(table));
		var columnIndex = document.getElementById('ColumnIndex'),
		rowIndex = document.getElementById('RowIndex');
	if(!_aspxIsExists(columnIndex)) {
		columnIndex = document.createElement(&quot;input&quot;);
		rowIndex = document.createElement(&quot;input&quot;);
		
		columnIndex.type = &quot;hidden&quot;;
		columnIndex.id = &quot;ColumnIndex&quot;;
		columnIndex.name = &quot;ColumnIndex&quot;;		
		rowIndex.type = &quot;hidden&quot;;
		rowIndex.id = &quot;RowIndex&quot;;
		rowIndex.name = &quot;RowIndex&quot;;		
		
		grid.GetRootTable().appendChild(columnIndex);
		grid.GetRootTable().appendChild(rowIndex);
	}	
	columnIndex.value = e.ColumnIndex;
	rowIndex.value = e.RowIndex;
}" />
        </dxwpg:ASPxPivotGrid>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
            SelectCommand="SELECT [Sales Person] AS Sales_Person, [Extended Price] AS Extended_Price, [CategoryName] FROM [SalesPerson]"/>
	</div>
	</form>
</body>
</html>