using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejarCamaras : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    private bool VistaPrimeraPersona;

    // Start is called before the first frame update
    void Start()
    {
        VistaPrimeraPersona = true;
        cam2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.V))
        {
            if (VistaPrimeraPersona)
            {
                VistaPrimeraPersona = false;
                cam2.enabled = true;
                cam1.enabled = false;

            }
            else
            {
                VistaPrimeraPersona = true;
                cam1.enabled = true;
                cam2.enabled = false;
            }


        }



    }
}
