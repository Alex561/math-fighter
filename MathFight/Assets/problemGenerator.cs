using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class problemGenerator : MonoBehaviour {
	public Text problemText;
	public Text turnText;
	public Text timeText;
	public List<string> unitCircle;
	bool correct = false;
	public int ap1 = 3;
	public int ap2= 3;
	bool p1Turn = true;
	string question;
	string answer1 = "p1";
	string answer2 = "p2";
	float countdown = 10.0f;

	void Start () {

		problemText.text = "placeholder";
		createUnitCircle ();
		question = changeProblem ();
		turnText.text = "player 1's turn";
	
	}
	void createUnitCircle()	{
		unitCircle.Add ("What is sin30°?");
		unitCircle.Add ("What is tan30°?");
		unitCircle.Add ("What is sin45°?");
		unitCircle.Add ("What is cos60°?");
		unitCircle.Add ("What is cos90°?");
	}
	string changeProblem(){
		int n = Random.Range (0, unitCircle.Count);
		problemText.text = unitCircle[n];
		string q = (n.ToString() + "U");
		return q;
	}
	int checkSolution(string a,int ap){
		switch (question) {
		case "0U":
			if (a =="1/2")
				return ap+=1;
			else
				return ap-=1;
		case "1U":
			return ap;
		case "2U":
			return ap;
		case "3U":
			return ap;
		case "4U":
			return ap;
		default:
			return ap;
		}
	}
	
	void OnGUI(){
		answer1 = GUI.TextField(new Rect(190,600,200,20),answer1,25);
		answer2 = GUI.TextField(new Rect(1000,600,200,20),answer2,25);
	}

	void flipTurn(){
		p1Turn = ! p1Turn;
		if (p1Turn == true) {
			turnText.text = "player 1's turn";
		}
		if (p1Turn == false) {
			turnText.text = "player 2's turn";
		}
		countdown = 10f;
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
		
			ap1 = checkSolution(answer1,ap1);//check if right
			print ("ap1: " + ap1.ToString());
			question = changeProblem ();//make a new question
			flipTurn();
		}
		//player 2 eneters answer
		if (Input.GetKeyDown (KeyCode.P)&& !p1Turn) {
			ap2 = checkSolution(answer2,ap2);
			print("ap2: " + ap2.ToString());
			question = changeProblem ();
			flipTurn ();
		}
		//add points
		if (correct) {
			correct=false;
		}
	}
}
