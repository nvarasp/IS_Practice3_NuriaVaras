using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlHands : MonoBehaviour
{
    private Rigidbody rb;
    public Component[] present;
    private bool isPresent;
    public Component[] cylinder;
    private bool isCylinder;
    public Component[] setas;
    private bool isSeta;

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

        if (other.gameObject.CompareTag("present"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("seta"))
        {
           
            if(other.gameObject.GetComponent<Rotate>().enabled == false)
            {
                other.gameObject.GetComponent<Rotate>().enabled = true;
            }
            else
            {
                other.gameObject.GetComponent<Rotate>().enabled = false;
            }
            
        }
        if (other.gameObject.CompareTag("cylinder"))
        {
            other.gameObject.GetComponentInChildren<MeshRenderer>().material.color = UnityEngine.Random.ColorHSV();
        }
    }
}
