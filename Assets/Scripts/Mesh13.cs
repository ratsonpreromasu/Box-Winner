using UnityEngine;
using System.Collections;

public class Mesh13 : MonoBehaviour
{

	public GameObject mes13;
	public GameObject mes1313;


	// Use this for initialization
	void Start ()
	{
		mes13.SetActive (true);
		mes1313.SetActive (false);
	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void OnMouseDown(){
		PlayerPrefs.SetInt ("clicked",1);
//		if(PlayerPrefs.GetInt("Turn")==0){
//			PlayerPrefs.SetInt ("Turn",1);
//		}
//		else if(PlayerPrefs.GetInt("Turn")==1){
//			PlayerPrefs.SetInt ("Turn",0);
//		}
		mes13.SetActive (false);
		mes1313.SetActive (true);

	}
}

