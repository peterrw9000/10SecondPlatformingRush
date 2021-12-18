using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreenControl : MonoBehaviour
{
    public Text scoreText;
    public Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = GameManager.instance.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        GameManager.instance.score = 0;
        SceneManager.LoadScene(GameManager.instance.levelNum);
        GameManager.instance.lives = 3;
    }
}
