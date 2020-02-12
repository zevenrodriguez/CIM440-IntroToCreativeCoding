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
        
    }

    void prevImage(){
        counter = counter - 1;
        if(counter < 0){
            counter = 3;
        }
    }
}
