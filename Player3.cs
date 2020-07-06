using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player3 : MonoBehaviour {

    public float jumpPower;

    // Update is called once per frame; then it might be better to make some scenario of coding
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(Application.loadedLevel);
    }
}
