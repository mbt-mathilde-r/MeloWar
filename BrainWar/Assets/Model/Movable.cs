using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : Transformable
{
    public float velocity = 1;

    private float scale = 100;

    // Moves methods

    override internal void up()
    {
        translate(0, velocity);
    }

    override internal void down()
    {
        translate(0, -velocity);
    }

    override internal void left()
    {
        translate(-velocity, 0);
    }

    override internal void right()
    {
        translate(velocity, 0);
    }

    // Calcul move methods

    private void translate(float x, float y)
    {
        transform.Translate(new Vector3(x / scale, y / scale, 0));
    }
}
