using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerFinder : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject target;

    void Start()
    {
        target= GameObject.Find("Player");
    }

	// Update is called once per frame
	void Update ()
	{
	    if (target != null)
	    {
            transform.LookAt(target.transform);
            transform.Translate(0, 0, (Time.deltaTime * moveSpeed));
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
        }
    }
}
