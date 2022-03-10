namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public class Wizard : Character
    {
        public Wizard(string Name, int Level, HeroType HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Wizard(){}
    }
}