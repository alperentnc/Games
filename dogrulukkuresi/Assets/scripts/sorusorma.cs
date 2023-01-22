using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sorusorma : MonoBehaviour
{
    public UnityEngine.UI.Text soracak, buton1txt, buton2txt, buton3txt, buton4txt, buton5txt,sorulankisi;
    public UnityEngine.UI.Button buton1, buton2, buton3, buton4, buton5;
    public UnityEngine.UI.InputField sorulacaksoru;
    string secilenkisi;
    int z = 0;
    oyuncuscripti oyuncuveri;
    void Start()
    {
        sorulacaksoru.lineType = UnityEngine.UI.InputField.LineType.MultiLineNewline;
        oyuncuveri = GameObject.Find("_scripts").GetComponent<oyuncuscripti>();
        int x = PlayerPrefs.GetInt("oyuncusayýsý");
        int randomsayi = Random.Range(0,x);
        z=PlayerPrefs.GetInt("z");
        print(z);
        if (z != 0)
        {
            secilenkisi = PlayerPrefs.GetString("secilenkisi");
        }
        print(secilenkisi);
        if (x == 4)
        {
            buton1.gameObject.SetActive(true);
            buton2.gameObject.SetActive(true);
            buton3.gameObject.SetActive(true);
        }
        else if (x == 5)
        {
            buton1.gameObject.SetActive(true);
            buton2.gameObject.SetActive(true);
            buton3.gameObject.SetActive(true);
            buton4.gameObject.SetActive(true);

        }
        else
        {
            buton1.gameObject.SetActive(true);
            buton2.gameObject.SetActive(true);
            buton3.gameObject.SetActive(true);
            buton4.gameObject.SetActive(true);
            buton5.gameObject.SetActive(true);
        }
        if (z==0)
        {
            if (randomsayi == 0)
            {
                soracak.text = PlayerPrefs.GetString("oyuncu1");
                buton1txt.text = PlayerPrefs.GetString("oyuncu2");
                buton2txt.text = PlayerPrefs.GetString("oyuncu3");
                buton3txt.text = PlayerPrefs.GetString("oyuncu4");
                buton4txt.text = PlayerPrefs.GetString("oyuncu5");
                buton5txt.text = PlayerPrefs.GetString("oyuncu6");
            }
            else if (randomsayi == 1)
            {
                soracak.text = PlayerPrefs.GetString("oyuncu2");
                buton1txt.text = PlayerPrefs.GetString("oyuncu1");
                buton2txt.text = PlayerPrefs.GetString("oyuncu3");
                buton3txt.text = PlayerPrefs.GetString("oyuncu4");
                buton4txt.text = PlayerPrefs.GetString("oyuncu5");
                buton5txt.text = PlayerPrefs.GetString("oyuncu6");
            }
            else if (randomsayi == 2)
            {
                soracak.text = PlayerPrefs.GetString("oyuncu3");
                buton1txt.text = PlayerPrefs.GetString("oyuncu1");
                buton2txt.text = PlayerPrefs.GetString("oyuncu2");
                buton3txt.text = PlayerPrefs.GetString("oyuncu4");
                buton4txt.text = PlayerPrefs.GetString("oyuncu5");
                buton5txt.text = PlayerPrefs.GetString("oyuncu6");
            }
            else if (randomsayi == 3)
            {
                soracak.text = PlayerPrefs.GetString("oyuncu4");
                buton1txt.text = PlayerPrefs.GetString("oyuncu1");
                buton2txt.text = PlayerPrefs.GetString("oyuncu2");
                buton3txt.text = PlayerPrefs.GetString("oyuncu3");
                buton4txt.text = PlayerPrefs.GetString("oyuncu5");
                buton5txt.text = PlayerPrefs.GetString("oyuncu6");
            }
            else if (randomsayi == 4)
            {
                soracak.text = PlayerPrefs.GetString("oyuncu5");
                buton1txt.text = PlayerPrefs.GetString("oyuncu1");
                buton2txt.text = PlayerPrefs.GetString("oyuncu2");
                buton3txt.text = PlayerPrefs.GetString("oyuncu3");
                buton4txt.text = PlayerPrefs.GetString("oyuncu4");
                buton5txt.text = PlayerPrefs.GetString("oyuncu6");
            }
            else
            {
                soracak.text = PlayerPrefs.GetString("oyuncu6");
                buton1txt.text = PlayerPrefs.GetString("oyuncu1");
                buton2txt.text = PlayerPrefs.GetString("oyuncu2");
                buton3txt.text = PlayerPrefs.GetString("oyuncu3");
                buton4txt.text = PlayerPrefs.GetString("oyuncu4");
                buton5txt.text = PlayerPrefs.GetString("oyuncu5");
            }
        }
        else
        {
            if (secilenkisi == PlayerPrefs.GetString("oyuncu1"))
            {
                soracak.text = PlayerPrefs.GetString("oyuncu1");
                buton1txt.text = PlayerPrefs.GetString("oyuncu2");
                buton2txt.text = PlayerPrefs.GetString("oyuncu3");
                buton3txt.text = PlayerPrefs.GetString("oyuncu4");
                buton4txt.text = PlayerPrefs.GetString("oyuncu5");
                buton5txt.text = PlayerPrefs.GetString("oyuncu6");
            }
            else if (secilenkisi == PlayerPrefs.GetString("oyuncu2"))
            {
                soracak.text = PlayerPrefs.GetString("oyuncu2");
                buton1txt.text = PlayerPrefs.GetString("oyuncu1");
                buton2txt.text = PlayerPrefs.GetString("oyuncu3");
                buton3txt.text = PlayerPrefs.GetString("oyuncu4");
                buton4txt.text = PlayerPrefs.GetString("oyuncu5");
                buton5txt.text = PlayerPrefs.GetString("oyuncu6");
            }
            else if (secilenkisi == PlayerPrefs.GetString("oyuncu3"))
            {
                soracak.text = PlayerPrefs.GetString("oyuncu3");
                buton1txt.text = PlayerPrefs.GetString("oyuncu1");
                buton2txt.text = PlayerPrefs.GetString("oyuncu2");
                buton3txt.text = PlayerPrefs.GetString("oyuncu4");
                buton4txt.text = PlayerPrefs.GetString("oyuncu5");
                buton5txt.text = PlayerPrefs.GetString("oyuncu6");
            }
            else if (secilenkisi == PlayerPrefs.GetString("oyuncu4"))
            {
                soracak.text = PlayerPrefs.GetString("oyuncu4");
                buton1txt.text = PlayerPrefs.GetString("oyuncu1");
                buton2txt.text = PlayerPrefs.GetString("oyuncu2");
                buton3txt.text = PlayerPrefs.GetString("oyuncu3");
                buton4txt.text = PlayerPrefs.GetString("oyuncu5");
                buton5txt.text = PlayerPrefs.GetString("oyuncu6");
            }
            else if (secilenkisi == PlayerPrefs.GetString("oyuncu5"))
            {
                soracak.text = PlayerPrefs.GetString("oyuncu5");
                buton1txt.text = PlayerPrefs.GetString("oyuncu1");
                buton2txt.text = PlayerPrefs.GetString("oyuncu2");
                buton3txt.text = PlayerPrefs.GetString("oyuncu3");
                buton4txt.text = PlayerPrefs.GetString("oyuncu4");
                buton5txt.text = PlayerPrefs.GetString("oyuncu6");
            }
            else
            {
                soracak.text = PlayerPrefs.GetString("oyuncu6");
                buton1txt.text = PlayerPrefs.GetString("oyuncu1");
                buton2txt.text = PlayerPrefs.GetString("oyuncu2");
                buton3txt.text = PlayerPrefs.GetString("oyuncu3");
                buton4txt.text = PlayerPrefs.GetString("oyuncu4");
                buton5txt.text = PlayerPrefs.GetString("oyuncu5");
            }
        }
    }

        //for (int i = 0; i <= oyuncuveri.oyuncusayýsý; i++)

    // Update is called once per frame
    void Update()
    {

    }
    public void buton1týkla()
    {
        if (sorulacaksoru.text != "")
        {
            sorulankisi.text = buton1txt.text;
            PlayerPrefs.SetString("sorulankisi", sorulankisi.text);
            PlayerPrefs.SetString("sorankisi", soracak.text);
            PlayerPrefs.SetString("sorulacaksoru", sorulacaksoru.text);
            SceneManager.LoadScene("sorugorme");
        }


    }
    public void buton2týkla()
    {
        if (sorulacaksoru.text != "")
        {
            sorulankisi.text = buton2txt.text;
            PlayerPrefs.SetString("sorulankisi", sorulankisi.text);
            PlayerPrefs.SetString("sorankisi", soracak.text);
            PlayerPrefs.SetString("sorulacaksoru", sorulacaksoru.text);
            SceneManager.LoadScene("sorugorme");
        }


    }
    public void buton3týkla()
    {
        if (sorulacaksoru.text != "")
        {
            sorulankisi.text = buton3txt.text;
            PlayerPrefs.SetString("sorulankisi", sorulankisi.text);
            PlayerPrefs.SetString("sorankisi", soracak.text);
            PlayerPrefs.SetString("sorulacaksoru", sorulacaksoru.text);
            SceneManager.LoadScene("sorugorme");
        }

    }
    public void buton4týkla()
    {
        if (sorulacaksoru.text != "")
        {
            sorulankisi.text = buton4txt.text;
            PlayerPrefs.SetString("sorulankisi", sorulankisi.text);
            PlayerPrefs.SetString("sorankisi", soracak.text);
            PlayerPrefs.SetString("sorulacaksoru", sorulacaksoru.text);
            SceneManager.LoadScene("sorugorme");
        }


    }
    public void buton5týkla()
    {
        if (sorulacaksoru.text != "")
        {
            sorulankisi.text = buton5txt.text;
            PlayerPrefs.SetString("sorulankisi", sorulankisi.text);
            PlayerPrefs.SetString("sorankisi", soracak.text);
            PlayerPrefs.SetString("sorulacaksoru", sorulacaksoru.text);
            SceneManager.LoadScene("sorugorme");
        }

    }

}
