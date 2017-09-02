﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGeneratorKadai : MonoBehaviour {


		//carPrefabを入れる
		public GameObject carPrefab;
		//coinPrefabを入れる
		public GameObject coinPrefab;
		//cornPrefabを入れる
		public GameObject conePrefab;
		//スタート地点
		private int startPos = -160;
		//ゴール地点
		private int goalPos = 120;
		//アイテムを出すx方向の範囲
		private float posRange = 3.4f;

		//ユニティちゃんを探す
		//private GameObject unitychan;
		//ユニティちゃんの進んだ距離
	//private float span =3.0f;
	//private float delta = 0;




		// Use this for initialization
		void Start () {

			



			//一定の距離ごとにアイテムを生成
		//スタート地点から45mまでアイテム生成
		for(int i = startPos; i <= startPos + 45 ; i += 15){
				//どのアイテムを出すのかをランダムに設定
				int num = Random.Range(0,10);
				if(num <= 1){
					//コーンをx軸方向に一直線に生成
					//Q.なぜこれで一直線に複数個生成されるの？→-1/-0.6/-0.2/0.2/0.6/1の範囲で0.4刻みで生成
					for(float j = -1 ; j <= 1 ; j += 0.4f){
						GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, i);
					}

				}else{

					//レーンごとにアイテムを生成
					for(int j = -1 ; j < 2 ; j++){
						//アイテムの種類を決める
						int item = Random.Range(1,11);
						//アイテムを置くz座標のオフセットをランダムに設定
						int offsetZ = Random.Range(-5,6);
						//60%コイン配置:30%車配置:10%何もなし
						if(1 <= item && item <= 6){
							//コインを生成
							GameObject coin = Instantiate(coinPrefab) as GameObject;
						coin.transform.position = new Vector3(posRange * j , coin.transform.position.y,i + offsetZ);
						}else if(7 <= item && item <= 9){
							//車を生成
							GameObject car = Instantiate(carPrefab) as GameObject;
						car.transform.position = new Vector3(posRange*j,car.transform.position.y,i + offsetZ);
						}
					}

				}
			}



		}


		// Update is called once per frame
		void Update () {
		/*
			
		this.unitychan = GameObject.Find ("unitychan");

		this.delta += Time.deltaTime;

		if(this.delta > this.span){
			this.delta = 0;
			
		//一定の距離ごとにアイテムを生成
			for(int i = this.unitychan.transform.position.z + 40 ; this.unitychan.transform.position.z + 50 ; i += 10){
			//どのアイテムを出すのかをランダムに設定
			int num = Random.Range(0,10);
			if(num <= 1){
				//コーンをx軸方向に一直線に生成
				for(float j = -1 ; j <= 1 ; j += 0.4f){
					GameObject cone = Instantiate (conePrefab) as GameObject;
					cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, i);
				}

			}else{

				//レーンごとにアイテムを生成
				for(int j = -1 ; j < 2 ; j++){
					//アイテムの種類を決める
					int item = Random.Range(1,11);
					//アイテムを置くz座標のオフセットをランダムに設定
					int offsetZ = Random.Range(-5,6);
					//60%コイン配置:30%車配置:10%何もなし
					if(1 <= item && item <= 6){
						//コインを生成
						GameObject coin = Instantiate(coinPrefab) as GameObject;
						coin.transform.position = new Vector3(posRange * j , coin.transform.position.y,i + offsetZ);
					}else if(7 <= item && item <= 9){
						//車を生成
						GameObject car = Instantiate(carPrefab) as GameObject;
						car.transform.position = new Vector3(posRange*j,car.transform.position.y,i + offsetZ);
					}
				}

			}
		}
		
	}
	*/
	}

	}
