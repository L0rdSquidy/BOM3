using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float gravityScale = 5;
    public Rigidbody rb;
    public float force = 5;

    public bool onFloor = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            onFloor = false;
        }
    }

    private void FixedUpdate()
    {
    rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
    }

    private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.tag == "floor") {
        onFloor = true;
    }
    
}
}
