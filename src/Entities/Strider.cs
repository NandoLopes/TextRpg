namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public class Strider : Character
    {
        public Strider(string Name, int Level, HeroType HeroType, int BaseHp, int BaseMp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.BaseHp = this.CurrentHp = BaseHp;
            this.BaseMp = this.CurrentMp = BaseMp;
        }

        public Strider(){}
    }
}