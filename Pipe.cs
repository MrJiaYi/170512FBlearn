using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {

	void Start(){
		RandomGeneratePosition();
	}


	public void RandomGeneratePosition(){
		// how to random a number
		float pos_y = Random.Range(-0.4f,-0.1f);
		this.transform.localPosition = new Vector3( this.transform.localPosition.x,pos_y,this.transform.localPosition.z );

	}

	void OnTriggerExit(Collider other){//OnTriggerEnter OnTriggerStay OnTiggerExit
		if(other.tag=="Player"){
			// plus scroe
			GameManager._intance.score = GameManager._intance.score + 1;
		}
	}


	// test code
	void OnGUI(){
		GUILayout.Label("Score:"+GameManager._intance.score);
	}


}
