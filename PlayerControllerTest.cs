using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	//問題１
    //public　boolとprivateでそれぞれを宣言している
	public bool CanTrack;
	public bool collided;
	private Vector3 position;
	private Vector3 WorldPointPos;

	void Update (){
		//問題２
        //CanTrackの時Track（）を呼び出す
		if(CanTrack){
			Track();
		}
		//問題３
        //マウスの左クリックで重力で落ちていくSleepingかつCanTrackで色が変化する
		if(Input.GetMouseButtonDown(0)){
			CanTrack = false;
			GetComponent<Rigidbody>().useGravity = true;
		}
		if(GetComponent<Rigidbody>().IsSleeping() && CanTrack == false){
			GetComponent<MeshRenderer>().material.color *= new Color(0.2f, 0.2f, 0.2f, 0.5f);
		}
	}
	void Track(){
		//問題４
        //マウスポインターの場所にブロックがついてきて、ブロックがBaseの外に行かないようにしている
		position = Input.mousePosition;
		position.z = -Camera.main.transform.position.z;
		WorldPointPos = Camera.main.ScreenToWorldPoint(position);

		float MoveRangeX = GameObject.Find("Base").transform.localScale.x/2;

		if (WorldPointPos.x <= -MoveRangeX) {
			WorldPointPos.x = -MoveRangeX;
		} else if (WorldPointPos.x >= MoveRangeX) {
			WorldPointPos.x = MoveRangeX;
		}

		WorldPointPos.y = GameObject.Find("SpawnPoint").transform.position.y;
		gameObject.transform.position = WorldPointPos;
	}
	//問題５
   // 両方ともfalseならスポーンポイントに次のキューブがスポーンされる
	void OnCollisionEnter(){
		if(collided == false && CanTrack == false){

			GameObject.Find("SpawnPoint").GetComponent<Spawner>().SpawnCube();
			collided = true;
		}
	}
}