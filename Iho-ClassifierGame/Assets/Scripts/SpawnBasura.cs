using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBasura : MonoBehaviour {

    public GameObject metal, vidrio, papel, plastico;
    GameObject objClonar;

    private void Awake()
    {
        float basura = Random.Range(0f, 4f);
        if(basura <= 1f)
        {
            objClonar = metal;
        }
        else if(basura <= 2f && basura > 1f)
        {
            objClonar = vidrio;
        }
        else if(basura <= 3f && basura > 2f)
        {
            objClonar = papel;
        }
        else if(basura <= 4f && basura > 3f)
        {
            objClonar = plastico;
        }

        Vector3 position = new Vector3(0f, 0f, 0f);

        GameObject clon = Instantiate(objClonar, position , Quaternion.identity);
        Renderer clonRedner = clon.GetComponent<Renderer>();
        Rigidbody clonBody = clon.GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
    }
}
