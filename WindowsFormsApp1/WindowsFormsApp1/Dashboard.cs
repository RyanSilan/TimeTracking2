using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.SQL;
using System.Data.SqlClient;
//using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts;
using LiveCharts.Wpf;

namespace WindowsFormsApp1
{
    public partial class Dashboard : UserControl
    {
        Dictionary<string, string> pieChartData = new Dictionary<string, string>();
        Dictionary<string, string> barChartData = new Dictionary<string, string>(); 


        public Dashboard()
        {
            InitializeComponent();

            Connection con = new Connection();
            SqlConnection sql = con.getConnection();

            string query = "SELECT top 100 * FROM dbo.Calls"; 

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sql);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataSet ds = new DataSet(); 

            sqlDataAdapter.Fill(ds);

            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            query = "select agents.Name, COUNT(*) from dbo.calls INNER JOIN dbo.agents ON calls.ID = agents.ID where calls.ID != '' group by agents.Name";

            SqlCommand cmd = new SqlCommand(query, sql);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                    pieChartData.Add(reader[0].ToString(), reader[1].ToString()); 
                }

            }

            query = "select date, COUNT(*) from dbo.calls where calls.date >= DATEADD(day,-7, GETDATE()) GROUP BY date";

            cmd = new SqlCommand(query, sql);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                    barChartData.Add(reader[0].ToString(), reader[1].ToString());
                }

            }

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new LiveCharts.SeriesCollection(); 

            

            foreach (KeyValuePair<string, string> entry in pieChartData)
            {
                var temp = new PieSeries
                {
                    Title = entry.Key,
                    Values = new ChartValues<double> { Convert.ToDouble(entry.Value) },
                    DataLabels = true,
                    LabelPoint = labelPoint
                };
                pieChart1.Series.Add(temp); 
            }

            pieChart1.LegendLocation = LegendLocation.Bottom;

            
            // could potentially use for chart

            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "2015",
                    Values = new ChartValues<double> { 10, 50, 39, 50 }
                }
            };

            //adding series will update and animate the chart automatically
            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "2016",
                Values = new ChartValues<double> { 11, 56, 42 }
            });

            //also adding values updates and animates the chart automatically
            cartesianChart1.Series[1].Values.Add(48d);

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Sales Man",
                Labels = new[] { "Maria", "Susan", "Charles", "Frida" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Sold Apps",
                LabelFormatter = value => value.ToString("N")
            });



        }
    }
}
