using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{ 
    public partial class Form1 : Form
    {
        List<Pokemon> listadepokemones = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] texto1 = Enum.GetNames(typeof(tipotipo));
            for (int i = 0; i < texto1.Length; i++)
            {
                cbotipo.Items.Add(texto1[i]);
                cbotipo.SelectedIndex = -1;
            }
            string[] textoestado = Enum.GetNames(typeof(tipoesatados));
            for (int i = 0; i < textoestado.Length; i++)
            {
                cboestado.Items.Add(textoestado[i]);
                cboestado.SelectedIndex = -1;
            }
            string[] texto3 = Enum.GetNames(typeof(pokerus));
            for (int i = 0; i < texto3.Length; i++)
            {
                cbopokerus.Items.Add(texto3[i]);
                cbopokerus.SelectedIndex = -1;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Pokemon pk1 = new Pokemon()
            {
                nombre = txtnombre.Text,
                numero = int.Parse(txtnumero.Text),
                hp = int.Parse(txthp.Text),
                pokeruss = (pokerus)Enum.Parse(typeof(pokerus), cbopokerus.SelectedItem.ToString()),
                estado = (tipoesatados)Enum.Parse(typeof(tipoesatados), cboestado.SelectedItem.ToString()),
                tipo = (tipotipo)Enum.Parse(typeof(tipotipo), cbotipo.SelectedItem.ToString())
            };
            listadepokemones.Add(pk1);
            MessageBox.Show("Hemos recibido tu Pokemon");
            txthp.Text = " ";
            txtnombre.Text = " ";
            txtnumero.Text = "";
            cboestado.SelectedIndex = -1;
            cbopokerus.SelectedIndex = -1;
            cbotipo.SelectedIndex = -1;

        }

        private void btninfectado_Click(object sender, EventArgs e)
        {
            int x = 0; int z = 0;
            txtdatos.Text = "";
            for (int i = 0; i < listadepokemones.Count; i++)
            {
                if (listadepokemones[i].pokeruss == pokerus.si)
                {
                    x = x + 1;
                }
                else if (listadepokemones[i].pokeruss == pokerus.no)
                {
                    z = z + 1;
                }
                txtdatos.Text = "Infectados " + x + "   No Infectados " + z;

            }
        }

        private void btnhp_Click(object sender, EventArgs e)
        {
           
            int x = 0;
            txtdatos.Text = "";
            for (int i = 0; i < listadepokemones.Count; i++)
            {
                if (listadepokemones[i].hp == 0)
                {
                    x = x + 1;
                }
                txtdatos.Text = "Total: " + x;
            }
        }

        private void btnestado_Click(object sender, EventArgs e)
        {
            int x = 0; int z = 0; int q = 0; int w = 0; int r = 0;
            txtdatos.Text = "";
            for (int i = 0; i < listadepokemones.Count; i++)
            {
                if (listadepokemones[i].estado == tipoesatados.congelado)
                    x = x + 1;
                else if (listadepokemones[i].estado == tipoesatados.envenenado)
                    z = z + 1;
                else if (listadepokemones[i].estado == tipoesatados.paralizado)
                    q = q + 1;
                else if (listadepokemones[i].estado == tipoesatados.quemado)
                    w = w + 1;
                else if (listadepokemones[i].estado == tipoesatados.somnoliento)
                    r = r + 1;
            }
            txtdatos.Text = "Pokemones Congelados " + x + "\r\nPokemones Envenenados " + z + "\r\n Pokemones Paralizado  " + q + "\r\n" +
                "Pokemones Quemados " + w + "\r\nPokemones Somnolientos " + r;

        }

        private void btnatendidos_Click(object sender, EventArgs e)
        {
            txtdatos.Text = "";
            for (int i = 0; i < listadepokemones.Count; i++)
            {
                txtdatos.Text = txtdatos.Text + "Nombre:\t" +
               listadepokemones[i].nombre + "\tNumero: " +
               listadepokemones[i].numero + "\tHP: " +
               listadepokemones[i].hp + "\r\nTipo: " +
               listadepokemones[i].tipo + "    En Estado: " +
               listadepokemones[i].estado + "\r\n Estado Pokerus: " +
               listadepokemones[i].pokeruss + "\r\n\r\n";

            }

        }

        private void btntipo_Click(object sender, EventArgs e)
        {
            int x = 0; int z = 0; int q = 0; int w = 0;
            txtdatos.Text = "";
            for (int i = 0; i < listadepokemones.Count; i++)
            {
                if (listadepokemones[i].tipo == tipotipo.fuego)
                {
                    x = x + 1;
                }
                else if (listadepokemones[i].tipo == tipotipo.agua)
                {
                    z = z + 1;
                }
                else if (listadepokemones[i].tipo == tipotipo.planta)
                {
                    q = q + 1;
                }
                else if (listadepokemones[i].tipo == tipotipo.tierra)
                {
                    w = w + 1;
                }
                txtdatos.Text = "de tipo fuego " + x + "  de tipo Agua " + z + "\r\n" +
                    "de tipo planta " + q + "  de tipo Tierra " + w;
            }
        }

       
    }
}
    


   