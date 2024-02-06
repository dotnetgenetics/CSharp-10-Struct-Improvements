namespace StructImprovements
{
    /// <summary>
    /// Record Structs
    /// </summary>
    public record struct BeautyQueens
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public int Age { get; set; }
        public string Country { get; set; }

        public BeautyQueens()
        {
            Age = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Country = string.Empty;
        }
    }
}
