using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    private bool gameHasEnded = false;
    public float restartDelay = 2f;

    public void EndGame()

    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke(nameof(Restart), restartDelay);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Returns the name of our current scene and loads it
        //Same as :
        //SceneManager.LoadScene("Level01");
    }
}