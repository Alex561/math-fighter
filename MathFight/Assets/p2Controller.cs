using UnityEngine;
using System.Collections;

public class p2Controller : MonoBehaviour {

	public problemGenerator pg;
	public hp hp1;
	// Use this for initialization
	void Start () {
		pg = GameObject.Find("problems").GetComponent<problemGenerator>();
		hp1 = GameObject.Find ("HP1").GetComponent<hp> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.O))
		{
			
			pg.ap2 -=1;
			Debug.Log("o");
			hp1.health-=1;
			///call punch
		}
		if (Input.GetKeyDown(KeyCode.Alpha1)&& !pg.p1Turn){
			if(pg.question== ("0U") || pg.question == ("3U"))
				pg.ap2+=1;
			else
				pg.ap2-=1;
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.Alpha2)&& !pg.p1Turn){
			if(pg.question== ("4U") )
				pg.ap2+=1;
			else
				pg.ap2-=1;
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.Alpha3)&& pg.p1Turn){
			if(pg.question== ("1U"))
				pg.ap2+=1;
			else
				pg.ap2-=1;
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.Alpha4)&& pg.p1Turn){
			if(pg.question== ("2U") )
				pg.ap2+=1;
			else
				pg.ap2-=1;
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}

	}
}
