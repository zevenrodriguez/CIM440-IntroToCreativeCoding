using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceChangeColor : MonoBehaviour
{
    float pre_position_y = 3;
    public Material original_material;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > pre_position_y){
            this.GetComponent<Renderer>().material.color = new Color(255,0,0);
            Debug.Log("RED");

        }else if(transform.position.y < pre_position_y){
            this.GetComponent<Renderer>().material = original_material;
            Debug.Log("ORIGINAL");

        }else{
            this.GetComponent<Renderer>().material.color = new Color(0,0,255);
            Debug.Log("Neither");
        }
        pre_position_y = transform.position.y;
    }
}
