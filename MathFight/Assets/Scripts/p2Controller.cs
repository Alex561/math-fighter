using UnityEngine;
using System.Collections;

public class p2Controller : MonoBehaviour {

	public problemGenerator pg;
	public hp hp1;
	public AudioClip correctSound1;
	public AudioClip wrongSound1;
	public AudioClip punch;
	private AudioSource source;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		pg = GameObject.Find("problems").GetComponent<problemGenerator>();
		hp1 = GameObject.Find ("HP1").GetComponent<hp> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.O) && pg.ap2 !=0)
		{
			
			pg.ap2 -=1;
			Debug.Log("o");
			hp1.health-=1;
			///call punch
			source.PlayOneShot(punch,5f);
		}
		if (Input.GetKeyDown(KeyCode.B)){
			if(pg.question== ("0U") || pg.question == ("3U")){
				pg.ap2+=1;
				source.PlayOneShot(correctSound1,.5f);}
			else{
				pg.ap2-=1;
				source.PlayOneShot(wrongSound1,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.N)){
			if(pg.question== ("1U") ){
				pg.ap2+=1;
			source.PlayOneShot(correctSound1,.5f);}
			else{
				pg.ap2-=1;
				source.PlayOneShot(wrongSound1,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.M)){
			if(pg.question== ("4U")){
				pg.ap2+=1;
				source.PlayOneShot(correctSound1,.5f);}
			else{
				pg.ap2-=1;
				source.PlayOneShot(wrongSound1,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.Comma)){
			if(pg.question== ("2U") ){
				pg.ap2+=1;
				source.PlayOneShot(correctSound1,.5f);}
			else{
				pg.ap2-=1;
				source.PlayOneShot(wrongSound1,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (hp1.health == 0)
			Application.LoadLevel ("SteveWins");

	}
}
