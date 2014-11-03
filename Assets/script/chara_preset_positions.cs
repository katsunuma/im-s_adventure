using UnityEngine;
using System.Collections;

public class chara_preset_position : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	static int position_number;

	public static Vector3[] position_generator (int position_number){
		Vector3[] vector = new Vector3[2];
		int position_repoint_number = 3;

		vector[0].x = (float)(position_number * 2 % position_repoint_number);
		vector[0].y = 1.5f;
		vector[0].z = (float)(position_number * 2 / position_repoint_number);

		field.set_field_occupy ((int)vector [0].x, (int)vector [0].z);

		vector [1].x = 45f;
		vector [1].y = 0f;
		vector [1].z = 0f;

		return vector; 
	}


}
