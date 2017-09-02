using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {

	private GameObject unitychan;
	private float difference;

	// Use this for initialization
	void Start () {
		
		this.unitychan = GameObject.Find ("unitychan");
		
	}
	
	// Update is called once per frame
	void Update () {
		this.difference =  this.transform.position.z - unitychan.transform.position.z;


		if(this.difference < -5.0f){
				Destroy (this.gameObject);
			}
			
		
	}
}
