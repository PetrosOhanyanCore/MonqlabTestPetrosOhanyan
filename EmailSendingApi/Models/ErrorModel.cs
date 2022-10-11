using System.Text.Json;

namespace EmailSendingApi.Models;

public class ErrorModel
{
    /// <summary>
    /// Error model status code
    /// </summary>
    public int StatusCode { get; set; }

    /// <summary>
    /// Error message
    /// </summary>
    public string Message { get; set; }

    public override string ToString() => JsonSerializer.Serialize(this);
}