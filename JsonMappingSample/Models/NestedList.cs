namespace JsonMappingSample.Models
{
    public class NestedListTop
    {
        public int Id { get; set; }
        public string TopLayerString { get; set; } = string.Empty;
        public List<NestedListNested> SecondLayersList { get; set; }
    }

    public class NestedListNested
    {
        public int Id { get; set; }
        public string SecondLayerString { get; set; } = string.Empty;
    }
}
