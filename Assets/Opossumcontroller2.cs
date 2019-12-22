using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opossumcontroller2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name =="Tilemap")

        Debug.Log(collision.gameObject.name);
    }
}
