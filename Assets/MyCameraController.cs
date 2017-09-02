using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour {

	//Unityちゃんのオブジェクト
	private GameObject unitychan;
	//Unityちゃんとカメラの距離
	private float difference;

	// Use this for initialization
	void Start () {
		//Unityちゃんのオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
		//unityちゃんとカメラの位置（z座標の差を求める）
		this.difference = unitychan.transform.position.z - this.transform.position.z;

		
	}
	
	// Update is called once per frame
	void Update () {
		//Unityちゃんの位置に合わせてカメラの位置を移動
		//Q.xは0？ this.transform.position.xではないの？
		//this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,this.unitychan.transform.position.z-difference);
		this.transform.position = new Vector3(0,this.transform.position.y,this.unitychan.transform.position.z-difference);
			
		
	}
}
