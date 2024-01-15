var builder = WebApplication.CreateBuilder(args);

// Service (Container)
builder.Services.AddControllers(); //api controllerlarý görsün diye bunu yapýyoruz...
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Swagger'i api'ye tanýtýyoruz.


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers(); // controllerin gördü ama tanýmasý için bu kod bloðunu kullanýyoruz.

app.Run();
