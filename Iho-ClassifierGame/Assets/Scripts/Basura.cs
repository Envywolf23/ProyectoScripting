using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Basura : MonoBehaviour {

    //private bool tiempoExtra;
    //private bool detenerTiempo;
    //private bool especial;
    public float speed = 10f;

  /*  public bool TiempoExtra
    {
        get
        {
            return tiempoExtra;
        }

        set
        {
            tiempoExtra = value;
        }
    }

    public bool Especial
    {
        get
        {
            return especial;
        }

        set
        {
            especial = value;
        }
    }

    public bool DetenerTiempo
    {
        get
        {
            return detenerTiempo;
        }

        set
        {
            detenerTiempo = value;
        }
    }

    */
    void Awake () {

    /*  float seleccionador = Random.Range(0f, 10f);
        if(seleccionador <= 7f)
        {
            Especial = false;
            Debug.Log("Basura normal");
        } 

        else if (seleccionador >= 8f)
        {
            Especial = true;
        }

        if(Especial == true)
        {
            float genEspecial = Random.Range(0f, 6f);

            if(genEspecial <= 3f)
            {
                TiempoExtra = true;
                Debug.Log("Basura Tiempo Extra");
            }
            else if(genEspecial <= 6f && genEspecial > 3f)
            {
                DetenerTiempo = true;
                Debug.Log("Basura Detener Tiempo");
            }
        }
	*/	
	}
	
	// Update is called once per frame
	public virtual void Update () {
        
    }
}
