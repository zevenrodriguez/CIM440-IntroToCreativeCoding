using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text currentTime;
    public Button startButton;

    float timer = 10f;
    bool startTimer = false; //bool values are either true or false;
    void Start()
    {
      startButton.onClick.AddListener(()=>{
          //function code in here
        startTimer = true;
        timer = 10f;
      });  
      currentTime.text = timer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime);     
        if(startTimer == true){
            Debug.Log("Start the timer");
            timer = timer - Time.deltaTime;
            Debug.Log(timer);
            int castTimer = (int)timer;
            currentTime.text = castTimer.ToString();
            // <= less than or equal to
            if(timer <= 0){
              startTimer = false;
              currentTime.text = "Timer Done";
            }
        }
    }
}
