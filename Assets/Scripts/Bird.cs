using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float push;
    private Rigidbody rb;
    [SerializeField] private float gravityScale = 1f;


    void Start()
    {
       rb = GetComponent<Rigidbody>();
       Physics.gravity *= gravityScale; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * push * Time.deltaTime / gravityScale , ForceMode.Impulse); //force mode comes with a "," not "*"
            
        }
    }

   
}
    
    

