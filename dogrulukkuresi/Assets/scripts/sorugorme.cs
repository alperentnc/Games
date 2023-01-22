using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sorugorme : MonoBehaviour
{
    public UnityEngine.UI.Text sorulankisi, sorulansoru, buton1txt, buton2txt, buton3txt, buton4txt, buton5txt,secilenkisi;
    public UnityEngine.UI.Button buton1,buton2,buton3,buton4,buton5,soruyugor;
    int oyuncusayýsý;
    string ilksoran;
    // Start is called before the first frame update
    void Start()
    {
        ilksoran = PlayerPrefs.GetString("sorankisi");
        sorulankisi.text = PlayerPrefs.GetString("sorulankisi");
        sorulansoru.text = PlayerPrefs.GetString("sorulacaksoru");
        if (sorulankisi.text == PlayerPrefs.GetString("oyuncu1"))
        {
            buton1txt.text = PlayerPrefs.GetString("oyuncu2");
            buton2txt.text = PlayerPrefs.GetString("oyuncu3");
            buton3txt.text = PlayerPrefs.GetString("oyuncu4");
            buton4txt.text = PlayerPrefs.GetString("oyuncu5");
            buton5txt.text = PlayerPrefs.GetString("oyuncu6");
        }
        else if (sorulankisi.text == PlayerPrefs.GetString("oyuncu2"))
        {
            buton1txt.text = PlayerPrefs.GetString("oyuncu1");
            buton2txt.text = PlayerPrefs.GetString("oyuncu3");
            buton3txt.text = PlayerPrefs.GetString("oyuncu4");
            buton4txt.text = PlayerPrefs.GetString("oyuncu5");
            buton5txt.text = PlayerPrefs.GetString("oyuncu6");
        }
        else if (sorulankisi.text == PlayerPrefs.GetString("oyuncu3"))
        {
            buton1txt.text = PlayerPrefs.GetString("oyuncu1");
            buton2txt.text = PlayerPrefs.GetString("oyuncu2");
            buton3txt.text = PlayerPrefs.GetString("oyuncu4");
            buton4txt.text = PlayerPrefs.GetString("oyuncu5");
            buton5txt.text = PlayerPrefs.GetString("oyuncu6");
        }
        else if (sorulankisi.text == PlayerPrefs.GetString("oyuncu4"))
        {
            buton1txt.text = PlayerPrefs.GetString("oyuncu1");
            buton2txt.text = PlayerPrefs.GetString("oyuncu2");
            buton3txt.text = PlayerPrefs.GetString("oyuncu3");
            buton4txt.text = PlayerPrefs.GetString("oyuncu5");
            buton5txt.text = PlayerPrefs.GetString("oyuncu6");
        }
        else if (sorulankisi.text == PlayerPrefs.GetString("oyuncu5"))
        {
            buton1txt.text = PlayerPrefs.GetString("oyuncu1");
            buton2txt.text = PlayerPrefs.GetString("oyuncu2");
            buton3txt.text = PlayerPrefs.GetString("oyuncu3");
            buton4txt.text = PlayerPrefs.GetString("oyuncu4");
            buton5txt.text = PlayerPrefs.GetString("oyuncu6");
        }
        else if (sorulankisi.text == PlayerPrefs.GetString("oyuncu6"))
        {
            buton1txt.text = PlayerPrefs.GetString("oyuncu1");
            buton2txt.text = PlayerPrefs.GetString("oyuncu2");
            buton3txt.text = PlayerPrefs.GetString("oyuncu3");
            buton4txt.text = PlayerPrefs.GetString("oyuncu4");
            buton5txt.text = PlayerPrefs.GetString("oyuncu5");
        }
    }

    // Update is called once per frame
    void Update()
    {

        

    }
   public void soruyugorme()
    {
        soruyugor.gameObject.SetActive(false);
        sorulansoru.gameObject.SetActive(true);
        int oyuncusayýsý = PlayerPrefs.GetInt("oyuncusayýsý");
        if (oyuncusayýsý == 4)
        {
            if (ilksoran != buton1txt.text) { buton1.gameObject.SetActive(true); }
            if (ilksoran != buton2txt.text) { buton2.gameObject.SetActive(true); }
            if (ilksoran != buton3txt.text) { buton3.gameObject.SetActive(true); }
        }
        else if (oyuncusayýsý == 5)
        {
            if (ilksoran != buton1txt.text) { buton1.gameObject.SetActive(true); }
            if (ilksoran != buton2txt.text) { buton2.gameObject.SetActive(true); }
            if (ilksoran != buton3txt.text) { buton3.gameObject.SetActive(true); }
            if (ilksoran != buton4txt.text) { buton4.gameObject.SetActive(true); }
        }
        else if (oyuncusayýsý == 6)
        {
            if (ilksoran != buton1txt.text) { buton1.gameObject.SetActive(true); }
            if (ilksoran != buton2txt.text) { buton2.gameObject.SetActive(true); }
            if (ilksoran != buton3txt.text) { buton3.gameObject.SetActive(true); }
            if (ilksoran != buton4txt.text) { buton4.gameObject.SetActive(true); }
            if (ilksoran != buton5txt.text) { buton5.gameObject.SetActive(true); }
        }


    }
    public void buton1in()
    {
        secilenkisi.text = buton1txt.text;
        PlayerPrefs.SetString("secilenkisi", (string)secilenkisi.text);
        SceneManager.LoadScene("vs");
    }
    public void buton2in()
    {
        secilenkisi.text = buton2txt.text;
        PlayerPrefs.SetString("secilenkisi", (string)secilenkisi.text);
        SceneManager.LoadScene("vs");
    }
    public void buton3in()
    {
        secilenkisi.text = buton3txt.text;
        PlayerPrefs.SetString("secilenkisi", (string)secilenkisi.text);
        SceneManager.LoadScene("vs");
    }
    public void buton4in()
    {
        secilenkisi.text = buton4txt.text;
        PlayerPrefs.SetString("secilenkisi", (string)secilenkisi.text);
        SceneManager.LoadScene("vs");
    }
    public void buton5in()
    {
        secilenkisi.text = buton5txt.text;
        PlayerPrefs.SetString("secilenkisi", (string)secilenkisi.text);
        SceneManager.LoadScene("vs");

    }
}
