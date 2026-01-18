# Serialization and Deserialization

### Why do we need Serialization and Deserialization?
1. Data Persistence
- Save state: Store application state (e.g., user sessions, game progress) to disk or database.
- Example: Serialize an object to a file for later reuse.

2. Network Communication
- Transmit data: Send objects over networks (APIs, messaging, RPCs) as bytes.
- Example: A client sends a JSON-serialized request to a server, which deserializes it into an object.

3. Interoperability
- Cross-platform/language exchange: Convert data to universal formats (JSON, XML, Protocol Buffers).
- Example: A dotnet server sends JSON to a JavaScript frontend.

### What is Serialization and Deserialization?

> Serialization and deserialization bridge the gap between runtime objects and storable/transmittable data, enabling persistence, communication, and interoperability across systems regardless of the programming language.

### How to Serialize and Deserialize?

> In ASP.NET Core Web API, serialization (converting objects to data formats like JSON/XML) and deserialization (converting those formats back to objects) are handled automatically for you. This process is performed by media-type formatters when reading request bodies and writing response bodies. The format is determined by the Accept and Content-Type HTTP headers.

- For JSON formats we use `System.Text.Json` library

**Controller example**
```csharp
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpPost]
    // This action can accept JSON (default) or XML if configured
    public IActionResult CreateProduct([FromBody] Product newProduct)
    {
        // 'newProduct' is automatically deserialized from the request body
        // ... save to database, process logic ...
        // The returned object is automatically serialized to the client's requested format (JSON/XML)
        return Ok(newProduct);
    }
}
```

**Optional configuration for custom formatting**
- JSON
```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        // Property names will be camelCase in JSON
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        // Null properties will be omitted from the JSON output
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });
``` 

- XML
```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers()
    .AddXmlSerializerFormatters(); // Enables XML input and output
```