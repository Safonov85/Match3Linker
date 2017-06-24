using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouch : MonoBehaviour
{
    bool touchDown = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButtonDown(0))
        //{ // if left button pressed...
        //    Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        // the object identified by hit.transform was clicked
        //        // do whatever you want
        //        transform.Rotate(0, 0, Time.deltaTime);
        //    }
        //}
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        //{
        //    transform.Rotate(0, 0, Time.deltaTime);
        //}
        if (touchDown)
        {
            RotateLeft();
        }
        //for (int i = 0; i < Input.touchCount; ++i)
        //{
        //    if (Input.GetTouch(i).phase == TouchPhase.Began)
        //    {
        //        // Construct a ray from the current touch coordinates
        //        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
        //        // Create a particle if hit
        //    }
        //}

    }

    void OnMouseDown()
    {
        touchDown = true;
    }

    void OnMouseUp()
    {
        touchDown = false;
        ResetRotation();
    }

    void RotateLeft()
    {
        transform.Rotate(Vector3.forward * -10);
    }

    void ResetRotation()
    {
        transform.rotation = Quaternion.identity;
    }
}
