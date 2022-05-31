Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxPivotGrid
Imports System.Drawing
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPivotGrid1.CellTemplate = New CellTemplate()
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
