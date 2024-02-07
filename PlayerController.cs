using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// SCRIPT TO HANDLE HANDLE PLAYER CONTROL //
// SCRIPT TO HANDLE HANDLE PLAYER CONTROL //
// SCRIPT TO HANDLE HANDLE PLAYER CONTROL //
// SCRIPT TO HANDLE HANDLE PLAYER CONTROL //
// ALSO USED TO STOP THE PLAYER FROM GOING OUT OF BOUNDS //
// ALSO USED TO SPAWN PIZZA PROJECTILES //
// ALSO USED FOR HEALTH CONTROL //




public class PlayerController : MonoBehaviour {
    // Referencing GameOverScreen
    GameOverScreen gameover;
    
    
    // Variables for Health Information
    public int maxHealth = 100;
    public int currentHealth;
    
    
    // public variable for horizontal input
    public float horizontalInput;
    
    // Public variable for player speed
    public float speed = 10.0f;
    
    // we'll make a variable for the projectile prefab
    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start() {
        currentHealth = 100;

    }

    // Update is called once per frame => this is all the time that the player moves
    void Update() {
        // Get the horizontal input // this gets the horizontal input from the player
        horizontalInput = Input.GetAxis("Horizontal");
        // Translates movement to the left or right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // if the player goes to the position x > 10 or x < -10, the player will stop moving
        if (transform.position.x > 10)
        {
            transform.position = new Vector3( 10, transform.position.y, transform.position.z );
        }
        if (transform.position.x < -10)
        {
            transform.position = new Vector3( -10, transform.position.y, transform.position.z );
        }
        // if the player presses space, the projectile pizza will spawn
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // instantiate makes the projectile spawn
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        

    }
}
    

