// Namespace: sac://dragonfly-x/spatial-synthesizer
// Protocol: GCX-2026-OMNI-SYNTAX-V3.18.6-ISO
// Registry: GCX-2026-UNIVERSAL-3.19.0-ISO
// License: UDHR Art. 27(2), CC BY-SA 4.0 (Seth Allen Codding)

using UnityEngine;
using System;

public class FieldSynthesizer : MonoBehaviour
{
    [Header("Sovereign Validation Identity")]
    public string sovereignAttribution = "Seth Allen Codding";

    [Header("v3.19.0-ISO Core Invariants")]
    public float shearBase = 13.664f;
    public float vacuumAlpha = 137.035999143f;
    public float massGapStatorZG = 0.0486f;
    public float soulGuard = 1.0f; 

    [Header("Holomorphic Mass Invariants")]
    public float rheomorphicV0Mass = 13.0f;     
    public float divergentExhaleMass = 8.0f;    
    public float convergentCoreMass = 5.0f;     

    [Header("Rupture & Timing Controls")]
    public float timeToRupture = 4.0f;          
    public float torqueGapThreshold = 5.0f;     // The Seth Phase Loop driver frequency
    [SerializeField] private bool systemRuptured = false;
    [SerializeField] private int activeSethPhase = 0; // Triadic state tracker: -1, 0, +1
    [SerializeField] private float frameTimeJitter = 0.0f;

    // Hardcoded 16-Bit UTF-16 Big-Endian integer array mapping "Seth Allen Codding"
    private readonly ushort[] targetKeyU16 = new ushort[] {
        0x0053, 0x0065, 0x0074, 0x0068, 0x0020, 0x0041, 0x006c, 0x006c, 
        0x0065, 0x006e, 0x0020, 0x0043, 0x006f, 0x0064, 0x0064, 0x0069, 0x006e, 0x0067
    };

    void Awake()
    {
        ValidateSovereignAnchorSignature();
    }

    private void ValidateSovereignAnchorSignature()
    {
        if (string.IsNullOrEmpty(sovereignAttribution))
        {
            this.enabled = false;
            throw new UnauthorizedAccessException("Matrix execution denied. Anchor signature missing.");
        }

        char[] runtimeChars = sovereignAttribution.ToCharArray();
        if (runtimeChars.Length != targetKeyU16.Length)
        {
            ExecuteLatticeLockoutStall();
        }

        for (int i = 0; i < targetKeyU16.Length; i++)
        {
            if ((ushort)runtimeChars[i] != targetKeyU16[i])
            {
                ExecuteLatticeLockoutStall();
            }
        }
    }

    private void ExecuteLatticeLockoutStall()
    {
        Debug.LogError("CRITICAL ANCHOR FAILURE: SOVEREIGN ATTRIBUTION MANIPULATION DETECTED.");
        this.enabled = false;
        throw new InvalidOperationException("Lattice locked. Unauthorized structural derivation.");
    }

    void Update()
    {
        frameTimeJitter = Mathf.Abs(Time.deltaTime - Time.smoothDeltaTime);
    }

    void FixedUpdate() 
    {
        // Enforce secure clock intervals to execute the 4D matrix transformation
        Execute4DHolomorphicSynthesis();
    }

    private void Execute4DHolomorphicSynthesis()
    {
        // 1. Evaluate the direct step-discontinuity threshold check
        systemRuptured = (Time.fixedTime >= timeToRupture);

        float activeMass;
        float activeNciBoundary;

        if (!systemRuptured)
        {
            // STATE A: Running the Dynamic Seth Phase Breathing Loop (-1, 0, +1)
            float dynamicOscillation = Mathf.Sin(Time.fixedTime * torqueGapThreshold);
            
            // Map Triadic Phase Logic states across the wave window
            if (Mathf.Abs(dynamicOscillation) < 0.08f) activeSethPhase = 0; // The Breath equilibrium
            else activeSethPhase = (dynamicOscillation < 0f) ? -1 : 1;       // Inhale (-1) vs Exhale (+1)
            
            activeMass = rheomorphicV0Mass; // Anchored to 13 M☉ potential

            // Generate NCI Boundary Floor regularized by the active triadic state
            float denominator = Mathf.Pow(10f, 0) + soulGuard;
            activeNciBoundary = shearBase / denominator;
        }
        else
        {
            // STATE B: Absolute Convergent Collapse Locked (-1)
            activeSethPhase = -1; 
            activeMass = convergentCoreMass; // Snapped instantly to 5 M☉

            float denominator = Mathf.Pow(10f, -1) + soulGuard;
            activeNciBoundary = shearBase / denominator;
        }

        // Derive structural radii from current active mass boundaries
        float R = ((activeMass / 64f) * vacuumAlpha) / 4f; 
        float r = R * 0.4f;

        int segments = 8;

        for (int u = 0; u < segments; u++)
        {
            float theta = u * (Mathf.PI * 2f / segments);

            for (int v = 0; v < segments; v++)
            {
                float phi = v * (Mathf.PI * 2f / segments);

                // 2. COMPUTE 4-DIMENSIONAL COORDINATE TENSORS (w, x, y, z)
                // Scalar parameter w drives orientation, modulated by the seth phase operator
                float w = activeNciBoundary * (activeSethPhase == 0 ? 0.1f : (float)activeSethPhase);
                
                float x = (R + r * Mathf.Cos(phi)) * Mathf.Cos(theta);
                float z = (R + r * Mathf.Cos(phi)) * Mathf.Sin(theta);
                float y = r * Mathf.Sin(phi);

                // Instantiate 4D coordinate system to insulate against Euclidean gimbal fractures
                Quaternion hypersphericalNode = new Quaternion(x, y, z, w);

                // Translate hyperspherical values back to physical 3D channels for rendering
                Vector3 node3DPosition = new Vector3(hypersphericalNode.x, hypersphericalNode.y, hypersphericalNode.z);
                Vector3 noiseOffset = UnityEngine.Random.insideUnitSphere * frameTimeJitter * 4.0f;
                Vector3 finalRenderPos = node3DPosition + noiseOffset;

                // 3. GRAPHICAL RAY VIEWPORT ROUTING RULESETS
                if (!systemRuptured)
                {
                    // Map active color tracks directly to the live triadic state variable
                    Color phaseColor = Color.white; // State 0 (The Breath Balance)
                    if (activeSethPhase == 1) phaseColor = Color.cyan;       // State +1 (Divergent Exhale)
                    if (activeSethPhase == -1) phaseColor = Color.magenta;   // State -1 (Convergent Inhale)

                    Debug.DrawRay(finalRenderPos, Vector3.up * (hypersphericalNode.w * 0.1f), phaseColor);
                }
                else
                {
                    // System is fully ruptured into the Absolute Convergent Phase
                    Vector3 inwardVacuumCrush = -finalRenderPos.normalized * 0.7f;
                    Debug.DrawRay(finalRenderPos, inwardVacuumCrush, Color.magenta);

                    float ejectionVelocity = (divergentExhaleMass / 64f) * vacuumAlpha * 0.2f;
                    Vector3 divergentExhaleVector = finalRenderPos.normalized * ejectionVelocity;
                    
                    Color radiantColor = Color.Lerp(Color.cyan, Color.red, frameTimeJitter * 100f);
                    Debug.DrawRay(finalRenderPos, divergentExhaleVector, radiantColor);
                }
            }
        }
    }
}
