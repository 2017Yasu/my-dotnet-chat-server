namespace Chat.Domain.Status;

public class StatusModel
{
    private StatusEntity _source;

    public StatusModel(Statuses s) : this(s, null)
    {
    }

    public StatusModel(Statuses s, string? m)
    {
        _source = new StatusEntity
        {
            Status = s,
            Message = m,
        };
    }

    public StatusEntity ToEntity()
    {
        return (StatusEntity)_source.Clone();
    }

    public static StatusModel OkStatus()
    {
        return new StatusModel(Statuses.Ok);
    }
}
