using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour {

    public int shotLimit;
    int shotNum;

    SpriteRenderer sprRend; 

    public GameMaster gMaster;

	// Use this for initialization
	void Start ()
    {
        sprRend = GetComponent<SpriteRenderer>();
  
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (shotNum >= shotLimit)
        {
            print("Finish");

            //gMaster.completedActivity = true;
        }

		
	}

    void OnMouseDown()
    {
        //  print("Fire");

        sprRend.color = Color.red;

        shotNum += 1;
    }

    private void OnMouseUp()
    {
        sprRend.color = Color.white;
    }
}
