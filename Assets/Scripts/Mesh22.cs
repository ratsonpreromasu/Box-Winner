using UnityEngine;
using System.Collections;

public class Mesh22 : MonoBehaviour
{

	public GameObject mes22;
	public GameObject mes2222;


	// Use this for initialization
	void Start ()
	{
		mes22.SetActive (true);
		mes2222.SetActive (false);
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
		mes22.SetActive (false);
		mes2222.SetActive (true);

	}
}

