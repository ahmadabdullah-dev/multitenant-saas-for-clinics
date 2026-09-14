namespace Domain.Tenant;

public class TenantUser :  AppUser 
{
    public Guid TenantId { get; set; }
}
public class TenantRole : AppRole
{
    public Guid TenantId { get; set; }
}