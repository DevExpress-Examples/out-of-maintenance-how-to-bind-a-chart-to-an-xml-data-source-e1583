Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
' ...

Namespace BindChartToXML
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a DataSet instance and, make it read the xml file.
			Dim ds As New DataSet()
			ds.ReadXml("..\..\Departments.xml")

			' Specify the dataset as the chart's data source.
			chartControl1.DataSource = ds
			' Specify the argument and value data members for the series. 
			chartControl1.Series(0).ArgumentDataMember = "Table.Department"
			chartControl1.Series(0).ValueDataMembers.AddRange(New String() { "Table.Budget" })
			' Define an appropriate scale type for the series points' values.
			chartControl1.Series(0).ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
		End Sub

	End Class
End Namespace

