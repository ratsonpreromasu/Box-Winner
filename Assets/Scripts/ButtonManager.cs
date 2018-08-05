using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
	public GameObject FirstPage;
	public GameObject SingleTwo;
	public GameObject EasyHard;
	public GameObject SingleTwoLeft;
	public GameObject FirstPageTurnLeft;
	public GameObject BGI;
	public GameObject FirstPageTurnRight;
	public GameObject SingleTwoRight;



	public GameObject PlayScene;
	public GameObject playback;








	void Start ()
	{
		PlayerPrefs.SetInt ("Start", 0);
		PlayerPrefs.SetInt ("AIPlayer",0);

		SingleTwo.SetActive (false);
		EasyHard.SetActive (false);
		SingleTwoLeft.SetActive (false);
		FirstPageTurnLeft.SetActive (false);

		FirstPageTurnRight.SetActive (false);
		SingleTwoRight.SetActive (false);
		PlayScene.SetActive (false);
		playback.SetActive (false);



	
	}
	
	// Update is called once per frame
	void Update ()
	{


	
	}

	public void Quit(){



		FirstPageTurnRight.SetActive (true);
		FirstPageTurnLeft.SetActive (false);
		StartCoroutine("WaitThreeSeconds");



	}

	IEnumerator WaitThreeSeconds(){

		yield return new WaitForSeconds (3);
		Application.Quit ();

	}



	public  void CoverClick(){
		
		FirstPage.SetActive (false);	
		SingleTwo.SetActive (true);
		FirstPageTurnLeft.SetActive (true);


	}

	public void SinglePlayer(){

		PlayerPrefs.SetInt ("AIPlayer",1);
		FirstPage.SetActive (false);
		SingleTwo.SetActive (false);
		EasyHard.SetActive (false);
		SingleTwoLeft.SetActive (false);
		FirstPageTurnLeft.SetActive (true);
		BGI.SetActive (false);


		FirstPageTurnRight.SetActive (false);
		SingleTwoRight.SetActive (false);
		SingleTwoLeft.SetActive (true);
		PlayScene.SetActive (true);
		StartCoroutine ("back3");


//		SingleTwo.SetActive (false);
//		EasyHard.SetActive (true);
//		SingleTwoLeft.SetActive (true);


	}

	public void back(){

		SingleTwoRight.SetActive (true);

	   
		SingleTwoLeft.SetActive (false);		
		EasyHard.SetActive (true);
		SingleTwo.SetActive (true); 
		StartCoroutine("back2");		 

	}

	IEnumerator back2(){

		yield return new WaitForSeconds (3);
		SingleTwoRight.SetActive (false);
		EasyHard.SetActive (false);



	}

	public  void PlayingScene(){

		FirstPage.SetActive (false);
		SingleTwo.SetActive (false);
		EasyHard.SetActive (false);
		SingleTwoLeft.SetActive (false);
		FirstPageTurnLeft.SetActive (true);
		BGI.SetActive (false);


		FirstPageTurnRight.SetActive (false);
		SingleTwoRight.SetActive (false);
		SingleTwoLeft.SetActive (true);
	    PlayScene.SetActive (true);
		StartCoroutine ("back3");



	}

	IEnumerator back3(){
		yield return new WaitForSeconds (1.5f);
		playback.SetActive (true);
		PlayerPrefs.SetInt ("Start",1);
	
	}

	public void playbackfunc()
	{
//		BGI.SetActive (true);
//		SingleTwo.SetActive (true);
//		FirstPageTurnLeft.SetActive (true);
//		PlayScene.SetActive (false);
//		playback.SetActive (false);
//		PlayerPrefs.SetInt ("Start",0);
		SceneManager.LoadScene (0);





	}


}


