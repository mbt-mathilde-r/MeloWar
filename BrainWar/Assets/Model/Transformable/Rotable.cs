using UnityEngine;

public class Rotable : Transformable
{

    // Rotation methods

    override internal void up()
    {
        rotate(0);
    }

    override internal void down()
    {
        rotate(180);
    }

    override internal void left()
    {
        rotate(90);
    }

    override internal void right()
    {
        rotate(270);
    }

    // Calcul rotation

    private void rotate(float rotation)
    {
        transform.eulerAngles = new Vector3(0, 0, rotation);
    }
}
