using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunkontrolcu : MonoBehaviour
{
    public UnityEngine.UI.Text sayac, balonsayisi,bitti;
    public float sayac1= 60;
    int patlayanbalon = 0;
    public GameObject patlama;
    public UnityEngine.UI.Button yenidenoyna;
    // Start is called before the first frame update
    void Start()
    {
        sayac.text = "Zaman : " + (int)sayac1;

    }

    // Update is called once per frame
    void Update()
    {
        if (sayac1> 0)
        {
            sayac1-= Time.deltaTime;
            sayac.text = "Zaman : " + (int)sayac1;
        }
        else
        {
            GameObject[] gos = GameObject.FindGameObjectsWithTag("balon");
            for(int i=0; i < gos.Length;i++)
            {
                Destroy(gos[i]);
                Instantiate(patlama, gos[i].transform.position, gos[i].transform.rotation);
                bitti.text = "Oyun Bitti Skorunuz : " + patlayanbalon;
                yenidenoyna.gameObject.SetActive(true);
            }
        }
    }
    public void balonekle()
    {
        patlayanbalon += 1;
        balonsayisi.text = "Balon : " + patlayanbalon;
    }
}
