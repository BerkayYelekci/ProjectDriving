using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedGainPS = 0.3f;
    [SerializeField] private float turnSpeed = 100f;

    private int steerValue;

    void Update()
    {
        speed += speedGainPS * Time.deltaTime;
        transform.Rotate(0f, steerValue*turnSpeed, 0f);
        transform.Translate(Vector3.forward * speed*Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("MenuScene");
        }
    }

    public void Steer(int value)
    {
        steerValue = value;
        
    }
}
