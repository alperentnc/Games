using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonkontrolcu : MonoBehaviour { 
    oyunkontrolcu oks;


    // Start is called before the first frame update
    void Start()
    {
        oks = GameObject.Find("_scripts").GetComponent<oyunkontrolcu>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject patlama;
    void OnMouseDown()
    {
        GameObject go=Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.333f);
        oks.balonekle();

    }
}
