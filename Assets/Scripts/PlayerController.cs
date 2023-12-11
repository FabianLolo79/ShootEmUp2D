using UnityEngine;

[System.Serializable] // para mostrar los campos en el inspector de unity
public class Boundary // restringir movimiento fuera de pantalla
{
    public float xMin, xMax, yMin, yMax;
}

public class PlayerController : MonoBehaviour
{
    // variables de movimiento 
    public Movement moverComponent;
    public float speed;
    public Boundary boundary;

    // variables del prefab bala
    public Transform shootOrigin;
    public GameObject shootPrefab;

    private void Start()
    {
        moverComponent.speed = speed;
        InputProvider.OnHasShoot += OnHasShoot;
        InputProvider.OnDirection += OnDirection;
    }

    private void OnDirection(Vector3 direction)
    {
        moverComponent.direction = direction;
        // generamos el movimiento del componente Player
    }

    private void OnHasShoot()
    {
        Instantiate(shootPrefab, shootOrigin, false);
    }

    // Update is called once per frame
    void Update()
    {
        // atrapamos el movimiento que se realice con las flechas de dirección en el eje X e Y
        //Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), transform.position.z);
        //moverComponent.direction = direction; 
        // generamos el movimiento del componente Player

        // 8.2 axis X restringir movimiento fuera de pantalla
        // 4.5 axis Y restringir movimiento fuera de pantalla
        float x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
        float y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
        transform.position = new Vector3(x, y);
    }
}
