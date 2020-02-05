using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class entertextpartyscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text message;
    public Button enterMessage;
    public InputField userInput;

    string currentMessage = "";

    void Start()
    {
       enterMessage.onClick.AddListener(getmessage); 
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(statement is true){
            run code inside this block
        }
        */
        if(currentMessage == "party"){
            Debug.Log("Lets have a party!");
            float randX = Random.Range(0,1000);
            float randY = Random.Range(0,1000);
            message.transform.position = new Vector3(randX,randY,0);
            // new Vector3(x,y,z);
        }
    }

    void getmessage(){
        // grab text from user: userInput.textComponent.text;
        currentMessage = userInput.textComponent.text;
        message.text = currentMessage;
    }
}
