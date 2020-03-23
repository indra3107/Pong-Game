using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pemain2 : MonoBehaviour
{

	public int Speed;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
 
if (Input.GetKey (KeyCode.DownArrow)) { // Fungsi untuk mendapatkan kode Keyboard D.
 transform.Translate (Vector2.down * Speed * Time.deltaTime); //Fungsi untuk gerakan karakter ke kanan sesuai dengan kecepatan input.
 
}
if (Input.GetKey (KeyCode.UpArrow)) { // Fungsi untuk mendapatkan kode Keyboard D.
 transform.Translate (Vector2.up * Speed * Time.deltaTime); //Fungsi untuk gerakan karakter ke kanan sesuai dengan kecepatan input.
 
}
}
}