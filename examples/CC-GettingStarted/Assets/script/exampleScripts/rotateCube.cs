using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour
{
    public float speed = 0.1f;

    public float degree = 45f;
    int direction = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        if(transform.position.x > 5){
            speed = -1 * speed;
            direction = -1 * direction;
        }
        if(transform.position.x < -5){
            speed = -1 * speed;
            direction = -1 * direction;

        }
        transform.position = new Vector3(transform.position.x + speed, transform.position.y,transform.position.z);
        transform.Rotate(new Vector3(0,0,direction*degree* Time.deltaTime));
    }
}
