using TesteEFCore;

var ctx = new TestContext();

var users = ctx.Usuario.ToList();

Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(users));
