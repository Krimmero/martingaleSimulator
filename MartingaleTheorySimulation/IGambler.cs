namespace MartingaleTheorySimulation
{
    public interface IGambler
    {
        void bet(Croupier croupier, int amount);
        void receiveCash(int amount);
    }
}