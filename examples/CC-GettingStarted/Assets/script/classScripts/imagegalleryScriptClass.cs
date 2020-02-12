using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imagegalleryScriptClass : MonoBehaviour
{
    // Start is called before the first frame update
    public Button prev;
    public Button next;
    public RawImage chameleon;
    public RawImage hedgehog;
    public RawImage chimp;
    public RawImage elephant;

    int counter = 0;

    
    void Start()
    {
        chameleon.enabled = false;
        hedgehog.enabled = false;
        chimp.enabled = false;
        elephant.enabled = false;

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
        if(counter == 0){
            chameleon.enabled = true;
            hedgehog.enabled = false;
            chimp.enabled = false;
            elephant.enabled = false;
        }else if(counter == 1){
            chameleon.enabled = false;
            hedgehog.enabled = true;
            chimp.enabled = false;
            elephant.enabled = false;
        }else if(counter == 2){
            chameleon.enabled = false;
            hedgehog.enabled = false;
            chimp.enabled = true;
            elephant.enabled = false;
        }else if(counter == 3){
            chameleon.enabled = false;
            hedgehog.enabled = false;
            chimp.enabled = false;
            elephant.enabled = true;
        }
    }

    void prevImage(){
        counter = counter - 1;
        if(counter < 0){
            counter = 3;
        }
    }
}
