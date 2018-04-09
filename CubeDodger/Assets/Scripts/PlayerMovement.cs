using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera c1;
    public Camera c2;
    public float playerSpeed = 10f;

    void Start()
    {
        c1.gameObject.SetActive(true);
        c2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
	    var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
	    var z = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;

	    transform.Rotate(0, x, 0);
	    transform.Translate(0, 0, z);
    }

    void OnDestroy()
    {
        if(c1 != null)
            c1.gameObject.SetActive(false);
        c2.gameObject.SetActive(true);
    }
}
