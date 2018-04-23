Imports Microsoft.VisualBasic
Imports System
Namespace Report_SortBySum
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xrGroupSortingSummary1 As New DevExpress.XtraReports.UI.XRGroupSortingSummary()
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.nwindDataSet1 = New Report_SortBySum.nwindDataSet()
			Me.productsTableAdapter = New Report_SortBySum.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
			Me.Detail.HeightF = 23F
			Me.Detail.MultiColumn.ColumnCount = 3
			Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
			Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(92))))), (CInt(Fix((CByte(92))))), (CInt(Fix((CByte(92))))))
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(9.999998F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(215.625F, 23F)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.StylePriority.UseForeColor = False
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "xrLabel2"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 49F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 47.91667F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrLabel3})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.HeightF = 33.00001F
			Me.GroupHeader1.Name = "GroupHeader1"
			xrGroupSortingSummary1.Enabled = True
			xrGroupSortingSummary1.FieldName = "UnitsOnOrder"
			xrGroupSortingSummary1.Function = DevExpress.XtraReports.UI.SortingSummaryFunction.Custom
			xrGroupSortingSummary1.IgnoreNullValues = True
			xrGroupSortingSummary1.SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.Descending
			Me.GroupHeader1.SortingSummary = xrGroupSortingSummary1
'			Me.GroupHeader1.SortingSummaryGetResult += New DevExpress.XtraReports.UI.GroupSortingSummaryGetResultEventHandler(Me.GroupHeader1_SortingSummaryGetResult);
'			Me.GroupHeader1.SortingSummaryReset += New System.EventHandler(Me.GroupHeader1_SortingSummaryReset);
'			Me.GroupHeader1.SortingSummaryRowChanged += New DevExpress.XtraReports.UI.GroupSortingSummaryRowChangedEventHandler(Me.GroupHeader1_SortingSummaryRowChanged);
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(192))))))
			Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrLabel1.ForeColor = System.Drawing.Color.White
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(112.5F, 23F)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseForeColor = False
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "Category ID: [CategoryID]"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitsOnOrder")})
			Me.xrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(192))))))
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(122.5F, 10.00001F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(198.9583F, 23F)
			Me.xrLabel3.StylePriority.UseBackColor = False
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.StylePriority.UseForeColor = False
			Me.xrLabel3.StylePriority.UseTextAlignment = False
			xrSummary1.FormatString = "Packs in the Group: {0}"
			xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
			Me.xrLabel3.Summary = xrSummary1
			Me.xrLabel3.Text = "xrLabel3"
			Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
'			Me.xrLabel3.SummaryGetResult += New DevExpress.XtraReports.UI.SummaryGetResultHandler(Me.xrLabel3_SummaryGetResult);
'			Me.xrLabel3.SummaryReset += New System.EventHandler(Me.xrLabel3_SummaryReset);
'			Me.xrLabel3.SummaryRowChanged += New System.EventHandler(Me.xrLabel3_SummaryRowChanged);
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.nwindDataSet1
			Me.Margins = New System.Drawing.Printing.Margins(48, 100, 49, 48)
			Me.Version = "10.2"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private nwindDataSet1 As nwindDataSet
		Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
		Private WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
