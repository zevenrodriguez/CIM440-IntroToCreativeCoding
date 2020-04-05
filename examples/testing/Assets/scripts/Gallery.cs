using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gallery : MonoBehaviour
{
    public Button start;
    public Button next;
    public Button previous;
    public Button nextArtist;
    public Button end;
    public Text currentTime;
    public Text artistDisplay;
    /*public RawImage[] picasso = new RawImage[4];
    public RawImage[] vanGogh = new RawImage[4];
    public RawImage[] takashi = new RawImage[4];*/
    int display = 0;
    public string[] artists = { "Pablo Picasso", "Takashi Murakami" ,"Vincent Vangogh" };
    int marker = 0;
    int counter = 0;
    bool startTimer = false;
    float time = 0f;
    
    /*bool picassoOn = false;
    bool vanGoghOn = false;
    bool takashiOn = false;*/
    public RawImage[] gallery = new RawImage[12];
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < gallery.Length; i++)
        {
            gallery[i].enabled = false;
        }
        
        next.onClick.AddListener(nextImage);
        start.onClick.AddListener(() =>
        {
            startTimer = true;
            artistDisplay.text = artists[display];
            marker = 0;

            

        });
        nextArtist.onClick.AddListener(()=>{
        for (int i = 0; i < gallery.Length; i++)
        {
            gallery[i].enabled = false;
        }
        display++;
        if (display == 0) {
            marker = 0;
            counter = marker;
        }else if(display == 1)
        {
            marker = 4;
            counter = marker;

        }else if(display == 2)
        {
            marker = 8;
            counter = marker;

        }else if (display == 3)
        {
            display = 0;
            marker = 0;
            counter = marker;

        }
        artistDisplay.text = artists[display];
        
        });
        currentTime.text = time.ToString();
        previous.onClick.AddListener(prevImage);
        end.onClick.AddListener(() =>
        {
            startTimer = false;
        });

    }

    // Update is called once per frame
    void Update()
    { 
        if (startTimer == true)
        {
            time = time + Time.deltaTime;
            currentTime.text = time.ToString();
        }
        
        
        for (int i = marker; i < marker+3 ; i++)
         {
                if (i == counter)
                {
                    gallery[i].enabled = true;
                }
                else
                {
                    gallery[i].enabled = false;
                }

            }

            Debug.Log(counter);

    }
    void prevImage()
    {
        
        counter--;
        if (counter < marker)
        {
            counter = marker+3;
        }
    }
    void nextImage()
    {
        
        counter++;
        
        if (counter == marker+3 )
        {
            counter = marker;
        }
    }
   
}
