using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class problemGenerator : MonoBehaviour {
	public Text problemText;
	public Text turnText;
	public Text timeText;
	public Text answerC1;
	public Text answerC2;
	public Text Ap1;
	public Text Ap2;
	public List<string> unitCircle;
	bool correct = false;
	public int ap1 = 3;
	public int ap2= 3;
	public bool p1Turn = true;
	public string question;
	string answer1 = "p1";
	string answer2 = "p2";
	float countdown = 12.0f;

	void Start () {

		problemText.text = "placeholder";
		answerC1.text = "Z: 1/2 \n" +
					     "X: sqrt(3)/2 \n" +
						 "C:0 \n" +
						 "V:1";
		answerC2.text = "1: 1/2 \n" +
			"2: sqrt(3)/2 \n" +
				"3:0 \n" +
				"4:1";
		createUnitCircle ();
		question = changeProblem ();
		turnText.text = "player 1's turn";
	
	}
	void createUnitCircle()	{
		unitCircle.Add ("What is sin30°?");
		unitCircle.Add ("What is cos30°?");
		unitCircle.Add ("What is tan45°?");
		unitCircle.Add ("What is cos60°?");
		unitCircle.Add ("What is cos90°?");
	}
	public string changeProblem(){
		int n = Random.Range (0, unitCircle.Count);
		Debug.Log ("I was called");
		problemText.text = unitCircle[n];
		string q = (n.ToString() + "U");
		return q;
	}
	int checkSolution(string a,int ap){
		Debug.Log ("going to checker to check: " + a);
		switch (question) {
		case "0U":
			if (a =="1/2"){
				Debug.Log("sin 30 is 1/2!!!!!!!!");
				return ap+=1;
			}
			else
				return ap-=1;
		case "1U":
			if (a == "s3/2"){
				Debug.Log("cos 30 is s3/2!!!!!!!!");
				return ap+=1;
			}
			else 
				return ap -=1;
		case "2U":
			if (a == "1"){
				Debug.Log("tan is 45!!!!!!!!");
				return ap+=1;
			}
			else 
				return ap -=1;
		case "3U":
			if (a == "1/2")
			{
				Debug.Log("cos 60 is 1/2!!!!!!!!");
				return ap+=1;
			}
			else 
				return ap -=1;
		case "4U":
			if (a == "0")
			{
				Debug.Log("cos 90 is 0!!!!!!!!");
				return ap+=1;
			}
			else 
				return ap -=1;
		default:
			return ap;
		}
	}
	
	void OnGUI(){
		answer1 = GUI.TextField(new Rect(190,600,200,20),answer1,25);
		answer2 = GUI.TextField(new Rect(1000,600,200,20),answer2,25);
	}

	public void flipTurn(){
		p1Turn = ! p1Turn;
		if (p1Turn == true) {
			turnText.text = "player 1's turn";
		}
		if (p1Turn == false) {
			turnText.text = "player 2's turn";
		}
		countdown = 12f;
	}
	void apManager()
	{
		if (ap1<0)
			ap1 = 0;
		Ap1.text = ("ap1: " + ap1.ToString());
		if (ap2<0)
			ap2 = 0;
		Ap2.text = ("ap2: " + ap2.ToString());
	}
	// Update is called once per frame
	void Update () {
		//countdown
		countdown -= Time.deltaTime;
		countdown = Mathf.Round(countdown *100f)/100f;
		timeText.text = countdown.ToString();
		if (countdown <= 0) {
			flipTurn();
		}
		//player 1 enters answer
		if (Input.GetKeyDown (KeyCode.Q) && p1Turn) {
			Debug.Log("pre solution ap" + ap1.ToString());
			ap1 = checkSolution(answer1,ap1);//check if right
			Debug.Log("post solution ap" + ap1.ToString());
			question = changeProblem ();//make a new question
			flipTurn();
		}
		//player 2 eneters answer
		if (Input.GetKeyDown (KeyCode.P)&& !p1Turn) {
			ap2 = checkSolution(answer2,ap2);
			question = changeProblem ();
			flipTurn ();

		}
		apManager();
	}
}
