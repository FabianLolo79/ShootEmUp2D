using UnityEngine;

public class InputKeyboardListener : MonoBehaviour, IInputeable
{
    public void GetDirection(Vector3 direction)
    {
        InputProvider.TriggerDirection(direction);
    }

    public void ShootPressed()
    {
        InputProvider.TriggerOnHasShoot();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1")) 
        {
            ShootPressed();
        }
        GetDirection(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }
}
