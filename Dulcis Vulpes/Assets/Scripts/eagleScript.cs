using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagleScript : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 startpos;
    float x;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(7, -1);
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(-2f, 3f);
        if (transform.position.x >= startpos.x+7)
        {
            rb.velocity = new Vector2(-5, x);
            startpos = transform.position;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else if (transform.position.x <= startpos.x - 7)
        {
            rb.velocity = new Vector2(5, x);
            startpos = transform.position;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (GameObject.Find("player").GetComponent<playerMovement>().gameOverBool == true)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
