using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento1
{
    public class People
    {
        private string nome;
        private int idade;
        private string tele;
        private string endereço;
        private string email;

        public string Nome
        {
            get
            { return (string)nome; }
            set
            { if (value != "") nome = value; }

        }
        public int Idade { 
            get 
            { return (int)(idade * 0.7); }
            set 
            { if (value >= 0) idade = value; }
        }

        public string Tele
        {
            get
            { return (string)tele; }
            set
            { if (value != "") tele = value; }

        }
        public string Endereço
        {
            get
            { return (string)endereço;  }
            set
            { if (value != "") endereço = value; }
        }
        public string Email
        {
            get
            { return (string)email; }
            set
            { if (value != "") email = value; }
        }
    }
}
