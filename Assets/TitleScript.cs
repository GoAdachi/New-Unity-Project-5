using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {
	private GUIStyle style;

	// Use this for initialization
	void Start () {
			style = new GUIStyle();
			style.fontSize = 50;
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonDown (0)) {
			Application.LoadLevel ("scene");
		}
	}

	void OnGUI(){
		GUI.Label (new Rect(Screen.width / 2.8f, Screen.height / 2, 128, 32),"ミカンパズル", style);
}
}