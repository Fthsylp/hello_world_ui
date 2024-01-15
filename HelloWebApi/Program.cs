var builder = WebApplication.CreateBuilder(args);

// Service (Container)
builder.Services.AddControllers(); //api controllerlar� g�rs�n diye bunu yap�yoruz...
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Swagger'i api'ye tan�t�yoruz.


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers(); // controllerin g�rd� ama tan�mas� i�in bu kod blo�unu kullan�yoruz.

app.Run();
