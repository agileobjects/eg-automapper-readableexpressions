﻿namespace AgileObjects.Examples.AutoMapperReadableExpressions.TestClasses
{
    using System;

    internal class Wedding
    {
        public DateTime Date { get; set; }

        public Person Bride { get; set; }

        public Person Groom { get; set; }
    }
}