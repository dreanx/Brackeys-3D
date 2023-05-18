using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offsetCamera;

    private void Update()
    {
        transform.position = player.position + offsetCamera;
    }
}