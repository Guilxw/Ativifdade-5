using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_5
{
    class Partida1
    {

        /*Atributos*/
        private DateTime data;
        private TIME1 timecasa;
        private TIME1 timevisitante;
        private int placarcasa;
        private int placarvisitante;

        /*construtor*/
        public Partida1(DateTime dataPartida, TIME1 Tcasa, TIME1 Tvisitante)
        {
            this.data = dataPartida;
            this.timecasa = Tcasa;
            this.timevisitante = Tvisitante;
            this.placarcasa = 0;
            this.placarvisitante = 0;
        }

        /* metodos*/

        public int golcasa()
        {
            return placarcasa++;
        }

        public int golvisitante()
        {
            return placarvisitante++;
        }

        public string getplacar()
        {
            if (this.placarcasa > this.placarvisitante)
            {
                this.timecasa.Vitorias = 1;
                this.timevisitante.Derrotas = 1;
                return "O vencendor da partidade em " + this.data.ToString("dd-MM-yyyy") +
                   "entre" + this.timecasa.Nome +
                   "x" + this.timevisitante.Nome +
                   "foi o time" + this.timecasa.Nome +
                   "com o placar de " + this.placarcasa.ToString() +
                   "a" + this.placarvisitante.ToString() + ".";
            }

            if (this.placarcasa == this.placarvisitante)
            {
                this.timecasa.Empate = 1;
                this.timevisitante.Empate = 1;
                return "A partida ficou empatada em" + this.data.ToString("dd-MM-yyyy") +
                    "entre" + this.timecasa.Nome +
                    "x" + this.timevisitante.Nome +
                    "com o placar de " + this.placarcasa.ToString() + "x" + this.placarvisitante.ToString() + ".";
            }

            else
            {
                this.timecasa.Vitorias = 0;
                this.timevisitante.Derrotas = 1;
                return "O vencendor da partidade em " + this.data.ToString("dd-MM-yyyy") +
                   "entre" + this.timecasa.Nome +
                   "x" + this.timevisitante.Nome +
                   "foi o time" + this.timevisitante.Nome +
                   "com o placar de " + this.placarvisitante.ToString() +
                   "a" + this.placarcasa.ToString() + ".";
            }


        }

        public void jogar()

        {

            Random rand = new Random();

            Int32 numeroDeGols = rand.Next(0, 15);



            for (int i = 1; i <= numeroDeGols; i++)

            {

                Int32 golDoTime = rand.Next(0, 2);

                if (golDoTime == 1)

                    this.golcasa();

                else

                    this.golvisitante();

            }
        }
    }
}
