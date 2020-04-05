using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imagegalleryarraytimerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button next;
    public Button prev;
    public RawImage[] imageArray;

    int counter = 0;

    float timer = 0.0f;
    void Start()
    {
       imageArray[0].enabled = false;
       imageArray[1].enabled = false;
       imageArray[2].enabled = false;
       imageArray[3].enabled = false; 

        next.onClick.AddListener(nextImage);
        prev.onClick.AddListener(prevImage);

    }

    // Update is called once per frame
    void Update()
    {
    /*
      if(counter == 0){
        imageArray[0].enabled = true; 
        imageArray[1].enabled = false;
        imageArray[2].enabled = false;
        imageArray[3].enabled = false;
      } else if(counter == 1){
        imageArray[0].enabled = false; 
        imageArray[1].enabled = true;
        imageArray[2].enabled = false;
        imageArray[3].enabled = false;
      }else if(counter == 2){
        imageArray[0].enabled = false; 
        imageArray[1].enabled = false;
        imageArray[2].enabled = true;
        imageArray[3].enabled = false;
      }else if(counter == 3){
        imageArray[0].enabled = false; 
        imageArray[1].enabled = false;
        imageArray[2].enabled = false;
        imageArray[3].enabled = true;
      }
      */

        timer = timer + Time.deltaTime;
       
        Debug.Log(counter);
        if(counter >= 4){
            timer = 0;
        }
    
        for(int i = 0; i<imageArray.Length; i++){
            if(i == counter){
                imageArray[i].enabled = true;
            }else{
                imageArray[i].enabled = false;
            }
        }

    }

    void nextImage(){
        counter++;
        if(counter == 4){
            counter = 3;
        }
    }

    void prevImage(){
        counter--;
        if(counter == -1){
            counter = 0;
        }
    }
}
