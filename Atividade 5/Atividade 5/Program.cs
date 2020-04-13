
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Atividade_5

{

    class Program

    {

        static void Main(string[] args)

        {

            TIME1 time1 = new TIME1(" Palmeiras ");

            TIME1 time2 = new TIME1(" Santos ");
           
            TIME1 time3 = new TIME1(" Atletico ");

            TIME1 time4 = new TIME1(" Cruzeiro ");
          



            Partida1 p1 = new Partida1(DateTime.Now, time1, time2);

            p1.jogar();

            Console.WriteLine(p1.getplacar());



            Partida1 p2 = new Partida1(DateTime.Now, time3, time4);

            p2.jogar();

            Console.WriteLine(p2.getplacar());



            Partida1 p3 = new Partida1(DateTime.Now, time1, time3);

            p3.jogar();

            Console.WriteLine(p3.getplacar());



            Partida1 p4 = new Partida1(DateTime.Now, time2, time4);

            p4.jogar();

            Console.WriteLine(p4.getplacar());





            Console.WriteLine(time1.getStatus());

            time1.contratarJogador(new Jogador("Alex", 20, 20, 1));
            time1.contratarJogador(new Jogador("Pedro", 4, 9, 1));
            time1.contratarJogador(new Jogador("Carlos", 40, 99, 99));
            time1.contratarJogador(new Jogador("Alexander", 27, 79, 10));
            time1.contratarJogador(new Jogador("Guilherme", 39, 99, 18));
            time1.contratarJogador(new Jogador("Victor", 37, 69, 89));
            time1.contratarJogador(new Jogador("Luis", 29, 99, 99));
            time1.contratarJogador(new Jogador("neymar", 23, 95, 96));
            time1.contratarJogador(new Jogador("cris", 32, 99, 99));
            time1.contratarJogador(new Jogador("ze", 29, 99, 13));
            time1.contratarJogador(new Jogador("jose", 20, 99, 1));
            time1.getDescriçãojogadores();

            Console.WriteLine(time2.getStatus());

            time2.contratarJogador(new Jogador("carlao", 20, 40, 12));
            time2.contratarJogador(new Jogador("roberto", 22, 94, 14));
            time2.contratarJogador(new Jogador("Caio", 22, 32, 32));
            time2.contratarJogador(new Jogador("Alexander", 27, 99, 90));
            time2.contratarJogador(new Jogador("Guilherme", 32, 45, 32));
            time2.contratarJogador(new Jogador("Victor", 37, 69, 89));
            time2.contratarJogador(new Jogador("Luis", 19, 99, 99));
            time2.contratarJogador(new Jogador("messi", 29, 95, 96));
            time2.contratarJogador(new Jogador("cris ", 19, 99, 99));
            time2.contratarJogador(new Jogador("vicente", 39, 99, 13));
            time2.contratarJogador(new Jogador("jesse", 20, 99, 1));
            time2.getDescriçãojogadores();
            
            Console.WriteLine(time3.getStatus());
            time3.contratarJogador(new Jogador("vitao", 20, 40, 12));
            time3.contratarJogador(new Jogador("marlao", 32, 94, 14));
            time3.contratarJogador(new Jogador("Carlao", 22, 32, 32));
            time3.contratarJogador(new Jogador("Luisao", 27, 99, 90));
            time3.contratarJogador(new Jogador("Guizao", 32, 45, 32));
            time3.contratarJogador(new Jogador("Hugao", 37, 79, 89));
            time3.contratarJogador(new Jogador("Tiao", 23, 99, 99));
            time3.contratarJogador(new Jogador("Ze flor", 29, 95, 96));
            time3.contratarJogador(new Jogador("Ronaldao ", 919, 99, 99));
            time3.contratarJogador(new Jogador("vicentao", 32, 99, 13));
            time3.contratarJogador(new Jogador("ronaldo", 20, 99, 1));
            time3.getDescriçãojogadores();

            Console.WriteLine(time4.getStatus());
            time4.contratarJogador(new Jogador("cocielo", 32, 60, 32));
            time4.contratarJogador(new Jogador("Goku", 50, 99, 23));
            time4.contratarJogador(new Jogador("rato", 32, 32, 32));
            time4.contratarJogador(new Jogador("hulk", 27, 99, 90));
            time4.contratarJogador(new Jogador("starck", 32, 45, 32));
            time4.contratarJogador(new Jogador("thor", 37, 69, 89));
            time4.contratarJogador(new Jogador("V.negra", 39, 99, 99));
            time4.contratarJogador(new Jogador("h.formiga", 29, 95, 96));
            time4.contratarJogador(new Jogador("Visão ", 32, 99, 99));
            time4.contratarJogador(new Jogador("Batman", 25, 99, 10));
            time4.contratarJogador(new Jogador("Super man", 0, 99, 1));
            time4.getDescriçãojogadores() ;








            Console.ReadKey();

        }

    }

}