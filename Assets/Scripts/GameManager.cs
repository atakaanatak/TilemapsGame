using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTextBox;
    public GameObject loseTextBox;

    int totalMoney = 0;
    bool IsGameOver = false;

    void Start()
    {
        totalMoney = 0;
        UpdateScore();
    }

    public void EarnMoney()
    {
        if (IsGameOver) return;

        totalMoney += 100;
        UpdateScore();
    }

    public void FinishGame()
    {
        if (IsGameOver) return;

        IsGameOver = true;

        loseTextBox.SetActive(true);
        Time.timeScale = 0;
    }

    void UpdateScore()
    {
        scoreTextBox.text = "SCORE: " + totalMoney + "$";
    }
}