Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxPivotGrid
Imports System.Drawing
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPivotGrid1.CellTemplate = New CellTemplate()
		Dim columnIndex As String = Page.Request("ColumnIndex")
		Dim rowIndex As String = Page.Request("RowIndex")
		If Not(String.IsNullOrEmpty(columnIndex) OrElse String.IsNullOrEmpty(rowIndex)) Then
			ASPxGridView1.DataSource = ASPxPivotGrid1.CreateDrillDownDataSource(Integer.Parse(columnIndex), Integer.Parse(rowIndex))
			ASPxGridView1.DataBind()
		End If
	End Sub

	Protected Sub OnASPxGridViewCustomCallback(ByVal sender As Object, ByVal e As ASPxGridViewCustomCallbackEventArgs)
		Dim param() As String = e.Parameters.Split("|"c)
		If param.Length <> 3 Then
			Return
		End If
		ASPxGridView1.DataSource = ASPxPivotGrid1.CreateDrillDownDataSource(Integer.Parse(param(1)), Integer.Parse(param(2)))
		ASPxGridView1.DataBind()
		ASPxGridView1.PageIndex = 0
	End Sub
End Class

Public Class CellTemplate
	Implements ITemplate
	#Region "ITemplate Members"

	Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
		Dim cellContainer As PivotGridCellTemplateContainer = CType(container, PivotGridCellTemplateContainer)
		Dim label As New Label()
		label.Attributes.Add("onclick", "OnCellClick(this)")
		label.Text = cellContainer.Text
		cellContainer.Controls.Add(label)
	End Sub

	#End Region
End Class
