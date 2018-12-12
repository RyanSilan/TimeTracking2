﻿using System;
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
        public Dashboard()
        {
            InitializeComponent();

            //Connection con = new Connection();
            //SqlConnection sql = con.getConnection();

            //string query = "SELECT * FROM dbo.Calls"; 

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sql);
            //SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            //DataSet ds = new DataSet(); 

            //sqlDataAdapter.Fill(ds);

            //dataGridView1.ReadOnly = true;
            //dataGridView1.DataSource = ds.Tables[0];

            //var series = new Series("Calls");
            //series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            //series.Points.DataBindXY(new[] { "Monday", "Tuesday", "Wednesday" }, new[] { 150, 125, 175 });
            //chart1.Series.Add(series);

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new LiveCharts.SeriesCollection
            {
                new PieSeries
                {
                    Title = "Maria",
                    Values = new ChartValues<double> {3},
                    //PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Charles",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frida",
                    Values = new ChartValues<double> {6},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Frederic",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;

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