namespace Muhasebe.Kasalar;
public class ListKasaDto : EntityDto<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string OzelKod1Adi { get; set; }
    public string OzelKod2Adi { get; set; }
    public decimal Borc { get; set; }
    public decimal Alacak { get; set; }
    private decimal _bakiye => Borc - Alacak;
    public decimal BorcBakiye => _bakiye > 0 ? _bakiye : 0;
    public decimal AlacakBakiye => _bakiye < 0 ? Math.Abs(_bakiye) : 0;
    public string Aciklama { get; set; }
}