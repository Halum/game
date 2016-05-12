using UnityEngine;
using System.Collections;

public class ScreenAdjust : MonoBehaviour {
	public float SCREEN_WIDTH = 1080f;
	public float SCREEN_HEIGHT = 1920f;

	// Use this for initialization
	void Start () {
		Camera.main.aspect = SCREEN_WIDTH / SCREEN_HEIGHT;
	}
}
