
namespace GameTop
{
   public class JogoFODA
    {
        private readonly iJogador jogadorA;
        private readonly iJogador jogadorB;
            public JogoFODA(iJogador jogador1, iJogador jogador2)
            {
                jogadorA = jogador1;
                jogadorB = jogador2;
            }
      public void IniciarJogo()
      {
        System.Console.Write(jogadorA.Corre());
        System.Console.Write(jogadorA.Chuta());
        System.Console.Write(jogadorA.Passa());
        //
        System.Console.Write("\n Proximo jogador\n");
        //

        System.Console.Write(jogadorB.Corre());
        System.Console.Write(jogadorB.Chuta());
        System.Console.Write(jogadorB.Passa());
      
          
      }
       
    }
}