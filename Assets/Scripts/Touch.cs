using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Touch : MonoBehaviour
{
    public LayerMask touchInputMask;
    private List<GameObject> touchList = new List<GameObject>();
    //public Color red = Color.red;
    private int fps = 0;
    Camera camera;

    // Use this for initialization
    void Start()
    {
        Input.simulateMouseWithTouches = true;
        camera = GetComponent<Camera>();
        //camera.backgroundColor = red;
        
    }

    private void OnGUI()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //fps++;
        //if(DateTime.Now.Millisecond > 950)
        //{
            
        //    Debug.Log(fps);
        //    fps = 0;
        //}
        
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            //GUI.Label(new Rect(0, 0, 100, 100), Input.mousePosition.ToString());
        }
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        //{
        //    // Get movement of the finger since last frame
        //    Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

        //    Vector3 fingerPos = Input.GetTouch(0).position;

        //    Debug.Log(touchDeltaPosition.x.ToString());

        //    //transform.position = touchDeltaPosition;

        //    Vector3 pos = fingerPos;
        //    pos.z = 8;
        //    Vector3 realWorldPos = Camera.main.ScreenToWorldPoint(pos);

        //    Debug.Log(realWorldPos.x.ToString());
        //    GUI.Label(new Rect(0, 0, 100, 100), Input.mousePosition.ToString());
        //}
        //Debug.Log(Input.mousePosition.x);
        //if(Input.touchCount > 0)
        //{
        //    camera.backgroundColor = Color.red;
        //foreach (UnityEngine.Touch touch in Input.touches)
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        //    RaycastHit hit;

        //    camera.backgroundColor = Color.red;

        //    if (Physics.Raycast(ray, out hit, touchInputMask))
        //    {
        //        GameObject recipient = hit.transform.gameObject;
        //        if (touch.phase == TouchPhase.Began)
        //        {
        //            recipient.SendMessage("OnTouch", hit.point, SendMessageOptions.DontRequireReceiver);
        //        }

        //        RotateLeft();
        //    }

        //}
        //}

    }

    void RotateLeft()
    {
        transform.Rotate(Vector3.forward * -10);
    }


}
