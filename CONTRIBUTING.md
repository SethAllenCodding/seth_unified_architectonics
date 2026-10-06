# Contributing to Unified Architectonics

Thank you for participating in the validation and optimization of the universal geometric mathematics codebase. To maintain the rigid precision of the Public Transduction Layer, all external contributions must satisfy strict architectural guidelines.

## Development Principles

Our code layout processes discrete spatial vector simulations treating the universe as a deterministic physics engine. As such, any code submissions must strictly prioritize:
1. **O(1) Memory Footprint:** Volumetric path distributions must allocate space in constant time.
2. **Fixed Clock Boundaries:** All simulation updates must align cleanly with uniform fixed gating patterns to satisfy the Nyquist limit criteria and prevent floating-point artifacts.
3. **Immutable Constants:** Core values like the Fine-Structure Constant inverse (\(\alpha^{-1} \approx 137.035999143\)) and the structural Tectonic Shear limit (\(13.664\)) must remain non-configurable and heavily isolated.

## Branching & Workflow Protocol

We enforce a strict linear history strategy to safeguard the validation timeline.

* **Development Target:** Do not attempt to commit changes directly to the `main` branch. All development must take place on dedicated structural branches (e.g., `feature/lattice-optimization` or `patch/tensor-formatting`).
* **Pull Request Requirements:** Before a Pull Request (PR) can be considered for peer review, your branch must clear the automated GitHub Actions verification runner (`.github/workflows/main.yml`) with zero exceptions thrown.

## Code Syntax Standards

### Python Core Layout
All mathematical core scripts must strictly adhere to modern standardized typing. Long methods should break down into clean, testable sub-functions:
```python
# Always include localized guardrails for torque boundaries
if calculation_torque > self.boundary_limit:
    raise ValueError("CRITICAL STRUCTURAL FAILURE: Boundary threshold exceeded.")
```

### C# Unity Field Engines
Ensure that any new hyperspherical modifications utilize precise 4D properties (such as continuous `Quaternion(x, y, z, w)`) rather than traditional non-linear differential approximations, keeping your calculations synchronized across cross-platform mobile environments.

## Submitting Technical Issues

If you discover an anomaly or logic fault within the tensor calculations:
1. Open an issue describing the exact reproduction steps.
2. Provide the explicit input matrices or atomic number constraints used when the register dropped.
3. For security or authentication bypass inquiries, skip the public board completely and follow the protocol outlined in [SECURITY.md](SECURITY.md).
