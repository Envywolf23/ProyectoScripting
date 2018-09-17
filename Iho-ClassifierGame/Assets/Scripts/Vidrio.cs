using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidrio : Basura {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public override void Update()
    {

        float translationVertical = Input.GetAxis("Vertical") * speed;

        translationVertical *= Time.deltaTime;

        float translationHorizontal = Input.GetAxis("Horizontal") * speed;

        translationHorizontal *= Time.deltaTime;

        transform.Translate(0, translationVertical, 0);
        transform.Translate(translationHorizontal, 0, 0);
    }
}
