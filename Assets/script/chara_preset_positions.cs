using UnityEngine;
using System.Collections;

public class chara_preset_position : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	static int position_number = 0;

	public static Vector3[] position_generator (){
		Vector3[] vector = new Vector3[2];
		int position_repoint_number = 3;

		vector[0].x = (float)(chara_preset_position.position_number % position_repoint_number);
		vector[0].y = 1.55f;
		vector[0].z = (float)(chara_preset_position.position_number / position_repoint_number);

		vector [1].x = 20f;
		vector [1].y = 0f;
		vector [1].z = 0f;

		chara_preset_position.position_number++;
		return vector; 
	}


}
