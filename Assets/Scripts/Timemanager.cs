using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timemanager : MonoBehaviour
{
    
    public Text text;


    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>=0)
        {
            timer-=Time.deltaTime;
            SetTimerText(timer);
        }
        else
        {
            timer=0;
        }

        
    }
    private void SetTimerText(float timetoDisplay)
    {
        if (timetoDisplay<0)
        {
            timetoDisplay=0;
        }
        float minutes=Mathf.FloorToInt(timetoDisplay/60);
        float seconds= Mathf.FloorToInt(timetoDisplay % 60);
        text.text= string.Format("{0:00}:{1:00}",minutes,seconds);
    }
}
