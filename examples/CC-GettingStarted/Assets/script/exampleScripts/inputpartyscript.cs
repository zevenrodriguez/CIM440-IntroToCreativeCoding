using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputpartyscript : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField userInput;
    public Button enterNameButton;
    public Text messageText;
    string currentMessage = "";
    void Start()
    {
        enterNameButton.onClick.AddListener(getMessage);
    }

    // Update is called once per frame
    void Update()
    {
       if(currentMessage == "party" || currentMessage == "Party"){
           float randX = Random.Range(0,1000);
           float randY = Random.Range(0,1000);
           messageText.transform.position = new Vector3(randX,randY,0);
       }else{
            //messageText.transform.position = new Vector3(-100,0,0);
       }
    }

    void getMessage(){
        currentMessage = userInput.textComponent.text;
        messageText.text = currentMessage;
    }
}
