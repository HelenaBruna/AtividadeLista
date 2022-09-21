using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLista.classes
{
    public class Contatos
    {
        private List<Contato> agendaContato = new List<Contato>();

        public List<Contato> Agenda { get => agendaContato; set => agendaContato = value; }

        public bool Adicionar(Contato c)
        {
            try
            {
                agendaContato.Add(new Contato(c.Email, c.Nome, c.Telefone, c.DtNasc));

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Contato Pesquisar(Contato c)
        {
            return agendaContato.Find(agenda => agenda.Equals(c));
        }

        public bool Alterar(Contato c)
        {
            try
            {
                int i = agendaContato.FindIndex(agenda => agenda.Equals(c));

                agendaContato[i].Nome = c.Nome;
                agendaContato[i].Telefone = c.Telefone;
                agendaContato[i].Email = c.Email;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remover(Contato c)
        {
            try
            {
                int i = agendaContato.FindIndex(agenda => agenda.Equals(c));

                agendaContato.RemoveAt(i);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
