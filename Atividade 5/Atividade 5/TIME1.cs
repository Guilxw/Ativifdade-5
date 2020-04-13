using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_5
{
    class TIME1
    {
        /*atributos*/
        private string nome;
        private Int32 vitorias;
        private Int32 derrotas;
        private Int32 empate;
        private List<Jogador> jogadores;

        /*construtor*/
        public TIME1(string Nome)
        {
            this.nome = Nome;
            this.vitorias = 0;
            this.derrotas = 0;
            this.empate = 0;
            this.jogadores = new List<Jogador>();
        }

        /*metodos*/
        public string Nome
        {
            get { return nome; }
        }

        public string getStatus()
        {
            return "O status do Time" + this.Nome +
                "é Vitorias:" + this.vitorias +
                "\tDerrotas: " + this.derrotas +
                "\tEmpates: " + this.empate;
        }

        public Int32 Vitorias
        {
            get { return vitorias; }
            set { vitorias += value; }
        }
        public Int32 Derrotas
        {
            get { return derrotas; }
            set { derrotas += value; }
        }
        public Int32 Empate
        {
            get { return empate; }
            set { empate += value; }
        }
         public void contratarJogador(Jogador j)
        {
            this.jogadores.Add(j);
        }
        
        private string demitirjogador (Jogador j)
        {
            int buscarJogador = this.jogadores.IndexOf(j);
                string Retorno = "jogador" + j.getnome();
            if (buscarJogador != -1)
            {
                this.jogadores.RemoveAt(buscarJogador);
                return Retorno + "Demitido";
            }
            return "Não foi possivel demitir" + Retorno;
        }

        private Jogador getJogador (int camisa)
        {
            return jogadores.Find(j => j.getcamisa().Equals(camisa));
        }

        public void gol (int camisa)
        {
            this.getJogador(camisa).Gols = 1;
        }

        public void getDescriçãojogadores()
        {
           
            foreach (Jogador jog in jogadores)
            {
                Console.WriteLine(jog.getDescrição()) ;
            }
        }
    }
}