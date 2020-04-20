using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class matchtriviaScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text questionOutput;
    public Text correctIncorrect;
    public Button[] answerButtons = new Button[4];
    //public Button[] answerButtons;
    string[] animals = {"Joe","Carol", "John", "Doc"};

    string currentAnswer = "";

    string[] questions = {"Who is considered the Tiger King?", "Who owns Big Cat Rescue?", "Who was Joe Exotics first boyfriend?", "Who performed with Britney Spears during her 2001 MTV VMA's show?", "Who had 3 husbands?", "Who captured and bred up to 227 tigers in his zoo", "At whose park did an employee get their arm bitten off?", "Whose husband disappeared and is thought to have been fed to the tigers?" };
    string[] answerKey = {"Joe", "Carol", "John", "Doc", "Joe", "Joe", "Joe", "Carol" };
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
               timer = 5f;

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
