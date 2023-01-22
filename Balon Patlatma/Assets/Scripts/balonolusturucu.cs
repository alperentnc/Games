using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonolusturucu : MonoBehaviour
{
    float finalsayaci;
    oyunkontrolcu oks;
    public GameObject balon;
    float balonolusturmasuresi = 1f;
    float balonsayaci = 1f;
    // Start is called before the first frame update
    void Start()
    {
        oks = GameObject.Find("_scripts").GetComponent<oyunkontrolcu>();
    }

    // Update is called once per frame
    void Update()
    {
        if (oks.sayac1>=0)
        {
            balonsayaci -= Time.deltaTime;
            int katsayi = ((int)oks.sayac1 / 10) - 6;
            katsayi = katsayi * -1;
            if (balonsayaci < 0)
            {
                GameObject go = Instantiate(balon, new Vector3(Random.Range(-2.3f, 2.4f), -5.8f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
                go.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Random.Range(20f*katsayi, 60f*katsayi)));
                balonsayaci = balonolusturmasuresi;
            }

        }
    }
}
