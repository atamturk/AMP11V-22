namespace Uygulama1.Models
{
    public class OgrenciModel
    {

        public int Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ClassName { get; set; }

        public OgrenciModel(int Number, string Name, string Surname, string ClassName)
        {

            this.Number = Number;
            this.Name = Name;  
            this.Surname = Surname; 
            this.ClassName = ClassName;
        }
    }
}
