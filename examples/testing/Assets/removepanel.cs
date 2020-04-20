using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class removepanel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panels;
    void Start()
    {
      panels.gameObject.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
            panels.gameObject.SetActive(true);  
  
    }
}
