using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_windows_forms
{
    public partial class Form4 : Form
    {
        public int limite = 0;
        Musicas[] lista_musicas = new Musicas[5];
        public Form4()
        {
            InitializeComponent();
        }
        public class Musicas
        {
            private string Nome;
            private string Cantor;
            private string Genero;
            private string Nota;

            public string getNome()
            {

                return Nome;
            }

            public string getCantor()
            {
                return Cantor;
            }

            public string getGenero()
            {
                return Genero;
            }

            public string getNota()
            {
                return Nota;
            }

            public void setNome(string a)
            {
                this.Nome = a;
            }

            public void setCantor(string b)
            {
                this.Cantor = b;
            }

            public void setGenero(string c)
            {
                this.Genero = c;
            }

            public void setNota(string d)
            {
                this.Nota = d;
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            Musicas x = new Musicas();
            
            
            
            x.setNome (textBox1.Text);
            x.setCantor(textBox2.Text);
            x.setGenero(textBox3.Text);
            x.setNota(textBox4.Text);

            lista_musicas[limite] = x;
            limite++;
            /*Console.WriteLine("titu: " + x.getAutor());
            Console.WriteLine("aut" + x.getTitulo());
            Console.WriteLine("lim: " + limite);*/

            for (int i = 0; i < limite; i++)
            {

                Console.WriteLine($"Nome: {lista_musicas[i].getNome()} \n Cantor(a): {lista_musicas[i].getCantor()} \n Gênero: {lista_musicas[i].getGenero()} \n Nota {lista_musicas[i].getNota()} e {limite}");
            }

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
