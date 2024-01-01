namespace Muhasebe.Cariler;
public class ListCariDto : EntityDto<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string VergiDairesi { get; set; }
    public string VergiNo { get; set; }
    public string Telefon { get; set; }
    public string Adres { get; set; }
    public string OzelKod1Adi { get; set; }
    public string OzelKod2Adi { get; set; }
    public decimal Borc { get; set; }
    public decimal Alacak { get; set; }
    private decimal _bakiye => Borc - Alacak;
    public decimal BorcBakiye => _bakiye > 0 ? _bakiye : 0;
    public decimal AlacakBakiye => _bakiye < 0 ? Math.Abs(_bakiye) : 0;
    public string Aciklama { get; set; }
    //public ICollection<SelectFaturaDto> Faturalar { get; set; }
    //public ICollection<SelectMakbuzDto> Makbuzlar { get; set; }
}