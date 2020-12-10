using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "teste chuta \n";
        }

        public string Corre()
        {
            return "teste corre \n";
        }

        public string Passe()
        {
            return "teste passe \n";
        }
    }
}