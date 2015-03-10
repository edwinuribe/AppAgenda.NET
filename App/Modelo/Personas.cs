using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Personas
    {
        #region "Atributos"
        private string id;
        private string nombres;
        private string apellidos;
        private string emailP;
        private string emailW;
        private string telefonoP;
        private string telefonoW;
        #endregion

        #region "Propiedades"
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string EmailP
        {
            get { return emailP; }
            set { emailP = value; }
        }
        public string EmailW
        {
            get { return emailW; }
            set { emailW = value; }
        }
        public string TelefonoP
        {
            get { return telefonoP; }
            set { telefonoP = value; }
        }
        public string TelefonoW
        {
            get { return telefonoW; }
            set { telefonoW = value; }
        }

        #endregion

        #region "Constructores"
        public Personas()
        {
            this.id = "XXXXXX";
            this.nombres = "Nombres";
            this.apellidos = "Apellidos";
            this.emailP = "eamilpersonal@dominio.com";
            this.emailW = "eamilwork@dominio.com";
            this.telefonoP = "3001234567";
            this.telefonoW = "6535234";
        }


        public Personas(string id, string nombres, string apellidos, string emailP, string emailW, string telefonoP, string telefonoW)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.emailP = emailP;
            this.emailW = emailW;
            this.telefonoP = telefonoP;
            this.telefonoW = telefonoW;
        }
        #endregion

        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return "\n_______________________________________" +
                    "\nIdentificacion: " + this.id +
                    "\nNombres: " + this.nombres +
                    "\nApellidos: " + this.apellidos +
                    "\nEmail P: " + this.emailP +
                    "\nEmail W: " + this.emailW +
                    "\nTelefono P: " + this.telefonoP +
                    "\nTelefono W: " + this.telefonoW +
                    "\n_______________________________________";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Personas o = (Personas )obj;
            bool result = false;

            if ((this.id == o.id) &&
                (this.nombres == o.nombres) &&
                (this.apellidos == o.apellidos) &&
                (this.emailP == o.emailP) &&
                (this.emailW == o.emailW) &&
                (this.telefonoP == o.telefonoP) &&
                (this.telefonoW == o.telefonoW))

                result = true;

            return result;
        }

        #endregion
    }
}