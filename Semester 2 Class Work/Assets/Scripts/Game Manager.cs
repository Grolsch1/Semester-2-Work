using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int Score = 0;
    public bool isGamePaused = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        Score += points;
        Debug.Log("Score: " + Score);
    }

    public void TogglePause()
    {
        isGamePaused = !isGamePaused;
        if (isGamePaused)
        {
            Time.timeScale = 0f;
            Debug.Log("Game Paused");
        }
        else
        {
            Time.timeScale = 1f;
            Debug.Log("Game Resumed");
        }
    }

    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

}
