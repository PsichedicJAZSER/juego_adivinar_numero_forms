using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego_adivinar_numero_forms
{
    public partial class formJuego : Form
    {
        public formJuego()
        {
            InitializeComponent();

        }

        public void random()
        {
        }

        /// <summary>
        /// se guardan todas las variables numericas, el corazon del codigo
        /// </summary>
        /// <retunr>hace todas las operaciones y funciones del codigo</retunr>
        public void numeros()
        {
            int numUsuario = 0;
            bool bandera = true;
            Random rng = new Random();
            int numRandom = rng.Next(1, 100);


            try
            {
                do
                {
                    numUsuario = Convert.ToInt32(txtNumUsuario.Text);
                    if (txtNumAnte1.Text == null && numUsuario != numRandom)
                    {
                        txtNumAnte1.Text = numUsuario.ToString();
                        txtNumUsuario.Text = null;
                        if (numUsuario < numRandom)
                        {
                            MessageBox.Show("Te faltó!!");
                        }
                        else
                        {
                            MessageBox.Show("Te pasaste!!");
                        }
                        bandera = false;
                    }
                    else if (txtNumAnte2.Text == null && numUsuario != numRandom)
                    {
                        txtNumAnte2.Text = numUsuario.ToString();
                        txtNumUsuario.Text = null;
                        if (numUsuario < numRandom)
                        {
                            MessageBox.Show("Te faltó!!");
                        }
                        else
                        {
                            MessageBox.Show("Te pasaste!!");
                        }
                        bandera = false;
                    }
                    else if (txtNumAnte3.Text == null && numUsuario != numRandom)
                    {
                        txtNumAnte3.Text = numUsuario.ToString();
                        txtNumUsuario.Text = null;
                        if (numUsuario < numRandom)
                        {
                            MessageBox.Show("Te faltó!!");
                        }
                        else
                        {
                            MessageBox.Show("Te pasaste!!");
                        }
                        bandera = false;
                    }
                    else if (txtNumAnte4.Text == null && numUsuario != numRandom)
                    {
                        txtNumAnte4.Text = numUsuario.ToString();
                        txtNumUsuario.Text = null;
                        if (numUsuario < numRandom)
                        {
                            MessageBox.Show("Te faltó!!");
                        }
                        else
                        {
                            MessageBox.Show("Te pasaste!!");
                        }
                        bandera = false;
                    }
                    else if (txtNumAnte5.Text == null && numUsuario != numRandom)
                    {
                        txtNumAnte5.Text = numUsuario.ToString();
                        txtNumUsuario.Text = null;
                        if (numUsuario < numRandom)
                        {
                            MessageBox.Show("Te faltó!!");
                        }
                        else
                        {
                            MessageBox.Show("Te pasaste!!");
                        }
                        bandera = false;
                    }
                    else if (numUsuario == numRandom)
                    {
                        MessageBox.Show("Ganaste!! ingresa otro numero para volver a intentar o cierra la ventana para salir");
                        rng = new Random();
                        numRandom = rng.Next(1, 100);
                    }
                    else
                    {
                        bandera = false;
                    }
                    bandera = false;

                } while (bandera == true);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("no has escrito nada");
            }

        }

        /// <summary>
        /// vuelve a correr el codigo
        /// </summary>
        /// <return>reinicia todo el progreso</return>
        public void reiniciar ()
        {
            txtNumUsuario.Text = null;
            txtNumAnte5.Text = null;
            txtNumAnte4.Text = null;
            txtNumAnte3.Text = null;
            txtNumAnte2.Text = null;
            txtNumAnte1.Text = null;

            MessageBox.Show("la partida se reiniciara, buena suerte!!");
        }

        /// <summary>
        /// boton para intentar adivinar el numero
        /// </summary>
        /// <return>Al precionarlo da los resultados en esta ronda</return>
        private void btnAdivinar_Click(object sender, EventArgs e)
        {
            numeros();
        }

        /// <summary>
        /// boton para reiniciar
        /// </summary>
        /// <return>borra el progreso anterior e inicia una nueva partida</return>
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reiniciar();
        }







    }





}
