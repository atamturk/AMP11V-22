namespace Uygulama1.Models
{
    public class DataModel
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DataModel(string Image , string Title, string Description) {

            this.Image = Image;            
            this.Title = Title;
            this.Description = Description;
        }



    }
}
