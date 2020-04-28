﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNose : MonoBehaviour
{
    private Rigidbody rb;
    public Component[] capsule;
    private bool isCapsule;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("capsule"))
        {
            SoundManager.Instance.PlayMusic();
        }
    }

}
