using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLista.classes
{
    public class Contato
    {
        #region Propriedades
        private string nome;
        private string email;
        private string telefone;
        private Data dataNascismento;

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public Data DtNasc { get => dataNascismento; set => dataNascismento = value; }
        #endregion

        #region Construtores 
        public Contato() : this("", "", "", null) { }

        public Contato(string email, string nome, string telefone, Data dataNasc)
        {
            this.email = email;
            this.nome = nome;
            this.telefone = telefone;
            this.dataNascismento = dataNasc;
        }
        #endregion

        public int GetIdade()
        {
            int idade = DateTime.Now.Year - dataNascismento.Ano;

            if (dataNascismento.Mes > DateTime.Now.Month || (dataNascismento.Mes == DateTime.Now.Month && dataNascismento.Dia < DateTime.Now.Day))
            { 
                idade--;
            }

            return idade;
        }

        public override string ToString()
        {
            string retorno = $"Nome = {nome}\nEmail = {email}\nTelefone = {telefone}\nIdade = {GetIdade()}";  

            return retorno;
        }

        public override bool Equals(object obj)
        {
            return this.nome.Equals(((Contato)obj).nome);
        }
    }
}
