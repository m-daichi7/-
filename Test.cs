using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      int hp = 180;
      if(hp <= 50){
        Debug.Log("逃走！");
      } else if(hp >= 200){
        Debug.Log("攻撃！");
      } else{
        Debug.Log("防御！");
      }

      //Vector２同士の減数
      Vector2 playerPos = new Vector2(2.0f, 1.0f);
      Vector2 playerPos = new Vector2(8.0f, 5.0f);
      Vector2 dir = endPos - startPos;
      Debug.Log(dir);

      float len = dir.magnitude;
      Debug.Log(len);
    }

  //playerclassの生成
    public class Player
    {
      private int hp = 100;
      private int power = 50;

      public void Attack(){
        Debug.Log(this.power + "のダメージを与えた");
      }

      public void Damage(int damage)
      {
        this.hp -= damage;
        Debug.Log(damade + "のダメージを受けた");
      }
    }

    public class Tast : MonoBehaviour
    {
      void Start()
      {
        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);
      }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
