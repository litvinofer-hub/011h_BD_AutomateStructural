## Dependency tiers

A class may reference lower tiers only — never its own or higher. Keeps the graph
acyclic.

| Tier | Class | May depend on |
|---|---|---|
| 0 | `Point3d`, `LineSegment2d` | SystemParams |
| 1 | `Vector3d` | tier 0, SystemParams |
| 2 | `LineSegment3d` | tiers 0-1, SystemParams |
| 3 | `Rectangle`, `Polygon` | tiers 0-2, SystemParams |
| 4 | `Box` | tiers 0-3, SystemParams |
| 5 | `VerticalBox` | tiers 0-4, SystemParams |
