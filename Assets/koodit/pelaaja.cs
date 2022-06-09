using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelaaja : MonoBehaviour
{
	
	public CharacterController controller;
	
	public int speed = 5;
	
	private float vaakanopeus = 0f;
	private float pystynopeus = 0f;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		vaakanopeus = Input.GetAxis("Horizontal") * speed;
		pystynopeus = Input.GetAxis("Vertical") * speed;
		
		Vector3 nopeus = new Vector3(vaakanopeus, 0, pystynopeus);
		
		controller.Move(nopeus * Time.deltaTime);
        
    }
}
