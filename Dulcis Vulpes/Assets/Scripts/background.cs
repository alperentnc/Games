using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public Transform cameraTransform;
    SpriteRenderer spriteRendererToChangeColor;
    Color colorr;
    float colorCounter;
     // Start is called before the first frame update
    void Start()
    {
        spriteRendererToChangeColor = GetComponent<SpriteRenderer>();
        colorCounter = 255;
    }

    // Update is called once per frame
    void Update()
    {
        if (colorCounter >= 0)
        {
            colorCounter -= Time.deltaTime * 2;
            spriteRendererToChangeColor.color = (Color)(new Color32(255, (byte)colorCounter, (byte)colorCounter, 255));
        }
        else
        {
            colorr = new Color(255, 0, 0, 255);
            spriteRendererToChangeColor.color = (Color)(new Color32(255, 0, 0, 255));
        }
    }
    private void FixedUpdate()
    {
        transform.position = new Vector3(cameraTransform.position.x, 0.5f, -9);
        
    }
}
