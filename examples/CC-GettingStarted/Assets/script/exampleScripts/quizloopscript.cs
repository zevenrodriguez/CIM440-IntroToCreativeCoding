using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quizloopscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text questionOutput;
    public Text correctIncorrect;
    bool answerCorrect = false;
    string[] questions = {"Which animal is born blind?","A group of this animal is called an array?","Which of animal is our closest relative?", "Which animal can see in UV light?"};
    string[] animals = {"Elephant","Chameleon","Hedgehog","Chimpanzee"};
    public Button[] answerButton = new Button[4];
    int currentQuestion = 0;
    string currentAnswer = "";
    string[] answerKey = {"Elephant", "Hedgehog", "Chimpanzee", "Chameleon"};

    float timer = 5f;
    bool startTimer = false;

    void Start()
    {
        for(int i = 0; i < answerButton.Length; i++){
            answerButton[i].GetComponentInChildren<Text>().text = animals[i];
        }
        /*
        answerButton[0].GetComponentInChildren<Text>().text = animals[0];
        answerButton[1].GetComponentInChildren<Text>().text = animals[1];
        answerButton[2].GetComponentInChildren<Text>().text = animals[2];
        answerButton[3].GetComponentInChildren<Text>().text = animals[3];
        */
        answerButton[0].onClick.AddListener( () => {
            Debug.Log(animals[0]);
            currentAnswer = animals[0];
        });
        answerButton[1].onClick.AddListener( () => {
            Debug.Log(animals[1]);
            currentAnswer = animals[1];
        });
        answerButton[2].onClick.AddListener( () => {
            Debug.Log(animals[2]);
            currentAnswer = animals[2];
        });
        answerButton[3].onClick.AddListener( () => {
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
                currentQuestion = currentQuestion + 1;
                if(currentQuestion >= questions.Length){
                    currentQuestion = 0;
                }
                answerCorrect = true;
                startTimer = true;
            }else{
                answerCorrect = false;
                startTimer = true;
            }
            currentAnswer = "";

            if(answerCorrect == true){
                correctIncorrect.text = "Correct";
            }else{
                correctIncorrect.text = "Incorrect";
            }
       }

       if(startTimer == true){
            timer = timer - Time.deltaTime;
            if(timer < 0){
                startTimer = false;
                correctIncorrect.text = "";
                timer = 5f;
                }
            }



    }
}
