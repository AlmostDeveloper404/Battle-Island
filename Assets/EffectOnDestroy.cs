using UnityEngine;

public class EffectOnDestroy : MonoBehaviour
{
    public GameObject DestroyEffect;

    public void OnDestroy()
    {
        GameObject effect= Instantiate(DestroyEffect,transform.position,Quaternion.identity);
        Destroy(effect,2f);
    }
}
