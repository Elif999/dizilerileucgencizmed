
/*                                     - Eriþim belirleyiceleri Notlarý---unutma ençok kullanýlan eriþim belirleyicieri public, private ve protecte bunlar yeterli
: Form burada kalýttýmý yaptýn yoksa böylemiydi zaten-                                                                                 
   
copiolot-Windows Forms uygulamasýnda bir form sýnýfý (örneðin, MainForm) Form sýnýfýndan türetilmiþtir.
Yani, MainForm sýnýfý Form sýnýfýný kalýtým yoluyla geniþletir.
Form sýnýfý, Windows Forms API'sinin bir parçasýdýr ve tüm Windows formlarýnýn temelini oluþturur.
Kalýtým iþlemi, MainForm sýnýfýnýn Form sýnýfýndaki tüm özelliklere ve metodlara eriþmesine ve bunlarý kullanmasýna olanak tanýr.

Aþaðýdaki kod parçasýnda MainForm sýnýfýnýn Form sýnýfýndan kalýtýldýðý açýkça görülmektedir:


public partial class MainForm : Form//bu satýrda kalýtým yapýlmýþtýr***
{
    // Public eriþim belirleyicisi
    public string PublicMesaj = "Bu public bir mesajdýr.";

    // Private eriþim belirleyicisi
    private string PrivateMesaj = "Bu private bir mesajdýr.";

    // Protected eriþim belirleyicisi
    protected string ProtectedMesaj = "Bu protected bir mesajdýr.";

    // Internal eriþim belirleyicisi
    internal string InternalMesaj = "Bu internal bir mesajdýr.";

    // Protected Internal eriþim belirleyicisi
    protected internal string ProtectedInternalMesaj = "Bu protected internal bir mesajdýr.";

    public MainForm()
    {
        InitializeComponent();
    }

    private void btnGoster_Click(object sender, EventArgs e)
    {
        // Eriþim belirleyicileri kullanýlarak mesajlar gösterilir
        MessageBox.Show(PublicMesaj);        // Her yerden eriþilebilir
        MessageBox.Show(PrivateMesaj);       // Sadece bu sýnýf içinden eriþilebilir
        MessageBox.Show(ProtectedMesaj);     // Bu sýnýf ve türetilmiþ sýnýflardan eriþilebilir
        MessageBox.Show(InternalMesaj);      // Ayný derleme içinden eriþilebilir
        MessageBox.Show(ProtectedInternalMesaj); // Ayný derleme ve türetilmiþ sýnýflardan eriþilebilir
    }
}
Bu kodda MainForm sýnýfý Form sýnýfýndan türetilmiþtir (Form'u kalýtým yoluyla geniþletmiþtir). Bu sayede MainForm sýnýfý, 
Form sýnýfýnýn tüm özelliklerine ve yöntemlerine sahiptir ve onlarý kullanabilir.
Kýsacasý, MainForm sýnýfý Form sýnýfýný kalýtýr ve bu, MainForm sýnýfýnýn Windows Forms uygulamasýndaki temel form sýnýfýný geniþletmesine olanak tanýr.

 3 yýldýzla iþaretlediðim satýrda kalýtým yapýlmýþtýr.
: Form burada kalýttýmý yaptýn yoksa böylemiydi zaten-                                                                                 
   
copiolot-Windows Forms uygulamasýnda bir form sýnýfý (örneðin, MainForm) Form sýnýfýndan türetilmiþtir.
Yani, MainForm sýnýfý Form sýnýfýný kalýtým yoluyla geniþletir.
Form sýnýfý, Windows Forms API'sinin bir parçasýdýr ve tüm Windows formlarýnýn temelini oluþturur.
Kalýtým iþlemi, MainForm sýnýfýnýn Form sýnýfýndaki tüm özelliklere ve metodlara eriþmesine ve bunlarý kullanmasýna olanak tanýr.

Aþaðýdaki kod parçasýnda MainForm sýnýfýnýn Form sýnýfýndan kalýtýldýðý açýkça görülmektedir:
public partial class MainForm : Form//bu satýrda kalýtým yapýlmýþtýr
{
    // Public eriþim belirleyicisi
    public string PublicMesaj = "Bu public bir mesajdýr.";

    // Private eriþim belirleyicisi
    private string PrivateMesaj = "Bu private bir mesajdýr.";

    // Protected eriþim belirleyicisi
    protected string ProtectedMesaj = "Bu protected bir mesajdýr.";

    // Internal eriþim belirleyicisi
    internal string InternalMesaj = "Bu internal bir mesajdýr.";

    // Protected Internal eriþim belirleyicisi
    protected internal string ProtectedInternalMesaj = "Bu protected internal bir mesajdýr.";

    public MainForm()
    {
        InitializeComponent();
    }

    private void btnGoster_Click(object sender, EventArgs e)
    {
        // Eriþim belirleyicileri kullanýlarak mesajlar gösterilir
        MessageBox.Show(PublicMesaj);        // Her yerden eriþilebilir
        MessageBox.Show(PrivateMesaj);       // Sadece bu sýnýf içinden eriþilebilir
        MessageBox.Show(ProtectedMesaj);     // Bu sýnýf ve türetilmiþ sýnýflardan eriþilebilir
        MessageBox.Show(InternalMesaj);      // Ayný derleme içinden eriþilebilir
        MessageBox.Show(ProtectedInternalMesaj); // Ayný derleme ve türetilmiþ sýnýflardan eriþilebilir
    }
}
Bu kodda MainForm sýnýfý Form sýnýfýndan türetilmiþtir (Form'u kalýtým yoluyla geniþletmiþtir).
Bu sayede MainForm sýnýfý, Form sýnýfýnýn tüm özelliklerine ve yöntemlerine sahiptir ve onlarý kullanabilir.
Kýsacasý, MainForm sýnýfý Form sýnýfýný kalýtýr ve bu, MainForm sýnýfýnýn Windows Forms uygulamasýndaki temel form sýnýfýný geniþletmesine olanak tanýr.
 */

//________________________________________________________________________________________________________________________________________________________________________________________













//__________________________________________________________________________________________________________________________________________________________________________________________


















//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



















//______________________________________________________________________________________________________________________________________________________________________________________________


                                                            /*KAPSÜLLEME(ENCAPSOLÝTON)*/

    /*
    aþaðýdaki bu kodda kapsülleme yapýlmýþtýr:
    __________________________________________________________________________________
    public class Hayvan
    {
    private string isim; // Kapsülleme ile gizlenmiþ özellik
    public string Isim
    {
        get { return isim; } // Özelliðin deðeri alýndýðýnda isim döner
        set { isim = value; } // Özelliðe bir deðer atandýðýnda isim güncellenir
    }
    __________________________________________________________________________________
Kapsülleme Notlarý:
1. Kapsülleme Nedir?
Kapsülleme, nesne yönelimli programlamada(OOP) 
bir nesnenin verilerini  (özelliklerini) ve bu verilere eriþim yöntemlerini (metotlarýný) 
bir arada tutarak dýþarýdan eriþimi kontrol etme tekniðidir.
Kapsülleme, veri gizleme ve kontrollü eriþim saðlar.

2. Veri Gizleme
Veri Gizleme, bir nesnenin iç durumunu (verilerini) dýþarýdan gizleyerek, 
yalnýzca belirli bir arayüz (özellikler ve metotlar) üzerinden eriþim saðlanmasýný ifade eder.
private olarak tanýmlanan alanlar, yalnýzca tanýmlandýðý sýnýf içinde eriþilebilir. 
Dýþarýdan doðrudan eriþim mümkün deðildir.

3. Özellikler (Properties)
Özellikler, bir sýnýfýn dýþarýdan eriþilebilen bir arayüzüdür.
public olarak tanýmlanan özellikler, dýþarýdan eriþime açýktýr.
get ve set bloklarý ile birlikte kullanýlarak, verilerin okunmasý ve yazýlmasý kontrol edilir.

4. Örnek
public class Hayvan
{
    private string isim; // Kapsülleme ile gizlenmiþ özellik

    public string Isim
    {
        get { return isim; } // Özelliðin deðeri alýndýðýnda isim döner
        set { isim = value; } // Özelliðe bir deðer atandýðýnda isim güncellenir
    }
}
private string isim;: Bu alan, dýþarýdan doðrudan eriþilemez.
public string Isim: Bu özellik, dýþarýdan eriþim saðlar. get ve set bloklarý ile veri kontrol edilir.

5. Kapsülleme ile Eriþim
Kapsülleme sayesinde, bir nesnenin iç verileri dýþarýdan eriþime kapatýlýr.
Dýþarýdan eriþim, public özellikler aracýlýðýyla saðlanýr. Bu, veri gizleme ve kontrol saðlar.

6. Kapsüllemenin Faydalarý
Veri Güvenliði: Dýþarýdan gelen istenmeyen eriþimleri engeller.
Kontrollü Eriþim: Verilerin nasýl okunacaðýný ve yazýlacaðýný kontrol etme imkaný sunar.
Modülerlik: Kodun daha düzenli ve anlaþýlýr olmasýna yardýmcý olur.
Bakým Kolaylýðý: Ýç yapýyý deðiþtirmek, dýþarýdaki kodu etkilemeden yapýlabilir.

7.Diðer Sýnýflardan Eriþim***Önemli
private string isim; alaný doðrudan eriþilemez, ancak public string Isim özelliði aracýlýðýyla bu alana eriþim saðlanabilir.
Bu yapý, kapsülleme ilkesinin bir parçasýdýr ve veri gizleme ile kontrollü eriþim saðlar.

Sonuç
Kapsülleme, nesne yönelimli programlamanýn temel prensiplerinden biridir 
ve yazýlým geliþtirmede veri güvenliðini ve bütünlüðünü saðlamak için önemlidir.
     
     */

   

/*                                       
                                     
Kapsülleme Yapýlan Kýsýmlar:

private string isim;:
Bu satýr, Hayvan sýnýfýnýn içinde tanýmlanan isim alanýný temsil eder. 
private anahtar kelimesi, bu alanýn yalnýzca Hayvan sýnýfý içinde eriþilebilir olduðunu belirtir.
Dýþarýdan (örneðin, baþka bir sýnýftan) bu alana doðrudan eriþim mümkün deðildir. 
Bu, veri gizleme saðlar ve nesnenin iç durumunu korur.

private string isim; // Kapsülleme ile gizlenmiþ özellik
public string Isim Özelliði:
Isim özelliði, public olarak tanýmlanmýþtýr. Bu, dýþarýdan eriþime açýk olduðu anlamýna gelir.
get ve set bloklarý, isim alanýna eriþimi kontrol eder:
get { return isim; }: Bu blok, Isim özelliði okunduðunda isim alanýnýn deðerini döndürür.
Dýþarýdan bu özelliðe eriþildiðinde, isim alanýnýn deðeri okunabilir.
set { isim = value; }: Bu blok, Isim özelliðine bir deðer atandýðýnda, bu deðeri isim alanýna kaydeder.
Dýþarýdan bu özelliðe bir deðer atandýðýnda, isim alaný güncellenir.

private string isim; // Kapsülleme ile gizlenmiþ özellik
public string Isim
{
    get { return isim; } // Özelliðin deðeri alýndýðýnda isim döner
    set { isim = value; } // Özelliðe bir deðer atandýðýnda isim güncellenir
}

Miyavla Metodu:
Kedi sýnýfýndaki Miyavla metodu, Isim özelliðini kullanarak kedinin ismini alýr.
Burada Isim özelliði, Hayvan sýnýfýndaki isim alanýna eriþim saðlar.
Bu, kapsülleme ilkesinin bir parçasýdýr çünkü isim alaný doðrudan eriþilemez, 
Ancak Isim özelliði aracýlýðýyla eriþilebilir.

public void Miyavla()
{
    MessageBox.Show($"{Isim} miyavlýyor."); // Üst sýnýftan devralýnan özellik
}
Özet
Kapsülleme: private string isim; ifadesi ile baþlar. Bu, isim alanýnýn dýþarýdan eriþimini engeller.
Eriþim Kontrolü: public string Isim özelliði, dýþarýdan eriþim saðlar. get ve set bloklarý, isim alanýna eriþimi kontrol eder.
Veri Gizleme: isim alaný doðrudan eriþilemez, ancak Isim özelliði aracýlýðýyla eriþilebilir. Bu, veri gizleme ve kontrol saðlar.
***********************************************************************************************************************************
//kodlar;
public class Hayvan
{
    private string isim; // Kapsülleme ile gizlenmiþ özellik

    public string Isim
    {
        get { return isim; } // Özelliðin deðeri alýndýðýnda isim döner
        set { isim = value; } // Özelliðe bir deðer atandýðýnda isim güncellenir
    }

    public void SesCikar()
    {
        Console.WriteLine("Hayvan ses çýkarýyor.");
    }
}

public class Kedi : Hayvan
{
    public void Miyavla()
    {
        MessageBox.Show($"{Isim} miyavlýyor."); // Üst sýnýftan devralýnan özellik
    }
}
//Kodun Mantýðý;
Kapsülleme Notlarý:
1. Kapsülleme Nedir?
Kapsülleme, nesne yönelimli programlamada (OOP) bir nesnenin verilerini (özelliklerini) ve
bu verilere eriþim yöntemlerini (metotlarýný) bir arada tutarak dýþarýdan eriþimi kontrol etme tekniðidir.
Kapsülleme, veri gizleme ve kontrollü eriþim saðlar.

2. Veri Gizleme
Veri Gizleme, bir nesnenin iç durumunu (verilerini) dýþarýdan gizleyerek,
yalnýzca belirli bir arayüz (özellikler ve metotlar) üzerinden eriþim saðlanmasýný ifade eder.
private olarak tanýmlanan alanlar, yalnýzca tanýmlandýðý sýnýf içinde eriþilebilir. 
Dýþarýdan doðrudan eriþim mümkün deðildir.

3. Özellikler (Properties)
Özellikler, bir sýnýfýn dýþarýdan eriþilebilen bir arayüzüdür.
public olarak tanýmlanan özellikler, dýþarýdan eriþime açýktýr.
get ve set bloklarý ile birlikte kullanýlarak, verilerin okunmasý ve yazýlmasý kontrol edilir.

4. Örnek
public class Hayvan
{
    private string isim; // Kapsülleme ile gizlenmiþ özellik

    public string Isim
    {
        get { return isim; } // Özelliðin deðeri alýndýðýnda isim döner
        set { isim = value; } // Özelliðe bir deðer atandýðýnda isim güncellenir
    }
}
private string isim;: Bu alan, dýþarýdan doðrudan eriþilemez.
public string Isim: Bu özellik, dýþarýdan eriþim saðlar. get ve set bloklarý ile veri kontrol edilir.

5. Kapsülleme ile Eriþim
Kapsülleme sayesinde, bir nesnenin iç verileri dýþarýdan eriþime kapatýlýr.
Dýþarýdan eriþim, public özellikler aracýlýðýyla saðlanýr. Bu, veri gizleme ve kontrol saðlar.

6. Kapsüllemenin Faydalarý
Veri Güvenliði: Dýþarýdan gelen istenmeyen eriþimleri engeller.
Kontrollü Eriþim: Verilerin nasýl okunacaðýný ve yazýlacaðýný kontrol etme imkaný sunar.
Modülerlik: Kodun daha düzenli ve anlaþýlýr olmasýna yardýmcý olur.
Bakým Kolaylýðý: Ýç yapýyý deðiþtirmek, dýþarýdaki kodu etkilemeden yapýlabilir.

7. Diðer Sýnýflardan Eriþim//**bu kýsmý önemli
private string isim; alaný doðrudan eriþilemez, ancak public string Isim özelliði aracýlýðýyla bu alana eriþim saðlanabilir.
Bu yapý, kapsülleme ilkesinin bir parçasýdýr ve veri gizleme ile kontrollü eriþim saðlar.
*/