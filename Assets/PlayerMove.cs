using System.Collections.Specialized;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 100f;
    public float jumpForce = 1000f;
    private Vector3 Hey = new Vector3(2,1,3);

    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        Debug.Log(rb.velocity);
    }
}

/*

JUMP:
if (Input.GetKey(KeyCode.Space))
{
    rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
}


MANUAL CONTROLLER:
if (Input.GetKey(KeyCode.S))
{
rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
}
if (Input.GetKey(KeyCode.Z))
{
rb.AddForce(0, 0, forwardForce * Time.deltaTime);
} */



