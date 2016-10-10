using UnityEngine;
using System.Collections;



public class MovimentacaoPersonagem : MonoBehaviour {


    public float velocidadeMov;
    public float velocidadeRot;
    
	// Use this for initialization
	void Start () {

        velocidadeMov = 4f;
        velocidadeRot = 1.2f;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("Vertical"))
        {
            transform.Rotate(0, 20 * velocidadeRot, 0);

        }



    }
}
