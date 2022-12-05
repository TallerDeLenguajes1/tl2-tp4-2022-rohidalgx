using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

public class Cadete: Persona
{
    List<Pedido> pedidos;

    public Cadete(int id, string nombre, string direccion, long telefono):base(id, nombre, direccion, telefono)
    {
        this.pedidos = new List<Pedido>();
    }

    public Cadete():base()
    {
        this.pedidos = new List<Pedido>();
    }

    public float jornal_a_cobrar()
    {
        float jornal = 0;
        int cant = 0;
        for(int i = 0; i < this.pedidos.Count; i++)
        {
            if (pedidos[i].getEstado() == true)
            {
                cant++;
            }
        }
        jornal = cant * 300;
        return (jornal);
    }


    public void asignarPedido(Pedido pedido)
    {
        this.pedidos.Add(pedido);
    }

    public int cantPedidos()
    {
        return (pedidos.Count());
    }

    public Pedido? quitarPedido(int nroPedido)
    {

        Pedido? buscado = this.pedidos.Find(pedido => pedido.getNumero() == nroPedido);

        if (buscado != null && buscado.getEstado() != true)
        {
            // No elimino un pedido que ya esté realizado.
            this.pedidos.Remove(buscado);
        }
        else
        {

            Console.WriteLine("El pedido buscado no existe o no está asignado a este cadete o ya se realizo.");

        }

        return buscado;
    }


}

