using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chainScript : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
        rb.velocity = new Vector2(25, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= startPos.x + 7)
        {
            rb.velocity = new Vector2(-25, -3);
        }
        else if (transform.position.x <= startPos.x - 7)
        {
            rb.velocity = new Vector2(25, 3);
        }
        if (GameObject.Find("player").GetComponent<playerMovement>().gameOverBool == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
