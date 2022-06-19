using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ShowResult()
        {
            if (textBox1.Text != "")
            {
                label19.Text = listBox1.SelectedItem.ToString();
                double result = Convert.ToDouble(textBox1.Text);
                switch (listBox1.SelectedItem.ToString())
                {
                    case "нанометр, нм":
                        {
                            textBox2.Text += Convert.ToString(result) + " нм \n " + Environment.NewLine; 
                            textBox2.Text += Convert.ToString(result / 1000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10000000) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100000000) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000000) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000000000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000000 * 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000000 * 0.71) + " верста \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000000 * 0.044) + " вершок \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000000 * 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000000 * 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000000 * 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000000 * 2.13) + " сажней \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000000 * 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "микрометр, мкм":
                        {
                            textBox2.Text += Convert.ToString(result * 1000) + " нм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10000) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100000) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000 * 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000 * 0.71) + " верста \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000 * 0.044) + " вершок \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000 * 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000 * 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000 * 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000 * 2.13) + " сажней \n" + Environment.NewLine; 
                            textBox2.Text += Convert.ToString(result / 1000000 * 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "миллиметр, млм":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000) + " нм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 0.71) + " верста \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 0.044) + " вершок \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 2.13) + " сажней \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "сантиметр, см":
                        {
                            textBox2.Text += Convert.ToString(result * 10000000) + " нм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 10000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 10) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100 * 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100 * 0.71) + " аршин \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100 * 0.044) + " вершок \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100 * 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100 * 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100 * 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100 * 2.13) + " сажней \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100 * 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "дециметр, дм":
                        {
                            textBox2.Text += Convert.ToString(result * 100000000) + " нм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 100000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 100) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 10) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10 * 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10 * 0.71) + " аршин \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10 * 0.044) + " вершок \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10 * 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10 * 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10 * 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10 * 2.13) + " сажней \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 10 * 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "метр, м":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000000) + " нм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 100) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 10) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71) + " аршин \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044) + " вершок \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13) + " сажней \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "километр, км":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000000000) + " нм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 100000) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 10000) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1.61) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000044) + " вершок \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1.07) + " аршин \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000* 2.13) + " сажней \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "миля":
                        {
                            textBox2.Text += Convert.ToString(result / 1609.34 * 1000000000) + " нм \n";
                            textBox2.Text += Convert.ToString(result / 1609.34 * 1000000) + " мкм \n";
                            textBox2.Text += Convert.ToString(result / 1609.34 * 1000) + " мм \n";
                            textBox2.Text += Convert.ToString(result / 1609.34 * 100) + " см \n";
                            textBox2.Text += Convert.ToString(result / 1609.34 * 10) + " дм \n";
                            textBox2.Text += Convert.ToString(result / 1609.34) + " м \n";
                            textBox2.Text += Convert.ToString(result / 1609.34 / 1000) + " км \n";
                            textBox2.Text += Convert.ToString(result) + " миль \n";
                            textBox2.Text += Convert.ToString(result / 1609.34 * 0.71) + " аршин \n";
                            textBox2.Text += Convert.ToString(result / 1609.34 * 0.044) + " вершок \n";
                            textBox2.Text += Convert.ToString(result / 1609.34 * 0.025) + " дюйм \n";
                            textBox2.Text += Convert.ToString(result / 1609.34 * 0.45) + " локтей \n";
                            textBox2.Text += Convert.ToString(result / 1609.34 * 0.18) + " пядей \n";
                            textBox2.Text += Convert.ToString(result / 1609.34 * 2.13) + " сажней \n";
                            textBox2.Text += Convert.ToString(result / 1609.34 * 0.3) + " фут \n";
                            break;
                        }
                    case "аршин":
                        {
                            textBox2.Text += Convert.ToString(result * 0.71 * 1000000000) + " нм " + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71 * 1000000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71 * 1000) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71 * 100) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71 * 10) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71 / 1000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71 / 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " аршин \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71 / 0.044) + " вершок \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71 / 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71 / 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71 / 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71 / 2.13) + " сажней \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.71 / 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "вершок":
                        {
                            textBox2.Text += Convert.ToString(result * 0.044 * 1000000000) + " нм " + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044 * 1000000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044 * 1000) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044 * 100) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044 * 10) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044 / 1000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044 / 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "вершок \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044 / 0.71) + " аршин \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044 / 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044 / 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044 / 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044 / 2.13) + " сажней \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.044 / 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "дюйм":
                        {
                            textBox2.Text += Convert.ToString(result * 0.025 * 1000000000) + " нм " + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025 * 1000000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025 * 1000) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025 * 100) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025 * 10) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025 / 1000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025 / 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025 / 0.71) + " аршин \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025 / 0.044) + " вершок \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025 / 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025 / 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025 / 2.13) + " сажней \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.025 / 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "локоть":
                        {
                            textBox2.Text += Convert.ToString(result * 0.45 * 1000000000) + " нм " + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45 * 1000000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45 * 1000) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45 * 100) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45 * 10) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45 / 1000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45 / 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "локоть \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45 / 0.71) + " верста \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45 / 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45 / 0.044) + "вершков \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45 / 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45 / 2.13) + " сажней \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.45 / 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "пядь":
                        {
                            textBox2.Text += Convert.ToString(result * 0.18 * 1000000000) + " нм " + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18 * 1000000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18 * 1000) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18 * 100) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18 * 10) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18 / 1000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18 / 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18 / 0.71) + " верста \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18 / 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18 / 0.044) + "вершков \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18 / 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18 / 2.13) + " сажней \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.18 / 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "сажень":
                        {
                            textBox2.Text += Convert.ToString(result * 2.13 * 1000000000) + " нм " + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13 * 1000000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13 * 1000) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13 * 100) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13 * 10) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13 / 1000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13 * 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "сажень \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13 / 0.71) + " верста \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13 / 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13 / 0.044) + "вершков \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13 / 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13 / 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2.13 / 0.3) + " фут \n" + Environment.NewLine;
                            break;
                        }
                    case "фут":
                        {
                            textBox2.Text += Convert.ToString(result * 0.3048 * 1000000000) + " нм " + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048 * 1000000) + " мкм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048 * 1000) + " мм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048 * 100) + " см \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048 * 10) + " дм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048) + " м \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048 / 1000) + " км \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048 / 1609.34) + " миль \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "фут \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048 / 0.71) + " верста \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048 / 0.025) + " дюйм \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048 / 0.044) + "вершков \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048 / 0.45) + " локтей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048 / 0.18) + " пядей \n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.3048 / 2.13) + " сажень \n" + Environment.NewLine;
                            break;
                        }
                    case "миллиметр квадратный, мм²":
                        {
                            textBox2.Text += Convert.ToString(result) + " мм²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10,2)) + " см²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10,4)) + " дм²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10,6)) + " м²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10,12)) + " км²" + Environment.NewLine;
                            break;
                        }
                    case "сантиметр квадратный, см²":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 2)) + " мм²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " см²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 2)) + " дм²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 4)) + " м²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 8)) + " км²" + Environment.NewLine;
                            break;
                        }
                    case "дециметр квадратный, дм²":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 4)) + " мм²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 2)) + " см²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "дм²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 2)) + " м²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 6)) + " км²" + Environment.NewLine;
                            break;
                        }
                    case "метр квадратный, м²":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 6)) + " мм²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 4)) + " см²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 2)) + " дм²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " м²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 6)) + " км²" + Environment.NewLine;
                            break;
                        }
                    case "километр квадратный, км²":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 12)) + " мм²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 10)) + " см²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 8)) + " дм²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 6)) + " м²" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " км²" + Environment.NewLine;
                            break;
                        }
                    case "миллиметр кубический, мм³":
                        {
                            textBox2.Text += Convert.ToString(result) + " мм³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 3)) + " см³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 6)) + " дм³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 9)) + " м³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 12)) + " км³" + Environment.NewLine;
                            break;
                        }
                    case "сантиметр кубический, см³":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 3)) + " мм³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " см³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 3)) + " дм³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 6)) + " м³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 9)) + " км³" + Environment.NewLine;
                            break;
                        }
                    case "дециметр кубический, дм³":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 6)) + " мм³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 3)) + " см³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "дм³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 3)) + " м³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 6)) + " км³" + Environment.NewLine;
                            break;
                        }
                    case "метр кубический, м³":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 9)) + " мм³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 6)) + " см³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 3)) + " дм³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " м³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / Math.Pow(10, 3)) + " км³" + Environment.NewLine;
                            break;
                        }
                    case "километр кубический, км³":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 12)) + " мм³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 9)) + " см³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 6)) + " дм³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 3)) + " м³" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " км³" + Environment.NewLine;
                            break;
                        }
                    case "километр в день, км/день":
                        {
                            textBox2.Text += Convert.ToString(result) + " км/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 24) + " км/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1440) + " км/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 86400) + " км/c" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " м/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000 /24) + " м/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000 / 1440) + " м/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000 / 86400) + " м/c" + Environment.NewLine;
                            break;
                        }
                    case "километр в час, км/ч":
                        {
                            textBox2.Text += Convert.ToString(result * 24) + " км/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result ) + " км/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 60) + " км/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 3600) + " км/c" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 24000) + " м/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " м/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000 / 60) + " м/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000 / 3600) + " м/c" + Environment.NewLine;
                            break;
                        }
                    case "километр в минуту, км/м":
                        {
                            textBox2.Text += Convert.ToString(result * 1440) + " км/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 60) + " км/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " км/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 60) + " км/c" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1440 * 1000) + " м/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000 * 60) + " м/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " м/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000 / 60) + " м/c" + Environment.NewLine;
                            break;
                        }
                    case "километр в секунду, км/с":
                        {
                            textBox2.Text += Convert.ToString(result * 86400) + " км/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1440) + " км/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 60) + " км/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " км/c" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 86400 * 1000) + " м/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000 * 1440) + " м/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000 * 60) + " м/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " м/c" + Environment.NewLine;
                            break;
                        }
                    case "метр в день, м/день":
                        {
                            textBox2.Text += Convert.ToString(result / 1000) + " км/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 24000) + " км/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1440000) + " км/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 / 86400) + " км/c" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " м/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 24) + " м/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1440) + " м/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 86400) + " м/c" + Environment.NewLine;
                            break;
                        }
                    case "метр в час, м/ч":
                        {
                            textBox2.Text += Convert.ToString(result / 1000 * 24) + " км/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000) + " км/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 60000 ) + " км/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 3600000) + " км/c" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 24) + " м/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " м/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 60) + " м/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 3600) + " м/c" + Environment.NewLine;
                            break;
                        }
                    case "метр в минуту, м/м":
                        {
                            textBox2.Text += Convert.ToString(result / 1000 * 24) + " км/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000) + " км/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 60000) + " км/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 3600000) + " км/c" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1440) + " м/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 60) + " м/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " м/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 60) + " м/c" + Environment.NewLine;
                            break;
                        }
                    case "метр в секунду, м/с":
                        {
                            textBox2.Text += Convert.ToString(result / 1000 * 86400) + " км/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 3600) + " км/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000 * 60) + " км/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1000) + " км/c" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 86400) + " м/день" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 3600) + " м/ч" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 60) + " м/мин" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " м/c" + Environment.NewLine;
                            break;
                        }
                    case "градус Цельсия, °С ":
                        {
                            textBox2.Text += Convert.ToString(result) + " °С" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 9 / 5 + 32 ) + " F" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result + 273.15) + " K" + Environment.NewLine;
                            break;
                        }
                    case "градус Фаренгейта, F":
                        {
                            textBox2.Text += Convert.ToString((result - 32) * 5 / 9) + " °С" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " F" + Environment.NewLine;
                            textBox2.Text += Convert.ToString((result - 32) * 5 / 9 + 273.15) + " K" + Environment.NewLine;
                            break;
                        }
                    case "градус Кельвина, K":
                        {
                            textBox2.Text += Convert.ToString(result - 273.15) + " °С" + Environment.NewLine;
                            textBox2.Text += Convert.ToString((result - 273.15) * 9 / 5 + 32) + " F" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " K" + Environment.NewLine;
                            break;
                        }
                    case "бит, б":
                        {
                            textBox2.Text += Convert.ToString(result) + " б\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2,-3)) + " Б\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2,-13)) + " КБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2,-23)) + " МБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2,-33)) + " ТБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2,-43)) + " ПБ\n" + Environment.NewLine;
                            break;
                        }
                    case "байт, Б":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 3)) + " б\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " Б\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, -10)) + " КБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, -20)) + " МБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, -30)) + " ТБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, -40)) + " ПБ\n" + Environment.NewLine;
                            break;
                        }
                    case "килобайт, КБ":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 13)) + " б\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 10)) + " Б\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " КБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, -10)) + " МБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, -20)) + " ТБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, -30)) + " ПБ\n" + Environment.NewLine;
                            break;
                        }
                    case "мегабайт, МБ":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 23)) + " б\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 20)) + " Б\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 10)) + " КБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "МБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, -10)) + " ТБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, -20)) + " ПБ\n" + Environment.NewLine;
                            break;
                        }
                    case "терабайт, ТБ":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 33)) + " б\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 30)) + " Б\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 20)) + " КБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 10)) + " МБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "ТБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, -10)) + " ПБ\n" + Environment.NewLine;
                            break;
                        }
                    case "петабайт, ПБ":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 43)) + " б\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 40)) + " Б\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 30)) + " КБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 20)) + " МБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(2, 10)) + " ТБ\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "ПБ\n" + Environment.NewLine;
                            break;
                        }
                    case "градус":
                        {
                            textBox2.Text += Convert.ToString(result) + " °\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.PI / 180) + " рад\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 10 / 9) + " град\n" + Environment.NewLine;
                            break;
                        }
                    case "радиан":
                        {
                            textBox2.Text += Convert.ToString(result / Math.PI * 180) + " °\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " рад\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString((result / Math.PI * 180) * 10 / 9) + " град\n" + Environment.NewLine;
                            break;
                        }
                    case "град":
                        {
                            textBox2.Text += Convert.ToString(result * 9 / 10) + " °\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString((result * 9 / 10) * Math.PI / 180) + " рад\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " град\n" + Environment.NewLine;
                            break;
                        }
                    case "микроньютон, мкН":
                        {
                            textBox2.Text += Convert.ToString(result) + " мкН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001) + " мН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000001) + " Н\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000001) + " КН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000000001) + " МН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -15)) + " ГН\n" + Environment.NewLine;
                            break;
                        }
                    case "миллиньютон, мН":
                        {
                            textBox2.Text += Convert.ToString(result * 1000) + " мкН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " мН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001) + " Н\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000001) + " КН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000001) + " МН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 10 * Math.Pow(10, -13)) + " ГН\n" + Environment.NewLine;
                            break;
                        }
                    case "ньютон, Н":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000) + " мкН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " мН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " Н\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001) + " КН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000001) + " МН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -9)) + " ГН\n" + Environment.NewLine;
                            break;
                        }
                    case "килоньютон, КН":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000000) + " мкН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + " мН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " Н\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " КН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001) + " МН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -6)) + " ГН\n" + Environment.NewLine;
                            break;
                        }
                    case "меганьютон, МН":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000000000) + " мкН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000000) + " мН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + " Н\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " КН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " МН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3)) + " ГН\n" + Environment.NewLine;
                            break;
                        }
                    case "гиганьютон, ГН":
                        {
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 15)) + " мкН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 10 * Math.Pow(10, 11)) + " мН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000000) + " Н\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + " КН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " МН\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " ГН\n" + Environment.NewLine;
                            break;
                        }
                    case "микрограмм, мкг":
                        {
                            textBox2.Text += Convert.ToString(result) + " мкг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001) + " мг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000001) + " г\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000001) + " кг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.00000000001) + " ц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000000001) + " т\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 6.02214129011674 * Math.Pow(10, 17)) + " а.е.м.\n" + Environment.NewLine;
                            break;
                        }
                    case "миллиграмм, мг":
                        {
                            textBox2.Text += Convert.ToString(result * 1000) + " мкг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " мг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001) + " г\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000001) + " кг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.00000001) + " ц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000001) + " т\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 6.02214129011674 * Math.Pow(10, 20)) + " а.е.м.\n" + Environment.NewLine;
                            break;
                        }
                    case "грамм, г":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000) + " мкг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " мг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " г\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001) + " кг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.00001) + " ц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000001) + " т\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 6.022 * Math.Pow(10, 23)) + " а.е.м.\n" + Environment.NewLine;
                            break;
                        }
                    case "килограмм, кг":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000000) + " мкг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + " мг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " г\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " кг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.01) + " ц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001) + " т\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 6.022 * Math.Pow(10, 26)) + " а.е.м.\n" + Environment.NewLine;
                            break;
                        }
                    case "центнер, ц":
                        {
                            textBox2.Text += Convert.ToString(result * 100000000000) + " мкг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 100000000) + " мг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 100000) + " г\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 100) + " кг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " ц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.1) + " т\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 6.022 * Math.Pow(10, 28)) + " а.е.м.\n" + Environment.NewLine;
                            break;
                        }
                    case "тонна, т":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000000000) + " мкг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000000) + " мг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + " г\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " кг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 10) + "ц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "т\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 6.022 * Math.Pow(10, 29)) + "а.е.м.\n" + Environment.NewLine;
                            break;
                        }
                    case "атомная масса, а.е.м.":
                        {
                            textBox2.Text += Convert.ToString(result * 1.661 * Math.Pow(10, -18)) + "мкг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1.661 * Math.Pow(10, -21)) + "мг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1.661 * Math.Pow(10, -24)) + "г\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1.661 * Math.Pow(10, -27)) + "кг\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1.661 * Math.Pow(10, -29)) + "ц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1.661 * Math.Pow(10, -30)) + "т\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "а.е.м.\n" + Environment.NewLine;
                            break;
                        }
                    case "микроватт, мкВт":
                        {
                            textBox2.Text += Convert.ToString(result) + " мкВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001) + " мВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000001) + " Вт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000001) + " КВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000000001) + " МВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000000000001) + " ГВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.0000000013596216173039) + " л.с.\n" + Environment.NewLine;
                            break;
                        }
                    case "милливатт, мВт":
                        {
                            textBox2.Text += Convert.ToString(result * 1000) + " мкВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " мВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3)) + " Вт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -6)) + " КВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 10 * Math.Pow(10, -10)) + " МВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000000001) + " ГВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1.34 * Math.Pow(10, -6)) + " л.с.\n" + Environment.NewLine;
                            break;
                        }
                    case "ватт, Вт":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000) + " мкВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " мВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " Вт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3)) + " КВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -6)) + " МВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000001) + " ГВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1.34 * Math.Pow(10, -3)) + " л.с.\n" + Environment.NewLine;
                            break;
                        }
                    case "киловатт, КВт":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000000) + " мкВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + " мВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " Вт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " КВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3)) + " МВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000001) + " ГВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1.34) + " л.с.\n" + Environment.NewLine;
                            break;
                        }
                    case "мегаватт, МВт":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000000000) + " мкВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000000) + " мВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + " Вт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " КВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " МВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001) + " ГВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1.34102) + " л.с.\n" + Environment.NewLine;
                            break;
                        }
                    case "гигаватт, ГВт":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000000000000) + " мкВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000000000) + " мВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000000) + " Вт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + " КВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + " МВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " ГВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1359621.6173039) + " л.с.\n" + Environment.NewLine;
                            break;
                        }
                    case "лошадиная сила, л.с.":
                        {
                            textBox2.Text += Convert.ToString(result * 735498750) + " мкВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 745.69987) + " мВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 745.7) + " Вт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.75) + " КВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 7.46 * Math.Pow(10, -4)) + " МВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.00000073549875) + " ГВт\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " л.с.\n" + Environment.NewLine;
                            break;
                        }
                    case "миллисекунда, мс":
                        {
                            textBox2.Text += "принято, что месяц = 30 дней, год обычный(365 дней)" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " мс\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3)) + " с\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3) / 60) + " мин\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3) / 360) + " ч\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3) / 86400) + " день\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3) / 604800) + " неделя\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3) / 2592000) + " месяц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3) / 31104000) + " год\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3) / 3110400000) + " век\n" + Environment.NewLine;
                            break;
                        }
                    case "секунда, с":
                        {
                            textBox2.Text += "принято, что месяц = 30 дней, год обычный(365 дней)" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 3)) + " мс\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " с\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 60) + " мин\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 360) + " ч\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 86400) + " день\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 604800) + " неделя\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 2592000) + " месяц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 31104000) + " год\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 3110400000) + " век\n" + Environment.NewLine;
                            break;
                        }
                    case "минута, мин":
                        {
                            textBox2.Text += "принято, что месяц = 30 дней, год обычный(365 дней)" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 3) * 60) + " мс\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 60) + " с\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " мин\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 60) + " ч\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1800) + " день\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 12600) + " неделя\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 5400) + " месяц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 648000) + " год\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 64800000) + " век\n" + Environment.NewLine;
                            break;
                        }
                    case "час, ч":
                        {
                            textBox2.Text += "принято, что месяц = 30 дней, год обычный(365 дней)" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 3) * 360) + " мс\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 360) + " с\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 60) + " мин\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " ч\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 24) + " день\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 168) + " неделя\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 720) + " месяц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 8640) + " год\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 864000) + " век\n" + Environment.NewLine;
                            break;
                        }
                    case "день, день":
                        {
                            textBox2.Text += "принято, что месяц = 30 дней, год обычный(365 дней)" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 3) * 86400) + " мс\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 86400) + " с\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1400) + " мин\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 24) + " ч\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " день\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 7) + " неделя\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 30) + " месяц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 360) + " год\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 36000) + " век\n" + Environment.NewLine;
                            break;
                        }
                    case "неделя, неделя":
                        {
                            textBox2.Text += "принято, что месяц = 30 дней, год обычный(365 дней)" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 3) * 604800) + " мс\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 604800) + " с\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 10080) + " мин\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 168) + " ч\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 7) + " день\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " неделя\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 7 / 30) + " месяц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 7 / 360) + " год\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 7 / 36000) + " век\n" + Environment.NewLine;
                            break;
                        }
                    case "месяц, месяц":
                        {
                            textBox2.Text += "принято, что месяц = 30 дней, год обычный(365 дней)" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 3) * 2592000) + " мс\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 2592000) + " с\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 43200) + " мин\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 720) + " ч\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 30) + " день\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 30 / 7) + " неделя\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " месяц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 12) + " год\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 1200) + " век\n" + Environment.NewLine;
                            break;
                        }
                    case "год, г":
                        {
                            textBox2.Text += "принято, что месяц = 30 дней, год обычный(365 дней)" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 3) * 31536000) + " мс\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 31536000) + " с\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 525600) + " мин\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 8760) + " ч\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 365) + " день\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 365 / 7) + " неделя\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 12) + " месяц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " год\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result / 100) + " век\n" + Environment.NewLine;
                            break;
                        }
                    case "век, век":
                        {
                            textBox2.Text += "принято, что месяц = 30 дней, год обычный(365 дней)" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, 3) * 3153600000) + " мс\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 3153600000) + " с\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 52560000) + " мин\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 876000) + " ч\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 36500) + " день\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 36500 / 7) + " неделя\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1200) + " месяц\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 100) + " год\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + " век\n" + Environment.NewLine;
                            break;
                        }
                    case "микропаскаль, мкПа":
                        {
                            textBox2.Text += Convert.ToString(result) + "мкПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001) + "мПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000001) + "Па\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000001) + "КПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000000001) + "МПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000000000001) + "ГПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.0000000075006150504341) + "м.р.с.\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.0000000000098692328671601) + "атм.\n" + Environment.NewLine;
                            break;
                        }

                    case "миллипаскаль, мПа":
                        {
                            textBox2.Text += Convert.ToString(result * 1000) + "мкПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "мПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3)) + "Па\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -6)) + "КПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 10 * Math.Pow(10, -10)) + "МПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000000001) + "ГПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.0000075006150504341) + "м.р.с.\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.0000000098692326671601) + "атм.\n" + Environment.NewLine;
                            break;
                        }

                    case "паскаль, Па":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000) + "мкПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + "мПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "Па\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3)) + "КПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -6)) + "МПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000000001) + "ГПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.0075006150504341) + "м.р.с.\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.0000098692326671601) + "атм.\n" + Environment.NewLine;
                            break;
                        }

                    case "килопаскаль, КПа":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000000) + "мкПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + "мПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + "Па\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "КПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * Math.Pow(10, -3)) + "МПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000001) + "ГПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 7.5006150504341) + "м.р.с.\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.0098692326671601) + "атм.\n" + Environment.NewLine;
                            break;
                        }

                    case "мегапаскаль, МПа":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000000000) + "мкПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000000) + "мПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + "Па\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + "КПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "МПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001) + "ГПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 7500.6150504341) + "м.р.с.\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 9.8692326671601) + "атм.\n" + Environment.NewLine;
                            break;
                        }

                    case "гигапаскаль, ГПа":
                        {
                            textBox2.Text += Convert.ToString(result * 1000000000000000) + "мкПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000000000) + "мПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000000) + "Па\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000000) + "КПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 1000) + "МПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "ГПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 7500615.0504341) + "м.р.с.\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 9869.2326671601) + "атм.\n" + Environment.NewLine;
                            break;
                        }

                    case "миллиметры ртутного столба":
                        {
                            textBox2.Text += Convert.ToString(result * 133322400) + "мкПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 133322.4) + "мПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 133.3224) + "Па\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.1333224) + "КПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.001333224) + "МПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.0000001333224) + "ГПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "м.р.с.\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.0013157897853442) + "атм.\n" + Environment.NewLine;
                            break;
                        }

                    case "атмосфера ст.":
                        {
                            textBox2.Text += Convert.ToString(result * 101325000000) + "мкПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 101325000) + "мПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 101325) + "Па\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 101.325) + "КПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.101325) + "МПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 0.000101325) + "ГПа\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result * 759.99981998524) + "м.р.с.\n" + Environment.NewLine;
                            textBox2.Text += Convert.ToString(result) + "атм.\n" + Environment.NewLine;
                            break;
                        }

                }
            }
        }
        public string test_1(string A)
        {
            string TextI = "information";
            return A= TextI;
        }
        void ReactToClick(string[] listitems)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Label && x.Tag == "information")
                {
                    x.BackColor = Color.Aqua;
                }
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(listitems);
            listBox1.SetSelected(0, true);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                textBox2.Text = "";
                ShowResult();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            string[] listitems = { "нанометр, нм", "микрометр, мкм", "миллиметр, млм", "сантиметр, см", "дециметр, дм", "метр, м", "километр, км", "миля","аршин","вершок","дюйм","локоть","пядь","сажень","фут" };
            ReactToClick(listitems);
            label1.BackColor = Color.Red;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            string[] listitems = { "миллиметр квадратный, мм²", "сантиметр квадратный, см²", "дециметр квадратный, дм²", "метр квадратный, м²", "километр квадратный, км²" };
            ReactToClick(listitems);
            label2.BackColor = Color.Red;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            string[] listitems = { "миллиметр кубический, мм³", "сантиметр кубический, см³", "дециметр кубический, дм³", "метр кубический, м³", "километр кубический, км³", "миллилитр, мл", "литр, л"};
            ReactToClick(listitems);
            label3.BackColor = Color.Red;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            string[] listitems = { "километр в день, км/день", "километр в час, км/ч", "километр в минуту, км/м", "километр в секунду, км/с", "метр в день, м/день", "метр в час, м/ч", "метр в минуту, м/м", "метр в секунду, м/с" };
            ReactToClick(listitems);
            label4.BackColor = Color.Red;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            string[] listitems = { "миллисекунда, мс", "секунда, с", "минута, мин", "час, ч", "день, день", "неделя, неделя", "месяц, месяц", "год, г", "век, век" };
            ReactToClick(listitems);
            label5.BackColor = Color.Red;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            string[] listitems = { "микрограмм, мкг", "миллиграмм, мг", "грамм, г", "килограмм, кг", "центнер, ц", "тонна, т", "атомная масса, а.е.м." };
            ReactToClick(listitems);
            label6.BackColor = Color.Red;
        }
        private void label8_Click(object sender, EventArgs e)
        { 
            string[] listitems = { "бит, б", "байт, Б", "килобайт, КБ", "мегабайт, МБ", "терабайт, ТБ", "петабайт, ПБ" };
            ReactToClick(listitems);
            label8.BackColor = Color.Red;
        }
        private void label9_Click(object sender, EventArgs e)
        {
            string[] listitems = { "микроньютон, мкН", "миллиньютон, мН", "ньютон, Н", "килоньютон, КН", "меганьютон, МН", "гиганьютон, ГН" };
            ReactToClick(listitems);
            label9.BackColor = Color.Red;
        }
        private void label11_Click(object sender, EventArgs e)
        {
            string[] listitems = { "градус", "радиан", "град"};
            ReactToClick(listitems);    
            label11.BackColor = Color.Red;
        }
        private void label12_Click(object sender, EventArgs e)
        {
            string[] listitems = { "градус Цельсия, °С ", "градус Фаренгейта, F", "градус Кельвина, K" };
            ReactToClick(listitems);
            label12.BackColor = Color.Red;
        }
        private void label14_Click(object sender, EventArgs e)
        {
            string[] listitems = { "микропаскаль, мкПа", "миллипаскаль, мПа", "паскаль, Па", "килопаскаль, КПа", "мегапаскаль, МПа", "гигапаскаль, ГПа" , "миллиметры ртутного столба", "атмосфера ст."};
            ReactToClick(listitems);
            label14.BackColor = Color.Red;
        }
        private void label16_Click(object sender, EventArgs e)
        {
            string[] listitems = { "микроватт, мкВт", "милливатт, мВт", "ватт, Вт", "киловатт, КВт", "мегаватт, МВт", "гигаватт, ГВт", "лошадиная сила, л.с." };
            ReactToClick(listitems);
            label16.BackColor = Color.Red;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double num;
            if ((listBox1.SelectedIndex >= 0) && (double.TryParse(textBox1.Text, out num)))
            {
                textBox2.Text = "";
                ShowResult();
            }
        }
    }
}
