using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algoritmer.CourseSchedulers
{
    public static class CourseScheduler
    {
        public static void Calculate(IConsole console)
        {
            int n = int.Parse(console.ReadLine());

            var courses = new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < n; i++)
            {
                string line = console.ReadLine();
                string course = line.Substring(line.LastIndexOf(' ') + 1);
                
                if (courses.TryGetValue(course, out HashSet<string> hashSet))
                {
                    hashSet.Add(line);
                }
                else
                {
                    courses.Add(course, new HashSet<string> { line });
                    
                }
            }

            foreach ((string key, HashSet<string> value) in courses.OrderBy(c => c.Key))
            {
                console.WriteLine(string.Join(' ', key, value.Count.ToString()));
            }
        }

    }
    
    
}
