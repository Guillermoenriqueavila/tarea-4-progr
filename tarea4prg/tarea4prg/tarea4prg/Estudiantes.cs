using System;
using System.Collections.Generic;
using System.Text;

namespace tarea4prg
{
    class Estudiantes
    {
        private int id;
        private String código;
        private String nombre;
        private int edad;
        private String facultad;

        public String Facultad
        {
            get { return facultad; }
            set { facultad = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Código
        {
            get { return código; }
            set { código = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public Estudiantes(int id, String código, string nombre, int edad, String facultad)
        {
            this.id = id;
            this.código = código;
            this.nombre = nombre;
            this.edad = edad;
            this.facultad = facultad;

        }
        public string mostrar()
        {
            return id + " " + código + " " + nombre + " " + facultad;
        }

    }
}
