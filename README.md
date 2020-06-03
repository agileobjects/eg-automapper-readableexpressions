# Viewing Automapper Execution Plans with ReadableExpressions

This repo demonstrates how to use ReadableExpressions to view AutoMapper execution plans. An execution 
plan shows how AutoMapper will perform a mapping from a source to a destination type.

Run the console app, mouse over the populated `description` variable and click the magnifying glass to 
view AutoMapper's execution plan for the `WeddingDto` -> `Wedding` unflattening mapping. You can also 
see the same mapping plan in the output of [this DotNetFiddle](https://dotnetfiddle.net/aJYTGZ)!

For a colourized, themeable view with various translation options, install the 
[ReadableExpressions Debugger Visualizers](https://marketplace.visualstudio.com/items?itemName=vs-publisher-1232914.ReadableExpressionsVisualizers),
mouse over the populated `executionPlan` variable and click the magnifying glass for full technicolour!
