Namespace StackedBarTotalLabelSample
    Partial Public Class Form1
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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("United Kingdom", New Object() { (CObj(5.8R))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("Germany", New Object() { (CObj(5.3R))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("Mexico", New Object() { (CObj(17.2R))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("Japan", New Object() { (CObj(8.5R))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() { (CObj(12.4R))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() { (CObj(23.9R))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("United States", New Object() { (CObj(31.2R))})
            Dim stackedBarSeriesView1 As New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("United Kingdom", New Object() { (CObj(21.1R))})
            Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("Germany", New Object() { (CObj(26.6R))})
            Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("Mexico", New Object() { (CObj(39.4R))})
            Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("Japan", New Object() { (CObj(37.9R))})
            Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() { (CObj(47.3R))})
            Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() { (CObj(70.5R))})
            Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("United States", New Object() { (CObj(106.6R))})
            Dim stackedBarSeriesView2 As New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim series3 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("United Kingdom", New Object() { (CObj(5.2R))})
            Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("Germany", New Object() { (CObj(7.7R))})
            Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint("Mexico", New Object() { (CObj(3.8R))})
            Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint("Japan", New Object() { (CObj(15.1R))})
            Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() { (CObj(6.2R))})
            Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() { (CObj(7.1R))})
            Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint("United States", New Object() { (CObj(21.9R))})
            Dim stackedBarSeriesView3 As New DevExpress.XtraCharts.StackedBarSeriesView()
            Me.cartesianChart = New DevExpress.XtraCharts.ChartControl()
            CType(Me.cartesianChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(stackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(stackedBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(stackedBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' cartesianChart
            ' 
            Me.cartesianChart.DataBindings = Nothing
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.Rotated = True
            Me.cartesianChart.Diagram = xyDiagram1
            Me.cartesianChart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cartesianChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.cartesianChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom
            Me.cartesianChart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.cartesianChart.Legend.Name = "Default Legend"
            Me.cartesianChart.Location = New System.Drawing.Point(0, 0)
            Me.cartesianChart.Name = "cartesianChart"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.Name = "0-14 years"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7})
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
            series1.View = stackedBarSeriesView1
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            series2.Name = "15-64 years"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14})
            series2.View = stackedBarSeriesView2
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            series3.Name = "65+ years"
            series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21})
            series3.View = stackedBarSeriesView3
            Me.cartesianChart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
            Me.cartesianChart.Size = New System.Drawing.Size(1264, 681)
            Me.cartesianChart.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 681)
            Me.Controls.Add(Me.cartesianChart)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(stackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(stackedBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(stackedBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cartesianChart, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private cartesianChart As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

