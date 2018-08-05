using UnityEngine;
using System.Collections;

public class Mesh5 : MonoBehaviour
{

	public GameObject mes5;
	public GameObject mes55;


	// Use this for initialization
	void Start ()
	{
		mes5.SetActive (true);
		mes55.SetActive (false);
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
		mes5.SetActive (false);
		mes55.SetActive (true);

	}
}

