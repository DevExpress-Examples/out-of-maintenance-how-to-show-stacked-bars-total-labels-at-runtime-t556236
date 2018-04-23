Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms

Namespace StackedBarTotalLabelSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
'            #Region "#StackedBarTotalLabel"
            Dim totalLabel As StackedBarTotalLabel = CType(cartesianChart.Diagram, XYDiagram).DefaultPane.StackedBarTotalLabel
            totalLabel.Visible = True
            totalLabel.ShowConnector = True
            totalLabel.TextPattern = "Total:" & vbLf & "{TV:F2}"
'            #End Region ' #StackedBarTotalLabel
        End Sub
    End Class
End Namespace
