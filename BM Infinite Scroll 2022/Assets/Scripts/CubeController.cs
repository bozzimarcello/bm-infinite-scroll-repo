using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        Debug.Log("Collisione contro: " + other.gameObject.name);
    }
}
