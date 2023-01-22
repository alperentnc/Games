using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dortislem : MonoBehaviour
{
    public UnityEngine.UI.Text ilksayi;
    public UnityEngine.UI.Text islemisareti;
    public UnityEngine.UI.Text ikincisayi;
    public UnityEngine.UI.Text sonuc;
    public UnityEngine.UI.Text dogruluk;
    int sayi1, sayi2, islem, islemsonucu;
    public UnityEngine.UI.InputField sonucinput;
    // Start is called before the first frame update
    void Start()
    {
        yenisoru();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void sonuckontrol()
    {
        if (int.Parse(sonuc.text) == islemsonucu)
        {
            dogruluk.text = "DOGRU";
        }
        else if (int.Parse(sonuc.text) != islemsonucu)
        {
            dogruluk.text = "YANLIS";
        }

    }
    public void yenisoru() {
        sonucinput.text = "";
        dogruluk.text = "";
        sayi1 = Random.Range(1, 10);
        sayi2 = Random.Range(1, 10);
        islem = Random.Range(1, 5);
        switch (islem)
        {
            case 1:
                islemisareti.text = "+";
                islemsonucu = sayi1 + sayi2;
                break;
            case 2:
                islemisareti.text = "-";
                islemsonucu = sayi1 - sayi2;
                break;
            case 3:
                islemisareti.text = "*";
                islemsonucu = sayi1 * sayi2;
                break;
            case 4:
                islemisareti.text = "/";
                islemsonucu = sayi1 / sayi2;
                break;
        }
        ilksayi.text = sayi1 + "";
        ikincisayi.text = sayi2 + "";
    } 
}
