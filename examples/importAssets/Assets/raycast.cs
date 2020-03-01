using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    // Start is called before the first frame update

    float speed = 2f;
    float rayDistance = 1000f;

    bool trigger = false;

    GameObject[] models;
    Vector3[] orginalScale;

    //GameObject selectedModel;
    string selectedModel = "";

    bool toggleCameraMouse = false;

    Ray currentRay;
    void Start()
    {
        models = GameObject.FindGameObjectsWithTag("addedmodels"); 
        Debug.Log(models.Length);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D)){
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.W)){
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S)){
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
        // Key Up wait for the user to press then release the key
        if (Input.GetKeyUp(KeyCode.C)){
			if(toggleCameraMouse == false){
                toggleCameraMouse = true;
            }else{
                toggleCameraMouse = false;
            }
		}
        RaycastHit hit;

        if(toggleCameraMouse == false){
            currentRay = new Ray(Camera.main.transform.position, Vector3.forward * rayDistance); // origin point from the camera position, direction vector forward
            Debug.DrawRay(currentRay.origin,currentRay.direction, Color.red);

        }else{
            Camera.main.transform.position = new Vector3(0,1,-10);
            currentRay = Camera.main.ScreenPointToRay(Input.mousePosition);// ScreenPointToRay: origin the camera, direction towards the mouse point
            Debug.DrawRay(currentRay.origin, currentRay.direction * rayDistance, Color.green);

        }
        
      
        if (Physics.Raycast(currentRay, out hit, rayDistance)) {
            // Do something with the object that was hit by the raycast.
            Debug.Log("Hit");
            var currentHit = hit.transform;
                Debug.Log(currentHit.name);

            if(currentHit.name == "shuttle" ||currentHit.name == "avocado" || currentHit.name == "toybear"){
                if(trigger == false){
                  currentHit.transform.localScale =  currentHit.transform.localScale * 1.1f;
                  trigger = true;  
                } 
                selectedModel = currentHit.transform.name;
            }    
        }else{
           if(selectedModel != ""){
                GameObject curObj = GameObject.Find(selectedModel);
                curObj.transform.localScale = curObj.transform.localScale / 1.1f;
                selectedModel = "";
                trigger = false;
           }             
           
        }
    }
}
