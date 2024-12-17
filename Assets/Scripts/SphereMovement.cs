using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody rb;
    private float hInput;
    private float vInput;
    public static int keyCount;
    void Start()
    {
        Application.targetFrameRate = 120;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(hInput, 0, vInput).normalized * 8, ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            Destroy(other.gameObject);
            keyCount++;
        }

        if (other.gameObject.tag == "Hole")
        {
            this.transform.position = new Vector3(9f, 2f, 3f);
        }
    }
}
