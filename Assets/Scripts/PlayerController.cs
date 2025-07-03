using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 20;
    private Vector3 projectileSpawnPositon;
    public GameObject projectilePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Controller input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * horizontalInput * Time.deltaTime * speed);



        //Set the limits of player's movement
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }



        //launch a prjectile from player by space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Offset the Y axis for a more realistic bottle flight
            projectileSpawnPositon = transform.position + new Vector3(0, 0.7f, 0);
            //Spawn a projectile
            Instantiate(projectilePrefab, projectileSpawnPositon, projectilePrefab.transform.rotation);
        }
    }
}
