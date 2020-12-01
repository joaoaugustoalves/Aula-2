using System;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancianado objeto

            Personagem jogador1 = new Personagem();
            jogador1.nome = "Tsukamoto";
            jogador1.idade = 32;
            jogador1.armadura = "Face-Shield";
            jogador1.iA = "Pure Skill";


             Personagem jogador2 = new Personagem(); 
            jogador2.nome = "Carlos";
            jogador2.idade = 35;
            jogador2.armadura = "MK3";


           Console.Clear(); 
           Console.WriteLine($"Partida {jogador1.nome} VS {jogador2.nome}");
           Console.WriteLine($"Jogador 1 Armadura: {jogador1.armadura} || Jogador 2 Armadura: {jogador2.armadura}");
           Console.WriteLine($"Jogador 1 IA: {jogador1.iA} || Jogador 2 IA: {jogador2.iA}");

           //Iniciando a luta


           int vidaDoJogador2 = jogador2.Defender(jogador2.Ataque1());

            if(vidaDoJogador2 <= 0){
                Console.WriteLine($"O jogador Morreu");
            }else{
               Console.WriteLine($"Jogador 2 depois do ataque ficou com {jogador2.vida}");
            }

        }
    }
}
