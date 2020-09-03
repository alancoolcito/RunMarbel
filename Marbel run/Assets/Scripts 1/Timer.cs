using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float startTime = -1;
    public Text timeText;
    public float stoper = 1;
    public float score;
    [SerializeField] Canvas winCanvas;
    [SerializeField] private Image star1;
    [SerializeField] private Image star2;
    [SerializeField] private Image star3;
    float seconds;

    void Start()
    {
    }

    void Update()
    {
        startTime += Time.deltaTime * stoper;
        DisplayTime(startTime);
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
         seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void EndTrack()
    {
        if (seconds <= 50f)
        {
            Debug.Log("<30");

            star1.gameObject.SetActive(true);
            star2.gameObject.SetActive(true);
            star3.gameObject.SetActive(true);
        }
        else if (seconds > 50f && seconds <= 70f)
        {
            Debug.Log(">30");

            star1.gameObject.SetActive(true);
            star2.gameObject.SetActive(true);
            star3.gameObject.SetActive(false);
        }
        else if (seconds >70f)
        {
            Debug.Log(">50");
            star1.gameObject.SetActive(true);
            star2.gameObject.SetActive(false);
            star3.gameObject.SetActive(false);
        }

        else
        {
            star1.gameObject.SetActive(true);
            star2.gameObject.SetActive(true);
            star3.gameObject.SetActive(true);
        }
    }
    
    
}
