﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Mirror;

public class PlayerControler : NetworkBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 0.2f;
    public float moveRotation = 20;
 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
                 if (isLocalPlayer)
        {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * moveSpeed);
            transform.Rotate(0, Input.GetAxis("Horizontal") * moveRotation, 0);
        }
    }
}
