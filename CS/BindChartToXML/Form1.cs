using System;
using System.Data;
using System.Windows.Forms;
// ...

namespace BindChartToXML {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a DataSet instance and, make it read the xml file.
            DataSet ds = new DataSet();
            ds.ReadXml(@"..\..\Departments.xml");

            // Specify the dataset as the chart's data source.
            chartControl1.DataSource = ds;
            // Specify the argument and value data members for the series. 
            chartControl1.Series[0].ArgumentDataMember = "Table.Department";
            chartControl1.Series[0].ValueDataMembers.AddRange(new string[] { "Table.Budget" });
            // Define an appropriate scale type for the series points' values.
            chartControl1.Series[0].ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
        }

    }
}

