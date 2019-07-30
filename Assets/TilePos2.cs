using UnityEngine;
using System.Collections;

public class TilePos2 : MonoBehaviour {
	
	public GameObject T1;
	public GameObject T2;
	public GameObject T3;
	public GameObject T4;
	public GameObject T5;
	public GameObject T6;
	public GameObject T7;
	public GameObject T8;
	public GameObject T9;
	public GameObject T10;
	public GameObject T11;
	public GameObject T12;
	public GameObject T13;
	public GameObject T14;
	public GameObject T15;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GameObject T1 = GameObject.Find("Tile1");
		GameObject T2 = GameObject.Find("Tile2");
		GameObject T3 = GameObject.Find("Tile3");
		GameObject T4 = GameObject.Find("Tile4");
		GameObject T5 = GameObject.Find("Tile5");
		GameObject T6 = GameObject.Find("Tile6");
		GameObject T7 = GameObject.Find("Tile7");
		GameObject T8 = GameObject.Find("Tile8");
		GameObject T9 = GameObject.Find("Tile9");
		GameObject T10 = GameObject.Find("Tile10");
		GameObject T11 = GameObject.Find("Tile11");
		GameObject T12 = GameObject.Find("Tile12");
		GameObject T13 = GameObject.Find("Tile13");
		GameObject T14 = GameObject.Find("Tile14");
		GameObject T15 = GameObject.Find("Tile15");
		
		if(T1.transform.position.x == 0 && T1.transform.position.y == 0 &&
		   T2.transform.position.x == 1 && T2.transform.position.y == 0 &&
		   T3.transform.position.x == 2 && T3.transform.position.y == 0 &&
		   T4.transform.position.x == 3 && T4.transform.position.y == 0 &&
		   T5.transform.position.x == 0 && T5.transform.position.y == 1 &&
		   T6.transform.position.x == 1 && T6.transform.position.y == 1 &&
		   T7.transform.position.x == 2 && T7.transform.position.y == 1 &&
		   T8.transform.position.x == 3 && T8.transform.position.y == 1 &&
		   T9.transform.position.x == 0 && T9.transform.position.y == 2 &&
		   T10.transform.position.x == 1 && T10.transform.position.y == 2 &&
		   T11.transform.position.x == 2 && T11.transform.position.y == 2 &&
		   T12.transform.position.x == 3 && T12.transform.position.y == 2 &&
		   T13.transform.position.x == 0 && T13.transform.position.y == 3 &&
		   T14.transform.position.x == 1 && T14.transform.position.y == 3 &&
		   T15.transform.position.x == 2 && T15.transform.position.y == 3 
		   ){
			Application.LoadLevel ("end2");
		}
	}
}
