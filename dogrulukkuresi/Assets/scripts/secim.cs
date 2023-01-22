using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secim : MonoBehaviour
{
    public UnityEngine.UI.Text oyuncuadý ,info;
    public UnityEngine.UI.Button tas, kagit, makas, onayla,sýfýrlabuton;
    int a = 0,b=0,z,secensayi,secilensayi;
    // Start is called before the first frame update
    void Start()
    {
        oyuncuadý.text = PlayerPrefs.GetString("sorulankisi");


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
                oyuncuadý.text = PlayerPrefs.GetString("secilenkisi");
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
                    oyuncuadý.gameObject.SetActive(false);
                    info.gameObject.SetActive(true);
                    info.text = PlayerPrefs.GetString("sorankisi") + " " + "kaybetmediði için soru açýklanmayacak.";
                    

                }
                else if ((secensayi == 1 && secilensayi == 3) || (secensayi == 2 && secilensayi == 1) || (secensayi == 3 && secilensayi == 2))
                {
                    tas.gameObject.SetActive(false);
                    kagit.gameObject.SetActive(false);
                    makas.gameObject.SetActive(false);
                    oyuncuadý.gameObject.SetActive(false);
                    info.gameObject.SetActive(true);
                    info.text = PlayerPrefs.GetString("sorulankisi") + " " + "kaybetmediði için soru açýklanmayacak.";
                }
                else
                {
                    tas.gameObject.SetActive(false);
                    kagit.gameObject.SetActive(false);
                    makas.gameObject.SetActive(false);
                    oyuncuadý.gameObject.SetActive(false);
                    info.gameObject.SetActive(true);
                    info.text = "Soru Açýklandý: " + PlayerPrefs.GetString("sorulacaksoru");
                }

            }
        

        }
        else if (b==2)
        {
            SceneManager.LoadScene("oyunkýsmýmýz");
            z = PlayerPrefs.GetInt("z");
            z++;
            PlayerPrefs.SetInt("z", z);

        }
    }
}
