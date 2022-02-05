namespace project_poo_gft.src.Entities
{
    public class PlayerThree : Characters
    
    {
        public PlayerThree(string Name, int Level, string Class, int Type)
            : base( Name, Level, Class)
        {
            this.Type = Type;
        }

        public override string Attack()
		{
            if(this.Type == 1) 
            {
                return this.Name + ", " + this.Class + ", " + this.Level + ": Lançou um feitiço de magia branca";
            } 
            else 
            {
                return this.Name + ", " + this.Class + ", " + this.Level + ": Lançou um feitiço de magia negra";
            }

		}

        public int Type;

    }
}