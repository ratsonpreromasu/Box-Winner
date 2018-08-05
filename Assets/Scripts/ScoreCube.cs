using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCube : MonoBehaviour
{
	
	public Text score1;
	public Text score2;
	public Text winText;

	private int firstPlayerScore;
	private int secondPlayerScore;

	public GameObject turn1;
	public GameObject turn2;
	public GameObject wINpANEL;

	private bool one;
	private bool two;
	private bool three;
	private bool four;
	private bool five;
	private bool six;
	private bool seven;
	private bool eight;
	private bool nine;

	// Use this for initialization

	public GameObject Scorecube;
	public GameObject Scorecube1;
	public GameObject Scorecube2;
	public GameObject Scorecube3;
	public GameObject Scorecube4;
	public GameObject Scorecube5;
	public GameObject Scorecube6;
	public GameObject Scorecube7;
	public GameObject Scorecube8;
	public GameObject cyc1;
	public GameObject cyc2;
	public GameObject cyc3;
	public GameObject cyc4;
	public GameObject cyc5;
	public GameObject cyc6;
	public GameObject cyc7;
	public GameObject cyc8;
	public GameObject cyc9;
	public GameObject cyc10;
	public GameObject cyc11;
	public GameObject cyc12;
	public GameObject cyc13;
	public GameObject cyc14;
	public GameObject cyc15;
	public GameObject cyc16;
	public GameObject cyc17;
	public GameObject cyc18;
	public GameObject cyc19;
	public GameObject cyc20;
	public GameObject cyc21;
	public GameObject cyc22;
	public GameObject cyc23;
	public GameObject cyc24;

	public GameObject Scorecube9;
	public GameObject Scorecube10;
	public GameObject Scorecube11;
	public GameObject Scorecube12;
	public GameObject Scorecube13;
	public GameObject Scorecube14;
	public GameObject Scorecube15;
	public GameObject Scorecube16;
	public GameObject Scorecube17;
	AIScript AiMove;
	public List<GameObject> Objectlist;
	public bool scored;
	public bool moved;

	public List<GameObject> getClick;
	public List<GameObject> Vissible;
//	public List<GameObject> scoreCube;


	void Start ()
	{
		Reset();
		one = false;
		two = false;
		three = false;
		four = false;
		five = false;
		six = false;
		seven = false;
		eight = false;
		nine = false;
		moved = false;
		PlayerPrefs.SetInt ("AisMove",0);
		scored = false;
		firstPlayerScore = 0;
		secondPlayerScore = 0;
		wINpANEL.SetActive (false);
		PlayerPrefs.SetInt ("Turn",0);
		Scorecube.SetActive (false);
		Scorecube1.SetActive (false);
		Scorecube2.SetActive (false);
		Scorecube3.SetActive (false);
		Scorecube4.SetActive (false);
		Scorecube5.SetActive (false);
		Scorecube6.SetActive (false);
		Scorecube7.SetActive (false);
		Scorecube8.SetActive (false);
		cyc1.SetActive (false);
		cyc2.SetActive (false);
		cyc3.SetActive (false);
		cyc4.SetActive (false);
		cyc5.SetActive (false);
		cyc6.SetActive (false);
		cyc7.SetActive (false);
		cyc8.SetActive (false);
		cyc9.SetActive (false);
		cyc10.SetActive (false);
		cyc11.SetActive (false);
		cyc12.SetActive (false);
		cyc13.SetActive (false);
		cyc14.SetActive (false);
		cyc15.SetActive (false);
		cyc16.SetActive (false);
		cyc17.SetActive (false);
		cyc18.SetActive (false);
		cyc19.SetActive (false);
		cyc20.SetActive (false);
		cyc21.SetActive (false);
		cyc22.SetActive (false);
		cyc23.SetActive (false);
		cyc24.SetActive (false);
		Scorecube9.SetActive (false);
		Scorecube10.SetActive (false);
		Scorecube11.SetActive (false);
		Scorecube12.SetActive (false);
		Scorecube13.SetActive (false);
		Scorecube14.SetActive (false);
		Scorecube15.SetActive (false);
		Scorecube16.SetActive (false);
		Scorecube17.SetActive (false);

		AiMove= new AIScript ();
		score1.text = "Blue : " + firstPlayerScore.ToString ();
		score2.text = "Green : " + secondPlayerScore.ToString ();
	}
	
	// Update is called once per frame
	void Update ()
	{

		if(firstPlayerScore+secondPlayerScore==9){
			wINpANEL.SetActive (true);
			if (firstPlayerScore > secondPlayerScore) {
				winText.text = "Blue  Has  Won";
			} 
			else {
				winText.text = "Green  Has  Won";
			}
			
		}

		if(PlayerPrefs.GetInt("Start")==1){

			if(PlayerPrefs.GetInt("Turn")==0){
				turn1.SetActive (true);
				turn2.SetActive (false);

			}
			else if(PlayerPrefs.GetInt("Turn")==1){
				turn1.SetActive (false);
				turn2.SetActive (true);
			}

		}
		if(PlayerPrefs.GetInt("Start")==0){

			turn1.SetActive (false);
			turn2.SetActive (false);

		}



		if(PlayerPrefs.GetInt("AIPlayer")==1 && PlayerPrefs.GetInt("Turn")==1 && firstPlayerScore+secondPlayerScore<=9){
			MakeAMove();
			moved = false;
			//MakeAMove ();
		}

		if ( !one && cyc1.activeInHierarchy == true && 
			cyc4.activeInHierarchy  ==true &&
			cyc5.activeInHierarchy ==true && 
			cyc8.activeInHierarchy ==true)

		{
			scored = true;
			//Debug.Log ("entering");
			if(PlayerPrefs.GetInt("Turn")==0){
				firstPlayerScore += 1;
				score1.text = "Blue : " + firstPlayerScore.ToString ();
				Scorecube.SetActive (true);
				one = true;
			}
			else if(PlayerPrefs.GetInt("Turn")==1){
				secondPlayerScore += 1;
				score2.text = "Green : " + secondPlayerScore.ToString ();
				Scorecube9.SetActive (true);
				one = true;
			}

		}

		if (!two && cyc2.activeInHierarchy == true && 
			cyc5.activeInHierarchy ==true &&
			cyc6.activeInHierarchy ==true && 
			cyc9 .activeInHierarchy ==true)

		{
			scored = true;
			if(PlayerPrefs.GetInt("Turn")==0){
				firstPlayerScore += 1;
				score1.text = "Blue : " + firstPlayerScore.ToString ();
				Scorecube1.SetActive (true);
				two = true;
			}
			else if(PlayerPrefs.GetInt("Turn")==1){
				secondPlayerScore += 1;
				score2.text = "Green : " + secondPlayerScore.ToString ();
				Scorecube10.SetActive (true);
				two = true;
			}


		}

		if ( !three &&cyc3.activeInHierarchy == true && 
			cyc7.activeInHierarchy ==true &&
			cyc6.activeInHierarchy ==true && 
			cyc10 .activeInHierarchy ==true)

		{
			scored = true;
			if(PlayerPrefs.GetInt("Turn")==0){
				firstPlayerScore += 1;
				score1.text = "Blue : " + firstPlayerScore.ToString ();
				Scorecube2.SetActive (true);
				three = true;
			}
			else if(PlayerPrefs.GetInt("Turn")==1){
				secondPlayerScore += 1;
				score2.text = "Green : " + secondPlayerScore.ToString ();
				Scorecube11.SetActive (true);
				three = true;
			}

		}

		if (!four && cyc8.activeInHierarchy == true && 
			cyc11.activeInHierarchy ==true &&
			cyc12.activeInHierarchy ==true && 
			cyc15 .activeInHierarchy ==true)

		{
			scored = true;
			if(PlayerPrefs.GetInt("Turn")==0){
				firstPlayerScore += 1;
				score1.text = "Blue : " + firstPlayerScore.ToString ();
				Scorecube3.SetActive (true);
				four = true;
			}
			else if(PlayerPrefs.GetInt("Turn")==1){
				secondPlayerScore += 1;
				score2.text = "Green : " + secondPlayerScore.ToString ();
				Scorecube12.SetActive (true);
				four = true;
			}

		}


		if (!five && cyc9.activeInHierarchy == true && 
			cyc13.activeInHierarchy ==true &&
			cyc12.activeInHierarchy ==true && 
			cyc16 .activeInHierarchy ==true)

		{
			scored = true;
			if(PlayerPrefs.GetInt("Turn")==0){
				firstPlayerScore += 1;
				score1.text = "Blue : " + firstPlayerScore.ToString ();
				Scorecube4.SetActive (true);
				five = true;
			}
			else if(PlayerPrefs.GetInt("Turn")==1){
				secondPlayerScore += 1;
				score2.text = "Green : " + secondPlayerScore.ToString ();
				Scorecube13.SetActive (true);
				five = true;
			}

		}


		if (!six && cyc10.activeInHierarchy == true && 
			cyc13.activeInHierarchy ==true &&
			cyc14.activeInHierarchy ==true && 
			cyc17.activeInHierarchy ==true)

		{
			scored = true;
			if(PlayerPrefs.GetInt("Turn")==0){
				firstPlayerScore += 1;
				score1.text = "Blue : " + firstPlayerScore.ToString ();
				Scorecube5.SetActive (true);
				six = true;
			}
			else if(PlayerPrefs.GetInt("Turn")==1){
				secondPlayerScore += 1;
				score2.text = "Green : " + secondPlayerScore.ToString ();
				Scorecube14.SetActive (true);
				six = true;
			}

		}

		if (!seven &&cyc15.activeInHierarchy == true && 
			cyc18.activeInHierarchy ==true &&
			cyc19.activeInHierarchy ==true && 
			cyc22.activeInHierarchy ==true)

		{
			scored = true;
			if(PlayerPrefs.GetInt("Turn")==0){
				firstPlayerScore += 1;
				score1.text = "Blue : " + firstPlayerScore.ToString ();
				Scorecube6.SetActive (true);
				seven = true;
			}
			else if(PlayerPrefs.GetInt("Turn")==1){
				secondPlayerScore += 1;
				score2.text = "Green : " + secondPlayerScore.ToString ();
				Scorecube15.SetActive (true);
				seven = true;
			}

		}


		if (!eight && cyc16.activeInHierarchy == true && 
			cyc20.activeInHierarchy ==true &&
			cyc19.activeInHierarchy ==true && 
			cyc23.activeInHierarchy ==true)

		{
			scored = true;
			if(PlayerPrefs.GetInt("Turn")==0){
				firstPlayerScore += 1;
				score1.text = "Blue : " + firstPlayerScore.ToString ();
				Scorecube7.SetActive (true);
				eight = true;
			}
			else if(PlayerPrefs.GetInt("Turn")==1){
				secondPlayerScore += 1;
				score2.text = "Green : " + secondPlayerScore.ToString ();
				Scorecube16.SetActive (true);
				eight = true;
			}

		}

		if (!nine && cyc17.activeInHierarchy == true && 
			cyc20.activeInHierarchy ==true &&
			cyc21.activeInHierarchy ==true && 
			cyc24.activeInHierarchy ==true)

		{
			scored = true;
			if(PlayerPrefs.GetInt("Turn")==0){
				firstPlayerScore += 1;
				score1.text = "Blue: " + firstPlayerScore.ToString ();
				Scorecube8.SetActive (true);
				nine = true;
			}
			else if(PlayerPrefs.GetInt("Turn")==1){
				secondPlayerScore += 1;
				score2.text = "Green : " + secondPlayerScore.ToString ();
				Scorecube17.SetActive (true);
				nine = true;
			}

		}




		if(!scored && PlayerPrefs.GetInt("clicked")==1){
			if(PlayerPrefs.GetInt("Turn")==0){
				PlayerPrefs.SetInt ("Turn",1);
			}
			else if(PlayerPrefs.GetInt("Turn")==1){
				PlayerPrefs.SetInt ("Turn",0);
			}
			PlayerPrefs.SetInt ("clicked",0);

		}
		if(scored && PlayerPrefs.GetInt("clicked")==1){
			scored = false;
			PlayerPrefs.SetInt ("clicked",0);
		}

	}


	public  void PlayAgain(){
				
		SceneManager.LoadScene (0);

	}

//	public void MakeAMove(){
//		int x = Random.Range (0,24);
//
//	}


	public void MakeAMove(){
		if(Objectlist.Count==0){
			return;
		}
		Debug.Log ("Moved");
		if(Objectlist.Count>0){
			int x = UnityEngine.Random.Range (0,Objectlist.Count);

			if (Objectlist [x].activeInHierarchy) {
				Objectlist.RemoveAt (x);	
				MakeAMove ();
			}

			if(!moved && Objectlist.Count>0){
				Objectlist [x].SetActive (true);
				PlayerPrefs.SetInt ("clicked",1);
				moved = true;
			}
		}

	}

	public void Reset(){
		for (int i=0;i<24;i++){
			getClick [i].SetActive (true);
			Vissible [i].SetActive (false);
			//scoreCube [i].SetActive (true);
		}
	}


}

