namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public enum HeroType{
        Hero, Enemy
    }
    public class Character
    {
        public Character(string Name, int Level, HeroType HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Character() {
            this.Name = "";
            this.Level = 1;
            this.HeroType = HeroType.Hero;
            this.BaseMp = 10 + Level - 1;
            this.BaseHp = 10 + Level - 1;
            this.CurrentHp = this.BaseHp;
            this.CurrentMp = this.BaseMp;
            this.ExpToLevel = 5;
            this.CurrentExp = 0;
         }

        public string Name { get; set; }
        public int Level { get; set; }
        public HeroType HeroType { get; set; }
        public int ExpToLevel { get; set; }
        public int CurrentExp { get; set; }
        public int BaseHp { get; set; }
        public int CurrentHp { get; set; }
        public int BaseMp { get; set; }
        public int CurrentMp { get; set; }

        public void ShowStatus(){
            Console.WriteLine($@"
            Name: {this.Name}, Level: {this.Level}, Type: {this.HeroType}
            Hp: {this.CurrentHp}/{this.BaseHp} | Mp: {this.CurrentMp}/{this.BaseMp}
            Exp: {this.CurrentExp}/{this.ExpToLevel}
            ");
        }

        public virtual void Attack(Character target){
            Random random = new Random();
            int randomDamage = random.Next(1, 4);
            target.CurrentHp -= randomDamage;
            if(target.CurrentHp > 0){
                Console.WriteLine($"{this.Name} caused {randomDamage} damage on {target.Name}.");
                target.ShowStatus();
            }
            else if (target.CurrentHp <=0 ) {
                target.CurrentHp = 0;
                Console.WriteLine($"{this.Name} caused {randomDamage} damage on {target.Name}.");
                KillEnemy(target);
            }
        }

        public void GainExp(Character EnemyKilled){
            int ExpGained = EnemyKilled.Level * 5;
            this.CurrentExp += ExpGained;
            if(CurrentExp > ExpToLevel){
                LevelUp();
            } else {
                Console.WriteLine($"  You gained {ExpGained} \n  Exp: {CurrentExp}/{ExpToLevel}");
            }
        }

        public void LevelUp(){
            this.Level++;
            this.CurrentHp = this.BaseHp;
            this.CurrentExp = this.CurrentExp - this.ExpToLevel;
            this.ExpToLevel += Level*2; 
            Console.WriteLine($"Level Up! {Level}");
            ShowStatus();
        }

        public void KillEnemy(Character Enemy){
            Console.WriteLine($"{this.Name} killed {Enemy.Name}.");
        }
    }
}