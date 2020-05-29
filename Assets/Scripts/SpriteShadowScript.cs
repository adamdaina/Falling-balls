using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteShadowScript : MonoBehaviour
{
    public Vector2 offset = new Vector2(-3, -3);

    private SpriteRenderer sprtrndcaster;
    private SpriteRenderer sprtrndshadow;
    private Transform transcaster;
    private Transform transshadow;

    void Start()
    {
        transcaster = transform;
        transshadow = new GameObject().transform;
        transshadow.parent = transcaster;
        transshadow.gameObject.name = "Shadow";
        transshadow.localRotation = Quaternion.identity;

        sprtrndcaster = GetComponent<SpriteRenderer>();
        sprtrndshadow = transshadow.gameObject.AddComponent<SpriteRenderer>();

        sprtrndshadow.sortingLayerName = sprtrndcaster.sortingLayerName;
        sprtrndshadow.sortingOrder = sprtrndcaster.sortingOrder - 1;

    }

    private void LateUpdate()
    {
        transshadow.position = new Vector2(transcaster.position.x + offset.x, transcaster.position.y + offset.y);

        sprtrndshadow.sprite = sprtrndcaster.sprite;
    }


}
