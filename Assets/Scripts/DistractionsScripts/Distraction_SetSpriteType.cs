using UnityEngine;
using System.Collections;

public class Distraction_SetSpriteType : MonoBehaviour {

    int state = 0;
    Distraction_Stats distractionStatsScript;

    public SpriteRenderer spriteRenderer;

    public Sprite fly1;
    public Sprite fly2;
    public Sprite fly3;
    public Sprite soundWave1;
    public Sprite soundWave2;
    public Sprite soundWave3;
    public Sprite smell1;
    public Sprite smell2;
    public Sprite smell3;
    public Sprite smell4;
    
    // Use this for initialization
	void Start () {
	    distractionStatsScript = GetComponent<Distraction_Stats>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(state == 0) {
            if(distractionStatsScript.distractionType != Distraction_Stats.DistractionType.NULL) {
                state = 1;
            }
        }

        if(state == 1) {
            if (distractionStatsScript.distractionType == Distraction_Stats.DistractionType.Noise)
            {
                int rand = Random.Range(1, 4);
                if (rand == 1)
                {
                    spriteRenderer.sprite = soundWave1;
                }
                else if (rand == 2)
                {
                    spriteRenderer.sprite = soundWave2;
                }
                else if (rand == 3)
                {
                    spriteRenderer.sprite = soundWave3;
                }
                state = 2;
            }

            else if (distractionStatsScript.distractionType == Distraction_Stats.DistractionType.Smell)
            {
                int rand = Random.Range(1, 5);
                if (rand == 1)
                {
                    spriteRenderer.sprite = smell1;
                }
                else if (rand == 2)
                {
                    spriteRenderer.sprite = smell2;
                }
                else if (rand == 3)
                {
                    spriteRenderer.sprite = smell3;
                }
                else if (rand == 4)
                {
                    spriteRenderer.sprite = smell4;
                }
                state = 2;
            }

            else if (distractionStatsScript.distractionType == Distraction_Stats.DistractionType.Projectile)
            {
                int rand = Random.Range(1, 4);
                if (rand == 1)
                {
                    spriteRenderer.sprite = fly1;
                }
                else if (rand == 2)
                {
                    spriteRenderer.sprite = fly2;
                }
                else if (rand == 3)
                {
                    spriteRenderer.sprite = fly3;
                }

                state = 2;
            }
        }

        if(state == 2) {
            Debug.Log("derp");
        }
	}
}
