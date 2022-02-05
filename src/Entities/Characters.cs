namespace project_poo_gft.src.Entities
{
    public class Characters
    {
        public Characters(string Name, int Level, string Class)

        {
            this.Name = Name;
            this.Level = Level;
            this.Class = Class;
        }

        public string Name;
        public int Level;
        public string Class;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Class;
        }

        public virtual string Attack() 
        {
            return this.Name + ", " + this.Class + ", " + this.Level + ":  Atacou com a sua espada longa";
        }

        public string Attack(string pesado) 
        {
            return this.Name + ", " + this.Class + ", " + this.Level + ": Atirou com o seu rifle automático " + pesado;
        }
    }
}