using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hwscale : MonoBehaviour
{
        public float speed = 0.1f;

    public float degree = 1f;
    int direction = -1;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        if(transform.position.z > 5){
            speed = -1 * speed;
            direction = -1 * direction;
            this.GetComponent<Renderer>().material.color = new Color(255,0,0);
        }
        if(transform.position.z < -5){
            speed = -1 * speed;
            direction = -1 * direction;
            this.GetComponent<Renderer>().material.color = new Color(255,255,0);

        }
        transform.position = new Vector3(transform.position.x, transform.position.y ,transform.position.z + speed);
    }
}
