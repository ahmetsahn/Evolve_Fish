using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Player_Movement playerMovement;
    [SerializeField]
    private Player_Input playerInput;
    [SerializeField]
    private Player_Renderer playerRenderer;
    public Player_Renderer PlayerRenderer => playerRenderer;

    private Base_Player currentState;
    public Base_Player CurrentState => currentState;
    
    private Green_Fish_State greenFishState = new Green_Fish_State();
    public Green_Fish_State GreenFishState => greenFishState;
    
    private Blue_Fish_State blueFishState = new Blue_Fish_State();
    public Blue_Fish_State BlueFishState => blueFishState;
    
    private Red_Fish_State redFishState = new Red_Fish_State();
    public Red_Fish_State RedFishState => redFishState;

    [SerializeField]
    private GameObject fishBonePrefab;


    private void OnEnable() => Game_Events_System.instance.OnDie += Die;

    
    
    private void Start()
    {
        currentState = greenFishState;
    }
    private void Update()
    {
        playerMovement.Move(playerInput.MousePos);
        playerInput.GetInteractInput();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<IEdible>() != null)
        {
            collision.GetComponent<IEdible>().Eat();
            currentState.OnTriggerEnter2D(this);
        }

        if(collision.GetComponent<IEdibleFish>()!= null)
        {
            collision.GetComponent<IEdibleFish>().Eat(this, GetComponent<Collider2D>());
            currentState.OnTriggerEnter2D(this);
        }
    }

    public void SwitchState(Base_Player state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

    private void Die()
    {
        Instantiate(fishBonePrefab, transform.position, Quaternion.identity);
        
    }
}
