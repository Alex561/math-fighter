using UnityEngine;
using System.Collections;

public class p1Controller : MonoBehaviour {

	public problemGenerator pg;
	public hp hp2;
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
			///call punch animation
		}
		
	}
}
