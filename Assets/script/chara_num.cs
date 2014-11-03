using UnityEngine;
using System.Collections;

public class chara_num : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private static int num = 0;

	public static int chara_num_generate(){
		return chara_num.num++;
	}
}
