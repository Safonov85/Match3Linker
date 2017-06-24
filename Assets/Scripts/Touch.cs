using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Get movement of the finger since last frame
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            Vector3 fingerPos = Input.GetTouch(0).position;

            Debug.Log(touchDeltaPosition.x.ToString());

            //transform.position = touchDeltaPosition;

            Vector3 pos = fingerPos;
            pos.z = 8;
            Vector3 realWorldPos = Camera.main.ScreenToWorldPoint(pos);

            Debug.Log(realWorldPos.x.ToString());
        }
        Debug.Log(Input.mousePosition.x);
    }
}
