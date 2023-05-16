using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 1000000f;

    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }


        /*
        JUMP? 
        if (Input.GetKey(KeyCode.T))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
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

    }
}
