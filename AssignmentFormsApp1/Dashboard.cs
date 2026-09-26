using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace AssignmentFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            // ===== Chart 2: Pie (circle) chart =====
            chart2.Series.Clear();

            Series pie = new Series("Drinks");
            pie.ChartType = SeriesChartType.Pie;

            pie.Points.AddXY("Coffee", 35);
            pie.Points.AddXY("Tea", 20);
            pie.Points.AddXY("Juice", 20);
            pie.Points.AddXY("Water", 10);
            pie.Points.AddXY("Pasty", 15);

            // INSIDE slice: only percentage (no .00)
            pie.Label = "#PERCENT{P0}";
            pie["PieLabelStyle"] = "Inside";
            pie.LabelForeColor = Color.White;
            pie.Font = new Font("Segoe UI", 8, FontStyle.Bold);

            // OUTSIDE (legend): name + percentage
            pie.LegendText = "#VALX (#PERCENT{P0})";

            chart2.Series.Add(pie);

            // legend settings
            chart2.Legends[0].Enabled = true;
            chart2.Legends[0].Docking = Docking.Right;
            chart2.Legends[0].Font = new Font("Segoe UI", 8);

            // give the pie more room
            chart2.ChartAreas[0].Position.Auto = false;
            chart2.ChartAreas[0].Position = new ElementPosition(0, 0, 65, 100);

            // draw right away
            chart2.Invalidate();
        }

        private void label49_Click(object sender, EventArgs e)
        {
          

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }
        //ការតlinkទៅmenu
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Order().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inventory().Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
           
        }

        private void chart2_Click(object sender, EventArgs e)
        {
           
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

            chart1.Series.Clear();

            Series s = new Series("Sales");
            s.ChartType = SeriesChartType.Column;   // try Line, Pie, Bar too

            s.Points.AddXY("Mon", 20);
            s.Points.AddXY("Tue", 35);
            s.Points.AddXY("Wed", 15);
            s.Points.AddXY("Thu", 40);
            s.Points.AddXY("Fri", 28);


            chart1.Series.Add(s);
        }
    }
}
