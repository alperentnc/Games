using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secim : MonoBehaviour
{
    public UnityEngine.UI.Text oyuncuad� ,info;
    public UnityEngine.UI.Button tas, kagit, makas, onayla,s�f�rlabuton;
    int a = 0,b=0,z,secensayi,secilensayi;
    // Start is called before the first frame update
    void Start()
    {
        oyuncuad�.text = PlayerPrefs.GetString("sorulankisi");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sifirlayici()
    {
        a = 0;
    }
    public void tass()
    {
        a = 1;
    }
    public void kagitt()
    {
        a = 2;
    }
    public void makass()
    {
        a = 3;
    }
    public void onaylatkm()
    {
        if (a != 0)
        {
            if (b == 0)
            {
                secensayi = a;
                oyuncuad�.text = PlayerPrefs.GetString("secilenkisi");
                b++;
                a = 0;
            }
            else if (b == 1)
            {
                b++;
                secilensayi = a;
                a = 0;
                if (secensayi == secilensayi)
                {
                    tas.gameObject.SetActive(false);
                    kagit.gameObject.SetActive(false);
                    makas.gameObject.SetActive(false);
                    oyuncuad�.gameObject.SetActive(false);
                    info.gameObject.SetActive(true);
                    info.text = PlayerPrefs.GetString("sorankisi") + " " + "kaybetmedi�i i�in soru a��klanmayacak.";
                    

                }
                else if ((secensayi == 1 && secilensayi == 3) || (secensayi == 2 && secilensayi == 1) || (secensayi == 3 && secilensayi == 2))
                {
                    tas.gameObject.SetActive(false);
                    kagit.gameObject.SetActive(false);
                    makas.gameObject.SetActive(false);
                    oyuncuad�.gameObject.SetActive(false);
                    info.gameObject.SetActive(true);
                    info.text = PlayerPrefs.GetString("sorulankisi") + " " + "kaybetmedi�i i�in soru a��klanmayacak.";
                }
                else
                {
                    tas.gameObject.SetActive(false);
                    kagit.gameObject.SetActive(false);
                    makas.gameObject.SetActive(false);
                    oyuncuad�.gameObject.SetActive(false);
                    info.gameObject.SetActive(true);
                    info.text = "Soru A��kland�: " + PlayerPrefs.GetString("sorulacaksoru");
                }

            }
        

        }
        else if (b==2)
        {
            SceneManager.LoadScene("oyunk�sm�m�z");
            z = PlayerPrefs.GetInt("z");
            z++;
            PlayerPrefs.SetInt("z", z);

        }
    }
}
