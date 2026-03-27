using UnityEngine;
using Vuforia;

public class WorldPlazaManager : MonoBehaviour
{
    public GameObject mode1_Buildings;

    private ObserverBehaviour mObserverBehaviour;

    void Start()
    {
        mObserverBehaviour = GetComponent<ObserverBehaviour>();
        if (mObserverBehaviour)
        {
            mObserverBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        bool tracked = status.Status == Status.TRACKED ||
                       status.Status == Status.EXTENDED_TRACKED;

        if (mode1_Buildings)
            mode1_Buildings.SetActive(tracked);
    }
}