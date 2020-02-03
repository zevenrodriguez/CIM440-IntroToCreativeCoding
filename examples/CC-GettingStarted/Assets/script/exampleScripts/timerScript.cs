using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text currentTime;
    public Button startButton;

    float timer = 10f;
    bool startTimer = false;
    void Start()
    {
       startButton.onClick.AddListener(() => {
           startTimer = true;
           timer = 10f;
       }); 
       currentTime.text = timer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
     if(startTimer == true){
         timer = timer - Time.deltaTime;
         int castTimer = (int)timer;
         currentTime.text = castTimer.ToString();
         if(castTimer < 0){
             startTimer = false;
             currentTime.text = "Timer Done";
         }
     }   
    }
}
