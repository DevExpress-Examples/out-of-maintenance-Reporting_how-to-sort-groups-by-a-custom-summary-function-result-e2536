Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
' ...

Namespace Report_SortBySum
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private totalUnits As Double = 0
		Private pack As Double = 15

		' To calculate a custom summary function, for sorting groups against its result,
		' handle the following events of the GroupHeader band.
		Private Sub GroupHeader1_SortingSummaryReset(ByVal sender As Object, ByVal e As EventArgs) Handles GroupHeader1.SortingSummaryReset
			' Reset the result each time a group is printed.
			totalUnits = 0
		End Sub

		Private Sub GroupHeader1_SortingSummaryRowChanged(ByVal sender As Object, ByVal e As GroupSortingSummaryRowChangedEventArgs) Handles GroupHeader1.SortingSummaryRowChanged
			' Calculate a summary.
			totalUnits += Convert.ToDouble(e.FieldValue)
		End Sub

		Private Sub GroupHeader1_SortingSummaryGetResult(ByVal sender As Object, ByVal e As GroupSortingSummaryGetResultEventArgs) Handles GroupHeader1.SortingSummaryGetResult
			' Round the result, so that a pack will be taken into account
			' even if it contains only one unit.
			e.Result = Math.Ceiling(totalUnits / pack)
			e.Handled = True
		End Sub

		' To display the summary function's result in the report,
		' handle the similar summary events of the XRLabel instance.
		Private Sub xrLabel3_SummaryReset(ByVal sender As Object, ByVal e As EventArgs) Handles xrLabel3.SummaryReset
			totalUnits = 0
		End Sub

		Private Sub xrLabel3_SummaryRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles xrLabel3.SummaryRowChanged
			totalUnits += Convert.ToDouble(GetCurrentColumnValue("UnitsOnOrder"))
		End Sub

		Private Sub xrLabel3_SummaryGetResult(ByVal sender As Object, ByVal e As SummaryGetResultEventArgs) Handles xrLabel3.SummaryGetResult
			e.Result = Math.Ceiling(totalUnits / pack)
			e.Handled = True
		End Sub

	End Class
End Namespace
