using UnityEngine;
using System.Collections;

public class field : MonoBehaviour {

	static int[,] field_property;
	static int[,] field_occupy;

	// Use this for initialization
	void Start () {
		int width = 30;
		int height = 30;
        field_property = new int[width,height];
		field_occupy = new int[width,height];
		field_property = field_property_data (width, height);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	//とりあえず全部1入れとく
	int[,] field_property_data(int width, int height){
		int[,] data = new int[width, height];
		for (int i = 0; i < width; i++) {
			for (int j = 0; j < height; j++) {
				data[i,j] = 1;
			}
		}
		return data;
 	}

	public static void set_field_occupy(int x, int z){
		field.field_occupy [x, z] = 1;
	}

	public static void del_field_occupy(int x, int z){
		field.field_occupy [x, z] = 0;
	}

	public static int get_field_occupy(int x, int z){
		return field.field_occupy [x, z];
	}

}
