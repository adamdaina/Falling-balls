using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBounds : MonoBehaviour
{

    private float maxX;
    private float minX;

    void Start()
    {
        Vector3 coorn = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        maxX = coorn.x - 1.0f;
        minX = -coorn.x + 1.0f; 
    }


    void Update()
    {
        Vector3 temp = transform.position;
        if (temp.x > maxX)
            temp.x = maxX;

        if (temp.x < minX)
            temp.x = minX;

        transform.position = temp;
    }
}

