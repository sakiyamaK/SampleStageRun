using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameResult : MonoBehaviour
{
  private int highScore;
  public Text resultTime;
  public Text bestTime;
  public GameObject resultUI;

    // Start is called before the first frame update
    void Start()
    {
      if (PlayerPrefs.HasKey("HighScore")) {
        highScore = PlayerPrefs.GetInt("HighScore");
      }
      else {
        highScore = 999;
      }
    }

    // Update is called once per frame
    void Update()
    {
      if (Goal.goal) {
        resultUI.SetActive(true);
        int result = Mathf.FloorToInt(Timer.time);
        resultTime.text = "Result Time:" + result;
        bestTime.text = "Best Time:" + highScore;

        if (highScore > result) {
          PlayerPrefs.SetInt("HightScore", result);
        }
      }
    }

    public void OnRetry() {
      SceneManager.LoadScene(
        SceneManager.GetActiveScene().name
      );
    }
}
