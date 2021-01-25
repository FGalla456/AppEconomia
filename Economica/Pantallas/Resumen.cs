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
        public struct Datos 
        {
            public int idCat;
            public string Nombre;
            public float Total;
        }

        N_Ingreso ing = new N_Ingreso();
        DataTable dt = new DataTable();
        N_Categoria cat = new N_Categoria();
        public Resumen()
        {
            InitializeComponent();
            SeriesCollection Serie = new SeriesCollection();
            Serie = LlenarGrafico();
            GraficoIngresos.Series = Serie;
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
        }

        public SeriesCollection LlenarGrafico()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection Serie = new SeriesCollection();
            List<Datos> Dat = new List<Datos>();
            Dat = LlenarLista();
            foreach (Datos row in Dat)
            {
                PieSeries Dato = new PieSeries();
                Dato.Title = Convert.ToString(row.Nombre);
                Dato.Values = new ChartValues<float> { row.Total };
                Dato.DataLabels = true;
                Dato.LabelPoint = labelPoint;
                Serie.Add(Dato);
            }
            return Serie;
        }

        public List<Datos> LlenarLista()
        {
            List<Datos> Dato = new List<Datos>();
            dt = cat.getTablaCatFiltrada(1);
            foreach (DataRow row in dt.Rows)
            {
                Datos da = new Datos();
                da.idCat = Convert.ToInt32(row[0]);
                da.Nombre = Convert.ToString(row[2]);
                da.Total = 0;
                Dato.Add(da);
            }
            dt = ing.getTablaResumen();
            foreach (DataRow row in dt.Rows)
            {
                for(int i=0; i<=Dato.Count-1; i++) 
                {
                    if(Convert.ToInt32(row[0]) == Dato[i].idCat) 
                    {
                        Datos da = new Datos();
                        da = Dato[i];
                        da.Total += float.Parse(row[2].ToString());
                        Dato[i] = da;
                    }
                }
            }

            return Dato;
        }

    }
}
