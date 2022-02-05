namespace project_poo_gft.src.Entities
{
    public class PlayerTwo : Characters
    {               
        public PlayerTwo(string Name, int Level, string Class, string Especial)
            : base(Name, Level, Class)
        {
            this.Especial = Especial;
        }
        
        public string Especial;

		public override string Attack()
		{
			return this.Name + ", " + this.Class + ", " + this.Level + ": Atirou com seu rifle automático, ATTACK ESPECIAL: " + this.Especial;
		}

    }
}