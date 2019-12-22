using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backcontroller : MonoBehaviour {


    public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(
            Player.transform.position.x, this.transform.position.y, this.transform.position.z);
	}
}
