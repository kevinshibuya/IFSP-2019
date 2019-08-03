using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ads271_poo
{
    public partial class formMedia : Form
    {
        Aluno aluno1 = new Aluno();
        public formMedia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aluno1.name = textBoxNome.Text;
            aluno1.nota1 = Convert.ToDouble(textBoxNota1.Text);
            aluno1.nota2 = Convert.ToDouble(textBoxNota2.Text);

            labelRetornaMedia.Text = aluno1.calcMedia();
        }
    }
}
