using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    public bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel() // What happens when we finish the level
    {
        completeLevelUI.SetActive(true); // Set the Canvas GO "Level Complete" from invisible to visible 
    }

    public void EndGame() // What happens if we hit an obstacle or fall

    {
        if (gameHasEnded == false) // Make it restart once if we fail
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke(nameof(Restart), restartDelay);
        }
    }

    private void Restart() // Invoked when we hit an obstable or fail  (after setting gameHadEnded to true)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Returns the name of our current scene and loads it
        //Same as :
        //SceneManager.LoadScene("Level01");
    }
}