using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour {


	public GameObject chedkPointPrefab;

	//carPrefabを入れる
	public GameObject carPrefab;
	//coinPrefabを入れる
	public GameObject coinPrefab;
	//cornPrefabを入れる
	public GameObject conePrefab;
	//アイテムを出すx方向の範囲
	private float posRange = 3.4f;
	//ユニティちゃんを探す
	private GameObject unitychan;

	//スタート地点
	private int startPos = -160;
	//ゴール地点
	private int goalPos = 120;


	// Use this for initialization
	void Start () {

		this.unitychan = GameObject.Find ("unitychan");


		//GameObject cp = Instantiate (chedkPointPrefab) as GameObject;
		//cp.transform.position = new Vector3 (0, 2.5, -100);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){

		//アイテムの種類を決める
		int item = Random.Range(1,11);

		//for(int k = startPos+45; k < goalPos - 50 ; k += 40){

		if (other.gameObject.tag == "UnityChanTag") {
			GameObject cp = Instantiate (chedkPointPrefab) as GameObject;
			cp.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z + 40);
		

			int num = Random.Range(0,10);
			if(num <= 1){
				//コーンをx軸方向に一直線に生成
				for(float j = -1 ; j <= 1 ; j += 0.4f){
					GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, cp.transform.position.z + 40);
				}

			}else{


				//レーンごとにアイテムを生成
				for(int j = -1 ; j < 2 ; j++){

					//アイテムを置くz座標のオフセットをランダムに設定
					int offsetZ = Random.Range(-15,16);
					//60%コイン配置:30%車配置:10%何もなし
					if(1 <= item && item <= 6){
						//コインを生成
						GameObject coin = Instantiate(coinPrefab) as GameObject;
						coin.transform.position = new Vector3(posRange * j , coin.transform.position.y,cp.transform.position.z + 40 + offsetZ);
					}else if(7 <= item && item <= 9){
						//車を生成
						GameObject car = Instantiate(carPrefab) as GameObject;
						car.transform.position = new Vector3(posRange*j,car.transform.position.y,cp.transform.position.z + 40 + offsetZ);
						}
					}

				}
			}

		}
			//}



}
