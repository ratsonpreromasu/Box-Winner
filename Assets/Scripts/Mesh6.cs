using UnityEngine;
using System.Collections;

public class Mesh6 : MonoBehaviour
{

	public GameObject mes6;
	public GameObject mes66;


	// Use this for initialization
	void Start ()
	{
		mes6.SetActive (true);
		mes66.SetActive (false);
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
		mes6.SetActive (false);
		mes66.SetActive (true);

	}
}

