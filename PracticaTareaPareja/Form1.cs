using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTareaPareja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //crear intancia de fish
            Fish fish = new Fish();
            fish.animalAge = 2;
            fish.animalGender = "";
            fish.CanEar = true;
            fish.sizeInft = 1;

            MessageBox.Show(fish.GetInfo());

        }
    }
}
