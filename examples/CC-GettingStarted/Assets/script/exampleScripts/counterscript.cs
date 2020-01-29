using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counterscript : MonoBehaviour
{
    // Start is called before the first frame update
      int count = 0;
    public Text numbers;
    public string message;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       count = count + 1;
       Debug.Log(count); 
       numbers.text = message + count.ToString();
    }

}
