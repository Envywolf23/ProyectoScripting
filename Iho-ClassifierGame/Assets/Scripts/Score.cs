using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public TextMeshProUGUI textMeta;
    public TextMeshProUGUI textTiempo;
    public int meta;
    public int actual;
    public float tiempo;
    public TextMeshProUGUI textErrores;
    public int errores;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tiempo = tiempo + Time.deltaTime;

        textMeta.text = actual + "/" + meta;
        textTiempo.text = "Tiempo = " + tiempo.ToString("F0");
        textErrores.text = "Errores = " + errores.ToString("F0");

        if (tiempo > 20)
        { 
            if(meta > actual)
            {
                SceneManager.LoadScene(2);
            }
        }

        if(actual == meta)
        {
            SceneManager.LoadScene(1);
        }

        if(errores == 3)
        {
            SceneManager.LoadScene(2);
        }
	}
}
