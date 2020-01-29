using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class entertext : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField userInput;
    public Button enterNameButton;
    public Text messageText;
    void Start()
    {
        enterNameButton.onClick.AddListener(getMessage);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void getMessage(){
        messageText.text = userInput.textComponent.text;
    }
}
