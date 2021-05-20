using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public float mouseSensitivityY = 1;
    public float mouseSensitivityX = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            this.transform.Translate(Vector3.forward * Time.deltaTime);
	    Debug.Log("Movete palante");
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            this.transform.Translate(Vector3.back * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.transform.Rotate(Vector3.up, -10);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            this.transform.Rotate(Vector3.up, 10);
        }


        if (Input.GetKey(KeyCode.Q)) {
            Debug.Log("Rompete esfera");
            Destroy(gameObject);
        }

    }
}
