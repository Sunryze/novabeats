using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ColourWheel : MonoBehaviour, IPointerClickHandler, IDragHandler {

    public Texture2D colourWheel;
    public GameObject mainChar;
    private Vector2 position;
    public int imageHeight;
    public int imageWidth;
    public float radius;
    public Camera cam;

    // Use this for initialization
    private void Start() {
        position = transform.position;
        radius = GetComponent<RectTransform>().rect.width / 2;
        cam = Camera.main;
        Debug.Log(position);
        //GetComponent<Image>().alphaHitTestMinimumThreshold = 0.2f;
        imageHeight = colourWheel.height;
        imageWidth = colourWheel.width;
    }



    public void Update() {
        if(Input.GetMouseButtonDown(0) == true) {
            
        }

    }

    
    public void OnPointerClick(PointerEventData eventData) {
        Vector2 pos = eventData.delta;

        Vector2 textureCoord = new Vector2(Input.mousePosition.x - position.x + 50, Input.mousePosition.y - position.y + 50);
        int aaa = Convert.ToInt32(textureCoord.x * cam.aspect);
        int bbb = Convert.ToInt32(textureCoord.y * cam.aspect);
        Debug.Log(aaa + ", " + bbb);
        Color colour = colourWheel.GetPixel(aaa, bbb);
        //Debug.Log(colour);
        mainChar.GetComponent<SpriteRenderer>().color = colour;

    }

    public void OnDrag(PointerEventData eventData) {
        Vector2 textureCoord = new Vector2(Input.mousePosition.x - position.x + 50, Input.mousePosition.y - position.y + 50);
        int aaa = Convert.ToInt32(textureCoord.x * cam.aspect);
        int bbb = Convert.ToInt32(textureCoord.y * cam.aspect);
        Debug.Log(aaa + ", " + bbb);
        Color colour = colourWheel.GetPixel(aaa, bbb);
        //Debug.Log(colour);
        mainChar.GetComponent<SpriteRenderer>().color = colour;

    }
}
