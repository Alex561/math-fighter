using UnityEngine;
using System.Collections;

public class p1Controller : MonoBehaviour {

	public problemGenerator pg;
	public hp hp2;
	public AnimationClip a;
	public AnimationClip b;
	public Animation anim;
	// Use this for initialization
	void Start () {
		pg = GameObject.Find("problems").GetComponent<problemGenerator>();
		hp2 = GameObject.Find ("HP2").GetComponent<hp> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.W))
		{
			
			pg.ap1 -=1;
			Debug.Log("w");
			hp2.health -=1;
			anim = GetComponent<Animation>();
			anim.AddClip(a, "Punch");
			anim.Play();
		}
		
	}
}
