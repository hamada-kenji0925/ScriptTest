using UnityEngine;
using System.Collections;


public class Boss{
	private int hp=100;			//体力
	private int power = 25;		//攻撃力
	private int mp = 53;		//マジックポイント

	//攻撃用の関数
	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	//防御用の関数
	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");

		//残りHPを減らす
		this.hp -= damage;

	}

	//魔法用の関数
	public void Magic(){
		if (this.mp >= 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {
	// Use this for initialization
	void Start () {

		//発展課題用Bossクラス宣言
		Boss lastboss = new Boss();

		Debug.Log ("課題：配列を宣言して出力しましょう");
		int[] array = {10,20,30,40,50 };

		Debug.Log ("配列array順番出力");

		//配列arrayの中身を順番に出力
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		Debug.Log ("配列array逆順出力");

		//配列arrayの中身を逆順で出力
		for (int i = 4; i >= 0; i--) {
			Debug.Log (array [i]);
		}

		Debug.Log ("発展課題");

		for (int i = 0; i <= 10; i++) {
			lastboss.Magic ();
		}
			

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
