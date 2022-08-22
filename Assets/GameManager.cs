using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    [SerializeField] ScoreSetter scoreSetter;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);

        scoreSetter.UploadPoints();

        Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
}
