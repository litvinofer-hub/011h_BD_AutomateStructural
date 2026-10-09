## Dependency tiers

A class may reference lower tiers only — never its own or higher. Keeps the graph
acyclic.

| Tier | Class | May depend on |
|---|---|---|
| 0 | `LengthUnit`, `LengthTolerance`, `AngleTolerance` | nothing |
| 1 | `Units` | tier 0 |

The unit a model is drawn in, and how close two values must be to count as equal, are
what everything else is measured against, so they sit under the whole project and
depend on none of it.
