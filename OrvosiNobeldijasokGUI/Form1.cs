using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace OrvosiNobeldijasokGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EvNumericUpDown.Value==0 || string.IsNullOrEmpty(NevTextBox.Text) || string.IsNullOrEmpty(SzH_TextBox.Text) || string.IsNullOrEmpty(OrszagTextBox.Text))
            {
                MessageBox.Show("Töltsön kiminden mezőt!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (1989<EvNumericUpDown.Value)
                {
                    try
                    {
                        using (StreamWriter sw = File.CreateText("uj_dijazott.txt")) {                
                            sw.WriteLine("Év;Név;SzületésHalálozás;Országkód");
                            sw.WriteLine($"{EvNumericUpDown.Value};{NevTextBox.Text};{SzH_TextBox.Text};{OrszagTextBox.Text}");

                        }
                        EvNumericUpDown.Value = 0;
                        NevTextBox.Clear();
                        SzH_TextBox.Clear();
                        OrszagTextBox.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Hiba az állomány írásánál!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Az évszám nem megfelelő!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
