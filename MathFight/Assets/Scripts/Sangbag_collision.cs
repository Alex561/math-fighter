﻿using UnityEngine;
using System.Collections;

public class Sangbag_collision : MonoBehaviour {	
	Animator anim_sand;
	// Use this for initialization
	void Start () {
		anim_sand = GetComponent<Animator> ();
	}
	
	void Update ()
	{
		AnimatorStateInfo stateinfo = anim_sand.GetCurrentAnimatorStateInfo (0);
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Fist") {
			Debug.Log("HIT!!!!!!!!");
			anim_sand.SetTrigger("Shake");
		}
	}
	//void onCollisionExit(Collider other){
		//if (gameObject.tag == "Batman"){
			//
		//Debug.Log ("bam");
		//}
	//}

}