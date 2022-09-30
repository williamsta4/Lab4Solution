//using FileIO;
using ClassLibrary;

var root = FileRoot.fileRoot;
char dirSep = Path.DirectorySeparatorChar;
var file = root + dirSep + "Data" + dirSep + "data.csv";
var newFile = root + dirSep + "Data" + dirSep + "data.psv";
var people = new List<Person>();

Address address = new Address();

using (var sr = new StreamReader(file))
{
    while(!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        var info = line.Split(",");

        var FirstName = info[0];
        var LastName = info[1];
        var Address = info[2];

        people.Add(new Person(FirstName, LastName, Address));
    }
}

people.Sort();

Console.WriteLine("Creating PSV File ;)");
using (var sw = new StreamWriter(newFile, append: false))
{
    foreach (Person p in people)
    {
        // interpolated string
        string line = $"{p.FirstName}|{p.LastName}|{p.Address}|";
        sw.WriteLine(line);
    }
}


