namespace Desafio.src.Entities
{
    public class Knight :Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int HPMax, int MP, int MPMax)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.HPMax = HPMax;
            this.MP = MP;
            this.MPMax = MPMax;
        }
    }
}