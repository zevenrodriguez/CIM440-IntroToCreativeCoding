using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    int count = 0;
    public Text numbers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       count = count + 1;
       Debug.Log(count); 
       numbers.text = count.ToString();
    }
}
