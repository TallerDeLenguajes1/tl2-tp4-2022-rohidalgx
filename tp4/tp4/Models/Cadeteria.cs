
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cadeteria
{
    string Nombre;
    long Telefono;
    List<Cadete> cadetes;

    public Cadeteria(string nombre, long telefono, List<Cadete> cadetes)
    {
        Nombre = nombre;
        Telefono = telefono;
        this.cadetes = cadetes;
    }

    public Pedido altaPedido(int IDCliente, string nombreCliente, string direccionCliente, long telefonoCliente, string datosReferenciaDireccionCliente, string observaciones, bool estado)
    {
        Pedido pedido = new Pedido(IDCliente, nombreCliente, direccionCliente, telefonoCliente, datosReferenciaDireccionCliente, observaciones, estado);
        return (pedido);
    }

    public void asignarPedido(int IDCadete, Pedido pedido)
    {
        Cadete cadete = this.cadetes.Find(cadete => cadete.getID() == IDCadete);
        cadete.asignarPedido(pedido);
    }

    public void reasignarPedido(Cadete cadete1, Cadete cadete2, int nroPedido)
    {

        Pedido? reasignar = cadete1.quitarPedido(nroPedido);

        if (reasignar != null)
        {
            cadete2.asignarPedido(reasignar);
            Console.WriteLine("Se reasigno el pedido");

        }

    }

    public void mostrarInforme()
    {
        
        float montoTotal = 0;
        int cantTotal = 0;

        for(int i = 0; i<cadetes.Count(); i++)
        {
            montoTotal += cadetes[i].jornal_a_cobrar();
            Console.WriteLine("Cadete " + i + "Cobra" + cadetes[i].jornal_a_cobrar());
            cantTotal += cadetes[i].cantPedidos();
            Console.WriteLine("Cadete " + i + "Realizo" + cadetes[i].cantPedidos() + "pedidos");

        }

        Console.WriteLine("Monto Total:" + montoTotal);
        Console.WriteLine("Envios promedio por cadete:" + cantTotal / cadetes.Count());

    }


}

