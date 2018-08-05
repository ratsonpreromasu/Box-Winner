using UnityEngine;
using System.Collections;

public class Mesh15 : MonoBehaviour
{

	public GameObject mes15;
	public GameObject mes1515;


	// Use this for initialization
	void Start ()
	{
		mes15.SetActive (true);
		mes1515.SetActive (false);
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
		mes15.SetActive (false);
		mes1515.SetActive (true);

	}
}

