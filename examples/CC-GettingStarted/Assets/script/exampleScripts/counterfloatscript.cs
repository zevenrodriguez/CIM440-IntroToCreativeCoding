using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counterfloatscript : MonoBehaviour
{
     // Start is called before the first frame update
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
       count = count + speed;
       int number = (int)count;
       Debug.Log("current count: " + count + " current number: " + number); 
       numbers.text = message + number.ToString();
    }
}
