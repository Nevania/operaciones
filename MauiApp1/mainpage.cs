using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    internal class mainpage : TabbedPage
    {
        private void Suma_Clicked(object sender, EventArgs e)
        {
            int valor1 = int.Parse(valor1_suma.Text);
            int valor2 = int.Parse(valor2_suma.Text);
            int valor3 = int.Parse(valor3_suma.Text);
            int resultado = valor1 + valor2 + valor3;
            resultado_suma.Text = "Resultado: " + resultado;
        }

        private void Resta_Clicked(object sender, EventArgs e)
        {
            int valor1 = int.Parse(valor1_resta.Text);
            int valor2 = int.Parse(valor2_resta.Text);
            int resultado = valor1 - valor2;
            resultado_resta.Tex = "Resultado: " + resultado;
        }

        private void Multiplicacion_Clicked(object sender, EventArgs e)
        {
            int valor1 = int.Parse(valor1_multiplicacion.Text);
            int valor2 = int.Parse(Valor2_multiplicacion.Text);
            int resultado = valor1 * valor2;
            resultado_multiplicacion.Text = "Resultado:" * resultado;
    }
   
