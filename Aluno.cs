using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Alunos
{
    class Aluno
    {
        List<Aluno> alunos = new List<Aluno>();

        public string nome;
        public string email;
        public string turma;

        public void listar()
        {
            alunos.ForEach(a =>
            {
                MessageBox.Show("Nome: " + a.nome + "\nE-mail: " + a.email + "\nTurma: " + a.turma);
            });
        }

        public void salvar(Aluno aluno)
        {
            alunos.Add(aluno);
        }
    }
}
