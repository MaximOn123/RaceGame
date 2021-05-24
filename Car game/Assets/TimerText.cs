using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{
    private float timer;
    private float seconds;
    private float minutes;
    private float hours;

    bool isStarted;

    [SerializeField]
    public Text stopWatchText;
    // Start is called before the first frame update
    void Start()
    {
        isStarted = true;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        StopWatchCalc();
    }

    void StopWatchCalc()
    {
        if(!isStarted)
        {
            return;
        }

        timer += Time.deltaTime;
        seconds = (int)timer % 60;
        minutes = (int)timer / 60 % 60;
        hours = (int)timer / 3600;

        stopWatchText.text = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
    }

    public void StartTimer()
    {
        isStarted = true;
    }

    public void StopTimer()
    {
        isStarted = false;
    }

    public void ResetTimer()
    {
        isStarted = false;
        timer = 0;
        stopWatchText.text = "00:00:00";
    }
}
