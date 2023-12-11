using UnityEngine;

public interface IInputeable
{
    void ShootPressed();
    //void GetHorizontalAxis(float value);
    //void GetVerticalAxis(float value);

    //método para obtener la direccón del GameObjetc
    void GetDirection(Vector3 direction);
}
