﻿namespace Muhasebe.Depolar;
public class DepoCodeParameterDto : IDurum, IEntityDto
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}