using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public int speed;
    public Object projectile;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

    
        if (Input.GetButtonDown("Fire1"))
        {
            //Old
            //Rigidbody clone;
            //clone = Instantiate(projectile, new Vector2(transform.position.x, transform.position.y + 0.3f), transform.rotation) as Rigidbody;
        }
      if (Input.GetMouseButton(0))
        {

        }

    }
}
