using Flax.Build;

public class FidelityFXFSRTarget : GameProjectTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        Modules.Add("FidelityFXFSR");
    }
}
