using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba_studio_F
{
    class listar
    {
        List<int> lstnum1 = new List<int>();

        public void guardar(int a)
        {
            lstnum1.Add(a);
        }

        public bool buscar(int a)
        {
            bool busqueda;
            busqueda = lstnum1.Contains(a);                       
            return busqueda;          
        }
        
        public List<int> mostrar()
        {
            return lstnum1;
        }
    }
}
