using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vsekrani : MonoBehaviour
{

    public UnityEngine.UI.Text sorulan, secilen;
    public UnityEngine.UI.Button sec;
    // Start is called before the first frame update
    void Start()
    {
        sorulan.text = PlayerPrefs.GetString("sorulankisi");
        secilen.text = PlayerPrefs.GetString("secilenkisi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void secim()
    {
        SceneManager.LoadScene("tkm");
    }
}
