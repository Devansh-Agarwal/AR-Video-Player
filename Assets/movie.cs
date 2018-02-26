using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movie : MonoBehaviour {

	public MovieTexture mov;// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().material.mainTexture = mov;
		mov.Play ();
		mov.loop =true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
