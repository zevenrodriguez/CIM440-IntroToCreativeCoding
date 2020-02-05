using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class entertextscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text message;
    public Button enterMessage;
    public InputField userInput;

    void Start()
    {
       enterMessage.onClick.AddListener(getmessage); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void getmessage(){
        // grab text from user: userInput.textComponent.text;
        message.text = userInput.textComponent.text;
    }
}
