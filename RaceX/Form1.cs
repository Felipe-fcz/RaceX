using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceX
{
    public partial class Form1: Form
    {
        private Carrera carrera;

        Dictionary<string, ProgressBar> barrasProgreso = new Dictionary<string, ProgressBar>();

        public Form1()
        {
            InitializeComponent();
            carrera = new Carrera();

            cbTipo.Items.AddRange(new string[] { "Deportivo", "Todoterreno", "Híbrido" });
            cbClima.Items.AddRange(new string[] { "Soleado", "Lluvia", "Ventoso" });

            btnTurno.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbClima.SelectedIndex == -1)
                {
                    MessageBox.Show("Debes seleccionar el clima antes de registrar autos.", "Clima no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombre.Text.Trim();
                string tipo = cbTipo.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo))
                {
                    MessageBox.Show("Debe ingresar un nombre y seleccionar tipo.");
                    return;
                }

                var auto = AutoFactory.CrearAuto(tipo, nombre);
                carrera.AgregarAuto(auto);

                lstAutos.Items.Add($"{auto.Nombre} ({auto.Tipo}) - 0m");
                ProgressBar barra = new ProgressBar();
                barra.Width = panelCarril.Width - 40;
                barra.Height = 25;
                barra.Minimum = 0;
                barra.Maximum = 150;
                barra.Value = 0;

                Label lblNombre = new Label();
                lblNombre.Text = nombre;
                lblNombre.Width = barra.Width;
                lblNombre.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                Panel carril = new Panel();
                carril.Height = 50;
                carril.Width = panelCarril.Width - 20;
                carril.Controls.Add(lblNombre);
                carril.Controls.Add(barra);
                lblNombre.Location = new Point(0, 0);
                barra.Location = new Point(0, 20);

                int yOffset = panelCarril.Controls.Count * 55;
                carril.Location = new Point(0, yOffset);
                panelCarril.Controls.Add(carril);
                barrasProgreso[nombre] = barra;

                txtNombre.Clear();
                cbTipo.SelectedIndex = -1;

                cbClima.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string clima = cbClima.SelectedItem?.ToString();
                carrera.SeleccionarClima(clima);
                carrera.IniciarCarrera();

                cbTipo.Enabled = false;
                cbClima.Enabled = false;
                txtNombre.Enabled = false;
                btnAgregar.Enabled = false;
                btnIniciar.Enabled = false;
                btnReiniciar.Enabled = true;

                btnTurno.Enabled = true;

                lblMensaje.Text = $" Clima seleccionado: {clima}";
                lblClima.Text = $"Clima actual: {clima}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = carrera.EjecutarTurno();
                ActualizarLista();

                var ganador = carrera.ObtenerGanador();
                if (ganador != null)
                {
                    lblGanador.Text = $"🏁 ¡Ganador: {ganador.Nombre}!";
                    btnTurno.Enabled = false;
                }

                lblMensaje.Text = mensaje;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarLista()
        {
            lstAutos.Items.Clear();
            foreach (var auto in carrera.Autos)
            {
                lstAutos.Items.Add($"{auto.Nombre} ({auto.Tipo}) - {auto.DistanciaRecorrida}m");
                if (barrasProgreso.ContainsKey(auto.Nombre))
                {
                    barrasProgreso[auto.Nombre].Value = Math.Min(auto.DistanciaRecorrida, 150);
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            carrera.Reiniciar();

            lstAutos.Items.Clear();
            txtNombre.Clear();
            cbTipo.SelectedIndex = -1;
            cbClima.SelectedIndex = -1;
            lblGanador.Text = "";
            lblMensaje.Text = "Carrera reiniciada.";
            lblClima.Text = "Clima: -";

            
            cbTipo.Enabled = true;
            cbClima.Enabled = true;
            txtNombre.Enabled = true;
            btnAgregar.Enabled = true;
            btnIniciar.Enabled = true;
            btnTurno.Enabled = false;
            btnReiniciar.Enabled = false;
            panelCarril.Controls.Clear();
            barrasProgreso.Clear();
        }
    }
}
    

