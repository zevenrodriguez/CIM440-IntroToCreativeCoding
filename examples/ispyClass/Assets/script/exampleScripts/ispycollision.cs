using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ispycollision : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cursor;
	public Text clock;
    public Text balloon;
	public Text guitar;


    GameObject foundObject;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        
        //Ouput the Collision to the console
        if(col.gameObject.name=="clock"){
            Debug.Log("Found Clock");
            clock.text = "✓";
            clock.color = new Color32(0,255,0,255);
        }else if(col.gameObject.name=="balloon"){
            Debug.Log("Found Balloon");
            balloon.text = "✓";
            balloon.color = new Color32(0,255,0,255);
        }else if(col.gameObject.name=="guitar"){
            Debug.Log("Found Guitar");
            guitar.text = "✓";
            guitar.color = new Color32(0,255,0,255);
        }
        Debug.Log("Collision : " + col.gameObject.name);
    }
    //✓
}
