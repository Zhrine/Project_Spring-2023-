using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//blank script named interfaces
public interface IMove
{	
    public void Move();
    //anything that uses i move will have a move method
	
}
public interface ITrigger
{
    public void OnTriggerEnter(Collider other);
	
}