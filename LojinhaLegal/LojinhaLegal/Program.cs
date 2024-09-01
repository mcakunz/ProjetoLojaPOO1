using Microsoft.EntityFrameworkCore;
using LojinhaLegal.Models; // Certifique-se de usar o namespace correto

var builder = WebApplication.CreateBuilder(args);

// Configurar a conex�o com o banco de dados MySQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21))));

// Adicionar servi�os ao cont�iner.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configurar o pipeline de requisi��es HTTP.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
