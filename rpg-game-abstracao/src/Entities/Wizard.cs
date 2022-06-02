namespace RPGame.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " lançou uma bola de Magia"; 
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou uma bola de Magia efetiva com bônus de " + Bonus; 
            } else 
            {
                return this.Name + " lançou uma bola de Magia fraca com um bônus de " + Bonus; 
            }

        }
    }
}