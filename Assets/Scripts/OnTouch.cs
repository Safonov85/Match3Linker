using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouch : MonoBehaviour
{
    //public LayerMask touchInputMask;
    // Use this for initialization
    private int test = 0;
    private float positionX, positionY = 0;
    void Start()
    {
        
    }

    void OnGUI()
    {

        //GUI.Label(new Rect(10, 10, 100, 20), "X: " + positionX.ToString() + " Y: " + positionY.ToString());
        //GUI.Label(new Rect(positionX, positionY, 100, 20), "O");

        Vector3 p = new Vector3();
        Camera c = Camera.main;
        Event e = Event.current;
        Vector2 mousePos = new Vector2();

        // Get the mouse position from Event.
        // Note that the y position from Event is inverted.
        mousePos.x = e.mousePosition.x;
        mousePos.y = c.pixelHeight - e.mousePosition.y;

        p = c.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, c.nearClipPlane));

        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
        GUILayout.Label("Screen pixels: " + c.pixelWidth + ":" + c.pixelHeight);
        GUILayout.Label("Mouse position: " + mousePos);
        GUILayout.Label("World position: " + p.ToString("F3"));
        GUILayout.EndArea();
        //GUI.Box(new Rect(positionX, positionY, -50, 50), test.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            //RotateLeft();
            positionX = (int)Input.mousePosition.x;
            positionY = Screen.height -  (int)Input.mousePosition.y;
            //GUI.Label(new Rect(0, 0, 100, 100), Input.mousePosition.ToString());
        }
    }

    void RotateLeft()
    {
        transform.Rotate(Vector3.forward * -10);
    }

    private void OnMouseDown()
    {

    }

    private void OnMouseDrag()
    {
        RotateLeft();
    }

    private void OnMouseUp()
    {

    }
}
