using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomnumberscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text output;
    public Button button1;
    int randnum = 0;
    void Start()
    {
       button1.onClick.AddListener(createrandom); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }//end of update


    void createrandom(){
        randnum = Random.Range(0,255);
        //Debug.Log("IT'S ALIVE!!!!!!");
        Debug.Log(randnum);
        output.text = randnum.ToString();

    }//end of createrandom

}//end of script
