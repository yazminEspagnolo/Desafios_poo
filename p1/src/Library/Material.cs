namespace Ucu.Poo.Defense
{
    public class Material 
    {
        public string Name { get; set; }

        public MaterialType Type { get; set; }

        public Material(string name, MaterialType type)
        {
            this.Name = name;
            this.Type = type;
        }

        // el material es peligroso si el tipo de material el peligroso.
        public bool IsDangerous()
        {
            return this.Type.IsDangerous; // Si el tipo de material es peligroso, el material es peligroso.
        }
    }
}