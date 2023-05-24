using UnityEngine;

public class GameManager : MonoBehaviour

{
    private bool gameHasEnded = false;

    public void EndGame()

    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            // TODO Restart game
        }
    }
}