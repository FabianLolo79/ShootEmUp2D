using UnityEngine;

public interface IInputeable
{
    void ShootPressed();
    //void GetHorizontalAxis(float value);
    //void GetVerticalAxis(float value);

    //m�todo para obtener la direcc�n del GameObjetc
    void GetDirection(Vector3 direction);
}
