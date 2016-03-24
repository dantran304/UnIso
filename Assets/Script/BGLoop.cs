using UnityEngine;
using System.Collections;

public class BGLoop : MonoBehaviour {

    public GameObject endPoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Block")
        {
            Debug.Log("BG Looping!!!");
            other.gameObject.transform.position = new Vector3(endPoint.transform.position.x, 
                                                                endPoint.transform.position.y, 
                                                                    endPoint.transform.position.z);
        }
    }
}
