using System;
using System.IO;
using System.Linq;
using Tababular;

namespace AnugComp
{
    class Program
    {
        static void Main()
        {
            var formatter = new TableFormatter(new Hints { CollapseVerticallyWhenSingleLine = true, MaxTableWidth = 120 });

            var objects = File.ReadAllText("Serverless_computing_-_the_most_fluffy_cloud.xls")
                .Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .Select(line => line.Split('\t'))
                .Select((cells, index) => new
                {
                    Name = cells[0],
                    Title = cells[2],
                    Host = cells[3],
                    Profile = cells[8],
                    n = index + 1
                });

            Console.WriteLine(formatter.FormatObjects(objects));
        }
    }
}
