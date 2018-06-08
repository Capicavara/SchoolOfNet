using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour {

    private Rigidbody2D rb;
    public float velocidade = 10.0f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        float horizontal = Input.GetAxis("Horizontal");
        Vector2 movimento = new Vector2(horizontal, 0);

        rb.MovePosition(rb.position + movimento * velocidade * Time.deltaTime);
	}
}
