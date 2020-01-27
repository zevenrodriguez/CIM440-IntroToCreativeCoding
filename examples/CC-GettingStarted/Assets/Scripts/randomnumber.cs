using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomnumber : MonoBehaviour
{
    // Start is called before the first frame update
    public Text outputText;
    public Button genRandom;
    int randNum = 0;
    void Start()
    {
       genRandom.onClick.AddListener(newRandomNumber); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void newRandomNumber(){
        randNum = Random.Range(0,255);
        outputText.text = randNum.ToString();
    }
}
