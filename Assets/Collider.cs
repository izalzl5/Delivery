using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("NABRAK CIK");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("medak sesuatu");
    }
}
