 namespace Desafio.src.Entities
{
    public  class Wizard :Hero
    {
         public Wizard(string Name, int Level, string HeroType, int HP, int HPMax, int MP, int MPMax)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.HPMax = HPMax;
            this.MP = MP;
            this.MPMax = MPMax;
        }
        public override string Attack()
        {
            return this.Name +  " Lançou magia";
        }

        public  string Attack(int bonus)
        {
            if(bonus > 6 )
            {
                return this.Name +  " Lançou magia super efetiva com bonus de " + bonus;
            }
            else{
                return this.Name +  " Lançou magia com força fraca com bonus de " + bonus;
            }

            
        }
    }
}