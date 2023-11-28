using System;

namespace Muhasebe;
public interface KodAdAckDrm
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}

public interface OKod
{
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
}