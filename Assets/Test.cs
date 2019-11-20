using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
        
    public class Boss
    {
        private int hp = 100;
        private int power = 25;
        private int mp = 53;

        public void Attack (){
            Debug.Log(this.power + "のダメージを与えた");
        }

        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            this.hp -= damage;
        }

        public void Magic()
        {
            if (mp >= 5)
            {
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りＭＰは" + mp);
            }
            else
            {
                Debug.Log("ＭＰが足りないため魔法が使えない。");
            }
        }
    }

    // Use this for initialization
    void Start() {
        int[] array = { 30,20,10,50,80};
        
        for (int i = 0;i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = array.Length - 1; i >= 0;i--)
        {
            Debug.Log(array[i]);
        }
        Boss lastboss = new Boss();
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
