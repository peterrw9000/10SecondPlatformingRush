using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoDisplay : MonoBehaviour
{
    public Text[] info;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        info[0].text = "Score: " + GameManager.instance.score;
        info[1].text = "Lives: " + GameManager.instance.lives;
        info[2].text = GameManager.instance.timer.ToString("F0");
        GameManager.instance.timer -= Time.deltaTime;
        if (GameManager.instance.timer <= 0)
        {
            GameManager.instance.lives -= 1;
            GameManager.instance.streak = 0;
            SceneManager.LoadScene(GameManager.instance.levelNum);
            GameManager.instance.timer = 10;
        }
    }
}
