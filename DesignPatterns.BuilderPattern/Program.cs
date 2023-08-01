using DesignPatterns.BuilderPattern.Method1;
using DesignPatterns.BuilderPattern.Method2;

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

//Console.WriteLine(employee);

IEmployeeBuilderM2 employeeBuilderM2 = new InternalEmployeeBuilder();
employeeBuilderM2.SetEmailAddress("bakhtiyarshamilzada@gmail.com");
var emp = employeeBuilderM2.Build();
Console.WriteLine(emp.EmailAddress);