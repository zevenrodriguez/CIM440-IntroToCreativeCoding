using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imagegalleryarrayclass : MonoBehaviour
{
    // Start is called before the first frame update
    public Button prev;
    public Button next;

    public RawImage[] imageArray = new RawImage[4]; // telling unity you want 4 images
    // public RawImage[] imageArray; You'll set in Unity's interface how many images you want

    int counter = 0;

    
    void Start()
    {
        
        imageArray[0].enabled = false;
        imageArray[1].enabled = false;
        imageArray[2].enabled = false;
        imageArray[3].enabled = false;
        //For loop as 3 parts: 
        //Part 1: Start Variable
        //part 2: How Long/Condition to make our loop stop 
        //part 3: Itterator, how do we want to count, i++ => i=i+1;
        for(int i = 0; i<imageArray.Length; i++){
            imageArray[i].enabled = false;
        }

        imageArray[0].enabled = true;

        next.onClick.AddListener(()=>{

            counter = counter + 1;
            if(counter == 4){
                counter = 0;
            }

        });

        prev.onClick.AddListener(prevImage);
    }

    // Update is called once per frame
    void Update()
    {
        for(int j = 0; j < imageArray.Length; j++){
            if(j == counter){
                imageArray[j].enabled = true;
            }else{
                imageArray[j].enabled = false;
            }
        }
        
    }

    void prevImage(){
        counter = counter - 1;
        if(counter < 0){
            counter = 3;
        }
    }
}
