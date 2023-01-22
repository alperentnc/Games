using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyuncuscripti : MonoBehaviour
{
    public int oyuncusayýsý = 0;
    public UnityEngine.UI.Text oyuncu1, oyuncu2, oyuncu3, oyuncu4, oyuncu5, oyuncu6,oyuncuismi,oyuncuisiminfo;
    public UnityEngine.UI.InputField oyuncuadý;
    public UnityEngine.UI.Button tamam,oyuncueklebtn,oyunabasla;
    int z = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetString("oyuncu1", oyuncu1.text);
        PlayerPrefs.SetString("oyuncu2", oyuncu2.text);
        PlayerPrefs.SetString("oyuncu3", oyuncu3.text);
        PlayerPrefs.SetString("oyuncu4", oyuncu4.text);
        PlayerPrefs.SetString("oyuncu5", oyuncu5.text);
        PlayerPrefs.SetString("oyuncu6", oyuncu6.text);
        PlayerPrefs.SetInt("oyuncusayýsý", oyuncusayýsý);
        PlayerPrefs.SetInt("z", z);

    }
    public void oyuncuekle()
    {

            oyuncuadý.gameObject.SetActive(true);
            tamam.gameObject.SetActive(true);
            oyuncuisiminfo.gameObject.SetActive(true);
            oyuncuadý.text = "";
            oyunabasla.gameObject.SetActive(false);
            






    }
    public void tamambutonu()
    {
        if (oyuncuadý.text != "")
        {
            oyuncuismi.text = "";
            if (oyuncusayýsý == 0)
            {

                oyuncu1.text = oyuncuismi.text;
                oyuncu1.gameObject.SetActive(true);
                oyuncuadý.gameObject.SetActive(false);
                tamam.gameObject.SetActive(false);
                oyuncuisiminfo.gameObject.SetActive(false);
                oyuncusayýsý += 1;


            }
            else if (oyuncusayýsý == 1)
            {

                oyuncu2.text = oyuncuismi.text;
                oyuncu2.gameObject.SetActive(true);
                oyuncuadý.gameObject.SetActive(false);
                tamam.gameObject.SetActive(false);
                oyuncuisiminfo.gameObject.SetActive(false);
                oyuncusayýsý += 1;

            }
            else if (oyuncusayýsý == 2)
            {
                oyuncu3.text = oyuncuismi.text;
                oyuncu3.gameObject.SetActive(true);
                oyuncuadý.gameObject.SetActive(false);
                tamam.gameObject.SetActive(false);
                oyuncuisiminfo.gameObject.SetActive(false);
                oyuncusayýsý += 1;

            }
            else if (oyuncusayýsý == 3)
            {
                oyuncu4.text = oyuncuismi.text;
                oyuncu4.gameObject.SetActive(true);
                oyuncuadý.gameObject.SetActive(false);
                tamam.gameObject.SetActive(false);
                oyuncuisiminfo.gameObject.SetActive(false);
                oyuncusayýsý += 1;
                oyunabasla.gameObject.SetActive(true);

            }
            else if (oyuncusayýsý == 4)
            {
                oyuncu5.text = oyuncuismi.text;
                oyuncu5.gameObject.SetActive(true);
                oyuncuadý.gameObject.SetActive(false);
                tamam.gameObject.SetActive(false);
                oyuncuisiminfo.gameObject.SetActive(false);
                oyuncusayýsý += 1;
                oyunabasla.gameObject.SetActive(true);

            }
            else if (oyuncusayýsý == 5)
            {
                oyuncu6.text = oyuncuismi.text;
                oyuncu6.gameObject.SetActive(true);
                oyuncuadý.gameObject.SetActive(false);
                tamam.gameObject.SetActive(false);
                oyuncuisiminfo.gameObject.SetActive(false);
                oyuncusayýsý += 1;
                oyuncueklebtn.gameObject.SetActive(false);
                oyunabasla.gameObject.SetActive(true);

            }
        }


    }
    public void oyunkýsmýnagecis()
    {
        SceneManager.LoadScene("Oyunkýsmýmýz");
    }
}
