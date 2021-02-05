using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class timercontroller : MonoBehaviour
{
    public static timercontroller instance; //script name

    public Text timeCounter;    //insert text object here

    public TimeSpan timePlaying;    //changed from private to public
    private bool timerGoing;
    private float elapsedTime;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        timeCounter.text = "Time: 00:00.00";    //initialize time
        timerGoing = false;
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timerGoing = false;
    }

    public IEnumerator UpdateTimer()    //changed from private to public 1601 1720
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayingStr;

            yield return null;
        }
    }

    void Update()
    {
    }
}
