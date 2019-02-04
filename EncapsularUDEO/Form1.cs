using EncapsularUDEO.Class;
using System;
using System.Collections;
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


        }

        //lista creada
        List<Cuenta> listacuenta = new List<Cuenta>();


        private void button1_Click(object sender, EventArgs e)
        {
          
      
        
            //se crea un obejto llamado cuenta1}
            // de la clase Cuenta
            Cuenta cuenta1 = new Cuenta
            (
                 txtnombre.Text,
                 txtdireccion.Text,
                 txttelefono.Text,
                 combotipcuenta.Text,
                 txtbanco.Text
            );
            //a la lista creada arriba,se le agregaran los datos que sean 
            //ingresadosen objeto cuenta1
            listacuenta.Add(cuenta1);

            //se restea el dataGridView1 o la pantalla
            dataGridView1.DataSource = null;
            //se muestra en el dataGridView1 los datos que tenga la lista
            dataGridView1.DataSource = listacuenta;
            //llama al metodo borrar
            borrar();
         
          
        }

        // se creo el metodo borrar
        public void borrar()
        {
            txtbanco.Clear();
            txtdireccion.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
         
            
        }
    }
}
