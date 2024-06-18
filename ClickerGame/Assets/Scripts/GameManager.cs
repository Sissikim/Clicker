using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    private int currentScore;

    private void Awake()
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
    private void Start()
    {
        currentScore = 0;
        UpdateScoreText();
        StartCoroutine(AutoIncreaseScore());
    }

    private IEnumerator AutoIncreaseScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            IncreaseScore();
        }
    }

    public void IncreaseScore()
    {
        currentScore++;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = currentScore.ToString();
    }
}
