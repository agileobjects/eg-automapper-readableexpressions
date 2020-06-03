namespace AgileObjects.Examples.AutoMapperReadableExpressions.TestClasses
{
    using System;

    internal class WeddingDto
    {
        public DateTime Date { get; set; }

        public string BrideTitle { get; set; }

        public string BrideName { get; set; }

        public string BrideAddressLine1 { get; set; }
        
        public string BrideAddressLine2 { get; set; }

        public string GroomTitle { get; set; }

        public string GroomName { get; set; }

        public string GroomAddressLine1 { get; set; }

        public string GroomAddressLine2 { get; set; }
    }
}