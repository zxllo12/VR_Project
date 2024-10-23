using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject basket;

    public static GameManager instance;
    public int score = 0;
    float bullet_speed = 0f;

    public Text scoreText;
    public Text timerText;
    public Text bulletSpeedText;

    public TextMeshPro XR_scoreText;
    public TextMeshPro XR_timerText;
    public TextMeshPro XR_bulletSpeedText;

    private float countdownTime = 30f;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }   

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
        XR_scoreText.text = "Score: " + score.ToString();
    }

    public void CountDown()
    {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        float currentTime = countdownTime;

        while (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerUI(currentTime);
            yield return null;
        }

        TimerEnded();
    }

    void UpdateTimerUI(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        XR_timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void TimerEnded()
    {
        basket.SetActive(false);
    }

    public void BulletSpeed(float speed)
    {
        bullet_speed = speed;
        UpdateBulletSpeedText();
    }

    void UpdateBulletSpeedText()
    {
        bulletSpeedText.text = "Speed: " + bullet_speed.ToString();
        XR_bulletSpeedText.text = "Speed: " + bullet_speed.ToString();
    }
}
