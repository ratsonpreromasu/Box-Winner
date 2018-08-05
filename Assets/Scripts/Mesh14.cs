using UnityEngine;
using System.Collections;

public class Mesh14 : MonoBehaviour
{

	public GameObject mes14;
	public GameObject mes1414;


	// Use this for initialization
	void Start ()
	{
		mes14.SetActive (true);
		mes1414.SetActive (false);
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
		mes14.SetActive (false);
		mes1414.SetActive (true);

	}
}

