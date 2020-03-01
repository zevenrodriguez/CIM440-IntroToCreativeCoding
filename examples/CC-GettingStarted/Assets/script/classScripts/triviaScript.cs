using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triviaScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text questionOutput;
    public Text correctIncorrect;
    public Button[] answerButtons = new Button[4];
    //public Button[] answerButtons;
    string[] animals = {"Elephant","Hedgehog", "Chimpanzee", "Chameleon"};

    string currentAnswer = "";

    string[] questions = {"Which animal is born blind?", "A group of this animal is called an array?", "Which animal is our closest relative?","Which animal can see UV light?"};
    string[] answerKey = {"Elephant", "Hedgehog","Chimpanzee", "Chameleon"};
    int currentQuestion = 0;//keeping track of the current question

    float timer = 5f;
    bool startTimer = false;

    void Start()
    {
        //answerButtons[0].image.color = new Color32(0,255,0,127);
        //answerButtons[0].GetComponentInChildren<Text>().text = animals[0];
        //answerButtons[0].GetComponentInChildren<Text>().color = new Color32(255,0,0,255);

        for(int i = 0; i < answerButtons.Length; i++){
            answerButtons[i].image.color = new Color32(0,255,0,127);
            answerButtons[i].GetComponentInChildren<Text>().text = animals[i];
            answerButtons[i].GetComponentInChildren<Text>().color = new Color32(255,0,0,255);
        
        }

        answerButtons[0].onClick.AddListener(()=>{
            Debug.Log(animals[0]);
            currentAnswer = animals[0];

        });

        answerButtons[1].onClick.AddListener(()=>{
            Debug.Log(animals[1]);
            currentAnswer = animals[1];

        });

        answerButtons[2].onClick.AddListener(()=>{
            Debug.Log(animals[2]);
            currentAnswer = animals[2];

        });

        answerButtons[3].onClick.AddListener(()=>{
            Debug.Log(animals[3]);
            currentAnswer = animals[3];

        });


    }

    // Update is called once per frame
    void Update()
    {
       questionOutput.text = questions[currentQuestion];
       if(currentAnswer != ""){
           if(currentAnswer == answerKey[currentQuestion]){
               Debug.Log("Correct");
               correctIncorrect.text = "correct";
               currentQuestion = currentQuestion + 1;
               if(currentQuestion > answerKey.Length-1){
                   currentQuestion = 0;
               }
               startTimer = true;
               timer =5f;

           }else{
               Debug.Log("Incorrect");
               correctIncorrect.text = "Incorrect";
               startTimer = true;
               timer = 5f;
           }

           currentAnswer = "";
       }

       if(startTimer == true){
           timer = timer - Time.deltaTime;
           if(timer < 0){
               startTimer = false;
               correctIncorrect.text = "";
           }
       } 
    }
}
