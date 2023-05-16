using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 1000f;
    [SerializeField] Rigidbody playerRigidbody;
    [SerializeField] float sideForce = 1000f;
    float direction = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forwardMovement = Vector3.forward * speed * Time.deltaTime;

        Vector3 sideMovement = new Vector3 (direction * sideForce * Time.deltaTime,0,0);

        playerRigidbody.AddForce(forwardMovement + sideMovement);

    }

    public void SideMovement(int value) 
    {
        direction = value;
    }
}
