using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pedido
{
    static int autoNum = 0;
    int Numero;
    string Observaciones;
    Cliente Cliente;
    bool Estado; //true entregado, false no entregado

    public Pedido(int IDCliente, string nombreCliente, string direccionCliente, long telefonoCliente, string datosReferenciaDireccionCliente, string observaciones, bool estado)
    {
        this.Numero = autoNum;
        autoNum++;
        this.Observaciones = observaciones;
        Cliente = new Cliente(IDCliente, nombreCliente, direccionCliente, telefonoCliente, datosReferenciaDireccionCliente);
        this.Estado = estado;
    }

    public void cambiarEstadoPedido(bool estado)
    {
        this.Estado = estado;
    }

    public bool getEstado()
    {
        return (this.Estado);
    }

    public int getNumero()
    {
        return (this.Numero);
    }


}

