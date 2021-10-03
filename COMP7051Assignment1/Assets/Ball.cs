using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 initialImpulse;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(initialImpulse, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
