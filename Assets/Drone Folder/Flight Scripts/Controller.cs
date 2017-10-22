using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
    private Transform planeTrans;
    float dhaxis;
    float ltaxis;
    float triggers;
    bool reset;
    float acc;
    bool left;
    bool right;
	// Use this for initialization
	void Start () {
	    planeTrans = GetComponent<Transform>();
        acc = 0;
    }

    // Update is called once per frame
    void ControllerCheck()
    {
        dhaxis = Input.GetAxis("Horizontal");
        ltaxis = Input.GetAxis("Vertical");
        reset = Input.GetButtonUp("Reset");
        triggers = Input.GetAxis("Accelaration");
        left = Input.GetButton("LeftButton");
        right = Input.GetButton("RightButton");

    }
    void Update() {
        ControllerCheck();
        //Debug.Log(dhaxis);
        //Debug.Log(ltaxis);
        //Debug.Log(fire);
        
   
        transform.Rotate((float)0.5 * -dhaxis, 0, 0);
        if (left) 
            transform.Rotate(0, -0.3f, 0);
        if (right)
            transform.Rotate(0, 0.3f, 0);
        /*if (transform.rotation.x > 0f)
        {
            transform.Rotate(-0.2f, 0.2f, 0);
        }
        if (transform.rotation.x < 0f)
        {
            transform.Rotate(0.2f, -0.2f, 0);
        }
        */
        transform.Rotate(0, 0, 0.5f * ltaxis);
        //transform.Rotate(0, 0, -0.2f);

        

        acc += (float)(0.15 * triggers);
        Debug.Log(triggers);
        if (acc > 1)
            acc = 1;
        if (acc < -0.2f)
            acc = -0.2f;
        Debug.Log(acc);
        transform.Translate(acc, 0, 0);


    }


}
