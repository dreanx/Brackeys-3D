using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMove movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}