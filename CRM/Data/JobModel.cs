namespace CRM.Data;

public class JobModel
{
    public int Id { get; set; }
    public JobStatuses Status { get; set; }
    public string? Description { get; set; }
}

