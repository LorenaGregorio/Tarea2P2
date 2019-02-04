using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsularUDEO.Class
{
    public class Cuenta
    {

        private string nombre;
        private string direccion;
        private string telefono;
        private string tipodecuenta;
        private string banco;
     

  

        public Cuenta(string nombre, string direccion, string telefono, string tipodeCuenta, string banco)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.tipodecuenta = tipodeCuenta;
            this.banco = banco;
        }





        //Nombre 
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
          
        }

        //Direccion 
        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }

        //Telefono 
        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }

        //Tipo de Cuenta 
        public string TipodeCuenta
        {
            get
            {
                return tipodecuenta;
            }
            set
            {
                tipodecuenta = value;
            }
        }

        //Banco 
        public string Banco
        {
            get
            {
                return banco;
            }
            set
            {
                banco = value;
            }

        }

    }
}
