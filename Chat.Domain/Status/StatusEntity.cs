using System.Text.Json.Serialization;

namespace Chat.Domain.Status;

public class StatusEntity : ICloneable
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public virtual Statuses Status { get; set; } = Statuses.Undefined;
    public virtual string? Message { get; set; }

    public object Clone()
    {
        return new StatusEntity()
        {
            Status = this.Status,
            Message = this.Message,
        };
    }
}
