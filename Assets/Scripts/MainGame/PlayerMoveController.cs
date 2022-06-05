using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    private Rigidbody playerRigidbody;

    public float Speed = 2f;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        playerRigidbody.AddForce(move * Speed);

        if(Input.GetKeyDown(KeyCode.Space)){
            playerRigidbody.AddForce(new Vector3(0,100,0));
        }
    }
}
