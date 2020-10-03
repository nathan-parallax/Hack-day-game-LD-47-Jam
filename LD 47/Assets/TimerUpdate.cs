using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUpdate : MonoBehaviour
{
    public string timeText;
    private float seconds;
    private int minutes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        seconds += Time.deltaTime;

        if(seconds >= 60) {
            minutes++;
            seconds = 0;
        }

        timeText = minutes.ToString("00") + ":" + ((int)seconds).ToString("00");

        GetComponentInParent<Text>().text = timeText;

    }
}
