using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_4_6_7
{
   
    public partial class Form1 : Form
    {
        
        private int nota1, nota2, nota3, nota4, promedio;
       

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

           
            lbl_promedio.Text = String.Empty;
            txt_1.Clear();
            txt_2.Clear();
            txt_3.Clear();
            txt_4.Clear();
            txt_estado.Clear();
            txtPruebaCompletiva.Clear();
            txtNotaCompletiva.Clear();
            txtTotalCompletivo.Clear();
            txtResultadoCompletivo.Clear();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_calcular_promedio_Click(object sender, EventArgs e)
        {

            PruebaCompletiva = int.Parse(txtPruebaCompletiva.Text);
            TotalCompletivo = (NotaCompletiva + PruebaCompletiva / 2);

            txtTotalCompletivo.Text = TotalCompletivo.ToString();

            //determinar si aprobo o reprobo la prueba completiva
            if (TotalCompletivo >= 70)
            {

                txtResultadoCompletivo.Text = "Aprobado";
                txtResultadoCompletivo.ForeColor = Color.Green;


            }

            else

            {
                txtResultadoCompletivo.Text = "Reprobado";
                txtResultadoCompletivo.ForeColor = Color.Red;

            }

        }

        private int NotaCompletiva, TotalCompletivo, PruebaCompletiva;
        
        public Form1()
        {
            InitializeComponent();
            txtNotaCompletiva.Visible = false;
            txtPruebaCompletiva.Visible = false;
            txtResultadoCompletivo.Visible = false;
            txtTotalCompletivo.Visible = false;
            btn_calcular_promedio.Visible = false;
            lbl_estado2.Visible = false;
            lbl_prueva.Visible = false;
            lbl_Total.Visible = false;
            lbl_nota.Visible = false;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            txtPruebaCompletiva.Clear();
            txtTotalCompletivo.Clear();
           
            txtResultadoCompletivo.Clear();
            txtNotaCompletiva.Enabled = false;
            txtPruebaCompletiva.Enabled = false;
            txtTotalCompletivo.Enabled = false;
            txtResultadoCompletivo.Enabled = false;
            btn_calcular_promedio.Enabled = false;


            nota1 = int.Parse(txt_1.Text);
            nota2 = int.Parse(txt_2.Text);
            nota3 = int.Parse(txt_3.Text);
            nota4 = int.Parse(txt_4.Text);

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            NotaCompletiva = promedio / 2;





           
            lbl_promedio.Text = promedio.ToString();


            //determinar si el estudiante aprobo o reprobo
            if (promedio >= 70)

            {

                txt_estado.Text = "Aprobado";
                txt_estado.ForeColor = Color.Green;
                txtNotaCompletiva.Clear();
            }

            else
            {
                lbl_estado2.Visible = true;
                lbl_prueva.Visible = true;
                lbl_Total.Visible = true;
                lbl_nota.Visible = true;
                lbl_promedio.Visible = true;
                txtNotaCompletiva.Visible = true;
                txtPruebaCompletiva.Visible = true;
                txtResultadoCompletivo.Visible = true;
                txtTotalCompletivo.Visible = true;
                btn_calcular_promedio.Visible = true;

                txt_estado.Text = "Reprobado";
                txt_estado.ForeColor = Color.Red;
                txtPruebaCompletiva.Enabled = true;
                txtResultadoCompletivo.Enabled = true;
                btn_calcular_promedio.Enabled = true;
                txtNotaCompletiva.Text = NotaCompletiva.ToString();




            }



        }
    }
    }

