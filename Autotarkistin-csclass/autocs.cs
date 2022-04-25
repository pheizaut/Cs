public class autocs
{
    private string merkki;

    private string malli;

    private string vari;

    private int vuosi;

    private bool katsastettu;

    public autocs(
        string merkki,
        string malli,
        string vari,
        int vuosi,
        bool katsastettu
    )
    {
        this.merkki = merkki;
        this.malli = malli;
        this.vari = vari;
        this.vuosi = vuosi;
        this.katsastettu = katsastettu;
    }

    public string Merkki
    {
        set
        {
            merkki = value;
        }
        get
        {
            return merkki;
        }
    }

    public string Malli
    {
        set
        {
            malli = value;
        }
        get
        {
            return malli;
        }
    }

    public string Vari
    {
        set
        {
            vari = value;
        }
        get
        {
            return vari;
        }
    }

    public int Vuosi
    {
        set
        {
            vuosi = value;
        }
        get
        {
            return vuosi;
        }
    }

    public bool Katsastettu
    {
        set
        {
            katsastettu = value;
        }
        get
        {
            return katsastettu;
        }
    }

    public string uusivari(string uusivari)
    {
        vari = uusivari;
        return vari;
    }

    public bool katsastus()
    {
        return katsastettu = true;
    }

    public void tiedot()
    {
        Console.WriteLine(merkki + malli + vari + katsastettu);
    }
}
