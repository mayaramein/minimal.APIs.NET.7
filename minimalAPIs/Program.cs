#region DI
using FluentValidation;
using minimalAPIs;

var builder = WebApplication.CreateBuilder(args);

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(MappingConfig));
builder.Services.AddSwaggerGen();
builder.Services.AddValidatorsFromAssemblyContaining<Program>();

#endregion


#region Middelware

var app = builder.Build();
app.UseHttpsRedirection();
app.Run();

#endregion