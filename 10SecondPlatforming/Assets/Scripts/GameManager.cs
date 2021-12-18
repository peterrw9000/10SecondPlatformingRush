using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float timer = 10;
    public int lives = 3;
    public int score = 0;
    public int streak = 0;
    public int levelNum;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 0)
        {
            SceneManager.LoadScene(7);
            lives = -1;
        }
        levelNum = Random.Range(2, 6);
    }
}
