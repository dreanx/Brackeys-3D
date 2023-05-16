
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offsetCamera;
    void Update()
    {
        transform.position = player.position + offsetCamera;
    }
}
