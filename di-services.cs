/* DI Services
  Map Model Class with  appsettings.json in ASP.NET
*/

var service = builder.Configuration.GetSection("ValuesFromAppSettings.json").Get<Model>();
builder.Services.AddSingleton(service);

// Example of "ValuesFromAppSettings.json"
"EmailSettings": {
    "From": "mymail@gmail.com",
    "SmtpServer": "smtp.gmail.com",
    "Port": 465,
    "Username": "mymail@gmail.com",
    "Password": "my password"
  }

// Example of Model

public class EmailSettings
{
    public string From { get; set; }
    public string SmtpServer { get; set; }
    public int Port { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
