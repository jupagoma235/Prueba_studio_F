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

        public List<int> repetidos()
        {
            int cont=0; 
            List<int> lstnum2 = new List<int>();
            
            foreach (var item in lstnum1)
            {
                cont = 0;
                foreach (var item1 in lstnum1)
                {
                    if (item == item1) 
                    {
                        cont = cont+1;
                        
                    }
                }
                if (cont > 1 ) 
                {                    
                    lstnum2.Add(item);                  
                    
                }
            }

            return lstnum2;

        }

        public List<int> mostrar()
        {
            return lstnum1;
        }
    }
}
