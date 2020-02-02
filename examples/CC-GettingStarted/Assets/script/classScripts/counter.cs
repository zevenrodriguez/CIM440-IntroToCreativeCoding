using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    float count = 0;
    public Text numbers;
    public string message;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //count = count + 1;
       count = count + speed;
       int newNumber = (int)count;
       Debug.Log("count: " + count + " newNumber: " + newNumber); 
       numbers.text = message + newNumber.ToString();
    }
}
