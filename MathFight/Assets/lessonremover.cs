﻿using UnityEngine;
using System.Collections;

public class lessonremover : MonoBehaviour {
	//public string[] dialogue={"Math Lessons","This is a test"};
	//int index=0;
	//Rect dialoguerect=new Rect(435,100,500,50);
	public bool flip=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("return")) {
			flip=true;

		}
	
	}

	// this is suppose to make the text mesh fall from the screen when enter is pressed but it wont do that, please help.......
	void OnTriggerEnter(Collider other)
	{ 
		if ((flip == true)) {
			if(other.tag == "text_on_bag")
			{
				Debug.Log ("what the fucks going on");
				other.attachedRigidbody.useGravity = true;
				other.attachedRigidbody.isKinematic = false;
			}
		}
	}
	/*void OnGUI()
	{
		if (index < dialogue.Length) {
			GUI.Box (dialoguerect, dialogue [index]);
		}
		else{
		}
	}*/
}
