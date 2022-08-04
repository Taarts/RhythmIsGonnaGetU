using System.Collections.Generic;


namespace RhythmIsGonnaGetU

{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public int NumberOfMembers { get; set; }
        public string Website { get; set; }
        public string Style { get; set; }
        public bool IsSigned { get; set; }
        public string ContactName { get; set; }
        public string ContactPhoneNumber { get; set; }


        // one to many relationship from Band to Songs & Albums
        public List<Album> Albums { get; set; }
        // public object Album { get; internal set; }
    }
}