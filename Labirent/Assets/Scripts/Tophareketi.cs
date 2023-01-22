using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tophareketi : MonoBehaviour
{
    private Rigidbody rg;
    public float hiz = 100.0f;
    public UnityEngine.UI.Text zaman, can,durum;
    float zamansayaci = 300;
    int cansayaci = 50;
    bool oyundurumu = true;
    bool oyunbitti = false;
    public UnityEngine.UI.Button btn;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oyundurumu && !oyunbitti)
        {

            zamansayaci -= Time.deltaTime;
            zaman.text = (int)zamansayaci + "";
        }
        if (zamansayaci < 0)
        {
            oyundurumu = false;
            durum.text = "OYUN TAMAMLANAMADI";
            oyunbitti = true;
            btn.gameObject.SetActive(true);
        }


    }
    private void FixedUpdate()
    {
        if (oyundurumu ==true && oyunbitti==false)
        {
            float yatay = Input.GetAxis("Horizontal");
            float dikey = Input.GetAxis("Vertical");
            Vector3 kuvvet = new Vector3(dikey, 0, -yatay);
            rg.AddForce(kuvvet * hiz);
        }
        else
        {
            rg.velocity = Vector3.zero;
            rg.angularVelocity = Vector3.zero;
        }
    }
    private void OnCollisionEnter(Collision cls)
    {
        string objectismi = cls.gameObject.name;
        if (objectismi.Equals("Finish"))
        {
            durum.text = "OYUN TAMAMLANDI TEBRÝKLER";
            oyunbitti = true;
            btn.gameObject.SetActive(true);
        }
        else if (!objectismi.Equals("Zemin") && !objectismi.Equals("Labirent Zemini1") && !objectismi.Equals("Labirent Zemini2") && !objectismi.Equals("Labirent Zemini3") && !objectismi.Equals("Labirent Zemini"))
        {
            if (!oyunbitti)
            {
                if (oyundurumu)
                {
                    cansayaci -= 1;
                    can.text = cansayaci + "";
                }
                if (cansayaci == 0)
                {
                    oyundurumu = false;
                    durum.text = "OYUN TAMAMLANAMADI";
                    btn.gameObject.SetActive(true);
                }
            }

        }
     

    }
    
}
