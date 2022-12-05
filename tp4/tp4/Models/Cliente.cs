using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cliente: Persona
{
    string DatosReferenciaDireccion;
    public Cliente(int id, string nombre, string direccion, long telefono, string datosDomicilio):base(id, nombre, direccion, telefono)
    {
        this.DatosReferenciaDireccion = datosDomicilio;
    }
}

