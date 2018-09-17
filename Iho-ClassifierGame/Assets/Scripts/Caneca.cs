using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Caneca : MonoBehaviour {

    public Score puntaje;
    public string basuraCorrecta;
    

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == basuraCorrecta)
        {

            puntaje.actual += 1;
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.position = new Vector3(0f, 0f, 0f);
            collision.gameObject.SetActive(true);

            Debug.Log("colision");
        }
        else
        {
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.position = new Vector3(0f, 0f, 0f);
            collision.gameObject.SetActive(true);
            puntaje.errores += 1;
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == basuraCorrecta)
        {
            puntaje.actual += 1;
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.position = new Vector3(0f, 0f, 0f);
            collision.gameObject.SetActive(true);

            Debug.Log("colision");
        }
        else
        {
            collision.gameObject.SetActive(false);
            collision.gameObject.transform.position = new Vector3(0f, 0f, 0f);
            collision.gameObject.SetActive(true);
            puntaje.errores += 1;
        }
    }

    /*
        {
            if(other.gameObject == basura_Correcta)
            {
                puntaje.actual += 1;
                other.gameObject.SetActive(false);
                other.gameObject.transform.position = new Vector3(0f, 0f, 0f);
                other.gameObject.SetActive(true);
            }



        }
        */
}
