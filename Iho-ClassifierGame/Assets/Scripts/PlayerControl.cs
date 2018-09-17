using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public Player playerControl;
    public Transform player;
    private Vector3 touchPos;
	
	// Update is called once per frame
	void Update () {

        if (playerControl.SwipeL)
        {
            touchPos += Vector3.left;
        }
        if (playerControl.SwipeR)
        {
            touchPos += Vector3.right;
        }
        if (playerControl.SwipeUp)
        {
            touchPos += Vector3.forward;
        }
        if (playerControl.SwipeDown)
        {
            touchPos += Vector3.back;
        }

        player.transform.position = Vector3.MoveTowards(player.transform.position, touchPos, 2.5f * Time.deltaTime);

        if (playerControl.Tap)
        {
            Debug.Log("Tappapi!");
        }

    }
}
