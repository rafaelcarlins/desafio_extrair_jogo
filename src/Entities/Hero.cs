namespace Desafio.src.Entities
{
    public class Hero
    {
        public string? Name{get; set;}
        
        public int Level{get; set;}
        
        public string? HeroType{get; set;}
        public int HP { get; set; }
        
        public int HPMax { get; set; }
        
        public int MP { get; set; }
        
        public int MPMax { get; set; }
        public Hero(string Name, int Level, string HeroType, int HP, int HPMax, int MP, int MPMax)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.HPMax = HPMax;
            this.MP = MP;
            this.MPMax = MPMax;
        }
        public Hero()
        {
            
        }
        public override string ToString()
        {
            return " Nome:" + this.Name  + " " + " Nível:" + this.Level + " Classe:" + this.HeroType
            + " HP:" + this.HP + "/"  + this.HPMax + " MP:" + this.MP +"/" + this.MPMax;
        }
        public virtual string Attack()
        {
            return this.Name +  " Atacou com sua espada";
        }
    }
}