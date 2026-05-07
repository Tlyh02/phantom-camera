using Godot;

namespace PhantomCamera.Noise;

public class PhantomCameraNoise3D(Resource resource)
{
    #region Public Field

    public readonly Resource Resource = resource;

    public bool PositionalNoise
    {
        get => (bool)Resource.Call(MethodName.GetPositionalNoise);
        set => Resource.Call(MethodName.SetPositionalNoise, value);
    }

    public bool RandomizeNoiseSeed
    {
        get => (bool)Resource.Call(MethodName.GetRandomizeNoiseSeed);
        set => Resource.Call(MethodName.SetRandomizeNoiseSeed, value);
    }

    public bool RotationalNoise
    {
        get => (bool)Resource.Call(MethodName.GetRotationalNoise);
        set => Resource.Call(MethodName.SetRotationalNoise, value);
    }

    public float Amplitude
    {
        get => (float)Resource.Call(MethodName.GetAmplitude);
        set => Resource.Call(MethodName.SetAmplitude, value);
    }

    public float Frequency
    {
        get => (float)Resource.Call(MethodName.GetFrequency);
        set => Resource.Call(MethodName.SetFrequency, value);
    }

    public float LineMultiplier
    {
        get => (float)Resource.Call(MethodName.GetLineMultiplier);
        set => Resource.Call(MethodName.SetLineMultiplier, value);
    }

    public float PositionalMultiplierX
    {
        get => (float)Resource.Call(MethodName.GetPositionalMultiplierX);
        set => Resource.Call(MethodName.SetPositionalMultiplierX, value);
    }

    public float PositionalMultiplierY
    {
        get => (float)Resource.Call(MethodName.GetPositionalMultiplierY);
        set => Resource.Call(MethodName.SetPositionalMultiplierY, value);
    }

    public float PositionalMultiplierZ
    {
        get => (float)Resource.Call(MethodName.GetPositionalMultiplierZ);
        set => Resource.Call(MethodName.SetPositionalMultiplierZ, value);
    }

    public float RotationalMultiplierX
    {
        get => (float)Resource.Call(MethodName.GetRotationalMultiplierX);
        set => Resource.Call(MethodName.SetRotationalMultiplierX, value);
    }

    public float RotationalMultiplierY
    {
        get => (float)Resource.Call(MethodName.GetRotationalMultiplierY);
        set => Resource.Call(MethodName.SetRotationalMultiplierY, value);
    }

    public float RotationalMultiplierZ
    {
        get => (float)Resource.Call(MethodName.GetRotationalMultiplierZ);
        set => Resource.Call(MethodName.SetRotationalMultiplierZ, value);
    }

    public int NoiseSeed
    {
        get => (int)Resource.Call(MethodName.GetNoiseSeed);
        set => Resource.Call(MethodName.SetNoiseSeed, value);
    }

    public Vector3 LineDirection
    {
        get => (Vector3)Resource.Call(MethodName.GetLineDirection);
        set => Resource.Call(MethodName.SetLineDirection, value);
    }

    #endregion

    #region Public Methods

    public static PhantomCameraNoise3D New()
    {
        Resource resource = new();
#if GODOT4_4_OR_GREATER
        resource.SetScript(GD.Load<GDScript>("uid://cuffvge5ad4aa"));
#else
        resource.SetScript(GD.Load<GDScript>("res://addons/phantom_camera/scripts/resources/phantom_camera_noise_3d.gd"));
#endif
        return new PhantomCameraNoise3D(resource);
    }

    #endregion

    public static class MethodName
    {
        #region Public Field

        public static readonly StringName GetAmplitude = new("get_amplitude");

        public static readonly StringName GetFrequency = new("get_frequency");

        public static readonly StringName GetLineDirection = new("get_line_direction");

        public static readonly StringName GetLineMultiplier = new("get_line_multiplier");

        public static readonly StringName GetNoiseSeed = new("get_noise_seed");

        public static readonly StringName GetPositionalMultiplierX = new("get_positional_multiplier_x");

        public static readonly StringName GetPositionalMultiplierY = new("get_positional_multiplier_y");

        public static readonly StringName GetPositionalMultiplierZ = new("get_positional_multiplier_z");

        public static readonly StringName GetPositionalNoise = new("get_positional_noise");

        public static readonly StringName GetRandomizeNoiseSeed = new("get_randomize_noise_seed");

        public static readonly StringName GetRotationalMultiplierX = new("get_rotational_multiplier_x");

        public static readonly StringName GetRotationalMultiplierY = new("get_rotational_multiplier_y");

        public static readonly StringName GetRotationalMultiplierZ = new("get_rotational_multiplier_z");

        public static readonly StringName GetRotationalNoise = new("get_rotational_noise");
        public static readonly StringName SetAmplitude = new("set_amplitude");
        public static readonly StringName SetFrequency = new("set_frequency");
        public static readonly StringName SetLineDirection = new("set_line_direction");
        public static readonly StringName SetLineMultiplier = new("set_line_multiplier");
        public static readonly StringName SetNoiseSeed = new("set_noise_seed");
        public static readonly StringName SetPositionalMultiplierX = new("set_positional_multiplier_x");
        public static readonly StringName SetPositionalMultiplierY = new("set_positional_multiplier_y");
        public static readonly StringName SetPositionalMultiplierZ = new("set_positional_multiplier_z");
        public static readonly StringName SetPositionalNoise = new("set_positional_noise");
        public static readonly StringName SetRandomizeNoiseSeed = new("set_randomize_noise_seed");
        public static readonly StringName SetRotationalMultiplierX = new("set_rotational_multiplier_x");
        public static readonly StringName SetRotationalMultiplierY = new("set_rotational_multiplier_y");
        public static readonly StringName SetRotationalMultiplierZ = new("set_rotational_multiplier_z");
        public static readonly StringName SetRotationalNoise = new("set_rotational_noise");

        #endregion
    }
}