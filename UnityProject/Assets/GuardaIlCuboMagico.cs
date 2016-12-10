using UnityEngine;
using System.Collections;

public class GuardaIlCuboMagico : MonoBehaviour {

    GameObject cube;
    Camera cam;

	// Use this for initialization
	void Start () {
        cube = GameObject.Find("Ciao sono un cubo magico roteante");
        cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        cam.transform.LookAt(cube.transform);
	}
}
