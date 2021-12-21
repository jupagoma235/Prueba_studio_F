using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_studio_F
{
    public partial class Formulario_prueba : Form

    {
        
        listar listar1 = new listar();
       
        public Formulario_prueba()

        {
            InitializeComponent();
        }

        private void bt_asc_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = listar1.mostrar().OrderBy(a => a).ToList();
            textBox1.Text = "";
        }

        private void bt_des_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = listar1.mostrar().OrderByDescending(a => a).ToList();
            textBox1.Text = "";
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                listar1.guardar(Convert.ToInt32(textBox1.Text)); listBox1.DataSource = null;
                listBox1.DataSource = listar1.mostrar();
                textBox1.Text = "";
            }
            catch 
            {
                MessageBox.Show("Los valores ingresados deben ser numeros enteros y menores a 2147483647");
                textBox1.Text = "";                          
            }                        
        }

        private void bt_bsc_Click(object sender, EventArgs e)
        {
            try
            {
                if (listar1.buscar(Convert.ToInt32(textBox1.Text)) == true)
                {
                    MessageBox.Show("El número buscado si existe en la lista");
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("El número buscado no existe en la lista");
                    textBox1.Text = "";
                }
            }
            catch {

                if (textBox1.Text == "") 
                {
                    MessageBox.Show("No se ha ingresado ningun número para efectuar la busqueda");
                }
                else
                {
                    
                    MessageBox.Show("Debe ingresar solo números enteros");
                    textBox1.Text = "";
                                        
                }
            }
        }

        private void bt_rpt_Click(object sender, EventArgs e)
        {
            
            foreach (var item in listar1.mostrar().GroupBy(x => x))
            {
               if (item.Count() > 1)
               {
                   
                   MessageBox.Show("Número " + item.Key + " encontrado " + item.Count() + " veces");
               }                
            }         
            
        }        
    }
}
