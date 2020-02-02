using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imagegalleryScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button next;
    public Button prev;
    public RawImage chameleon;
    public RawImage hedgehog;
    public RawImage chimpanzee;
    public RawImage elephant;

    int counter = 0;
    void Start()
    {
       chameleon.enabled = false;
       hedgehog.enabled = false;
       chimpanzee.enabled = false;
       elephant.enabled = false; 

        next.onClick.AddListener(nextImage);
        prev.onClick.AddListener(prevImage);

    }

    // Update is called once per frame
    void Update()
    {
      if(counter == 0){
        chameleon.enabled = true; 
        hedgehog.enabled = false;
        chimpanzee.enabled = false;
        elephant.enabled = false;
      } else if(counter == 1){
        chameleon.enabled = false; 
        hedgehog.enabled = true;
        chimpanzee.enabled = false;
        elephant.enabled = false;
      }else if(counter == 2){
        chameleon.enabled = false; 
        hedgehog.enabled = false;
        chimpanzee.enabled = true;
        elephant.enabled = false;
      }else if(counter == 3){
        chameleon.enabled = false; 
        hedgehog.enabled = false;
        chimpanzee.enabled = false;
        elephant.enabled = true;
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
