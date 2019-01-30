using EncapsularUDEO.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsularUDEO
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();

            //instancia == creación de objeto en memoria
            var MiAlumno = new Alumno();


            var cuenta = new Cuenta();
            List<Cuenta> listaCuenta = new List<Cuenta>();
                    listaCuenta.Add(cuenta);
            //creando una fuente de llenado para el dataGridView
            BindingSource bs = new BindingSource();
            bs.DataSource = listaCuenta;
            dataGridView1.DataSource = bs;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Cuenta> listaCuenta = new List<Cuenta>();

            //Agregamos la cuenta la lista
            var cuenta = new Cuenta();

            //llenando los datos para el get y set
            //cuenta.Nombre = txtnombre.Text;
            //cuenta.Direccion = txtdireccion.Text;
            //cuenta.Telefono = txttelefono.Text;
            //cuenta.TipodeCuenta = combotipcuenta.Text;
            //cuenta.Banco = txtbanco.Text;

            listaCuenta.Add(new Cuenta()
            {
                Nombre = txtnombre.Text,
                Direccion = txtdireccion.Text,
                Telefono = txttelefono.Text,
                TipodeCuenta = combotipcuenta.Text,
                Banco = txtbanco.Text
            });



           
            //listaCuenta.Add(cuenta);
         

            //creando una fuente de llenado para el dataGridView
            BindingSource bs = new BindingSource();
            bs.DataSource = listaCuenta;
            dataGridView1.DataSource = bs;
       


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
               
            
        
    }
}
