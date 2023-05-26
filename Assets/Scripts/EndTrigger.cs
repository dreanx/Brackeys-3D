using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter() // This method is called when the player hit the END invisible (no mesh renderer) GameObject
    {
        gameManager.CompleteLevel();
    }
}