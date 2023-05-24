using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMove movement; // Reference to our PlayerMove script

    private void OnCollisionEnter(Collision collisionInfo) // This function runs when we hit another object
    {
        if (collisionInfo.collider.tag == "Obstacle") // Checks if we collided with an object tagged "Obstacle"
        {
            movement.enabled = false; // Next line is the same outcome
            //GetComponent<PlayerMove>().enabled = false;

            FindObjectOfType<GameManager>().EndGame();

        }
    }
}