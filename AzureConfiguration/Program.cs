using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var appconfigUrl = builder.Configuration.GetValue<string>("AzureAppConfigUrl");

builder.Host.ConfigureAppConfiguration(builder =>
            {
                //Connect to your App Config Store using the connection string
                builder.AddAzureAppConfiguration(options =>
                {
                    var credential = new DefaultAzureCredential();
                    options.Connect(new Uri(appconfigUrl), credential);
                });
            })
            .ConfigureServices(services =>
            {
                services.AddControllersWithViews();
            });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
