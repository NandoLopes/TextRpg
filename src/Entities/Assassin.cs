namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public class Assassin : Character
    {
        public Assassin(string Name, int Level, HeroType HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Assassin(){}
    }
}