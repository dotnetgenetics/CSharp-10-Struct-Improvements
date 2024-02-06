namespace StructImprovements
{
    public struct Student
    {
        public string City { get; init; }

        /// <summary>
        /// Parameterless struct constructor
        /// </summary>
        public Student()
        {
            City = "Cebu City"; //default
        }
    }
}
