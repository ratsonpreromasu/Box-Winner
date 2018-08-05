using UnityEngine;
using System.Collections;

public class Mesh2 : MonoBehaviour
{

	public GameObject mes2;
	public GameObject mes22;


	// Use this for initialization
	void Start ()
	{
		mes2.SetActive (true);
		mes22.SetActive (false);
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
		mes2.SetActive (false);
		mes22.SetActive (true);

	}
}

