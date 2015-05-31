using UnityEngine;
using System.Collections;

public class p1Controller : MonoBehaviour {

	public problemGenerator pg;
	public hp hp2;
	public AudioClip correctSound;
	public AudioClip wrongSound;
	public AudioClip punch;
	private AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		pg = GameObject.Find("problems").GetComponent<problemGenerator>();
		hp2 = GameObject.Find ("HP2").GetComponent<hp> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.W)&& pg.ap1!=0)
		{
			
			pg.ap1 -=1;
			Debug.Log("w");
			//put punch animation
			source.PlayOneShot(punch,5f);
			hp2.health -=1;
		
		}
		if (Input.GetKeyDown(KeyCode.Z)&& pg.p1Turn){
			if(pg.question== ("0U") || pg.question == ("3U")){
				pg.ap1+=1;
				source.PlayOneShot(correctSound,.5f);}
			else{
				pg.ap1-=1;
				source.PlayOneShot(wrongSound,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.C)&& pg.p1Turn){
			if(pg.question== ("4U") ){
				pg.ap1+=1;
			source.PlayOneShot(correctSound,.5f);}
			else{
				pg.ap1-=1;
				source.PlayOneShot(wrongSound,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.X)&& pg.p1Turn){
			if(pg.question== ("1U")){
				pg.ap1+=1;
			source.PlayOneShot(correctSound,.5f);}
			else{
				pg.ap1-=1;
				source.PlayOneShot(wrongSound,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.V)&& pg.p1Turn){
			if(pg.question== ("2U") ){
				pg.ap1+=1;
			source.PlayOneShot(wrongSound,.5f);}
			else{
				pg.ap1-=1;
				source.PlayOneShot(correctSound,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		
	}
}
