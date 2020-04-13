using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_5
{
    public class Jogador
    {
        private string nome;
        private int idade;
        private int habilidade;
        private int camisa;
        private int gols;

        public Jogador (string Pnome, int Pidade, int Phab, int Pcamisa)
        {
            this.nome = Pnome;
            this.idade = Pidade;
            this.habilidade = Phab;
            this.camisa = Pcamisa;
        }

        public string getnome()
        {
            return nome;
        }

        public int getcamisa()
        {
            return camisa;
        }

        public int gethabilidade()
        {
            return habilidade;
        }

        public int Gols
        {
            get { return gols; }
            set { gols += value; }
        }

        public string getDescrição()
        {
            return "Nome: " + this.getnome() +
                "\t Idade: " + this.idade +
                "\t Habilidade: " + this.habilidade +
                "\t Camisa: " + this.camisa +
                "\t Gols: " + this.Gols;
        }


    }
}
