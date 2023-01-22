using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class baslangic : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEngine.UI.Button oyna;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gecis()
    {
        SceneManager.LoadScene("oynanis");
    }
}
