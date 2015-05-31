using UnityEngine;
using System.Collections;

public class ParticleS : MonoBehaviour {
	public ParticleSystem Flame;
	public bool enableEmission;
	public problemGenerator pg;
	void Start () {
		pg = GameObject.Find ("problems").GetComponent<problemGenerator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.O)&& pg.ap2!=0){
			Flame.enableEmission = true;
			Debug.Log("lol");
		}
		
		if(Input.GetKeyUp(KeyCode.O)){
			Flame.enableEmission = false;
		};
		;
		
		
		
	}
}
