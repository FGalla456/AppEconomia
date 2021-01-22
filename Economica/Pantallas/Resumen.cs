using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using Negocio;

namespace Economica.Pantallas
{
    public partial class Resumen : Form
    {
        N_Ingreso ing = new N_Ingreso();
        DataTable dt = new DataTable();
        public Resumen()
        {
            InitializeComponent();
            SeriesCollection Serie = new SeriesCollection();
            Serie = LlenarGrafico();
            GraficoIngresos.Series = Serie;
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
            Grilla.DataSource = ing.getTablaResumen();
        }

        public SeriesCollection LlenarGrafico()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection Serie = new SeriesCollection();
            dt = ing.getTablaResumen();
            foreach (DataRow row in dt.Rows)
            {
                PieSeries Dato = new PieSeries();
                Dato.Title = Convert.ToString(row[1]);
                Dato.Values = new ChartValues<float> { float.Parse(row[2].ToString()) };
                Dato.DataLabels = true;
                Dato.LabelPoint = labelPoint;
                Serie.Add(Dato);
            }
            return Serie;
        }
    }
}
