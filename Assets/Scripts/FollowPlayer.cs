using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // We reference the player x, y, z coordinates
    public Vector3 offsetCamera; // We create a new Vector3 that we can manually adjust in Unity by making it public

    private void Update() // This method makes the camera follow the player position
    {
        transform.position = player.position + offsetCamera; // We update the transform position of the GO (the camera) to follow the player and add the offset
    }
}