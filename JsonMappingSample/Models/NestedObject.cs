namespace JsonMappingSample.Models
{
    public class NestedObjectModelTop
    {
        public int Id { get; set; }
        public string TopLayerString { get; set; } = string.Empty;
        public NestedObjectModelNested SecondLayer { get; set; } = new NestedObjectModelNested();
    }

    public class NestedObjectModelNested
    {
        public int Id { get; set; }
        public string SecondLayerString { get; set; } = string.Empty;
    }
}
