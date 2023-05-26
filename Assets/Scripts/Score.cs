using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    private TMP_Text scoreText;

    private void Start() // We fetch the text component this script is attached to
    {
        scoreText = GetComponent<TMP_Text>();
    }

    private void Update() // We update and display the z player position every frame
    {
        scoreText.text = player.position.z.ToString("0");
    }
}