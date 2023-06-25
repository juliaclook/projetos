using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Alunos
{
    public partial class Form1 : Form
    {
        Aluno aluno = new Aluno();

        public Form1()
        {
            InitializeComponent();
            btnSalvar.Click += cadastrarAluno;
            btnListar.Click += listar;
        }

        private void listar(object sender, EventArgs e)
        {
            aluno.listar();
        }

        private void cadastrarAluno(object sender, EventArgs e)
        {
            aluno.nome = txtNome.Text;
            aluno.email = txtEmail.Text;
            aluno.turma = txtTurma.Text;
            aluno.salvar(aluno);

            MessageBox.Show("Salvo com sucesso!");
        }
    }
}
