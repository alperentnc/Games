using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackopsScript : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("player").GetComponent<playerMovement>().gameOverBool == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
