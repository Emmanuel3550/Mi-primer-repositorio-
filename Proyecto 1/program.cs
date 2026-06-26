using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

string nombre = configuration["Aplicacion:Nombre"]!;
int version = int.Parse(configuration["Aplicacion:Version"]!);

Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Versión: {version}");

var persona = new
{
    Nombre = "Emmanuel",
    Edad = 20,
    Pais = "Colombia"
};

string json = JsonConvert.SerializeObject(persona, Formatting.Indented);

Console.WriteLine();
Console.WriteLine(json);