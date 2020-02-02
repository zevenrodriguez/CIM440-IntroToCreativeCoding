using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class testing : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    // Start is called before the first frame update
    public Image test;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

      public void OnPointerEnter(PointerEventData eventData)
    {
        // Debug.Log("Name: " + eventData.pointerCurrentRaycast.gameObject.name);
        // Debug.Log("Tag: " + eventData.pointerCurrentRaycast.gameObject.tag);
        // Debug.Log("GameObj  ect: " + eventData.pointerCurrentRaycast.gameObject);
    }

      public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Name: " + eventData.pointerCurrentRaycast.gameObject.name);
        Debug.Log("Tag: " + eventData.pointerCurrentRaycast.gameObject.tag);
        Debug.Log("GameObject: " + eventData.pointerCurrentRaycast.gameObject);
    }
}
