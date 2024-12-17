using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class trap : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private float rotationSpeed;
    [SerializeField] private float clockWise;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationDirection = new Vector3(0, 0, 1 * clockWise);
        transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime);
    }
}
