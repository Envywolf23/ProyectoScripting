using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private bool drag;
    private bool swipeL;
    private bool swipeR;
    private bool swipeUp;
    private bool swipeDown;
    private bool tap;

    private Vector2 startTap, swipeD;

    private void Update()
    {
        tap = swipeL = swipeR = swipeUp = swipeDown = false;

        #region UnityControl

        if (Input.GetMouseButtonDown(0))
        {
            tap = true;
            startTap = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Reset();
        }
        #endregion

        #region MobileContol
        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                tap = true;
                drag = true;
                startTap = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                drag = false;
                Reset();
            }

        }

        swipeD = Vector2.zero;
        if(drag)
        {
            if (Input.touches.Length > 0)
            {
                swipeD = Input.touches[0].position - startTap;

            }
            else if (Input.GetMouseButton(0))
            {
                swipeD = (Vector2)Input.mousePosition - startTap;
            }
                
            
        }

        if( swipeD.magnitude > 1500)
        {
            float x = swipeD.x;
            float y = swipeD.y;
            if(Mathf.Abs(x) > Mathf.Abs(y))
            {
                if (x < 0)
                {
                    swipeL = true;
                }
                else
                {
                    swipeR = true;
                }
            }
            else
            {
                if (y < 0)
                {
                    swipeDown = true;
                }
                else
                {
                    swipeUp = true;
                }
            }


            Reset();
        }

        #endregion

    }

    private void Reset()
    {
        startTap = swipeD = Vector2.zero;
        drag = false;

    }


    public Vector2 SwipeD { get { return swipeD; } }
    public bool SwipeL { get { return swipeL; } }
    public bool SwipeR { get { return swipeR; } }
    public bool SwipeUp { get { return swipeUp; } }
    public bool SwipeDown { get { return swipeDown; } }
    public bool Tap { get { return tap; } }


}
