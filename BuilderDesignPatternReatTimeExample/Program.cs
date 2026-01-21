// See https://aka.ms/new-console-template for more information
using BuilderDesignPatternReatTimeExample.HttpRequestMessageRTE.Builder;
using BuilderDesignPatternReatTimeExample.StringBuilderRTE.Builder;
using System.Text;

Console.WriteLine("Hello, World!");

var constructor = new StringConstructor();
constructor.AppendLine("Hello, Builder pattern!")
    .AppendWords("This", "is", "a", "custom", "string")
    .AppendLine("It's effecient");

var costomStr = constructor.Build();

Console.WriteLine(costomStr);

Console.ReadKey();

var request = new HttpRequestBuilder()
                .WithMethod(HttpMethod.Get)
                .WithUri(new Uri("https://jsonplaceholder.typicode.com/posts"))
                .WithContent(new StringContent("{\"name\":\"sampleItem\"}", Encoding.UTF8, "application/json"))
                .WithHeader("Authorization", "Bearer my_token")
                .Build();
// You can now use this request with HttpClient to send the actual request.
using (var client = new HttpClient())
{
    var response = client.SendAsync(request).Result;
    Console.WriteLine(response.StatusCode);
}

Console.ReadKey();