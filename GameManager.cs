using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	// define the state of the game
	public static int GAMESTATE_MENU 		=0;//游戏菜单状态
	public static int GAMESTATE_PLAYING		=1;//游戏中状态 ... 
	public static int GAMESTATE_END			=2;//游戏结束状态


	public Transform firstBg;

	public int score = 0;

	bool jiasu1 = false;
	bool jiasu2 = false;

	public int GameState  = GAMESTATE_MENU;

	public static GameManager _intance;

	private GameObject bird;

	void Awake(){
		_intance = this;
		bird = GameObject.FindGameObjectWithTag("Player");
	}

	void Update(){
		if(GameState==GameManager.GAMESTATE_MENU){
			if(Input.GetMouseButtonDown(0)){
				// transform state
				GameState = GAMESTATE_PLAYING;
				// set bird is playing 
				// 1.set gravity 2.add velocity of x
				bird.SendMessage("getLife");
			}
		}

		if (score > 5) {
			if(!jiasu1){
				bird.SendMessage("speedUp");
				jiasu1 = true;
			}
		}
		if (score > 10) {
			if(!jiasu2){
				bird.SendMessage("speedUp");
				jiasu2 = true;
			}
		}
	}

	//test code
	void OnGUI(){
		string str = "SCORE : ";
		str = str + score;
		GUILayout.Label(str);
	}
}
