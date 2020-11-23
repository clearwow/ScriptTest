using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
     private int hp = 100;
     private int power =25;
     private int mp =53;
   
     public void Attack()
     {
        Debug.Log( this.power + "のダメージを与えた" );
     }
     
     public void Defence(int damage)
     {
        Debug.Log( damage+"のダメージを受けた" );
        this.hp-= damage;
     }
     
     public void MagicAttack()
     {
       
     }

}
public class boss : MonoBehaviour
{

    void Start()
    {
        Boss lastboss = new Boss();
      
        lastboss.Attack();

        lastboss.Defence(3);
  
        lastboss.MagicAttack();
 
    }

  
    void Update()
    {
        
    }
}
