using UnityEngine;
using System.Collections;

public class End2Script : MonoBehaviour {
	private GUIStyle style;
	
	// Use this for initialization
	void Start () {
		style = new GUIStyle();
		style.fontSize = 30;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Application.LoadLevel ("title");
		}
	}
	
	void OnGUI(){
		GUI.Label (new Rect(Screen.width / 2, Screen.height / 2, 128, 32),"クリア！！！", style);
	}
}