using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Persona
{
    public int ID;
    public string Nombre;
    public string Direccion;
    public long telefono;

    public Persona()
    {

    }
    public Persona(int id, string nombre, string direccion, long telefono)
    {
        this.ID = id;
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.telefono = telefono;
    }

    public int getID()
    {
        return (this.ID);
    }

    public string getNombre()
    {
        return (this.Nombre);
    }

    public string getDireccion()
    {
        return (this.Direccion);
    }

    public long getTelefono()
    {
        return (this.telefono);
    }

}

