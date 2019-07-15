namespace zadanieRekrutacyjne
{
    public class Category
    {
        public Category(string Name,int Parentid, bool Visibility, int Ordering, string Description, string Picture)
        {
            name = Name;
            parent_id = Parentid;
            is_visibile = Visibility;
            orderding = Ordering;
            description = Description;
            picture_filename = Picture;
        }
        public string name { get; set; }
        public int parent_id { get; set; }
        public bool is_visibile { get; set; }
        public int orderding { get; set; }
        public string description { get; set; }
        public string picture_filename { get; set; }
    }
    public class CatJson
    {
        public Category category { get; set; }
    }
}
