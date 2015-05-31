using UnityEngine;
using System.Collections;

public class Particle : MonoBehaviour {
	public ParticleSystem Flame;
	public bool enableEmission;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.W)){
			Flame.enableEmission = true;
			Debug.Log("lol");
		}

		if(Input.GetKeyUp(KeyCode.W)){
			Flame.enableEmission = false;
		};
		;
		

	
	}
}
