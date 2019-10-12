using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
            
            string otvet = null;
            num = Int32.Parse(Interaction.InputBox("Введите число", "проверка на деления"));
            //////////////////////////////////////////////////////////////////////////////
            //otvet = num > 5 && num <= 10 ? "da" :"net";
            num &= 247;
            //otvet = Convert.ToString(num, 2);

            //num %= 10;
            otvet = Convert.ToString(num);
            //otvet = Convert.ToString(otvet[otvet.Length - 1]);


            MessageBox.Show("hello");
            MessageBox.Show("hello2");

            MessageBox.Show(otvet);

    
        }
    }
}
