namespace AgileObjects.Examples.AutoMapperReadableExpressions
{
    using System;
    using AutoMapper;
    using ReadableExpressions;
    using TestClasses;

    // You can also run this demo at https://dotnetfiddle.net/aJYTGZ!
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Wedding, WeddingDto>();
            });
            
            // This retrieves the execution plan Expression which can best be viewed
            // by installing the ReadableExpressions Debugger Visualizers from
            // https://marketplace.visualstudio.com/items?itemName=vs-publisher-1232914.ReadableExpressionsVisualizers,
            // mousing over the 'executionPlan' variable and clicking the magnifying glass:
            var executionPlan = configuration.BuildExecutionPlan(typeof(Wedding), typeof(WeddingDto));

            // This generates a string version of the execution
            // plan which can be viewed by mousing over the 'description'
            // variable and clicking the magnifying glass:
            var description = executionPlan.ToReadableString();

            Console.WriteLine(description);
            Console.ReadLine();
        }
    }
}
