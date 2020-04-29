using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassMove : MonoBehaviour
{
    private Vector3 posA;

    private Vector3 posB;

    private Vector3 posC;

    private Vector3 nextPos;

    private Vector3 nextPos_2;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform childTransform;

    [SerializeField]
    private Transform transform_B;

    [SerializeField]
    private Transform transform_C;

    void Start()
    {
        posA = childTransform.localPosition;
        posB = transform_B.localPosition;
        posC = transform_C.localPosition;
        nextPos = posB;
        nextPos_2 = posC;
    }

   
    void Update()
    {
        move();
    }

    private void move()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nextPos, speed * Time.deltaTime);

        //transform_B.localPosition = Vector3.MoveTowards(transform_B.localPosition, nextPos_2, speed * Time.deltaTime);
    }

}
