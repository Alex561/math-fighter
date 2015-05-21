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
	void checkSolution(string a){
		switch (question) {
		case "0U":
			print ('0');
			break;
		case "1U":
			print ('1');
			break;
		case "2U":
			print ('2');
			break;
		case "3U":
			print ('3');
			break;
		case "4U":
			print ('4');
			break;
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
		countdown = 6.1f;
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
		
			checkSolution (answer1);//check if right
			question = changeProblem ();//make a new question
			flipTurn();
		}
		//player 2 eneters answer
		if (Input.GetKeyDown (KeyCode.P)&& !p1Turn) {
			checkSolution(answer2);
			question = changeProblem ();
			flipTurn ();
		}
		//add points
		if (correct) {
			correct=false;
		}
	}
}
