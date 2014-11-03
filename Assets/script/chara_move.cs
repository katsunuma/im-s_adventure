using UnityEngine;
using System.Collections;

public class chara_move : MonoBehaviour {
	public int chara_number;
	// Use this for initialization
	void Start () {
		chara_number = chara_num.chara_num_generate ();
		Vector3[] vector = chara_preset_position.position_generator (chara_number);
		transform.position = vector[0];
		transform.eulerAngles = vector[1];
//		transform.lossyScale = new Vector3(0.5f, 0.5f, 1f);
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
