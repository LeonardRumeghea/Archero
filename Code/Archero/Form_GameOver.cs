using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archero
{
    public partial class Form_GameOver : Form
    {
        public Form_GameOver(int Score)
        {
            InitializeComponent();

            label_Text.Text = "Ai reusit sa omori \n" + Score.ToString() + " Gaini!";
        }
    }
}
