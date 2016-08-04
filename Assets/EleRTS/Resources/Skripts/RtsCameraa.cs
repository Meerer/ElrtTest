using UnityEngine;
using System.Collections;

public class RtsCameraa : MonoBehaviour {
   
   
    public float scrollingSpeed;
    public Vector2 mp = Vector2.zero;
	// Use this for initialization
	void Start () {
        scrollingSpeed = 5f;
    }
	
	// Update is called once per frame
	void Update () {
        mp = Input.mousePosition;
        
        if(mp.x == 0 || mp.y == 0 || mp.x == Screen.width || mp.y == Screen.height)
        {
            Debug.Log("This shold now move");
            scaleMP();
            mp.Normalize();
            mp *= scrollingSpeed;


            moveCamera();
        }
    }
   public void moveCamera()
   {
        this.transform.Translate(mp * Time.deltaTime);
   }
    public void scaleMP()
    {
        mp.x -= Screen.width / 2;
        mp.y -= Screen.height / 2;
    }
}
