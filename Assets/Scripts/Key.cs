using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Key : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private float rotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationDirection = new Vector3(1, 0, 0);
        transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime); 
    }
}
