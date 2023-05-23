using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    private TMP_Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}