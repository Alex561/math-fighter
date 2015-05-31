using UnityEngine;
using System.Collections;

public class Particle : MonoBehaviour {
	public ParticleSystem Flame;
	public bool enableEmission;
	public problemGenerator pg;
	void Start () {
		pg = GameObject.Find ("problems").GetComponent<problemGenerator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.W)&& pg.ap1!=0){
			Flame.enableEmission = true;
			Debug.Log("lol");
		}

		if(Input.GetKeyUp(KeyCode.W)){
			Flame.enableEmission = false;
		};
		;
		

	
	}
}
