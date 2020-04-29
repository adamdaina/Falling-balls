using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] planets;
    private BoxCollider2D coll;
    float x1, x2;

    private void Awake()
    {
        coll = GetComponent<BoxCollider2D>();
        x1 = transform.position.x - coll.bounds.size.x / 2f;
        x2 = transform.position.x + coll.bounds.size.x / 2f;
    }

    void Start()
    {
        StartCoroutine(SpawnPlanet(0.5f));
    }

    IEnumerator SpawnPlanet(float time)
    {
        yield return new WaitForSecondsRealtime (time);

        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);

        Instantiate (planets[Random.Range(0, planets.Length)], temp, Quaternion.identity);
        StartCoroutine(SpawnPlanet(Random.Range(1f, 2f)));

    }
}













