using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text scoreText;
    
    public void UpdateScore(int newScore)
    {
        scoreText.text = newScore.ToString();
    }
}
