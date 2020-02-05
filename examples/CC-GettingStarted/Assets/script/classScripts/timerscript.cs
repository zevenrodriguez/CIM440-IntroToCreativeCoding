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
      });  
    }

    // Update is called once per frame
    void Update()
    {
        if(startTimer == true){
            Debug.Log("Start the timer");
        }
    }
}
