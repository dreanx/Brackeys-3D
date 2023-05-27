using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour 
{
    public void LoadNextLevel() // This method is added to the animation
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Load the next active scene in the build index
    }
}