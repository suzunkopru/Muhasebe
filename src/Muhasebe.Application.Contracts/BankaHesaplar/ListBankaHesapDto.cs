namespace Muhasebe.BankaHesaplar;
public class ListBankaHesapDto : EntityDto<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public BankaHesapTuru HesapTuru { get; set; }
    public string HesapTuruAdi { get; set; }
    public string HesapNo { get; set; }
    public string IbanNo { get; set; }
    public string BankaAdi { get; set; }
    public string BankaSubeAdi { get; set; }
    public string OzelKod1Adi { get; set; }
    public string OzelKod2Adi { get; set; }
    public decimal Borc { get; set; }
    public decimal Alacak { get; set; }
    private decimal _bakiye => Borc - Alacak;
    public decimal BorcBakiye => _bakiye > 0 ? _bakiye : 0;
    public decimal AlacakBakiye => _bakiye < 0 ? Math.Abs(_bakiye) : 0;
    public string Aciklama { get; set; }
    //public ICollection<SelectMakbuzHareketDto> MakbuzHareketler { get; set; }
}