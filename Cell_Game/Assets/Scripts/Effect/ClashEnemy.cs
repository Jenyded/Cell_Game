using UnityEngine;

public class ClashEnemy : Clash
{
    public override void ClashCollisionWithObject(string tag)
    {
        if (tag.Equals("PlayerTag"))
        {
            EnableEffect();
            if (!AudioListener.pause)
            {
                AudioManager.instance.Play("Sound_Panel");
            }
            base.BaseDestroy();
        }

        if (tag.Equals("Finish_panelTag"))
        {
            EnableEffect();
            if (!AudioListener.pause)
            {
                AudioManager.instance.Play("Sound_Panel");
            }
            base.BaseDestroy();
        }
    }

    public override void EnableEffect()
    {
        Effect.SetActive(true);
        Instantiate(Effect, transform.position, Quaternion.identity);
    }
}
