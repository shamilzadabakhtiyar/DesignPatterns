using DesignPatterns.BuilderPattern.Method1;

var eb = new EndpointBuilder("https://localhost");
eb
    .Append("api")
    .Append("v1")
    .Append("user")
    .AppendParam("id", "5")
    .AppendParam("username", "bakh");
var url = eb.Build();
//Console.WriteLine(url);

var empBuilder = new EmployeeBuilderM1();
var employee = empBuilder
    .SetFullname("Bakhtiyar Shamilzada")
    .SetUsername("bakhtiyar_shamilzada")
    .SetEmailAddress("bakhtiyarshamilzada@gmail.com")
    .Build();

Console.WriteLine(employee);