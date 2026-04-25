using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipaScript : MonoBehaviour
{
    float nilaiRandom;
    void Start()
    {
        nilaiRandom = Random.Range(-2.03f, 2f);
        transform.position = new Vector2(transform.position.x, nilaiRandom);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 100,Time.deltaTime * 5);
    }
}