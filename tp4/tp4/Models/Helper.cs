using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Helper
{
    public List<Cadete> LeerCSVYCrearListaDeCadetes(string NombreDelArchivo)
    {
        string unaLinea;
        List<Cadete> ListaDeCadetes = new();
        using (var FS = new FileStream("C:\\TallerII_Repo\\tl2-tp3-2022-rohidalgx\\tp3\\tp3/" + NombreDelArchivo, FileMode.Open))
        {
            using (var SR = new StreamReader(FS))
            {
                //string line = SR.ReadLine();
                while ((unaLinea = SR.ReadLine()) != null)
                {
                    var unArray = unaLinea.Split(";");

                    Cadete unCadete = new(Convert.ToInt32(unArray[0]), unArray[1], unArray[2], Convert.ToInt64(unArray[3]));
                    ListaDeCadetes.Add(unCadete);

                }
            }
        }
        return (ListaDeCadetes);
    }
}

