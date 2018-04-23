using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;

namespace StackedBarTotalLabelSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            #region #StackedBarTotalLabel
            StackedBarTotalLabel totalLabel = ((XYDiagram)cartesianChart.Diagram).DefaultPane.StackedBarTotalLabel;
            totalLabel.Visible = true;
            totalLabel.ShowConnector = true;
            totalLabel.TextPattern = "Total:\n{TV:F2}";
            #endregion #StackedBarTotalLabel
        }
    }
}
